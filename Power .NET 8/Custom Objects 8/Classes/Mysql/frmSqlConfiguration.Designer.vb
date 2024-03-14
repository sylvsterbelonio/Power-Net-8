<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SC))
        Me.frmContenr = New System.Windows.Forms.Panel
        Me.cmdSave = New System.Windows.Forms.Button
        Me.dgvListDatabase = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.gbConnection = New System.Windows.Forms.GroupBox
        Me.cmdTest = New System.Windows.Forms.Button
        Me.cboDBName = New System.Windows.Forms.ComboBox
        Me.lblPort = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtPort = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtServername = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmdClearAll = New System.Windows.Forms.Button
        Me.cmdRemove = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.frmContenr.SuspendLayout()
        CType(Me.dgvListDatabase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbConnection.SuspendLayout()
        Me.SuspendLayout()
        '
        'frmContenr
        '
        Me.frmContenr.Controls.Add(Me.cmdSave)
        Me.frmContenr.Controls.Add(Me.dgvListDatabase)
        Me.frmContenr.Controls.Add(Me.Label6)
        Me.frmContenr.Controls.Add(Me.gbConnection)
        Me.frmContenr.Controls.Add(Me.Label11)
        Me.frmContenr.Controls.Add(Me.cmdClearAll)
        Me.frmContenr.Controls.Add(Me.cmdRemove)
        Me.frmContenr.Controls.Add(Me.cmdAdd)
        Me.frmContenr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmContenr.Location = New System.Drawing.Point(5, 5)
        Me.frmContenr.Name = "frmContenr"
        Me.frmContenr.Size = New System.Drawing.Size(729, 311)
        Me.frmContenr.TabIndex = 0
        Me.frmContenr.Tag = "ACCESS SQL CONFIGURATION"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(651, 212)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 31
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'dgvListDatabase
        '
        Me.dgvListDatabase.AllowUserToAddRows = False
        Me.dgvListDatabase.AllowUserToDeleteRows = False
        Me.dgvListDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListDatabase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dgvListDatabase.Location = New System.Drawing.Point(377, 9)
        Me.dgvListDatabase.Name = "dgvListDatabase"
        Me.dgvListDatabase.ReadOnly = True
        Me.dgvListDatabase.Size = New System.Drawing.Size(351, 197)
        Me.dgvListDatabase.TabIndex = 30
        '
        'Column1
        '
        Me.Column1.HeaderText = "DatabaseName"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(31, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(324, 60)
        Me.Label6.TabIndex = 23
        Me.Label6.Tag = "custom"
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'gbConnection
        '
        Me.gbConnection.Controls.Add(Me.cmdTest)
        Me.gbConnection.Controls.Add(Me.cboDBName)
        Me.gbConnection.Controls.Add(Me.lblPort)
        Me.gbConnection.Controls.Add(Me.Label7)
        Me.gbConnection.Controls.Add(Me.txtPassword)
        Me.gbConnection.Controls.Add(Me.Label8)
        Me.gbConnection.Controls.Add(Me.txtusername)
        Me.gbConnection.Controls.Add(Me.Label9)
        Me.gbConnection.Controls.Add(Me.txtPort)
        Me.gbConnection.Controls.Add(Me.Label10)
        Me.gbConnection.Controls.Add(Me.txtServername)
        Me.gbConnection.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbConnection.Location = New System.Drawing.Point(12, 31)
        Me.gbConnection.Name = "gbConnection"
        Me.gbConnection.Size = New System.Drawing.Size(350, 195)
        Me.gbConnection.TabIndex = 29
        Me.gbConnection.TabStop = False
        Me.gbConnection.Text = "Connect to MySQL Server Instance"
        '
        'cmdTest
        '
        Me.cmdTest.Location = New System.Drawing.Point(242, 159)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(75, 23)
        Me.cmdTest.TabIndex = 32
        Me.cmdTest.Text = "Test"
        Me.cmdTest.UseVisualStyleBackColor = True
        '
        'cboDBName
        '
        Me.cboDBName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDBName.FormattingEnabled = True
        Me.cboDBName.Location = New System.Drawing.Point(123, 132)
        Me.cboDBName.Name = "cboDBName"
        Me.cboDBName.Size = New System.Drawing.Size(194, 21)
        Me.cboDBName.TabIndex = 31
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPort.Location = New System.Drawing.Point(19, 109)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(26, 13)
        Me.lblPort.TabIndex = 25
        Me.lblPort.Text = "Port"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(20, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Database Name"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(122, 76)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(194, 20)
        Me.txtPassword.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(20, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Server Host"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(123, 50)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(194, 20)
        Me.txtusername.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(20, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "User Name"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(122, 106)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(194, 20)
        Me.txtPort.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(19, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Password"
        '
        'txtServername
        '
        Me.txtServername.Location = New System.Drawing.Point(123, 24)
        Me.txtServername.Name = "txtServername"
        Me.txtServername.Size = New System.Drawing.Size(194, 20)
        Me.txtServername.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(12, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(343, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Select appropriate configuration for your system's database connection."
        '
        'cmdClearAll
        '
        Me.cmdClearAll.Location = New System.Drawing.Point(570, 212)
        Me.cmdClearAll.Name = "cmdClearAll"
        Me.cmdClearAll.Size = New System.Drawing.Size(75, 23)
        Me.cmdClearAll.TabIndex = 17
        Me.cmdClearAll.Text = "Clear All"
        Me.cmdClearAll.UseVisualStyleBackColor = True
        '
        'cmdRemove
        '
        Me.cmdRemove.Location = New System.Drawing.Point(489, 212)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(75, 23)
        Me.cmdRemove.TabIndex = 16
        Me.cmdRemove.Text = "Remove"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(408, 212)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 15
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'SC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 321)
        Me.Controls.Add(Me.frmContenr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SC"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ACCESS SQL CONFIGURATION"
        Me.Text = "SQL Configuration and Settings"
        Me.frmContenr.ResumeLayout(False)
        Me.frmContenr.PerformLayout()
        CType(Me.dgvListDatabase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbConnection.ResumeLayout(False)
        Me.gbConnection.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frmContenr As System.Windows.Forms.Panel
    Friend WithEvents gbConnection As System.Windows.Forms.GroupBox
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents txtServername As System.Windows.Forms.TextBox
    Friend WithEvents cmdClearAll As System.Windows.Forms.Button
    Friend WithEvents cmdRemove As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents dgvListDatabase As System.Windows.Forms.DataGridView
    Friend WithEvents cmdTest As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboDBName As System.Windows.Forms.ComboBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
End Class
