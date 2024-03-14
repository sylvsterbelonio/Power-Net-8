Public Class frmXMLGeneratorSQL
    Friend mySql As New PowerNET8.mySQL.Init.SQL
    Friend myDialog As New PowerNET8.myDialog.messageBoxes
    Friend myObject As New PowerNET8.myObject
    'Private myThemes As CustomObjects.MyObject.ThemeNames = CustomObjects.MyObject.ThemeNames.Original
    Private colobjects As New Collection

    Public allow_pass As Boolean = False

    Private Sub frmXMLGeneratorSQL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize_form()
        allow_pass = False
    End Sub

    Private Sub initialize_form()
        myObject.get_all_objects_data(colobjects, Me)
        'myObject.load(colobjects, myThemes)
        'myDialog.set_class(myThemes)
    End Sub

    Private Sub t_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t.Click
        If mySql.connectServer(txtLocalhost.Text, txtport.Text, txtusername.Text, txtpassword.Text) Then
            Dim cols() As String = mySql.getListDatabase().ToString.Split(",")
            cboDatabase.Items.Clear()
            For i As Integer = 0 To cols.Length - 1
                cboDatabase.Items.Add(cols(i))
            Next
            myDialog.show("Please select a database name", , , MessageBoxIcon.Information)
        Else
            'myDialog.show("There was a problem of connecting mysql. Please reconfigure the settings or the sql does not run in the system.", "Unable to connect")
            txtpassword.Text = ""
            txtusername.Text = ""
            txtLocalhost.Text = ""
            txtport.Text = ""
            txtLocalhost.Focus()
            cboDatabase.Items.Clear()
            cmdConnect.Enabled = False
        End If
        cmdExecute.Enabled = False
        cmdappend.Enabled = False
    End Sub

    Private Sub cboDatabase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDatabase.SelectedIndexChanged
        If cboDatabase.SelectedIndex <> -1 Then
            cmdConnect.Enabled = True
        Else
            cmdConnect.Enabled = False
        End If
        cmdExecute.Enabled = False
        cmdappend.Enabled = False
    End Sub

    Private Sub cmdConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConnect.Click
        If mySql.connectDatabase(txtLocalhost.Text, txtport.Text, txtusername.Text, txtpassword.Text, cboDatabase.Text) Then
            cmdExecute.Enabled = True
            UltraTabControl1.Tabs(0).Selected = True
            myDialog.show("Sql successfully configured!", , , MessageBoxIcon.Information)
        End If
        cmdappend.Enabled = False
    End Sub

    Private Sub MbGlassButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MbGlassButton1.Click
        Me.Close()
    End Sub

    Private Sub cmdExecute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExecute.Click
        If txtsql.Text <> "" Then
            If txtsql.Text.ToLower.Contains("select") Then
                With mySql
                    Dim mydata As DataTable = .Query(txtsql.Text + " LIMIT 0,1")
                    lstColumnName.Items.Clear()
                    For i As Integer = 0 To mydata.Columns.Count - 1
                        lstColumnName.Items.Add(mydata.Columns(i).ColumnName + " - " + mydata.Columns(i).DataType.ToString())

                    Next
                End With
                cmdappend.Enabled = True
                'GET TABLE NAME HERE
                Dim blnf As Boolean = False
                Dim cols() As String = txtsql.Text.Split(" ")
                For i As Integer = 0 To cols.Length - 1
                    If cols(i).ToLower.Contains("from") Then
                        For ii As Integer = i + 1 To cols.Length - 1
                            If Trim(cols(ii)) <> "" Then
                                txttablename.Text = cols(ii)
                                blnf = True
                                Exit For
                            End If
                        Next
                    End If
                    If blnf Then
                        Exit For
                    End If
                Next
            Else
                cmdappend.Enabled = False
                myDialog.show("You can query SELECT method only otherwise it will not display the column name", , , MessageBoxIcon.Exclamation)
            End If
        Else
            cmdappend.Enabled = False
            myDialog.show("Please input SELECT query or the sql contains an error.", , , MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtsql_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtsql.MouseClick
        txtsql.SelectAll()
    End Sub

    Private Sub cmdappend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdappend.Click
        If myDialog.show("Are you sure you want to select this table query?", "Selection Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            allow_pass = True
            Me.Close()
        End If
    End Sub

End Class