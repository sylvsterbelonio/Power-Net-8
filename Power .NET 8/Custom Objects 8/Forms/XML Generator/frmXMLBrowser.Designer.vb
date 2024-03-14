<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXMLBrowser
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
        Me.frmContent = New System.Windows.Forms.Panel
        Me.cmdCancel = New PowerNET8.My7GlassButton
        Me.cmdBrowse = New PowerNET8.My7GlassButton
        Me.frmContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'frmContent
        '
        Me.frmContent.Controls.Add(Me.cmdCancel)
        Me.frmContent.Controls.Add(Me.cmdBrowse)
        Me.frmContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmContent.Location = New System.Drawing.Point(0, 0)
        Me.frmContent.Name = "frmContent"
        Me.frmContent.Size = New System.Drawing.Size(228, 53)
        Me.frmContent.TabIndex = 0
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
        Me.cmdCancel.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdCancel.Location = New System.Drawing.Point(117, 12)
        Me.cmdCancel.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdCancel.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmdCancel.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdCancel.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdCancel.ShowBase = PowerNET8.My7GlassButton.MB_ShowBase.Yes
        Me.cmdCancel.Size = New System.Drawing.Size(99, 27)
        Me.cmdCancel.SplitButton = PowerNET8.My7GlassButton.MB_SplitButton.No
        Me.cmdCancel.SplitLocation = PowerNET8.My7GlassButton.MB_SplitLocation.Bottom
        Me.cmdCancel.TabIndex = 11
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Arrow = PowerNET8.My7GlassButton.MB_Arrow.None
        Me.cmdBrowse.BackColor = System.Drawing.Color.Transparent
        Me.cmdBrowse.BaseColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cmdBrowse.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdBrowse.FlatAppearance.BorderSize = 0
        Me.cmdBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBrowse.GroupPosition = PowerNET8.My7GlassButton.MB_GroupPos.None
        Me.cmdBrowse.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdBrowse.Location = New System.Drawing.Point(12, 12)
        Me.cmdBrowse.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdBrowse.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmdBrowse.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdBrowse.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdBrowse.ShowBase = PowerNET8.My7GlassButton.MB_ShowBase.Yes
        Me.cmdBrowse.Size = New System.Drawing.Size(99, 27)
        Me.cmdBrowse.SplitButton = PowerNET8.My7GlassButton.MB_SplitButton.No
        Me.cmdBrowse.SplitLocation = PowerNET8.My7GlassButton.MB_SplitLocation.Bottom
        Me.cmdBrowse.TabIndex = 10
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'frmXMLBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(228, 53)
        Me.ControlBox = False
        Me.Controls.Add(Me.frmContent)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmXMLBrowser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "-"
        Me.frmContent.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frmContent As System.Windows.Forms.Panel
    Friend WithEvents cmdBrowse As PowerNET8.My7GlassButton
    Friend WithEvents cmdCancel As PowerNET8.My7GlassButton
End Class
