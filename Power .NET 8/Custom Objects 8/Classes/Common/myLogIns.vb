Public Class myLogIns
    Dim frm As New frmLogIn
    Friend myDialog As New myDialog.messageBoxes
    Friend myEncrypt As New myEncrypt
    Friend myCon As New myConnector
    Friend myAssembly As New myAssemblyInfo
    Friend mySql As New mySQL.Init.SQL
    Public curUserID As String
    Public curUsername As String
    Public curUserLevel As String
    Public curFullName As String

    Public Sub clear_password()
        frm.txtpassword.Text = ""
    End Sub

    Public Function run(ByRef myCon As myConnector, ByRef mysqls As mySQL.Init.SQL, ByRef asm As System.Reflection.Assembly, ByVal location As String, Optional ByVal table As String = "tblusers", Optional ByVal usernameCol As String = "username", Optional ByVal passwordCol As String = "password", Optional ByVal suggestUsername As String = "", Optional ByVal Logo As Image = Nothing, Optional ByVal ShadowImage As Image = Nothing, Optional ByVal Shadowopacity As Decimal = 0.3)
        mySql = mysqls
        myAssembly.set_assembly(asm)
        With myCon
            'myDialog.set_class(myThemes)
            With frm
                .Table = table
                .UsernameField = usernameCol
                .PasswordField = passwordCol
                .lblTitle.Text = myAssembly.getTitle
                .lblSubTitle.Text = myAssembly.getCompany
                .set_class(mysqls)
                .Table = table
                .UsernameField = usernameCol
                .PasswordField = passwordCol
                .txtusername.Text = suggestUsername
                .txtusername.Focus()
            End With
            If Not ShadowImage Is Nothing Then
                myDialog.setShadowBackground = PowerNET8.myDialog.messageBoxes.Mode.enable
            End If

            If Not Logo Is Nothing Then frm.picLogo.Image = Logo
            Dim ret As String = myDialog.show_form(frm, , , Shadowopacity)

            If ret <> "" Then
                Dim col() As String = ret.Split("!")
                curUserID = col(1)
                curUsername = col(0)
                ._User = col(0)
                .update_setup(location, "setup.ini")
                Return True
            Else
                Return False
            End If
        End With

    End Function

    Public Sub get_user_info(Optional ByVal userID As String = "user_ID", Optional ByVal user_previlege As String = "user_previlege", Optional ByVal firstName As String = "firstName", Optional ByVal middleName As String = "middleName", Optional ByVal surname As String = "surname", Optional ByVal username As String = "username", Optional ByVal nameExt As String = "nameExt", Optional ByVal From As String = "tblusers  INNER JOIN  tblemployeeinfo    ON (tblusers.user_ID = tblemployeeinfo.user_ID)")
        Dim mydata As DataTable = mySql.Query("SELECT * FROM " + From + "   where " + username + "='" + frm.txtusername.Text + "'")
        If mydata.Rows.Count > 0 Then
            curUserID = mydata.Rows(0).Item(userID)
            curUserLevel = myEncrypt.DecryptData(mydata.Rows(0).Item(user_previlege))
            curFullName = mydata.Rows(0).Item(firstName) + " " + mydata.Rows(0).Item(middleName) + " " + mydata.Rows(0).Item(surname) + " " + mydata.Rows(0).Item(nameExt)
        End If
    End Sub
End Class
