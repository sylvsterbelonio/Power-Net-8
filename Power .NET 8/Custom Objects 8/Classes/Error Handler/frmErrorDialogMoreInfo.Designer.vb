<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmErrorDialogMoreInfo
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
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.btnCopy = New System.Windows.Forms.Button
        Me.btnSend = New System.Windows.Forms.Button
        Me.txtFullText = New System.Windows.Forms.TextBox
        Me.lblErr = New System.Windows.Forms.Label
        Me.pnlContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContent
        '
        Me.pnlContent.Controls.Add(Me.btnCopy)
        Me.pnlContent.Controls.Add(Me.btnSend)
        Me.pnlContent.Controls.Add(Me.txtFullText)
        Me.pnlContent.Controls.Add(Me.lblErr)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(543, 405)
        Me.pnlContent.TabIndex = 0
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCopy.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCopy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCopy.Location = New System.Drawing.Point(325, 364)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(100, 30)
        Me.btnCopy.TabIndex = 22
        Me.btnCopy.Text = "C&opy"
        '
        'btnSend
        '
        Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSend.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSend.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSend.Location = New System.Drawing.Point(431, 364)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(100, 30)
        Me.btnSend.TabIndex = 21
        Me.btnSend.Text = "&Close"
        '
        'txtFullText
        '
        Me.txtFullText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFullText.Location = New System.Drawing.Point(12, 53)
        Me.txtFullText.Multiline = True
        Me.txtFullText.Name = "txtFullText"
        Me.txtFullText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtFullText.Size = New System.Drawing.Size(519, 305)
        Me.txtFullText.TabIndex = 20
        '
        'lblErr
        '
        Me.lblErr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblErr.Location = New System.Drawing.Point(12, 13)
        Me.lblErr.Name = "lblErr"
        Me.lblErr.Size = New System.Drawing.Size(519, 30)
        Me.lblErr.TabIndex = 19
        Me.lblErr.Text = "The following text is what will be contained in the error report. You may also cl" & _
            "ick the Copy button to copy this text to the clipboard."
        '
        'frmErrorDialogMoreInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 405)
        Me.Controls.Add(Me.pnlContent)
        Me.Name = "frmErrorDialogMoreInfo"
        Me.Text = "frmErrorDialogMoreInfo"
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents txtFullText As System.Windows.Forms.TextBox
    Friend WithEvents lblErr As System.Windows.Forms.Label
End Class
