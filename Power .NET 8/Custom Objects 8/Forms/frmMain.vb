Public Class frmMain
    Dim myWin8 As New myVisualEffects.myVisualEffects

    Private Sub frmSettingsvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With myWin8
            'create an event to show panel settings
            .create_click_panel_event(Me)
        End With

    End Sub

    Private Sub frmSettingsvb_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.X = Me.Width And e.Y = 0 Then
            MsgBox("asd")
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        'Dim f As New Form1
        'f.Show()
    End Sub

End Class