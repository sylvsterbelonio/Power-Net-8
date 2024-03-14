Public Class myLineSeparator

    Enum LineMode
        Vertical
        Horizontal
    End Enum

    Private myLineMode As LineMode = LineMode.Horizontal

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
            e.Graphics.DrawLine(New Pen(myLineColor, myLineBorder), 0, 0, 0, Me.Height)
        ElseIf myLineMode = LineMode.Horizontal Then
            e.Graphics.DrawLine(New Pen(myLineColor, myLineBorder), 0, 0, Me.Width, 0)
        End If
    End Sub

    Private Sub myLineSeparator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Transparent
    End Sub

End Class
