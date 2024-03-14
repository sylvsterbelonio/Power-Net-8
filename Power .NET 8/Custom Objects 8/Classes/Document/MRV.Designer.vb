<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MRV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MRV))
        Me.rptMicrosoftReportViewer = New Microsoft.Reporting.WinForms.ReportViewer
        Me.frmContent = New System.Windows.Forms.Panel
        Me.frmContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'rptMicrosoftReportViewer
        '
        Me.rptMicrosoftReportViewer.BackColor = System.Drawing.Color.Gainsboro
        Me.rptMicrosoftReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rptMicrosoftReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptMicrosoftReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.rptMicrosoftReportViewer.Name = "rptMicrosoftReportViewer"
        Me.rptMicrosoftReportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.rptMicrosoftReportViewer.ServerReport.ReportServerUrl = New System.Uri("", System.UriKind.Relative)
        Me.rptMicrosoftReportViewer.Size = New System.Drawing.Size(764, 337)
        Me.rptMicrosoftReportViewer.TabIndex = 0
        '
        'frmContent
        '
        Me.frmContent.Controls.Add(Me.rptMicrosoftReportViewer)
        Me.frmContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmContent.Location = New System.Drawing.Point(0, 0)
        Me.frmContent.Name = "frmContent"
        Me.frmContent.Size = New System.Drawing.Size(764, 337)
        Me.frmContent.TabIndex = 1
        '
        'MRV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(764, 337)
        Me.Controls.Add(Me.frmContent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MRV"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Microsoft Report Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.frmContent.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rptMicrosoftReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents frmContent As System.Windows.Forms.Panel
End Class
