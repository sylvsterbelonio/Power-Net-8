<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnector
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConnector))
        Me.frmContent = New System.Windows.Forms.Panel
        Me.cmdTest = New PowerNET8.My7GlassButton
        Me.cmdOk = New PowerNET8.My7GlassButton
        Me.cmdCancel = New PowerNET8.My7GlassButton
        Me.gbConnection = New System.Windows.Forms.GroupBox
        Me.cboDBName = New PowerNET8.MyComboBoxExtension
        Me.txtPassword = New PowerNET8.MyTextBoxExtension
        Me.txtUserID = New PowerNET8.MyTextBoxExtension
        Me.txtPort = New PowerNET8.MyTextBoxExtension
        Me.txtServer = New PowerNET8.MyTextBoxExtension
        Me.lblPort = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.frmContent.SuspendLayout()
        Me.gbConnection.SuspendLayout()
        Me.SuspendLayout()
        '
        'frmContent
        '
        Me.frmContent.Controls.Add(Me.cmdTest)
        Me.frmContent.Controls.Add(Me.cmdOk)
        Me.frmContent.Controls.Add(Me.cmdCancel)
        Me.frmContent.Controls.Add(Me.gbConnection)
        Me.frmContent.Controls.Add(Me.Label1)
        Me.frmContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmContent.Location = New System.Drawing.Point(0, 0)
        Me.frmContent.Name = "frmContent"
        Me.frmContent.Size = New System.Drawing.Size(388, 325)
        Me.frmContent.TabIndex = 0
        '
        'cmdTest
        '
        Me.cmdTest.Arrow = PowerNET8.My7GlassButton.MB_Arrow.None
        Me.cmdTest.BackColor = System.Drawing.Color.Transparent
        Me.cmdTest.BaseColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cmdTest.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdTest.FlatAppearance.BorderSize = 0
        Me.cmdTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTest.GroupPosition = PowerNET8.My7GlassButton.MB_GroupPos.None
        Me.cmdTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTest.ImageSize = New System.Drawing.Size(16, 16)
        Me.cmdTest.Location = New System.Drawing.Point(44, 279)
        Me.cmdTest.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdTest.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmdTest.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdTest.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdTest.Radius = 20
        Me.cmdTest.ShowBase = PowerNET8.My7GlassButton.MB_ShowBase.Yes
        Me.cmdTest.Size = New System.Drawing.Size(95, 35)
        Me.cmdTest.SplitButton = PowerNET8.My7GlassButton.MB_SplitButton.No
        Me.cmdTest.SplitLocation = PowerNET8.My7GlassButton.MB_SplitLocation.Bottom
        Me.cmdTest.TabIndex = 12
        Me.cmdTest.Tag = "ui-icon-clipboard;tooltip-Test the configuration@Database and Sql"
        Me.cmdTest.Text = "Test"
        Me.cmdTest.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Arrow = PowerNET8.My7GlassButton.MB_Arrow.None
        Me.cmdOk.BackColor = System.Drawing.Color.Transparent
        Me.cmdOk.BaseColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cmdOk.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdOk.FlatAppearance.BorderSize = 0
        Me.cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOk.GroupPosition = PowerNET8.My7GlassButton.MB_GroupPos.None
        Me.cmdOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdOk.ImageSize = New System.Drawing.Size(16, 16)
        Me.cmdOk.Location = New System.Drawing.Point(145, 279)
        Me.cmdOk.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdOk.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmdOk.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdOk.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdOk.Radius = 20
        Me.cmdOk.ShowBase = PowerNET8.My7GlassButton.MB_ShowBase.Yes
        Me.cmdOk.Size = New System.Drawing.Size(95, 35)
        Me.cmdOk.SplitButton = PowerNET8.My7GlassButton.MB_SplitButton.No
        Me.cmdOk.SplitLocation = PowerNET8.My7GlassButton.MB_SplitLocation.Bottom
        Me.cmdOk.TabIndex = 11
        Me.cmdOk.Tag = "ui-icon-check;tooltip-Exit and Save the current Configurations"
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Arrow = PowerNET8.My7GlassButton.MB_Arrow.None
        Me.cmdCancel.BackColor = System.Drawing.Color.Transparent
        Me.cmdCancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cmdCancel.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdCancel.FlatAppearance.BorderSize = 0
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.GroupPosition = PowerNET8.My7GlassButton.MB_GroupPos.None
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancel.ImageSize = New System.Drawing.Size(16, 16)
        Me.cmdCancel.Location = New System.Drawing.Point(246, 279)
        Me.cmdCancel.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdCancel.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmdCancel.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdCancel.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdCancel.Radius = 20
        Me.cmdCancel.ShowBase = PowerNET8.My7GlassButton.MB_ShowBase.Yes
        Me.cmdCancel.Size = New System.Drawing.Size(95, 35)
        Me.cmdCancel.SplitButton = PowerNET8.My7GlassButton.MB_SplitButton.No
        Me.cmdCancel.SplitLocation = PowerNET8.My7GlassButton.MB_SplitLocation.Bottom
        Me.cmdCancel.TabIndex = 10
        Me.cmdCancel.Tag = "ui-icon-cancel;tooltip-Cancel All Configurations"
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'gbConnection
        '
        Me.gbConnection.Controls.Add(Me.cboDBName)
        Me.gbConnection.Controls.Add(Me.txtPassword)
        Me.gbConnection.Controls.Add(Me.txtUserID)
        Me.gbConnection.Controls.Add(Me.txtPort)
        Me.gbConnection.Controls.Add(Me.txtServer)
        Me.gbConnection.Controls.Add(Me.lblPort)
        Me.gbConnection.Controls.Add(Me.Label3)
        Me.gbConnection.Controls.Add(Me.Label2)
        Me.gbConnection.Controls.Add(Me.Label5)
        Me.gbConnection.Controls.Add(Me.Label7)
        Me.gbConnection.Controls.Add(Me.Label8)
        Me.gbConnection.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbConnection.Location = New System.Drawing.Point(16, 31)
        Me.gbConnection.Name = "gbConnection"
        Me.gbConnection.Size = New System.Drawing.Size(350, 240)
        Me.gbConnection.TabIndex = 9
        Me.gbConnection.TabStop = False
        Me.gbConnection.Text = "Connect to MySQL Server Instance"
        '
        'cboDBName
        '
        Me.cboDBName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDBName.FormattingEnabled = True
        Me.cboDBName.Location = New System.Drawing.Point(120, 123)
        Me.cboDBName.My_Border_Size = 1
        Me.cboDBName.My_BorderColor_Hover = System.Drawing.Color.SteelBlue
        Me.cboDBName.My_Corner = 3
        Me.cboDBName.My_Event_Backcolor_Focus = System.Drawing.Color.White
        Me.cboDBName.My_Event_Backcolor_Lostfocus = System.Drawing.Color.White
        Me.cboDBName.My_Event_Fontcolor_Focus = System.Drawing.Color.Black
        Me.cboDBName.My_Event_Forecolor_Lostfocus = System.Drawing.Color.Black
        Me.cboDBName.My_Image_Icon_Style = PowerNET8.MyComboBoxExtension.ImageIconStyle.Left
        Me.cboDBName.My_Image_Width = 25
        Me.cboDBName.My_Selection_Style = PowerNET8.MyComboBoxExtension.SelectStyleType.Standard
        Me.cboDBName.My_Selection_Style_Custom_Select_BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboDBName.My_Selection_Style_Custom_Select_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboDBName.My_Selection_Style_Custom_Select_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.cboDBName.My_Selection_Style_Custom_Select_FontColor = System.Drawing.Color.DarkBlue
        Me.cboDBName.My_Selection_Style_Custom_Select_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboDBName.My_Selection_Style_Custom_Select_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cboDBName.My_Selection_Style_Custom_UnSelect_BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.cboDBName.My_Selection_Style_Custom_UnSelect_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.cboDBName.My_Selection_Style_Custom_UnSelect_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.cboDBName.My_Selection_Style_Custom_UnSelect_FontColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.cboDBName.My_Selection_Style_Custom_UnSelect_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.cboDBName.My_Selection_Style_Custom_UnSelect_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.cboDBName.Name = "cboDBName"
        Me.cboDBName.Size = New System.Drawing.Size(200, 21)
        Me.cboDBName.TabIndex = 10
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtPassword.Location = New System.Drawing.Point(120, 97)
        Me.txtPassword.My_Border_Color_Hover = System.Drawing.Color.SteelBlue
        Me.txtPassword.My_Border_Size = 1
        Me.txtPassword.My_Character_Input_Style = PowerNET8.MyTextBoxExtension.Cinput.All
        Me.txtPassword.My_Corner = 1
        Me.txtPassword.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.txtPassword.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.txtPassword.My_Event_Fontcolor_GotFocus = System.Drawing.Color.Black
        Me.txtPassword.My_Event_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.txtPassword.My_WaterMark_Color = System.Drawing.Color.Gray
        Me.txtPassword.My_WaterMark_Text = "Password"
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.txtPassword.Size = New System.Drawing.Size(200, 20)
        Me.txtPassword.TabIndex = 13
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtUserID.Location = New System.Drawing.Point(120, 72)
        Me.txtUserID.My_Border_Color_Hover = System.Drawing.Color.SteelBlue
        Me.txtUserID.My_Border_Size = 1
        Me.txtUserID.My_Character_Input_Style = PowerNET8.MyTextBoxExtension.Cinput.All
        Me.txtUserID.My_Corner = 1
        Me.txtUserID.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.txtUserID.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.txtUserID.My_Event_Fontcolor_GotFocus = System.Drawing.Color.Black
        Me.txtUserID.My_Event_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.txtUserID.My_WaterMark_Color = System.Drawing.Color.Gray
        Me.txtUserID.My_WaterMark_Text = "Username"
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(200, 20)
        Me.txtUserID.TabIndex = 12
        '
        'txtPort
        '
        Me.txtPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtPort.Location = New System.Drawing.Point(120, 46)
        Me.txtPort.My_Border_Color_Hover = System.Drawing.Color.SteelBlue
        Me.txtPort.My_Border_Size = 1
        Me.txtPort.My_Character_Input_Style = PowerNET8.MyTextBoxExtension.Cinput.All
        Me.txtPort.My_Corner = 1
        Me.txtPort.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.txtPort.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.txtPort.My_Event_Fontcolor_GotFocus = System.Drawing.Color.Black
        Me.txtPort.My_Event_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.txtPort.My_WaterMark_Color = System.Drawing.Color.Gray
        Me.txtPort.My_WaterMark_Text = "Port Number"
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(200, 20)
        Me.txtPort.TabIndex = 11
        '
        'txtServer
        '
        Me.txtServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtServer.Location = New System.Drawing.Point(120, 20)
        Me.txtServer.My_Border_Color_Hover = System.Drawing.Color.SteelBlue
        Me.txtServer.My_Border_Size = 1
        Me.txtServer.My_Character_Input_Style = PowerNET8.MyTextBoxExtension.Cinput.All
        Me.txtServer.My_Corner = 1
        Me.txtServer.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.txtServer.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.txtServer.My_Event_Fontcolor_GotFocus = System.Drawing.Color.Black
        Me.txtServer.My_Event_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.txtServer.My_WaterMark_Color = System.Drawing.Color.Gray
        Me.txtServer.My_WaterMark_Text = "Name of Server"
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(200, 20)
        Me.txtServer.TabIndex = 10
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPort.Location = New System.Drawing.Point(20, 50)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(26, 13)
        Me.lblPort.TabIndex = 25
        Me.lblPort.Text = "Port"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(20, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(324, 60)
        Me.Label3.TabIndex = 23
        Me.Label3.Tag = "custom"
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(20, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Database Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(20, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Server Host"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(20, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "User Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(20, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Select appropriate configuration for your system's database connection."
        '
        'frmConnector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 325)
        Me.ControlBox = False
        Me.Controls.Add(Me.frmContent)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConnector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuration and Settings of Database"
        Me.frmContent.ResumeLayout(False)
        Me.frmContent.PerformLayout()
        Me.gbConnection.ResumeLayout(False)
        Me.gbConnection.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frmContent As System.Windows.Forms.Panel
    Friend WithEvents gbConnection As System.Windows.Forms.GroupBox
    Friend WithEvents txtServer As PowerNET8.MyTextBoxExtension
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboDBName As PowerNET8.MyComboBoxExtension
    Friend WithEvents txtPassword As PowerNET8.MyTextBoxExtension
    Friend WithEvents txtUserID As PowerNET8.MyTextBoxExtension
    Friend WithEvents txtPort As PowerNET8.MyTextBoxExtension
    Friend WithEvents cmdTest As PowerNET8.My7GlassButton
    Friend WithEvents cmdOk As PowerNET8.My7GlassButton
    Friend WithEvents cmdCancel As PowerNET8.My7GlassButton
End Class
