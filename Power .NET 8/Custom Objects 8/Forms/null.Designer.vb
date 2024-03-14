<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class null
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(null))
        Me.txtX = New System.Windows.Forms.TextBox
        Me.txtY = New System.Windows.Forms.TextBox
        Me.txtHeight = New System.Windows.Forms.TextBox
        Me.txtWidth = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.AccentColor1 = New PowerNET8.My8AccentColor
        Me.BackgroundColor1 = New PowerNET8.My8BackgroundColor
        Me.My8Button1 = New PowerNET8.My8Button
        Me.My8Button3 = New PowerNET8.My8Button
        Me.pnlContent.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(22, 186)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(71, 20)
        Me.txtX.TabIndex = 3
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(22, 212)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(71, 20)
        Me.txtY.TabIndex = 4
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(147, 212)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(71, 20)
        Me.txtHeight.TabIndex = 6
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(147, 186)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(71, 20)
        Me.txtWidth.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Y"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(111, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Width"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(111, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Height"
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlContent.Controls.Add(Me.AccentColor1)
        Me.pnlContent.Controls.Add(Me.BackgroundColor1)
        Me.pnlContent.Controls.Add(Me.My8Button1)
        Me.pnlContent.Controls.Add(Me.My8Button3)
        Me.pnlContent.Controls.Add(Me.Button1)
        Me.pnlContent.Controls.Add(Me.PictureBox2)
        Me.pnlContent.Controls.Add(Me.Label4)
        Me.pnlContent.Controls.Add(Me.txtX)
        Me.pnlContent.Controls.Add(Me.Label3)
        Me.pnlContent.Controls.Add(Me.txtY)
        Me.pnlContent.Controls.Add(Me.Label2)
        Me.pnlContent.Controls.Add(Me.txtWidth)
        Me.pnlContent.Controls.Add(Me.Label1)
        Me.pnlContent.Controls.Add(Me.txtHeight)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlContent.Size = New System.Drawing.Size(804, 508)
        Me.pnlContent.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Image = Global.PowerNET8.My.Resources.Resources.ui_icons_cd0a0a_256x240
        Me.Button1.Location = New System.Drawing.Point(198, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 66)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Red
        Me.PictureBox2.Image = Global.PowerNET8.My.Resources.Resources.TitleBarIcons4
        Me.PictureBox2.Location = New System.Drawing.Point(227, 31)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'AccentColor1
        '
        Me.AccentColor1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.AccentColor1.ColorNameTag = "A6"
        Me.AccentColor1.groupColorNameTag = "cyan"
        Me.AccentColor1.Location = New System.Drawing.Point(378, 238)
        Me.AccentColor1.MaximumSize = New System.Drawing.Size(373, 158)
        Me.AccentColor1.MinimumSize = New System.Drawing.Size(373, 158)
        Me.AccentColor1.Name = "AccentColor1"
        Me.AccentColor1.Size = New System.Drawing.Size(373, 158)
        Me.AccentColor1.TabIndex = 16
        '
        'BackgroundColor1
        '
        Me.BackgroundColor1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BackgroundColor1.ColorNameTag = "A6"
        Me.BackgroundColor1.ForeColor = System.Drawing.Color.Silver
        Me.BackgroundColor1.groupColorNameTag = "cyan"
        Me.BackgroundColor1.Location = New System.Drawing.Point(378, 29)
        Me.BackgroundColor1.MaximumSize = New System.Drawing.Size(373, 203)
        Me.BackgroundColor1.MinimumSize = New System.Drawing.Size(373, 203)
        Me.BackgroundColor1.Name = "BackgroundColor1"
        Me.BackgroundColor1.Size = New System.Drawing.Size(373, 203)
        Me.BackgroundColor1.TabIndex = 15
        '
        'My8Button1
        '
        Me.My8Button1.BorderColors = System.Drawing.Color.White
        Me.My8Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.My8Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.My8Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.My8Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.My8Button1.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.My8Button1.Image = CType(resources.GetObject("My8Button1.Image"), System.Drawing.Image)
        Me.My8Button1.ImageSize = New System.Drawing.Size(48, 48)
        Me.My8Button1.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconColor.Black
        Me.My8Button1.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.triangle_1_ne
        Me.My8Button1.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.My8Button1.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.My8Button1.Location = New System.Drawing.Point(127, 56)
        Me.My8Button1.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.My8Button1.MouseOverForecolor = System.Drawing.Color.White
        Me.My8Button1.MousePressedBackColor = System.Drawing.Color.White
        Me.My8Button1.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.My8Button1.Name = "My8Button1"
        Me.My8Button1.Size = New System.Drawing.Size(75, 74)
        Me.My8Button1.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.My8Button1.TabIndex = 0
        Me.My8Button1.UseVisualStyleBackColor = False
        Me.My8Button1.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'My8Button3
        '
        Me.My8Button3.BorderColors = System.Drawing.Color.White
        Me.My8Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.My8Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.My8Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.My8Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.My8Button3.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Windows8
        Me.My8Button3.Image = CType(resources.GetObject("My8Button3.Image"), System.Drawing.Image)
        Me.My8Button3.ImageSize = New System.Drawing.Size(32, 32)
        Me.My8Button3.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconColor.NotSet
        Me.My8Button3.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.My8Button3.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.My8Button3.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.My8Button3.Location = New System.Drawing.Point(19, 251)
        Me.My8Button3.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.My8Button3.MouseOverForecolor = System.Drawing.Color.White
        Me.My8Button3.MousePressedBackColor = System.Drawing.Color.White
        Me.My8Button3.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.My8Button3.Name = "My8Button3"
        Me.My8Button3.Size = New System.Drawing.Size(173, 74)
        Me.My8Button3.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Orange
        Me.My8Button3.TabIndex = 14
        Me.My8Button3.Text = "Crop"
        Me.My8Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.My8Button3.UseVisualStyleBackColor = False
        Me.My8Button3.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.no
        '
        'null
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 508)
        Me.Controls.Add(Me.pnlContent)
        Me.Name = "null"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "null"
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents My8Button1 As PowerNET8.My8Button
    Friend WithEvents txtX As System.Windows.Forms.TextBox
    Friend WithEvents txtY As System.Windows.Forms.TextBox
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents My8Button3 As PowerNET8.My8Button
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents AccentColor1 As PowerNET8.My8AccentColor
    Friend WithEvents BackgroundColor1 As PowerNET8.My8BackgroundColor

End Class
