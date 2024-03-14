Public Class frmThemeColorSample

    Private Sub BackgroundColor1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackgroundColor1.Load

    End Sub

    Private Sub colorpick_(ByVal color As Color) Handles BackgroundColor1.ColorPicked
        My8Button1.BackColor = color
        My8Button2.BackColor = color
        My8Button3.BackColor = color
    End Sub

    Private Sub AccentColorPciked(ByVal color As Color) Handles AccentColor1.ColorPicked
        My8Button1.MouseOverBackcolor = color
        My8Button2.MouseOverBackcolor = color
        My8Button3.MouseOverBackcolor = color
    End Sub

    Private Sub frmThemeColorSample_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class