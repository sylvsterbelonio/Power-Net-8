<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemLock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSystemLock))
        Me.grpLogInForm = New System.Windows.Forms.GroupBox
        Me.cmdLogIn = New PowerNET8.My7GlassButton
        Me.txtpassword = New PowerNET8.MyTextBoxExtension
        Me.txtusername = New PowerNET8.MyTextBoxExtension
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblInform1 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.MyLineSeparator1 = New PowerNET8.myLineSeparator
        Me.grpLogInForm.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpLogInForm
        '
        Me.grpLogInForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grpLogInForm.Controls.Add(Me.cmdLogIn)
        Me.grpLogInForm.Controls.Add(Me.txtpassword)
        Me.grpLogInForm.Controls.Add(Me.txtusername)
        Me.grpLogInForm.Controls.Add(Me.Label6)
        Me.grpLogInForm.Controls.Add(Me.Label5)
        Me.grpLogInForm.Location = New System.Drawing.Point(151, 144)
        Me.grpLogInForm.Name = "grpLogInForm"
        Me.grpLogInForm.Size = New System.Drawing.Size(346, 117)
        Me.grpLogInForm.TabIndex = 7
        Me.grpLogInForm.TabStop = False
        Me.grpLogInForm.Visible = False
        '
        'cmdLogIn
        '
        Me.cmdLogIn.Arrow = PowerNET8.My7GlassButton.MB_Arrow.None
        Me.cmdLogIn.BackColor = System.Drawing.Color.Transparent
        Me.cmdLogIn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cmdLogIn.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdLogIn.FlatAppearance.BorderSize = 0
        Me.cmdLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLogIn.GroupPosition = PowerNET8.My7GlassButton.MB_GroupPos.None
        Me.cmdLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLogIn.ImageSize = New System.Drawing.Size(16, 16)
        Me.cmdLogIn.Location = New System.Drawing.Point(192, 71)
        Me.cmdLogIn.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.cmdLogIn.Name = "cmdLogIn"
        Me.cmdLogIn.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdLogIn.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmdLogIn.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdLogIn.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdLogIn.Radius = 25
        Me.cmdLogIn.ShowBase = PowerNET8.My7GlassButton.MB_ShowBase.Yes
        Me.cmdLogIn.Size = New System.Drawing.Size(132, 35)
        Me.cmdLogIn.SplitButton = PowerNET8.My7GlassButton.MB_SplitButton.No
        Me.cmdLogIn.SplitLocation = PowerNET8.My7GlassButton.MB_SplitLocation.Bottom
        Me.cmdLogIn.TabIndex = 4
        Me.cmdLogIn.Tag = "ui-icon-check"
        Me.cmdLogIn.Text = "Log In"
        Me.cmdLogIn.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.AcceptsReturn = True
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtpassword.Location = New System.Drawing.Point(77, 45)
        Me.txtpassword.My_Border_Color_Hover = System.Drawing.Color.SteelBlue
        Me.txtpassword.My_Border_Size = 1
        Me.txtpassword.My_Character_Input_Style = PowerNET8.MyTextBoxExtension.Cinput.All
        Me.txtpassword.My_Corner = 1
        Me.txtpassword.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.txtpassword.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.txtpassword.My_Event_Fontcolor_GotFocus = System.Drawing.Color.Black
        Me.txtpassword.My_Event_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.txtpassword.My_WaterMark_Color = System.Drawing.Color.Gray
        Me.txtpassword.My_WaterMark_Text = "Input Password Here"
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(247, 20)
        Me.txtpassword.TabIndex = 3
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtusername.Location = New System.Drawing.Point(77, 19)
        Me.txtusername.My_Border_Color_Hover = System.Drawing.Color.SteelBlue
        Me.txtusername.My_Border_Size = 1
        Me.txtusername.My_Character_Input_Style = PowerNET8.MyTextBoxExtension.Cinput.All
        Me.txtusername.My_Corner = 1
        Me.txtusername.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.txtusername.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.txtusername.My_Event_Fontcolor_GotFocus = System.Drawing.Color.Black
        Me.txtusername.My_Event_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.txtusername.My_WaterMark_Color = System.Drawing.Color.Gray
        Me.txtusername.My_WaterMark_Text = ""
        Me.txtusername.Name = "txtusername"
        Me.txtusername.ReadOnly = True
        Me.txtusername.Size = New System.Drawing.Size(247, 20)
        Me.txtusername.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Username"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(146, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(351, 77)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = resources.GetString("Label4.Text")
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(13, 144)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(127, 119)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "THIS IS THE SYSTEM SAMPLE LOCK"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(145, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(351, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = " If you have the correct account, press the link to enter password and unlock the" & _
            " system."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(146, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Caution: If you lose or forget the password, it can not be recovered. (Remember t" & _
            "hat passwords are care sensitive.)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInform1
        '
        Me.lblInform1.Location = New System.Drawing.Point(146, 13)
        Me.lblInform1.Name = "lblInform1"
        Me.lblInform1.Size = New System.Drawing.Size(351, 37)
        Me.lblInform1.TabIndex = 1
        Me.lblInform1.Text = "This system has been locked by [username]. Only the same user can lift this syste" & _
            "m lock."
        Me.lblInform1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(429, 121)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(67, 13)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Show Log In"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.picLogo)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.grpLogInForm)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.MyLineSeparator1)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.lblInform1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(513, 275)
        Me.Panel1.TabIndex = 9
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Location = New System.Drawing.Point(13, 13)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(127, 119)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'MyLineSeparator1
        '
        Me.MyLineSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.MyLineSeparator1.Location = New System.Drawing.Point(151, 138)
        Me.MyLineSeparator1.My_Line_Border = 1
        Me.MyLineSeparator1.My_Line_Color = System.Drawing.Color.Black
        Me.MyLineSeparator1.My_Line_Style = PowerNET8.myLineSeparator.LineMode.Horizontal
        Me.MyLineSeparator1.Name = "MyLineSeparator1"
        Me.MyLineSeparator1.Size = New System.Drawing.Size(345, 10)
        Me.MyLineSeparator1.TabIndex = 6
        '
        'frmSystemLock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 285)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSystemLock"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "-"
        Me.grpLogInForm.ResumeLayout(False)
        Me.grpLogInForm.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblInform1 As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents MyLineSeparator1 As myLineSeparator
    Friend WithEvents grpLogInForm As System.Windows.Forms.GroupBox
    Friend WithEvents cmdLogIn As My7GlassButton
    Friend WithEvents txtpassword As MyTextboxExtension
    Friend WithEvents txtusername As MyTextboxExtension
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
