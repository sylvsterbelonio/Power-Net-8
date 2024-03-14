Public Class mySystemLock

    Friend myAssembly As New myAssemblyInfo
    Dim frm As New frmSystemLock

    Public Sub set_Formbackcolor(ByVal cl As Color)
        frm.BackColor = cl
    End Sub

    Public Sub set_FormforeColor(ByVal cl As Color)
        frm.ForeColor = cl
    End Sub

    Public Sub run(ByRef basedForm As Form, ByRef mysql As mySQL.Init.SQL, ByRef asm As System.Reflection.Assembly, ByVal username As String, Optional ByVal table As String = "tblusers", Optional ByVal usernameCol As String = "username", Optional ByVal passwordcol As String = "password", Optional ByVal Logo As Image = Nothing)

        myAssembly.set_assembly(asm)


        frm.set_class(mysql, table, usernameCol, passwordcol)
        frm.lblInform1.Text = "This system has been locked by [" + username + "]. Only the same user can lift this system lock."
        If Not Logo Is Nothing Then frm.picLogo.Image = Logo
        frm.lblTitle.Text = myAssembly.getTitle
        frm.txtusername.Text = username
        frm.Table = table
        basedForm.Hide()
        frm.ShowDialog()

        If frm.return_value Then
            basedForm.Show()
        End If

    End Sub

End Class
