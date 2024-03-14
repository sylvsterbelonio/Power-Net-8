
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'txtSearch.Text = "asdasdas"
    End Sub

    Private Sub s(ByVal s As String)
        MsgBox(s)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim effect As New myVisualEffects.SlideRightEffects
        Dim col As New Collection
        With effect
            '.AddControl(Label1)
            '.AddControl(Label2)
            '.AddControl(Label3)
            '.AddControl(Label4)
            '.AddControl(Label5)

            '.AddControl(Label6)
            '.AddControl(Label7)
            '.AddControl(Label8)
            .AddEffects(60)
        End With

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim msgBoxs As New PowerNET8.myDialog.messageBoxes
        With msgBoxs
            .setUserThemes = "sylvster"
            .setDialogBoxStyle = myDialog.messageBoxes.DialogStyle.WindowsDialog8
            .setShadowBackground = myDialog.messageBoxes.Mode.enable
            Dim dx As New myDialog.DialogShadowAttributes
            If .show("Do you want to delete this file?", , MessageBoxButtons.OK, ) = Windows.Forms.DialogResult.Yes Then
                MsgBox("you yes")
            Else
                MsgBox("not")
            End If
        End With
    End Sub

    Private Sub My8TextBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Search(ByVal value As String)
        'do code here for searching a data.
        'use the value
        MsgBox(value)
    End Sub

    Private Sub My7GlassButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MsgBox(txtSearch.Text_)
    End Sub

    Private Sub My8TextBox1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class