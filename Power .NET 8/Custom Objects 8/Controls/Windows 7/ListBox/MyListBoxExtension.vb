Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.Globalization
Imports System.Reflection
Imports System.ComponentModel.Design.Serialization
Public Class MyListBoxExtension

    Inherits listBox

#Region "BACKCOLOR EVENT"
    Private pen As Pen = New Pen(bordercolor, penWidth)
    Private penWidth As Double = 0.5F
    Private bordercolor As Color = Color.SteelBlue

    Public Property My_Border_Color() As Color
        Get
            Return bordercolor
        End Get
        Set(ByVal value As Color)
            bordercolor = value
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
    Enum BorderEvent
        Normal
        Hover
    End Enum
    Private Sub DrawBorder(Optional ByVal type As BorderEvent = BorderEvent.Normal)
        If Not MyBase.Parent Is Nothing Then
            Dim g As Graphics = MyBase.Parent.CreateGraphics
            Select Case type
                Case BorderEvent.Normal
                    pen = New Pen(MyBase.Parent.BackColor, penWidth)
                    g.DrawRectangle(pen, New Rectangle(Me.Location.X - 1, Me.Location.Y - 1, Me.Width + 1, Me.Height + 1))
                Case BorderEvent.Hover
                    pen = New Pen(bordercolor, penWidth)
                    g.DrawRectangle(pen, New Rectangle(Me.Location.X - 1, Me.Location.Y - 1, Me.Width + 1, Me.Height + 1))
            End Select
        End If
        'Me.Invalidate()
    End Sub

    Private OnFocusBack As Color = Color.White
    Private OnLostBack As Color = Color.White

    Public Property My_Event_Backcolor_LostFocus() As Color
        Get
            Return Me.OnLostBack
        End Get
        Set(ByVal value As Color)
            OnLostBack = value
        End Set
    End Property

    Public Property My_Event_Backcolor_GotFocus() As Color
        Get
            Return Me.OnFocusBack
        End Get
        Set(ByVal value As Color)
            OnFocusBack = value
        End Set
    End Property

    Private Sub GotFocus_(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MyBase.BackColor = OnFocusBack
        Refresh()
    End Sub
    Private Sub LostFocuss(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        MyBase.BackColor = OnLostBack
        Refresh()
    End Sub
    Private Sub MouseMove_(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        DrawBorder(BorderEvent.Hover)
    End Sub
    Private Sub MouseLeaver(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        DrawBorder(BorderEvent.Normal)
    End Sub

#End Region

#Region "GRADIENT AREA ONLY"
#Region "PROPERTY"
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
    Private ImgWidth As Integer = 0
    Public Property My_Image_Width_Additional() As Integer
        Get
            Return Me.ImgWidth
        End Get
        Set(ByVal value As Integer)
            ImgWidth = value
            Me.Invalidate()
        End Set
    End Property
    Private _normal_forecolor As Color = Color.Black
    Public Property My_Normal_ForeColor() As Color
        Get
            Return _normal_forecolor
        End Get
        Set(ByVal value As Color)
            _normal_forecolor = value
        End Set
    End Property
    Private _highlight_forecolor As Color = Color.White
    Public Property My_Highlight_Forecolor() As Color
        Get
            Return _highlight_forecolor
        End Get
        Set(ByVal value As Color)
            _highlight_forecolor = value
        End Set
    End Property
    Private select_font_color As Color = Color.Transparent
    Private select_border_color As Color = ColorTranslator.FromHtml("#cae8ff")
    Private select_top1 As Color = ColorTranslator.FromHtml("#ffffff")
    Private select_top2 As Color = ColorTranslator.FromHtml("#dceefb")
    Private select_bottom1 As Color = ColorTranslator.FromHtml("#c6e6ff")
    Private select_bottom2 As Color = ColorTranslator.FromHtml("#d6eaf9")
    Private unselect_font_color As Color = ColorTranslator.FromHtml("#797979")
    Private unselect_border_color As Color = ColorTranslator.FromHtml("#dadada")
    Private unselect_top1 As Color = ColorTranslator.FromHtml("#f3f4f5")
    Private unselect_top2 As Color = ColorTranslator.FromHtml("#e8e9e9")
    Private unselect_bottom1 As Color = ColorTranslator.FromHtml("#c1c1c1")
    Private unselect_bottom2 As Color = ColorTranslator.FromHtml("#f3f4f5")
    Private _itemToolItemSelectedColors As GradientColor
    Private Const _cutMenuItemBack As Single = 1.2F
    Private select_forecolor As Color = select_font_color
    Private selected_line_colors As Color = select_border_color
    Private tr_tl_lineup_corner As Color = selected_line_colors
    Private tr_tl_corner As Color = selected_line_colors
    Private br_bl_corner As Color = selected_line_colors
    Private br_bl_linedown_corner As Color = selected_line_colors
    Private top_fill_first As Color = select_top1
    Private top_fill_second As Color = select_top2
    Private bottom_fill_first As Color = select_bottom1
    Private bottom_fill_second As Color = select_bottom2
    Private top_rl_down_rl_line_corner_within_menu As Color = select_forecolor
    Private left_right_side_corner_withing_menu As Color = select_forecolor
    Private _itemToolItemUnSelectedColors As GradientColor
    Private unselect_forecolor As Color = unselect_font_color
    Private unselect_linecolor As Color = unselect_border_color
    Private utr_tl_lineup_corner As Color = unselect_linecolor
    Private utr_tl_corner As Color = unselect_linecolor
    Private ubr_bl_corner As Color = unselect_linecolor
    Private ubr_bl_linedown_corner As Color = unselect_linecolor
    Private utop_fill_first As Color = unselect_top1
    Private utop_fill_second As Color = unselect_top2
    Private ubottom_fill_first As Color = unselect_bottom1
    Private ubottom_fill_second As Color = unselect_bottom2
    Private utop_rl_down_rl_line_corner_within_menu As Color = unselect_linecolor
    Private uleft_right_side_corner_withing_menu As Color = unselect_linecolor
#End Region
#Region "SELECTION STYLE"
    Public Property My_Selection_Style_Custom_Select_FontColor() As Color
        Get
            Return Me.select_font_color
        End Get
        Set(ByVal value As Color)
            select_font_color = value
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
    Public Property My_Selection_Style_Custom_UnSelect_FontColor() As Color
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
#Region "FUNCTIONS"
    Public Sub reload_draw_item()
        Select Case SelectionStyle
            Case SelectStyleType.Standard
                MyBase.DrawMode = Nothing
            Case SelectStyleType.Custom_Selection_Only
                MyBase.DrawMode = Forms.DrawMode.OwnerDrawFixed
                assign_colors()
            Case SelectStyleType.Custom_Select_and_Unselect
                MyBase.DrawMode = Forms.DrawMode.OwnerDrawFixed
                assign_colors()
                assign_uncolors()
        End Select
    End Sub
    Private Sub refreshallassignments()
        select_forecolor = select_font_color
        selected_line_colors = select_border_color
        tr_tl_lineup_corner = selected_line_colors
        tr_tl_corner = selected_line_colors
        br_bl_corner = selected_line_colors
        br_bl_linedown_corner = selected_line_colors
        top_fill_first = select_top1
        top_fill_second = select_top2
        bottom_fill_first = select_bottom1
        bottom_fill_second = select_bottom2
        top_rl_down_rl_line_corner_within_menu = select_forecolor
        left_right_side_corner_withing_menu = select_forecolor
        unselect_forecolor = unselect_font_color
        unselect_linecolor = unselect_border_color
        utr_tl_lineup_corner = unselect_linecolor
        utr_tl_corner = unselect_linecolor
        ubr_bl_corner = unselect_linecolor
        ubr_bl_linedown_corner = unselect_linecolor
        utop_fill_first = unselect_top1
        utop_fill_second = unselect_top2
        ubottom_fill_first = unselect_bottom1
        ubottom_fill_second = unselect_bottom2
        utop_rl_down_rl_line_corner_within_menu = unselect_linecolor
        uleft_right_side_corner_withing_menu = unselect_linecolor
    End Sub
    Private Sub assign_colors()
        refreshallassignments()
        _itemToolItemSelectedColors = New GradientColor(tr_tl_lineup_corner, tr_tl_corner, br_bl_corner, br_bl_linedown_corner, top_fill_first, top_fill_second, bottom_fill_first, bottom_fill_second, top_rl_down_rl_line_corner_within_menu, left_right_side_corner_withing_menu)
    End Sub
    Private Sub assign_uncolors()
        refreshallassignments()
        _itemToolItemUnSelectedColors = New GradientColor(utr_tl_lineup_corner, utr_tl_corner, ubr_bl_corner, ubr_bl_linedown_corner, utop_fill_first, utop_fill_second, ubottom_fill_first, ubottom_fill_second, utop_rl_down_rl_line_corner_within_menu, uleft_right_side_corner_withing_menu)
    End Sub

#End Region
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

#Region " Constructor "

    Public Sub New()
        Me.DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
        _Items = New ColorListBoxItemCollection(Me)

        _ShowImages = True
        _TextAlign = ContentAlignment.MiddleLeft
    End Sub

#End Region

#Region " Properties "

    Private _Items As ColorListBoxItemCollection
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
    Public Overloads ReadOnly Property Items() As ColorListBoxItemCollection
        Get
            Return _Items
        End Get
    End Property

    'The original items that the user will never see.
    Private ReadOnly Property baseItems() As ObjectCollection
        Get
            Return MyBase.Items
        End Get
    End Property

    Public Overloads Property SelectedItem() As ColorListBoxItem
        Get
            Return DirectCast(MyBase.SelectedItem, ColorListBoxItem)
        End Get
        Set(ByVal value As ColorListBoxItem)
            MyBase.SelectedItem = value
        End Set
    End Property

    Public Overloads ReadOnly Property SelectedItems() As ColorListBoxSelectedItemCollection
        Get
            Dim items As New ColorListBoxSelectedItemCollection()
            For Each item As Object In MyBase.SelectedItems
                items.Add(DirectCast(item, ColorListBoxItem))
            Next
            Return items
        End Get
    End Property

    Private _ShowImages As Boolean
    <DefaultValue(True)> _
    Public Property My_ShowImages() As Boolean
        Get
            Return _ShowImages
        End Get
        Set(ByVal value As Boolean)
            If _ShowImages <> value Then
                _ShowImages = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _TextAlign As ContentAlignment
    <DefaultValue(ContentAlignment.MiddleLeft)> _
    Public Property My_TextAlign() As ContentAlignment
        Get
            Return _TextAlign
        End Get
        Set(ByVal value As ContentAlignment)
            If _TextAlign <> value Then
                _TextAlign = value
                Me.Invalidate()
            End If
        End Set
    End Property
    Enum ImgAlign
        left
        right
    End Enum
    Private _ImageAlign As ImgAlign
    <DefaultValue(ImgAlign.left)> _
    Public Property My_ImageAlign() As ImgAlign
        Get
            Return _ImageAlign
        End Get
        Set(ByVal value As ImgAlign)
            If _ImageAlign <> value Then
                _ImageAlign = value
                Me.Invalidate()
            End If
        End Set
    End Property

#End Region

#Region " Methods "

    Protected Overrides Sub OnDrawItem(ByVal e As System.Windows.Forms.DrawItemEventArgs)
        MyBase.OnDrawItem(e)

        'Draw original background and selection.
        'You can remove this and draw your own background if you want.
        e.DrawBackground()
        e.DrawFocusRectangle()

        If e.Index >= 0 AndAlso e.Index < Me.Items.Count Then
            Dim item As ColorListBoxItem = Me.Items(e.Index)
            DrawItemText(e, item)
            If item IsNot Nothing Then
                e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                If Me.My_ShowImages _
                AndAlso item.Image IsNot Nothing Then
                    'Draw the image
                    Select Case My_ImageAlign
                        Case ImgAlign.left
                            e.Graphics.DrawImage(item.Image, _
                                                 e.Bounds.X + 1, _
                                                 e.Bounds.Y + 1, _
                                                 (Me.ItemHeight - 2) + My_Image_Width_Additional, _
                                                 Me.ItemHeight - 2)
                        Case ImgAlign.right
                            e.Graphics.DrawImage(item.Image, _
                                                 ((Me.Width - Me.ItemHeight) - 1), e.Bounds.Y + 1, (Me.ItemHeight - 2) + My_Image_Width_Additional, Me.ItemHeight - 2)
                    End Select
                End If
            End If
            'Draw the item text
        End If
    End Sub

    Private Sub DrawItemText(ByVal e As System.Windows.Forms.DrawItemEventArgs, ByVal item As ColorListBoxItem)
        refreshallassignments()
        assign_colors()
        assign_uncolors()

        Dim x, y As Single
        Dim textSize As SizeF = e.Graphics.MeasureString(item.Text, Me.Font)
        Dim w As Single = textSize.Width
        Dim h As Single = textSize.Height
        Dim bounds As Rectangle = e.Bounds

        'If we are showing images, make some room for them and adjust the bounds width.
        If Me.My_ShowImages Then
            Select Case Me.My_ImageAlign
                Case ImgAlign.left
                    bounds.X += Me.ItemHeight + My_Image_Width_Additional
                    bounds.Width -= Me.ItemHeight
                Case ImgAlign.right
                    bounds.X += 0
                    bounds.Width -= Me.ItemHeight
            End Select
        End If

        'Depending on which TextAlign is chosen, determine the x and y position of the text.
        Select Case Me.My_TextAlign
            Case ContentAlignment.BottomCenter
                x = bounds.X + (bounds.Width - w) / 2
                y = bounds.Y + bounds.Height - h
            Case ContentAlignment.BottomLeft
                x = bounds.X
                y = bounds.Y + bounds.Height - h
            Case ContentAlignment.BottomRight
                x = bounds.X + bounds.Width - w
                y = bounds.Y + bounds.Height - h
            Case ContentAlignment.MiddleCenter
                x = bounds.X + (bounds.Width - w) / 2
                y = bounds.Y + (bounds.Height - h) / 2
            Case ContentAlignment.MiddleLeft
                x = bounds.X
                y = bounds.Y + (bounds.Height - h) / 2
            Case ContentAlignment.MiddleRight
                x = bounds.X + bounds.Width - w
                y = bounds.Y + (bounds.Height - h) / 2
            Case ContentAlignment.TopCenter
                x = bounds.X + (bounds.Width - w) / 2
                y = bounds.Y
            Case ContentAlignment.TopLeft
                x = bounds.X
                y = bounds.Y
            Case ContentAlignment.TopRight
                x = bounds.X + bounds.Width - w
                y = bounds.Y
        End Select
        'Finally draw the text.
        Try
            e.DrawBackground()
            Select Case SelectionStyle
                Case SelectStyleType.Standard
                    If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                        e.Graphics.DrawString(item.Text, Me.Font, New SolidBrush(My_Highlight_Forecolor), x, y)
                    Else
                        e.Graphics.DrawString(item.Text, Me.Font, New SolidBrush(My_Normal_ForeColor), x, y)
                    End If
                Case SelectStyleType.Custom_Selection_Only
                    If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                        DrawGradientItem(e.Graphics, New Rectangle(e.Bounds.Location.X, e.Bounds.Location.Y, e.Bounds.Width, e.Bounds.Height - 1), _itemToolItemSelectedColors)
                        e.Graphics.DrawString(item.Text, Me.Font, New SolidBrush(My_Highlight_Forecolor), x, y)
                    Else
                        e.Graphics.DrawString(item.Text, Me.Font, New SolidBrush(My_Normal_ForeColor), x, y)
                    End If
                Case SelectStyleType.Custom_Select_and_Unselect
                    If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                        DrawGradientItem(e.Graphics, New Rectangle(e.Bounds.Location, e.Bounds.Size), _itemToolItemSelectedColors)
                        e.Graphics.DrawString(item.Text, Me.Font, New SolidBrush(My_Highlight_Forecolor), x, y)
                    Else
                        DrawGradientItem(e.Graphics, New Rectangle(e.Bounds.Location, e.Bounds.Size), _itemToolItemUnSelectedColors)
                        e.Graphics.DrawString(item.Text, Me.Font, New SolidBrush(My_Normal_ForeColor), x, y)
                    End If
            End Select
            'e.DrawFocusRectangle()
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region " Nested classes "

    'A collection of ColorListBoxItems
    Public Class ColorListBoxItemCollection
        Inherits System.Collections.ObjectModel.Collection(Of ColorListBoxItem)

#Region " Fields "

        'Keep a reference to the ColorListBox so we can update its baseItems list
        Private _listBox As MyListBoxExtension

#End Region

#Region " Constructor "

        Public Sub New(ByVal listBox As MyListBoxExtension)
            _listBox = listBox
        End Sub

#End Region

#Region " Methods "

        Public Overloads Function Add(ByVal text As String) As ColorListBoxItem
            Return Me.Add(text, Color.Black, Nothing)
        End Function

        Public Overloads Function Add(ByVal text As String, ByVal color As Color) As ColorListBoxItem
            Return Me.Add(text, color, Nothing)
        End Function

        Public Overloads Function Add(ByVal text As String, ByVal color As Color, ByVal img As Image) As ColorListBoxItem
            Dim item As New ColorListBoxItem(text, color, img)
            Me.InsertItem(Me.Items.Count, item)
            Return item
        End Function

        Protected Overrides Sub ClearItems()
            MyBase.ClearItems()
            _listBox.baseItems.Clear()
        End Sub

        Protected Overrides Sub InsertItem(ByVal index As Integer, ByVal item As ColorListBoxItem)
            MyBase.InsertItem(index, item)
            _listBox.baseItems.Insert(index, item)
        End Sub

        Protected Overrides Sub RemoveItem(ByVal index As Integer)
            MyBase.RemoveItem(index)
            _listBox.baseItems.RemoveAt(index)
        End Sub

        Protected Overrides Sub SetItem(ByVal index As Integer, ByVal item As ColorListBoxItem)
            MyBase.SetItem(index, item)
            _listBox.baseItems(index) = item
        End Sub

        Public Sub AddRange(ByVal items As IEnumerable(Of ColorListBoxItem))
            For Each item As ColorListBoxItem In items
                Me.InsertItem(Me.Items.Count, item)
            Next
        End Sub

#End Region

    End Class

    'A collection containing the selected items
    Public Class ColorListBoxSelectedItemCollection
        Inherits System.Collections.ObjectModel.Collection(Of ColorListBoxItem)
    End Class

#End Region


    'An item that is added to the ColorListBox
    Public Class ColorListBoxItem

#Region " Constructors "

        Public Sub New()
            Me.New("New item", Color.Black, Nothing)
        End Sub

        Public Sub New(ByVal text As String)
            Me.New(text, Color.Black, Nothing)
        End Sub

        Public Sub New(ByVal text As String, ByVal color As Color)
            Me.New(text, color, Nothing)
        End Sub

        Public Sub New(ByVal text As String, ByVal color As Color, ByVal img As Image)
            Me.Text = text
            Me.Color = color
            Me.Image = img
        End Sub

#End Region

#Region " Properties "

        Private _Text As String
        Public Property Text() As String
            Get
                Return _Text
            End Get
            Set(ByVal value As String)
                _Text = value
            End Set
        End Property

        Private _Color As Color
        Public Property Color() As Color
            Get
                Return _Color
            End Get
            Set(ByVal value As Color)
                _Color = value
            End Set
        End Property

        Private _Image As Image
        Public Property Image() As Image
            Get
                Return _Image
            End Get
            Set(ByVal value As Image)
                _Image = value
            End Set
        End Property

#End Region

    End Class



End Class

