<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXMLGenerator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmXMLGenerator))
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.lblS = New System.Windows.Forms.Label
        Me.lstCType = New PowerNET8.MyListBoxExtension
        Me.cboType = New PowerNET8.MyComboBoxExtension
        Me.cmdCDel = New PowerNET8.My7GlassButton
        Me.cmdCEdit = New PowerNET8.My7GlassButton
        Me.cmdCAdd = New PowerNET8.My7GlassButton
        Me.txtCName = New PowerNET8.MyTextBoxExtension
        Me.lstC = New PowerNET8.MyListBoxExtension
        Me.cmdTDelete = New PowerNET8.My7GlassButton
        Me.cmdTEdit = New PowerNET8.My7GlassButton
        Me.cmdTAdd = New PowerNET8.My7GlassButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTName = New PowerNET8.MyTextBoxExtension
        Me.lstT = New PowerNET8.MyListBoxExtension
        Me.frmContent = New System.Windows.Forms.Panel
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.txtDataset = New PowerNET8.MyTextBoxExtension
        Me.Label1 = New System.Windows.Forms.Label
        Me.MyMenuStripExtension1 = New PowerNET8.MyMenuStripExtension
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoagSQLQueryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.UltraTabPageControl1.SuspendLayout()
        Me.frmContent.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.MyMenuStripExtension1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.lblS)
        Me.UltraTabPageControl1.Controls.Add(Me.lstCType)
        Me.UltraTabPageControl1.Controls.Add(Me.cboType)
        Me.UltraTabPageControl1.Controls.Add(Me.cmdCDel)
        Me.UltraTabPageControl1.Controls.Add(Me.cmdCEdit)
        Me.UltraTabPageControl1.Controls.Add(Me.cmdCAdd)
        Me.UltraTabPageControl1.Controls.Add(Me.txtCName)
        Me.UltraTabPageControl1.Controls.Add(Me.lstC)
        Me.UltraTabPageControl1.Controls.Add(Me.cmdTDelete)
        Me.UltraTabPageControl1.Controls.Add(Me.cmdTEdit)
        Me.UltraTabPageControl1.Controls.Add(Me.cmdTAdd)
        Me.UltraTabPageControl1.Controls.Add(Me.Label3)
        Me.UltraTabPageControl1.Controls.Add(Me.Label2)
        Me.UltraTabPageControl1.Controls.Add(Me.txtTName)
        Me.UltraTabPageControl1.Controls.Add(Me.lstT)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(590, 301)
        '
        'lblS
        '
        Me.lblS.ForeColor = System.Drawing.Color.Blue
        Me.lblS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblS.Location = New System.Drawing.Point(356, 16)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(225, 20)
        Me.lblS.TabIndex = 19
        Me.lblS.Text = "-"
        Me.lblS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lstCType
        '
        Me.lstCType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lstCType.FormattingEnabled = True
        Me.lstCType.Location = New System.Drawing.Point(485, 105)
        Me.lstCType.My_Border_Color = System.Drawing.Color.SteelBlue
        Me.lstCType.My_Border_Size = 0.5
        Me.lstCType.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.lstCType.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.lstCType.My_Highlight_Forecolor = System.Drawing.Color.White
        Me.lstCType.My_Image_Width_Additional = 0
        Me.lstCType.My_ImageAlign = PowerNET8.MyListBoxExtension.ImgAlign.left
        Me.lstCType.My_Normal_ForeColor = System.Drawing.Color.Black
        Me.lstCType.My_Selection_Style = PowerNET8.MyListBoxExtension.SelectStyleType.Standard
        Me.lstCType.My_Selection_Style_Custom_Select_BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lstCType.My_Selection_Style_Custom_Select_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lstCType.My_Selection_Style_Custom_Select_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lstCType.My_Selection_Style_Custom_Select_FontColor = System.Drawing.Color.Transparent
        Me.lstCType.My_Selection_Style_Custom_Select_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lstCType.My_Selection_Style_Custom_Select_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.lstCType.My_Selection_Style_Custom_UnSelect_BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lstCType.My_Selection_Style_Custom_UnSelect_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.lstCType.My_Selection_Style_Custom_UnSelect_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lstCType.My_Selection_Style_Custom_UnSelect_FontColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.lstCType.My_Selection_Style_Custom_UnSelect_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lstCType.My_Selection_Style_Custom_UnSelect_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lstCType.My_ShowImages = False
        Me.lstCType.My_TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lstCType.Name = "lstCType"
        Me.lstCType.SelectedItem = Nothing
        Me.lstCType.Size = New System.Drawing.Size(96, 186)
        Me.lstCType.TabIndex = 18
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"string", "integer", "positiveInteger", "date", "boolean", "language", "base64Binary"})
        Me.cboType.Location = New System.Drawing.Point(485, 45)
        Me.cboType.My_Border_Size = 1
        Me.cboType.My_BorderColor_Hover = System.Drawing.Color.SteelBlue
        Me.cboType.My_Corner = 3
        Me.cboType.My_Event_Backcolor_Focus = System.Drawing.Color.White
        Me.cboType.My_Event_Backcolor_Lostfocus = System.Drawing.Color.White
        Me.cboType.My_Event_Fontcolor_Focus = System.Drawing.Color.Black
        Me.cboType.My_Event_Forecolor_Lostfocus = System.Drawing.Color.Black
        Me.cboType.My_Image_Icon_Style = PowerNET8.MyComboBoxExtension.ImageIconStyle.Left
        Me.cboType.My_Image_Width = 25
        Me.cboType.My_Selection_Style = PowerNET8.MyComboBoxExtension.SelectStyleType.Standard
        Me.cboType.My_Selection_Style_Custom_Select_BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboType.My_Selection_Style_Custom_Select_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboType.My_Selection_Style_Custom_Select_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.cboType.My_Selection_Style_Custom_Select_FontColor = System.Drawing.Color.DarkBlue
        Me.cboType.My_Selection_Style_Custom_Select_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboType.My_Selection_Style_Custom_Select_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cboType.My_Selection_Style_Custom_UnSelect_BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.cboType.My_Selection_Style_Custom_UnSelect_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.cboType.My_Selection_Style_Custom_UnSelect_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.cboType.My_Selection_Style_Custom_UnSelect_FontColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.cboType.My_Selection_Style_Custom_UnSelect_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.cboType.My_Selection_Style_Custom_UnSelect_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(96, 21)
        Me.cboType.TabIndex = 17
        '
        'cmdCDel
        '
        Me.cmdCDel.Arrow = PowerNET8.My7GlassButton.MB_Arrow.None
        Me.cmdCDel.BackColor = System.Drawing.Color.Transparent
        Me.cmdCDel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cmdCDel.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdCDel.Enabled = False
        Me.cmdCDel.FlatAppearance.BorderSize = 0
        Me.cmdCDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCDel.GroupPosition = PowerNET8.My7GlassButton.MB_GroupPos.None
        Me.cmdCDel.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdCDel.Location = New System.Drawing.Point(536, 72)
        Me.cmdCDel.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.cmdCDel.Name = "cmdCDel"
        Me.cmdCDel.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdCDel.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmdCDel.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdCDel.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdCDel.ShowBase = PowerNET8.My7GlassButton.MB_ShowBase.Yes
        Me.cmdCDel.Size = New System.Drawing.Size(45, 27)
        Me.cmdCDel.SplitButton = PowerNET8.My7GlassButton.MB_SplitButton.No
        Me.cmdCDel.SplitLocation = PowerNET8.My7GlassButton.MB_SplitLocation.Bottom
        Me.cmdCDel.TabIndex = 16
        Me.cmdCDel.Text = "Del"
        Me.cmdCDel.UseVisualStyleBackColor = True
        '
        'cmdCEdit
        '
        Me.cmdCEdit.Arrow = PowerNET8.My7GlassButton.MB_Arrow.None
        Me.cmdCEdit.BackColor = System.Drawing.Color.Transparent
        Me.cmdCEdit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cmdCEdit.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdCEdit.Enabled = False
        Me.cmdCEdit.FlatAppearance.BorderSize = 0
        Me.cmdCEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCEdit.GroupPosition = PowerNET8.My7GlassButton.MB_GroupPos.None
        Me.cmdCEdit.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdCEdit.Location = New System.Drawing.Point(485, 72)
        Me.cmdCEdit.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.cmdCEdit.Name = "cmdCEdit"
        Me.cmdCEdit.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdCEdit.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmdCEdit.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdCEdit.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdCEdit.ShowBase = PowerNET8.My7GlassButton.MB_ShowBase.Yes
        Me.cmdCEdit.Size = New System.Drawing.Size(45, 27)
        Me.cmdCEdit.SplitButton = PowerNET8.My7GlassButton.MB_SplitButton.No
        Me.cmdCEdit.SplitLocation = PowerNET8.My7GlassButton.MB_SplitLocation.Bottom
        Me.cmdCEdit.TabIndex = 15
        Me.cmdCEdit.Text = "Edit"
        Me.cmdCEdit.UseVisualStyleBackColor = True
        '
        'cmdCAdd
        '
        Me.cmdCAdd.Arrow = PowerNET8.My7GlassButton.MB_Arrow.None
        Me.cmdCAdd.BackColor = System.Drawing.Color.Transparent
        Me.cmdCAdd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cmdCAdd.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdCAdd.FlatAppearance.BorderSize = 0
        Me.cmdCAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCAdd.GroupPosition = PowerNET8.My7GlassButton.MB_GroupPos.None
        Me.cmdCAdd.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdCAdd.Location = New System.Drawing.Point(417, 72)
        Me.cmdCAdd.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.cmdCAdd.Name = "cmdCAdd"
        Me.cmdCAdd.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdCAdd.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmdCAdd.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdCAdd.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdCAdd.ShowBase = PowerNET8.My7GlassButton.MB_ShowBase.Yes
        Me.cmdCAdd.Size = New System.Drawing.Size(62, 27)
        Me.cmdCAdd.SplitButton = PowerNET8.My7GlassButton.MB_SplitButton.No
        Me.cmdCAdd.SplitLocation = PowerNET8.My7GlassButton.MB_SplitLocation.Bottom
        Me.cmdCAdd.TabIndex = 14
        Me.cmdCAdd.Text = "Add"
        Me.cmdCAdd.UseVisualStyleBackColor = True
        '
        'txtCName
        '
        Me.txtCName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCName.Location = New System.Drawing.Point(280, 46)
        Me.txtCName.My_Border_Color_Hover = System.Drawing.Color.SteelBlue
        Me.txtCName.My_Border_Size = 1
        Me.txtCName.My_Character_Input_Style = PowerNET8.MyTextBoxExtension.Cinput.All
        Me.txtCName.My_Corner = 1
        Me.txtCName.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.txtCName.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.txtCName.My_Event_Fontcolor_GotFocus = System.Drawing.Color.Black
        Me.txtCName.My_Event_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.txtCName.My_WaterMark_Color = System.Drawing.Color.Gray
        Me.txtCName.My_WaterMark_Text = "Enter Column Name Here"
        Me.txtCName.Name = "txtCName"
        Me.txtCName.Size = New System.Drawing.Size(199, 20)
        Me.txtCName.TabIndex = 13
        '
        'lstC
        '
        Me.lstC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lstC.FormattingEnabled = True
        Me.lstC.Location = New System.Drawing.Point(279, 105)
        Me.lstC.My_Border_Color = System.Drawing.Color.SteelBlue
        Me.lstC.My_Border_Size = 0.5
        Me.lstC.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.lstC.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.lstC.My_Highlight_Forecolor = System.Drawing.Color.White
        Me.lstC.My_Image_Width_Additional = 0
        Me.lstC.My_ImageAlign = PowerNET8.MyListBoxExtension.ImgAlign.left
        Me.lstC.My_Normal_ForeColor = System.Drawing.Color.Black
        Me.lstC.My_Selection_Style = PowerNET8.MyListBoxExtension.SelectStyleType.Standard
        Me.lstC.My_Selection_Style_Custom_Select_BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lstC.My_Selection_Style_Custom_Select_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lstC.My_Selection_Style_Custom_Select_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lstC.My_Selection_Style_Custom_Select_FontColor = System.Drawing.Color.Transparent
        Me.lstC.My_Selection_Style_Custom_Select_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lstC.My_Selection_Style_Custom_Select_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.lstC.My_Selection_Style_Custom_UnSelect_BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lstC.My_Selection_Style_Custom_UnSelect_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.lstC.My_Selection_Style_Custom_UnSelect_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lstC.My_Selection_Style_Custom_UnSelect_FontColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.lstC.My_Selection_Style_Custom_UnSelect_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lstC.My_Selection_Style_Custom_UnSelect_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lstC.My_ShowImages = False
        Me.lstC.My_TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lstC.Name = "lstC"
        Me.lstC.SelectedItem = Nothing
        Me.lstC.Size = New System.Drawing.Size(200, 186)
        Me.lstC.TabIndex = 12
        '
        'cmdTDelete
        '
        Me.cmdTDelete.Arrow = PowerNET8.My7GlassButton.MB_Arrow.None
        Me.cmdTDelete.BackColor = System.Drawing.Color.Transparent
        Me.cmdTDelete.BaseColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cmdTDelete.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdTDelete.Enabled = False
        Me.cmdTDelete.FlatAppearance.BorderSize = 0
        Me.cmdTDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTDelete.GroupPosition = PowerNET8.My7GlassButton.MB_GroupPos.None
        Me.cmdTDelete.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdTDelete.Location = New System.Drawing.Point(228, 72)
        Me.cmdTDelete.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.cmdTDelete.Name = "cmdTDelete"
        Me.cmdTDelete.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdTDelete.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmdTDelete.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdTDelete.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdTDelete.ShowBase = PowerNET8.My7GlassButton.MB_ShowBase.Yes
        Me.cmdTDelete.Size = New System.Drawing.Size(45, 27)
        Me.cmdTDelete.SplitButton = PowerNET8.My7GlassButton.MB_SplitButton.No
        Me.cmdTDelete.SplitLocation = PowerNET8.My7GlassButton.MB_SplitLocation.Bottom
        Me.cmdTDelete.TabIndex = 11
        Me.cmdTDelete.Text = "Del"
        Me.cmdTDelete.UseVisualStyleBackColor = True
        '
        'cmdTEdit
        '
        Me.cmdTEdit.Arrow = PowerNET8.My7GlassButton.MB_Arrow.None
        Me.cmdTEdit.BackColor = System.Drawing.Color.Transparent
        Me.cmdTEdit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cmdTEdit.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdTEdit.Enabled = False
        Me.cmdTEdit.FlatAppearance.BorderSize = 0
        Me.cmdTEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTEdit.GroupPosition = PowerNET8.My7GlassButton.MB_GroupPos.None
        Me.cmdTEdit.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdTEdit.Location = New System.Drawing.Point(177, 72)
        Me.cmdTEdit.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.cmdTEdit.Name = "cmdTEdit"
        Me.cmdTEdit.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdTEdit.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmdTEdit.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdTEdit.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdTEdit.ShowBase = PowerNET8.My7GlassButton.MB_ShowBase.Yes
        Me.cmdTEdit.Size = New System.Drawing.Size(45, 27)
        Me.cmdTEdit.SplitButton = PowerNET8.My7GlassButton.MB_SplitButton.No
        Me.cmdTEdit.SplitLocation = PowerNET8.My7GlassButton.MB_SplitLocation.Bottom
        Me.cmdTEdit.TabIndex = 10
        Me.cmdTEdit.Text = "Edit"
        Me.cmdTEdit.UseVisualStyleBackColor = True
        '
        'cmdTAdd
        '
        Me.cmdTAdd.Arrow = PowerNET8.My7GlassButton.MB_Arrow.None
        Me.cmdTAdd.BackColor = System.Drawing.Color.Transparent
        Me.cmdTAdd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cmdTAdd.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdTAdd.FlatAppearance.BorderSize = 0
        Me.cmdTAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTAdd.GroupPosition = PowerNET8.My7GlassButton.MB_GroupPos.None
        Me.cmdTAdd.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdTAdd.Location = New System.Drawing.Point(110, 72)
        Me.cmdTAdd.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.cmdTAdd.Name = "cmdTAdd"
        Me.cmdTAdd.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdTAdd.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmdTAdd.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdTAdd.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdTAdd.ShowBase = PowerNET8.My7GlassButton.MB_ShowBase.Yes
        Me.cmdTAdd.Size = New System.Drawing.Size(61, 27)
        Me.cmdTAdd.SplitButton = PowerNET8.My7GlassButton.MB_SplitButton.No
        Me.cmdTAdd.SplitLocation = PowerNET8.My7GlassButton.MB_SplitLocation.Bottom
        Me.cmdTAdd.TabIndex = 9
        Me.cmdTAdd.Text = "Add"
        Me.cmdTAdd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(277, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Column Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Table Name"
        '
        'txtTName
        '
        Me.txtTName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTName.Location = New System.Drawing.Point(11, 46)
        Me.txtTName.My_Border_Color_Hover = System.Drawing.Color.SteelBlue
        Me.txtTName.My_Border_Size = 1
        Me.txtTName.My_Character_Input_Style = PowerNET8.MyTextBoxExtension.Cinput.All
        Me.txtTName.My_Corner = 1
        Me.txtTName.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.txtTName.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.txtTName.My_Event_Fontcolor_GotFocus = System.Drawing.Color.Black
        Me.txtTName.My_Event_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.txtTName.My_WaterMark_Color = System.Drawing.Color.Gray
        Me.txtTName.My_WaterMark_Text = "Enter Tablename Here"
        Me.txtTName.Name = "txtTName"
        Me.txtTName.Size = New System.Drawing.Size(263, 20)
        Me.txtTName.TabIndex = 1
        '
        'lstT
        '
        Me.lstT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lstT.FormattingEnabled = True
        Me.lstT.Location = New System.Drawing.Point(10, 105)
        Me.lstT.My_Border_Color = System.Drawing.Color.SteelBlue
        Me.lstT.My_Border_Size = 0.5
        Me.lstT.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.lstT.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.lstT.My_Highlight_Forecolor = System.Drawing.Color.White
        Me.lstT.My_Image_Width_Additional = 0
        Me.lstT.My_ImageAlign = PowerNET8.MyListBoxExtension.ImgAlign.left
        Me.lstT.My_Normal_ForeColor = System.Drawing.Color.Black
        Me.lstT.My_Selection_Style = PowerNET8.MyListBoxExtension.SelectStyleType.Standard
        Me.lstT.My_Selection_Style_Custom_Select_BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lstT.My_Selection_Style_Custom_Select_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lstT.My_Selection_Style_Custom_Select_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lstT.My_Selection_Style_Custom_Select_FontColor = System.Drawing.Color.Transparent
        Me.lstT.My_Selection_Style_Custom_Select_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lstT.My_Selection_Style_Custom_Select_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.lstT.My_Selection_Style_Custom_UnSelect_BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.lstT.My_Selection_Style_Custom_UnSelect_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.lstT.My_Selection_Style_Custom_UnSelect_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lstT.My_Selection_Style_Custom_UnSelect_FontColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.lstT.My_Selection_Style_Custom_UnSelect_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lstT.My_Selection_Style_Custom_UnSelect_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lstT.My_ShowImages = False
        Me.lstT.My_TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lstT.Name = "lstT"
        Me.lstT.SelectedItem = Nothing
        Me.lstT.Size = New System.Drawing.Size(263, 186)
        Me.lstT.TabIndex = 0
        '
        'frmContent
        '
        Me.frmContent.Controls.Add(Me.UltraTabControl1)
        Me.frmContent.Controls.Add(Me.txtDataset)
        Me.frmContent.Controls.Add(Me.Label1)
        Me.frmContent.Controls.Add(Me.MyMenuStripExtension1)
        Me.frmContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmContent.Location = New System.Drawing.Point(0, 0)
        Me.frmContent.Name = "frmContent"
        Me.frmContent.Size = New System.Drawing.Size(622, 405)
        Me.frmContent.TabIndex = 0
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Location = New System.Drawing.Point(12, 64)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(594, 327)
        Me.UltraTabControl1.TabIndex = 3
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "XML Editor"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(590, 301)
        '
        'txtDataset
        '
        Me.txtDataset.AccessibleDescription = ""
        Me.txtDataset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDataset.Location = New System.Drawing.Point(102, 38)
        Me.txtDataset.My_Border_Color_Hover = System.Drawing.Color.SteelBlue
        Me.txtDataset.My_Border_Size = 1
        Me.txtDataset.My_Character_Input_Style = PowerNET8.MyTextBoxExtension.Cinput.All
        Me.txtDataset.My_Corner = 1
        Me.txtDataset.My_Event_Backcolor_GotFocus = System.Drawing.Color.White
        Me.txtDataset.My_Event_Backcolor_LostFocus = System.Drawing.Color.White
        Me.txtDataset.My_Event_Fontcolor_GotFocus = System.Drawing.Color.Black
        Me.txtDataset.My_Event_Fontcolor_LostFocus = System.Drawing.Color.Black
        Me.txtDataset.My_WaterMark_Color = System.Drawing.Color.Gray
        Me.txtDataset.My_WaterMark_Text = "Enter Dataset Name Here"
        Me.txtDataset.Name = "txtDataset"
        Me.txtDataset.Size = New System.Drawing.Size(492, 20)
        Me.txtDataset.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dataset Name"
        '
        'MyMenuStripExtension1
        '
        Me.MyMenuStripExtension1.BackColor = System.Drawing.Color.Silver
        Me.MyMenuStripExtension1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MyMenuStripExtension1.Location = New System.Drawing.Point(0, 0)
        Me.MyMenuStripExtension1.My_BackGround_BorderColor = System.Drawing.Color.SteelBlue
        Me.MyMenuStripExtension1.My_BackGround_BottomColor1 = System.Drawing.Color.LightGray
        Me.MyMenuStripExtension1.My_BackGround_BottomColor2 = System.Drawing.Color.White
        Me.MyMenuStripExtension1.My_BackGround_HasBorder = False
        Me.MyMenuStripExtension1.My_BackGround_Style = PowerNET8.MyMenuStripExtension.BackStyle.Standard
        Me.MyMenuStripExtension1.My_BackGround_TopColor1 = System.Drawing.Color.White
        Me.MyMenuStripExtension1.My_BackGround_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.MyMenuStripExtension1.My_Selection_Style = PowerNET8.MyMenuStripExtension.SelectStyleType.Standard
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_Select_BorderColor = System.Drawing.Color.Black
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_Select_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_Select_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_Select_Has_Border = False
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_Select_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_Select_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_UnSelect_BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_UnSelect_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_UnSelect_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_UnSelect_Has_Border = False
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_UnSelect_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_UnSelect_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.MyMenuStripExtension1.My_Standard_Select_FontColor = System.Drawing.Color.White
        Me.MyMenuStripExtension1.My_Standard_Selection_BackColor = System.Drawing.Color.SteelBlue
        Me.MyMenuStripExtension1.My_Standard_UnSelect_FontColor = System.Drawing.Color.Black
        Me.MyMenuStripExtension1.Name = "MyMenuStripExtension1"
        Me.MyMenuStripExtension1.Size = New System.Drawing.Size(622, 24)
        Me.MyMenuStripExtension1.TabIndex = 10
        Me.MyMenuStripExtension1.Text = "MyMenuStripExtension1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ExportXMLToolStripMenuItem, Me.ExitToolStripMenuItem1, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem3})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "New"
        '
        'ExportXMLToolStripMenuItem
        '
        Me.ExportXMLToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ExportXMLToolStripMenuItem.Name = "ExportXMLToolStripMenuItem"
        Me.ExportXMLToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ExportXMLToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportXMLToolStripMenuItem.Text = "Open"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem1.Text = "Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem3
        '
        Me.ExitToolStripMenuItem3.ForeColor = System.Drawing.Color.Black
        Me.ExitToolStripMenuItem3.Name = "ExitToolStripMenuItem3"
        Me.ExitToolStripMenuItem3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem3.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoagSQLQueryToolStripMenuItem})
        Me.ViewToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'LoagSQLQueryToolStripMenuItem
        '
        Me.LoagSQLQueryToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.LoagSQLQueryToolStripMenuItem.Name = "LoagSQLQueryToolStripMenuItem"
        Me.LoagSQLQueryToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.LoagSQLQueryToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.LoagSQLQueryToolStripMenuItem.Text = "SQL Builder"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'frmXMLGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 405)
        Me.Controls.Add(Me.frmContent)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MyMenuStripExtension1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmXMLGenerator"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XML Generator - v1.1"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        Me.frmContent.ResumeLayout(False)
        Me.frmContent.PerformLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.MyMenuStripExtension1.ResumeLayout(False)
        Me.MyMenuStripExtension1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frmContent As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txtDataset As PowerNET8.MyTextBoxExtension
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTName As PowerNET8.MyTextBoxExtension
    Friend WithEvents lstT As PowerNET8.MyListBoxExtension
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdTDelete As PowerNET8.My7GlassButton
    Friend WithEvents cmdTEdit As PowerNET8.My7GlassButton
    Friend WithEvents cmdTAdd As PowerNET8.My7GlassButton
    Friend WithEvents cmdCDel As PowerNET8.My7GlassButton
    Friend WithEvents cmdCEdit As PowerNET8.My7GlassButton
    Friend WithEvents cmdCAdd As PowerNET8.My7GlassButton
    Friend WithEvents txtCName As PowerNET8.MyTextBoxExtension
    Friend WithEvents lstC As PowerNET8.MyListBoxExtension
    Friend WithEvents cboType As PowerNET8.MyComboBoxExtension
    Friend WithEvents lstCType As PowerNET8.MyListBoxExtension
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lblS As System.Windows.Forms.Label
    Friend WithEvents MyMenuStripExtension1 As PowerNET8.MyMenuStripExtension
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportXMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoagSQLQueryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
End Class
