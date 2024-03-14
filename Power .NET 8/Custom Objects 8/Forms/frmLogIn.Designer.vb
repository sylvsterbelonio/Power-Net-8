<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdLogin = New PowerNET8.My8Button
        Me.My8Button2 = New PowerNET8.My8Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(97, 16)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(250, 20)
        Me.txtusername.TabIndex = 1
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(97, 42)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(250, 20)
        Me.txtpassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'cmdLogin
        '
        Me.cmdLogin.BorderColors = System.Drawing.Color.White
        Me.cmdLogin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLogin.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdLogin.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdLogin.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.cmdLogin.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdLogin.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdLogin.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdLogin.Location = New System.Drawing.Point(191, 71)
        Me.cmdLogin.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmdLogin.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdLogin.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdLogin.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(75, 30)
        Me.cmdLogin.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.cmdLogin.TabIndex = 4
        Me.cmdLogin.Text = "Log In"
        Me.cmdLogin.UseVisualStyleBackColor = True
        Me.cmdLogin.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'My8Button2
        '
        Me.My8Button2.BorderColors = System.Drawing.Color.White
        Me.My8Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.My8Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.My8Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.My8Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.My8Button2.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.My8Button2.ImageSize = New System.Drawing.Size(24, 24)
        Me.My8Button2.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.My8Button2.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.My8Button2.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.My8Button2.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.My8Button2.Location = New System.Drawing.Point(272, 71)
        Me.My8Button2.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.My8Button2.MouseOverForecolor = System.Drawing.Color.White
        Me.My8Button2.MousePressedBackColor = System.Drawing.Color.White
        Me.My8Button2.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.My8Button2.Name = "My8Button2"
        Me.My8Button2.Size = New System.Drawing.Size(75, 30)
        Me.My8Button2.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Green
        Me.My8Button2.TabIndex = 5
        Me.My8Button2.Text = "Cancel"
        Me.My8Button2.UseVisualStyleBackColor = True
        Me.My8Button2.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'frmLogIn
        '
        Me.AcceptButton = Me.cmdLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 106)
        Me.Controls.Add(Me.My8Button2)
        Me.Controls.Add(Me.cmdLogin)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(375, 144)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(375, 144)
        Me.Name = "frmLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Authorized Person Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdLogin As PowerNET8.My8Button
    Friend WithEvents My8Button2 As PowerNET8.My8Button
End Class
