Public Class SC
    Private mysql As New mySQL.Init.SQL

    Public runCode As String = ""
    Public basePath As String = ""

    Private Sub clear()
        txtPort.Text = ""
        txtServername.Text = ""
        txtusername.Text = ""
        txtPassword.Text = ""
        txtServername.Focus()
        cboDBName.SelectedIndex = -1
        cboDBName.Enabled = False
    End Sub

    Private Sub cmdTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest.Click
        If mysql.connectServer(txtServername.Text, txtPort.Text, txtusername.Text, txtPassword.Text) Then
            Dim data() As String = mysql.getListDatabase.ToString.Split(",")
            cboDBName.Items.Clear()
            For i As Integer = 0 To data.Length - 2
                cboDBName.Items.Add(data(i))
            Next
            MsgBox("You have successfully connected in the server", , "Connection MySql Success!")
            cboDBName.Enabled = True
            cmdAdd.Enabled = True
        Else
            clear()
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim blnFound As Boolean = False
        For i As Integer = 0 To dgvListDatabase.RowCount - 1
            If dgvListDatabase.Rows(i).Cells(0).Value = cboDBName.Text Then
                blnFound = True
            End If
        Next

        If Not blnFound And cboDBName.Text <> "" Then
            add_configMysql(Me, cboDBName.Text, txtServername.Text, txtusername.Text, txtPassword.Text, txtPort.Text)
            showListDatabase(dgvListDatabase)
        Else
            MsgBox("Database name is already selected or No Databasename.")
        End If

    End Sub

    Private Sub dgvListDatabase_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvListDatabase.MouseClick
        If dgvListDatabase.RowCount > 0 Then
            clear()
            Dim col() As String = getListDatabaseInfo(dgvListDatabase.CurrentRow.Cells(0).Value).ToString.Split(",")
            txtServername.Text = col(0)
            txtusername.Text = col(1)
            txtPassword.Text = col(2)
            txtPort.Text = col(3)
            cboDBName.Text = col(4)
        End If
    End Sub

    Private Sub cmdClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearAll.Click
        If MsgBox("Do you want to clear all list of databases?", MsgBoxStyle.YesNo, "Delete confirm") = MsgBoxResult.Yes Then
            clear_configMysql()
            showListDatabase(dgvListDatabase)
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim blnFound As Boolean = False
        For i As Integer = 0 To dgvListDatabase.RowCount - 1
            If dgvListDatabase.Rows(i).Cells(0).Value = "powernet8" Then
                blnFound = True
            End If
        Next
        If blnFound Then
            If MsgBox("Do you want to save this database settings?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                myDocument.Share.XMLDesigner.DatabaseConfig.writeDatabaseConfig(basePath)
                Me.Close()
            End If
        Else
            MsgBox("Power .NET 8 Database is required in your system.")
        End If

    End Sub

    Private Sub frmSqlConfiguration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If runCode = "masterkey" Then
            myDocument.Share.XMLDesigner.DatabaseConfig.readDatabaseConfig(basePath)
            showListDatabase(dgvListDatabase)
        Else
            MsgBox("Unable to access data.", MsgBoxStyle.Critical, "Restricted")
        End If
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        If dgvListDatabase.RowCount > 0 Then
            remove_configMysql(dgvListDatabase.CurrentRow.Cells(0).Value)
            showListDatabase(dgvListDatabase)
        End If
    End Sub

    Private Sub frmContenr_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles frmContenr.Paint

    End Sub
End Class