Option Explicit On

Imports System.Data.Odbc

#Region "数据库语法介绍"
'读取："Select * From 表名称"
'"Select * From 用户数据"

'筛选："Select * From 表名称 Where 条件"
'"Select * From 用户数据 Where 列头部文字 In ('数据1','数据2','数据3')"
'"Select * From 用户数据 Where 列头部文字 Between '数值1' And '数值2'"

'编辑："Update 表名称 Set 列头部文字1='数据1',列头部文字2='数据2'[,列头部文字n='数据n'] Where 条件"
'"Update 用户数据 Set 姓名='小眼',学号='20148110XXX' Where 手机号码='15824734237'"

'添加："Insert Into 表名称 (列头部文字1,列头部文字2,列头部文字3) Valuess ('数据1','数据2','数据3')"
'"Insert Into 表名称 (姓名,手机号码,学号) Valuess ('小眼','15824734XXX','20148110XXX')"

'清空："Delete From 表名称"
'"Delete From 用户数据"

'删除："Delete From 表名称 Where 条件"
'"Delete From用户数据 Where 学号='20148110XXX'"
#End Region


Public Class AccessWindow
    Private Const AccessUserName As String = "XiaoYan"              '数据库账户
    Private Const AccessPassword As String = "2543280836"       '数据库密码  
    Private Const AccessFilePath As String = "\Data.mdb"               '数据库文件末端路径 ”Application.StartupPath & AccessFilePath“

    Dim StrConn As String = "driver={microsoft access driver (*.mdb)};uid=" & AccessUserName & ";pwd=" & AccessPassword & ";dbq=" & Application.StartupPath & AccessFilePath
    Dim OdbcConn As New OdbcConnection(StrConn)
    Dim ListName As String = "用户数据"  '*.mdb里的表名
    Dim OdbcData As New OdbcDataAdapter("Select * From " & ListName, OdbcConn)
    Dim SetData As New DataSet
    Dim CommandBuilder As New OdbcCommandBuilder(OdbcData)

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        OdbcConn.Close()   '关闭数据库
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OdbcConn.Open()   '打开数据库
        LoadAccessData() '程序运行 自动读取数据库
    End Sub

    Private Sub LoadAccessData()
        UsersData.Rows.Clear()
        Dim Index As Integer = 0
        '加载数据库数据
        Dim OdbcListData As New OdbcCommand("Select * From " & ListName, OdbcConn)
        Dim GetOdbcData As OdbcDataReader = OdbcListData.ExecuteReader()
        Do While GetOdbcData.Read
            UsersData.Rows.Add(GetOdbcData("姓名").ToString, GetOdbcData("手机号码").ToString, GetOdbcData("照片").ToString)
            UsersData.Rows(Index).HeaderCell.Value = Str(Index + 1).Trim
            Index += 1
        Loop
    End Sub

    Private Sub SaveAccessData() '保存数据库数据
        '清空表里所有数据再写入数据，实现覆盖写入；删除以下三行则是追加写入
        OdbcData = New OdbcDataAdapter("Delete * From " & ListName, OdbcConn)
        CommandBuilder = New OdbcCommandBuilder(OdbcData)
        OdbcData.Fill(SetData, ListName)
        '

        '写入全部数据
        OdbcData = New OdbcDataAdapter("Select * From " & ListName, OdbcConn)
        CommandBuilder = New OdbcCommandBuilder(OdbcData)
        OdbcData.Fill(SetData, ListName)
        OdbcData.InsertCommand = CommandBuilder.GetInsertCommand
        Dim Index As Integer = 0
        With SetData.Tables(ListName)
            For Index = 0 To UsersData.Rows.Count - 2
                Dim RowDataTemp As DataRow = .NewRow
                RowDataTemp("姓名") = UsersData.Rows(Index).Cells(0).Value
                RowDataTemp("手机号码") = UsersData.Rows(Index).Cells(1).Value
                .Rows.Add(RowDataTemp)
            Next
        End With
        OdbcData.Update(SetData.Tables(ListName))

        LoadAccessData() '重新加载数据库数据
    End Sub

    Public Sub AddAccessData(ByVal UserName As String, ByVal UserTelephone As String, ByVal UserPhoto() As Byte)
        '添加数据库数据_(储存数据的数组)
        OdbcData = New OdbcDataAdapter("Select * From " & ListName, OdbcConn)
        CommandBuilder = New OdbcCommandBuilder(OdbcData)
        OdbcData.Fill(SetData, ListName)
        OdbcData.InsertCommand = CommandBuilder.GetInsertCommand

        Dim RowDataTemp As DataRow = SetData.Tables(ListName).NewRow

        RowDataTemp("姓名") = UserName
        RowDataTemp("手机号码") = UserTelephone
        RowDataTemp("照片") = UserPhoto

        SetData.Tables(ListName).Rows.Add(RowDataTemp)

        OdbcData.Update(SetData.Tables(ListName))
    End Sub

    Private Sub DeleteAccessData(ByVal RowIndex As Integer)
        '删除数据库数据_(要删除条目的标识)
        OdbcData = New OdbcDataAdapter("Delete From " & ListName & " Where 手机号码='" & UsersData.Rows(RowIndex).Cells(1).Value & "'", OdbcConn)
        CommandBuilder = New OdbcCommandBuilder(OdbcData)
        OdbcData.Fill(SetData, ListName)
    End Sub

    Public Sub EditAccessData(ByVal RowIndex As Integer, ByVal DataArray() As String)
        '编辑数据库数据_(要编辑条目的标识，储存数据的数组)
        OdbcData = New OdbcDataAdapter("Update " & ListName & " Set 姓名='" & DataArray(0) & "',手机号码='" & DataArray(1) & "' Where 手机号码='" & UsersData.Rows(RowIndex).Cells(1).Value & "'", OdbcConn)
        CommandBuilder = New OdbcCommandBuilder(OdbcData)
        OdbcData.Fill(SetData, ListName)
    End Sub

    Private Sub 删除条目ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim IndexNow As Integer = UsersData.CurrentRow.Index '记录当前激活的条目的ID

        If IndexNow = UsersData.Rows.Count - 1 Then Exit Sub '有些用户手贱，把焦点放在最后不是数据的行

        If MsgBox("真的要删除 [" & UsersData.Rows(IndexNow).Cells(0).Value & "] 吗？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "确定删除？") = vbYes Then
            DeleteAccessData(IndexNow) '删除数据库里的条目
            UsersData.Rows.RemoveAt(IndexNow) '在控件里删除条目

            For IndexNow = IndexNow To UsersData.Rows.Count - 2
                UsersData.Rows(IndexNow).HeaderCell.Value = Str(IndexNow + 1).Trim
            Next
        End If
    End Sub

    Private Sub 修改条目ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        '输入新用户的数据
        Dim Index As Integer = 0
        Dim IndexNow As Integer = UsersData.CurrentRow.Index '记录当前激活的条目的ID
        If IndexNow = UsersData.Rows.Count - 1 Then Exit Sub '有些用户手贱，把焦点放在最后不是数据的行

        Dim Data(UsersData.Columns.Count) As String
        For Index = 0 To UsersData.Columns.Count - 1
            Data(Index) = InputBox("请输入新用户的" & UsersData.Columns(Index).HeaderText.Trim & "：" & vbCrLf & "(为空则取消添加新用户)", "输入数据：", UsersData.Rows(IndexNow).Cells(Index).Value)
            If Data(Index) = vbNullString Then Exit Sub
        Next

        For Index = 0 To UsersData.Rows.Count - 2
            If UsersData.Rows(Index).Cells(1).Value = Data(1) And Index <> IndexNow Then
                MsgBox("该号码已被注册，请重新输入！")
            End If
        Next

        EditAccessData(IndexNow, Data)

        LoadAccessData()
    End Sub

    Private Sub btnReLoad_Click(sender As Object, e As EventArgs) Handles btnReLoad.Click
        '重新加载数据库
        LoadAccessData()
    End Sub

    Private Sub btnSaveAccess_Click(sender As Object, e As EventArgs) Handles btnSaveAccess.Click
        '保存数据库
        SaveAccessData()
    End Sub

    Private Sub btnExitMe_Click(sender As Object, e As EventArgs) Handles btnExitMe.Click
        OdbcConn.Close()   '关闭数据库
        End
    End Sub

    Private Sub btnAddData_Click(sender As Object, e As EventArgs) Handles btnAddData.Click
        AddNewData.Show(Me)
    End Sub

    Private Sub UsersData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersData.CellContentClick

    End Sub

    Private Sub UsersData_SelectionChanged(sender As Object, e As EventArgs) Handles UsersData.SelectionChanged
        On Error Resume Next
        Dim B() As Byte = UsersData.Rows(UsersData.CurrentRow.Index).Cells(2).Value
        Dim S As New System.IO.MemoryStream(B)
        picUserPhoto.Image = System.Drawing.Image.FromStream(S)
    End Sub
End Class
