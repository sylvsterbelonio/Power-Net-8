Public Class frmSystemLock

    Public Table As String = "tblusers"
    Public UsernameField As String = "username"
    Public PasswordField As String = "password"

    Friend mySql As New mySQL.Init.SQL
    Friend myDialog As New myDialog.messageBoxes
    Friend myEncrypt As New myEncrypt
    Friend myObject As New MyObject
    Private colobject As New Collection
    ' Private myTheme As MyObject.ThemeNames
    Public return_value As Boolean = False

    Public Sub set_class(ByRef mysqls As mySQL.Init.SQL, Optional ByVal Table As String = "tblusers", Optional ByVal usernamefield As String = "username", Optional ByVal passwordfield As String = "password")
        mySql = mysqls
        'myTheme = mythemes
        'myDialog.set_class(mythemes)
    End Sub

    Private Sub frmSystemLock_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            If grpLogInForm.Visible Then
                grpLogInForm.Visible = False
            Else
                grpLogInForm.Visible = True
            End If
        End If
    End Sub

    Private KeyPressChar As Long

    Private Sub frmSystemLock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If sender Is Nothing OrElse e Is Nothing Then
            Return
        End If
        KeyPressChar = e.KeyChar.GetHashCode

        Select Case KeyPressChar
            Case 851981 ' enter
                'btnUnlock.PerformClick()
            Case 1769499 ' esc
                If grpLogInForm.Visible Then
                    'lblSystemLock.Text = "This system has been locked by [" & Trim(txtusername.Text) & "]. Only the same user can lift this system lock." & vbCr & vbCr & "Caution : If you lose or forget the password, it can not be recovered. (Remember that passwords are case sensitive.)" & vbCr & vbCr & "If you have the correct account specified below, enter your password to unlock the system."
                    grpLogInForm.Visible = False
                    'btnUnlock.Enabled = True
                    If txtpassword.Text.Length > 0 Then
                        txtpassword.SelectAll()
                    End If
                    txtpassword.Focus()
                Else
                    'lblSystemLock.Text = "This system has been locked by [" & Trim(txtusername.Text) & "]. Only the same user can lift this system lock." & vbCr & vbCr & "Caution : If you lose or forget the password, it can not be recovered. (Remember that passwords are case sensitive.)" & vbCr & vbCr & "If you have the correct account, press [ESC] key to enter password and unlock the system."
                    grpLogInForm.Visible = True
                    'btnUnlock.Enabled = False
                    txtpassword.Text = ""
                End If
        End Select
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If LinkLabel1.Text = "Show Log In" Then
            LinkLabel1.Text = "Hide Log In"
            grpLogInForm.Visible = True
            If txtpassword.Text.Length > 0 Then
                txtpassword.SelectAll()
            End If
            txtpassword.Focus()
        Else
            grpLogInForm.Visible = False
            LinkLabel1.Text = "Show Log In"
        End If
    End Sub

    Private Sub txtpassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdLogIn_Click(cmdLogIn, Nothing)
        End If
    End Sub

    Private Sub cmdLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogIn.Click
        If txtpassword.Text <> "" Then
            Dim en As String = myEncrypt.EncryptData(txtpassword.Text)
            Dim mydata As DataTable = mySql.Query("SELECT * from " + Table + " where " + UsernameField + "='" + txtusername.Text + "' and " + PasswordField + "='" + en + "'")
            If mydata.Rows.Count > 0 Then
                return_value = True
                Me.Close()
            Else
                myDialog.show("Username and password does not match, please try again.", "Unable to unlock the system.")
                txtpassword.SelectAll()
                txtpassword.Focus()
            End If
        End If
    End Sub

    Private Sub frmSystemLock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myObject.get_all_objects_data(colobject, Me)
        'myObject.load(colobject, myTheme)
    End Sub

End Class