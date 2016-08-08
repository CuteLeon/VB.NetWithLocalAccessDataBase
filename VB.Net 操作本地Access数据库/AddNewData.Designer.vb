<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewData
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtUserTelephone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picUserPhoto = New System.Windows.Forms.PictureBox()
        Me.btnSaveData = New System.Windows.Forms.Button()
        Me.btnSelectPhoto = New System.Windows.Forms.Button()
        CType(Me.picUserPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "用户姓名："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "手机号码："
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(97, 23)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(130, 21)
        Me.txtUserName.TabIndex = 2
        '
        'txtUserTelephone
        '
        Me.txtUserTelephone.Location = New System.Drawing.Point(97, 47)
        Me.txtUserTelephone.Name = "txtUserTelephone"
        Me.txtUserTelephone.Size = New System.Drawing.Size(130, 21)
        Me.txtUserTelephone.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "上传照片："
        '
        'picUserPhoto
        '
        Me.picUserPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picUserPhoto.Location = New System.Drawing.Point(97, 75)
        Me.picUserPhoto.Name = "picUserPhoto"
        Me.picUserPhoto.Size = New System.Drawing.Size(130, 145)
        Me.picUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUserPhoto.TabIndex = 5
        Me.picUserPhoto.TabStop = False
        '
        'btnSaveData
        '
        Me.btnSaveData.Location = New System.Drawing.Point(97, 226)
        Me.btnSaveData.Name = "btnSaveData"
        Me.btnSaveData.Size = New System.Drawing.Size(130, 39)
        Me.btnSaveData.TabIndex = 6
        Me.btnSaveData.Text = "添加数据"
        Me.btnSaveData.UseVisualStyleBackColor = True
        '
        'btnSelectPhoto
        '
        Me.btnSelectPhoto.Location = New System.Drawing.Point(28, 132)
        Me.btnSelectPhoto.Name = "btnSelectPhoto"
        Me.btnSelectPhoto.Size = New System.Drawing.Size(63, 37)
        Me.btnSelectPhoto.TabIndex = 7
        Me.btnSelectPhoto.Text = "选择图片"
        Me.btnSelectPhoto.UseVisualStyleBackColor = True
        '
        'AddNewData
        '
        Me.AcceptButton = Me.btnSaveData
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 276)
        Me.Controls.Add(Me.btnSelectPhoto)
        Me.Controls.Add(Me.btnSaveData)
        Me.Controls.Add(Me.picUserPhoto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUserTelephone)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AddNewData"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "添加新用户"
        CType(Me.picUserPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtUserTelephone As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents picUserPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnSaveData As System.Windows.Forms.Button
    Friend WithEvents btnSelectPhoto As System.Windows.Forms.Button
End Class
