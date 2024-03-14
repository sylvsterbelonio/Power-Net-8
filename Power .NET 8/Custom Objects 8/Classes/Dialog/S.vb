Public Class S
    Private action As String
    Dim Timer_ As New Timer
    'Friend myObject As New MyObject
    Private colobjects As New Collection
    Private intro_value As Double = 0
    Private windows_form As Form
    Public type_view As String
    Private msg As String
    Private title_ As String
    Public max_opacity As Double = 1
    Public speed As Integer = 1
    Private content_ As String
    Private style_ As MessageBoxButtons
    Private icons_ As MessageBoxIcon
    Private dialogs As Form

    'Private myThm As CustomObjects.MyObject.ThemeNames
    Private myPicture As Image = Nothing
    Public object_type As String = ""
    Public runCode As String = ""
    Public return_value = ""
    Public _userThemes As String
    Public return_value_dialog As DialogResult
    Public incrementor As Double = 0.2
    Public messageBoxes As myDialog.messageBoxes.DialogStyle
    Public DialogAttributes As myDialog.DialogAttributes

    Private Sub SWx_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If runCode = "masterkey" Then
            Me.ControlBox = False

            Timer_.Interval = 1
            'incrementor = 0.08
            'max_opacity = 0.75

            action = "fade in"
            Timer_.Enabled = True
            Timer_.Start()
            AddHandler Timer_.Tick, AddressOf Timer_Tick
        Else
            Me.Close()
            activationRequired("Shadow.Form")
        End If
    End Sub

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
                    Select Case DialogAttributes.messageBoxes
                        Case myDialog.messageBoxes.DialogStyle.MsgBox
                            With DialogAttributes
                                return_value_dialog = MsgBox(.content, .style, .title)
                            End With
                        Case myDialog.messageBoxes.DialogStyle.DialogBox
                            With DialogAttributes
                                return_value_dialog = MessageBox.Show(.content, .title, .style, .icons)
                            End With
                        Case myDialog.messageBoxes.DialogStyle.PlainDialog
                            Dim frm As New PDB(DialogAttributes.content, DialogAttributes.title, DialogAttributes.style, DialogAttributes.icons, DialogAttributes.DialogWidth, DialogAttributes.DialogHeight)
                            frm.userThemes = DialogAttributes.userThemes
                            frm.Opacity = 0
                            frm.runCode = "masterkey"
                            frm.typeDialog = "plain"
                            frm.ShowDialog()
                            return_value_dialog = frm.return_values
                        Case myDialog.messageBoxes.DialogStyle.WindowsDialog8
                            Dim frm As New PDB(DialogAttributes.content, DialogAttributes.title, DialogAttributes.style, DialogAttributes.icons, DialogAttributes.DialogWidth, DialogAttributes.DialogHeight)
                            frm.userThemes = DialogAttributes.userThemes
                            frm.Opacity = 0
                            frm.runCode = "masterkey"
                            frm.typeDialog = "windows8"
                            frm.Width += 10
                            frm.ShowDialog()
                            return_value_dialog = frm.return_values
                        Case myDialog.messageBoxes.DialogStyle.WideDialog8

                    End Select
                ElseIf type_view = "custom-dialog" Then
                    With DialogAttributes
                        Dim dialogs As New PDB(.content, .title, .style, .icons, 314, 114)
                        dialogs.ShowDialog()
                        return_value_dialog = dialogs.return_values
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
End Class