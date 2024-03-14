Public Class frmThemeSampler
    Dim timer As New Timer
    Shadows backColor As Color
    Dim accentColor As Color
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub bColor(ByVal color As Color) Handles BackgroundColor1.ColorPicked
        backColor = color
    End Sub
    Private Sub cColor(ByVal color As Color) Handles AccentColor1.ColorPicked
        accentColor = color
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PowerNET8.myFunctions.Share.Themes.GetThemes(Me, timer, "sylvster")
        PowerNET8.myFunctions.Share.Themes.GetThemesContextMenuStrip(ContextMenuStrip1, "sylvster")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim STheme As New PowerNET8.myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue
        STheme.backgroundColor = PowerNET8.myColor.Share.Converter.ColorToString.getHTMLColor(backColor)
        STheme.backgroundColor_mainValue = BackgroundColor1.getColorTagName
        STheme.backgroundCOlor_subValue = BackgroundColor1.getGroupNameTag

        STheme.accentColor = PowerNET8.myColor.Share.Converter.ColorToString.getHTMLColor(accentColor)
        STheme.accentColor_mainValue = AccentColor1.getColorTagName
        STheme.accentColor_subValue = AccentColor1.getGroupNameTag

        STheme.form_backColor = "FAFBFB"
        STheme.form_borderColor = "E1A61E"

        PowerNET8.myDocument.Share.XMLDesigner.ThemesConfig.updateThemes("sylvster", STheme)
        MsgBox("Save themes")
    End Sub

    Private Sub frmThemeSampler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MenuStrip1.BackColor = PowerNET8.myColor.Share.Tools.Brightness.Apply(backColor, ToolStripTextBox2.Text)
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ToolStrip1.BackColor = PowerNET8.myColor.Share.Tools.Brightness.Apply(backColor, ToolStripTextBox1.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        pnlContent.BackColor = PowerNET8.myColor.Share.Tools.Brightness.Apply(backColor, TextBox2.Text)
    End Sub

    Dim Move As Boolean = True
    Dim Leave As Boolean = True

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Move = True
        If Leave Then
            Leave = False
            PowerNET8.myVisualEffects.ColorFadeEffects.AddEffects(Button2, "BackColor", Color.Blue, Color.Blue, 25, Color.White, 25, 5)
        End If
    End Sub


    Private Sub Button2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseMove
        If Move Then
            Leave = True
            Move = False
            PowerNET8.myVisualEffects.ColorFadeEffects.AddEffects(Button2, "BackColor", Color.White, Color.Blue, 25, Color.Blue, 25, 10)
        End If
    End Sub

    Private Sub BackgroundColor2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub My8TextBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles My8TextBox1.Load

    End Sub

    Private Sub searchEvent(ByVal value As String) Handles My8TextBox1.SearchValue
        MsgBox(value)
    End Sub

End Class