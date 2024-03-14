Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.ComponentModel.Design

<ToolboxBitmapAttribute(GetType(TextBox))> _
Public Class My7TextBoxExtension
    Inherits TextBox

    Sub New()
        MyBase.New()
        OnNormal = MyBase.BackColor
        OnNormalF = MyBase.ForeColor
        JoinEvents(True)
        'Me.BorderStyle = Forms.BorderStyle.FixedSingle
    End Sub

#Region "ROUND CORNER"
    <Browsable(False)> _
    Public Property My_Corner() As Integer
        Get
            Return _edge
        End Get
        Set(ByVal Value As Integer)
            _edge = Value
            Invalidate()
        End Set
    End Property
    Public Property My_Border_Size() As Double
        Get
            Return penWidth
        End Get
        Set(ByVal value As Double)
            penWidth = value
        End Set
    End Property
    Public Property My_Border_Color_Hover() As Color
        Get
            Return MyBorderColorsHover
        End Get
        Set(ByVal value As Color)
            MyBorderColorsHover = value
        End Set
    End Property

    Dim MyBorderColorsHover As Color = Color.SteelBlue
    Dim MyBorderColorsNormal As Color = Color.Gray
    Private pen As Pen = New Pen(MyBorderColorsNormal, penWidth)
    Private penWidth As Double = 1.0F
    Private _edge As Integer = 1


    Private Function GetLeftUpper(ByVal e As Integer) As Rectangle
        Return New Rectangle(0, 0, e, e)
    End Function
    Private Function GetRightUpper(ByVal e As Integer) As Rectangle
        Return New Rectangle(Width - e, 0, e, e)
    End Function
    Private Function GetRightLower(ByVal e As Integer) As Rectangle
        Return New Rectangle(Width - e, Height - e, e, e)
    End Function
    Private Function GetLeftLower(ByVal e As Integer) As Rectangle
        Return New Rectangle(0, Height - e, e, e)
    End Function

    Private Sub ExtendedDraw(ByVal e As Graphics)
        e.SmoothingMode = SmoothingMode.AntiAlias
        Dim path As GraphicsPath = New GraphicsPath
        path.StartFigure()
        path.StartFigure()
        path.AddArc(GetLeftUpper(My_Corner), 180, 90)
        path.AddLine(My_Corner, 0, Me.Width - My_Corner, 0)
        path.AddArc(GetRightUpper(My_Corner), 270, 90)
        path.AddLine(Me.Width, My_Corner, Me.Width, Height - My_Corner)
        path.AddArc(GetRightLower(My_Corner), 0, 90)
        path.AddLine(Me.Width - My_Corner, Me.Height, My_Corner, Me.Height)
        path.AddArc(GetLeftLower(My_Corner), 90, 90)
        path.AddLine(0, Me.Height - My_Corner, 0, My_Corner)
        path.CloseFigure()
        Region = New Region(path)
    End Sub
    Enum BorderEvent
        Normal
        Hover
    End Enum
    Private Sub DrawBorder(Optional ByVal type As BorderEvent = BorderEvent.Normal)
        If Me.BorderStyle <> Forms.BorderStyle.Fixed3D Then
            If Not MyBase.Parent Is Nothing Then
                Dim g As Graphics = MyBase.CreateGraphics
                ExtendedDraw(g)
                Select Case type
                    Case BorderEvent.Normal
                        pen = New Pen(MyBorderColorsNormal, penWidth)
                        DrawBorders(g, MyBorderColorsNormal)
                    Case BorderEvent.Hover
                        pen = New Pen(MyBorderColorsHover, penWidth)
                        DrawBorders(g, MyBorderColorsHover)
                End Select
            End If
        End If

        'Me.Invalidate()
    End Sub
    Private Sub DrawBorders(ByVal graphics As Graphics, ByVal colorx As Color)
        'DrawSingleBorder(graphics, colorx)
    End Sub

    Private Sub DrawSingleBorder(ByVal graphics As Graphics, ByVal colorx As Color)
        graphics.DrawArc(New Pen(colorx, penWidth), New Rectangle(0, 0, My_Corner, My_Corner), _
                         180, 90)
        graphics.DrawArc(New Pen(colorx, penWidth), New Rectangle(Width - My_Corner - 1, -1, _
                         My_Corner, My_Corner), 270, 90)
        graphics.DrawArc(New Pen(colorx, penWidth), New Rectangle(Width - My_Corner - 1, _
                         Height - My_Corner - 1, My_Corner, My_Corner), 0, 90)
        graphics.DrawArc(New Pen(colorx, penWidth), New Rectangle(0, Height - My_Corner - 1, _
                         My_Corner, My_Corner), 90, 90)
        graphics.DrawRectangle(pen, 0.0F, 0.0F, CType((Width - 1), _
                               Single), CType((Height - 1), Single))
    End Sub

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        Invalidate()
    End Sub


#Region "VALIDATION OF BORDER ERRORS"

    Private Sub load_the_latest_event()
        For i As Integer = 0 To Me.Controls.Count - 1
            Dim a As Object = Me.Controls(i)
            'If TypeOf a Is MyComboBoxExtension Then
            '    'If CType(a, MyComboBoxExtension).Enabled = False Then
            '    '    CType(a, MyComboBoxExtension).Enabled = True
            '    '    CType(a, MyComboBoxExtension).Enabled = False
            '    '    CType(a, MyComboBoxExtension).BackColor = Color.Red
            '    'End If
            '    'CType(a, MyComboBoxExtension).reload_draw_item()
            'Else
            'End If
        Next
    End Sub

    Private Sub update_combobox()
        For i As Integer = 0 To Me.Controls.Count - 1
            Dim a As Object = Me.Controls(i)
            'If TypeOf a Is MyComboBoxExtension Then
            '    If CType(a, MyComboBoxExtension).Enabled Then
            '        If Not CType(a, MyComboBoxExtension).checkHasBorderErrors And Not CType(a, MyComboBoxExtension).CheckHasDisabledOccurred Then
            '            'CType(a, MyComboBoxExtension).RefreshBorder()
            '        Else
            '        End If
            '    Else
            '    End If
            'End If
        Next
    End Sub

#End Region

#End Region

#Region "NUMBER AND CHARACTER INPUT FIELD"
    Public Event OnEnterKeyPress()
    Dim MyInput As Cinput = Cinput.All
    Public Property My_Character_Input_Style() As Cinput
        Get
            Return Me.MyInput
        End Get
        Set(ByVal value As Cinput)
            Me.MyInput = value
        End Set
    End Property
    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        MyBase.OnKeyPress(e)

        If Asc(e.KeyChar) = 13 Then
            RaiseEvent OnEnterKeyPress()
        End If

        Select Case Me.MyInput

            Case Cinput.CharactersOnly
                If IsNumeric(e.KeyChar) Then
                    e.Handled = True
                End If
            Case Cinput.NumericOnly
                If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
                    e.Handled = True
                End If
        End Select

    End Sub
    Enum Cinput
        NumericOnly
        CharactersOnly
        All
    End Enum
#End Region

#Region "BACKCOLOR EVENT"

    Dim OnFocus As Color = Color.White
    Dim OnNormal As Color = Color.White
    Dim OnHover As Color = Color.White

    Dim OnFocusF As Color = Color.Black
    Dim OnNormalF As Color = Color.Black
    Dim OnHoverF As Color = Color.Black
    Private OnLostBack As Color = Color.White
    Private OnLostFore As Color = Color.Black
    Private m_backcolor As Color

    Public Property My_Event_Backcolor_LostFocus() As Color
        Get
            Return Me.OnLostBack
        End Get
        Set(ByVal value As Color)
            OnLostBack = value
        End Set
    End Property

    Public Property My_Event_Fontcolor_LostFocus() As Color
        Get
            Return Me.OnLostFore
        End Get
        Set(ByVal value As Color)
            OnLostFore = value
        End Set
    End Property

    Public Property My_Event_Backcolor_GotFocus() As Color
        Get
            Return Me.OnFocus
        End Get
        Set(ByVal value As Color)
            OnFocus = value
        End Set
    End Property

    Public Property My_Event_Fontcolor_GotFocus() As Color
        Get
            Return Me.OnFocusF
        End Get
        Set(ByVal value As Color)
            OnFocusF = value
        End Set
    End Property
#End Region

#Region "WATER MARK AREA"

    Private oldFont As Font = Nothing
    Private waterMarkTextEnabled As Boolean = False

#Region "Attributes"
    Private _waterMarkColor As Color = Drawing.Color.Gray
    Private _waterMarkText As String = "Textbox"

    Public Property My_WaterMark_Color() As Color
        Get
            Return _waterMarkColor
        End Get
        Set(ByVal value As Color)
            _waterMarkColor = value
            Me.Invalidate()
        End Set
    End Property

    Public Property My_WaterMark_Text() As String
        Get
            Return _waterMarkText
        End Get
        Set(ByVal value As String)
            _waterMarkText = value
            Me.Invalidate()
        End Set
    End Property

#End Region

    Private Sub JoinEvents(ByVal join As Boolean)
        If join Then
            AddHandler (TextChanged), AddressOf WaterMark_Toggle
            AddHandler (LostFocus), AddressOf WaterMark_Toggle
            AddHandler (FontChanged), AddressOf WaterMark_FontChanged
            'No one of the above events will start immeddiatlly 
            'TextBox control still in constructing, so,
            'Font object (for example) couldn't be catched from within WaterMark_Toggle
            'So, call WaterMark_Toggel through OnCreateControl after TextBox is totally created
            'No doupt, it will be only one time call

            'Old solution uses Timer.Tick event to check Create property
        End If
    End Sub

    Private Sub WaterMark_Toggle(ByVal sender As Object, ByVal args As EventArgs)
        If Me.Text.Length <= 0 Then
            EnableWaterMark()
        Else
            DisableWaterMark()
        End If
    End Sub

    Private Sub WaterMark_FontChanged(ByVal sender As Object, ByVal args As EventArgs)
        If waterMarkTextEnabled Then
            oldFont = New Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)
            Me.Font = oldFont
            'Refresh()
        End If
    End Sub

    Private Sub EnableWaterMark()
        'Save current font until returning the UserPaint style to false (NOTE: It is a try and error advice)
        oldFont = New Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)

        'Enable OnPaint Event Handler
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.waterMarkTextEnabled = True

        'Trigger OnPaint immediatly
        'Refresh()

    End Sub

    Private Sub DisableWaterMark()
        'Disbale OnPaint event handler
        Me.waterMarkTextEnabled = False
        Me.SetStyle(ControlStyles.UserPaint, False)

        'Return oldFont if existed
        If Not oldFont Is Nothing Then
            Me.Font = New Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)
        End If
    End Sub

    ' Override OnCreateControl 
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        WaterMark_Toggle(Nothing, Nothing)
    End Sub

#End Region

    Protected Overloads Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        'DrawBorder()
        If Me.BorderStyle = Forms.BorderStyle.Fixed3D Then
            DrawBorder()
        End If

        ' Use the same font that was defined in base class
        Dim drawFont As Font = New Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)
        ' Create new brush with gray color or 
        Dim drawBrush As SolidBrush = New SolidBrush(Me._waterMarkColor) 'use WaterMarkColor
        ' Draw Test or WaterMark

        If Me.BorderStyle = Forms.BorderStyle.Fixed3D Then
            e.Graphics.DrawString(IIf(waterMarkTextEnabled, _waterMarkText, Text).ToString(), drawFont, drawBrush, New Point(0, 2))
        ElseIf Me.BorderStyle = Forms.BorderStyle.None Then
            e.Graphics.DrawString(IIf(waterMarkTextEnabled, _waterMarkText, Text).ToString(), drawFont, drawBrush, New Point(0, 0))
        Else
            e.Graphics.DrawString(IIf(waterMarkTextEnabled, _waterMarkText, Text).ToString(), drawFont, drawBrush, New Point(0, 4))
        End If

        MyBase.OnPaint(e)
    End Sub

    Protected Overloads Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaintBackground(pevent)
        If Me.BorderStyle = Forms.BorderStyle.Fixed3D Then
            DrawBorder()
        End If

    End Sub

    Dim focus_event As Boolean = False

    Private Sub GotFocus_(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        If Me.ReadOnly = False Then
            MyBase.BackColor = OnFocus

            MyBase.ForeColor = OnFocusF

            If Me.BorderStyle = Forms.BorderStyle.Fixed3D Then
                DrawBorder(BorderEvent.Hover)
            End If


            'Refresh()
            focus_event = True
        End If
    End Sub

    Private Sub LostFocuss(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        If Me.ReadOnly = False Then
            MyBase.BackColor = OnLostBack
            MyBase.ForeColor = OnLostFore
            If Me.BorderStyle = Forms.BorderStyle.Fixed3D Then
                DrawBorder(BorderEvent.Normal)
            End If
            focus_event = False
        End If
    End Sub

    Private Sub MouseMove_(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If Me.ReadOnly = False Then
            If Me.BorderStyle = Forms.BorderStyle.Fixed3D Then
                DrawBorder(BorderEvent.Hover)
            End If
        End If
    End Sub

    Private Sub MouseLeaver(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        If Me.ReadOnly = False Then
            If focus_event = False Then
                If Me.BorderStyle = Forms.BorderStyle.Fixed3D Then
                    DrawBorder(BorderEvent.Normal)
                End If
                'Refresh()
            End If
        End If
    End Sub

    Private Sub OnKeyPress_(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim KeyPressChar As Long
        KeyPressChar = e.KeyChar.GetHashCode
        Select Case KeyPressChar
            Case 65537 ' press ctrl+a
                DirectCast(sender, TextBox).SelectAll()
            Case 327685 'press ctrl+e
                'MsgBox("crl e")
            Case 262148 'press ctrl+d
                DirectCast(sender, TextBox).Text = ""
            Case 393222 'press ctrl+f
                'MsgBox("crl f")
            Case 1245203 'press ctrl+s
                'MsgBox("crl s")
            Case 1769499 ' press esc
                DirectCast(sender, TextBox).Text = ""
            Case 983055 ' press ctrl+o
                'MsgBox("crl o")
        End Select
        If Me.ReadOnly = False Then
            Me.ForeColor = OnFocusF
            Invalidate()
            Refresh()
        End If
    End Sub

End Class


