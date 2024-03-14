Public Class frmLogIn
    Friend mySql As New mySQL.Init.SQL
    Friend myEncrypt As New myEncrypt
    Friend myDialog As New myDialog.messageBoxes
    Friend myObject As New myObject
    'Friend clsSkin As New clsCustomSkin
    Private colObjects As New Collection
    Private myMainForm As New Form
    Public Table As String = "tblusers"
    Public UsernameField As String = "username"
    Public PasswordField As String = "password"

    Public Sub set_class(ByRef mySqls As mySQL.Init.SQL)
        mySql = mySqls
        myObject.get_all_objects_data(colObjects, Me)
        'myObject.load(colObjects, myThemes)
        'myDialog.set_class(myThemes)
    End Sub

    Public Sub set_form_load(ByRef frm As Form)
        myMainForm = frm
    End Sub

    Private Sub frmLogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize_form()
        initialize_load()
    End Sub

    Private Sub initialize_form()
        'Connect(mySql)
        'Themes(Me, mySql)
        'setJueryIcon()
        'lblTitle.Pulse = True
        'myDialog.set_class(MyThemes)
        'clsSkin.setSystemThemes(get_Objects)
    End Sub

    Private Sub initialize_load()

        Dim mydata As DataTable = mySql.Query("Select * from " + Table)
        For i As Integer = 0 To mydata.Rows.Count - 1
            txtusername.AutoCompleteCustomSource.Add(mydata.Rows(i).Item(UsernameField))
        Next
        With txtusername
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With

    End Sub

    Private Sub cmdSignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogIn.Click
        If txtusername.Text <> "" And txtpassword.Text <> "" Then
            Dim en As String = myEncrypt.EncryptData(txtpassword.Text)
            Dim mydata As DataTable = mySql.Query("SELECT * from " + Table + " where " + UsernameField + "='" + txtusername.Text + "' and " + PasswordField + "='" + en + "'")
            If mydata.Rows.Count > 0 Then
                Me.Text = "access granted-" + txtusername.Text + "!" + mydata.Rows(0).Item(0).ToString
                Me.Close()
            Else
                myDialog.show("Username and password does not match, please try again.", "Unable to sign in", , MessageBoxIcon.Exclamation)
                txtpassword.Text = ""
                txtpassword.Focus()
            End If
        Else
            myDialog.show("Please input username and password", "Unable to proceed", , MessageBoxIcon.Information)
            If txtusername.Text = "" Then
                txtusername.Focus()
            ElseIf txtpassword.Text = "" Then
                txtpassword.Focus()
            End If
        End If
    End Sub

    Private Sub txtpassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpassword.KeyDown, txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSignIn_Click(cmdLogIn, Nothing)
        End If
    End Sub

    Private Sub chkGuest_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkGuest.Click
        If chkGuest.Checked Then
            txtusername.ReadOnly = True
            txtpassword.ReadOnly = True
            txtusername.Text = "Guest"
            txtpassword.Text = "guest"
        Else
            txtusername.ReadOnly = False
            txtpassword.ReadOnly = False
            txtusername.Text = ""
            txtpassword.Text = ""
            txtusername.Focus()
        End If
    End Sub

End Class