Public Class frmMain



    Private Sub Sample1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sample1ToolStripMenuItem.Click
        Dim a As New frmSample
        PowerNET8.myControls.Share.Forms.childForm.load(Me, a)

    End Sub

    Private Sub ModuleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModuleToolStripMenuItem.Click

    End Sub
End Class