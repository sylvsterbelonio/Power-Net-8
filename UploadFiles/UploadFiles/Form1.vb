Imports System.IO


Public Class Form1

    Private Sub cmdUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpload.Click
        Dim dialog As New OpenFileDialog()

        Dim mysql As New CustomObjects.mySql
        mysql.setConnection("localhost", "3306", "root", "", "uploadfiles")

        Dim myB As New CustomObjects.myBrowseDialog
        lblFileName.Text = myB.browse_any_file

        With mysql
            .setTable("tblfiles")
            .addValue(.nextID("id"), "id")
            .addValue(.convertAnyFilesToBLOB(lblFileName.Text), "file")
            .addValue(.get_FileName(lblFileName.Text, CustomObjects.mySql.FileNameStyle.withExtension), "fileName")
            .runInsert()
        End With

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myb As New CustomObjects.myBrowseDialog
        txtLocationToSave.Text = (myb.browse_folder())
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim mysql As New CustomObjects.mySql
        mysql.setConnection("localhost", "3306", "root", "", "uploadfiles")
        With mysql
            Dim mydata As DataTable = .runQuery("SELECT * from tblfiles where id=" + DataGridView1.CurrentRow.Cells(0).Value.ToString)
            If mydata.Rows.Count > 0 Then
                .write_BLOBFIle(txtLocationToSave.Text, mydata.Rows(0).Item("filename"), mydata.Rows(0).Item("file"))
                MsgBox("Successfully downloaded!")
            End If
        End With
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mysql As New CustomObjects.mySql
        mysql.setConnection("localhost", "3306", "root", "", "uploadfiles")
        Dim mydata As DataTable = mysql.runQuery("SELECT * from tblfiles")
        DataGridView1.Rows.Clear()
        For i As Integer = 0 To mydata.Rows.Count - 1
            DataGridView1.Rows.Add()
            DataGridView1.Rows(i).Cells(0).Value = mydata.Rows(i).Item("id")
            DataGridView1.Rows(i).Cells(1).Value = mydata.Rows(i).Item("filename")
        Next
    End Sub
End Class
