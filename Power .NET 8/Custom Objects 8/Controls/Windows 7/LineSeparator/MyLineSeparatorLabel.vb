Public Class myLineSeparatorLabel

    Enum LineMode
        Vertical
        Horizontal
    End Enum

    Private myLineMode As LineMode = LineMode.Horizontal

    Public Property My_Pulse_Speed() As Integer
        Get
            Return lblLabel.PulseSpeed
        End Get
        Set(ByVal value As Integer)
            lblLabel.PulseSpeed = value
        End Set
    End Property

    Public Property My_Pulse() As Boolean
        Get
            Return lblLabel.Pulse
        End Get
        Set(ByVal value As Boolean)
            lblLabel.Pulse = value
        End Set
    End Property

    Public Property My_Font() As Font
        Get
            Return lblLabel.Font
        End Get
        Set(ByVal value As Font)
            lblLabel.Font = value
        End Set
    End Property

    Public Property My_ForeColor() As Color
        Get
            Return lblLabel.ForeColor
        End Get
        Set(ByVal value As Color)
            lblLabel.ForeColor = value
        End Set
    End Property

    Public Property My_Glow_Size() As Integer
        Get
            Return lblLabel.Glow
        End Get
        Set(ByVal value As Integer)
            lblLabel.Glow = value
        End Set
    End Property

    Public Property My_Glow_Color() As Color
        Get
            Return lblLabel.GlowColor
        End Get
        Set(ByVal value As Color)
            lblLabel.GlowColor = value
        End Set
    End Property

    Public Property My_Text_Width() As Integer
        Get
            Return lblLabel.Width
        End Get
        Set(ByVal value As Integer)
            lblLabel.Width = value
            Me.Invalidate()
        End Set
    End Property

    Public Property My_Text_Height() As Integer
        Get
            Return lblLabel.Height
        End Get
        Set(ByVal value As Integer)
            lblLabel.Height = value
            Me.Invalidate()
        End Set
    End Property

    Public Property My_Text() As String
        Get
            Return lblLabel.Text
        End Get
        Set(ByVal value As String)
            lblLabel.Text = value
            Me.Invalidate()
        End Set
    End Property

    Public Property My_Line_Style() As LineMode
        Get
            Return myLineMode
        End Get
        Set(ByVal value As LineMode)
            myLineMode = value

            If myLineMode = LineMode.Vertical Then
                Me.Height = Me.Width
                Me.Width = 1 + myLineBorder

            Else
                Me.Width = Me.Height
                Me.Height = 1 + myLineBorder
            End If
            Me.Invalidate()
        End Set
    End Property

    Private myLineBorder As Integer = 1
    Public Property My_Line_Border() As Integer
        Get
            Return myLineBorder
        End Get
        Set(ByVal value As Integer)
            myLineBorder = value
            Me.Invalidate()
        End Set
    End Property

    Private myLineColor As Color = Color.Black
    Public Property My_Line_Color() As Color
        Get
            Return myLineColor
        End Get
        Set(ByVal value As Color)
            myLineColor = value
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        Me.BackColor = Color.Transparent
        If myLineMode = LineMode.Vertical Then
            Dim half As Integer = lblLabel.Width / 2
            e.Graphics.DrawLine(New Pen(myLineColor, myLineBorder), half, lblLabel.Height + 1, half, Me.Height)
        ElseIf myLineMode = LineMode.Horizontal Then
            Dim half As Integer = lblLabel.Height / 2
            e.Graphics.DrawLine(New Pen(myLineColor, myLineBorder), lblLabel.Width + 1, half, Me.Width, half)
        End If
    End Sub

    Private Sub myLineSeparator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Transparent
    End Sub

End Class
