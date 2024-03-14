Public Class windows8Button
    Private Sub My8Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My8Button9.BackColor = myValidation.Share.ColorReader.readHTMLColor("#A4A8AA")
        My8Button9.ForeColor = myValidation.Share.ColorReader.readHTMLColor("#FFFFFF")
        My8Button9.ForeColor = Color.White
    End Sub

    Private Sub windows8Button_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My8Button9.BackColor = myValidation.Share.ColorReader.readHTMLColor("#A4A8AA")
        My8Button9.ForeColor = myValidation.Share.ColorReader.readHTMLColor("#FFFFFF")
        My8Button9.ForeColor = Color.White
    End Sub
End Class
