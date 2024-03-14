Public Class myChangePassword

    Friend myDialog As New myDialog.messageBoxes

    Public Sub run(ByRef mysql As mySQL.Init.SQL, ByVal username As String, Optional ByVal table As String = "tblusers", Optional ByVal usernameCol As String = "username", Optional ByVal passwordcol As String = "password")
        Dim frm As New frmChangePassword
        'myDialog.set_class(mythemes)
        With frm
            .set_class(mysql)
            .txtusername.Text = username
            .Table = table
            .UsernameField = usernameCol
            .PasswordField = passwordcol
        End With
        myDialog.show_form(frm, "Change User Password", , 0.3)
    End Sub
End Class
