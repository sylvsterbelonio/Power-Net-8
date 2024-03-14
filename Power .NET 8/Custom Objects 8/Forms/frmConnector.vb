Public Class frmConnector
    Friend mySql As New mySQL.Init.SQL
    Friend myObject As New MyObject
    'Friend myThemes As New MyObject.ThemeNames
    Friend wrapper As New myEncrypt
    Friend myDialog As New myDialog.messageBoxes
    Dim colObjects As New Collection
    Public allow_save As Boolean = False
    Dim locations As String = ""
    Dim fileNames As String = ""

    'Public Sub set_themes(ByVal themes As MyObject.ThemeNames)
    '   myThemes = themes
    'End Sub

    Public Sub set_location(ByVal value As String)
        locations = value
    End Sub

    Public Sub set_fileName(ByVal value As String)
        fileNames = value
    End Sub

    Private Sub frmConnector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize_form()
        initialize_variables()
    End Sub

    Private Sub initialize_form()
        'myObject.get_all_objects_data(colObjects, Me)
        'myObject.load(colObjects, myThemes)
        'myDialog.set_class(myThemes)
    End Sub

    Private Sub initialize_variables()
        cboDBName.Enabled = False
    End Sub

    Private Sub clear()
        txtPort.Text = ""
        txtServer.Text = ""
        txtUserID.Text = ""
        txtPassword.Text = ""
        txtServer.Focus()
        cboDBName.SelectedIndex = -1
        cboDBName.Enabled = False
    End Sub

    Private Sub MbGlassButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        If myDialog.show("You can never run the system without proper configuration, are you sure you want to cancel the configuration?", "Cancel Configuration Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            allow_save = False
            Me.Close()
        End If
    End Sub

    Private Sub cmdTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest.Click
        If mySql.connectServer(txtServer.Text, txtPort.Text, txtUserID.Text, txtPassword.Text) Then
            Dim data() As String = mySql.getListDatabase.ToString.Split(",")
            cboDBName.Items.Clear()
            For i As Integer = 0 To data.Length - 2
                cboDBName.Items.Add(data(i))
            Next
            myDialog.show("You have successfully connected in the server", "Connection MySql Success!")
            cboDBName.Enabled = True
            cmdOk.Enabled = True
        Else
            clear()
        End If
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If cboDBName.SelectedIndex <> -1 Then
            If Not mySql.setConnectionErrno(txtServer.Text, txtPort.Text, txtUserID.Text, txtPassword.Text, cboDBName.Text) Then
                allow_save = True
                Me.Close()
            Else
                clear()
            End If
        Else
            myDialog.show("Please select database name", "Database is required")
        End If
    End Sub

End Class