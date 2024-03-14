<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myLineSeparatorLabel
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
        Me.lblLabel = New PowerNET8.gLabel
        Me.SuspendLayout()
        '
        'lblLabel
        '
        Me.lblLabel.BorderColor = System.Drawing.Color.Blue
        Me.lblLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLabel.Glow = 2
        Me.lblLabel.GlowColor = System.Drawing.Color.SkyBlue
        Me.lblLabel.Location = New System.Drawing.Point(-1, -1)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(16, 18)
        Me.lblLabel.TabIndex = 0
        Me.lblLabel.Text = "-"
        Me.lblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'myLineSeparatorLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblLabel)
        Me.Name = "myLineSeparatorLabel"
        Me.Size = New System.Drawing.Size(500, 18)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblLabel As PowerNET8.gLabel

End Class
