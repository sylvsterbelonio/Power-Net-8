<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PDB
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
        Me.components = New System.ComponentModel.Container
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.picIcon = New System.Windows.Forms.PictureBox
        Me.imgClose = New System.Windows.Forms.PictureBox
        Me.lblContent = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button3 = New PowerNET8.My8Button
        Me.Button2 = New PowerNET8.My8Button
        Me.Button1 = New PowerNET8.My8Button
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlContent.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContent
        '
        Me.pnlContent.Controls.Add(Me.SplitContainer1)
        Me.pnlContent.Controls.Add(Me.Panel1)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(304, 152)
        Me.pnlContent.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.ControlText
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.picIcon)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.imgClose)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblContent)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.SplitContainer1.Size = New System.Drawing.Size(304, 100)
        Me.SplitContainer1.SplitterDistance = 61
        Me.SplitContainer1.TabIndex = 2
        '
        'picIcon
        '
        Me.picIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.picIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picIcon.Image = Global.PowerNET8.My.Resources.Resources.report
        Me.picIcon.Location = New System.Drawing.Point(0, 0)
        Me.picIcon.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.picIcon.Size = New System.Drawing.Size(61, 100)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picIcon.TabIndex = 0
        Me.picIcon.TabStop = False
        '
        'imgClose
        '
        Me.imgClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgClose.Location = New System.Drawing.Point(223, 3)
        Me.imgClose.Name = "imgClose"
        Me.imgClose.Size = New System.Drawing.Size(26, 22)
        Me.imgClose.TabIndex = 1
        Me.imgClose.TabStop = False
        Me.imgClose.Visible = False
        '
        'lblContent
        '
        Me.lblContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContent.Location = New System.Drawing.Point(10, 10)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(219, 80)
        Me.lblContent.TabIndex = 0
        Me.lblContent.Text = "Label1"
        Me.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(304, 52)
        Me.Panel1.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.BorderColors = System.Drawing.Color.White
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.Button3.ImageSize = New System.Drawing.Size(24, 24)
        Me.Button3.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.Button3.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.Button3.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.Button3.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.Button3.Location = New System.Drawing.Point(-6, 10)
        Me.Button3.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Button3.MouseOverForecolor = System.Drawing.Color.White
        Me.Button3.MousePressedBackColor = System.Drawing.Color.White
        Me.Button3.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 32)
        Me.Button3.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Button 3"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'Button2
        '
        Me.Button2.BorderColors = System.Drawing.Color.White
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.Button2.ImageSize = New System.Drawing.Size(24, 24)
        Me.Button2.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.Button2.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.Button2.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.Button2.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.Button2.Location = New System.Drawing.Point(94, 10)
        Me.Button2.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Button2.MouseOverForecolor = System.Drawing.Color.White
        Me.Button2.MousePressedBackColor = System.Drawing.Color.White
        Me.Button2.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 32)
        Me.Button2.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button 2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'Button1
        '
        Me.Button1.BorderColors = System.Drawing.Color.White
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.Button1.ImageSize = New System.Drawing.Size(24, 24)
        Me.Button1.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.Button1.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.Button1.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.Button1.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.Button1.Location = New System.Drawing.Point(194, 10)
        Me.Button1.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Button1.MouseOverForecolor = System.Drawing.Color.White
        Me.Button1.MousePressedBackColor = System.Drawing.Color.White
        Me.Button1.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 32)
        Me.Button1.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button 1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'Timer2
        '
        '
        'PDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 152)
        Me.Controls.Add(Me.pnlContent)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(320, 190)
        Me.Name = "PDB"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "-"
        Me.pnlContent.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents Button3 As PowerNET8.My8Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As PowerNET8.My8Button
    Friend WithEvents Button2 As PowerNET8.My8Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents picIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblContent As System.Windows.Forms.Label
    Friend WithEvents imgClose As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
