Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.IO
Imports System.Xml
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Windows.Forms.Cursors
Imports System.Text
Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports CrystalDecisions.Shared

Public Class myCommon

#Region "ERROR LOG"

    '*************************************************************
    'NAME:          WriteToErrorLog
    'PURPOSE:       Open or create an error log and submit error message
    'PARAMETERS:    msg - message to be written to error file
    '               stkTrace - stack trace from error message
    '               title - title of the error file entry
    'RETURNS:       Nothing
    '*************************************************************


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="msg"></param>
    ''' <param name="stkTrace"></param>
    ''' <param name="title"></param>
    ''' <remarks></remarks>
    Public Sub WriteToErrorLog(ByVal msg As String, ByVal stkTrace As String, ByVal title As String)
        'check and make the directory if necessary; this is set to look in the application
        'folder, you may wish to place the error log in another location depending upon the
        'the user's role and write access to different areas of the file system
        Dim path As String = myDocument.Share.XMLDesigner.PathConfig.readPath

        If Not Directory.Exists(path & "\Templates\Errors\") Then
            Directory.CreateDirectory(path & "\Templates\Errors\")
        End If

        'check the file
        Dim fs As FileStream = New FileStream(path & "\Templates\Errors\errlog.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim s As StreamWriter = New StreamWriter(fs)
        s.Close()
        fs.Close()

        'log it
        Dim fs1 As FileStream = New FileStream(path & "\Templates\Errors\errlog.txt", FileMode.Append, FileAccess.Write)
        Dim s1 As StreamWriter = New StreamWriter(fs1)
        s1.Write("Title: " & title & vbCrLf)
        s1.Write("Message: " & msg & vbCrLf)
        s1.Write("StackTrace: " & stkTrace & vbCrLf)
        s1.Write("Date/Time: " & DateTime.Now.ToString() & vbCrLf)
        s1.Write("===========================================================================================" & vbCrLf)
        s1.Close()
        fs1.Close()
    End Sub

    Public Function GetDebugInfo() As String
        Dim retStringBuf As New StringBuilder

        Try

            retStringBuf.AppendLine("Common class (debug reporter) Assembly Version: " + Environment.Version.Major.ToString() + "." + Environment.Version.Minor.ToString() + "." + Environment.Version.Revision.ToString() + "." + Environment.Version.Build.ToString())
            retStringBuf.AppendLine("Operating System: " + Environment.OSVersion.Platform.ToString())
            retStringBuf.AppendLine("Service Pack: " + Environment.OSVersion.ServicePack())
            retStringBuf.AppendLine("Major Version:	" + Environment.OSVersion.Version.Major.ToString())
            retStringBuf.AppendLine("Minor Version:	" + Environment.OSVersion.Version.Minor.ToString())
            retStringBuf.AppendLine("Revision:		" + Environment.OSVersion.Version.MajorRevision.ToString())
            retStringBuf.AppendLine("Build:		" + Environment.OSVersion.Version.Build.ToString())
            retStringBuf.Append(Environment.NewLine)
            retStringBuf.AppendLine("-------------------------------------------------")
            retStringBuf.Append("Logical Drives: ")
            For Each s As String In Environment.GetLogicalDrives()
                retStringBuf.Append(s & " ")
            Next
            retStringBuf.Append(Environment.NewLine)
            retStringBuf.AppendLine("System Directory: " + Environment.SystemDirectory)
            retStringBuf.AppendLine("Current Directory: " + Environment.CurrentDirectory)
            retStringBuf.AppendLine("Command Line: " + Environment.CommandLine)
            retStringBuf.Append("Command Line Args: ")
            For Each s As String In Environment.GetCommandLineArgs
                retStringBuf.Append(s & " ")
            Next
            retStringBuf.Append(Environment.NewLine)
            retStringBuf.Append(Environment.NewLine)
            retStringBuf.AppendLine("------------Environment Variables-----------------")
            Dim iEnum As IDictionaryEnumerator = Environment.GetEnvironmentVariables.GetEnumerator()
            While iEnum.MoveNext()
                Dim entry As DictionaryEntry = iEnum.Entry
                retStringBuf.AppendLine(entry.Key & " == " & entry.Value)
            End While
            retStringBuf.Append(Environment.NewLine)
            retStringBuf.AppendLine("------------Performance Info (Bytes)--------------")

            Dim currentProc As Process = Process.GetCurrentProcess()
            currentProc.Refresh()

            retStringBuf.Append("Private Memory:  ").AppendLine(currentProc.PrivateMemorySize64.ToString())
            retStringBuf.Append("Virtual Memory:  ").AppendLine(currentProc.VirtualMemorySize64.ToString())
            retStringBuf.Append("Total CPU time: ").AppendLine(currentProc.TotalProcessorTime.ToString())
            retStringBuf.Append("Total User Mode CPU time: ").AppendLine(currentProc.UserProcessorTime.ToString())
            retStringBuf.Append(Environment.NewLine)
            retStringBuf.AppendLine("------------Module Info:--------------------------")

            Dim myProcessModuleCollection As ProcessModuleCollection = currentProc.Modules
            Dim myProcessModule As ProcessModule
            For Each myProcessModule In myProcessModuleCollection
                Try
                    retStringBuf.Append("----Module Name:  ").AppendLine(myProcessModule.ModuleName)
                    retStringBuf.Append("    Path:  ").AppendLine(myProcessModule.FileName)
                    retStringBuf.Append("    Version: ").AppendLine(myProcessModule.FileVersionInfo.FileVersion.ToString())
                Catch
                End Try
            Next myProcessModule

            retStringBuf.Append(Environment.NewLine)
            retStringBuf.AppendLine("------------End Debug Info------------------------")
        Catch
        End Try

        Return retStringBuf.ToString()
    End Function

#End Region

    Public Function IsConnectionAvailable() As Boolean
        'Call url
        Dim url As New Uri("http://www.google.com/")
        'Request for request
        Dim req As Net.WebRequest
        req = Net.WebRequest.Create(url)
        Dim resp As Net.WebResponse
        Try
            resp = req.GetResponse()
            resp.Close()
            req = Nothing
            Return True
        Catch ex As Exception
            req = Nothing
            Return False
        End Try
    End Function

    Public Shared Function ExecuteUrl(ByVal fullUrl As String, ByVal postdata As String, Optional ByVal bAllowAutoRedirect As Boolean = True, Optional ByVal iTimeout As Integer = System.Threading.Timeout.Infinite) As String
        Dim webRequest As Net.HttpWebRequest
        Dim webResponse As Net.HttpWebResponse = Nothing
        Try
            'Create an HttpWebRequest with the specified URL.
            webRequest = CType(Net.WebRequest.Create(fullUrl), Net.HttpWebRequest)
            webRequest.AllowAutoRedirect = bAllowAutoRedirect
            webRequest.Method = "POST"
            webRequest.ContentType = "application/x-www-form-urlencoded"
            webRequest.ContentLength = postdata.Length
            'webRequest.MaximumAutomaticRedirections = 50
            webRequest.Timeout = iTimeout

            Dim requestStream As IO.Stream = webRequest.GetRequestStream()
            Dim postBytes As Byte() = Encoding.ASCII.GetBytes(postdata)
            requestStream.Write(postBytes, 0, postBytes.Length)
            requestStream.Close()

            'Send the request and wait for a response.
            Try
                webResponse = CType(webRequest.GetResponse(), Net.HttpWebResponse)
                Select Case (webResponse.StatusCode)
                    Case Net.HttpStatusCode.OK
                        'read the content from the response
                        Dim responseStream As IO.Stream = _
                            webResponse.GetResponseStream()
                        Dim responseEncoding As System.Text.Encoding = _
                            System.Text.Encoding.UTF8
                        ' Pipes the response stream to a higher level stream reader with the required encoding format.
                        Dim responseReader As New System.IO.StreamReader(responseStream, responseEncoding)
                        Dim responseContent As String = _
                            responseReader.ReadToEnd()
                        Return responseContent
                    Case System.Net.HttpStatusCode.Redirect, System.Net.HttpStatusCode.MovedPermanently
                        Throw New System.Exception(String.Format( _
                            "Unable to read response content.  URL has moved. StatusCode={0}.", _
                            webResponse.StatusCode))
                    Case System.Net.HttpStatusCode.NotFound
                        Throw New System.Exception(String.Format( _
                            "Unable to read response content. URL not found. StatusCode={0}.", _
                            webResponse.StatusCode))
                    Case Else
                        Throw New System.Exception(String.Format( _
                            "Unable to read response content. StatusCode={0}.", _
                            webResponse.StatusCode))
                End Select
            Catch we As System.Net.WebException
                'If (we.Status = Net.WebExceptionStatus.Timeout) Then
                '    Return False
                'End If
                Throw New System.Exception( _
                    "Unable to execute URL.", _
                    we)
            Finally
                If (Not IsNothing(webResponse)) Then
                    webResponse.Close()
                End If
            End Try
        Catch e As System.Exception
            Throw New System.Exception( _
                "Unable to execute URL.", _
                e)
        End Try
    End Function

End Class
