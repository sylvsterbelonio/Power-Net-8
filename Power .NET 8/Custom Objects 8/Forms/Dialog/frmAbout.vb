Imports System.Reflection
Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports Microsoft.Win32

Public Class frmAbout
    Public LogoImage As Image
    Friend myObject As New MyObject
    Private colObject As New Collection
    'Private myThemes As MyObject.ThemeNames = CustomObjects.MyObject.ThemeNames.Original

    'Public Sub set_class(Optional ByVal myTheme As MyObject.ThemeNames = CustomObjects.MyObject.ThemeNames.Original)
    '    myThemes = myTheme
    'End Sub

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Comments, Credits As String

        Comments = ""
        Credits = ""

        myObject.get_all_objects_data(colObject, Me)
        'myObject.load(colObject, myThemes)
        If Not LogoImage Is Nothing Then
            picLogo.Image = LogoImage
        End If
    End Sub

    Private Sub MbGlassButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MbGlassButton2.Click
        Me.Close()
    End Sub

    Private Function RegistryHklmValue(ByVal KeyName As String, ByVal SubKeyRef As String) As String
        Dim rk As RegistryKey
        Try
            rk = Registry.LocalMachine.OpenSubKey(KeyName)
            Return CType(rk.GetValue(SubKeyRef, ""), String)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub MbGlassButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MbGlassButton1.Click
        Dim strSysInfoPath As String = ""

        strSysInfoPath = RegistryHklmValue("SOFTWARE\Microsoft\Shared Tools Location", "MSINFO")
        If strSysInfoPath = "" Then
            strSysInfoPath = RegistryHklmValue("SOFTWARE\Microsoft\Shared Tools\MSINFO", "PATH")
        End If

        If strSysInfoPath = "" Then
            MessageBox.Show("System Information is unavailable at this time." & _
                Environment.NewLine & _
                Environment.NewLine & _
                "(couldn't find path for Microsoft System Information Tool in the registry.)", _
                Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Process.Start(strSysInfoPath)
        Catch ex As Exception
            MessageBox.Show("System Information is unavailable at this time." & _
                Environment.NewLine & _
                Environment.NewLine & _
                "(couldn't launch '" & strSysInfoPath & "')", _
                Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub

    Private Sub lnkURL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkURL.LinkClicked
        If Not lnkURL.Text.ToLower().StartsWith("http://") Then
            Diagnostics.Process.Start("http://" + lnkURL.Text)
        Else
            Diagnostics.Process.Start(lnkURL.Text)
        End If
    End Sub

End Class