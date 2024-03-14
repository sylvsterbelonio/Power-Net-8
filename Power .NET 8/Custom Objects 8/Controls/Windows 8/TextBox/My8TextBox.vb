Imports System.Drawing.Design
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Security.Permissions
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

<ToolboxBitmapAttribute(GetType(TextBox))> _
Public Class My8TextBox

    Public Event SearchValue(ByVal value As String)
    Public myText As String = ""

#Region "PROPERTIES"

    Private Sub reAssign()
        txtSearchBox.Text = myText
    End Sub

    Enum SearchButtonBehavior
        Hide
        Show
        AutoHide
    End Enum
    Private _My_SearchButton As SearchButtonBehavior = SearchButtonBehavior.Hide

    Private autoClear As Boolean = True
    Public Property My_SearchButton_AutoClear() As Boolean
        Get
            Return autoClear
        End Get
        Set(ByVal value As Boolean)
            autoClear = value
        End Set
    End Property

    Public Property AutoCompleteSourceCustomSource() As AutoCompleteStringCollection
        Get
            Return txtSearchBox.AutoCompleteCustomSource
        End Get
        Set(ByVal value As AutoCompleteStringCollection)
            txtSearchBox.AutoCompleteCustomSource = value
        End Set
    End Property
    Public Property AutoCompleteMode() As AutoCompleteMode
        Get
            Return txtSearchBox.AutoCompleteMode
        End Get
        Set(ByVal value As AutoCompleteMode)
            txtSearchBox.AutoCompleteMode = value
        End Set
    End Property
    Public Property AutoCompleteSource() As AutoCompleteSource
        Get
            Return txtSearchBox.AutoCompleteSource
        End Get
        Set(ByVal value As AutoCompleteSource)
            txtSearchBox.AutoCompleteSource = value
        End Set
    End Property

    Public Property MaxLength() As Integer
        Get
            Return txtSearchBox.MaxLength
        End Get
        Set(ByVal value As Integer)
            txtSearchBox.MaxLength = value
        End Set
    End Property

    Public Property Text_() As String
        Get
            Return txtSearchBox.Text
        End Get
        Set(ByVal value As String)
            myText = value
            txtSearchBox.Text = value
        End Set
    End Property
    Public Property ReadOnly_() As Boolean
        Get
            Return (txtSearchBox.ReadOnly)
        End Get
        Set(ByVal value As Boolean)
            txtSearchBox.ReadOnly = value
        End Set
    End Property

    Public Property PasswordChar() As String
        Get
            Return txtSearchBox.PasswordChar
        End Get
        Set(ByVal value As String)
            txtSearchBox.PasswordChar = value
        End Set
    End Property
    Public Property My_SearchButton() As SearchButtonBehavior
        Get
            Return Me._My_SearchButton
        End Get
        Set(ByVal value As SearchButtonBehavior)
            _My_SearchButton = value
            SearchButton()
        End Set
    End Property

    Private clearButton As Boolean = True
    Public Property My_ClearButton() As Boolean
        Get
            Return Me.clearButton
        End Get
        Set(ByVal value As Boolean)
            clearButton = value
        End Set
    End Property

    Private gotFocusBackcolor As Color = Color.White
    Private lostFocusBackcolor As Color = Color.White
    Private gotFocusForecolor As Color = Color.Black
    Private lostFocusForecolor As Color = Color.Black
    Private customColors As Boolean = False
    Private CharCasing As CharacterCasing = Windows.Forms.CharacterCasing.Normal


    Public Property CharacterCasing() As CharacterCasing
        Get
            Return txtSearchBox.CharacterCasing
        End Get
        Set(ByVal value As CharacterCasing)
            txtSearchBox.CharacterCasing = value
        End Set
    End Property

    Public Property My_AllowCustom_Colors() As Boolean
        Get
            Return customColors
        End Get
        Set(ByVal value As Boolean)
            customColors = value
        End Set
    End Property
    Public Property My_GotFocus_Backcolor() As Color
        Get
            Return gotFocusBackcolor
        End Get
        Set(ByVal value As Color)
            gotFocusBackcolor = value

        End Set
    End Property
    Public Property My_GotFocus_Forecolor() As Color
        Get
            Return gotFocusForecolor
        End Get
        Set(ByVal value As Color)
            gotFocusForecolor = value
        End Set
    End Property
    Public Property My_LostFocus_Backcolor() As Color
        Get
            Return lostFocusBackcolor
        End Get
        Set(ByVal value As Color)
            lostFocusBackcolor = value
        End Set
    End Property
    Public Property My_LostFocus_Forecolor() As Color
        Get
            Return lostFocusForecolor
        End Get
        Set(ByVal value As Color)
            lostFocusForecolor = value
        End Set
    End Property

    Public Property TextAlign() As HorizontalAlignment
        Get
            Return txtSearchBox.TextAlign
        End Get
        Set(ByVal value As HorizontalAlignment)
            txtSearchBox.TextAlign = value
        End Set
    End Property

    Private SampleColor As myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors = myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
    Friend myDColor As New myColor.Share.SystemColor.BackgroundColor.StandardColor
    Public Property Standard_ThemeColor() As myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors
        Get
            Return SampleColor
        End Get
        Set(ByVal value As myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors)
            SampleColor = value
            myDColor.getDefaultColor(SampleColor)
            set_color_properties()
            Me.Invalidate()
        End Set
    End Property
    Private Normal_BackColor As Color = myColor.Share.Converter.StringToColor.getHTMLColor("#0050EF")
    Private Normal_ForeColor As Color = Color.White
    Private Pressed_BackColor As Color = Color.White
    Private Pressed_ForeColor As Color = myColor.Share.Converter.StringToColor.getHTMLColor("#0050EF")
    Private Hover_BackColor As Color = myColor.Share.Converter.StringToColor.getHTMLColor("#0050EF")
    Private Hover_ForeColor As Color = Color.White
    Private BorderColor As Color = Color.White

    Public Property My_SearchButton_MouseOverBackcolor() As Color
        Get
            Return cmdSearch.FlatAppearance.MouseOverBackColor
        End Get
        Set(ByVal value As Color)
            cmdSearch.FlatAppearance.MouseOverBackColor = value
            Me.Invalidate()
        End Set
    End Property

    Public Property My_SearchButton_BackColor() As Color
        Get
            Return Normal_BackColor

        End Get
        Set(ByVal value As Color)
            Normal_BackColor = value
            cmdSearch.BackColor = value
            Me.Invalidate()
        End Set
    End Property

    Private Sub set_color_properties()
        If customColors = False Then
            Normal_BackColor = myDColor.gBackColor
            Normal_ForeColor = myDColor.gForeColor
            Pressed_BackColor = myDColor.gPressedBackColor
            Pressed_ForeColor = myDColor.gPressedForeColor
            Hover_BackColor = myDColor.gHoverBackColor
            Hover_ForeColor = myDColor.gHoverForeColor

            cmdSearch.BackColor = Normal_BackColor
            cmdSearch.ForeColor = Normal_ForeColor
            cmdSearch.FlatAppearance.MouseDownBackColor = Pressed_BackColor
            cmdSearch.FlatAppearance.MouseOverBackColor = myColor.Share.Tools.Brightness.Apply(Normal_BackColor, sBUTTON)
            reAssign()
        End If
    End Sub

#End Region

    Private Sub SearchButton()
        If _My_SearchButton = SearchButtonBehavior.Show Then
            cmdSearch.Visible = True
        ElseIf txtSearchBox.Text <> "" And _My_SearchButton = SearchButtonBehavior.AutoHide Then
            cmdSearch.Visible = True
        Else
            cmdSearch.Visible = False
        End If
    End Sub

    Private Sub My8TextBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = txtSearchBox.BackColor
        reAssign()
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        cmdClose.Image = myIcons.Share.Jquery.GetJqueryIcons(myIcons.Share.Jquery.JqueryIconTypes.close, My.Resources.gray_jquery, 16, 16)
        reAssign()
    End Sub

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        txtSearchBox.Width = Me.Width - 10
    End Sub

    Private Sub txtSearchBox_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.EnabledChanged
        Me.BackColor = txtSearchBox.BackColor
    End Sub

    Private Sub txtSearchBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.GotFocus
        txtSearchBox.BackColor = gotFocusBackcolor
        txtSearchBox.ForeColor = gotFocusForecolor
        Me.BackColor = gotFocusBackcolor
        Me.CreateGraphics.DrawRectangle(New Pen(cmdSearch.BackColor), New Rectangle(0, 0, Me.Width - 1, Me.Height - 1))

    End Sub

    Private Sub txtSearchBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmdSearch.Visible Then
                RaiseEvent SearchValue(txtSearchBox.Text)
                If autoClear Then
                    txtSearchBox.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub txtSearchBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.LostFocus

        txtSearchBox.BackColor = lostFocusBackcolor
        txtSearchBox.ForeColor = lostFocusForecolor
        Me.BackColor = lostFocusBackcolor

        Me.CreateGraphics.DrawRectangle(New Pen(lostFocusBackcolor), New Rectangle(0, 0, Me.Width - 1, Me.Height - 1))
    End Sub

    Private Sub txtSearchBox_ReadOnlyChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.ReadOnlyChanged
        Me.BackColor = txtSearchBox.BackColor
    End Sub

    Private Sub txtSearchBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchBox.TextChanged
        If txtSearchBox.Text.Length > 0 And txtSearchBox.ReadOnly = False Then
            If clearButton Then cmdClose.Visible = True
            If _My_SearchButton = SearchButtonBehavior.AutoHide Then
                cmdSearch.Visible = True
            End If
        Else

            If _My_SearchButton = SearchButtonBehavior.AutoHide Then
                cmdSearch.Visible = False
            End If

            If clearButton Then cmdClose.Visible = False


            txtSearchBox.CreateGraphics.DrawString("THIS IS JUST WATERMARK", Me.Font, Brushes.Gray, 0, Me.Height / 2)
        End If
    End Sub

    Private Sub cmdClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        If txtSearchBox.ReadOnly = False Then
            txtSearchBox.Text = ""
            cmdClose.Visible = False
        End If
    End Sub

    Private Sub cmdClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClose.MouseLeave
        cmdClose.Image = myIcons.Share.Jquery.GetJqueryIcons(myIcons.Share.Jquery.JqueryIconTypes.close, My.Resources.gray_jquery, 16, 16)
    End Sub

    Private Sub cmdClose_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdClose.MouseMove
        cmdClose.Image = myIcons.Share.Jquery.GetJqueryIcons(myIcons.Share.Jquery.JqueryIconTypes.close, My.Resources.ui_icons_070603_256x240, 16, 16)
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        RaiseEvent SearchValue(txtSearchBox.Text)
        If autoClear Then
            txtSearchBox.Text = ""
        End If
    End Sub

End Class


