Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.Globalization
Imports System.Reflection
Imports System.ComponentModel.Design.Serialization

'<ToolboxItem(True), ToolboxBitmap(GetType(MyComboBoxExtension), "MyObjectExtensions.comboboxes.bmp")> _
Public Class MyComboBoxExtension
    Inherits ComboBox

    Public Sub New()
        MyBase.New()
    End Sub

#Region "BACKCOLOR EVENT"

    Dim OnFocus As Color = Color.White
    Dim OnFocusF As Color = Color.Black

    <Description("Set the backcolor of an object during [Got Focus Event].")> _
    Public Property My_Event_Backcolor_Focus() As Color
        Get
            Return Me.OnFocus
        End Get
        Set(ByVal value As Color)
            OnFocus = value
        End Set
    End Property

    <Description("Set the forecolor of an object during [Got Focus Event].")> _
    Public Property My_Event_Fontcolor_Focus() As Color
        Get
            Return Me.OnFocusF
        End Get
        Set(ByVal value As Color)
            OnFocusF = value
        End Set
    End Property

    Public Property My_Event_Backcolor_Lostfocus() As Color
        Get
            Return Me.backC
        End Get
        Set(ByVal value As Color)
            backC = value
        End Set
    End Property

    Public Property My_Event_Forecolor_Lostfocus() As Color
        Get
            Return Me.foreC
        End Get
        Set(ByVal value As Color)
            foreC = value
        End Set
    End Property

    Dim IsTextFocus As Boolean = False
#End Region

#Region "CORNER AND BORDER STYLE"

    Dim MyCOrnerSize_ As Double = 1.0
    Dim MyBorderSize As Double = 0.5
    Dim MyBorderColorsNormal As Color = Color.Black
    Dim MyBorderColorsHover As Color = Color.SteelBlue
    Dim MyBorderError As Color = Color.White
    Dim MyBorderDisabled As Color = Color.Gray
    Dim HasErrorOccurred As Boolean = False

    Enum BorderEvent
        Normal
        Hover
    End Enum

    Private Sub DrawBorder(Optional ByVal type As BorderEvent = BorderEvent.Normal)
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
        'Me.Invalidate()
    End Sub

#Region "PROPERTY"

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
            Return Me.penWidth
        End Get
        Set(ByVal value As Double)
            penWidth = value
            Invalidate()
        End Set
    End Property

    <Description("The border line color changes when hovered by the mouse pointer.")> _
    Public Property My_BorderColor_Hover() As Color
        Get
            Return Me.MyBorderColorsHover
        End Get
        Set(ByVal value As Color)
            MyBorderColorsHover = value
        End Set
    End Property

#End Region

    Public Sub RefreshBorder()
        DrawBorder()
        Me.Invalidate()
    End Sub

    Enum MyEvent
        ui_state_normal
        ui_state_hover
        ui_state_error
        ui_state_disable
    End Enum

    Public Sub MyEvent_Mode(ByVal event_style As MyEvent)
        Dim g As Graphics = MyBase.CreateGraphics

        'ExtendedDraw(g)
        Select Case event_style
            Case MyEvent.ui_state_normal
                pen = New Pen(MyBorderColorsNormal, penWidth)
                'DrawBorders(g, MyBorderColorsNormal)
            Case MyEvent.ui_state_hover
                pen = New Pen(MyBorderColorsHover, penWidth)
                'DrawBorders(g, MyBorderColorsHover)
            Case MyEvent.ui_state_disable
                pen = New Pen(MyBorderDisabled, penWidth)
                'DrawBorders(g, MyBorderDisabled)
            Case MyEvent.ui_state_error
                pen = New Pen(MyBorderError, penWidth)
                'DrawBorders(g, MyBorderError)
                HasErrorOccurred = True
        End Select
        'Invalidate()
        ' ExtendedDraw(g)
    End Sub

    Public Function checkHasBorderErrors()
        Return HasErrorOccurred
    End Function

#End Region


#Region "ROUND CORNER"

    Private pen As Pen = New Pen(MyBorderColorsNormal, penWidth)
    Private penWidth As Double = 1.0F
    Private _edge As Integer = 3
    Dim backC As Color = Color.White
    Dim foreC As Color = Color.Black

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

    Private Sub DrawBorders(ByVal graphics As Graphics, ByVal colorx As Color)
        DrawSingleBorder(graphics, colorx)
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

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        DrawBorder()
        If SelectionStyle = SelectStyleType.Custom_Selection_Only Or SelectionStyle = SelectStyleType.Custom_Select_and_Unselect Then
            Me.DrawMode = Forms.DrawMode.OwnerDrawVariable
        End If
    End Sub

#Region "VALIDATION OF BORDER ERRORS"

    Private Sub load_the_latest_event()
        For i As Integer = 0 To Me.Controls.Count - 1
            Dim a As Object = Me.Controls(i)
            If TypeOf a Is MyComboBoxExtension Then
                If CType(a, MyComboBoxExtension).Enabled = False Then
                    'CType(a, MyComboBoxExtension).Enabled = True
                    'CType(a, MyComboBoxExtension).Enabled = False
                    'CType(a, MyComboBoxExtension).BackColor = Color.Red
                End If
                CType(a, MyComboBoxExtension).reload_draw_item()
            Else
            End If
        Next
    End Sub

    Private Sub update_combobox()
        For i As Integer = 0 To Me.Controls.Count - 1
            Dim a As Object = Me.Controls(i)
            If TypeOf a Is MyComboBoxExtension Then
                If CType(a, MyComboBoxExtension).Enabled Then
                    If Not CType(a, MyComboBoxExtension).checkHasBorderErrors And Not CType(a, MyComboBoxExtension).CheckHasDisabledOccurred Then
                        CType(a, MyComboBoxExtension).RefreshBorder()
                    Else
                    End If
                Else
                End If
            End If
        Next
    End Sub

#End Region

#End Region

    Dim focus_event As Boolean = False
    Private Sub GotFocus_(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MyBase.BackColor = OnFocus
        MyBase.ForeColor = OnFocusF
        DrawBorder(BorderEvent.Hover)
        Refresh()
        focus_event = True
    End Sub

    Private Sub LostFocuss(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        MyBase.BackColor = backC
        MyBase.ForeColor = foreC
        DrawBorder(BorderEvent.Normal)
        Refresh()
        'focus_event()
    End Sub

    Private Sub MouseMove_(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        DrawBorder(BorderEvent.Hover)
    End Sub

    Private Sub MouseLeaver(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        DrawBorder(BorderEvent.Normal)
        Refresh()
    End Sub

    Protected Overrides Sub OnMouseDoubleClick(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDoubleClick(e)
        Refresh()
    End Sub

    Protected Overrides Sub OnMouseClick(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseClick(e)
        Refresh()
    End Sub

    Dim HasDisabledOccurred As Boolean = False

    Public Function CheckHasDisabledOccurred() As Boolean
        Return HasDisabledOccurred
    End Function

    Protected Overrides Sub OnEnabledChanged(ByVal e As System.EventArgs)
        MyBase.OnEnabledChanged(e)

        If MyBase.Enabled = True Then
            HasDisabledOccurred = False
            'MyEvent_Mode(MyEvent.ui_state_normal)
        Else
            HasDisabledOccurred = True
            'MyEvent_Mode(MyEvent.ui_state_disable)
            'MyBase.BackColor = Color.Red
        End If
    End Sub

    Protected Overrides Sub OnSelectedIndexChanged(ByVal e As System.EventArgs)
        MyBase.OnSelectedIndexChanged(e)
        'DrawBorder(BorderEvent.Normal)
    End Sub

    Private Sub OnKeyPress_(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim KeyPressChar As Long
        KeyPressChar = e.KeyChar.GetHashCode
        Select Case KeyPressChar
            Case 65537 ' press ctrl+a
                DirectCast(sender, ComboBox).SelectAll()
            Case 327685 'press ctrl+e
                'MsgBox("crl e")
            Case 262148 'press ctrl+d
                DirectCast(sender, ComboBox).Text = ""
            Case 393222 'press ctrl+f
                'MsgBox("crl f")
            Case 1245203 'press ctrl+s
                'MsgBox("crl s")
            Case 1769499 ' press esc
                DirectCast(sender, ComboBox).Text = ""
            Case 983055 ' press ctrl+o
                'MsgBox("crl o")
        End Select
    End Sub

#Region "DRAW ITEM EVENTS"

#Region "GLOBAL DECLARATIONS"

    Private ImgWidth As Integer = 25
    Dim ImgList As New ImageList
    Private SelectionStyle As SelectStyleType = SelectStyleType.Standard
    Private ImageIconStyles As ImageIconStyle

    Enum ImageIconStyle
        Left
        Right
        None
    End Enum

#End Region

#Region "PROPERTIES"

    Enum SelectStyleType
        Standard
        Custom_Selection_Only
        Custom_Select_and_Unselect
    End Enum

    Public Property My_Selection_Style() As SelectStyleType
        Get
            Return Me.SelectionStyle
        End Get
        Set(ByVal value As SelectStyleType)
            SelectionStyle = value
            Select Case SelectionStyle
                Case SelectStyleType.Standard
                    Me.DrawMode = Forms.DrawMode.Normal
                Case SelectStyleType.Custom_Select_and_Unselect Or SelectStyleType.Custom_Selection_Only
                    Me.DrawMode = Forms.DrawMode.OwnerDrawVariable
            End Select
            refreshallassignments()
            Me.Invalidate()
        End Set
    End Property

    Public Property My_Image_Icon_Style() As ImageIconStyle
        Get
            Return Me.ImageIconStyles
        End Get
        Set(ByVal value As ImageIconStyle)
            ImageIconStyles = value
        End Set
    End Property

    Public Property My_Image_Width() As Integer
        Get
            Return Me.ImgWidth
        End Get
        Set(ByVal value As Integer)
            ImgWidth = value
        End Set
    End Property

    Public Property My_ImageList() As ImageList
        Get
            Return Me.ImgList
        End Get
        Set(ByVal value As ImageList)
            ImgList = value
        End Set
    End Property

    Private select_font_color As Color = Color.DarkBlue
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


#End Region

#Region "FUNCTIONS"

    Public Sub clear_image_collection()
        ImgList.Images.Clear()
    End Sub

#End Region

#Region "GLOBAL VARIABLES"

    Dim cropBitmap As Bitmap

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

#End Region

#Region "GLOBAL VARIABLES"

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

#End Region

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

    Public Function resize_Image(ByRef bmp As Bitmap, ByVal width As Integer, ByVal height As Integer)
        If Not bmp Is Nothing Then
            Try
                Dim bm_dest As Bitmap
                Dim bm_source As Bitmap
                Dim img1 As New PictureBox

                img1.Image = cropBitmap
                bm_source = New Bitmap(bmp)
                bm_dest = New Bitmap( _
                    CInt(width), _
                    CInt(height))
                Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)
                gr_dest.DrawImage(bm_source, 0, 0, width, height)
                Return bm_dest
            Catch ex As Exception
            End Try
        End If
        Return Nothing
    End Function

    Private Function load_image(ByVal index As Integer) As Image
        If index <> -1 Then
            If index <= ImgList.Images.Count - 1 Then
                Return ImgList.Images(index)
            Else
                Return Nothing
            End If
        End If
        Return Nothing
    End Function

    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaintBackground(pevent)
        If SelectionStyle = SelectStyleType.Custom_Selection_Only Or SelectionStyle = SelectStyleType.Custom_Select_and_Unselect Then
            Me.DrawMode = Forms.DrawMode.OwnerDrawVariable
        End If
    End Sub

    Protected Overrides Sub OnDrawItem(ByVal e As System.Windows.Forms.DrawItemEventArgs)
        refreshallassignments()
        assign_colors()
        assign_uncolors()

        MyBase.OnDrawItem(e)

        Dim a As Image = resize_Image(load_image(e.Index), ImgWidth, 10)

        Try
            e.DrawBackground()

            Select Case SelectionStyle

                Case SelectStyleType.Standard
                    If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then

                        Using brush As New SolidBrush(unselect_forecolor)
                            e.Graphics.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), e.Font, Brushes.Black, e.Bounds)
                        End Using
                    Else

                    End If

                Case SelectStyleType.Custom_Selection_Only

                    If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                        DrawGradientItem(e.Graphics, New Rectangle(e.Bounds.Location, e.Bounds.Size), _itemToolItemSelectedColors)
                        Dim rc As New Rectangle(Point.Empty, e.Bounds.Size)
                        Dim cc As Color = select_forecolor

                        If ImageIconStyles = ImageIconStyle.Left Then

                            If Not a Is Nothing Then
                                e.Graphics.DrawImage(a, e.Bounds.Left + 2, e.Bounds.Top + 2)
                                Using brush As New SolidBrush(cc)
                                    e.Graphics.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), e.Font, brush, a.Width + 5, e.Bounds.Y)
                                End Using
                            Else
                                Using brush As New SolidBrush(cc)
                                    e.Graphics.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), e.Font, brush, e.Bounds)
                                End Using
                            End If

                        ElseIf ImageIconStyles = ImageIconStyle.Right Then
                            If Not a Is Nothing Then e.Graphics.DrawImage(a, e.Bounds.Right - (a.Width + 2), e.Bounds.Top + 2)
                            Using brush As New SolidBrush(cc)
                                e.Graphics.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), e.Font, brush, e.Bounds)
                            End Using
                        Else
                            Using brush As New SolidBrush(cc)
                                e.Graphics.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), e.Font, brush, e.Bounds)
                            End Using
                        End If

                    Else
                        Dim rc As New Rectangle(Point.Empty, e.Bounds.Size)
                        Dim cc As Color = unselect_forecolor
                        If ImageIconStyles = ImageIconStyle.Left Then
                            If Not a Is Nothing Then
                                e.Graphics.DrawImage(a, e.Bounds.Left + 2, e.Bounds.Top + 2)
                                Using brush As New SolidBrush(cc)
                                    e.Graphics.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), e.Font, brush, a.Width + 5, e.Bounds.Y)
                                End Using
                            Else
                                Using brush As New SolidBrush(cc)
                                    e.Graphics.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), e.Font, brush, e.Bounds)
                                End Using
                            End If

                        ElseIf ImageIconStyles = ImageIconStyle.Right Then
                            If Not a Is Nothing Then
                                e.Graphics.DrawImage(a, e.Bounds.Right - (a.Width + 2), e.Bounds.Top + 2)
                                Using brush As New SolidBrush(cc)
                                    e.Graphics.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), e.Font, brush, e.Bounds)
                                End Using
                            Else
                                Using brush As New SolidBrush(cc)
                                    e.Graphics.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), e.Font, brush, e.Bounds)
                                End Using
                            End If
                        Else
                            Using brush As New SolidBrush(cc)
                                e.Graphics.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), e.Font, brush, e.Bounds)
                            End Using
                        End If

                    End If

                Case SelectStyleType.Custom_Select_and_Unselect

                    If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                        DrawGradientItem(e.Graphics, New Rectangle(e.Bounds.Location, e.Bounds.Size), _itemToolItemSelectedColors)
                        Dim rc As New Rectangle(Point.Empty, e.Bounds.Size)
                        Dim cc As Color = select_forecolor

                        If ImageIconStyles = ImageIconStyle.Left Then

                            If Not a Is Nothing Then
                                e.Graphics.DrawImage(a, e.Bounds.Left + 2, e.Bounds.Top + 2)
                                Using brush As New SolidBrush(cc)
                                    e.Graphics.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), e.Font, brush, a.Width + 5, e.Bounds.Y)
                                End Using
                            Else
                                Using brush As New SolidBrush(cc)
                                    e.Graphics.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), e.Font, brush, e.Bounds)
                                End Using
                            End If

                        ElseIf ImageIconStyles = ImageIconStyle.Right Then
                            If Not a Is Nothing Then e.Graphics.DrawImage(a, e.Bounds.Right - (a.Width + 2), e.Bounds.Top + 2)
                            Using brush As New SolidBrush(cc)
                                e.Graphics.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), e.Font, brush, e.Bounds)
                            End Using
                        Else
                            Using brush As New SolidBrush(cc)
                                e.Graphics.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), e.Font, brush, e.Bounds)
                            End Using
                        End If

                    Else
                        DrawGradientItem(e.Graphics, New Rectangle(e.Bounds.Location, e.Bounds.Size), _itemToolItemUnSelectedColors)
                        Dim rc As New Rectangle(Point.Empty, e.Bounds.Size)
                        Dim cc As Color = unselect_forecolor

                        If ImageIconStyles = ImageIconStyle.Left Then
                            If Not a Is Nothing Then
                                e.Graphics.DrawImage(a, e.Bounds.Left + 2, e.Bounds.Top + 2)
                                Using brush As New SolidBrush(cc)
                                    e.Graphics.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), e.Font, brush, a.Width + 5, e.Bounds.Y)
                                End Using
                            Else
                                Using brush As New SolidBrush(cc)
                                    e.Graphics.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), e.Font, brush, e.Bounds)
                                End Using
                            End If

                        ElseIf ImageIconStyles = ImageIconStyle.Right Then
                            If Not a Is Nothing Then e.Graphics.DrawImage(a, e.Bounds.Right - (a.Width + 2), e.Bounds.Top + 2)
                            Using brush As New SolidBrush(cc)
                                e.Graphics.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), e.Font, brush, e.Bounds)
                            End Using
                        Else
                            Using brush As New SolidBrush(cc)
                                e.Graphics.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), e.Font, brush, e.Bounds)
                            End Using
                        End If

                    End If
            End Select
            'e.DrawFocusRectangle()
        Catch ex As Exception
        End Try
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

End Class

