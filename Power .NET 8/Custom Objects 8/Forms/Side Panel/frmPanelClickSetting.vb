Public Class frmPanelClickSetting

    Private allow_showIcon As Boolean = False
    Private Icon1 As New frmTransparentIcon
    Private Icon2 As New frmTransparentIcon
    Private Icon3 As New frmTransparentIcon
    Private Icon4 As New frmTransparentIcon
    Private Icon5 As New frmTransparentIcon
    Public frm As Form

    Public Sub set_BasedForm(ByRef frmz As Form)
        frm = frmz
    End Sub

    Private Sub frmPanelSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Icon1.ImageSource = My.Resources.alarm
        'Icon2.ImageSource = My.Resources.alarm
        'Icon3.ImageSource = My.Resources.alarm
        'Icon4.ImageSource = My.Resources.alarm
        'Icon5.ImageSource = My.Resources.alarm
    End Sub


#Region "HIDE ICONS"



#End Region

    Public Sub hideIcons()
        Icon1.faDeOut()
        Icon2.faDeOut()
        Icon3.faDeOut()
        Icon4.faDeOut()
        Icon5.faDeOut()
        allow_showIcon = False
    End Sub

#Region "SHOW ICONS"

    Private Sub showIcons()
        If allow_showIcon = False Then
            Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
            Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

            Dim topPos = screenHeight - 375
            Dim lefPos = screenWidth - 75

            Icon1 = New frmTransparentIcon
            With Icon1
                .Left = lefPos
                .Top = topPos - 300
                .Owner = frm
                .Opacity = 0
                .Show()
            End With
            Icon2 = New frmTransparentIcon
            With Icon2
                .Left = lefPos
                .Top = topPos - 225
                .Owner = frm
                .Opacity = 0
                .Show()
            End With
            Icon3 = New frmTransparentIcon
            With Icon3
                .Left = lefPos
                .Top = topPos - 150
                .Owner = frm
                .Opacity = 0
                .Show()
            End With
            Icon4 = New frmTransparentIcon
            With Icon4
                .Left = lefPos
                .Top = topPos - 75
                .Owner = frm
                .Opacity = 0
                .Show()
            End With
            Icon5 = New frmTransparentIcon
            With Icon5
                .Left = lefPos
                .Top = topPos
                .Owner = frm
                .Opacity = 0
                .Show()
            End With
            slide_in_icon()
        End If
    End Sub

#End Region

    Private Sub frmPanelSetting_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        showIcons()
    End Sub

    Private Animate_1st As Integer
    Private Animate_2nd As Integer
    Private Animate_3rd As Integer
    Private Animate_4th As Integer
    Private inc_width As Integer = 75

    Private Sub slide_in_icon()
        max_width = 60
        calculate_animation(max_width)
        Dim timerx As New Timer
        timerx.Start()
        timerx.Interval = 1
        AddHandler timerx.Tick, AddressOf ShowPanel_Tick
    End Sub

    Private Sub calculate_animation(ByVal value As Integer)
        Animate_1st = Val(CDbl(value) * 0.89)
        Animate_2nd = Val(CDbl(value) * 0.9)
        Animate_3rd = Val(CDbl(value) * 0.95)
        Animate_4th = Val(CDbl(value) * 0.97)
    End Sub

    Private max_width As Integer = 60
    Private deductions As Integer = 0

    Private Sub ShowPanel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If max_width > 0 Then
            If max_width >= Animate_1st Then
                max_width -= 9
                Icon1.Left -= 9
                Icon2.Left -= 9
                Icon3.Left -= 9
                Icon4.Left -= 9
                Icon5.Left -= 9
            ElseIf max_width >= Animate_2nd Then
                max_width -= 9
                Icon1.Left -= 9
                Icon2.Left -= 9
                Icon3.Left -= 9
                Icon4.Left -= 9
                Icon5.Left -= 9
            ElseIf max_width >= Animate_3rd Then
                max_width -= 9
                Icon1.Left -= 9
                Icon2.Left -= 9
                Icon3.Left -= 9
                Icon4.Left -= 9
                Icon5.Left -= 9
            ElseIf max_width >= Animate_4th Then
                max_width -= 5
                Icon1.Left -= 5
                Icon2.Left -= 5
                Icon3.Left -= 5
                Icon4.Left -= 5
                Icon5.Left -= 5
            Else
                max_width -= 5
                Icon1.Left -= 5
                Icon2.Left -= 5
                Icon3.Left -= 5
                Icon4.Left -= 5
                Icon5.Left -= 5
            End If
        Else
            sender.Stop()
            allow_showIcon = True
            beginJudgeToFadeOut()
            'isEnteredToPicture = False
        End If
    End Sub

    Private isGoingtoFadeOut As Boolean = False

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave

        ' MsgBox("show panel")
        JudgeTimer.Stop()
        'hideIcons()


        Dim slide As New myVisualEffects.myVisualEffects
        Dim frmPanel As New frmPanelSettings
        frmPanel.Owner = frm
        slide.side_bar(frmPanel, Me)

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
            hideIcons()
        End If
    End Sub

#End Region

    Private Sub frmPanelSetting_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        isGoingtoFadeOut = True
    End Sub

    Private Sub frmPanelSetting_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        isGoingtoFadeOut = False
    End Sub

End Class