Public Class frmSampleButtonIcons

    Private Function getTable()
        Dim myTable As New PowerNET8.myControls.Init.DataTables.DataTableDesigner
        With myTable
            .newTable("tlbDetails")
            .addColumnField("Name")
            .addColumnField("Gender")
            .addColumnField("Section")
            Return .getTable
        End With
    End Function

    Private Sub My8Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles My8Button1.Click
        Dim clsReportViewer As New PowerNET8.myDocument.Init.MicrosoftReportViewer

        Dim myDetails As DataTable = getTable()

        With clsReportViewer
            .setDatasetName("DataSet1")

            myDetails.Rows.Add()
            myDetails.Rows(0).Item("Name") = "Sylvster"
            myDetails.Rows(0).Item("Gender") = "M"
            myDetails.Rows(0).Item("Section") = "1 st"

            .addTableField(myDetails)

            .addParameterField("lblName", "Sylvster R. Belonio")
            .addParameterField("lblPosition", "Programmer")
            .addParameterField("lblDate", "June 19,1989")

            .setXML("xmlSample.xml")
            .setXMLSchema("rptsample.xsd")

            .title = "MY FIRST TIME TO CREATE MICROSOFT REPORT VIEWER"
            .reportPathType = PowerNET8.myDocument.Init.MicrosoftReportViewer.EmbeddedType.ReportPath
            .reportPath("Report1.rdlc")

            .launchReport()
        End With

    End Sub

End Class
