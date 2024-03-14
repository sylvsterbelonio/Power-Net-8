<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myNavigationGrid
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(myNavigationGrid))
        Me.tsMain = New PowerNET8.MyToolStripExtension
        Me.cmdFirst = New System.Windows.Forms.ToolStripButton
        Me.cmdPrev = New System.Windows.Forms.ToolStripButton
        Me.txtPageNum = New System.Windows.Forms.ToolStripTextBox
        Me.lblPageTotal = New System.Windows.Forms.ToolStripLabel
        Me.cmdNext = New System.Windows.Forms.ToolStripButton
        Me.cmdLast = New System.Windows.Forms.ToolStripButton
        Me.cboPageType = New System.Windows.Forms.ToolStripComboBox
        Me.lblRemarks = New System.Windows.Forms.ToolStripLabel
        Me.tsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.AutoSize = False
        Me.tsMain.BackColor = System.Drawing.SystemColors.Control
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdFirst, Me.cmdPrev, Me.txtPageNum, Me.lblPageTotal, Me.cmdNext, Me.cmdLast, Me.cboPageType, Me.lblRemarks})
        Me.tsMain.Location = New System.Drawing.Point(1, 1)
        Me.tsMain.My_BackGround_BorderColor = System.Drawing.Color.White
        Me.tsMain.My_BackGround_BottomColor1 = System.Drawing.Color.LightGray
        Me.tsMain.My_BackGround_BottomColor2 = System.Drawing.Color.White
        Me.tsMain.My_BackGround_Has_Border = False
        Me.tsMain.My_BackGround_Style = PowerNET8.MyToolStripExtension.BackStyle.VerticalGradient
        Me.tsMain.My_BackGround_TopColor1 = System.Drawing.Color.White
        Me.tsMain.My_BackGround_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.tsMain.My_Selection_Style = PowerNET8.MyToolStripExtension.SelectStyleType.Standard
        Me.tsMain.My_Selection_Style_Custom_Select_BorderColor = System.Drawing.Color.Black
        Me.tsMain.My_Selection_Style_Custom_Select_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tsMain.My_Selection_Style_Custom_Select_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.tsMain.My_Selection_Style_Custom_Select_Has_Border = False
        Me.tsMain.My_Selection_Style_Custom_Select_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tsMain.My_Selection_Style_Custom_Select_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tsMain.My_Selection_Style_Custom_UnSelect_BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.tsMain.My_Selection_Style_Custom_UnSelect_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.tsMain.My_Selection_Style_Custom_UnSelect_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.tsMain.My_Selection_Style_Custom_UnSelect_Has_Border = False
        Me.tsMain.My_Selection_Style_Custom_UnSelect_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.tsMain.My_Selection_Style_Custom_UnSelect_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.tsMain.My_Standard_Select_FontColor = System.Drawing.Color.DarkBlue
        Me.tsMain.My_Standard_Selection_BackColor = System.Drawing.Color.SteelBlue
        Me.tsMain.My_Standard_UnSelect_FontColor = System.Drawing.Color.Black
        Me.tsMain.My_Transparent_Effect = False
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(498, 30)
        Me.tsMain.TabIndex = 1
        Me.tsMain.Text = "MyToolStripExtension1"
        '
        'cmdFirst
        '
        Me.cmdFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdFirst.Image = CType(resources.GetObject("cmdFirst.Image"), System.Drawing.Image)
        Me.cmdFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.Size = New System.Drawing.Size(23, 27)
        Me.cmdFirst.Tag = "ui-icon-seek-first"
        Me.cmdFirst.Text = "First Page"
        '
        'cmdPrev
        '
        Me.cmdPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPrev.Image = CType(resources.GetObject("cmdPrev.Image"), System.Drawing.Image)
        Me.cmdPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.Size = New System.Drawing.Size(23, 27)
        Me.cmdPrev.Tag = "ui-icon-triangle-1-w"
        Me.cmdPrev.Text = "Previous Page"
        '
        'txtPageNum
        '
        Me.txtPageNum.Name = "txtPageNum"
        Me.txtPageNum.Size = New System.Drawing.Size(50, 30)
        Me.txtPageNum.Text = "1"
        Me.txtPageNum.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPageTotal
        '
        Me.lblPageTotal.Name = "lblPageTotal"
        Me.lblPageTotal.Size = New System.Drawing.Size(18, 27)
        Me.lblPageTotal.Text = "/1"
        '
        'cmdNext
        '
        Me.cmdNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdNext.Image = CType(resources.GetObject("cmdNext.Image"), System.Drawing.Image)
        Me.cmdNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(23, 27)
        Me.cmdNext.Tag = "ui-icon-triangle-1-e"
        Me.cmdNext.Text = "Next Page"
        '
        'cmdLast
        '
        Me.cmdLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdLast.Image = CType(resources.GetObject("cmdLast.Image"), System.Drawing.Image)
        Me.cmdLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.Size = New System.Drawing.Size(23, 27)
        Me.cmdLast.Tag = "ui-icon-seek-end"
        Me.cmdLast.Text = "Last Page"
        '
        'cboPageType
        '
        Me.cboPageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPageType.Items.AddRange(New Object() {"5", "10", "25", "50", "75", "100", "250", "500", "750", "998", "1000"})
        Me.cboPageType.Name = "cboPageType"
        Me.cboPageType.Size = New System.Drawing.Size(75, 30)
        '
        'lblRemarks
        '
        Me.lblRemarks.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(62, 27)
        Me.lblRemarks.Text = "View - of -"
        Me.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'myNavigationGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tsMain)
        Me.Name = "myNavigationGrid"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(500, 32)
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tsMain As PowerNET8.MyToolStripExtension
    Friend WithEvents cmdFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPrev As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtPageNum As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lblPageTotal As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboPageType As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents lblRemarks As System.Windows.Forms.ToolStripLabel

End Class
