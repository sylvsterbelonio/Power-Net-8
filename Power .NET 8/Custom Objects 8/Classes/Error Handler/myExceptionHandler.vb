Imports System.Threading
Public Class myExceptionHandler

    Private Shared myCommon As New myCommon
    Public Shared Assembly As Reflection.Assembly = Nothing

    ''' <summary>
    ''' It handles the exception event
    ''' </summary>
    ''' <param name="sender">Specify the object Exception Event</param>
    ''' <param name="t">Specify the Thread Exception Event Argument</param>
    ''' <remarks></remarks>
    Public Shared Sub OnThreadException(ByVal sender As Object, ByVal t As ThreadExceptionEventArgs)
        OnThreadException(t.Exception)
    End Sub

    ''' <summary>
    ''' It calls the Thread Exception handler by calling the class. You can used this method within the try and catch area
    ''' </summary>
    ''' <param name="e">Set the error exception</param>
    ''' <param name="Msg">Set the other message that clarifies the error exception</param>
    ''' <remarks></remarks>
    Public Shared Sub OnThreadException(ByVal e As Exception, Optional ByVal Msg As String = "")
        myCommon.WriteToErrorLog(e.Message, e.StackTrace, "Error")

        If e.Message.Contains("UnauthorizedAccessException") Then
            'clsCommon.Prompt_User("error", "An Unauthorized Access error was generated. Please ensure you have access to all files you're trying to work with, and that the files aren't in use by other applications.")
            MsgBox("An Unauthorized Access error was generated. Please ensure you have access to all files you're trying to work with, and that the files aren't in use by other applications.", , "error")
            Exit Sub
        End If
        Try
            If (IIf((Len(myApplication.Share.Registry.GetRegistrySetting("Reports", "DontReportBugs")) = 0), 0, CInt(myApplication.Share.Registry.GetRegistrySetting("Reports", "DontReportBugs")))) = 0 Then
                Dim errorBoxes As New frmErrorDialog(e, Msg, Assembly)
                errorBoxes.ShowDialog()
            Else
                Dim errorBox As New frmErrorDialog(e, Msg, Assembly)
                errorBox.ShowDialog()
            End If
        Catch ex As Exception
            Dim errorBox As New frmErrorDialog(e, Msg, Assembly)
            errorBox.ShowDialog()

        End Try
    End Sub

End Class
