<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyStatusViewer
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
        Me.components = New System.ComponentModel.Container
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.stMain = New PowerNET8.MyStatusStripExtension
        Me.lblcuser = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblcrole = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblcConnectionQuality = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblcConnectionType = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblcdatabase = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblVacant = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblnum = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblcap = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblscr = New System.Windows.Forms.ToolStripStatusLabel
        Me.stMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'stMain
        '
        Me.stMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stMain.Font = New System.Drawing.Font("Lucida Sans", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblcuser, Me.lblcrole, Me.lblcConnectionQuality, Me.lblcConnectionType, Me.lblcdatabase, Me.lblVacant, Me.lblnum, Me.lblcap, Me.lblscr})
        Me.stMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.stMain.Location = New System.Drawing.Point(0, 0)
        Me.stMain.My_BackGround_BorderColor = System.Drawing.Color.White
        Me.stMain.My_BackGround_BottomColor1 = System.Drawing.Color.LightGray
        Me.stMain.My_BackGround_BottomColor2 = System.Drawing.Color.White
        Me.stMain.My_BackGround_Has_Border = False
        Me.stMain.My_BackGround_Style = PowerNET8.MyStatusStripExtension.BackStyle.VerticalGradient
        Me.stMain.My_BackGround_TopColor1 = System.Drawing.Color.White
        Me.stMain.My_BackGround_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.stMain.My_Label_BackColor = System.Drawing.Color.Silver
        Me.stMain.My_Selection_Style = PowerNET8.MyStatusStripExtension.SelectStyleType.Standard
        Me.stMain.My_Selection_Style_Custom_Select_BorderColor = System.Drawing.Color.Black
        Me.stMain.My_Selection_Style_Custom_Select_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stMain.My_Selection_Style_Custom_Select_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.stMain.My_Selection_Style_Custom_Select_Has_Border = False
        Me.stMain.My_Selection_Style_Custom_Select_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stMain.My_Selection_Style_Custom_Select_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.stMain.My_Selection_Style_Custom_UnSelect_BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.stMain.My_Selection_Style_Custom_UnSelect_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.stMain.My_Selection_Style_Custom_UnSelect_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.stMain.My_Selection_Style_Custom_UnSelect_Has_Border = False
        Me.stMain.My_Selection_Style_Custom_UnSelect_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.stMain.My_Selection_Style_Custom_UnSelect_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.stMain.My_Standard_Select_FontColor = System.Drawing.Color.DarkBlue
        Me.stMain.My_Standard_Selection_BackColor = System.Drawing.Color.SteelBlue
        Me.stMain.My_Standard_UnSelect_FontColor = System.Drawing.Color.Black
        Me.stMain.My_Transparent_Effect = True
        Me.stMain.Name = "stMain"
        Me.stMain.ShowItemToolTips = True
        Me.stMain.Size = New System.Drawing.Size(793, 23)
        Me.stMain.TabIndex = 0
        Me.stMain.Text = "MyStatusStripExtension1"
        '
        'lblcuser
        '
        Me.lblcuser.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblcuser.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblcuser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcuser.Name = "lblcuser"
        Me.lblcuser.Size = New System.Drawing.Size(37, 19)
        Me.lblcuser.Text = "User:"
        Me.lblcuser.ToolTipText = "Name of the user of the system."
        '
        'lblcrole
        '
        Me.lblcrole.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblcrole.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcrole.Name = "lblcrole"
        Me.lblcrole.Size = New System.Drawing.Size(37, 19)
        Me.lblcrole.Text = "Role:"
        Me.lblcrole.ToolTipText = "User Access Level of the System."
        '
        'lblcConnectionQuality
        '
        Me.lblcConnectionQuality.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblcConnectionQuality.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcConnectionQuality.Name = "lblcConnectionQuality"
        Me.lblcConnectionQuality.Size = New System.Drawing.Size(117, 19)
        Me.lblcConnectionQuality.Text = "Connection Quality:"
        Me.lblcConnectionQuality.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.lblcConnectionQuality.ToolTipText = "Quality of the connection from the server"
        '
        'lblcConnectionType
        '
        Me.lblcConnectionType.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblcConnectionType.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblcConnectionType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcConnectionType.Name = "lblcConnectionType"
        Me.lblcConnectionType.Size = New System.Drawing.Size(105, 19)
        Me.lblcConnectionType.Text = "Connection Type:"
        Me.lblcConnectionType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblcConnectionType.ToolTipText = "Connection Type"
        '
        'lblcdatabase
        '
        Me.lblcdatabase.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblcdatabase.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblcdatabase.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcdatabase.Name = "lblcdatabase"
        Me.lblcdatabase.Size = New System.Drawing.Size(62, 19)
        Me.lblcdatabase.Text = "Database:"
        Me.lblcdatabase.ToolTipText = "Name of the Database  imported from the system."
        '
        'lblVacant
        '
        Me.lblVacant.AutoSize = False
        Me.lblVacant.BackColor = System.Drawing.Color.Transparent
        Me.lblVacant.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblVacant.Name = "lblVacant"
        Me.lblVacant.Size = New System.Drawing.Size(200, 15)
        Me.lblVacant.Spring = True
        '
        'lblnum
        '
        Me.lblnum.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblnum.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(39, 19)
        Me.lblnum.Text = "NUM"
        Me.lblnum.ToolTipText = "Num Lock"
        '
        'lblcap
        '
        Me.lblcap.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblcap.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcap.Name = "lblcap"
        Me.lblcap.Size = New System.Drawing.Size(34, 19)
        Me.lblcap.Spring = True
        Me.lblcap.Text = "CAP"
        Me.lblcap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblcap.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.lblcap.ToolTipText = "Caps Lock"
        '
        'lblscr
        '
        Me.lblscr.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblscr.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscr.Name = "lblscr"
        Me.lblscr.Size = New System.Drawing.Size(32, 19)
        Me.lblscr.Spring = True
        Me.lblscr.Text = "SCR"
        Me.lblscr.ToolTipText = "Scroll Lock"
        '
        'MyStatusViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.stMain)
        Me.Name = "MyStatusViewer"
        Me.Size = New System.Drawing.Size(793, 23)
        Me.stMain.ResumeLayout(False)
        Me.stMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stMain As PowerNET8.MyStatusStripExtension
    Friend WithEvents lblcuser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblcrole As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblcdatabase As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblcConnectionQuality As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblcConnectionType As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblnum As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblcap As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblscr As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblVacant As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
