<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogIn))
        Me.lblSubTitle = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblProductVersion = New System.Windows.Forms.Label
        Me.frmContent = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkGuest = New System.Windows.Forms.CheckBox
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.cmdLogIn = New PowerNET8.My7GlassButton
        Me.txtusername = New PowerNET8.MyTextboxExtension
        Me.MyLineSeparator2 = New PowerNET8.myLineSeparator
        Me.txtpassword = New PowerNET8.MyTextBoxExtension
        Me.MyLineSeparator1 = New PowerNET8.myLineSeparator
        Me.frmContent.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSubTitle
        '
        Me.lblSubTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTitle.Location = New System.Drawing.Point(144, 37)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(422, 16)
        Me.lblSubTitle.TabIndex = 3
        Me.lblSubTitle.Text = "Sub Title"
        Me.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(12, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 81)
        Me.Label4.TabIndex = 13
        Me.Label4.Tag = "custom"
        Me.Label4.Text = "Don't have an account? Please inform the administrator for the creation of your n" & _
            "ew account."
        '
        'lblProductVersion
        '
        Me.lblProductVersion.AutoSize = True
        Me.lblProductVersion.Location = New System.Drawing.Point(12, 138)
        Me.lblProductVersion.Name = "lblProductVersion"
        Me.lblProductVersion.Size = New System.Drawing.Size(118, 13)
        Me.lblProductVersion.TabIndex = 14
        Me.lblProductVersion.Text = "Product Version 1.0.0.0"
        '
        'frmContent
        '
        Me.frmContent.Controls.Add(Me.Label9)
        Me.frmContent.Controls.Add(Me.Label8)
        Me.frmContent.Controls.Add(Me.Label7)
        Me.frmContent.Controls.Add(Me.lblTitle)
        Me.frmContent.Controls.Add(Me.GroupBox1)
        Me.frmContent.Controls.Add(Me.picLogo)
        Me.frmContent.Controls.Add(Me.lblProductVersion)
        Me.frmContent.Controls.Add(Me.Label4)
        Me.frmContent.Controls.Add(Me.MyLineSeparator1)
        Me.frmContent.Controls.Add(Me.lblSubTitle)
        Me.frmContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmContent.Location = New System.Drawing.Point(0, 0)
        Me.frmContent.Name = "frmContent"
        Me.frmContent.Size = New System.Drawing.Size(594, 308)
        Me.frmContent.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(150, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(410, 21)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "If you've been registered, please supply the following data:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(151, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(410, 41)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Caution : If you lose or forget the password, it can not be recovered. (Remember " & _
            "that passwords are case sensitive.)"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(151, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(410, 41)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "This application manipulates sensitive data. Only registered users are allowed ac" & _
            "cess."
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(144, 17)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(422, 20)
        Me.lblTitle.TabIndex = 21
        Me.lblTitle.Text = "TITLE"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.chkGuest)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdLogIn)
        Me.GroupBox1.Controls.Add(Me.txtusername)
        Me.GroupBox1.Controls.Add(Me.MyLineSeparator2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Location = New System.Drawing.Point(144, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 128)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "backcolor-top1"
        '
        'chkGuest
        '
        Me.chkGuest.AutoSize = True
        Me.chkGuest.Location = New System.Drawing.Point(189, 92)
        Me.chkGuest.Name = "chkGuest"
        Me.chkGuest.Size = New System.Drawing.Size(102, 17)
        Me.chkGuest.TabIndex = 20
        Me.chkGuest.Text = "Log In As Guest"
        Me.chkGuest.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Location = New System.Drawing.Point(7, 17)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(123, 116)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'cmdLogIn
        '
        Me.cmdLogIn.Arrow = PowerNET8.My7GlassButton.MB_Arrow.None
        Me.cmdLogIn.BackColor = System.Drawing.Color.Transparent
        Me.cmdLogIn.BaseColor = System.Drawing.Color.CornflowerBlue
        Me.cmdLogIn.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.cmdLogIn.FlatAppearance.BorderSize = 0
        Me.cmdLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLogIn.GroupPosition = PowerNET8.My7GlassButton.MB_GroupPos.None
        Me.cmdLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLogIn.ImageSize = New System.Drawing.Size(16, 16)
        Me.cmdLogIn.Location = New System.Drawing.Point(300, 74)
        Me.cmdLogIn.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.cmdLogIn.Name = "cmdLogIn"
        Me.cmdLogIn.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdLogIn.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmdLogIn.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdLogIn.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdLogIn.Radius = 25
        Me.cmdLogIn.ShowBase = PowerNET8.My7GlassButton.MB_ShowBase.Yes
        Me.cmdLogIn.Size = New System.Drawing.Size(91, 35)
        Me.cmdLogIn.SplitButton = PowerNET8.My7GlassButton.MB_SplitButton.No
        Me.cmdLogIn.SplitLocation = PowerNET8.My7GlassButton.MB_SplitLocation.Bottom
        Me.cmdLogIn.TabIndex = 19
        Me.cmdLogIn.Tag = "ui-icon-check"
        Me.cmdLogIn.Text = "Log In"
        Me.cmdLogIn.UseVisualStyleBackColor = True
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.White
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(102, 22)
        Me.txtusername.My_Border_Color_Hover = System.Drawing.Color.SteelBlue
        Me.txtusername.My_Border_Size = 1
        Me.txtusername.My_Character_Input_Style = PowerNET8.MyTextBoxExtension.Cinput.All
        Me.txtusername.My_Corner = 1
        Me.txtusername.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.txtusername.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.txtusername.My_Event_Fontcolor_GotFocus = System.Drawing.Color.Black
        Me.txtusername.My_Event_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.txtusername.My_WaterMark_Color = System.Drawing.Color.Gray
        Me.txtusername.My_WaterMark_Text = "Enter your username"
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(289, 20)
        Me.txtusername.TabIndex = 6
        Me.txtusername.Tag = "suggest-username@tblusers"
        '
        'MyLineSeparator2
        '
        Me.MyLineSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.MyLineSeparator2.Location = New System.Drawing.Point(28, 77)
        Me.MyLineSeparator2.My_Line_Border = 1
        Me.MyLineSeparator2.My_Line_Color = System.Drawing.Color.Black
        Me.MyLineSeparator2.My_Line_Style = PowerNET8.myLineSeparator.LineMode.Horizontal
        Me.MyLineSeparator2.Name = "MyLineSeparator2"
        Me.MyLineSeparator2.Size = New System.Drawing.Size(263, 10)
        Me.MyLineSeparator2.TabIndex = 16
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtpassword.Location = New System.Drawing.Point(102, 48)
        Me.txtpassword.My_Border_Color_Hover = System.Drawing.Color.SteelBlue
        Me.txtpassword.My_Border_Size = 1
        Me.txtpassword.My_Character_Input_Style = PowerNET8.MyTextBoxExtension.Cinput.All
        Me.txtpassword.My_Corner = 1
        Me.txtpassword.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.txtpassword.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.txtpassword.My_Event_Fontcolor_GotFocus = System.Drawing.Color.Black
        Me.txtpassword.My_Event_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.txtpassword.My_WaterMark_Color = System.Drawing.Color.Gray
        Me.txtpassword.My_WaterMark_Text = "Enter your password"
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(289, 20)
        Me.txtpassword.TabIndex = 7
        '
        'MyLineSeparator1
        '
        Me.MyLineSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.MyLineSeparator1.Location = New System.Drawing.Point(144, 56)
        Me.MyLineSeparator1.My_Line_Border = 1
        Me.MyLineSeparator1.My_Line_Color = System.Drawing.Color.Black
        Me.MyLineSeparator1.My_Line_Style = PowerNET8.myLineSeparator.LineMode.Horizontal
        Me.MyLineSeparator1.Name = "MyLineSeparator1"
        Me.MyLineSeparator1.Size = New System.Drawing.Size(422, 10)
        Me.MyLineSeparator1.TabIndex = 2
        '
        'frmLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(594, 308)
        Me.Controls.Add(Me.frmContent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "-"
        Me.frmContent.ResumeLayout(False)
        Me.frmContent.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents MyLineSeparator1 As myLineSeparator
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtusername As MyTextboxExtension
    Friend WithEvents txtpassword As MyTextboxExtension
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblProductVersion As System.Windows.Forms.Label
    Friend WithEvents frmContent As System.Windows.Forms.Panel
    Friend WithEvents MyLineSeparator2 As myLineSeparator
    Friend WithEvents cmdLogIn As PowerNET8.My7GlassButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkGuest As System.Windows.Forms.CheckBox
End Class
