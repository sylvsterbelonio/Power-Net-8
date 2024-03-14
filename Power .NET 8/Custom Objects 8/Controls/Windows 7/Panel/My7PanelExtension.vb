Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.ComponentModel.Design

'<ToolboxBitmap("MyObjectExtensions.panel.bmp")> _
<ToolboxBitmapAttribute(GetType(Panel))> _
Public Class My7PanelExtension
    Inherits Panel

    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.Opaque, False)
        SetStyle(ControlStyles.DoubleBuffer, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.UserPaint, True)
        UpdateStyles()
    End Sub


#Region "TRANSPARENT AREA"

#Region " PROPERTY "
    Private m_transparent As ViewStyle = ViewStyle.Standard
    Private m_transparentColor As Color = Color.WhiteSmoke
    Private m_opacity As Double = 0.6R
    Private m_backcolor As Color = Color.Transparent

    <System.ComponentModel.Browsable(False)> _
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    <System.ComponentModel.DefaultValue(GetType(Color), "Transparent")> _
    <System.ComponentModel.Description("Set background color.")> _
    <System.ComponentModel.Category("Control Style")> _
        Public Overrides Property BackColor() As System.Drawing.Color
        Get
            Return m_backcolor
        End Get
        Set(ByVal value As System.Drawing.Color)
            m_backcolor = value
            Refresh()
        End Set
    End Property
    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)> _
    <System.ComponentModel.DefaultValue(0.6R)> _
    <System.ComponentModel.TypeConverter(GetType(OpacityConverter))> _
    <System.ComponentModel.Description("Set the opacity percentage of the control.")> _
    <System.ComponentModel.Category("Control Style")> _
    Public Overridable Property My_Transparent_Opacity() As Double
        Get
            Return m_opacity
        End Get
        Set(ByVal value As Double)
            If value = m_opacity Then
                Return
            End If
            m_opacity = value
            UpdateStyles()
            Refresh()
        End Set
    End Property
    Enum ViewStyle
        Standard
        Transparent
        GradientLinear
    End Enum
    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)> _
    <System.ComponentModel.Description("Enable control trnasparency.")> _
    Public Overridable Property My_Transparent_Vissibility() As ViewStyle
        Get
            Return m_transparent
        End Get
        Set(ByVal value As ViewStyle)
            If value = m_transparent Then
                Return
            End If
            m_transparent = value
            Refresh()
        End Set
    End Property
    <System.ComponentModel.Description("Set the fill color of the control.")> _
    Public Overridable Property My_BackColor() As Color
        Get
            Return m_transparentColor
        End Get
        Set(ByVal value As Color)
            m_transparentColor = value
            Refresh()
        End Set
    End Property

#End Region

#Region "FUNCTIONS"

    Public Overridable Sub DrawTransparentBackground(ByVal g As Graphics, ByVal control As My7PanelExtension)
        If My_Transparent_Vissibility = ViewStyle.Transparent Then
            Using sb As New SolidBrush(control.BackColor)
                g.FillRectangle(sb, control.ClientRectangle)
                sb.Dispose()
                Using sbt As New SolidBrush(Color.FromArgb(control.My_Transparent_Opacity * 255, control.My_BackColor))
                    g.FillRectangle(sbt, control.ClientRectangle)
                    sbt.Dispose()
                End Using
            End Using
        ElseIf My_Transparent_Vissibility = ViewStyle.GradientLinear Then
            DrawGradientItem(g, control.ClientRectangle, _itemToolItemSelectedColors)
        Else
            Using sb As New SolidBrush(control.My_BackColor)
                g.FillRectangle(sb, control.ClientRectangle)
                sb.Dispose()
            End Using
        End If
    End Sub

#End Region

#End Region

#Region "GRADIENT AREA"
    Private Const _cutMenuItemBack As Single = 1.2F

    Private select_forecolor As Color = Color.Black
    Private selected_line_colors As Color = Color.Red
    Private tr_tl_lineup_corner As Color = select_top1
    Private tr_tl_corner As Color = select_top1
    Private br_bl_corner As Color = select_bottom1
    Private br_bl_linedown_corner As Color = select_bottom2
    Private top_fill_first As Color = Color.White
    Private top_fill_second As Color = Color.Yellow
    Private bottom_fill_first As Color = Color.Blue
    Private bottom_fill_second As Color = Color.Black
    Private top_rl_down_rl_line_corner_within_menu As Color = Color.White
    Private left_right_side_corner_withing_menu As Color = Color.White
    Private _itemToolItemUnSelectedColors As GradientColor
    Private _itemToolItemSelectedColors As GradientColor

    Private select_top1 As Color = Color.White
    Private select_top2 As Color = Color.Red
    Private select_bottom1 As Color = Color.White
    Private select_bottom2 As Color = Color.Red

#Region "SELECTION STYLE"

    Public Property My_Gradient_Style_TopColor1() As Color
        Get
            Return Me.select_top1
        End Get
        Set(ByVal value As Color)
            select_top1 = value
            Me.Invalidate()
        End Set
    End Property

    Public Property My_Gradient_Style_TopColor2() As Color
        Get
            Return Me.select_top2
        End Get
        Set(ByVal value As Color)
            select_top2 = value
            Me.Invalidate()
        End Set
    End Property

    Public Property My_Gradient_Style_BottomColor1() As Color
        Get
            Return Me.select_bottom1
        End Get
        Set(ByVal value As Color)
            select_bottom1 = value
            Me.Invalidate()
        End Set
    End Property

    Public Property My_Gradient_Style_BottomColor2() As Color
        Get
            Return Me.select_bottom2
        End Get
        Set(ByVal value As Color)
            select_bottom2 = value
            Me.Invalidate()
        End Set
    End Property

#End Region

    Private Sub assign_colors()

        tr_tl_lineup_corner = select_top1
        tr_tl_corner = select_top1
        br_bl_corner = select_bottom1
        br_bl_linedown_corner = select_bottom2
        top_fill_first = select_top1
        top_fill_second = select_top2
        bottom_fill_first = select_bottom1
        bottom_fill_second = select_bottom2
        top_rl_down_rl_line_corner_within_menu = Color.White
        left_right_side_corner_withing_menu = Color.White

        _itemToolItemSelectedColors = New GradientColor(tr_tl_lineup_corner, tr_tl_corner, br_bl_corner, br_bl_linedown_corner, top_fill_first, top_fill_second, bottom_fill_first, bottom_fill_second, top_rl_down_rl_line_corner_within_menu, left_right_side_corner_withing_menu)
    End Sub

    Private Sub DrawGradientItem(ByVal g As Graphics, ByVal backRect As Rectangle, ByVal colors As GradientColor)
        If ((backRect.Width > 0) And (backRect.Height > 0)) Then
            DrawGradientBackground(g, backRect, colors)
        End If
    End Sub
    Private Sub DrawGradientBorder(ByVal g As Graphics, ByVal backRect As Rectangle, ByVal colors As GradientColor)
        Using uaa As UseAntiAlias = New UseAntiAlias(g)
            Dim backRectI As Rectangle = backRect
            backRectI.Inflate(1, 1)
            Using borderBrush As LinearGradientBrush = New LinearGradientBrush(backRectI, colors.TBorder, colors.BBorder, 90.0F)
                borderBrush.SetSigmaBellShape(0.5F)
                Using borderPen As Pen = New Pen(borderBrush)
                    Using borderPath As GraphicsPath = GetBorderPath(backRect, _cutMenuItemBack)
                        g.DrawPath(borderPen, borderPath)
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Private Sub DrawGradientBackground(ByVal g As Graphics, ByVal backRect As Rectangle, ByVal colors As GradientColor)
        backRect.Inflate(-1, -1)
        Dim y2 As Int32 = backRect.Height / 2
        Dim backRect1 As Rectangle = New Rectangle(backRect.X, backRect.Y, backRect.Width, y2)
        Dim backRect2 As Rectangle = New Rectangle(backRect.X, backRect.Y + y2, backRect.Width, backRect.Height - y2)
        Dim backRect1I As Rectangle = backRect1
        Dim backRect2I As Rectangle = backRect2
        backRect1I.Inflate(1, 1)
        backRect2I.Inflate(1, 1)
        Using insideBrush1 As LinearGradientBrush = New LinearGradientBrush(backRect1I, colors.InsideTTop, colors.InsideBTop, 90.0F), _
            insideBrush2 = New LinearGradientBrush(backRect2I, colors.InsideTBottom, colors.InsideBBottom, 90.0F)
            g.FillRectangle(insideBrush1, backRect1)
            g.FillRectangle(insideBrush2, backRect2)
        End Using
        y2 = backRect.Height / 2
        backRect1 = New Rectangle(backRect.X, backRect.Y, backRect.Width, y2)
        backRect2 = New Rectangle(backRect.X, backRect.Y + y2, backRect.Width, backRect.Height - y2)
        backRect1I = backRect1
        backRect2I = backRect2
        backRect1I.Inflate(1, 1)
        backRect2I.Inflate(1, 1)
        Using fillBrush1 As LinearGradientBrush = New LinearGradientBrush(backRect1I, colors.FillTTop, colors.FillBTop, 90.0F), _
            fillBrush2 = New LinearGradientBrush(backRect2I, colors.FillTBottom, colors.FillBBottom, 90.0F)
            backRect.Inflate(-1, -1)
            y2 = backRect.Height / 2
            backRect1 = New Rectangle(backRect.X, backRect.Y, backRect.Width, y2)
            backRect2 = New Rectangle(backRect.X, backRect.Y + y2, backRect.Width, backRect.Height - y2)
            g.FillRectangle(fillBrush1, backRect1)
            g.FillRectangle(fillBrush2, backRect2)
        End Using
    End Sub

#Region "UseAntiAlias Class"

    Public Class UseAntiAlias
        Implements IDisposable
        Private disposedValue As Boolean = False        ' To detect redundant calls
        ' IDisposable
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: free other state (managed objects).
                End If

                ' TODO: free your own state (unmanaged objects).
                ' TODO: set large fields to null.
            End If
            Me.disposedValue = True
        End Sub

#Region " IDisposable Support "
        ' This code added by Visual Basic to correctly implement the disposable pattern.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region

#Region "Instance Fields"
        Private _g As Graphics
        Private _old As SmoothingMode
#End Region

        Public Sub New(ByVal g As Graphics)
            _g = g
            _old = _g.SmoothingMode
            _g.SmoothingMode = SmoothingMode.AntiAlias
        End Sub

        Protected Overrides Sub Finalize()
            _g.SmoothingMode = _old
            MyBase.Finalize()
        End Sub

    End Class

#End Region

    Private Function GetBorderPath(ByVal rect As Rectangle, ByVal cut As Single) As GraphicsPath
        rect.Width -= 1
        rect.Height -= 1
        Dim path As GraphicsPath = New GraphicsPath()
        path.AddLine(rect.Left + cut, rect.Top, rect.Right - cut, rect.Top)
        path.AddLine(rect.Right - cut, rect.Top, rect.Right, rect.Top + cut)
        path.AddLine(rect.Right, rect.Top + cut, rect.Right, rect.Bottom - cut)
        path.AddLine(rect.Right, rect.Bottom - cut, rect.Right - cut, rect.Bottom)
        path.AddLine(rect.Right - cut, rect.Bottom, rect.Left + cut, rect.Bottom)
        path.AddLine(rect.Left + cut, rect.Bottom, rect.Left, rect.Bottom - cut)
        path.AddLine(rect.Left, rect.Bottom - cut, rect.Left, rect.Top + cut)
        path.AddLine(rect.Left, rect.Top + cut, rect.Left + cut, rect.Top)
        Return path
    End Function

#Region "Gradient Color"
    ''' <summary>
    ''' GradientColor Class which Provides Gradient Colors
    ''' </summary>
    Private Class GradientColor

#Region "           Public Fields"
        Public InsideTTop As Color
        Public InsideBTop As Color
        Public InsideTBottom As Color
        Public InsideBBottom As Color
        Public FillTTop As Color
        Public FillBTop As Color
        Public FillTBottom As Color
        Public FillBBottom As Color
        Public TBorder As Color
        Public BBorder As Color
#End Region

#Region "           Identity"
        ''' <summary>
        ''' Constructor for GradientItemColor Class
        ''' </summary>
        Public Sub New(ByVal _insideTTop As Color, ByVal _insideBTop As Color, _
                                      ByVal _insideTBottom As Color, ByVal _insideBBottom As Color, _
                                      ByVal _fillTTop As Color, ByVal _fillBTop As Color, _
                                      ByVal _fillTBottom As Color, ByVal _fillBBottom As Color, _
                                      ByVal _Tborder As Color, ByVal _Bborder As Color)
            InsideTTop = _insideTTop
            InsideBTop = _insideBTop
            InsideTBottom = _insideTBottom
            InsideBBottom = _insideBBottom
            FillTTop = _fillTTop
            FillBTop = _fillBTop
            FillTBottom = _fillTBottom
            FillBBottom = _fillBBottom
            TBorder = _Tborder
            BBorder = _Bborder
        End Sub
#End Region

    End Class

#End Region

#End Region

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        assign_colors()
        DrawTransparentBackground(e.Graphics, Me)

        ExtendedDraw(e)
        DrawBorder(e.Graphics)
        load_the_latest_event()
    End Sub


#Region "ROUND CORNER"
    Private _borderColor As Color = Color.Black
    Private pen As Pen = New Pen(_borderColor, penWidth)
    Private penWidth As Double = 2.0F
    Private _edge As Integer = 15
    <Browsable(True)> _
    Public Property My_Corner() As Integer
        Get
            Return _edge
        End Get
        Set(ByVal Value As Integer)
            _edge = Value
            Invalidate()
        End Set
    End Property

    <Browsable(True)> _
    Public Property My_Border_Color() As Color
        Get
            Return _borderColor
        End Get
        Set(ByVal Value As Color)
            _borderColor = Value
            pen = New Pen(_borderColor, penWidth)
            Invalidate()
        End Set
    End Property
    Public Property My_Border_Size() As Double
        Get
            Return Me.penWidth
        End Get
        Set(ByVal value As Double)
            penWidth = value
            Invalidate()
        End Set
    End Property
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
    Private Sub ExtendedDraw(ByVal e As PaintEventArgs)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim path As GraphicsPath = New GraphicsPath()
        path.StartFigure()
        path.StartFigure()
        path.AddArc(GetLeftUpper(My_Corner), 180, 90)
        path.AddLine(My_Corner, 0, Width - My_Corner, 0)
        path.AddArc(GetRightUpper(My_Corner), 270, 90)
        path.AddLine(Width, My_Corner, Width, Height - My_Corner)
        path.AddArc(GetRightLower(My_Corner), 0, 90)
        path.AddLine(Width - My_Corner, Height, My_Corner, Height)
        path.AddArc(GetLeftLower(My_Corner), 90, 90)
        path.AddLine(0, Height - My_Corner, 0, My_Corner)
        path.CloseFigure()
        Region = New Region(path)
    End Sub
    Private Sub DrawBorder(ByVal graphics As Graphics)
        DrawSingleBorder(graphics)
    End Sub
    Private Sub DrawSingleBorder(ByVal graphics As Graphics)
        graphics.DrawArc(pen, New Rectangle(0, 0, My_Corner, My_Corner), _
                         180, 90)
        graphics.DrawArc(pen, New Rectangle(Width - My_Corner - 1, -1, _
                         My_Corner, My_Corner), 270, 90)
        graphics.DrawArc(pen, New Rectangle(Width - My_Corner - 1, _
                         Height - My_Corner - 1, My_Corner, My_Corner), 0, 90)
        graphics.DrawArc(pen, New Rectangle(0, Height - My_Corner - 1, _
                         My_Corner, My_Corner), 90, 90)
        graphics.DrawRectangle(pen, 0.0F, 0.0F, CType((Width - 1), _
                               Single), CType((Height - 1), Single))
    End Sub

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        Invalidate()
    End Sub

    Protected Overrides Sub OnScroll(ByVal se As System.Windows.Forms.ScrollEventArgs)
        MyBase.OnScroll(se)
        Me.Invalidate()
    End Sub


#Region "VALIDATION OF BORDER ERRORS"

    'Private Sub load_the_latest_event()
    '    For i As Integer = 0 To Me.Controls.Count - 1
    '        Dim a As Object = Me.Controls(i)
    '        If TypeOf a Is MyComboBoxExtension Then
    '            If CType(a, MyComboBoxExtension).Enabled = False Then
    '                CType(a, MyComboBoxExtension).Enabled = True
    '                CType(a, MyComboBoxExtension).Enabled = False
    '                CType(a, MyComboBoxExtension).BackColor = Color.Red
    '            End If
    '            CType(a, MyComboBoxExtension).reload_draw_item()
    '        Else
    '        End If
    '    Next
    'End Sub

    'Private Sub update_combobox()
    '    For i As Integer = 0 To Me.Controls.Count - 1
    '        Dim a As Object = Me.Controls(i)
    '        If TypeOf a Is MyComboBoxExtension Then
    '            If CType(a, MyComboBoxExtension).Enabled Then
    '                If Not CType(a, MyComboBoxExtension).checkHasBorderErrors And Not CType(a, MyComboBoxExtension).CheckHasDisabledOccurred Then
    '                    CType(a, MyComboBoxExtension).RefreshBorder()
    '                Else
    '                End If
    '            Else
    '            End If
    '        End If
    '    Next
    'End Sub
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        load_the_latest_event()
    End Sub

    Private Sub load_the_latest_event()
        For i As Integer = 0 To Me.Controls.Count - 1
            Dim a As Object = Me.Controls(i)
            'If TypeOf a Is MyComboBoxExtension Then
            '    CType(a, MyComboBoxExtension).reload_draw_item()
            'End If
        Next
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        'load_the_latest_event()
        'update_combobox()
    End Sub

#End Region

#End Region

End Class

Public Class TransparentControlActionList2

    Inherits DesignerActionList

#Region " Field "
    Private designerActionUISvc As System.ComponentModel.Design.DesignerActionUIService = Nothing
    Private tc As My7PanelExtension
#End Region

#Region " Constructor "
    Public Sub New(ByVal component As IComponent)
        MyBase.New(component)
        tc = component
        designerActionUISvc = CType(GetService(GetType(DesignerActionUIService)), DesignerActionUIService)
    End Sub
#End Region

#Region " Property "

    <System.ComponentModel.DefaultValue(1.0R)> _
    <System.ComponentModel.TypeConverter(GetType(OpacityConverter))> _
    Public Overridable Property Opacity() As Double
        Get
            Return tc.My_Transparent_Opacity
        End Get
        Set(ByVal value As Double)
            GetPropertyByName("Opacity").SetValue(tc, value)
        End Set
    End Property

    <System.ComponentModel.DefaultValue(GetType(Boolean), "False")> _
    Public Overridable Property Transparent() As Boolean
        Get
            Return tc.My_Transparent_Vissibility
        End Get
        Set(ByVal value As Boolean)
            GetPropertyByName("Transparent").SetValue(tc, value)
        End Set
    End Property

    <System.ComponentModel.DefaultValue(GetType(Color), "OliveDrab")> _
    Public Overridable Property TransparentColor() As Color
        Get
            Return tc.My_BackColor
        End Get
        Set(ByVal value As Color)
            GetPropertyByName("TransparentColor").SetValue(tc, value)
        End Set
    End Property

#End Region

#Region " Function "
    Private Function GetPropertyByName(ByVal propName As String) As PropertyDescriptor

        Dim prop As PropertyDescriptor = TypeDescriptor.GetProperties(tc)(propName)
        If prop Is Nothing Then
            Throw New ArgumentException("Matching property not valid!", propName)
        Else
            Return prop
        End If
    End Function

#End Region


End Class




