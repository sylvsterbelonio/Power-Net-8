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
<ToolboxBitmapAttribute(GetType(Button))> _
Public Class My8Button
    Inherits Windows.Forms.Button

    Friend myDColor As New myColor.Share.SystemColor.BackgroundColor.StandardColor
    Friend myValidate As New myColor.Share.Converter.StringToColor

    Private Normal_BackColor As Color = myColor.Share.Converter.StringToColor.getHTMLColor("#0050EF")
    Private Normal_ForeColor As Color = Color.White
    Private Pressed_BackColor As Color = Color.White
    Private Pressed_ForeColor As Color = myColor.Share.Converter.StringToColor.getHTMLColor("#0050EF")
    Private Hover_BackColor As Color = myColor.Share.Converter.StringToColor.getHTMLColor("#0050EF")
    Private Hover_ForeColor As Color = Color.White
    Private BorderColor As Color = Color.White
    Private SampleColor As myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors = myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue

    Private myImage_ As Image = Nothing
    'My Icon Custom
    Private IconLibraryTypes As myIcons.Share.General.IconLibraryTypes = myIcons.Share.General.IconLibraryTypes.NotSet

    Public Property IconTypes() As myIcons.Share.General.IconLibraryTypes
        Get
            Return IconLibraryTypes
        End Get
        Set(ByVal value As myIcons.Share.General.IconLibraryTypes)
            IconLibraryTypes = value
            set_color_properties()
        End Set
    End Property

#Region "JQUERY"

    Private JqueryIcon As myIcons.Share.Jquery.JqueryIconTypes = myIcons.Share.Jquery.JqueryIconTypes.NotSet
    Private JqueryIconColor As myIcons.Share.Jquery.JqueryIconColor = myIcons.Share.Jquery.JqueryIconColor.Black

    Public Property JqueryIconTypes() As myIcons.Share.Jquery.JqueryIconTypes
        Get
            Return JqueryIcon
        End Get
        Set(ByVal value As myIcons.Share.Jquery.JqueryIconTypes)
            JqueryIcon = value
            If JqueryIcon <> myIcons.Share.Jquery.JqueryIconTypes.NotSet Then
                JqueryMobileIcon = myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
                JqueryMobileIconColor_ = myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
                Windows8Icon = myIcons.Share.Windows8.Windows8IconTypes.NotSet
                IconLibraryTypes = myIcons.Share.General.IconLibraryTypes.Jquery
            End If

            set_color_properties()
        End Set
    End Property

    Public Property JqueryIconColorHover() As myIcons.Share.Jquery.JqueryIconTypes
        Get
            Return JqueryIconColor
        End Get
        Set(ByVal value As myIcons.Share.Jquery.JqueryIconTypes)
            JqueryIconColor = value
            If JqueryIconColor <> myIcons.Share.Jquery.JqueryIconTypes.NotSet Then
                JqueryMobileIcon = myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
                JqueryMobileIconColor_ = myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
                Windows8Icon = myIcons.Share.Windows8.Windows8IconTypes.NotSet
                IconLibraryTypes = myIcons.Share.General.IconLibraryTypes.Jquery
            End If

            If JqueryIconTypes = myIcons.Share.Jquery.JqueryIconTypes.NotSet Then
                'JqueryIconTypes = myicons.share.JqueryIconTypes.carrat_1_n
            End If

            set_color_properties()
        End Set
    End Property

#End Region

#Region "JQUERY MOBILE"

    Private JqueryMobileIcon As myIcons.Share.JqueryMobile.JqueryMobileIconTypes = myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
    Private JqueryMobileIconColor_ As myIcons.Share.JqueryMobile.JqueryMobileIconColor = myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet

    Public Property JqueryMobileIconTypes() As myIcons.Share.JqueryMobile.JqueryMobileIconTypes
        Get
            Return JqueryMobileIcon
        End Get
        Set(ByVal value As myIcons.Share.JqueryMobile.JqueryMobileIconTypes)
            JqueryMobileIcon = value
            If JqueryMobileIcon <> myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet Then
                JqueryIcon = myIcons.Share.Jquery.JqueryIconTypes.NotSet
                JqueryIconColor = myIcons.Share.Jquery.JqueryIconTypes.NotSet
                Windows8Icon = myIcons.Share.Windows8.Windows8IconTypes.NotSet
                IconLibraryTypes = myIcons.Share.General.IconLibraryTypes.JqueryMobile
            End If

            set_color_properties()
        End Set
    End Property

    Public Property JqueryMobileIconColor() As myIcons.Share.JqueryMobile.JqueryMobileIconColor
        Get
            Return JqueryMobileIconColor_
        End Get
        Set(ByVal value As myIcons.Share.JqueryMobile.JqueryMobileIconColor)
            JqueryMobileIconColor_ = value
            If JqueryMobileIconColor_ <> myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet Then
                JqueryIcon = myIcons.Share.Jquery.JqueryIconTypes.NotSet
                JqueryIconColor = myIcons.Share.Jquery.JqueryIconTypes.NotSet
                Windows8Icon = myIcons.Share.Windows8.Windows8IconTypes.NotSet
                IconLibraryTypes = myIcons.Share.General.IconLibraryTypes.JqueryMobile
            End If
            If JqueryMobileIcon = myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet Then
                'JqueryMobileIcon = myicons.share.JqueryMobileIconTypes.left_arrow
            End If

            set_color_properties()
        End Set
    End Property

#End Region

#Region "WINDOWS 8"

    Private Windows8Icon As myIcons.Share.Windows8.Windows8IconTypes = myIcons.Share.Windows8.Windows8IconTypes.NotSet

    Public Property Windows8IconTypes() As myIcons.Share.Windows8.Windows8IconTypes
        Get
            Return Windows8Icon
        End Get
        Set(ByVal value As myIcons.Share.Windows8.Windows8IconTypes)
            Windows8Icon = value
            If Windows8Icon <> myIcons.Share.Windows8.Windows8IconTypes.NotSet Then
                JqueryIcon = myIcons.Share.Jquery.JqueryIconTypes.NotSet
                JqueryIconColor = myIcons.Share.Jquery.JqueryIconTypes.NotSet
                JqueryMobileIcon = myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
                JqueryMobileIconColor_ = myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
                IconLibraryTypes = myIcons.Share.General.IconLibraryTypes.Windows8
            End If
            set_color_properties()
        End Set
    End Property

#End Region

    Public Overrides Property BackColor() As Color
        Get
            Return Normal_BackColor
        End Get
        Set(ByVal value As Color)
            Normal_BackColor = value
            Me.Invalidate()
        End Set
    End Property

    Public Overrides Property ForeColor() As Color
        Get
            Return Normal_ForeColor
        End Get
        Set(ByVal value As Color)
            Normal_ForeColor = value
            Me.Invalidate()
        End Set
    End Property

    Public Property MouseOverBackcolor() As Color
        Get
            Return Hover_BackColor
        End Get
        Set(ByVal value As Color)
            Hover_BackColor = value
            Me.FlatAppearance.MouseOverBackColor = Hover_BackColor
            Me.Invalidate()
        End Set
    End Property

    Public Property MouseOverForecolor() As Color
        Get
            Return Hover_ForeColor
        End Get
        Set(ByVal value As Color)
            Hover_ForeColor = value
            Me.Invalidate()
        End Set
    End Property

    Public Property MousePressedBackColor() As Color
        Get
            Return Pressed_BackColor
        End Get
        Set(ByVal value As Color)
            Pressed_BackColor = value
            Me.Invalidate()
        End Set
    End Property

    Public Property MousePressedForeColor() As Color
        Get
            Return Pressed_ForeColor
        End Get
        Set(ByVal value As Color)
            Pressed_ForeColor = value
            Me.Invalidate()
        End Set
    End Property

    Public Property BorderColors() As Color
        Get
            Return Me.FlatAppearance.BorderColor
        End Get
        Set(ByVal value As Color)
            Me.FlatAppearance.BorderColor = value
        End Set
    End Property

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

    Private _ImageSize As Size = New Size(24, 24)
    ''' <summary>
    ''' Get or Set the Image Size for MBGlassButton
    ''' </summary>
    <Category("MBGlassButton Image Settings"), _
    Description("Set Image Size of MBGlassButton"), _
    DefaultValue("24,24"), Browsable(True)> _
    Public Property ImageSize() As Size
        Get
            Return _ImageSize
        End Get
        Set(ByVal value As Size)
            If value.Width > 64 Or value.Height > 64 Then
                MsgBox("Image size is too large.")
                _ImageSize = New Size(24, 24)
            Else
                _ImageSize = value
            End If
        End Set
    End Property

    Public Sub New()
        MyBase.New()

        Me.FlatStyle = Forms.FlatStyle.Flat
        Me.FlatAppearance.BorderColor = BorderColor
        Me.FlatAppearance.BorderSize = 1
        Me.BackColor = Normal_BackColor
        Me.ForeColor = Normal_ForeColor
        Me.Height = 30

        myDColor.getDefaultColor(SampleColor)
        set_color_properties()

        myImage_ = Me.Image
    End Sub

    Private Sub set_default_value()
        JqueryMobileIcon = myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        JqueryIcon = myIcons.Share.Jquery.JqueryIconTypes.NotSet
        JqueryIconColor = myIcons.Share.Jquery.JqueryIconColor.Black
    End Sub

    Private Sub set_color_properties()
        Normal_BackColor = myDColor.gBackColor
        Normal_ForeColor = myDColor.gForeColor
        Pressed_BackColor = myDColor.gPressedBackColor
        Pressed_ForeColor = myDColor.gPressedForeColor
        Hover_BackColor = myDColor.gHoverBackColor
        Hover_ForeColor = myDColor.gHoverForeColor

        Me.BackColor = Normal_BackColor
        Me.ForeColor = Normal_ForeColor
        Me.FlatAppearance.MouseDownBackColor = Pressed_BackColor
        'Me.FlatAppearance.MouseOverBackColor = Hover_BackColor
        Me.FlatAppearance.MouseOverBackColor = myColor.Share.Tools.Brightness.Apply(Normal_BackColor, sBUTTON)
        If Me.IconTypes = myIcons.Share.General.IconLibraryTypes.JqueryMobile And Me.JqueryMobileIcon <> myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet Then
            Me.Image = myImage.Share.Controls.Buttons.Icon.resizeJqueryMobileImageButton(Me.JqueryMobileIconTypes, _ImageSize.Width, _ImageSize.Height, JqueryMobileIconColor)
        ElseIf Me.IconTypes = myIcons.Share.General.IconLibraryTypes.Jquery And Me.JqueryIconTypes <> myIcons.Share.Jquery.JqueryIconTypes.NotSet Then
            Me.Image = myImage.Share.Controls.Buttons.Icon.resizeJqueryImageButton(Me.JqueryIconTypes, _ImageSize.Width, _ImageSize.Height, Me.JqueryIconColorHover)
        ElseIf Me.Windows8Icon <> myIcons.Share.Windows8.Windows8IconTypes.NotSet Then
            Me.Image = myImage.Share.Controls.Buttons.Icon.resizeWindows8ImageButton(Me.Windows8Icon, _ImageSize.Width, _ImageSize.Height, Normal_BackColor)
        End If

    End Sub

    Protected Overrides Sub OnMouseDown(ByVal mevent As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(mevent)
        If Me.Enabled Then
            Me.ForeColor = myColor.Share.Tools.Brightness.Apply(Normal_BackColor, sBUTTON)
            BorderColor = Color.Red
            Me.BorderColor = BorderColor

            If Me.IconTypes = myIcons.Share.General.IconLibraryTypes.JqueryMobile And Me.JqueryMobileIcon <> myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet Then
                Me.Image = myImage.Share.Controls.Buttons.Icon.resizeJqueryMobileImageButton(Me.JqueryMobileIconTypes, _ImageSize.Width, _ImageSize.Height, JqueryMobileIconColor)
            ElseIf Me.JqueryIconTypes <> myIcons.Share.Jquery.JqueryIconTypes.NotSet Then
                Me.Image = myImage.Share.Controls.Buttons.Icon.resizeJqueryImageButton(Me.JqueryIconTypes, _ImageSize.Width, _ImageSize.Height, myIcons.Share.JqueryMobile.JqueryMobileImageSelect.Hover, JqueryIconColor)
            ElseIf Me.Windows8Icon <> myIcons.Share.Windows8.Windows8IconTypes.NotSet Then
                Me.Image = myImage.Share.Controls.Buttons.Icon.resizeWindows8ImageButton(Me.Windows8Icon, _ImageSize.Width, _ImageSize.Height, Hover_BackColor, myIcons.Share.JqueryMobile.JqueryMobileImageSelect.Hover, "hover")
            End If
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal mevent As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(mevent)
        If Me.Enabled Then
            Me.ForeColor = myDColor.gHoverForeColor
            Me.BorderColor = Color.White

            If Me.IconTypes = myIcons.Share.General.IconLibraryTypes.JqueryMobile And Me.JqueryMobileIcon <> myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet Then
                Me.Image = myImage.Share.Controls.Buttons.Icon.resizeJqueryMobileImageButton(Me.JqueryMobileIconTypes, _ImageSize.Width, _ImageSize.Height, JqueryMobileIconColor)
            ElseIf Me.JqueryIconTypes <> myIcons.Share.Jquery.JqueryIconTypes.NotSet Then
                Me.Image = myImage.Share.Controls.Buttons.Icon.resizeJqueryImageButton(Me.JqueryIconTypes, _ImageSize.Width, _ImageSize.Height, myIcons.Share.JqueryMobile.JqueryMobileImageSelect.Normal, Me.JqueryIconColorHover)
            ElseIf Me.Windows8Icon <> myIcons.Share.Windows8.Windows8IconTypes.NotSet Then
                Me.Image = myImage.Share.Controls.Buttons.Icon.resizeWindows8ImageButton(Me.Windows8Icon, _ImageSize.Width, _ImageSize.Height, Normal_BackColor)
            End If
        End If
    End Sub


    Protected Overrides Sub OnMouseMove(ByVal mevent As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(mevent)
        If Me.Enabled Then
            Me.Cursor = Cursors.Hand
        End If
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        MyBase.OnMouseLeave(e)
        If Me.Enabled Then
            Me.Cursor = Cursors.Arrow
            If Me.IconTypes = myIcons.Share.General.IconLibraryTypes.JqueryMobile And Me.JqueryMobileIcon <> myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet Then
                Me.Image = myImage.Share.Controls.Buttons.Icon.resizeJqueryMobileImageButton(Me.JqueryMobileIconTypes, _ImageSize.Width, _ImageSize.Height, JqueryMobileIconColor)
            ElseIf Me.IconTypes = myIcons.Share.General.IconLibraryTypes.Jquery And Me.JqueryIconTypes <> myIcons.Share.Jquery.JqueryIconTypes.NotSet Then
                Me.Image = myImage.Share.Controls.Buttons.Icon.resizeJqueryImageButton(Me.JqueryIconTypes, _ImageSize.Width, _ImageSize.Height, Me.JqueryIconColorHover)
            ElseIf Me.Windows8Icon <> myIcons.Share.Windows8.Windows8IconTypes.NotSet Then
                Me.Image = myImage.Share.Controls.Buttons.Icon.resizeWindows8ImageButton(Me.Windows8Icon, _ImageSize.Width, _ImageSize.Height, Normal_BackColor)
            End If
        End If
    End Sub


    Protected Overrides Sub OnEnabledChanged(ByVal e As System.EventArgs)
        MyBase.OnEnabledChanged(e)
        If Me.Enabled Then
            Me.BackColor = myDColor.gBackColor
        Else
            Dim d As New myColor.Share.SystemColor.BackgroundColor.StandardColor
            d.getDefaultColor(myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Disabled)
            Me.BackColor = d.gBackColor
            Me.ForeColor = d.gForeColor
        End If
    End Sub

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        If Not Me.Image Is Nothing Then
            If Me.IconTypes = myIcons.Share.General.IconLibraryTypes.JqueryMobile And Me.JqueryMobileIcon <> myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet Then
                Me.Image = myImage.Share.Controls.Buttons.Icon.resizeJqueryMobileImageButton(Me.JqueryMobileIconTypes, _ImageSize.Width, _ImageSize.Height, JqueryMobileIconColor)
            ElseIf Me.IconTypes = myIcons.Share.General.IconLibraryTypes.Jquery And Me.JqueryIconTypes <> myIcons.Share.Jquery.JqueryIconTypes.NotSet Then
                Me.Image = myImage.Share.Controls.Buttons.Icon.resizeJqueryImageButton(Me.JqueryIconTypes, _ImageSize.Width, _ImageSize.Height, Me.JqueryIconColorHover)
            ElseIf Me.Windows8Icon <> myIcons.Share.Windows8.Windows8IconTypes.NotSet Then
                Me.Image = myImage.Share.Controls.Buttons.Icon.resizeWindows8ImageButton(Me.Windows8Icon, _ImageSize.Width, _ImageSize.Height, Normal_BackColor)
            End If
            'DrawImage()
            Me.Refresh()
        End If
    End Sub

End Class

