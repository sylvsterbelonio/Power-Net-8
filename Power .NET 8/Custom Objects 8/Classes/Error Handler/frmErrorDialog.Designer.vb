<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmErrorDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmErrorDialog))
        Me.lblErr02 = New System.Windows.Forms.Label
        Me.lblErr01 = New System.Windows.Forms.Label
        Me.pbTechSupport = New System.Windows.Forms.PictureBox
        Me.lblComments = New System.Windows.Forms.Label
        Me.txtComments = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblWhatReport = New System.Windows.Forms.LinkLabel
        Me.lblAltLink = New System.Windows.Forms.LinkLabel
        Me.chkNoReport = New System.Windows.Forms.CheckBox
        Me.btnSend = New System.Windows.Forms.Button
        Me.btnDontSend = New System.Windows.Forms.Button
        Me.txtEMail = New System.Windows.Forms.TextBox
        CType(Me.pbTechSupport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblErr02
        '
        Me.lblErr02.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblErr02.Location = New System.Drawing.Point(72, 42)
        Me.lblErr02.Name = "lblErr02"
        Me.lblErr02.Size = New System.Drawing.Size(305, 35)
        Me.lblErr02.TabIndex = 38
        '
        'lblErr01
        '
        Me.lblErr01.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblErr01.Location = New System.Drawing.Point(72, 12)
        Me.lblErr01.Name = "lblErr01"
        Me.lblErr01.Size = New System.Drawing.Size(305, 16)
        Me.lblErr01.TabIndex = 33
        '
        'pbTechSupport
        '
        Me.pbTechSupport.BackgroundImage = CType(resources.GetObject("pbTechSupport.BackgroundImage"), System.Drawing.Image)
        Me.pbTechSupport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbTechSupport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pbTechSupport.Location = New System.Drawing.Point(12, 12)
        Me.pbTechSupport.Name = "pbTechSupport"
        Me.pbTechSupport.Size = New System.Drawing.Size(55, 75)
        Me.pbTechSupport.TabIndex = 34
        Me.pbTechSupport.TabStop = False
        '
        'lblComments
        '
        Me.lblComments.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblComments.Location = New System.Drawing.Point(12, 107)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(365, 30)
        Me.lblComments.TabIndex = 35
        Me.lblComments.Text = "If you would like to include additional comments such as how to cause this proble" & _
            "m, please enter your text below:    (Optional)"
        '
        'txtComments
        '
        Me.txtComments.AcceptsReturn = True
        Me.txtComments.Location = New System.Drawing.Point(12, 143)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(365, 66)
        Me.txtComments.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 30)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Please provide a vaid email address where we can contact you with questions or co" & _
            "mments about this error. (Required)"
        '
        'lblWhatReport
        '
        Me.lblWhatReport.AutoSize = True
        Me.lblWhatReport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWhatReport.Location = New System.Drawing.Point(72, 82)
        Me.lblWhatReport.Name = "lblWhatReport"
        Me.lblWhatReport.Size = New System.Drawing.Size(106, 13)
        Me.lblWhatReport.TabIndex = 31
        Me.lblWhatReport.TabStop = True
        Me.lblWhatReport.Text = "What's in this report?"
        '
        'lblAltLink
        '
        Me.lblAltLink.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAltLink.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.lblAltLink.Location = New System.Drawing.Point(12, 337)
        Me.lblAltLink.Name = "lblAltLink"
        Me.lblAltLink.Size = New System.Drawing.Size(370, 19)
        Me.lblAltLink.TabIndex = 32
        Me.lblAltLink.UseMnemonic = False
        '
        'chkNoReport
        '
        Me.chkNoReport.AutoSize = True
        Me.chkNoReport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkNoReport.Location = New System.Drawing.Point(12, 317)
        Me.chkNoReport.Name = "chkNoReport"
        Me.chkNoReport.Size = New System.Drawing.Size(164, 17)
        Me.chkNoReport.TabIndex = 36
        Me.chkNoReport.Text = "Don't Ask Me to Report Bugs"
        Me.chkNoReport.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSend.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSend.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSend.Location = New System.Drawing.Point(277, 281)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(100, 30)
        Me.btnSend.TabIndex = 29
        Me.btnSend.Text = "&Send Data"
        '
        'btnDontSend
        '
        Me.btnDontSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDontSend.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnDontSend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDontSend.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDontSend.Location = New System.Drawing.Point(171, 281)
        Me.btnDontSend.Name = "btnDontSend"
        Me.btnDontSend.Size = New System.Drawing.Size(100, 30)
        Me.btnDontSend.TabIndex = 30
        Me.btnDontSend.Text = "&No, Don't Send"
        '
        'txtEMail
        '
        Me.txtEMail.Location = New System.Drawing.Point(12, 252)
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Size = New System.Drawing.Size(365, 20)
        Me.txtEMail.TabIndex = 28
        '
        'frmErrorDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 386)
        Me.Controls.Add(Me.lblErr02)
        Me.Controls.Add(Me.lblErr01)
        Me.Controls.Add(Me.pbTechSupport)
        Me.Controls.Add(Me.lblComments)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWhatReport)
        Me.Controls.Add(Me.lblAltLink)
        Me.Controls.Add(Me.chkNoReport)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnDontSend)
        Me.Controls.Add(Me.txtEMail)
        Me.Name = "frmErrorDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEventHandler"
        CType(Me.pbTechSupport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblErr02 As System.Windows.Forms.Label
    Friend WithEvents lblErr01 As System.Windows.Forms.Label
    Friend WithEvents pbTechSupport As System.Windows.Forms.PictureBox
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblWhatReport As System.Windows.Forms.LinkLabel
    Friend WithEvents lblAltLink As System.Windows.Forms.LinkLabel
    Friend WithEvents chkNoReport As System.Windows.Forms.CheckBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnDontSend As System.Windows.Forms.Button
    Friend WithEvents txtEMail As System.Windows.Forms.TextBox
End Class
