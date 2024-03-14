

Public Class frmLogIn
    Private mysql As New PowerNET8.mySQL.Init.SQL
    Private myencrypt As New PowerNET8.myEncrypt



    Private Sub My8Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles My8Button2.Click
        End
    End Sub

    Private Sub My8Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        If txtusername.Text <> "" And txtpassword.Text <> "" Then
            Dim mydata As DataTable = mysql.Query("select * from tblsys_user where username='" + txtusername.Text + "' and password ='" + myencrypt.Crypt(txtpassword.Text) + "'")
            If mydata.Rows.Count > 0 Then
                gUsername = mydata.Rows(0).Item("username")
                userID = mydata.Rows(0).Item("userID")

                If mydata.Rows(0).Item("userLevel") = "Administrator" Then
                    Dim frm As New frmMain

                    With frm
                        frm.frmLogIn = Me
                        .Show()
                    End With
                Else

                    Dim frm As New frmSideBarPanel
                    frm.action = "add"
                    frm.frmLogIn = Me
                    frm.Show()
                End If
                Me.Hide()
            Else
                MsgBox("Username or password doest not match, please try again.")
            End If
        Else
            MsgBox("Please input username and password")
        End If
    End Sub

    Private Sub frmLogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect(mysql)
    End Sub


End Class