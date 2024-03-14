Imports System.Text
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Public Class MyMenuStripExtension
    Inherits MenuStrip

    Private select_font_color As Color = Color.DarkBlue
    Private select_border_color As Color = Color.Black
    Private select_top1 As Color = ColorTranslator.FromHtml("#ffffff")
    Private select_top2 As Color = ColorTranslator.FromHtml("#dceefb")
    Private select_bottom1 As Color = ColorTranslator.FromHtml("#c6e6ff")
    Private select_bottom2 As Color = ColorTranslator.FromHtml("#d6eaf9")

    Private unselect_font_color As Color = Color.Black
    Private unselect_border_color As Color = ColorTranslator.FromHtml("#dadada")
    Private unselect_top1 As Color = ColorTranslator.FromHtml("#f3f4f5")
    Private unselect_top2 As Color = ColorTranslator.FromHtml("#e8e9e9")
    Private unselect_bottom1 As Color = ColorTranslator.FromHtml("#c1c1c1")
    Private unselect_bottom2 As Color = ColorTranslator.FromHtml("#f3f4f5")

    Private dselect_font_color As Color = Color.White
    Private dselect_border_color As Color = Color.White
    Private dselect_top1 As Color = Color.White
    Private dselect_top2 As Color = ColorTranslator.FromHtml("#e8e9e9")
    Private dselect_bottom1 As Color = Color.LightGray
    Private dselect_bottom2 As Color = Color.White

    Private Renderers As New myRenderer_MenuStrip

    Private Sub set_renderer()
        With Renderers

            .select_font_color = select_font_color
            .select_border_color = select_border_color
            .select_top1 = select_top1
            .select_top2 = select_top2
            .select_bottom1 = select_bottom1
            .select_bottom2 = select_bottom2
            ._My_Selection_Style_Custom_Select_Has_Border = _My_Selection_Style_Custom_Select_Has_Border

            .border_color = border_color
            .hasBorder = hasBorder

            .unselect_font_color = unselect_font_color
            .unselect_border_color = unselect_border_color
            .unselect_top1 = unselect_top1
            .unselect_top2 = unselect_top2
            .unselect_bottom1 = unselect_bottom1
            .unselect_bottom2 = unselect_bottom2
            ._Unselect_Has_Border = _Unselect_Has_Border

            .dselect_top1 = dselect_top1
            .dselect_top2 = dselect_top2
            .dselect_bottom1 = dselect_bottom1
            .dselect_bottom2 = dselect_bottom2

            .standard_highlight_backcolor = standard_highlight_backcolor

            .SelectionStyle = SelectionStyle
            .assign_colors()
        End With
        Me.Renderer = Renderers
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        set_renderer()
        If _Background_Style = BackStyle.VerticalGradient Then
            Renderers.fillBackgroundColor(e.Graphics, e.ClipRectangle)
        End If
        MyBase.OnPaint(e)
    End Sub


#Region "SELECTION STYLE"
    Private _My_Selection_Style_Custom_Select_Has_Border As Boolean = False
    Public Property My_Selection_Style_Custom_Select_Has_Border() As Boolean
        Get
            Return _My_Selection_Style_Custom_Select_Has_Border
        End Get
        Set(ByVal value As Boolean)
            _My_Selection_Style_Custom_Select_Has_Border = value
        End Set
    End Property
    Public Property My_Standard_Select_FontColor() As Color
        Get
            Return Me.select_font_color
        End Get
        Set(ByVal value As Color)
            select_font_color = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_Selection_Style_Custom_Select_BorderColor() As Color
        Get
            Return Me.select_border_color
        End Get
        Set(ByVal value As Color)
            select_border_color = value
        End Set
    End Property
    Public Property My_Selection_Style_Custom_Select_TopColor1() As Color
        Get
            Return Me.select_top1
        End Get
        Set(ByVal value As Color)
            select_top1 = value
        End Set
    End Property
    Public Property My_Selection_Style_Custom_Select_TopColor2() As Color
        Get
            Return Me.select_top2
        End Get
        Set(ByVal value As Color)
            select_top2 = value
        End Set
    End Property
    Public Property My_Selection_Style_Custom_Select_BottomColor1() As Color
        Get
            Return Me.select_bottom1
        End Get
        Set(ByVal value As Color)
            select_bottom1 = value
        End Set
    End Property
    Public Property My_Selection_Style_Custom_Select_BottomColor2() As Color
        Get
            Return Me.select_bottom2
        End Get
        Set(ByVal value As Color)
            select_bottom2 = value
        End Set
    End Property
#End Region

#Region "UNSELECTION STYLE"
    Private _Unselect_Has_Border As Boolean = False
    Public Property My_Selection_Style_Custom_UnSelect_Has_Border() As Boolean
        Get
            Return _Unselect_Has_Border
        End Get
        Set(ByVal value As Boolean)
            _Unselect_Has_Border = value
        End Set
    End Property
    Public Property My_Standard_UnSelect_FontColor() As Color
        Get
            Return Me.unselect_font_color
        End Get
        Set(ByVal value As Color)
            unselect_font_color = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_Selection_Style_Custom_UnSelect_BorderColor() As Color
        Get
            Return Me.unselect_border_color
        End Get
        Set(ByVal value As Color)
            unselect_border_color = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_Selection_Style_Custom_UnSelect_TopColor1() As Color
        Get
            Return Me.unselect_top1
        End Get
        Set(ByVal value As Color)
            unselect_top1 = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_Selection_Style_Custom_UnSelect_TopColor2() As Color
        Get
            Return Me.unselect_top2
        End Get
        Set(ByVal value As Color)
            unselect_top2 = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_Selection_Style_Custom_UnSelect_BottomColor1() As Color
        Get
            Return Me.unselect_bottom1
        End Get
        Set(ByVal value As Color)
            unselect_bottom1 = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_Selection_Style_Custom_UnSelect_BottomColor2() As Color
        Get
            Return Me.unselect_bottom2
        End Get
        Set(ByVal value As Color)
            unselect_bottom2 = value
            Me.Invalidate()
        End Set
    End Property

#End Region

#Region "BACKGROUND COLOR"
    Public Property My_BackGround_TopColor1() As Color
        Get
            Return Me.dselect_top1
        End Get
        Set(ByVal value As Color)
            dselect_top1 = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_BackGround_TopColor2() As Color
        Get
            Return Me.dselect_top2
        End Get
        Set(ByVal value As Color)
            dselect_top2 = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_BackGround_BottomColor1() As Color
        Get
            Return Me.dselect_bottom1
        End Get
        Set(ByVal value As Color)
            dselect_bottom1 = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_BackGround_BottomColor2() As Color
        Get
            Return Me.dselect_bottom2
        End Get
        Set(ByVal value As Color)
            dselect_bottom2 = value
            Me.Invalidate()
        End Set
    End Property
#End Region

    Enum BackStyle
        Standard
        VerticalGradient
    End Enum
    Private border_color As Color = Color.SteelBlue
    Public Property My_BackGround_BorderColor() As Color
        Get
            Return Me.border_color
        End Get
        Set(ByVal value As Color)
            border_color = value
            Invalidate()
        End Set
    End Property
    Private hasBorder As Boolean = False
    Public Property My_BackGround_HasBorder() As Boolean
        Get
            Return Me.hasBorder
        End Get
        Set(ByVal value As Boolean)
            hasBorder = value
            Invalidate()
        End Set
    End Property

    Private _Background_Style As BackStyle = BackStyle.Standard
    Public Property My_BackGround_Style() As BackStyle
        Get
            Return _Background_Style
        End Get
        Set(ByVal value As BackStyle)
            _Background_Style = value
            Me.Invalidate()
        End Set
    End Property

    Enum SelectStyleType
        Standard
        Custom_Selection_Only
        Custom_Select_and_Unselect
    End Enum
    Private SelectionStyle As SelectStyleType = SelectStyleType.Standard
    Public Property My_Selection_Style() As SelectStyleType
        Get
            Return Me.SelectionStyle
        End Get
        Set(ByVal value As SelectStyleType)
            SelectionStyle = value
            Me.Invalidate()
        End Set
    End Property
    Private standard_highlight_backcolor As Color = Color.Beige
    Public Property My_Standard_Selection_BackColor() As Color
        Get
            Return standard_highlight_backcolor
        End Get
        Set(ByVal value As Color)
            standard_highlight_backcolor = value
        End Set
    End Property

End Class


Public Class myRenderer_MenuStrip
    Inherits ToolStripProfessionalRenderer



    Public select_font_color As Color = Color.DarkBlue
    Public select_border_color As Color = ColorTranslator.FromHtml("#cae8ff")
    Public select_top1 As Color = ColorTranslator.FromHtml("#ffffff")
    Public select_top2 As Color = ColorTranslator.FromHtml("#dceefb")
    Public select_bottom1 As Color = ColorTranslator.FromHtml("#c6e6ff")
    Public select_bottom2 As Color = ColorTranslator.FromHtml("#d6eaf9")
    Public _My_Selection_Style_Custom_Select_Has_Border As Boolean = False

    Public unselect_font_color As Color = ColorTranslator.FromHtml("#797979")
    Public unselect_border_color As Color = ColorTranslator.FromHtml("#dadada")
    Public unselect_top1 As Color = ColorTranslator.FromHtml("#f3f4f5")
    Public unselect_top2 As Color = ColorTranslator.FromHtml("#e8e9e9")
    Public unselect_bottom1 As Color = ColorTranslator.FromHtml("#c1c1c1")
    Public unselect_bottom2 As Color = ColorTranslator.FromHtml("#f3f4f5")
    Public _Unselect_Has_Border As Boolean = False

    Public dselect_font_color As Color = ColorTranslator.FromHtml("#797979")
    Public dselect_border_color As Color = ColorTranslator.FromHtml("#dadada")
    Public dselect_top1 As Color = ColorTranslator.FromHtml("#f3f4f5")
    Public dselect_top2 As Color = ColorTranslator.FromHtml("#e8e9e9")
    Public dselect_bottom1 As Color = ColorTranslator.FromHtml("#c1c1c1")
    Public dselect_bottom2 As Color = ColorTranslator.FromHtml("#f3f4f5")
    Public border_color As Color = Color.SteelBlue
    Public hasBorder As Boolean = False

    Private Const _cutMenuItemBack As Single = 1.2F
    Public StrokeColor As Color = Color.FromArgb(196, 177, 118)

    Private select_color As String
    Private unselect_color As String

    Private tr_tl_lineup_corner As Color
    Private tr_tl_corner As Color
    Private br_bl_corner As Color
    Private br_bl_linedown_corner As Color
    Private top_fill_first As Color
    Private top_fill_second As Color
    Private bottom_fill_first As Color
    Private bottom_fill_second As Color
    Private top_rl_down_rl_line_corner_within_menu As Color
    Private left_right_side_corner_withing_menu As Color

    Private ntr_tl_lineup_corner As Color
    Private ntr_tl_corner As Color
    Private nbr_bl_corner As Color
    Private nbr_bl_linedown_corner As Color
    Private ntop_fill_first As Color
    Private ntop_fill_second As Color
    Private nbottom_fill_first As Color
    Private nbottom_fill_second As Color
    Private ntop_rl_down_rl_line_corner_within_menu As Color
    Private nleft_right_side_corner_withing_menu As Color

    Private dntr_tl_lineup_corner As Color
    Private dntr_tl_corner As Color
    Private dnbr_bl_corner As Color
    Private dnbr_bl_linedown_corner As Color
    Private dntop_fill_first As Color
    Private dntop_fill_second As Color
    Private dnbottom_fill_first As Color
    Private dnbottom_fill_second As Color
    Private dntop_rl_down_rl_line_corner_within_menu As Color
    Private dnleft_right_side_corner_withing_menu As Color


    Private select_forecolor As Color = Color.Red
    Private unselected_backcolor As Color = Color.White
    Private unselected_forecolor As Color = Color.Black
    Public standard_highlight_backcolor As Color = Color.Beige

    Private _separatorMenuLight As Color = Color.Red
    Private _itemContextItemEnabledColors As GradientColor
    Private _itemDisabledColors As GradientColor
    Private _itemToolItemSelectedColors As GradientColor
    Private _BackgroundColors As GradientColor


    Enum SelectStyleType
        Standard
        Custom_Selection_Only
        Custom_Select_and_Unselect
    End Enum
    Public SelectionStyle As SelectStyleType = SelectStyleType.Standard


    Public Sub assign_colors()

        If _My_Selection_Style_Custom_Select_Has_Border Then
            tr_tl_lineup_corner = select_border_color
            tr_tl_corner = select_border_color
            br_bl_corner = select_border_color
            br_bl_linedown_corner = select_border_color
        Else
            tr_tl_lineup_corner = select_top1
            tr_tl_corner = select_top1
            br_bl_corner = select_bottom2
            br_bl_linedown_corner = select_bottom2
        End If

        top_fill_first = select_top1
        top_fill_second = select_top2
        bottom_fill_first = select_bottom1
        bottom_fill_second = select_bottom2
        top_rl_down_rl_line_corner_within_menu = select_border_color
        left_right_side_corner_withing_menu = select_border_color
        select_forecolor = select_font_color


        If _Unselect_Has_Border Then
            ntr_tl_lineup_corner = unselect_border_color
            ntr_tl_corner = unselect_border_color
            nbr_bl_corner = unselect_border_color
            nbr_bl_linedown_corner = unselect_border_color
        Else
            ntr_tl_lineup_corner = unselect_top1
            ntr_tl_corner = unselect_top1
            nbr_bl_corner = unselect_bottom2
            nbr_bl_linedown_corner = unselect_bottom2
        End If

        ntop_fill_first = unselect_top1
        ntop_fill_second = unselect_top2
        nbottom_fill_first = unselect_bottom1
        nbottom_fill_second = unselect_bottom2
        ntop_rl_down_rl_line_corner_within_menu = unselect_border_color
        nleft_right_side_corner_withing_menu = unselect_border_color
        unselected_forecolor = unselect_font_color

        If hasBorder Then
            dntr_tl_lineup_corner = border_color
            dntr_tl_corner = border_color
            dnbr_bl_corner = border_color
            dnbr_bl_linedown_corner = border_color

            dntop_rl_down_rl_line_corner_within_menu = border_color
            dnleft_right_side_corner_withing_menu = border_color
        Else
            dntr_tl_lineup_corner = dselect_top1
            dntr_tl_corner = dselect_top1
            dnbr_bl_corner = dselect_bottom2
            dnbr_bl_linedown_corner = dselect_bottom2

            dntop_rl_down_rl_line_corner_within_menu = dselect_border_color
            dnleft_right_side_corner_withing_menu = dselect_border_color
        End If

        dntop_fill_first = dselect_top1
        dntop_fill_second = dselect_top2
        dnbottom_fill_first = dselect_bottom1
        dnbottom_fill_second = dselect_bottom2
        dntop_rl_down_rl_line_corner_within_menu = dselect_border_color
        dnleft_right_side_corner_withing_menu = dselect_border_color

        _itemContextItemEnabledColors = New GradientColor(tr_tl_lineup_corner, tr_tl_corner, br_bl_corner, br_bl_linedown_corner, top_fill_first, top_fill_second, bottom_fill_first, bottom_fill_second, Color.FromArgb(217, 203, 150), Color.FromArgb(192, 167, 118))
        _itemDisabledColors = New GradientColor(ntr_tl_lineup_corner, ntr_tl_corner, nbr_bl_corner, nbr_bl_linedown_corner, ntop_fill_first, ntop_fill_second, nbottom_fill_first, nbottom_fill_second, ntop_rl_down_rl_line_corner_within_menu, nleft_right_side_corner_withing_menu)
        _itemToolItemSelectedColors = New GradientColor(tr_tl_lineup_corner, tr_tl_corner, br_bl_corner, br_bl_linedown_corner, top_fill_first, top_fill_second, bottom_fill_first, bottom_fill_second, top_rl_down_rl_line_corner_within_menu, left_right_side_corner_withing_menu)
        _BackgroundColors = New GradientColor(dntr_tl_lineup_corner, dntr_tl_corner, dnbr_bl_corner, dnbr_bl_linedown_corner, dntop_fill_first, dntop_fill_second, dnbottom_fill_first, dnbottom_fill_second, dntop_rl_down_rl_line_corner_within_menu, dnleft_right_side_corner_withing_menu)

    End Sub


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

    Dim offsetx As Int32 = 3, offsety As Int32 = 2, imageheight As Int32 = 0, imagewidth As Int32 = 0
    Protected Overrides Sub OnRenderItemImage(ByVal e As System.Windows.Forms.ToolStripItemImageRenderEventArgs)
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality
        If Not (e.Image Is Nothing) Then
            imageheight = e.Item.Height - offsety * 2
            imagewidth = ((Convert.ToDouble(imageheight) / e.Image.Height) * e.Image.Width)
        End If
        e.Graphics.DrawImage(e.Image, New Rectangle(offsetx, offsety, imagewidth, imageheight))
    End Sub

    Public Sub fillBackgroundColor(ByVal e As Graphics, ByVal rect As Rectangle)
        DrawGradientBackground(e, rect, _BackgroundColors)
    End Sub

    Protected Overloads Overrides Sub OnRenderMenuItemBackground(ByVal e As ToolStripItemRenderEventArgs)
        If e.Item.Selected Then
            e.Item.ForeColor = select_forecolor

            If (e.Item.Enabled) Then
                If SelectionStyle = SelectStyleType.Custom_Selection_Only Or SelectionStyle = SelectStyleType.Custom_Select_and_Unselect Then
                    If TypeOf (e.ToolStrip) Is MenuStrip Then
                        DrawGradientToolItem(e.Graphics, e.Item, _itemToolItemSelectedColors)
                    Else
                        DrawGradientMenuItem(e.Graphics, e.Item, _itemContextItemEnabledColors)
                    End If
                Else
                    Dim mousePos As Point = e.ToolStrip.PointToClient(Control.MousePosition)
                    If TypeOf e.ToolStrip Is MenuStrip Then
                        e.Graphics.FillRectangle(New SolidBrush(standard_highlight_backcolor), e.ToolStrip.Bounds)
                    ElseIf TypeOf e.ToolStrip Is ToolStripDropDownMenu Then
                        Dim backRect As Rectangle = New Rectangle(2, 0, e.Item.Bounds.Width - 3, e.Item.Bounds.Height)
                        e.Graphics.FillRectangle(New SolidBrush(standard_highlight_backcolor), backRect)
                    End If
                End If
            Else
                Dim mousePos As Point = e.ToolStrip.PointToClient(Control.MousePosition)
                If (Not e.Item.Bounds.Contains(mousePos)) Then
                    If TypeOf (e.ToolStrip) Is MenuStrip Then
                        DrawGradientToolItem(e.Graphics, e.Item, _itemDisabledColors)
                    Else
                        DrawGradientMenuItem(e.Graphics, e.Item, _itemDisabledColors)
                    End If
                End If
            End If
        Else

            If SelectionStyle = SelectStyleType.Standard Then
                'nothing
                e.Item.ForeColor = unselected_forecolor
                e.Graphics.FillRectangle(Brushes.Transparent, e.Item.Bounds)
            ElseIf SelectionStyle = SelectStyleType.Custom_Selection_Only Then
                'nothing
                e.Item.ForeColor = unselected_forecolor
            ElseIf SelectionStyle = SelectStyleType.Custom_Select_and_Unselect Then
                e.Item.ForeColor = unselected_forecolor
                DrawGradientMenuItem2(e.Graphics, e.Item, _itemDisabledColors)
            End If
            'Dim rc As New Rectangle(Point.Empty, e.Item.Size)
            'Dim c As Color = unselected_backcolor
            'Using brush As New SolidBrush(c)
            '    e.Graphics.FillRectangle(brush, rc)
            'End Using
            'e.Item.ForeColor = unselected_forecolor
        End If
    End Sub

    Private Sub DrawGradientMenuItem(ByVal g As Graphics, ByVal item As ToolStripItem, ByVal colors As GradientColor)
        Dim backRect As Rectangle = New Rectangle(-1, -2, item.Bounds.Width + 2, item.Bounds.Height + 3)
        DrawGradientItem(g, backRect, colors)
    End Sub

    Private Sub DrawGradientMenuItem2(ByVal g As Graphics, ByVal item As ToolStripItem, ByVal colors As GradientColor)
        Dim backRect As Rectangle = New Rectangle(-1, -2, item.Bounds.Width + 2, item.Bounds.Height + 3)
        DrawGradientItem2(g, backRect, colors)
    End Sub

    Private Sub DrawGradientToolItem(ByVal g As Graphics, ByVal item As ToolStripItem, ByVal colors As GradientColor)
        Dim a As New Size(item.Bounds.Width + 2, item.Bounds.Height + 3)
        DrawGradientItem(g, New Rectangle(Point.Empty, a), colors)
    End Sub

    Private Sub DrawGradientItem(ByVal g As Graphics, ByVal backRect As Rectangle, ByVal colors As GradientColor)
        If ((backRect.Width > 0) And (backRect.Height > 0)) Then
            DrawGradientBackground(g, backRect, colors)

            If _My_Selection_Style_Custom_Select_Has_Border Then
                DrawGradientBorder(g, backRect, colors)
            End If

        End If
    End Sub

    Private Sub DrawGradientItem2(ByVal g As Graphics, ByVal backRect As Rectangle, ByVal colors As GradientColor)
        If ((backRect.Width > 0) And (backRect.Height > 0)) Then
            DrawGradientBackground(g, backRect, colors)
            If _Unselect_Has_Border Then
                DrawGradientBorder(g, backRect, colors)
            End If
        End If
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

End Class
