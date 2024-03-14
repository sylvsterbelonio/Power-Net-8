Public Class frmChangePassword
    Public Table As String = "tblusers"
    Public UsernameField As String = "username"
    Public PasswordField As String = "password"

    Friend mySql As New mySQL.Init.SQL
    Friend myDialog As New myDialog.messageBoxes
    Friend myEncrypt As New myEncrypt
    Friend myObject As New MyObject
    Private colobjects As New Collection
    'Private myTheme As MyObject.ThemeNames

    Public Sub set_class(ByRef mySqls As mySQL.Init.SQL)
        mySql = mySqls
        myObject.get_all_objects_data(colobjects, Me)
        'myObject.load(colobjects, myThemes)
        'myDialog.set_class(myThemes)
    End Sub

    Public Sub set_username(ByVal user As String)
        txtusername.Text = user
    End Sub

    Private Sub cmdSignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogIn.Click
        If txtusername.Text <> "" And txtOldPassword.Text <> "" And txtnewPassword.Text <> "" And txtVerifyPasswoed.Text <> "" Then

            If txtnewPassword.Text = txtVerifyPasswoed.Text Then
                Dim en As String = myEncrypt.EncryptData(txtOldPassword.Text)
                Dim mydata As DataTable = mySql.Query("SELECT * from " + Table + " where " + UsernameField + "='" + txtusername.Text + "' and " + PasswordField + "='" + en + "'")

                If mydata.Rows.Count > 0 Then
                    Dim username As String = mydata.Rows(0).Item(UsernameField)
                    With mySql
                        .clear()
                        .setTable(Table)
                        .addValue(myEncrypt.EncryptData(txtnewPassword.Text), PasswordField)
                        .Update(UsernameField, txtusername.Text)
                    End With
                    myDialog.show("You have successfully changed your password.", "Changed User Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    myDialog.show("Username and password does not match, please try again.", "Unable to sign in", , MessageBoxIcon.Exclamation)
                    txtVerifyPasswoed.Text = ""
                    txtnewPassword.Text = ""
                    txtOldPassword.Text = ""
                    txtOldPassword.Focus()
                End If
            Else
                myDialog.show("Your new password does not match with your verification password, please try again.", "Unable to sign in", , MessageBoxIcon.Exclamation)
                txtnewPassword.Text = ""
                txtVerifyPasswoed.Text = ""
                txtnewPassword.Focus()
            End If
        Else
            myDialog.show("Please input username and password", "Unable to proceed", , MessageBoxIcon.Information)
            If txtusername.Text = "" Then
                txtusername.Focus()
            ElseIf txtVerifyPasswoed.Text = "" Then
                txtVerifyPasswoed.Focus()
            End If
        End If
    End Sub

    Private Sub MbGlassButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MbGlassButton1.Click
        Me.Close()
    End Sub

    Private Sub frmChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class