<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXMLGeneratorSQL
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.frmContent = New System.Windows.Forms.Panel
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.MbGlassButton1 = New PowerNET8.My7GlassButton
        Me.cmdappend = New PowerNET8.My7GlassButton
        Me.cmdExecute = New PowerNET8.My7GlassButton
        Me.lstColumnName = New PowerNET8.MyListBoxExtension
        Me.txttablename = New PowerNET8.MyTextBoxExtension
        Me.txtsql = New PowerNET8.MyTextBoxExtension
        Me.cmdConnect = New PowerNET8.My7GlassButton
        Me.t = New PowerNET8.My7GlassButton
        Me.cboDatabase = New PowerNET8.MyComboBoxExtension
        Me.txtport = New PowerNET8.MyTextBoxExtension
        Me.txtpassword = New PowerNET8.MyTextBoxExtension
        Me.txtusername = New PowerNET8.MyTextBoxExtension
        Me.txtLocalhost = New PowerNET8.MyTextBoxExtension
        Me.UltraTabPageControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.frmContent.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.MbGlassButton1)
        Me.UltraTabPageControl1.Controls.Add(Me.cmdappend)
        Me.UltraTabPageControl1.Controls.Add(Me.cmdExecute)
        Me.UltraTabPageControl1.Controls.Add(Me.GroupBox1)
        Me.UltraTabPageControl1.Controls.Add(Me.txttablename)
        Me.UltraTabPageControl1.Controls.Add(Me.Label2)
        Me.UltraTabPageControl1.Controls.Add(Me.txtsql)
        Me.UltraTabPageControl1.Controls.Add(Me.Label1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 28)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(409, 397)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstColumnName)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 227)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Column Name Field from SQL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(13, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "TableName"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SQL Command"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.GroupBox2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(409, 397)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdConnect)
        Me.GroupBox2.Controls.Add(Me.t)
        Me.GroupBox2.Controls.Add(Me.cboDatabase)
        Me.GroupBox2.Controls.Add(Me.txtport)
        Me.GroupBox2.Controls.Add(Me.txtpassword)
        Me.GroupBox2.Controls.Add(Me.txtusername)
        Me.GroupBox2.Controls.Add(Me.txtLocalhost)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 206)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Settings and Configuration"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(17, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Database"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(19, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Port"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(19, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(17, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(19, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Localhost"
        '
        'frmContent
        '
        Me.frmContent.Controls.Add(Me.UltraTabControl1)
        Me.frmContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmContent.Location = New System.Drawing.Point(0, 0)
        Me.frmContent.Name = "frmContent"
        Me.frmContent.Size = New System.Drawing.Size(428, 451)
        Me.frmContent.TabIndex = 0
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Location = New System.Drawing.Point(9, 10)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(413, 428)
        Me.UltraTabControl1.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "SQL Query Builder"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "My Sql Settings"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.UltraTabControl1.TabSize = New System.Drawing.Size(0, 25)
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(409, 397)
        '
        'MbGlassButton1
        '
        Me.MbGlassButton1.Arrow = PowerNET8.My7GlassButton.MB_Arrow.None
        Me.MbGlassButton1.BackColor = System.Drawing.Color.Transparent
        Me.MbGlassButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.MbGlassButton1.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MbGlassButton1.FlatAppearance.BorderSize = 0
        Me.MbGlassButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MbGlassButton1.GroupPosition = PowerNET8.My7GlassButton.MB_GroupPos.None
        Me.MbGlassButton1.ImageSize = New System.Drawing.Size(24, 24)
        Me.MbGlassButton1.Location = New System.Drawing.Point(333, 3)
        Me.MbGlassButton1.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.MbGlassButton1.Name = "MbGlassButton1"
        Me.MbGlassButton1.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.MbGlassButton1.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.MbGlassButton1.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MbGlassButton1.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MbGlassButton1.ShowBase = PowerNET8.My7GlassButton.MB_ShowBase.Yes
        Me.MbGlassButton1.Size = New System.Drawing.Size(62, 27)
        Me.MbGlassButton1.SplitButton = PowerNET8.My7GlassButton.MB_SplitButton.No
        Me.MbGlassButton1.SplitLocation = PowerNET8.My7GlassButton.MB_SplitLocation.Bottom
        Me.MbGlassButton1.TabIndex = 7
        Me.MbGlassButton1.Text = "Close"
        Me.MbGlassButton1.UseVisualStyleBackColor = True
        '
        'cmdappend
        '
        Me.cmdappend.Arrow = PowerNET8.My7GlassButton.MB_Arrow.None
        Me.cmdappend.BackColor = System.Drawing.Color.Transparent
        Me.cmdappend.BaseColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cmdappend.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdappend.Enabled = False
        Me.cmdappend.FlatAppearance.BorderSize = 0
        Me.cmdappend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdappend.GroupPosition = PowerNET8.My7GlassButton.MB_GroupPos.None
        Me.cmdappend.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdappend.Location = New System.Drawing.Point(266, 3)
        Me.cmdappend.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.cmdappend.Name = "cmdappend"
        Me.cmdappend.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdappend.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmdappend.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdappend.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdappend.ShowBase = PowerNET8.My7GlassButton.MB_ShowBase.Yes
        Me.cmdappend.Size = New System.Drawing.Size(62, 27)
        Me.cmdappend.SplitButton = PowerNET8.My7GlassButton.MB_SplitButton.No
        Me.cmdappend.SplitLocation = PowerNET8.My7GlassButton.MB_SplitLocation.Bottom
        Me.cmdappend.TabIndex = 2
        Me.cmdappend.Text = "Append"
        Me.cmdappend.UseVisualStyleBackColor = True
        '
        'cmdExecute
        '
        Me.cmdExecute.Arrow = PowerNET8.My7GlassButton.MB_Arrow.None
        Me.cmdExecute.BackColor = System.Drawing.Color.Transparent
        Me.cmdExecute.BaseColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cmdExecute.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdExecute.Enabled = False
        Me.cmdExecute.FlatAppearance.BorderSize = 0
        Me.cmdExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExecute.GroupPosition = PowerNET8.My7GlassButton.MB_GroupPos.None
        Me.cmdExecute.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdExecute.Location = New System.Drawing.Point(198, 3)
        Me.cmdExecute.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.cmdExecute.Name = "cmdExecute"
        Me.cmdExecute.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdExecute.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmdExecute.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdExecute.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdExecute.ShowBase = PowerNET8.My7GlassButton.MB_ShowBase.Yes
        Me.cmdExecute.Size = New System.Drawing.Size(62, 27)
        Me.cmdExecute.SplitButton = PowerNET8.My7GlassButton.MB_SplitButton.No
        Me.cmdExecute.SplitLocation = PowerNET8.My7GlassButton.MB_SplitLocation.Bottom
        Me.cmdExecute.TabIndex = 1
        Me.cmdExecute.Text = "Execute"
        Me.cmdExecute.UseVisualStyleBackColor = True
        '
        'lstColumnName
        '
        Me.lstColumnName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lstColumnName.FormattingEnabled = True
        Me.lstColumnName.Location = New System.Drawing.Point(6, 19)
        Me.lstColumnName.My_Border_Color = System.Drawing.Color.SteelBlue
        Me.lstColumnName.My_Border_Size = 0.5
        Me.lstColumnName.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.lstColumnName.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.lstColumnName.My_Highlight_Forecolor = System.Drawing.Color.White
        Me.lstColumnName.My_Image_Width_Additional = 0
        Me.lstColumnName.My_ImageAlign = PowerNET8.MyListBoxExtension.ImgAlign.left
        Me.lstColumnName.My_Normal_ForeColor = System.Drawing.Color.Black
        Me.lstColumnName.My_Selection_Style = PowerNET8.MyListBoxExtension.SelectStyleType.Standard
        Me.lstColumnName.My_Selection_Style_Custom_Select_BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lstColumnName.My_Selection_Style_Custom_Select_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lstColumnName.My_Selection_Style_Custom_Select_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lstColumnName.My_Selection_Style_Custom_Select_FontColor = System.Drawing.Color.Transparent
        Me.lstColumnName.My_Selection_Style_Custom_Select_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lstColumnName.My_Selection_Style_Custom_Select_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.lstColumnName.My_Selection_Style_Custom_UnSelect_BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lstColumnName.My_Selection_Style_Custom_UnSelect_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.lstColumnName.My_Selection_Style_Custom_UnSelect_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lstColumnName.My_Selection_Style_Custom_UnSelect_FontColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.lstColumnName.My_Selection_Style_Custom_UnSelect_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lstColumnName.My_Selection_Style_Custom_UnSelect_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lstColumnName.My_ShowImages = False
        Me.lstColumnName.My_TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lstColumnName.Name = "lstColumnName"
        Me.lstColumnName.SelectedItem = Nothing
        Me.lstColumnName.Size = New System.Drawing.Size(367, 199)
        Me.lstColumnName.TabIndex = 0
        '
        'txttablename
        '
        Me.txttablename.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttablename.Location = New System.Drawing.Point(16, 134)
        Me.txttablename.My_Border_Color_Hover = System.Drawing.Color.SteelBlue
        Me.txttablename.My_Border_Size = 1
        Me.txttablename.My_Character_Input_Style = PowerNET8.MyTextBoxExtension.Cinput.All
        Me.txttablename.My_Corner = 1
        Me.txttablename.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.txttablename.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.txttablename.My_Event_Fontcolor_GotFocus = System.Drawing.Color.Black
        Me.txttablename.My_Event_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.txttablename.My_WaterMark_Color = System.Drawing.Color.Gray
        Me.txttablename.My_WaterMark_Text = "Textbox"
        Me.txttablename.Name = "txttablename"
        Me.txttablename.Size = New System.Drawing.Size(379, 20)
        Me.txttablename.TabIndex = 5
        Me.txttablename.Text = "mySampleTable"
        '
        'txtsql
        '
        Me.txtsql.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtsql.Location = New System.Drawing.Point(16, 38)
        Me.txtsql.Multiline = True
        Me.txtsql.My_Border_Color_Hover = System.Drawing.Color.SteelBlue
        Me.txtsql.My_Border_Size = 1
        Me.txtsql.My_Character_Input_Style = PowerNET8.MyTextBoxExtension.Cinput.All
        Me.txtsql.My_Corner = 1
        Me.txtsql.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.txtsql.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.txtsql.My_Event_Fontcolor_GotFocus = System.Drawing.Color.Black
        Me.txtsql.My_Event_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.txtsql.My_WaterMark_Color = System.Drawing.Color.Gray
        Me.txtsql.My_WaterMark_Text = "Input SQL Command Here"
        Me.txtsql.Name = "txtsql"
        Me.txtsql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtsql.Size = New System.Drawing.Size(379, 68)
        Me.txtsql.TabIndex = 3
        '
        'cmdConnect
        '
        Me.cmdConnect.Arrow = PowerNET8.My7GlassButton.MB_Arrow.None
        Me.cmdConnect.BackColor = System.Drawing.Color.Transparent
        Me.cmdConnect.BaseColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cmdConnect.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdConnect.Enabled = False
        Me.cmdConnect.FlatAppearance.BorderSize = 0
        Me.cmdConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdConnect.GroupPosition = PowerNET8.My7GlassButton.MB_GroupPos.None
        Me.cmdConnect.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdConnect.Location = New System.Drawing.Point(294, 165)
        Me.cmdConnect.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdConnect.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmdConnect.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdConnect.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdConnect.ShowBase = PowerNET8.My7GlassButton.MB_ShowBase.Yes
        Me.cmdConnect.Size = New System.Drawing.Size(71, 27)
        Me.cmdConnect.SplitButton = PowerNET8.My7GlassButton.MB_SplitButton.No
        Me.cmdConnect.SplitLocation = PowerNET8.My7GlassButton.MB_SplitLocation.Bottom
        Me.cmdConnect.TabIndex = 11
        Me.cmdConnect.Text = "Connect"
        Me.cmdConnect.UseVisualStyleBackColor = True
        '
        't
        '
        Me.t.Arrow = PowerNET8.My7GlassButton.MB_Arrow.None
        Me.t.BackColor = System.Drawing.Color.Transparent
        Me.t.BaseColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.t.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.t.FlatAppearance.BorderSize = 0
        Me.t.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.t.GroupPosition = PowerNET8.My7GlassButton.MB_GroupPos.None
        Me.t.ImageSize = New System.Drawing.Size(24, 24)
        Me.t.Location = New System.Drawing.Point(226, 165)
        Me.t.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.t.Name = "t"
        Me.t.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.t.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.t.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.t.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.t.ShowBase = PowerNET8.My7GlassButton.MB_ShowBase.Yes
        Me.t.Size = New System.Drawing.Size(62, 27)
        Me.t.SplitButton = PowerNET8.My7GlassButton.MB_SplitButton.No
        Me.t.SplitLocation = PowerNET8.My7GlassButton.MB_SplitLocation.Bottom
        Me.t.TabIndex = 10
        Me.t.Text = "Test"
        Me.t.UseVisualStyleBackColor = True
        '
        'cboDatabase
        '
        Me.cboDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDatabase.FormattingEnabled = True
        Me.cboDatabase.Location = New System.Drawing.Point(105, 138)
        Me.cboDatabase.My_Border_Size = 1
        Me.cboDatabase.My_BorderColor_Hover = System.Drawing.Color.SteelBlue
        Me.cboDatabase.My_Corner = 3
        Me.cboDatabase.My_Event_Backcolor_Focus = System.Drawing.Color.White
        Me.cboDatabase.My_Event_Backcolor_Lostfocus = System.Drawing.Color.White
        Me.cboDatabase.My_Event_Fontcolor_Focus = System.Drawing.Color.Black
        Me.cboDatabase.My_Event_Forecolor_Lostfocus = System.Drawing.Color.Black
        Me.cboDatabase.My_Image_Icon_Style = PowerNET8.MyComboBoxExtension.ImageIconStyle.Left
        Me.cboDatabase.My_Image_Width = 25
        Me.cboDatabase.My_Selection_Style = PowerNET8.MyComboBoxExtension.SelectStyleType.Standard
        Me.cboDatabase.My_Selection_Style_Custom_Select_BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboDatabase.My_Selection_Style_Custom_Select_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboDatabase.My_Selection_Style_Custom_Select_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.cboDatabase.My_Selection_Style_Custom_Select_FontColor = System.Drawing.Color.DarkBlue
        Me.cboDatabase.My_Selection_Style_Custom_Select_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboDatabase.My_Selection_Style_Custom_Select_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cboDatabase.My_Selection_Style_Custom_UnSelect_BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.cboDatabase.My_Selection_Style_Custom_UnSelect_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.cboDatabase.My_Selection_Style_Custom_UnSelect_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.cboDatabase.My_Selection_Style_Custom_UnSelect_FontColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.cboDatabase.My_Selection_Style_Custom_UnSelect_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.cboDatabase.My_Selection_Style_Custom_UnSelect_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.cboDatabase.Name = "cboDatabase"
        Me.cboDatabase.Size = New System.Drawing.Size(260, 21)
        Me.cboDatabase.TabIndex = 9
        '
        'txtport
        '
        Me.txtport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtport.Location = New System.Drawing.Point(105, 108)
        Me.txtport.My_Border_Color_Hover = System.Drawing.Color.SteelBlue
        Me.txtport.My_Border_Size = 1
        Me.txtport.My_Character_Input_Style = PowerNET8.MyTextBoxExtension.Cinput.NumericOnly
        Me.txtport.My_Corner = 1
        Me.txtport.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.txtport.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.txtport.My_Event_Fontcolor_GotFocus = System.Drawing.Color.Black
        Me.txtport.My_Event_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.txtport.My_WaterMark_Color = System.Drawing.Color.Gray
        Me.txtport.My_WaterMark_Text = "[port]"
        Me.txtport.Name = "txtport"
        Me.txtport.Size = New System.Drawing.Size(260, 20)
        Me.txtport.TabIndex = 7
        Me.txtport.Text = "3306"
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtpassword.Location = New System.Drawing.Point(105, 79)
        Me.txtpassword.My_Border_Color_Hover = System.Drawing.Color.SteelBlue
        Me.txtpassword.My_Border_Size = 1
        Me.txtpassword.My_Character_Input_Style = PowerNET8.MyTextBoxExtension.Cinput.All
        Me.txtpassword.My_Corner = 1
        Me.txtpassword.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.txtpassword.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.txtpassword.My_Event_Fontcolor_GotFocus = System.Drawing.Color.Black
        Me.txtpassword.My_Event_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.txtpassword.My_WaterMark_Color = System.Drawing.Color.Gray
        Me.txtpassword.My_WaterMark_Text = "[password]"
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(260, 20)
        Me.txtpassword.TabIndex = 5
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtusername.Location = New System.Drawing.Point(105, 50)
        Me.txtusername.My_Border_Color_Hover = System.Drawing.Color.SteelBlue
        Me.txtusername.My_Border_Size = 1
        Me.txtusername.My_Character_Input_Style = PowerNET8.MyTextBoxExtension.Cinput.All
        Me.txtusername.My_Corner = 1
        Me.txtusername.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.txtusername.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.txtusername.My_Event_Fontcolor_GotFocus = System.Drawing.Color.Black
        Me.txtusername.My_Event_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.txtusername.My_WaterMark_Color = System.Drawing.Color.Gray
        Me.txtusername.My_WaterMark_Text = "[root]"
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(260, 20)
        Me.txtusername.TabIndex = 3
        '
        'txtLocalhost
        '
        Me.txtLocalhost.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLocalhost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtLocalhost.Location = New System.Drawing.Point(105, 24)
        Me.txtLocalhost.My_Border_Color_Hover = System.Drawing.Color.SteelBlue
        Me.txtLocalhost.My_Border_Size = 1
        Me.txtLocalhost.My_Character_Input_Style = PowerNET8.MyTextBoxExtension.Cinput.All
        Me.txtLocalhost.My_Corner = 1
        Me.txtLocalhost.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.txtLocalhost.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.txtLocalhost.My_Event_Fontcolor_GotFocus = System.Drawing.Color.Black
        Me.txtLocalhost.My_Event_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.txtLocalhost.My_WaterMark_Color = System.Drawing.Color.Gray
        Me.txtLocalhost.My_WaterMark_Text = "[localhost]"
        Me.txtLocalhost.Name = "txtLocalhost"
        Me.txtLocalhost.Size = New System.Drawing.Size(260, 20)
        Me.txtLocalhost.TabIndex = 1
        Me.txtLocalhost.Text = "LOCALHOST"
        '
        'frmXMLGeneratorSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 451)
        Me.ControlBox = False
        Me.Controls.Add(Me.frmContent)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmXMLGeneratorSQL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XML Generator SQL"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.frmContent.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frmContent As System.Windows.Forms.Panel
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txtsql As PowerNET8.MyTextBoxExtension
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttablename As PowerNET8.MyTextBoxExtension
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdappend As PowerNET8.My7GlassButton
    Friend WithEvents cmdExecute As PowerNET8.My7GlassButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdConnect As PowerNET8.My7GlassButton
    Friend WithEvents t As PowerNET8.My7GlassButton
    Friend WithEvents cboDatabase As PowerNET8.MyComboBoxExtension
    Friend WithEvents txtport As PowerNET8.MyTextBoxExtension
    Friend WithEvents txtpassword As PowerNET8.MyTextBoxExtension
    Friend WithEvents txtusername As PowerNET8.MyTextBoxExtension
    Friend WithEvents txtLocalhost As PowerNET8.MyTextBoxExtension
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstColumnName As PowerNET8.MyListBoxExtension
    Friend WithEvents MbGlassButton1 As PowerNET8.My7GlassButton
End Class
