Imports System.Text
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Namespace myControls

    Namespace Init

        Public Class contextMenuStripRenderer
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
            Public separatorBarColor As Color = Color.White

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

                top_fill_first = select_top1
                top_fill_second = select_top2
                bottom_fill_first = select_top1
                bottom_fill_second = select_top2


                nbottom_fill_first = unselect_bottom1
                nbottom_fill_second = unselect_bottom2
                ntop_rl_down_rl_line_corner_within_menu = unselect_border_color
                nleft_right_side_corner_withing_menu = unselect_border_color
                unselected_forecolor = unselect_font_color

                dntr_tl_lineup_corner = dselect_top1
                dntr_tl_corner = dselect_top1
                dnbr_bl_corner = dselect_bottom2
                dnbr_bl_linedown_corner = dselect_bottom2
                dntop_fill_first = dselect_top1
                dntop_fill_second = dselect_top2
                dnbottom_fill_first = dselect_bottom1
                dnbottom_fill_second = dselect_bottom2
                dntop_rl_down_rl_line_corner_within_menu = dselect_border_color
                dnleft_right_side_corner_withing_menu = dselect_border_color
                dntr_tl_lineup_corner = separatorBarColor

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
                                DrawGradientMenuItem(e.Graphics, e.Item, _itemContextItemEnabledColors)

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

            Protected Overrides Sub OnRenderArrow(ByVal e As System.Windows.Forms.ToolStripArrowRenderEventArgs)
                MyBase.OnRenderArrow(e)
                Dim startX As Integer = e.Item.Bounds.Width - 15
                Dim startY As Integer = (e.Item.Bounds.Height / 2) - 3
                Dim endX As Integer = e.Item.Bounds.Width - 15
                Dim endY As Integer = (e.Item.Bounds.Height / 2) + 3
                e.Graphics.DrawLine(Pens.White, startX, startY, endX, endY)

                startX = e.Item.Bounds.Width - 14
                startY = (e.Item.Bounds.Height / 2) - 2
                endX = e.Item.Bounds.Width - 14
                endY = (e.Item.Bounds.Height / 2) + 2
                e.Graphics.DrawLine(Pens.White, startX, startY, endX, endY)

                startX = e.Item.Bounds.Width - 13
                startY = (e.Item.Bounds.Height / 2) - 1
                endX = e.Item.Bounds.Width - 13
                endY = (e.Item.Bounds.Height / 2) + 1
                e.Graphics.DrawLine(Pens.White, startX, startY, endX, endY)

                startX = e.Item.Bounds.Width - 14
                startY = (e.Item.Bounds.Height / 2)
                endX = e.Item.Bounds.Width - 12
                endY = (e.Item.Bounds.Height / 2)
                e.Graphics.DrawLine(Pens.White, startX, startY, endX, endY)
            End Sub

            Protected Overrides Sub OnRenderDropDownButtonBackground(ByVal e As System.Windows.Forms.ToolStripItemRenderEventArgs)
                'MyBase.OnRenderDropDownButtonBackground(e)
                DrawGradientMenuItemSeparator(e.Graphics, e.Item, _itemDisabledColors)
            End Sub

            Protected Overrides Sub InitializeContentPanel(ByVal contentPanel As System.Windows.Forms.ToolStripContentPanel)
                'MyBase.InitializeContentPanel(contentPanel)
                DrawGradientMenuItemVV(contentPanel.CreateGraphics, contentPanel, _itemDisabledColors)
            End Sub

            Private Sub DrawGradientMenuItemVV(ByVal g As Graphics, ByVal contentPanel As System.Windows.Forms.ToolStripContentPanel, ByVal colors As GradientColor)
                Dim backRect As Rectangle = New Rectangle(-4, -4, contentPanel.Width, contentPanel.Height)
                DrawGradientItem2(g, backRect, colors)
            End Sub

            Protected Overrides Sub OnRenderSeparator(ByVal e As System.Windows.Forms.ToolStripSeparatorRenderEventArgs)
                'MyBase.OnRenderSeparator(e)
                DrawGradientMenuItemSeparator(e.Graphics, e.Item, _itemDisabledColors)
                Dim center As Integer = e.Item.Height / 2
                e.Graphics.DrawLine(New Pen(Color.White, 1), -5, center, e.Item.Width + 20, center)
                'e.Graphics.DrawLine(New Pen(_itemContextItemEnabledColors.FillBTop, 5), -2, 0, -2, e.Item.Height)
            End Sub

            Protected Overrides Sub OnRenderToolStripPanelBackground(ByVal e As System.Windows.Forms.ToolStripPanelRenderEventArgs)
                'MyBase.OnRenderToolStripPanelBackground(e)
                DrawGradientPanel(e.Graphics, e.ToolStripPanel, _itemDisabledColors)
            End Sub

            Protected Overrides Sub OnRenderItemBackground(ByVal e As System.Windows.Forms.ToolStripItemRenderEventArgs)
                'MyBase.OnRenderItemBackground(e)
                DrawGradientMenuItemSeparator(e.Graphics, e.Item, _itemDisabledColors)
            End Sub

            Protected Overrides Sub OnRenderToolStripContentPanelBackground(ByVal e As System.Windows.Forms.ToolStripContentPanelRenderEventArgs)
                'MyBase.OnRenderToolStripContentPanelBackground(e)
                'DrawGradientMenuItemV(e.Graphics, e.ToolStripContentPanel, _itemDisabledColors)
            End Sub

            Protected Overrides Sub OnRenderGrip(ByVal e As System.Windows.Forms.ToolStripGripRenderEventArgs)
                '  MyBase.OnRenderGrip(e)
                'DrawGradientMenuItemSeparator(e.Graphics, e.Item, _itemDisabledColors)
            End Sub

            Private Sub DrawGradientMenuItemV(ByVal g As Graphics, ByVal item As ToolStripContentPanel, ByVal colors As GradientColor)
                Dim backRect As Rectangle = New Rectangle(-4, -4, item.Bounds.Width + 5, item.Bounds.Height + 5)
                DrawGradientItem2(g, backRect, colors)
            End Sub

            Protected Overrides Sub OnRenderItemText(ByVal e As System.Windows.Forms.ToolStripItemTextRenderEventArgs)
                MyBase.OnRenderItemText(e)
                'DrawGradientMenuItemSeparator(e.Graphics, e.Item, _itemDisabledColors)
            End Sub 'TEXT

            Private Sub DrawGradientPanel(ByVal g As Graphics, ByVal item As ToolStripPanel, ByVal colors As GradientColor)
                Dim backRect As Rectangle = New Rectangle(-1, -2, item.Bounds.Width + 2, item.Bounds.Height + 3)
                DrawGradientItem(g, backRect, colors)
            End Sub

            Private Sub DrawGradientMenuItem(ByVal g As Graphics, ByVal item As ToolStripItem, ByVal colors As GradientColor)
                Dim backRect As Rectangle = New Rectangle(-1, -2, item.Bounds.Width + 2, item.Bounds.Height + 3)
                DrawGradientItem(g, backRect, colors)
            End Sub

            Private Sub DrawGradientMenuItem2(ByVal g As Graphics, ByVal item As ToolStripItem, ByVal colors As GradientColor)
                Dim backRect As Rectangle = New Rectangle(-1, -2, item.Bounds.Width + 2, item.Bounds.Height + 3)
                DrawGradientItem2(g, backRect, colors)
            End Sub

            Private Sub DrawGradientMenuItemSeparator(ByVal g As Graphics, ByVal item As ToolStripItem, ByVal colors As GradientColor)
                Dim backRect As Rectangle = New Rectangle(-4, -4, item.Bounds.Width + 5, item.Bounds.Height + 5)
                DrawGradientItem2(g, backRect, colors)
            End Sub

            Private Sub DrawGradientItem3(ByVal g As Graphics, ByVal backRect As Rectangle, ByVal colors As GradientColor)
                If ((backRect.Width > 0) And (backRect.Height > 0)) Then
                    DrawGradientBackground(g, backRect, colors)
                    If _Unselect_Has_Border Then
                        DrawGradientBorder(g, backRect, colors)
                    End If
                End If
            End Sub

            Private Sub DrawGradientToolItem(ByVal g As Graphics, ByVal item As ToolStripItem, ByVal colors As GradientColor)
                DrawGradientItem(g, New Rectangle(Point.Empty, New Size(item.Bounds.Size.Width, item.Bounds.Size.Height + 2)), colors)
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

        Public Class toolStripRenderer

            Inherits System.Windows.Forms.ToolStripRenderer

#Region "GLOBAL VARIABLES"


            Private Const _cutMenuItemBack As Single = 1.2F

            'selection gradient
            ' Friend myPic As New CustomObjects.myPicture
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
            Public hover_image As Image = Nothing
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
            Public OutColorButton As Color

            Private select_forecolor As Color
            Private unselected_backcolor As Color
            Private unselected_forecolor As Color
            Private _separatorMenuLight As Color = Color.Red
            Private _itemContextItemEnabledColors As GradientColor
            Private _itemDisabledColors As GradientColor
            Private _itemToolItemSelectedColors As GradientColor
            Private _backgroundColor As GradientColor
            Private _separatorMenuLights As GradientColor
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
                    bntr_tl_lineup_corner = OutColorButton
                    bntr_tl_corner = OutColorButton
                    bnbr_bl_corner = OutColorButton
                    bnbr_bl_linedown_corner = OutColorButton
                    bntop_rl_down_rl_line_corner_within_menu = OutColorButton
                    bnleft_right_side_corner_withing_menu = OutColorButton
                Else
                    bntr_tl_lineup_corner = OutColorButton
                    bntr_tl_corner = OutColorButton
                    bnbr_bl_corner = OutColorButton
                    bnbr_bl_linedown_corner = OutColorButton
                    bntop_rl_down_rl_line_corner_within_menu = OutColorButton
                    bnleft_right_side_corner_withing_menu = OutColorButton
                End If

                'bntop_fill_first = dselect_top1
                'bntop_fill_second = dselect_top2
                'bnbottom_fill_first = dselect_bottom1
                'bnbottom_fill_second = dselect_bottom2


                _itemContextItemEnabledColors = New GradientColor(tr_tl_lineup_corner, tr_tl_corner, br_bl_corner, br_bl_linedown_corner, top_fill_first, top_fill_second, bottom_fill_first, bottom_fill_second, Color.FromArgb(217, 203, 150), Color.FromArgb(192, 167, 118))
                _itemDisabledColors = New GradientColor(ntr_tl_lineup_corner, ntr_tl_corner, nbr_bl_corner, nbr_bl_linedown_corner, ntop_fill_first, ntop_fill_second, nbottom_fill_first, nbottom_fill_second, ntop_rl_down_rl_line_corner_within_menu, nleft_right_side_corner_withing_menu)
                _itemToolItemSelectedColors = New GradientColor(tr_tl_lineup_corner, tr_tl_corner, br_bl_corner, br_bl_linedown_corner, top_fill_first, top_fill_second, bottom_fill_first, bottom_fill_second, top_rl_down_rl_line_corner_within_menu, left_right_side_corner_withing_menu)
                _backgroundColor = New GradientColor(bntr_tl_lineup_corner, bntr_tl_corner, bnbr_bl_corner, bnbr_bl_linedown_corner, bntop_fill_first, bntop_fill_second, bnbottom_fill_first, bnbottom_fill_second, bntop_rl_down_rl_line_corner_within_menu, bnleft_right_side_corner_withing_menu)
                _separatorMenuLights = New GradientColor(Color.White, Color.White, Color.White, Color.White, Color.White, Color.White, Color.White, Color.White, Color.White, Color.White)

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
                                ' e.Graphics.FillRectangle(New SolidBrush(standard_highlight_backcolor), e.ToolStrip.Bounds)
                            ElseIf TypeOf e.ToolStrip Is ToolStripDropDownMenu Then
                                Dim backRect As Rectangle = New Rectangle(2, 0, e.Item.Bounds.Width - 3, e.Item.Bounds.Height)
                                'e.Graphics.FillRectangle(New SolidBrush(standard_highlight_backcolor), backRect)
                            End If
                        End If
                    Else
                        Dim mousePos As Point = e.ToolStrip.PointToClient(Control.MousePosition)
                        If (Not e.Item.Bounds.Contains(mousePos)) Then
                            If TypeOf (e.ToolStrip) Is MenuStrip Then
                                'DrawGradientToolItem(e.Graphics, e.Item, _itemDisabledColors)
                            Else
                                'DrawGradientMenuItem(e.Graphics, e.Item, _itemToolItemSelectedColors)
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
                        If TypeOf e.Item Is ToolStripButton Then
                            'MsgBox("as")
                        End If
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


                        Dim startX As Integer = e.Item.Bounds.Width - 15
                        Dim startY As Integer = (e.Item.Bounds.Height / 2) - 3
                        Dim endX As Integer = e.Item.Bounds.Width - 15
                        Dim endY As Integer = (e.Item.Bounds.Height / 2) + 3
                        e.Graphics.DrawLine(Pens.White, startX, startY, endX, endY)

                        startX = e.Item.Bounds.Width - 14
                        startY = (e.Item.Bounds.Height / 2) - 2
                        endX = e.Item.Bounds.Width - 14
                        endY = (e.Item.Bounds.Height / 2) + 2
                        e.Graphics.DrawLine(Pens.White, startX, startY, endX, endY)

                        startX = e.Item.Bounds.Width - 13
                        startY = (e.Item.Bounds.Height / 2) - 1
                        endX = e.Item.Bounds.Width - 13
                        endY = (e.Item.Bounds.Height / 2) + 1
                        e.Graphics.DrawLine(Pens.White, startX, startY, endX, endY)

                        startX = e.Item.Bounds.Width - 14
                        startY = (e.Item.Bounds.Height / 2)
                        endX = e.Item.Bounds.Width - 12
                        endY = (e.Item.Bounds.Height / 2)
                        e.Graphics.DrawLine(Pens.White, startX, startY, endX, endY)
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


                            DrawGradientMenuItem2(e.Graphics, e.Item, _backgroundColor)




                            Dim startX As Integer = e.Item.Bounds.Width - 15
                            Dim startY As Integer = (e.Item.Bounds.Height / 2) - 3
                            Dim endX As Integer = e.Item.Bounds.Width - 15
                            Dim endY As Integer = (e.Item.Bounds.Height / 2) + 3
                            e.Graphics.DrawLine(Pens.White, startX, startY, endX, endY)

                            startX = e.Item.Bounds.Width - 14
                            startY = (e.Item.Bounds.Height / 2) - 2
                            endX = e.Item.Bounds.Width - 14
                            endY = (e.Item.Bounds.Height / 2) + 2
                            e.Graphics.DrawLine(Pens.White, startX, startY, endX, endY)

                            startX = e.Item.Bounds.Width - 13
                            startY = (e.Item.Bounds.Height / 2) - 1
                            endX = e.Item.Bounds.Width - 13
                            endY = (e.Item.Bounds.Height / 2) + 1
                            e.Graphics.DrawLine(Pens.White, startX, startY, endX, endY)

                            startX = e.Item.Bounds.Width - 14
                            startY = (e.Item.Bounds.Height / 2)
                            endX = e.Item.Bounds.Width - 12
                            endY = (e.Item.Bounds.Height / 2)
                            e.Graphics.DrawLine(Pens.White, startX, startY, endX, endY)








                        End If
                    End If
                    e.Item.ForeColor = unselected_forecolor
                End If
            End Sub


            Private Sub SplitButtonDraw(ByVal g As Graphics, ByVal item As ToolStripItem, ByVal colors As GradientColor, ByVal width As Integer)
                Dim backRect As Rectangle = New Rectangle(-1, -2, width, item.Bounds.Height + 4)
                DrawGradientItem(g, backRect, colors)
            End Sub

            Protected Overrides Sub OnRenderSplitButtonBackground(ByVal e As System.Windows.Forms.ToolStripItemRenderEventArgs)
                Dim button As ToolStripSplitButton = e.Item
                If button.Selected Then
                    e.Item.ForeColor = select_forecolor

                    Dim perc As Integer = (e.Item.Width * 0.3)
                    Dim perc2 As Integer = (e.Item.Height * 0.15)

                    Dim h As Integer = e.Item.Height / 2
                    Dim w As Integer = e.Item.Width - 7

                    If SelectionStyle = SelectStyleType.Standard Then

                        e.Graphics.FillRectangle(New SolidBrush(standard_highlight_backcolor), New Rectangle(-1, -1, e.Item.Bounds.Width + 2, e.Item.Bounds.Height + 2))

                        e.Graphics.DrawLine(New Pen(select_font_color), e.Item.Width - 10, 0, e.Item.Width - 10, e.Item.Height)

                        e.Graphics.DrawLine(New Pen(select_font_color), (w - 2) + 1, h - 1, (w + 2) + 1, h - 1)
                        e.Graphics.DrawLine(New Pen(select_font_color), (w - 1) + 1, h, (w + 1) + 1, h)
                        e.Graphics.DrawLine(New Pen(select_font_color), (w) + 1, h, w + 1, h + 1)
                    Else
                        SplitButtonDraw(e.Graphics, e.Item, _itemContextItemEnabledColors, button.Width + 5)

                        e.Graphics.DrawLine(New Pen(select_font_color), e.Item.Width - 10, 0, e.Item.Width - 10, e.Item.Height)

                        e.Graphics.DrawLine(New Pen(select_font_color), (w - 2) + 1, h - 1, (w + 2) + 1, h - 1)
                        e.Graphics.DrawLine(New Pen(select_font_color), (w - 1) + 1, h, (w + 1) + 1, h)
                        e.Graphics.DrawLine(New Pen(select_font_color), (w) + 1, h, w + 1, h + 1)
                    End If


                    If button.Pressed Then
                        DrawGradientMenuItem(e.Graphics, e.Item, _itemContextItemEnabledColors)
                        'button.Padding = New Padding(1, 0, 0, 0)
                    Else
                        'button.Padding = New Padding(0, 0, 0, 0)
                    End If
                ElseIf button.Pressed Then
                    

                Else
                    If button.HasDropDownItems Then

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
                                DrawGradientMenuItem2(e.Graphics, e.Item, _backgroundColor)
                            End If
                        End If

                        e.Item.ForeColor = unselected_forecolor
                        Dim perc As Integer = (e.Item.Width * 0.3)
                        Dim perc2 As Integer = (e.Item.Height * 0.15)
                        'e.Graphics.DrawLine(New Pen(unselect_font_color), e.Item.Width - 10, 0, e.Item.Width - 10, e.Item.Height)

                        Dim h As Integer = e.Item.Height / 2
                        Dim w As Integer = e.Item.Width - 7
                        e.Graphics.DrawLine(New Pen(unselect_font_color), (w - 2) + 1, h - 1, (w + 2) + 1, h - 1)
                        e.Graphics.DrawLine(New Pen(unselect_font_color), (w - 1) + 1, h, (w + 1) + 1, h)
                        e.Graphics.DrawLine(New Pen(unselect_font_color), (w) + 1, h, w + 1, h + 1)
                    End If
                  
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
                                DrawGradientMenuItem2(e.Graphics, e.Item, _backgroundColor)
                            End If
                        End If
                        e.Item.ForeColor = unselected_forecolor
                    End If
                End If
            End Sub

            Protected Overrides Sub OnRenderSeparator(ByVal e As System.Windows.Forms.ToolStripSeparatorRenderEventArgs)
                'MyBase.OnRenderSeparator(e)
                DrawGradientMenuItemSeparator(e.Graphics, e.Item, _itemDisabledColors)
                Dim center As Integer = e.Item.Height / 2
                e.Graphics.DrawLine(New Pen(Color.White, 1), -5, center, e.Item.Width + 20, center)
                'e.Graphics.DrawLine(New Pen(_itemContextItemEnabledColors.FillBTop, 5), -2, 0, -2, e.Item.Height)
            End Sub

            Private Sub DrawGradientMenuItemSeparator(ByVal g As Graphics, ByVal item As ToolStripItem, ByVal colors As GradientColor)
                Dim backRect As Rectangle = New Rectangle(-4, -4, item.Bounds.Width + 5, item.Bounds.Height + 5)
                DrawGradientItem2(g, backRect, colors)
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

    End Namespace

    Namespace Share

        ''' <summary>
        ''' This class is used to control a specific object in the system. You can use this without setting a variable name
        ''' </summary>
        ''' <remarks></remarks>
        Public Class Objects

            Private Shared Sub getMainObject(ByRef colObjects As Collection, ByRef forms As Form)
                With colObjects
                    .Clear()
                    Dim cControl As Control
                    For Each cControl In forms.Controls
                        If (TypeOf cControl Is GroupBox) Then
                            .Add(CType(cControl, GroupBox))
                            getSubMainObject(colObjects, cControl)
                        ElseIf TypeOf cControl Is Panel Then
                            .Add(CType(cControl, Panel))
                            getSubMainObject(colObjects, cControl)
                        ElseIf TypeOf cControl Is Windows.Forms.TabControl Then
                            .Add(CType(cControl, Windows.Forms.TabControl))
                            getSubMainObject(colObjects, cControl)
                        ElseIf TypeOf cControl Is CheckBox Then
                            .Add(CType(cControl, CheckBox))
                        ElseIf (TypeOf cControl Is SplitContainer) Then
                            .Add(CType(cControl, SplitContainer))
                            getSubMainObject(colObjects, cControl)
                        ElseIf (TypeOf cControl Is TableLayoutPanel) Then
                            .Add(CType(cControl, TableLayoutPanel))
                            getSubMainObject(colObjects, cControl)
                        ElseIf TypeOf cControl Is Infragistics.Win.UltraWinEditors.UltraDateTimeEditor Then
                            .Add(CType(cControl, Infragistics.Win.UltraWinEditors.UltraDateTimeEditor))
                        ElseIf (TypeOf cControl Is Infragistics.Win.UltraWinTabControl.UltraTabControl) Then
                            .Add(CType(cControl, Infragistics.Win.UltraWinTabControl.UltraTabControl))
                            getSubMainObject(colObjects, cControl)
                        ElseIf (TypeOf cControl Is TabControl) Then
                            .Add(CType(cControl, TabControl))
                            getSubMainObject(colObjects, cControl)
                        Else
                            .Add(cControl)
                        End If
                    Next cControl
                    .Add(forms)
                End With
            End Sub

            Private Shared Sub getSubMainObject(ByRef colObjects As Collection, ByRef listOjbect As Object)
                Dim cControl As Control
                With colObjects
                    For i As Integer = (listOjbect.Controls.Count - 1) To 0 Step -1
                        cControl = listOjbect.Controls(i)
                        If (TypeOf cControl Is GroupBox) Then
                            .Add(CType(cControl, GroupBox))
                            getSubMainObject(colObjects, cControl)
                        ElseIf (TypeOf cControl Is Infragistics.Win.UltraWinTabControl.UltraTabControl) Then
                            .Add(CType(cControl, Infragistics.Win.UltraWinTabControl.UltraTabControl))
                            getSubMainObject(colObjects, cControl)
                        ElseIf TypeOf cControl Is Infragistics.Win.UltraWinTabControl.UltraTabPageControl Then
                            .Add(CType(cControl, Infragistics.Win.UltraWinTabControl.UltraTabPageControl))
                            getSubMainObject(colObjects, cControl)
                        ElseIf TypeOf cControl Is Windows.Forms.TabControl Then
                            .Add(CType(cControl, Windows.Forms.TabControl))
                            getSubMainObject(colObjects, cControl)
                        ElseIf TypeOf cControl Is Windows.Forms.TabPage Then
                            .Add(CType(cControl, Windows.Forms.TabPage))
                            getSubMainObject(colObjects, cControl)
                        ElseIf TypeOf cControl Is Panel Then
                            .Add(CType(cControl, Panel))
                            getSubMainObject(colObjects, cControl)
                        ElseIf TypeOf cControl Is CheckBox Then
                            .Add(CType(cControl, CheckBox))
                        ElseIf (TypeOf cControl Is SplitContainer) Then
                            .Add(CType(cControl, SplitContainer))
                            getSubMainObject(colObjects, cControl)
                        ElseIf (TypeOf cControl Is TableLayoutPanel) Then
                            .Add(CType(cControl, TableLayoutPanel))
                            getSubMainObject(colObjects, cControl)
                        ElseIf (TypeOf cControl Is Infragistics.Win.UltraWinTabControl.UltraTabPageControl) Then
                            .Add(CType(cControl, Infragistics.Win.UltraWinTabControl.UltraTabPageControl))
                            getSubMainObject(colObjects, cControl)
                        ElseIf (TypeOf cControl Is TabPage) Then
                            .Add(CType(cControl, TabPage))
                            getSubMainObject(colObjects, cControl)
                        ElseIf TypeOf cControl Is StatusStrip Then
                            .Add(cControl)
                        Else
                            .Add(cControl)
                        End If
                    Next i
                End With
            End Sub

            Private Shared Function getObjectByName_collectionType(ByVal colObject As Collection, ByVal searchFilter As String) As Object
                For Each obj As Object In colObject
                    If obj.name = searchFilter Then
                        Return obj
                    End If
                Next
                Return Nothing
            End Function

            ''' <summary>
            ''' It gathers all objects which are found in the form and will be stored in the collection
            ''' </summary>
            ''' <param name="form">Set the form to be used as reference</param>
            ''' <returns>Get all objects within the form specified</returns>
            ''' <remarks></remarks>
            Public Shared Function getAllObject(ByVal form As Form) As Collection
                Dim colObjects As New Collection
                getMainObject(colObjects, form)
                Return colObjects
            End Function

            ''' <summary>
            ''' It searches the selected object for the purpose of assigning its properties
            ''' </summary>
            ''' <param name="form">Set the form to be used as reference</param>
            ''' <param name="searchFilter">Specify the name of the object you want to search</param>
            ''' <returns>Get the selected object based on the search criteria</returns>
            ''' <remarks></remarks>
            Public Shared Function getObjectName(ByVal form As Form, ByVal searchFilter As String) As Object
                Dim colObject As Collection = getAllObject(form)
                Return getObjectByName_collectionType(colObject, searchFilter)
            End Function

        End Class

        Namespace Forms

            ''' <summary>
            ''' This class is not intented to be used by other purposes. This is a reserved to create and simulate the windows 8 platform
            ''' </summary>
            ''' <remarks></remarks>
            Public Class TitleBar


                ''' <summary>
                ''' It helps to create and design a title bar which is similar to the windows 8 platform regardless of the OS version it can still simulate the windows 8 version
                ''' </summary>
                ''' <param name="form">
                ''' Set the form as reference upon handling the creation of the object</param>
                ''' <param name="runCode">It needs an authentication to be able to use this function</param>
                ''' <remarks></remarks>
                Public Shared Sub createTitleBar(ByRef form As Form, ByVal userName As String, Optional ByVal runCode As String = "")

                    Dim getThemes As myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue = myDocument.Share.XMLDesigner.ThemesConfig.readThemes(userName)

                    If runCode = "masterkey" Then

                        Dim imgIcon As New PictureBox
                        Dim lblTitle As New Label
                        Dim imgClose As New PictureBox
                        Dim imgMaximize As New PictureBox
                        Dim imgMinimize As New PictureBox
                        Dim pnlHeader As New Panel

                        form.FormBorderStyle = FormBorderStyle.None

                        pnlHeader.Name = "pnlHeader"
                        pnlHeader.Height = 24
                        pnlHeader.BackColor = myColor.Share.Converter.StringToColor.getHTMLColor(getThemes.form_borderColor)
                        pnlHeader.Dock = DockStyle.Top

                        myEvents.Share.TitleBar.Resize.addEvent(pnlHeader, form, "masterkey")

                        Dim obj As Object = myControls.Share.Objects.getObjectName(form, "pnlContent")
                        If Not obj Is Nothing Then
                            CType(obj, Panel).BackColor = myColor.Share.Converter.StringToColor.getHTMLColor(getThemes.form_backColor)
                        End If

                        form.Padding = New Padding(5, 0, 5, 5)
                        form.BackColor = pnlHeader.BackColor

                        With pnlHeader

                            With lblTitle
                                .Text = form.Text
                                .Dock = DockStyle.Fill
                                .Padding = New Padding(0, 5, 0, 0)
                                myEvents.Share.TitleBar.Drag.addEvent(lblTitle, form, imgMaximize, "masterkey")
                            End With
                            .Controls.Add(lblTitle)

                            With imgIcon
                                .Width = 24
                                .Dock = DockStyle.Left
                                .Image = myImage.Share.Converter.IconToBitmap(form.Icon)
                                .SizeMode = PictureBoxSizeMode.StretchImage
                                .Padding = New Padding(0, 3, 6, 3)

                                If form.ShowIcon = False Then .Visible = False
                                myEvents.Share.TitleBar.Drag.addEvent(imgIcon, form, imgMaximize, "masterkey")
                            End With
                            .Controls.Add(imgIcon)

                            With imgMinimize
                                .Name = "imgMinimize"
                                .Width = 24
                                .BackColor = Color.Transparent
                                .Dock = DockStyle.Right
                                .SizeMode = PictureBoxSizeMode.CenterImage
                                .Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.minimize, , "masterkey")
                                .Margin = New Padding(2, 2, 2, 2)
                                If form.MinimizeBox = False Then
                                    .Visible = False
                                End If
                            End With
                            .Controls.Add(imgMinimize)

                            Dim g As Graphics = imgMinimize.CreateGraphics
                            g.DrawLine(New Pen(Color.Black, 3), 0, 5, 10, 5)
                            g.DrawEllipse(Pens.Black, New Rectangle(0, 0, 10, 10))

                            With imgMaximize
                                .Name = "imgMaximize"
                                .Width = 24
                                .BackColor = Color.Transparent
                                .Dock = DockStyle.Right
                                .SizeMode = PictureBoxSizeMode.CenterImage
                                .Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.maximize, , "masterkey")
                                If form.MaximizeBox = False Then
                                    .Visible = False
                                End If
                            End With
                            .Controls.Add(imgMaximize)

                            With imgClose
                                .Name = "imgClose"
                                .Width = 48
                                .BackColor = myColor.Share.Converter.StringToColor.getHTMLColor("C75050")
                                .Dock = DockStyle.Right
                                .SizeMode = PictureBoxSizeMode.CenterImage
                                .Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.close, , "masterkey")
                            End With
                            .Controls.Add(imgClose)

                            myEvents.Share.TitleBar.ClickTitleButton.addEvent(form, imgIcon, imgMinimize, imgMaximize, imgClose, userName, "masterkey")

                            .Padding = New Padding(0, 0, 0, 2)

                        End With

                        If Not myValidation.Share.Controls.Panels.checkNameExist(form, "pnlHeader") Then
                            form.Controls.Add(pnlHeader)
                        End If


                    Else
                        activationRequired("TitleBar.CreateTitleBar")
                    End If
                End Sub

            End Class

            ''' <summary>
            ''' This class handles the show form within the parent MDI container
            ''' </summary>
            ''' <remarks></remarks>
            Public Class childForm

                ''' <summary>
                ''' It loads the child form over the parent form
                ''' </summary>
                ''' <param name="parentForm">Set the Parent form as reference for the child form</param>
                ''' <param name="childForm">Set the child form</param>
                ''' <returns>Use for checking purpose</returns>
                ''' <remarks></remarks>
                Public Shared Function load(ByVal parentForm As Form, ByRef childForm As Form) As Boolean
                    'this procedure loads a form based on its name. it activates the form if existing already
                    parentForm.Cursor = Cursors.WaitCursor
                    Dim NwObjForm As Form
                    If Not myValidation.Share.Controls.Forms.checkChildForm(parentForm, childForm.Name) Then
                        childForm.MdiParent = parentForm
                        childForm.Show()
                        parentForm.Cursor = Cursors.Arrow
                        Return True
                    Else
                        childForm.Dispose()
                        NwObjForm = myValidation.Share.Controls.Forms.getMDIChildForm(parentForm, parentForm.Name)
                        NwObjForm.WindowState = FormWindowState.Normal
                        NwObjForm.Activate()
                        parentForm.Cursor = Cursors.Arrow
                        Return False
                    End If
                End Function

                ''' <summary>
                ''' It loads the sub child over the child form for the purpose of maintaining the sub child and still within the parent MDI container 
                ''' </summary>
                ''' <param name="childForm">Set the child form as reference for the sub child form</param>
                ''' <param name="subChildForm">Set the sub child form</param>
                ''' <returns>Use for checking purpose</returns>
                ''' <remarks></remarks>
                Public Shared Function subLoad(ByVal childForm As Form, ByRef subChildForm As Form)
                    'parent_form.Cursor = Cursors.WaitCursor
                    Dim NwObjForm As Form
                    'objForm.Cursor = Cursors.WaitCursor
                    If childForm.IsMdiChild Then
                        If Not myValidation.Share.Controls.Forms.checkChildForm(childForm, subChildForm.Name) Then
                            subChildForm.MdiParent = childForm.MdiParent
                            subChildForm.Show()
                            subChildForm.Cursor = Cursors.Default
                            childForm.Cursor = Cursors.Default
                            Return True
                        Else
                            subChildForm.Dispose()
                            NwObjForm = myValidation.Share.Controls.Forms.getMDIChildForm(childForm, subChildForm.Name)
                            NwObjForm.WindowState = FormWindowState.Normal
                            NwObjForm.Activate()
                            childForm.Cursor = Cursors.Default
                            Return False
                        End If
                    Else
                        subChildForm.ShowInTaskbar = False
                        subChildForm.ShowDialog()
                        Return True
                    End If
                End Function

                ''' <summary>
                ''' It loads the child form and hides the icon so that it will not detect by the user that the form is separated from the parent form MDI container
                ''' </summary>
                ''' <param name="ChildForm">Set the child form</param>
                ''' <remarks></remarks>
                Public Shared Sub loadModalForm(ByRef ChildForm As Form)
                    If ChildForm.IsMdiChild Then
                        ChildForm.ShowInTaskbar = False
                        ChildForm.ShowDialog()
                    End If
                End Sub

            End Class

        End Namespace

        Namespace Datagridviews

            Public Class rowIndexNumber
                Public Shared Sub add(ByRef dgv As DataGridView)
                    With dgv
                        AddHandler .RowPostPaint, AddressOf RowPostPaint
                    End With
                End Sub

                Private Shared Sub RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs)
                    If sender Is Nothing OrElse e Is Nothing Then
                        Return
                    End If

                    Using b As SolidBrush = New SolidBrush(sender.RowHeadersDefaultCellStyle.ForeColor)
                        e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), _
                                              sender.DefaultCellStyle.Font, _
                                               b, _
                                               e.RowBounds.Location.X + 15, _
                                               e.RowBounds.Location.Y + 4)
                    End Using
                End Sub

            End Class

        End Namespace

    End Namespace

    Namespace Init

        ''' <summary>
        ''' This class is used to control a specific object in the system. You must declare as variable so that you can use this class method
        ''' </summary>
        ''' <remarks></remarks>
        Public Class Objects

            Private colObjects As New Collection

            Private Sub getMainObject(ByRef colObjects As Collection, ByRef forms As Form)
                With colObjects
                    .Clear()
                    Dim cControl As Control
                    For Each cControl In forms.Controls
                        If (TypeOf cControl Is GroupBox) Then
                            .Add(CType(cControl, GroupBox))
                            getSubMainObject(colObjects, cControl)
                        ElseIf TypeOf cControl Is Panel Then
                            .Add(CType(cControl, Panel))
                            getSubMainObject(colObjects, cControl)
                        ElseIf TypeOf cControl Is CheckBox Then
                            .Add(CType(cControl, CheckBox))
                        ElseIf (TypeOf cControl Is SplitContainer) Then
                            .Add(CType(cControl, SplitContainer))
                            getSubMainObject(colObjects, cControl)
                        ElseIf (TypeOf cControl Is TableLayoutPanel) Then
                            .Add(CType(cControl, TableLayoutPanel))
                            getSubMainObject(colObjects, cControl)
                        ElseIf TypeOf cControl Is Infragistics.Win.UltraWinEditors.UltraDateTimeEditor Then
                            .Add(CType(cControl, Infragistics.Win.UltraWinEditors.UltraDateTimeEditor))
                        ElseIf (TypeOf cControl Is Infragistics.Win.UltraWinTabControl.UltraTabControl) Then
                            .Add(CType(cControl, Infragistics.Win.UltraWinTabControl.UltraTabControl))
                            getSubMainObject(colObjects, cControl)
                        ElseIf (TypeOf cControl Is TabControl) Then
                            .Add(CType(cControl, TabControl))
                            getSubMainObject(colObjects, cControl)
                        Else
                            .Add(cControl)
                        End If
                    Next cControl
                    .Add(forms)
                End With
            End Sub

            Private Sub getSubMainObject(ByRef colObjects As Collection, ByRef listOjbect As Object)
                Dim cControl As Control
                With colObjects
                    For i As Integer = (listOjbect.Controls.Count - 1) To 0 Step -1
                        cControl = listOjbect.Controls(i)
                        If (TypeOf cControl Is GroupBox) Then
                            .Add(CType(cControl, GroupBox))
                            getSubMainObject(colObjects, cControl)
                        ElseIf (TypeOf cControl Is Infragistics.Win.UltraWinTabControl.UltraTabControl) Then
                            .Add(CType(cControl, Infragistics.Win.UltraWinTabControl.UltraTabControl))
                            getSubMainObject(colObjects, cControl)
                        ElseIf TypeOf cControl Is Infragistics.Win.UltraWinTabControl.UltraTabPageControl Then
                            .Add(CType(cControl, Infragistics.Win.UltraWinTabControl.UltraTabPageControl))
                            getSubMainObject(colObjects, cControl)
                        ElseIf TypeOf cControl Is Panel Then
                            .Add(CType(cControl, Panel))
                            getSubMainObject(colObjects, cControl)
                        ElseIf TypeOf cControl Is CheckBox Then
                            .Add(CType(cControl, CheckBox))
                        ElseIf (TypeOf cControl Is SplitContainer) Then
                            .Add(CType(cControl, SplitContainer))
                            getSubMainObject(colObjects, cControl)
                        ElseIf (TypeOf cControl Is TableLayoutPanel) Then
                            .Add(CType(cControl, TableLayoutPanel))
                            getSubMainObject(colObjects, cControl)
                        ElseIf (TypeOf cControl Is Infragistics.Win.UltraWinTabControl.UltraTabPageControl) Then
                            .Add(CType(cControl, Infragistics.Win.UltraWinTabControl.UltraTabPageControl))
                            getSubMainObject(colObjects, cControl)
                        ElseIf (TypeOf cControl Is TabPage) Then
                            .Add(CType(cControl, TabPage))
                            getSubMainObject(colObjects, cControl)
                        ElseIf TypeOf cControl Is StatusStrip Then
                            .Add(cControl)
                        Else
                            .Add(cControl)
                        End If
                    Next i
                End With
            End Sub

            Private Function getObjectByName_collectionType(ByVal colObject As Collection, ByVal searchFilter As String) As Object
                For Each obj As Object In colObject
                    If obj.name = searchFilter Then
                        Return obj
                    End If
                Next
                Return Nothing
            End Function

            ''' <summary>
            ''' It gathers all objects which are found in the form and will be stored in the collection
            ''' </summary>
            ''' <param name="form">Set the form to be used as reference</param>
            ''' <remarks></remarks>
            Public Sub getAllObject(ByVal form As Form)
                getMainObject(colObjects, form)
            End Sub

            ''' <summary>
            ''' It searches the selected object for the purpose of assigning its properties
            ''' </summary>
            ''' <param name="searchFilter">Specify the name of the object you want to search</param>
            ''' <returns>Get the selected object based on the search criteria</returns>
            ''' <remarks></remarks>
            Public Function getObjectName(ByVal searchFilter As String) As Object
                Return getObjectByName_collectionType(colObjects, searchFilter)
            End Function

        End Class

        Namespace DataTables

            ''' <summary>
            ''' This class handles the design of the datatable columns and rows. You can create your own datatables without doing much code
            ''' </summary>
            ''' <remarks></remarks>
            Public Class DataTableDesigner

                Private Shared myOwnTable As New DataTable

                ''' <summary>
                ''' List of datacolumn type in the column
                ''' </summary>
                ''' <remarks></remarks>
                Enum FieldType
                    Strings
                    Images
                    Integers
                    Decimals
                    Blobs
                End Enum

                Private Sub setField(ByVal field_type As FieldType)
                    Select Case field_type
                        Case FieldType.Strings
                            myOwnTable.Columns.Add("Name_Employee", System.Type.GetType("System.String"))
                    End Select
                End Sub

                ''' <summary>
                ''' Use to create new table and specify the respective name of the datatable
                ''' </summary>
                ''' <param name="name">Set the name of the datatable</param>
                ''' <remarks></remarks>
                Public Sub newTable(ByVal name As String)
                    myOwnTable = New DataTable
                    myOwnTable.TableName = name
                End Sub 'CREATE NEW TABLE

                ''' <summary>
                ''' If there is table already exist, you can represent the datatable to be used as a designer of this class
                ''' </summary>
                ''' <param name="datatable">Set the datatable as reference to this class</param>
                ''' <param name="tablename">Set the name of the datatable</param>
                ''' <remarks></remarks>
                Public Sub refTable(ByRef datatable As DataTable, Optional ByVal tablename As String = "")
                    If Not datatable Is Nothing Then
                        myOwnTable = New DataTable
                        myOwnTable = datatable
                        If tablename <> "" Then
                            myOwnTable.TableName = tablename
                        End If
                    Else
                        MsgBox("There is no datatable set. Data table creation failed. Your By reference is nothing please try to fill it.")
                    End If
                End Sub 'REFERENCE TABLE

                ''' <summary>
                ''' You can add your own column field type
                ''' </summary>
                ''' <param name="name">Set the column name</param>
                ''' <param name="field_type">Specify what type of field you want to inherit from your column</param>
                ''' <remarks></remarks>
                Public Sub addColumnField(ByVal name As String, Optional ByVal field_type As FieldType = FieldType.Strings)
                    Select Case field_type
                        Case FieldType.Strings
                            myOwnTable.Columns.Add(name, GetType(String))
                        Case FieldType.Images
                            myOwnTable.Columns.Add(name, GetType(Image))
                        Case FieldType.Decimals
                            myOwnTable.Columns.Add(name, GetType(Decimal))
                        Case FieldType.Integers
                            myOwnTable.Columns.Add(name, GetType(Integer))
                        Case FieldType.Blobs
                            myOwnTable.Columns.Add(name, GetType(Byte()))
                    End Select
                End Sub 'ADD COLUMN FIELD by REFERENCE MODE

                ''' <summary>
                ''' You can add your own column filed and you must specify your own column type field
                ''' </summary>
                ''' <param name="name">Set the column name</param>
                ''' <param name="field_type">Set the field type of the column</param>
                ''' <remarks></remarks>
                Public Sub addColumnField_StringStyle(ByVal name As String, Optional ByVal field_type As String = "")
                    Select Case Trim(field_type).ToLower
                        Case "", "string", "language"
                            myOwnTable.Columns.Add(name, GetType(String))
                        Case "integer", "number", "positiveinteger"
                            myOwnTable.Columns.Add(name, GetType(Integer))
                        Case "date"
                            myOwnTable.Columns.Add(name, GetType(Date))
                        Case "boolean"
                            myOwnTable.Columns.Add(name, GetType(Boolean))
                        Case "base64binary"
                            myOwnTable.Columns.Add(name, GetType(Base64FormattingOptions))
                        Case Else
                            myOwnTable.Columns.Add(name, GetType(String))
                    End Select
                End Sub 'ADD COLUMN FIELD STRING STYLE

                ''' <summary>
                ''' It gets the designed datatable once you have done of adding a column field in your table
                ''' </summary>
                ''' <returns>Get the designed Datatable</returns>
                ''' <remarks></remarks>
                Public Function getTable() As DataTable
                    Return myOwnTable
                End Function 'RETURN TABLE

            End Class

        End Namespace

    End Namespace



End Namespace


