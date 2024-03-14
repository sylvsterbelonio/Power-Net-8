Public Class frmPanelSettings
    Private action As String
    Private intro_value As Double = 0
    Private max_opacity As Double = 1
    Private timer_ As New Timer
    Private leftAnimate As Integer
    Public incrementor As Double = 0.05

    Private Sub faDeIn()
        Me.Left = Me.Left + 10
        timer_.Interval = 1
        'incrementor = 0.08
        'max_opacity = 0.75
        action = "fade in"
        timer_.Enabled = True
        timer_.Start()
        AddHandler timer_.Tick, AddressOf Timer_Tick
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If action = "fade in" Then
            If intro_value >= max_opacity Then
                timer_.Stop()
                'action = "fade out"
                'timer_.Start()
                pnlIcon1.Visible = True
                pnlIcon2.Visible = True
                pnlIcon3.Visible = True
                pnlIcon4.Visible = True
                pnlIcon5.Visible = True
            End If
            intro_value += CDbl(incrementor)
        ElseIf action = "fade out" Then
            If intro_value <= 0 Then
                timer_.Stop()
                Me.Close()
            End If
            Me.Left += 2
            intro_value -= CDbl(incrementor)
        End If
        Me.Opacity = intro_value
    End Sub

    Public Sub faDeOut()
        'Me.Left = Me.Left + 50
        timer_.Interval = 1
        'incrementor = 0.08
        'max_opacity = 0.75
        action = "fade out"
        timer_.Enabled = True
        timer_.Start()
        AddHandler timer_.Tick, AddressOf Timer_Tick
    End Sub

    Private Sub frmPanelSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        faDeIn()
        autoArrangeIcon()
    End Sub

    Private Sub autoArrangeIcon()
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim topPos = screenHeight - 375
        Dim lefPos = screenWidth - 75

        With pnlIcon1
            .Left = 0
            Icon1.Left = 25
            .Width = Me.Width
            .Top = topPos - 300
            .Visible = False
        End With
        With pnlIcon2
            .Left = 0
            Icon2.Left = 25
            .Width = Me.Width
            .Top = topPos - 225
            .Visible = False
        End With
        With pnlIcon3
            .Left = 0
            Icon3.Left = 25
            .Width = Me.Width
            .Top = topPos - 150
            .Visible = False
        End With
        With pnlIcon4
            .Left = 0
            Icon4.Left = 25
            .Width = Me.Width
            .Top = topPos - 75
            .Visible = False
        End With
        With pnlIcon5
            .Left = 0
            Icon5.Left = 25
            .Width = Me.Width
            .Top = topPos
            .Visible = False
        End With

    End Sub

    Private Sub frmPanelSettings_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        beginJudgeToFadeOut()
    End Sub


#Region "JUDGE TIMER"

    Private JudgeSec As Integer = 1
    Private JudgeInc As Integer = 0
    Private JudgeTimer As New Timer
    Private Sub beginJudgeToFadeOut()
        JudgeTimer = New Timer
        JudgeTimer.Interval = 1000
        JudgeInc = 0
        AddHandler JudgeTimer.Tick, AddressOf FadeOutJudge_Tick
        JudgeTimer.Start()
    End Sub
    Private Sub FadeOutJudge_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If JudgeInc <= JudgeSec Then
            JudgeInc += 1
        Else
            sender.stop()
            'MsgBox("hide this!")
            hidePanel()
        End If
    End Sub

#End Region

    Private Sub hidePanel()
        faDeOut()
    End Sub

    Private myVal As New myColor.Share.Converter.StringToColor
    Private hoverColor As String = "#232626"
    Private normalColor As String = "#000000"

    Private Sub pnlIcon1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlIcon1.MouseLeave, pnlIcon2.MouseLeave, pnlIcon3.MouseLeave, pnlIcon4.MouseLeave, pnlIcon5.MouseLeave
        CType(sender, Panel).Cursor = Cursors.Hand
        sender.backcolor = myColor.Share.Converter.StringToColor.getHTMLColor(normalColor)
        beginJudgeToFadeOut()
    End Sub

    Private Sub pnlIcon1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlIcon1.MouseMove, pnlIcon2.MouseMove, pnlIcon3.MouseMove, pnlIcon4.MouseMove, pnlIcon5.MouseMove
        CType(sender, Panel).Cursor = Cursors.Hand
        sender.backcolor = myColor.Share.Converter.StringToColor.getHTMLColor(hoverColor)
        JudgeTimer.Stop()
    End Sub

    Private Sub Icon1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Icon1.MouseLeave, Icon2.MouseLeave, Icon3.MouseLeave, Icon4.MouseLeave, Icon5.MouseLeave
        CType(sender, PictureBox).Cursor = Cursors.Default
        Select Case CType(sender, PictureBox).Name
            Case "Icon1"
                pnlIcon1.BackColor = myColor.Share.Converter.StringToColor.getHTMLColor(normalColor)
            Case "Icon2"
                pnlIcon2.BackColor = myColor.Share.Converter.StringToColor.getHTMLColor(normalColor)
            Case "Icon3"
                pnlIcon3.BackColor = myColor.Share.Converter.StringToColor.getHTMLColor(normalColor)
            Case "Icon4"
                pnlIcon4.BackColor = myColor.Share.Converter.StringToColor.getHTMLColor(normalColor)
            Case "Icon5"
                pnlIcon5.BackColor = myColor.Share.Converter.StringToColor.getHTMLColor(normalColor)
        End Select
        JudgeTimer.Stop()
    End Sub

    Private Sub Icon1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Icon1.MouseMove, Icon2.MouseMove, Icon3.MouseMove, Icon4.MouseMove, Icon5.MouseMove
        CType(sender, PictureBox).Cursor = Cursors.Hand
        Select Case CType(sender, PictureBox).Name
            Case "Icon1"
                pnlIcon1.BackColor = myColor.Share.Converter.StringToColor.getHTMLColor(hoverColor)
            Case "Icon2"
                pnlIcon2.BackColor = myColor.Share.Converter.StringToColor.getHTMLColor(hoverColor)
            Case "Icon3"
                pnlIcon3.BackColor = myColor.Share.Converter.StringToColor.getHTMLColor(hoverColor)
            Case "Icon4"
                pnlIcon4.BackColor = myColor.Share.Converter.StringToColor.getHTMLColor(hoverColor)
            Case "Icon5"
                pnlIcon5.BackColor = myColor.Share.Converter.StringToColor.getHTMLColor(hoverColor)
        End Select
        JudgeTimer.Stop()
    End Sub

    Private Sub frmPanelSettings_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        JudgeTimer.Stop()
    End Sub

    Private Sub Icon1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Icon1.Click
        Select Case CType(sender, PictureBox).Name
            Case "Icon1"

        End Select
    End Sub
End Class