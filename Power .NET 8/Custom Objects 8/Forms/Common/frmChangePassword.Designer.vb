<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangePassword))
        Me.frmContent = New System.Windows.Forms.Panel
        Me.MbGlassButton1 = New PowerNET8.My7GlassButton
        Me.cmdLogIn = New PowerNET8.My7GlassButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtOldPassword = New PowerNET8.MyTextboxExtension
        Me.txtnewPassword = New PowerNET8.MyTextboxExtension
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtVerifyPasswoed = New PowerNET8.MyTextboxExtension
        Me.txtusername = New PowerNET8.MyTextboxExtension
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.frmContent.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'frmContent
        '
        Me.frmContent.BackColor = System.Drawing.Color.White
        Me.frmContent.Controls.Add(Me.MbGlassButton1)
        Me.frmContent.Controls.Add(Me.cmdLogIn)
        Me.frmContent.Controls.Add(Me.GroupBox1)
        Me.frmContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmContent.Location = New System.Drawing.Point(0, 0)
        Me.frmContent.Name = "frmContent"
        Me.frmContent.Size = New System.Drawing.Size(350, 217)
        Me.frmContent.TabIndex = 0
        '
        'MbGlassButton1
        '
        Me.MbGlassButton1.Arrow = PowerNET8.My7GlassButton.MB_Arrow.None
        Me.MbGlassButton1.BackColor = System.Drawing.Color.Transparent
        Me.MbGlassButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.MbGlassButton1.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MbGlassButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.MbGlassButton1.FlatAppearance.BorderSize = 0
        Me.MbGlassButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MbGlassButton1.GroupPosition = PowerNET8.My7GlassButton.MB_GroupPos.None
        Me.MbGlassButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MbGlassButton1.ImageSize = New System.Drawing.Size(16, 16)
        Me.MbGlassButton1.Location = New System.Drawing.Point(160, 169)
        Me.MbGlassButton1.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.MbGlassButton1.Name = "MbGlassButton1"
        Me.MbGlassButton1.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.MbGlassButton1.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.MbGlassButton1.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MbGlassButton1.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MbGlassButton1.Radius = 25
        Me.MbGlassButton1.ShowBase = PowerNET8.My7GlassButton.MB_ShowBase.Yes
        Me.MbGlassButton1.Size = New System.Drawing.Size(84, 35)
        Me.MbGlassButton1.SplitButton = PowerNET8.My7GlassButton.MB_SplitButton.No
        Me.MbGlassButton1.SplitLocation = PowerNET8.My7GlassButton.MB_SplitLocation.Bottom
        Me.MbGlassButton1.TabIndex = 1
        Me.MbGlassButton1.Tag = "ui-icon-close"
        Me.MbGlassButton1.Text = "Cancel"
        Me.MbGlassButton1.UseVisualStyleBackColor = True
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
        Me.cmdLogIn.Location = New System.Drawing.Point(250, 169)
        Me.cmdLogIn.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.cmdLogIn.Name = "cmdLogIn"
        Me.cmdLogIn.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdLogIn.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmdLogIn.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdLogIn.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdLogIn.Radius = 25
        Me.cmdLogIn.ShowBase = PowerNET8.My7GlassButton.MB_ShowBase.Yes
        Me.cmdLogIn.Size = New System.Drawing.Size(87, 35)
        Me.cmdLogIn.SplitButton = PowerNET8.My7GlassButton.MB_SplitButton.No
        Me.cmdLogIn.SplitLocation = PowerNET8.My7GlassButton.MB_SplitLocation.Bottom
        Me.cmdLogIn.TabIndex = 2
        Me.cmdLogIn.Tag = "ui-icon-check"
        Me.cmdLogIn.Text = "Ok"
        Me.cmdLogIn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtOldPassword)
        Me.GroupBox1.Controls.Add(Me.txtnewPassword)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtVerifyPasswoed)
        Me.GroupBox1.Controls.Add(Me.txtusername)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 151)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "backcolor-top1"
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtOldPassword.Location = New System.Drawing.Point(113, 55)
        Me.txtOldPassword.My_Border_Color_Hover = System.Drawing.Color.SteelBlue
        Me.txtOldPassword.My_Border_Size = 1
        Me.txtOldPassword.My_Character_Input_Style = PowerNET8.MyTextboxExtension.Cinput.All
        Me.txtOldPassword.My_Corner = 1
        Me.txtOldPassword.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.txtOldPassword.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.txtOldPassword.My_Event_Fontcolor_GotFocus = System.Drawing.Color.Black
        Me.txtOldPassword.My_Event_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.txtOldPassword.My_WaterMark_Color = System.Drawing.Color.Gray
        Me.txtOldPassword.My_WaterMark_Text = "your old password"
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPassword.Size = New System.Drawing.Size(196, 20)
        Me.txtOldPassword.TabIndex = 3
        '
        'txtnewPassword
        '
        Me.txtnewPassword.AcceptsReturn = True
        Me.txtnewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtnewPassword.Location = New System.Drawing.Point(113, 81)
        Me.txtnewPassword.My_Border_Color_Hover = System.Drawing.Color.SteelBlue
        Me.txtnewPassword.My_Border_Size = 1
        Me.txtnewPassword.My_Character_Input_Style = PowerNET8.MyTextboxExtension.Cinput.All
        Me.txtnewPassword.My_Corner = 1
        Me.txtnewPassword.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.txtnewPassword.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.txtnewPassword.My_Event_Fontcolor_GotFocus = System.Drawing.Color.Black
        Me.txtnewPassword.My_Event_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.txtnewPassword.My_WaterMark_Color = System.Drawing.Color.Gray
        Me.txtnewPassword.My_WaterMark_Text = "new password"
        Me.txtnewPassword.Name = "txtnewPassword"
        Me.txtnewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewPassword.Size = New System.Drawing.Size(196, 20)
        Me.txtnewPassword.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(17, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "New Password   :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(17, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Old Password     : "
        '
        'txtVerifyPasswoed
        '
        Me.txtVerifyPasswoed.AcceptsReturn = True
        Me.txtVerifyPasswoed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtVerifyPasswoed.Location = New System.Drawing.Point(113, 107)
        Me.txtVerifyPasswoed.My_Border_Color_Hover = System.Drawing.Color.SteelBlue
        Me.txtVerifyPasswoed.My_Border_Size = 1
        Me.txtVerifyPasswoed.My_Character_Input_Style = PowerNET8.MyTextboxExtension.Cinput.All
        Me.txtVerifyPasswoed.My_Corner = 1
        Me.txtVerifyPasswoed.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.txtVerifyPasswoed.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.txtVerifyPasswoed.My_Event_Fontcolor_GotFocus = System.Drawing.Color.Black
        Me.txtVerifyPasswoed.My_Event_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.txtVerifyPasswoed.My_WaterMark_Color = System.Drawing.Color.Gray
        Me.txtVerifyPasswoed.My_WaterMark_Text = "verify your password"
        Me.txtVerifyPasswoed.Name = "txtVerifyPasswoed"
        Me.txtVerifyPasswoed.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtVerifyPasswoed.Size = New System.Drawing.Size(196, 20)
        Me.txtVerifyPasswoed.TabIndex = 7
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtusername.Location = New System.Drawing.Point(113, 29)
        Me.txtusername.My_Border_Color_Hover = System.Drawing.Color.SteelBlue
        Me.txtusername.My_Border_Size = 1
        Me.txtusername.My_Character_Input_Style = PowerNET8.MyTextboxExtension.Cinput.All
        Me.txtusername.My_Corner = 1
        Me.txtusername.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.txtusername.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.txtusername.My_Event_Fontcolor_GotFocus = System.Drawing.Color.Black
        Me.txtusername.My_Event_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.txtusername.My_WaterMark_Color = System.Drawing.Color.Gray
        Me.txtusername.My_WaterMark_Text = ""
        Me.txtusername.Name = "txtusername"
        Me.txtusername.ReadOnly = True
        Me.txtusername.Size = New System.Drawing.Size(196, 20)
        Me.txtusername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(17, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Verify Password  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(17, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "User Name         :"
        '
        'frmChangePassword
        '
        Me.AcceptButton = Me.cmdLogIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.MbGlassButton1
        Me.ClientSize = New System.Drawing.Size(350, 217)
        Me.Controls.Add(Me.frmContent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change User Password"
        Me.frmContent.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frmContent As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOldPassword As PowerNET8.MyTextboxExtension
    Friend WithEvents txtnewPassword As PowerNET8.MyTextboxExtension
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtVerifyPasswoed As PowerNET8.MyTextboxExtension
    Friend WithEvents txtusername As PowerNET8.MyTextboxExtension
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MbGlassButton1 As PowerNET8.My7GlassButton
    Friend WithEvents cmdLogIn As PowerNET8.My7GlassButton
End Class
