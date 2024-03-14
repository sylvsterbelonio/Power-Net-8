<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class My7LabelTextBox
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
        Me.components = New System.ComponentModel.Container
        Me.lblDisplay = New System.Windows.Forms.Label
        Me.txtDisplay = New System.Windows.Forms.TextBox
        Me.ttDisplay = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblDisplay
        '
        Me.lblDisplay.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDisplay.Location = New System.Drawing.Point(3, 3)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(466, 20)
        Me.lblDisplay.TabIndex = 0
        Me.lblDisplay.Text = "Label1"
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(6, 26)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(234, 20)
        Me.txtDisplay.TabIndex = 1
        Me.txtDisplay.Visible = False
        '
        'MyLabelTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.lblDisplay)
        Me.MaximumSize = New System.Drawing.Size(1000, 24)
        Me.MinimumSize = New System.Drawing.Size(50, 24)
        Me.Name = "MyLabelTextBox"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(472, 24)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents txtDisplay As System.Windows.Forms.TextBox
    Friend WithEvents ttDisplay As System.Windows.Forms.ToolTip

End Class
