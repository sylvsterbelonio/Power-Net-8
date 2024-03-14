<ToolboxBitmap(GetType(Label))> _
Public Class My7LabelTextBox

    Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

#Region "PROPERTY"""

    Private _onCfocus As Color = Color.Azure
    Private _onFFocus As Color = Color.Black
    Private _onFLost As Color = Color.Black
    Private _borderColor As Color = Color.Black
    Private _waterMarkColor As Color = Color.Silver
    Private _tooltip_backcolor As Color = Color.Beige
    Private _tooltip_foreColor As Color = Color.Black
    Private _text As String = ""
    Private _watermark As String = "input your text here."

    Public Property My_BackColor_Focus() As Color
        Get
            Return _onCfocus
        End Get
        Set(ByVal value As Color)
            _onCfocus = value
            Me.Invalidate()
        End Set
    End Property

    Public Property My_ForeColor_Focus() As Color
        Get
            Return _onFFocus
        End Get
        Set(ByVal value As Color)
            _onFFocus = value
            Invalidate()
        End Set
    End Property

    Public Property My_ForeColor_LostFocus() As Color
        Get
            Return _onFLost
        End Get
        Set(ByVal value As Color)
            _onFLost = value
            Me.Invalidate()
        End Set
    End Property

    Public Property My_BorderColor_Hover() As Color
        Get
            Return _borderColor
        End Get
        Set(ByVal value As Color)
            _borderColor = value
            Me.Invalidate()
        End Set
    End Property

    Public Property My_Text() As String
        Get
            Return _text
        End Get
        Set(ByVal value As String)
            _text = value
            lblDisplay.Text = _text
            Me.Invalidate()
        End Set
    End Property

    Public Property My_Watermark_Text() As String
        Get
            Return _watermark
        End Get
        Set(ByVal value As String)
            _watermark = value
            Me.Invalidate()
        End Set
    End Property

    Public Property My_Watermark_ForeColor() As Color
        Get
            Return _waterMarkColor
        End Get
        Set(ByVal value As Color)
            _waterMarkColor = value
            Me.Invalidate()
        End Set
    End Property

    Public Property My_ToolTip_BackColor() As Color
        Get
            Return _tooltip_backcolor
        End Get
        Set(ByVal value As Color)
            _tooltip_backcolor = value
            Me.Invalidate()
        End Set
    End Property

    Public Property My_ToolTip_ForeColor() As Color
        Get
            Return _tooltip_foreColor
        End Get
        Set(ByVal value As Color)
            _tooltip_foreColor = value
        End Set
    End Property

    Enum Layout_Style
        Standard
        Italic
        Underline
        Bold
    End Enum
    Private _layout As Layout_Style

    Public Property My_Watermark_Layout_Style() As Layout_Style
        Get
            Return _layout
        End Get
        Set(ByVal value As Layout_Style)
            _layout = value
            Me.Invalidate()
        End Set
    End Property

    Public Property My_ReadOnly_TextBox() As Boolean
        Get
            Return txtDisplay.ReadOnly
        End Get
        Set(ByVal value As Boolean)
            txtDisplay.ReadOnly = value
            Me.Invalidate()
        End Set
    End Property

#End Region

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        If Not Me.Parent Is Nothing Then
            Me.BackColor = Me.Parent.BackColor
            lblDisplay.BackColor = Me.BackColor

            If My_Text = "" OrElse My_Text Is Nothing Then
                lblDisplay.Text = My_Watermark_Text
                lblDisplay.ForeColor = My_Watermark_ForeColor

                Select Case My_Watermark_Layout_Style
                    Case Layout_Style.Italic
                        lblDisplay.Font = New Font(lblDisplay.Font, FontStyle.Italic)
                    Case Layout_Style.Bold
                        lblDisplay.Font = New Font(lblDisplay.Font, FontStyle.Bold)
                    Case Layout_Style.Underline
                        lblDisplay.Font = New Font(lblDisplay.Font, FontStyle.Underline)
                End Select

            Else
                lblDisplay.Text = My_Text
                lblDisplay.ForeColor = My_ForeColor_LostFocus
            End If
        End If

        'Setting a label into a tooltip
        ttDisplay.BackColor = Color.Red
        ttDisplay.ForeColor = My_ToolTip_ForeColor
        ttDisplay.SetToolTip(lblDisplay, My_Text)
    End Sub

    Private Sub lblDisplay_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblDisplay.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            txtDisplay.Visible = True
            lblDisplay.Visible = False
            txtDisplay.Dock = DockStyle.Top
            txtDisplay.Focus()
            If My_Text <> "" Then
                txtDisplay.Text = My_Text
            Else
                txtDisplay.Text = ""
            End If
        End If
    End Sub

    Private Sub lblDisplay_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDisplay.MouseLeave
        lblDisplay.Cursor = Cursors.Default
        Dim g As Graphics = lblDisplay.Parent.CreateGraphics
        g.DrawRectangle(New Pen(lblDisplay.Parent.BackColor), New Rectangle(lblDisplay.Location.X - 1, lblDisplay.Location.Y - 1, lblDisplay.Width + 1, lblDisplay.Height + 1))
    End Sub

    Private Sub lblDisplay_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblDisplay.MouseMove
        lblDisplay.Cursor = Cursors.IBeam
        Dim g As Graphics = lblDisplay.Parent.CreateGraphics
        g.DrawRectangle(New Pen(My_BorderColor_Hover), New Rectangle(lblDisplay.Location.X - 1, lblDisplay.Location.Y - 1, lblDisplay.Width + 1, lblDisplay.Height + 1))
    End Sub

    Private Sub txtDisplay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDisplay.GotFocus
        txtDisplay.BackColor = My_BackColor_Focus
        txtDisplay.ForeColor = My_ForeColor_Focus
    End Sub

    Private Sub txtDisplay_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDisplay.LostFocus
        lblDisplay.Visible = True
        txtDisplay.Visible = False
        Dim g As Graphics = lblDisplay.Parent.CreateGraphics
        g.DrawRectangle(New Pen(lblDisplay.Parent.BackColor), New Rectangle(lblDisplay.Location.X - 1, lblDisplay.Location.Y - 1, lblDisplay.Width + 1, lblDisplay.Height + 1))
        My_Text = txtDisplay.Text

        If My_Text = "" Then
            txtDisplay.Visible = False
        Else
            lblDisplay.Text = My_Text
            txtDisplay.Text = My_Text
        End If

        txtDisplay.Dock = DockStyle.None
    End Sub

End Class
