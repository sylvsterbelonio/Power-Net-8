Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Xml

Public Class frmCrystalReportViewer
    Inherits System.Windows.Forms.Form

    Public ReportPath As String
    Public myDs As New DataSet
    Public collectionFields As New ParameterFields
    Public WithEvents oRpt As New ReportDocument
    Public ci_serverName As String
    Public ci_database As String
    Public ci_userID As String
    Public ci_password As String
              
    Public Sub setDS(ByVal ds As DataSet)
        myDs = ds
    End Sub

    Public Sub setPaperStyle(ByVal vals As myDocument.Init.CrystalReportViewer.ReportStyle)
        Select Case vals
            Case myDocument.Init.CrystalReportViewer.ReportStyle.Portrait
                oRpt.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            Case myDocument.Init.CrystalReportViewer.ReportStyle.LandScape
                oRpt.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            Case Else
                oRpt.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.DefaultPaperOrientation
        End Select
    End Sub

    Public Sub setPaperSize(ByVal vals As myDocument.Init.CrystalReportViewer.ReportSize)
        Select Case vals
            Case myDocument.Init.CrystalReportViewer.ReportSize.Letter
                oRpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperLetter
            Case myDocument.Init.CrystalReportViewer.ReportSize.Legal
                oRpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperLegal
            Case myDocument.Init.CrystalReportViewer.ReportSize.A3
                oRpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA3
            Case myDocument.Init.CrystalReportViewer.ReportSize.A4
                oRpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
            Case Else
                oRpt.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.DefaultPaperSize
        End Select
    End Sub

    Public Sub setTitle(ByVal title As String)
        Me.Text = title
    End Sub

    Function Logon(ByVal cr As ReportDocument) As Boolean
        Dim ci As New ConnectionInfo
        Dim subObj As SubreportObject

        ci = GetConnectionInfo()

        If Not (ApplyLogon(cr, ci)) Then
            Return False
        End If

        Dim obj As ReportObject

        For Each obj In cr.ReportDefinition.ReportObjects()
            If (obj.Kind = ReportObjectKind.SubreportObject) Then
                subObj = CType(obj, SubreportObject)
                If Not (ApplyLogon(cr.OpenSubreport(subObj.SubreportName), ci)) Then
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    Function ApplyLogon(ByVal cr As ReportDocument, ByVal ci As ConnectionInfo) As Boolean
        Dim li As TableLogOnInfo
        Dim tbl As Table

        ' for each table apply connection info 
        For Each tbl In cr.Database.Tables
            li = tbl.LogOnInfo
            li.ConnectionInfo = ci
            tbl.ApplyLogOnInfo(li)

            ' check if logon was successful 
            ' if TestConnectivity returns false, check logon credentials 

            If (tbl.TestConnectivity()) Then
                'drop fully qualified table location 
                If (tbl.Location.IndexOf(".") > 0) Then
                    tbl.Location = tbl.Location.Substring(tbl.Location.LastIndexOf(".") + 1)
                Else
                    tbl.Location = tbl.Location
                End If
            Else
                Return False
            End If

        Next
        Return True
    End Function

    Public Function GetConnectionInfo() As ConnectionInfo
        Dim Doc As New XmlDocument
        Dim Root As XmlElement
        Try
            Dim ci As New ConnectionInfo

            'Doc.Load(fn)
            'Root = Doc.DocumentElement.Item("Connection")

            'With Root
            ci.ServerName = ci_serverName
            ci.DatabaseName = ci_database
            ci.UserID = ci_userID
            ci.Password = ci_password
            'End With

            Return ci
        Catch ex As Exception
            'RaiseEvent MsgArrival(ex.Message, False)
            MsgBox("There was an error :" + ex.ToString)
            Return Nothing
        End Try
    End Function

    Private Sub frmCrystalReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BackgroundImage = Nothing
        Me.Cursor = Cursors.WaitCursor
        Dim logOnInfo As New TableLogOnInfo
        oRpt = New ReportDocument

        If sender Is Nothing OrElse e Is Nothing Then
            Return
        End If
        Try
            oRpt.Load(ReportPath)
            If Not myDs Is Nothing Then
                Logon(oRpt)
                If myDs.Tables.Count > 0 Then
                    oRpt.SetDataSource(myDs)
                End If
            End If

            rptViewer.ReportSource = oRpt
            rptViewer.Refresh()

        Catch ex As Exception
            MsgBox("Unable to load report. [" + ex.ToString + "].", , "Load Report Failed...")
        End Try
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub frmCrystalReportViewer_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        rptViewer.Width = Me.Width - 10
        rptViewer.Height = Me.Height - 10
    End Sub

End Class