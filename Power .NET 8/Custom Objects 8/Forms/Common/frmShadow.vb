Public Class frmShadow
    'THIS IS SHADOW FORM I MADE FOR INTERACTIVE VISUAL EFFECTS IN PROGRAMMING - Jan 17, 2013'
    Friend myObject As New MyObject

    Private colobjects As New Collection
    Private intro_value As Double = 0
    Private action As String
    Private windows_form As Form
    Private type_view As String
    Private msg As String
    Private title_ As String
    Private max_opacity As Double
    Private speed As Integer = 1
    Private timer_ As New Timer
    Private content_ As String
    Private style_ As MessageBoxButtons
    Private icons_ As MessageBoxIcon
    Private dialogs As Form
    Private MyForm As Form
    'Private myThm As CustomObjects.MyObject.ThemeNames
    Private myPicture As Image = Nothing
    Public object_type As String = ""
    Public return_value = ""
    Public return_value_dialog As DialogResult
    Public incrementor As Double


    Enum Style
        Standard
        Shadow
    End Enum

    Public _DialogShadowAttributes As myDialog.DialogShadowAttributes


    Public Sub set_image_background(ByVal bm As Image)
        myPicture = bm
    End Sub

    Public Sub set_class(Optional ByVal content As String = "", Optional ByVal title As String = "The system said", Optional ByVal style As MessageBoxButtons = MessageBoxButtons.OK, Optional ByVal icons As MessageBoxIcon = MessageBoxIcon.None, Optional ByVal type As String = "dialog", Optional ByVal speed As Double = 0.05, Optional ByVal dialog As Form = Nothing)


        type_view = type
        style_ = style
        content_ = content
        icons_ = icons
        title_ = title
        incrementor = speed
        dialogs = dialog
        myObject.get_all_objects_data(colobjects, New Form)
        'myObject.load(colobjects, themes)

        'this is to set image manually///
        If Not myPicture Is Nothing Then
            Me.BackgroundImage = myPicture
        End If

    End Sub

    Public Sub set_form(ByRef fmz As Form, Optional ByVal title As String = "", Optional ByVal speed As Double = 0.05, Optional ByVal opacity As Double = 0.75)
        If title <> "" Then fmz.Text = title
        type_view = "form"
        windows_form = fmz
        'myThm = themes
        max_opacity = opacity
        myObject.get_all_objects_data(colobjects, New Form)
        'myObject.load(colobjects, themes)
        incrementor = speed
    End Sub

    Private Sub frmShadow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Nothing
        Me.ControlBox = False
        Me.BackColor = _DialogShadowAttributes.backColor
        timer_.Interval = 1
        'incrementor = 0.08
        'max_opacity = 0.75

        action = "fade in"
        timer_.Enabled = True
        timer_.Start()
        AddHandler timer_.Tick, AddressOf Timer_Tick
    End Sub

#Region "CLOCK EVENT"

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If action = "fade in" Then
            If intro_value >= max_opacity Then
                timer_.Stop()
                If type_view = "form" Then
                    With windows_form
                        .ShowDialog()
                        Dim str_msg() As String = .Text.Split("-")
                        If str_msg.Length > 1 Then return_value = str_msg(1)
                    End With
                ElseIf type_view = "dialog" Then
                    'return_value = myDialog.show_dialog(msg, title, msgButton, msgiCon)
                    With dialogs
                        'dialogs = New frmDialogBox(content_, title_, style_, icons_, )
                        '.ShowDialog()
                        'return_value = dialogs
                    End With
                End If
                action = "fade out"
                timer_.Start()
            End If
            intro_value += CDbl(incrementor)
        ElseIf action = "fade out" Then
            If intro_value <= 0 Then
                timer_.Stop()
                Me.Close()
            End If
            intro_value -= CDbl(incrementor)
        End If
        Me.Opacity = intro_value
    End Sub

#End Region

End Class