<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iconCropper
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtY = New System.Windows.Forms.TextBox
        Me.txtHeight = New System.Windows.Forms.TextBox
        Me.txtWidth = New System.Windows.Forms.TextBox
        Me.txtX = New System.Windows.Forms.TextBox
        Me.picImage = New System.Windows.Forms.PictureBox
        Me.cmdCrop = New PowerNET8.My8Button
        Me.My8Button1 = New PowerNET8.My8Button
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(155, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Height"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(155, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Width"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Y"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "X"
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(32, 53)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(100, 20)
        Me.txtY.TabIndex = 15
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(209, 53)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtHeight.TabIndex = 14
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(209, 27)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth.TabIndex = 13
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(32, 27)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(100, 20)
        Me.txtX.TabIndex = 12
        '
        'picImage
        '
        Me.picImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.picImage.Image = Global.PowerNET8.My.Resources.Resources.DialogBoxIcon
        Me.picImage.Location = New System.Drawing.Point(330, 27)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(453, 338)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picImage.TabIndex = 20
        Me.picImage.TabStop = False
        '
        'cmdCrop
        '
        Me.cmdCrop.BorderColors = System.Drawing.Color.White
        Me.cmdCrop.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdCrop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdCrop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmdCrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCrop.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdCrop.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdCrop.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.cmdCrop.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdCrop.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdCrop.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdCrop.Location = New System.Drawing.Point(15, 79)
        Me.cmdCrop.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmdCrop.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdCrop.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdCrop.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cmdCrop.Name = "cmdCrop"
        Me.cmdCrop.Size = New System.Drawing.Size(294, 37)
        Me.cmdCrop.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.cmdCrop.TabIndex = 21
        Me.cmdCrop.Text = "Crop"
        Me.cmdCrop.UseVisualStyleBackColor = True
        Me.cmdCrop.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'My8Button1
        '
        Me.My8Button1.BorderColors = System.Drawing.Color.White
        Me.My8Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.My8Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.My8Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.My8Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.My8Button1.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.My8Button1.ImageSize = New System.Drawing.Size(24, 24)
        Me.My8Button1.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.My8Button1.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.My8Button1.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.My8Button1.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.My8Button1.Location = New System.Drawing.Point(15, 294)
        Me.My8Button1.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.My8Button1.MouseOverForecolor = System.Drawing.Color.White
        Me.My8Button1.MousePressedBackColor = System.Drawing.Color.White
        Me.My8Button1.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.My8Button1.Name = "My8Button1"
        Me.My8Button1.Size = New System.Drawing.Size(294, 37)
        Me.My8Button1.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.My8Button1.TabIndex = 22
        Me.My8Button1.Text = "Dialog Icon"
        Me.My8Button1.UseVisualStyleBackColor = True
        Me.My8Button1.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'iconCropper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 361)
        Me.Controls.Add(Me.My8Button1)
        Me.Controls.Add(Me.cmdCrop)
        Me.Controls.Add(Me.picImage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtY)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtX)
        Me.Name = "iconCropper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "iconCropper"
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picImage As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtY As System.Windows.Forms.TextBox
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtX As System.Windows.Forms.TextBox
    Friend WithEvents cmdCrop As PowerNET8.My8Button
    Friend WithEvents My8Button1 As PowerNET8.My8Button
End Class
