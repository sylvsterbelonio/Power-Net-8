<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSample
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup4 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.BackgroundColor1 = New PowerNET8.My8BackgroundColor
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtReadOnly = New System.Windows.Forms.TextBox
        Me.My8Button2 = New PowerNET8.My8Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDefault = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtHighlight = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBackColor = New System.Windows.Forms.TextBox
        Me.AccentColor1 = New PowerNET8.My8AccentColor
        Me.txtAlternate = New System.Windows.Forms.TextBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.lbl_status = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.My8Button1 = New PowerNET8.My8Button
        Me.stop_button = New System.Windows.Forms.Button
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.start_button = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.my_BGWorker = New System.ComponentModel.BackgroundWorker
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtReadFore = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContent.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(564, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(419, 228)
        Me.DataGridView1.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Items.AddRange(New Object() {"A", "B", "C"})
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Read Only"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Column4"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Column5"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Column6"
        Me.Column6.Name = "Column6"
        '
        'pnlContent
        '
        Me.pnlContent.Controls.Add(Me.txtReadFore)
        Me.pnlContent.Controls.Add(Me.Label7)
        Me.pnlContent.Controls.Add(Me.BackgroundColor1)
        Me.pnlContent.Controls.Add(Me.Label6)
        Me.pnlContent.Controls.Add(Me.txtReadOnly)
        Me.pnlContent.Controls.Add(Me.My8Button2)
        Me.pnlContent.Controls.Add(Me.Label5)
        Me.pnlContent.Controls.Add(Me.txtDefault)
        Me.pnlContent.Controls.Add(Me.Label4)
        Me.pnlContent.Controls.Add(Me.Label3)
        Me.pnlContent.Controls.Add(Me.txtHighlight)
        Me.pnlContent.Controls.Add(Me.Label2)
        Me.pnlContent.Controls.Add(Me.txtBackColor)
        Me.pnlContent.Controls.Add(Me.AccentColor1)
        Me.pnlContent.Controls.Add(Me.txtAlternate)
        Me.pnlContent.Controls.Add(Me.ProgressBar1)
        Me.pnlContent.Controls.Add(Me.lbl_status)
        Me.pnlContent.Controls.Add(Me.RadioButton1)
        Me.pnlContent.Controls.Add(Me.RichTextBox1)
        Me.pnlContent.Controls.Add(Me.ComboBox1)
        Me.pnlContent.Controls.Add(Me.MaskedTextBox1)
        Me.pnlContent.Controls.Add(Me.TextBox1)
        Me.pnlContent.Controls.Add(Me.ListView1)
        Me.pnlContent.Controls.Add(Me.ListBox1)
        Me.pnlContent.Controls.Add(Me.GroupBox1)
        Me.pnlContent.Controls.Add(Me.My8Button1)
        Me.pnlContent.Controls.Add(Me.stop_button)
        Me.pnlContent.Controls.Add(Me.FlowLayoutPanel1)
        Me.pnlContent.Controls.Add(Me.DomainUpDown1)
        Me.pnlContent.Controls.Add(Me.ComboBox2)
        Me.pnlContent.Controls.Add(Me.CheckedListBox1)
        Me.pnlContent.Controls.Add(Me.CheckBox1)
        Me.pnlContent.Controls.Add(Me.start_button)
        Me.pnlContent.Controls.Add(Me.DataGridView1)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1015, 365)
        Me.pnlContent.TabIndex = 3
        '
        'BackgroundColor1
        '
        Me.BackgroundColor1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BackgroundColor1.ColorNameTag = "A1"
        Me.BackgroundColor1.ForeColor = System.Drawing.Color.Silver
        Me.BackgroundColor1.groupColorNameTag = "black"
        Me.BackgroundColor1.Location = New System.Drawing.Point(30, 4)
        Me.BackgroundColor1.MaximumSize = New System.Drawing.Size(373, 203)
        Me.BackgroundColor1.MinimumSize = New System.Drawing.Size(373, 203)
        Me.BackgroundColor1.Name = "BackgroundColor1"
        Me.BackgroundColor1.Size = New System.Drawing.Size(373, 203)
        Me.BackgroundColor1.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(623, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "ReadOnly"
        '
        'txtReadOnly
        '
        Me.txtReadOnly.Location = New System.Drawing.Point(731, 311)
        Me.txtReadOnly.Name = "txtReadOnly"
        Me.txtReadOnly.Size = New System.Drawing.Size(56, 20)
        Me.txtReadOnly.TabIndex = 33
        Me.txtReadOnly.Text = "backcolor"
        '
        'My8Button2
        '
        Me.My8Button2.BorderColors = System.Drawing.Color.White
        Me.My8Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.My8Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.My8Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.My8Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.My8Button2.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.My8Button2.ImageSize = New System.Drawing.Size(24, 24)
        Me.My8Button2.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.My8Button2.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.My8Button2.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.My8Button2.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.My8Button2.Location = New System.Drawing.Point(409, 289)
        Me.My8Button2.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.My8Button2.MouseOverForecolor = System.Drawing.Color.White
        Me.My8Button2.MousePressedBackColor = System.Drawing.Color.White
        Me.My8Button2.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.My8Button2.Name = "My8Button2"
        Me.My8Button2.Size = New System.Drawing.Size(75, 30)
        Me.My8Button2.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.My8Button2.TabIndex = 32
        Me.My8Button2.Text = "My8Button2"
        Me.My8Button2.UseVisualStyleBackColor = True
        Me.My8Button2.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(503, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Default"
        '
        'txtDefault
        '
        Me.txtDefault.Location = New System.Drawing.Point(564, 282)
        Me.txtDefault.Name = "txtDefault"
        Me.txtDefault.Size = New System.Drawing.Size(56, 20)
        Me.txtDefault.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(502, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Highlight"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(503, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Alternate"
        '
        'txtHighlight
        '
        Me.txtHighlight.Location = New System.Drawing.Point(564, 256)
        Me.txtHighlight.Name = "txtHighlight"
        Me.txtHighlight.Size = New System.Drawing.Size(56, 20)
        Me.txtHighlight.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(503, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Backcolor"
        '
        'txtBackColor
        '
        Me.txtBackColor.Location = New System.Drawing.Point(564, 333)
        Me.txtBackColor.Name = "txtBackColor"
        Me.txtBackColor.Size = New System.Drawing.Size(56, 20)
        Me.txtBackColor.TabIndex = 25
        Me.txtBackColor.Text = "backcolor"
        '
        'AccentColor1
        '
        Me.AccentColor1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.AccentColor1.ColorNameTag = "A1"
        Me.AccentColor1.groupColorNameTag = "black"
        Me.AccentColor1.Location = New System.Drawing.Point(30, 204)
        Me.AccentColor1.MaximumSize = New System.Drawing.Size(373, 158)
        Me.AccentColor1.MinimumSize = New System.Drawing.Size(373, 158)
        Me.AccentColor1.Name = "AccentColor1"
        Me.AccentColor1.Size = New System.Drawing.Size(373, 158)
        Me.AccentColor1.TabIndex = 24
        '
        'txtAlternate
        '
        Me.txtAlternate.Location = New System.Drawing.Point(564, 307)
        Me.txtAlternate.Name = "txtAlternate"
        Me.txtAlternate.Size = New System.Drawing.Size(56, 20)
        Me.txtAlternate.TabIndex = 23
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 302)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(166, 23)
        Me.ProgressBar1.TabIndex = 21
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Location = New System.Drawing.Point(12, 277)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(39, 13)
        Me.lbl_status.TabIndex = 20
        Me.lbl_status.Text = "Label2"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(217, 95)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 19
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(138, 136)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(169, 71)
        Me.RichTextBox1.TabIndex = 18
        Me.RichTextBox1.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"item1", "item2", "item3", "item4"})
        Me.ComboBox1.Location = New System.Drawing.Point(313, 46)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 17
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(313, 136)
        Me.MaskedTextBox1.Mask = "90:00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(120, 20)
        Me.MaskedTextBox1.TabIndex = 16
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Red
        Me.TextBox1.Location = New System.Drawing.Point(313, 110)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 15
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        ListViewGroup1.Header = "ListViewGroup"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "ListViewGroup"
        ListViewGroup2.Name = "ListViewGroup2"
        ListViewGroup3.Header = "ListViewGroup"
        ListViewGroup3.Name = "ListViewGroup3"
        ListViewGroup4.Header = "ListViewGroup"
        ListViewGroup4.Name = "ListViewGroup4"
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3, ListViewGroup4})
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4})
        Me.ListView1.Location = New System.Drawing.Point(313, 163)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(110, 44)
        Me.ListView1.TabIndex = 14
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Item1", "item2", "item3", "item4"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 112)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(440, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(118, 100)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(20, 54)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
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
        Me.My8Button1.Location = New System.Drawing.Point(138, 64)
        Me.My8Button1.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.My8Button1.MouseOverForecolor = System.Drawing.Color.White
        Me.My8Button1.MousePressedBackColor = System.Drawing.Color.White
        Me.My8Button1.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.My8Button1.Name = "My8Button1"
        Me.My8Button1.Size = New System.Drawing.Size(75, 30)
        Me.My8Button1.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.My8Button1.TabIndex = 11
        Me.My8Button1.Text = "My8Button1"
        Me.My8Button1.UseVisualStyleBackColor = True
        Me.My8Button1.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'stop_button
        '
        Me.stop_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stop_button.Image = Global.Testing.My.Resources.Resources._222
        Me.stop_button.Location = New System.Drawing.Point(173, 251)
        Me.stop_button.Name = "stop_button"
        Me.stop_button.Size = New System.Drawing.Size(76, 39)
        Me.stop_button.TabIndex = 10
        Me.stop_button.Text = "Stop"
        Me.stop_button.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(626, 255)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(118, 47)
        Me.FlowLayoutPanel1.TabIndex = 9
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.Location = New System.Drawing.Point(313, 86)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.DomainUpDown1.TabIndex = 8
        Me.DomainUpDown1.Text = "DomainUpDown1"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"item1", "item2", "item3", "item4"})
        Me.ComboBox2.Location = New System.Drawing.Point(313, 19)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 6
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"item 2", "item 3", "item 4"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(12, 12)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(120, 94)
        Me.CheckedListBox1.TabIndex = 5
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(219, 72)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'start_button
        '
        Me.start_button.Location = New System.Drawing.Point(80, 251)
        Me.start_button.Name = "start_button"
        Me.start_button.Size = New System.Drawing.Size(87, 39)
        Me.start_button.TabIndex = 3
        Me.start_button.Text = "Start"
        Me.start_button.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(318, 250)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 51)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'my_BGWorker
        '
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(623, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "ReadOnly ForeColor"
        '
        'txtReadFore
        '
        Me.txtReadFore.Location = New System.Drawing.Point(731, 334)
        Me.txtReadFore.Name = "txtReadFore"
        Me.txtReadFore.Size = New System.Drawing.Size(56, 20)
        Me.txtReadFore.TabIndex = 37
        Me.txtReadFore.Text = "backcolor"
        '
        'frmSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 365)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmSample"
        Me.Text = "frmSample"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.DomainUpDown
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents start_button As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents My8Button1 As PowerNET8.My8Button
    Friend WithEvents stop_button As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents my_BGWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_status As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtAlternate As System.Windows.Forms.TextBox
    Friend WithEvents AccentColor1 As PowerNET8.My8AccentColor
    Friend WithEvents My8Button2 As PowerNET8.My8Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDefault As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtHighlight As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundColor1 As PowerNET8.My8BackgroundColor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtReadOnly As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBackColor As System.Windows.Forms.TextBox
    Friend WithEvents txtReadFore As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
