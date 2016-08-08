Public Class AddNewData

    Private Sub btnSaveData_Click(sender As Object, e As EventArgs) Handles btnSaveData.Click
        If btnSaveData.Text = "添加数据" Then
            '遍历DataGridView控件，检测新的手机号码是否已被注册
            For Index = 0 To AccessWindow.UsersData.Rows.Count - 2
                If txtUserTelephone.Text = AccessWindow.UsersData.Rows(Index).Cells(1).Value Then
                    txtUserTelephone.Focus()
                    txtUserTelephone.SelectAll()
                    MsgBox("该手机号已经被注册。")
                    Exit Sub
                End If
            Next

            'DataGridView控件先添加进新条目
            AccessWindow.UsersData.Rows.Add(txtUserName.Text, txtUserTelephone.Text)
            AccessWindow.UsersData.Rows(AccessWindow.UsersData.NewRowIndex - 1).HeaderCell.Value = Str(AccessWindow.UsersData.NewRowIndex).Trim

            '把用户图片文件储存进数据库
            Dim PhotoStream As New System.IO.MemoryStream
            picUserPhoto.Image.Save(PhotoStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim UserPhoto(PhotoStream.Length) As Byte
            UserPhoto = PhotoStream.GetBuffer

            '再把新条目添加进数据库文件
            AccessWindow.AddAccessData(txtUserName.Text, txtUserTelephone.Text, UserPhoto)
        End If
    End Sub

    Private Sub btnSelectPhoto_Click(sender As Object, e As EventArgs) Handles btnSelectPhoto.Click
        Dim GetPhotoPath As New OpenFileDialog
        GetPhotoPath.Title = "请选则要加载的图片文件"
        GetPhotoPath.ShowDialog()
        picUserPhoto.Image = Image.FromFile(GetPhotoPath.FileName)
    End Sub
End Class