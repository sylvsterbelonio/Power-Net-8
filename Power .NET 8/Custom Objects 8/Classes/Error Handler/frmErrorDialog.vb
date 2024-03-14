Imports System
Imports System.Web
Imports System.Drawing
Imports System.Windows.Forms.Cursors
Imports Microsoft.VisualBasic

Public Class frmErrorDialog

    Inherits System.Windows.Forms.Form

    Private Shared resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmErrorDialog))

    Private gException As Exception
    Private clsCommon As New myCommon

    Private Const REGISTRY_SECTION_ERRORS = "Reports"

    Private Const REGISTRY_KEY_REPORT_BUGS = "DontReportBugs"

    Sub New(ByVal a As Exception, ByVal msg As String, Optional ByVal asm As System.Reflection.Assembly = Nothing)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        If msg <> "" Then
            txtComments.Text = msg + vbCrLf + a.ToString
        Else
            txtComments.Text = a.ToString
        End If

        If Not asm Is Nothing Then
            modApp.setAssemblyInfo(asm)
        End If

    End Sub

    Private Sub frmEventHandler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblErr01.Text = "An error has occurred in " & modApp.getTitle & " or in one of its assemblies."
        lblErr02.Text = "If you would like to send the error details to " & modApp.getCompany & " CPG automatically, please press Send Data below."
        lblAltLink.Text = "Problems can also be reported to " & modApp.getAlias & " as well."
        chkNoReport.CheckState = IIf((Len(myApplication.Share.Registry.GetRegistrySetting(REGISTRY_SECTION_ERRORS, REGISTRY_KEY_REPORT_BUGS)) = 0), 0, CInt(myApplication.Share.Registry.GetRegistrySetting(REGISTRY_SECTION_ERRORS, REGISTRY_KEY_REPORT_BUGS)))
    End Sub

    Private Sub lblWhatReport_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblWhatReport.LinkClicked
        Dim moreInfo As New frmErrorDialogMoreInfo()
        moreInfo.txtFullText.Text = modApp.getTitle + " (" + System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly().Location).ToShortDateString() + ")" + vbCrLf + vbCrLf + gException.ToString() + vbCrLf + vbCrLf + clsCommon.GetDebugInfo()
        moreInfo.Owner = Me
        moreInfo.Show()
        moreInfo.BringToFront()
    End Sub

    Private Sub lblAltLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblAltLink.LinkClicked
        Try
            System.Diagnostics.Process.Start("mailto:" & modApp.getAlias)
        Catch
        End Try
    End Sub

    Private Sub btnDontSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDontSend.Click
        If sender Is Nothing OrElse e Is Nothing Then
            Return
        End If
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        If sender Is Nothing OrElse e Is Nothing Then
            Return
        End If

        Cursor = WaitCursor
        If Not clsCommon.IsConnectionAvailable Then
            Cursor = Arrow
            MsgBox("error", "There is an error connecting to the internet." & vbCr & "The application detected that you are currently not connected to the internet." & vbCr & "Please make sure that you are connected to the internet before trying to resend this error report. If this problem persists, please notify the system administrator immediately.")

            Exit Sub
        End If

        Dim Expression As New System.Text.RegularExpressions.Regex("\S+@\S+\.\S+")
        If Not Expression.IsMatch(txtEMail.Text) Then
            MsgBox("error", "Please provide a valid email address.")
            Exit Sub
        End If

        Try
            If Not gException Is Nothing Then
                Dim post As String = "prog=" + System.Web.HttpUtility.UrlEncode(modApp.getProduct + " (" + System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetEntryAssembly().Location).ToShortDateString() + ")") + "&ex=" + System.Web.HttpUtility.UrlEncode(gException.ToString()) + "&fromemail=" + System.Web.HttpUtility.UrlEncode(txtEMail.Text) + "&adtnl=" + System.Web.HttpUtility.UrlEncode(clsCommon.GetDebugInfo()) + "&comments=" + System.Web.HttpUtility.UrlEncode(txtComments.Text)

                Try
                    myCommon.ExecuteUrl("http://www.jamediasolutions.com/automailer.php", post)
                Catch ex As Exception
                    System.Diagnostics.Debug.WriteLine(ex.ToString())
                End Try
            End If
        Catch

        Finally
            Cursor = Arrow
        End Try

        Try
            Dim msg As String = Resources.GetString("msgDataSubmitted.Text")
            If msg.Trim() = "" Then msg = "Thank you! The data has been submitted."
            MsgBox("information", msg)
        Catch
            MsgBox("information", "Thank you! The data has been submitted.")
        End Try
    End Sub


End Class