<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccessWindow
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UsersData = New System.Windows.Forms.DataGridView()
        Me.btnReLoad = New System.Windows.Forms.Button()
        Me.btnSaveAccess = New System.Windows.Forms.Button()
        Me.btnAddData = New System.Windows.Forms.Button()
        Me.btnEditData = New System.Windows.Forms.Button()
        Me.btnDeleteData = New System.Windows.Forms.Button()
        Me.picUserPhoto = New System.Windows.Forms.PictureBox()
        Me.btnExitMe = New System.Windows.Forms.Button()
        Me.LstUsersName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LstTelephone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.UsersData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUserPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsersData
        '
        Me.UsersData.BackgroundColor = System.Drawing.Color.White
        Me.UsersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LstUsersName, Me.LstTelephone, Me.UserName})
        Me.UsersData.Location = New System.Drawing.Point(12, 12)
        Me.UsersData.Name = "UsersData"
        Me.UsersData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.UsersData.RowTemplate.Height = 23
        Me.UsersData.Size = New System.Drawing.Size(300, 369)
        Me.UsersData.TabIndex = 0
        '
        'btnReLoad
        '
        Me.btnReLoad.Location = New System.Drawing.Point(318, 238)
        Me.btnReLoad.Name = "btnReLoad"
        Me.btnReLoad.Size = New System.Drawing.Size(79, 36)
        Me.btnReLoad.TabIndex = 2
        Me.btnReLoad.Text = "重新加载"
        Me.btnReLoad.UseVisualStyleBackColor = True
        '
        'btnSaveAccess
        '
        Me.btnSaveAccess.Enabled = False
        Me.btnSaveAccess.Location = New System.Drawing.Point(403, 238)
        Me.btnSaveAccess.Name = "btnSaveAccess"
        Me.btnSaveAccess.Size = New System.Drawing.Size(79, 36)
        Me.btnSaveAccess.TabIndex = 3
        Me.btnSaveAccess.Text = "保存数据"
        Me.btnSaveAccess.UseVisualStyleBackColor = True
        '
        'btnAddData
        '
        Me.btnAddData.Location = New System.Drawing.Point(318, 280)
        Me.btnAddData.Name = "btnAddData"
        Me.btnAddData.Size = New System.Drawing.Size(79, 36)
        Me.btnAddData.TabIndex = 4
        Me.btnAddData.Text = "添加数据"
        Me.btnAddData.UseVisualStyleBackColor = True
        '
        'btnEditData
        '
        Me.btnEditData.Location = New System.Drawing.Point(403, 280)
        Me.btnEditData.Name = "btnEditData"
        Me.btnEditData.Size = New System.Drawing.Size(79, 36)
        Me.btnEditData.TabIndex = 5
        Me.btnEditData.Text = "编辑数据"
        Me.btnEditData.UseVisualStyleBackColor = True
        '
        'btnDeleteData
        '
        Me.btnDeleteData.Location = New System.Drawing.Point(318, 322)
        Me.btnDeleteData.Name = "btnDeleteData"
        Me.btnDeleteData.Size = New System.Drawing.Size(79, 36)
        Me.btnDeleteData.TabIndex = 6
        Me.btnDeleteData.Text = "删除数据"
        Me.btnDeleteData.UseVisualStyleBackColor = True
        '
        'picUserPhoto
        '
        Me.picUserPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picUserPhoto.Location = New System.Drawing.Point(316, 12)
        Me.picUserPhoto.Name = "picUserPhoto"
        Me.picUserPhoto.Size = New System.Drawing.Size(166, 212)
        Me.picUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picUserPhoto.TabIndex = 9
        Me.picUserPhoto.TabStop = False
        '
        'btnExitMe
        '
        Me.btnExitMe.Location = New System.Drawing.Point(403, 322)
        Me.btnExitMe.Name = "btnExitMe"
        Me.btnExitMe.Size = New System.Drawing.Size(79, 36)
        Me.btnExitMe.TabIndex = 10
        Me.btnExitMe.Text = "退出"
        Me.btnExitMe.UseVisualStyleBackColor = True
        '
        'LstUsersName
        '
        Me.LstUsersName.HeaderText = "姓名"
        Me.LstUsersName.Name = "LstUsersName"
        '
        'LstTelephone
        '
        Me.LstTelephone.HeaderText = "手机号码"
        Me.LstTelephone.Name = "LstTelephone"
        '
        'UserName
        '
        Me.UserName.HeaderText = "照片"
        Me.UserName.Name = "UserName"
        Me.UserName.Visible = False
        '
        'AccessWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 394)
        Me.Controls.Add(Me.btnExitMe)
        Me.Controls.Add(Me.picUserPhoto)
        Me.Controls.Add(Me.btnDeleteData)
        Me.Controls.Add(Me.btnEditData)
        Me.Controls.Add(Me.btnAddData)
        Me.Controls.Add(Me.btnSaveAccess)
        Me.Controls.Add(Me.btnReLoad)
        Me.Controls.Add(Me.UsersData)
        Me.Name = "AccessWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB.Net 操作本地Access数据库"
        CType(Me.UsersData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUserPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UsersData As System.Windows.Forms.DataGridView
    Friend WithEvents btnReLoad As System.Windows.Forms.Button
    Friend WithEvents btnSaveAccess As System.Windows.Forms.Button
    Friend WithEvents btnAddData As System.Windows.Forms.Button
    Friend WithEvents btnEditData As System.Windows.Forms.Button
    Friend WithEvents btnDeleteData As System.Windows.Forms.Button
    Friend WithEvents picUserPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnExitMe As System.Windows.Forms.Button
    Friend WithEvents LstUsersName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstTelephone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserName As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
