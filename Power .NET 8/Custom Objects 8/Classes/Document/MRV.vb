Imports System.Windows.Forms
Imports System.Windows.Forms.Cursors
Imports Microsoft.Reporting.WinForms

Public Class MRV
    Public ds As DataSet
    Public ReportTitle As String
    Public EmbeddedResource As String
    Public ReportName As String
    Public EmbeddedType As myDocument.Init.MicrosoftReportViewer.EmbeddedType = myDocument.Init.MicrosoftReportViewer.EmbeddedType.ReportPath
    Public ParameterCollection(99) As myDocument.Init.MicrosoftReportViewer.ParameterField
    Public countParameter As Integer = 0
    Private code As String = ""

    Protected Overloads Overrides Sub WndProc(ByRef m As Message)
        'Define DoubleClick...
        Const WM_NCLBUTTONDBLCLK As Integer = &HA3
        'Define LeftButtonDown event...
        Const WM_NCLBUTTONDOWN As Integer = 161
        'Define MOVE action...
        Const WM_SYSCOMMAND As Integer = 274
        'Define that the WM_NCLBUTTONDOWN is at TitleBar...
        Const HTCAPTION As Integer = 2
        'Trap MOVE action...
        Const SC_MOVE As Integer = 61456
        'Disable moving TitleBar...
        If (m.Msg = WM_SYSCOMMAND) AndAlso (m.WParam.ToInt32() = SC_MOVE) Then
            Exit Sub
        End If
        'Track whether clicked on TitleBar...
        If (m.Msg = WM_NCLBUTTONDOWN) AndAlso (m.WParam.ToInt32() = HTCAPTION) Then
            Exit Sub
        End If
        'Disable double click on TitleBar...
        If (m.Msg = WM_NCLBUTTONDBLCLK) Then
            Exit Sub
        End If
        MyBase.WndProc(m)
    End Sub

    Public Sub callCommand(Optional ByVal runCode As String = "")
        code = runCode
    End Sub

    Private Sub frmMicrosoftReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' myForm.TitleBar.createTitleBar(Me)
        If code <> "masterkey" Then
            If sender Is Nothing OrElse e Is Nothing Then
                Return
            End If

            Dim i As Integer = 0

            With rptMicrosoftReportViewer

                .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local

                If EmbeddedType = myDocument.Init.MicrosoftReportViewer.EmbeddedType.ReportEmbeddedResource Then
                    .LocalReport.ReportEmbeddedResource = EmbeddedResource
                Else
                    .LocalReport.ReportPath = EmbeddedResource
                    reportParameters()
                End If

                'Distributing Local Parameters Field
                .LocalReport.DisplayName = ReportTitle

                AddHandler .LocalReport.SubreportProcessing, AddressOf Me.SubreportProcessingEventHandler
                'reportDatasets()

                For i = 0 To ds.Tables.Count - 1
                    .LocalReport.DataSources.Add(New ReportDataSource(ds.DataSetName & "_" & ds.Tables(i).TableName, ds.Tables(i)))
                Next
                .ZoomMode = ZoomMode.FullPage

                .RefreshReport()
            End With
            Me.Text = ReportTitle
        Else
            MsgBox("Unable to use this data", MsgBoxStyle.Critical, "Restricted.")
            Me.Close()
        End If
    End Sub

    Private Sub reportDatasets()
        For i As Integer = 0 To ds.Tables.Count - 1
            Dim dss1 As New ReportDataSource
            dss1.Name = ds.Tables(i).TableName
            dss1.Value = ds.Tables(i)

            rptMicrosoftReportViewer.LocalReport.DataSources.Add(dss1)
        Next
    End Sub

    Private Sub reportParameters()
        For i As Integer = 0 To countParameter - 1
            With rptMicrosoftReportViewer
                Dim rpfilled As New ReportParameter()
                rpfilled.Name = ParameterCollection(i).name
                rpfilled.Values.Add(ParameterCollection(i).value)

                Dim param() As ReportParameter = {rpfilled}
                .LocalReport.SetParameters(param)
            End With
        Next
    End Sub

    Public Sub SubreportProcessingEventHandler(ByVal sender As Object, ByVal e As SubreportProcessingEventArgs)
        Dim mySubreportBindingSource As New BindingSource
        For i As Integer = 0 To ds.Tables.Count - 1
            e.DataSources.Add(New ReportDataSource(ds.DataSetName & "_" & ds.Tables(i).TableName, ds.Tables(i)))
        Next
    End Sub

End Class