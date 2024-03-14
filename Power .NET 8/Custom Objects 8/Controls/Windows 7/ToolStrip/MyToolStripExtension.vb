Imports System.Text
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Public Class MyToolStripExtension
    Inherits ToolStrip
    Private Renderers As New myRenderer_ToolStrip
    Private select_font_color As Color = Color.DarkBlue
    Private select_border_color As Color = Color.Black
    Private select_top1 As Color = ColorTranslator.FromHtml("#ffffff")
    Private select_top2 As Color = ColorTranslator.FromHtml("#dceefb")
    Private select_bottom1 As Color = ColorTranslator.FromHtml("#c6e6ff")
    Private select_bottom2 As Color = ColorTranslator.FromHtml("#d6eaf9")
    Private select_has_border As Boolean = False

    Private unselect_font_color As Color = Color.Black
    Private unselect_border_color As Color = ColorTranslator.FromHtml("#dadada")
    Private unselect_top1 As Color = ColorTranslator.FromHtml("#f3f4f5")
    Private unselect_top2 As Color = ColorTranslator.FromHtml("#e8e9e9")
    Private unselect_bottom1 As Color = ColorTranslator.FromHtml("#c1c1c1")
    Private unselect_bottom2 As Color = ColorTranslator.FromHtml("#f3f4f5")
    Private unselect_has_border As Boolean = False

    Private dselect_font_color As Color = Color.White
    Private dselect_border_color As Color = Color.White
    Private dselect_top1 As Color = Color.White
    Private dselect_top2 As Color = ColorTranslator.FromHtml("#e8e9e9")
    Private dselect_bottom1 As Color = Color.LightGray
    Private dselect_bottom2 As Color = Color.White
    Private background_has_border As Boolean = False
    Private timer As New Timer


    'this is very important in order to inherit into the toolbar'
    Public Sub New()
        MyBase.New()
        With timer
            AddHandler .Tick, AddressOf Timer1_Tick
            .Start()
        End With
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Refresh()
    End Sub

    Private Sub set_renderer()
        With Renderers
            .select_font_color = select_font_color
            .select_border_color = select_border_color
            .select_top1 = select_top1
            .select_top2 = select_top2
            .select_bottom1 = select_bottom1
            .select_bottom2 = select_bottom2
            .select_has_border = select_has_border
            ._Background_Style = _Background_Style
            .unselect_font_color = unselect_font_color
            .unselect_border_color = unselect_border_color
            .unselect_top1 = unselect_top1
            .unselect_top2 = unselect_top2
            .unselect_bottom1 = unselect_bottom1
            .unselect_bottom2 = unselect_bottom2
            .unselect_has_border = unselect_has_border

            .dselect_font_color = dselect_font_color
            .dselect_border_color = dselect_border_color
            .dselect_top1 = dselect_top1
            .dselect_top2 = dselect_top2
            .dselect_bottom1 = dselect_bottom1
            .dselect_bottom2 = dselect_bottom2
            .standard_highlight_backcolor = standard_highlight_backcolor
            .SelectionStyle = SelectionStyle
            .background_has_border = background_has_border
            .TransEffect = TransEffect
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
            Return select_has_border
        End Get
        Set(ByVal value As Boolean)
            select_has_border = value
            Me.Invalidate()
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
            Return unselect_has_border
        End Get
        Set(ByVal value As Boolean)
            unselect_has_border = value
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
    Public Property My_BackGround_BorderColor() As Color
        Get
            Return dselect_border_color
        End Get
        Set(ByVal value As Color)
            dselect_border_color = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_BackGround_Has_Border() As Boolean
        Get
            Return background_has_border
        End Get
        Set(ByVal value As Boolean)
            background_has_border = value
            Me.Invalidate()
        End Set
    End Property
#End Region

    Private TransEffect As Boolean = False
    Public Property My_Transparent_Effect() As Boolean
        Get
            Return TransEffect
        End Get
        Set(ByVal value As Boolean)
            TransEffect = value
            Me.Invalidate()
        End Set
    End Property

    Enum BackStyle
        Standard
        VerticalGradient
    End Enum
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
    Private standard_highlight_backcolor As Color = Color.SteelBlue
    Public Property My_Standard_Selection_BackColor() As Color
        Get
            Return standard_highlight_backcolor
        End Get
        Set(ByVal value As Color)
            standard_highlight_backcolor = value
        End Set
    End Property

End Class

Public Class myRenderer_ToolStrip

    Inherits System.Windows.Forms.ToolStripRenderer

#Region "GLOBAL VARIABLES"


    Private Const _cutMenuItemBack As Single = 1.2F

    'selection gradient
    'Friend myPic As New CustomObjects.myPicture
    Public ui_icon_normal As Image
    Public ui_icon_hover As Image
    Public TransEffect As Boolean = False
    Public select_font_color As Color = Color.DarkBlue
    Public select_border_color As Color = Color.Black
    Public select_top1 As Color = ColorTranslator.FromHtml("#ffffff")
    Public select_top2 As Color = ColorTranslator.FromHtml("#dceefb")
    Public select_bottom1 As Color = ColorTranslator.FromHtml("#c6e6ff")
    Public select_bottom2 As Color = ColorTranslator.FromHtml("#d6eaf9")
    Public select_has_border As Boolean = False

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

    'unselected gradient
    Public unselect_font_color As Color = Color.Black
    Public unselect_border_color As Color = ColorTranslator.FromHtml("#dadada")
    Public unselect_top1 As Color = ColorTranslator.FromHtml("#f3f4f5")
    Public unselect_top2 As Color = ColorTranslator.FromHtml("#e8e9e9")
    Public unselect_bottom1 As Color = ColorTranslator.FromHtml("#c1c1c1")
    Public unselect_bottom2 As Color = ColorTranslator.FromHtml("#f3f4f5")
    Public unselect_has_border As Boolean = False
    Public standard_highlight_backcolor As Color
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

    'background gradient
    Public dselect_font_color As Color = Color.White
    Public dselect_border_color As Color = Color.White
    Public dselect_top1 As Color = Color.White
    Public dselect_top2 As Color = ColorTranslator.FromHtml("#e8e9e9")
    Public dselect_bottom1 As Color = Color.LightGray
    Public dselect_bottom2 As Color = Color.White
    Public background_has_border As Boolean
    Public _Background_Style As BackStyle
    Private bntr_tl_lineup_corner As Color
    Private bntr_tl_corner As Color
    Private bnbr_bl_corner As Color
    Private bnbr_bl_linedown_corner As Color
    Private bntop_fill_first As Color
    Private bntop_fill_second As Color
    Private bnbottom_fill_first As Color
    Private bnbottom_fill_second As Color
    Private bntop_rl_down_rl_line_corner_within_menu As Color
    Private bnleft_right_side_corner_withing_menu As Color


    Private colorskin As Color = Color.Beige

    Private select_forecolor As Color
    Private unselected_backcolor As Color
    Private unselected_forecolor As Color
    Private _separatorMenuLight As Color = Color.Red
    Private _itemContextItemEnabledColors As GradientColor
    Private _itemDisabledColors As GradientColor
    Private _itemToolItemSelectedColors As GradientColor
    Private _backgroundColor As GradientColor
    Private arrow_down As Image
    Private arrow_down_hover As Image
    Enum BackStyle
        Standard
        VerticalGradient
    End Enum
    Enum SelectStyleType
        Standard
        Custom_Selection_Only
        Custom_Select_and_Unselect
    End Enum
    Public SelectionStyle As SelectStyleType = SelectStyleType.Standard
#End Region

    Public Sub set_arrowdown(ByVal img_normal As Bitmap, ByVal img_hover As Bitmap)
        arrow_down = img_normal
        arrow_down_hover = img_hover
    End Sub

    Public Sub assign_colors()

        'selection gradient
        If select_has_border Then
            tr_tl_lineup_corner = select_border_color
            tr_tl_corner = select_border_color
            br_bl_corner = select_border_color
            br_bl_linedown_corner = select_border_color

            top_rl_down_rl_line_corner_within_menu = Color.White
            left_right_side_corner_withing_menu = Color.White
        Else
            tr_tl_lineup_corner = select_top1
            tr_tl_corner = select_top1
            br_bl_corner = select_bottom2
            br_bl_linedown_corner = select_bottom2

            top_rl_down_rl_line_corner_within_menu = Color.White
            left_right_side_corner_withing_menu = Color.White
        End If
        top_fill_first = select_top1
        top_fill_second = select_top2
        bottom_fill_first = select_bottom1
        bottom_fill_second = select_bottom2

        'unselected gradient
        If unselect_has_border Then
            ntr_tl_lineup_corner = unselect_border_color
            ntr_tl_corner = unselect_border_color
            nbr_bl_corner = unselect_border_color
            nbr_bl_linedown_corner = unselect_border_color

            ntop_rl_down_rl_line_corner_within_menu = Color.Transparent
            nleft_right_side_corner_withing_menu = Color.Transparent
        Else
            ntr_tl_lineup_corner = unselect_top1
            ntr_tl_corner = unselect_top1
            nbr_bl_corner = unselect_bottom2
            nbr_bl_linedown_corner = unselect_bottom2

            ntop_rl_down_rl_line_corner_within_menu = Color.Transparent
            nleft_right_side_corner_withing_menu = Color.Transparent
        End If
        ntop_fill_first = unselect_top1
        ntop_fill_second = unselect_top2
        nbottom_fill_first = unselect_bottom1
        nbottom_fill_second = unselect_bottom2

        'background gradient
        If background_has_border Then
            bntr_tl_lineup_corner = dselect_border_color
            bntr_tl_corner = dselect_border_color
            bnbr_bl_corner = dselect_border_color
            bnbr_bl_linedown_corner = dselect_border_color
            bntop_rl_down_rl_line_corner_within_menu = dselect_border_color
            bnleft_right_side_corner_withing_menu = dselect_border_color
        Else
            bntr_tl_lineup_corner = dselect_top1
            bntr_tl_corner = dselect_top1
            bnbr_bl_corner = dselect_bottom2
            bnbr_bl_linedown_corner = dselect_bottom2
            bntop_rl_down_rl_line_corner_within_menu = Color.Transparent
            bnleft_right_side_corner_withing_menu = Color.Transparent
        End If

        bntop_fill_first = dselect_top1
        bntop_fill_second = dselect_top2
        bnbottom_fill_first = dselect_bottom1
        bnbottom_fill_second = dselect_bottom2


        _itemContextItemEnabledColors = New GradientColor(tr_tl_lineup_corner, tr_tl_corner, br_bl_corner, br_bl_linedown_corner, top_fill_first, top_fill_second, bottom_fill_first, bottom_fill_second, Color.FromArgb(217, 203, 150), Color.FromArgb(192, 167, 118))
        _itemDisabledColors = New GradientColor(ntr_tl_lineup_corner, ntr_tl_corner, nbr_bl_corner, nbr_bl_linedown_corner, ntop_fill_first, ntop_fill_second, nbottom_fill_first, nbottom_fill_second, ntop_rl_down_rl_line_corner_within_menu, nleft_right_side_corner_withing_menu)
        _itemToolItemSelectedColors = New GradientColor(tr_tl_lineup_corner, tr_tl_corner, br_bl_corner, br_bl_linedown_corner, top_fill_first, top_fill_second, bottom_fill_first, bottom_fill_second, top_rl_down_rl_line_corner_within_menu, left_right_side_corner_withing_menu)
        _backgroundColor = New GradientColor(bntr_tl_lineup_corner, bntr_tl_corner, bnbr_bl_corner, bnbr_bl_linedown_corner, bntop_fill_first, bntop_fill_second, bnbottom_fill_first, bnbottom_fill_second, bntop_rl_down_rl_line_corner_within_menu, bnleft_right_side_corner_withing_menu)
    End Sub

    Enum typecolor
        tr_tl_lineup_corner
        tr_tl_corner
        br_bl_corner
        br_bl_linedown_corner
        top_fill_first
        top_fill_second
        bottom_fill_first
        bottom_fill_second
        top_rl_down_rl_line_corner_within_menu
        left_right_side_corner_withing_menu
    End Enum

    Private Function get_TypeColor(ByVal type As typecolor)
        Select Case type
            Case typecolor.tr_tl_lineup_corner
                Return "tr_tl_lineup_corner"
            Case typecolor.tr_tl_corner
                Return "tr_tl_corner"
            Case typecolor.br_bl_corner
                Return "br_bl_corner"
            Case typecolor.br_bl_linedown_corner
                Return "br_bl_linedown_corner"
            Case typecolor.top_fill_first
                Return "top_fill_first"
            Case typecolor.top_fill_second
                Return "top_fill_second"
            Case typecolor.bottom_fill_first
                Return "bottom_fill_first"
            Case typecolor.bottom_fill_second
                Return "bottom_fill_second"
            Case typecolor.top_rl_down_rl_line_corner_within_menu
                Return "top_rl_down_rl_line_corner_within_menu"
            Case typecolor.left_right_side_corner_withing_menu
                Return "left_right_side_corner_withing_menu"
        End Select
        Return Nothing
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

    Protected Overrides Sub OnRenderSeparator(ByVal e As System.Windows.Forms.ToolStripSeparatorRenderEventArgs)
        Dim sep As ToolStripSeparator = e.Item
        e.Graphics.FillRectangle(Brushes.Black, 0, 4, 1, sep.Bounds.Height - 8)
    End Sub

    Protected Overrides Sub OnRenderMenuItemBackground(ByVal e As System.Windows.Forms.ToolStripItemRenderEventArgs)
        If e.Item.Selected Then
            e.Item.ForeColor = select_font_color

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

            e.Item.ForeColor = unselect_font_color
            If SelectionStyle = SelectStyleType.Standard Then
                'nothing
                e.Graphics.FillRectangle(Brushes.Transparent, e.Item.Bounds)
            ElseIf SelectionStyle = SelectStyleType.Custom_Selection_Only Then
                'nothing
                e.Graphics.FillRectangle(Brushes.Transparent, e.Item.Bounds)
            ElseIf SelectionStyle = SelectStyleType.Custom_Select_and_Unselect Then
                DrawGradientMenuItem2(e.Graphics, e.Item, _itemDisabledColors)
            End If
        End If

    End Sub

    Private Sub DrawGradientMenuItem2(ByVal g As Graphics, ByVal item As ToolStripItem, ByVal colors As GradientColor)
        Dim backRect As Rectangle = New Rectangle(-1, -2, item.Bounds.Width + 2, item.Bounds.Height + 4)
        DrawGradientItem2(g, backRect, colors)
    End Sub

    Protected Overrides Sub OnRenderDropDownButtonBackground(ByVal e As System.Windows.Forms.ToolStripItemRenderEventArgs)
        Dim button As ToolStripDropDownButton = e.Item
        If button.Selected Then
            e.Item.ForeColor = select_forecolor
            If SelectionStyle = SelectStyleType.Standard Then
                e.Graphics.FillRectangle(New SolidBrush(standard_highlight_backcolor), New Rectangle(-1, -1, e.Item.Bounds.Width + 2, e.Item.Bounds.Height + 2))
            Else
                DrawGradientMenuItem(e.Graphics, e.Item, _itemContextItemEnabledColors)
            End If
        Else
            If SelectionStyle = SelectStyleType.Custom_Selection_Only Or SelectionStyle = SelectStyleType.Standard Then
                If _Background_Style = BackStyle.VerticalGradient Then
                    fillBackgroundColor(e.Graphics, New Rectangle(-1, -1, e.Item.Bounds.Width + 2, e.Item.Bounds.Height + 2))
                Else
                    'e.Graphics.FillRectangle(New SolidBrush(standard_highlight_backcolor), e.Item.Bounds)
                End If
            Else
                If TransEffect Then
                    'do nothing
                Else
                    DrawGradientMenuItem2(e.Graphics, e.Item, _itemDisabledColors)
                End If
            End If
            e.Item.ForeColor = unselected_forecolor
        End If
    End Sub

    Protected Overrides Sub OnRenderSplitButtonBackground(ByVal e As System.Windows.Forms.ToolStripItemRenderEventArgs)
        Dim button As ToolStripSplitButton = e.Item
        If button.Selected Then
            e.Item.ForeColor = select_forecolor

            Dim perc As Integer = (e.Item.Width * 0.3)
            Dim perc2 As Integer = (e.Item.Height * 0.15)

            Dim h As Integer = e.Item.Height / 2
            Dim w As Integer = e.Item.Width * 0.8

            If SelectionStyle = SelectStyleType.Standard Then

                e.Graphics.FillRectangle(New SolidBrush(standard_highlight_backcolor), New Rectangle(-1, -1, e.Item.Bounds.Width + 2, e.Item.Bounds.Height + 2))
                e.Graphics.DrawLine(New Pen(select_font_color), e.Item.Width - perc, e.Item.Height - perc2, e.Item.Width - perc, perc2)

                e.Graphics.DrawLine(New Pen(select_font_color), (w - 2) + 1, h - 1, (w + 2) + 1, h - 1)
                e.Graphics.DrawLine(New Pen(select_font_color), (w - 1) + 1, h, (w + 1) + 1, h)
                e.Graphics.DrawLine(New Pen(select_font_color), (w) + 1, h, w + 1, h + 1)
            Else
                DrawGradientMenuItem(e.Graphics, e.Item, _itemContextItemEnabledColors)

                e.Graphics.DrawLine(New Pen(select_font_color), e.Item.Width - perc, e.Item.Height - perc2, e.Item.Width - perc, perc2)

                e.Graphics.DrawLine(New Pen(select_font_color), (w - 2) + 1, h - 1, (w + 2) + 1, h - 1)
                e.Graphics.DrawLine(New Pen(select_font_color), (w - 1) + 1, h, (w + 1) + 1, h)
                e.Graphics.DrawLine(New Pen(select_font_color), (w) + 1, h, w + 1, h + 1)
            End If
        Else

            If SelectionStyle = SelectStyleType.Custom_Selection_Only Or SelectionStyle = SelectStyleType.Standard Then
                If _Background_Style = BackStyle.VerticalGradient Then
                    fillBackgroundColor(e.Graphics, New Rectangle(-1, -1, e.Item.Bounds.Width + 2, e.Item.Bounds.Height + 2))
                Else
                    'e.Graphics.FillRectangle(New SolidBrush(standard_highlight_backcolor), New Rectangle(-1, -1, e.Item.Bounds.Width + 2, e.Item.Bounds.Height + 2))
                End If
            Else
                If TransEffect Then
                    'do nothing
                Else
                    DrawGradientMenuItem2(e.Graphics, e.Item, _itemDisabledColors)
                End If
            End If

            e.Item.ForeColor = unselected_forecolor
            Dim perc As Integer = (e.Item.Width * 0.3)
            Dim perc2 As Integer = (e.Item.Height * 0.15)
            e.Graphics.DrawLine(New Pen(unselect_font_color), e.Item.Width - perc, e.Item.Height - perc2, e.Item.Width - perc, perc2)

            Dim h As Integer = e.Item.Height / 2
            Dim w As Integer = e.Item.Width * 0.8
            e.Graphics.DrawLine(New Pen(unselect_font_color), (w - 2) + 1, h - 1, (w + 2) + 1, h - 1)
            e.Graphics.DrawLine(New Pen(unselect_font_color), (w - 1) + 1, h, (w + 1) + 1, h)
            e.Graphics.DrawLine(New Pen(unselect_font_color), (w) + 1, h, w + 1, h + 1)
        End If
        MyBase.OnRenderSplitButtonBackground(e)
    End Sub

    Protected Overrides Sub OnRenderButtonBackground(ByVal e As System.Windows.Forms.ToolStripItemRenderEventArgs)
        If TypeOf e.Item Is ToolStripButton Then
            Dim button As ToolStripButton = e.Item
            If button.Selected Then
                e.Item.ForeColor = select_forecolor
                If SelectionStyle = SelectStyleType.Standard Then
                    e.Graphics.FillRectangle(New SolidBrush(standard_highlight_backcolor), New Rectangle(-1, -1, e.Item.Bounds.Width + 2, e.Item.Bounds.Height + 2))
                Else
                    DrawGradientMenuItem(e.Graphics, e.Item, _itemContextItemEnabledColors)
                End If
            Else
                If SelectionStyle = SelectStyleType.Custom_Selection_Only Or SelectionStyle = SelectStyleType.Standard Then
                    If _Background_Style = BackStyle.VerticalGradient Then
                        fillBackgroundColor(e.Graphics, New Rectangle(-1, -1, e.Item.Bounds.Width + 2, e.Item.Bounds.Height + 2))

                    End If
                Else
                    If TransEffect Then
                        'do nothing
                    Else
                        DrawGradientMenuItem2(e.Graphics, e.Item, _itemDisabledColors)
                    End If
                End If
                e.Item.ForeColor = unselected_forecolor
            End If
        End If
    End Sub

#Region "FUNCTIONS"

    Private Sub DrawGradientMenuItem(ByVal g As Graphics, ByVal item As ToolStripItem, ByVal colors As GradientColor)
        Dim backRect As Rectangle = New Rectangle(-1, -2, item.Bounds.Width + 2, item.Bounds.Height + 4)
        DrawGradientItem(g, backRect, colors)
    End Sub

    Private Sub DrawGradientToolItem(ByVal g As Graphics, ByVal item As ToolStripItem, ByVal colors As GradientColor)
        DrawGradientItem(g, New Rectangle(Point.Empty, New Size(item.Bounds.Width + 2, item.Bounds.Height + 3)), colors)
    End Sub

    Private Sub DrawGradientItem(ByVal g As Graphics, ByVal backRect As Rectangle, ByVal colors As GradientColor)
        If ((backRect.Width > 0) And (backRect.Height > 0)) Then
            DrawGradientBackground(g, backRect, colors)
            DrawGradientBorder(g, backRect, colors)
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

    Public Sub fillBackgroundColor(ByVal e As Graphics, ByVal rect As Rectangle)
        DrawGradientBackground(e, rect, _backgroundColor)
        'If background_has_border Then
        DrawGradientBorder(e, rect, _backgroundColor)
        'End If
    End Sub

    Private Sub DrawGradientItem2(ByVal g As Graphics, ByVal backRect As Rectangle, ByVal colors As GradientColor)
        If ((backRect.Width > 0) And (backRect.Height > 0)) Then
            DrawGradientBackground(g, backRect, colors)
            If unselect_has_border Then
                DrawGradientBorder(g, backRect, colors)
            End If
        End If
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

#End Region

End Class
