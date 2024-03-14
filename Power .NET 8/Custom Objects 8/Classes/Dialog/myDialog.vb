Imports System.ComponentModel
Namespace myDialog


    Public Class messageBoxes

#Region "PROPERTIES"

        Enum DialogStyle
            MsgBox
            DialogBox
            PlainDialog
            WindowsDialog8
            WideDialog8
        End Enum
        Enum Mode
            enable
            disable
        End Enum

        Private _dialogStyle As DialogStyle = DialogStyle.MsgBox
        Private _shadowBground As Mode = Mode.disable
        Private _DialogShadowAttributes As DialogShadowAttributes = Nothing
        Private _userThemes As String = "sylvster"

        Public Property setUserThemes() As String
            Get
                Return _userThemes
            End Get
            Set(ByVal value As String)
                _userThemes = value
            End Set
        End Property
        Public Property setShadowBackground() As Mode
            Get
                Return _shadowBground
            End Get
            Set(ByVal value As Mode)
                _shadowBground = value
            End Set
        End Property 'activates the shadow background style
        Public Property setDialogBoxStyle() As DialogStyle
            Get
                Return _dialogStyle
            End Get
            Set(ByVal value As DialogStyle)
                _dialogStyle = value
            End Set
        End Property
        Public Property setShadowProperties() As DialogShadowAttributes
            Get
                Return _DialogShadowAttributes
            End Get
            Set(ByVal value As DialogShadowAttributes)
                _DialogShadowAttributes = value
            End Set
        End Property

#End Region

#Region "FUNCTIONS"

        Private Sub setRendererDialog()

        End Sub


#End Region

        ''' <summary>
        ''' It overrides the message box of the system to call the windows 8 platform.
        ''' </summary>
        ''' <param name="content">Set the message content</param>
        ''' <param name="title">Set the title of the message</param>
        ''' <param name="style">Set the dialog style</param>
        ''' <param name="icons">Set the icon type</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function show(Optional ByVal content As String = "", Optional ByVal title As String = "The system said:", Optional ByVal style As MessageBoxButtons = MessageBoxButtons.OK, Optional ByVal icons As MessageBoxIcon = MessageBoxIcon.None, Optional ByVal dialogWidth As Integer = 334, Optional ByVal dialogHeight As Integer = 114) As DialogResult

            Dim DialogAttributes As New DialogAttributes
            If _DialogShadowAttributes Is Nothing Then
                Dim dx As New DialogShadowAttributes
                _DialogShadowAttributes = dx
            End If
            With DialogAttributes
                .content = content
                .title = title
                .style = style
                .icons = icons
                .DialogWidth = dialogWidth
                .DialogHeight = dialogHeight
                .messageBoxes = _dialogStyle
                .userThemes = _userThemes
            End With
            If _dialogStyle = DialogStyle.MsgBox Then
                If _shadowBground = Mode.enable Then
                    Dim shadow As New BackShadow
                    Return shadow.applyDialogBox(DialogAttributes, _DialogShadowAttributes, "masterkey")
                Else
                    Return MsgBox(content, style, title)
                End If
            ElseIf _dialogStyle = DialogStyle.DialogBox Then
                If _shadowBground = Mode.enable Then
                    Dim shadow As New BackShadow
                    Return shadow.applyDialogBox(DialogAttributes, _DialogShadowAttributes, "masterkey")
                Else
                    Return MessageBox.Show(content, title, style, icons)
                End If
            ElseIf _dialogStyle = DialogStyle.PlainDialog Then
                If _shadowBground = Mode.enable Then
                    Dim shadow As New BackShadow
                    Return shadow.applyCustomDialog(DialogAttributes, _DialogShadowAttributes, "masterkey")
                Else
                    Dim frm As New PDB(content, title, style, icons, DialogAttributes.DialogWidth, DialogAttributes.DialogHeight)
                    frm.userThemes = _userThemes
                    frm.Opacity = 0
                    frm.runCode = "masterkey"
                    frm.typeDialog = "plain"
                    frm.ShowDialog()
                    Return frm.return_values
                End If
            ElseIf _dialogStyle = DialogStyle.WindowsDialog8 Then
                If _shadowBground = Mode.enable Then
                    Dim shadow As New BackShadow
                    Return shadow.applyCustomDialog(DialogAttributes, _DialogShadowAttributes, "masterkey")
                Else
                    Dim frm As New PDB(content, title, style, icons, DialogAttributes.DialogWidth, DialogAttributes.DialogHeight)
                    frm.userThemes = _userThemes
                    frm.Opacity = 0
                    frm.runCode = "masterkey"
                    frm.typeDialog = "windows8"
                    frm.Width += 10
                    frm.ShowDialog()
                    Return frm.return_values
                End If
            End If

        End Function

        Public Sub show(ByVal content As Form, Optional ByVal title As String = "The system said:")
            Dim frm As New PDB
            Dim DialogAttributes As New DialogAttributes
            With DialogAttributes
                .form = content
                .title = title
            End With

            If _dialogStyle = DialogStyle.MsgBox Then
                content.Text = title
                content.ShowDialog()
                'MsgBox(content, style, title)
            ElseIf _dialogStyle = DialogStyle.DialogBox Then
                content.Text = title
                content.ShowDialog()
            ElseIf _dialogStyle = DialogStyle.PlainDialog Then
                frm.runCode = "masterkey"
                frm.ShowDialog()
            End If

        End Sub

        Public Function show_form(ByRef frmz As Form, Optional ByVal title As String = "", Optional ByVal speed As Double = 0.05, Optional ByVal opacity As Double = 0.75)
            Dim Shadow As New frmShadow
            With Shadow
                .set_form(frmz, title, speed, opacity)
                .ShowInTaskbar = False
                ._DialogShadowAttributes = _DialogShadowAttributes
                .ShowDialog()
                Return .return_value
            End With
        End Function

    End Class



    Public Class DialogAttributes
        Public content As String
        Public title As String
        Public style As MessageBoxButtons
        Public icons As MessageBoxIcon
        Public form As Form
        Public messageBoxes As messageBoxes.DialogStyle
        Public DialogWidth As Integer = 334
        Public DialogHeight As Integer = 114
        Public userThemes As String = ""
    End Class

    Public Class DialogShadowAttributes
        Public opacity As Double = 0
        Public maxOpacity As Double = 0.75
        Public backColor As Color = Color.Black
        Public imageBackGround As Image = Nothing
        Public speed As Double = 0.05
        Public incrementor As Double = 0.04
    End Class

    Public Class BackShadow
        Dim frm As New S

        Public Function applyDialogBox(ByVal DialogAttributes As DialogAttributes, ByVal DialogShadowAttributes As DialogShadowAttributes, Optional ByVal runCode As String = "") As DialogResult
            If runCode = "masterkey" Then
                With frm
                    .Opacity = DialogShadowAttributes.opacity
                    .BackColor = DialogShadowAttributes.backColor
                    .incrementor = DialogShadowAttributes.incrementor
                    .DialogAttributes = DialogAttributes
                    .max_opacity = DialogShadowAttributes.maxOpacity
                    .speed = DialogShadowAttributes.speed
                    .runCode = "masterkey"
                    .ShowInTaskbar = False
                    .type_view = "dialog"
                    If Not DialogShadowAttributes.imageBackGround Is Nothing Then
                        .BackgroundImage = DialogShadowAttributes.imageBackGround
                        .BackgroundImageLayout = ImageLayout.Tile
                    End If
                    .ShowDialog()
                    Return .return_value_dialog
                End With
            Else
                activationRequired("BackShawdowHolder.Apply")
            End If
        End Function

        Public Function applyCustomDialog(ByVal DialogAttributes As DialogAttributes, ByVal DialogShadowAttributes As DialogShadowAttributes, Optional ByVal runCode As String = "") As DialogResult
            If runCode = "masterkey" Then
                With frm
                    .Opacity = DialogShadowAttributes.opacity
                    .BackColor = DialogShadowAttributes.backColor
                    .incrementor = DialogShadowAttributes.incrementor
                    .DialogAttributes = DialogAttributes
                    .max_opacity = DialogShadowAttributes.maxOpacity
                    .speed = DialogShadowAttributes.speed
                    .runCode = "masterkey"
                    .ShowInTaskbar = False
                    .type_view = "dialog"
                    If Not DialogShadowAttributes.imageBackGround Is Nothing Then
                        .BackgroundImage = DialogShadowAttributes.imageBackGround
                        .BackgroundImageLayout = ImageLayout.Tile
                    End If
                    .ShowDialog()
                    Return .return_value_dialog
                End With
            Else
                activationRequired("BackShawdowHolder.Apply")
            End If
        End Function

    End Class

    Public Class formBox

    End Class






End Namespace

