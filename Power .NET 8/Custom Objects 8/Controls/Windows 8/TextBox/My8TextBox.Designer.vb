<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class My8TextBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(My8TextBox))
        Me.txtSearchBox = New System.Windows.Forms.TextBox
        Me.cmdClose = New System.Windows.Forms.PictureBox
        Me.cmdSearch = New PowerNET8.My8Button
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearchBox
        '
        Me.txtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchBox.Location = New System.Drawing.Point(4, 6)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(100, 13)
        Me.txtSearchBox.TabIndex = 5
        '
        'cmdClose
        '
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdClose.Location = New System.Drawing.Point(208, 2)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(24, 22)
        Me.cmdClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.TabStop = False
        Me.cmdClose.Visible = False
        '
        'cmdSearch
        '
        Me.cmdSearch.BorderColors = System.Drawing.Color.White
        Me.cmdSearch.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdSearch.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearch.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdSearch.Image = CType(resources.GetObject("cmdSearch.Image"), System.Drawing.Image)
        Me.cmdSearch.ImageSize = New System.Drawing.Size(16, 16)
        Me.cmdSearch.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.cmdSearch.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.search
        Me.cmdSearch.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdSearch.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdSearch.Location = New System.Drawing.Point(232, 2)
        Me.cmdSearch.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmdSearch.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdSearch.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdSearch.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(28, 22)
        Me.cmdSearch.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.cmdSearch.TabIndex = 3
        Me.cmdSearch.TabStop = False
        Me.cmdSearch.UseMnemonic = False
        Me.cmdSearch.UseVisualStyleBackColor = False
        Me.cmdSearch.Visible = False
        Me.cmdSearch.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'My8TextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.txtSearchBox)
        Me.MaximumSize = New System.Drawing.Size(1024, 26)
        Me.MinimumSize = New System.Drawing.Size(50, 26)
        Me.Name = "My8TextBox"
        Me.Padding = New System.Windows.Forms.Padding(0, 2, 2, 2)
        Me.Size = New System.Drawing.Size(262, 26)
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSearch As PowerNET8.My8Button
    Friend WithEvents cmdClose As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearchBox As System.Windows.Forms.TextBox

End Class
