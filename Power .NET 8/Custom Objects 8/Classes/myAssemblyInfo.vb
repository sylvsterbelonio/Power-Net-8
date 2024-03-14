Imports System.Reflection
Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports Microsoft.Win32
Public Class myAssemblyInfo
    Dim asm As System.Reflection.Assembly = Nothing

    Private titleAttr As System.Reflection.AssemblyTitleAttribute
    ' <Assembly: AssemblyDescription("My Assembly Description")>
    Private descAttr As System.Reflection.AssemblyDescriptionAttribute
    ' <Assembly: AssemblyCompany("My Company")>

    ' <Assembly: AssemblyProduct("My Product Name")>
    Private productAttr As System.Reflection.AssemblyProductAttribute
    ' <Assembly: AssemblyCopyright("My Copyright")>
    Private copyrtAttr As System.Reflection.AssemblyCopyrightAttribute
    ' <Assembly: AssemblyTrademark("My Trademark")>
    Private trademkAttr As System.Reflection.AssemblyTrademarkAttribute
    ' <Assembly: AssemblyTrademark("My Informational Version")>
    Private infoverAttr As System.Reflection.AssemblyInformationalVersionAttribute
    ' <Assembly: AssemblyAlias("Default Alias")>
    Private infoaliasAttr As System.Reflection.AssemblyDefaultAliasAttribute

    Public Sub set_assembly(ByRef asms As System.Reflection.Assembly)
        asm = asms
    End Sub

    Public Function getTitle() As String
        If Not asm Is Nothing Then
            Dim Attr As System.Reflection.AssemblyTitleAttribute
            Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyTitleAttribute), False)(0)
            Return Attr.Title
        End If
        Return Nothing
    End Function

    Public Function getDescription() As String
        If Not asm Is Nothing Then
            Dim Attr As System.Reflection.AssemblyDescriptionAttribute
            Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyDescriptionAttribute), False)(0)
            Return Attr.Description
        End If
        Return Nothing
    End Function

    Public Function getCompany() As String
        If Not asm Is Nothing Then
            Dim Attr As System.Reflection.AssemblyCompanyAttribute
            Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyCompanyAttribute), False)(0)
            Return Attr.Company
        End If
        Return Nothing
    End Function

    Public Function getProduct() As String
        If Not asm Is Nothing Then
            Dim Attr As System.Reflection.AssemblyProductAttribute
            Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyProductAttribute), False)(0)
            Return Attr.Product
        End If
        Return Nothing
    End Function

    Public Function getTrademark() As String
        If Not asm Is Nothing Then
            Dim Attr As System.Reflection.AssemblyTrademarkAttribute
            Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyTrademarkAttribute), False)(0)
            Return Attr.Trademark
        End If
        Return Nothing
    End Function

    Public Function getCopyright() As String
        If Not asm Is Nothing Then
            Dim Attr As System.Reflection.AssemblyCopyrightAttribute
            Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyCopyrightAttribute), False)(0)
            Return Attr.Copyright
        End If
        Return Nothing
    End Function

    Public Function getBuildDate() As String
        If Not asm Is Nothing Then
            Return System.IO.File.GetLastWriteTime(asm.Location).ToShortDateString()
        End If
        Return Nothing
    End Function

    Public Function getVersionProduct() As String
        If Not asm Is Nothing Then
            With System.Diagnostics.FileVersionInfo.GetVersionInfo(asm.Location)
                Return .FileMajorPart & "." & .FileMinorPart & "." & .FileBuildPart
            End With

        End If
        Return Nothing
    End Function

#Region "NON ESSENTIALS INFO"

    Public Function getConfigurationAttribute() As String
        If Not asm Is Nothing Then
            Dim Attr As System.Reflection.AssemblyConfigurationAttribute
            Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyConfigurationAttribute), False)(0)
            Return Attr.Configuration
        End If
        Return Nothing
    End Function

    Public Function getCulture() As String
        If Not asm Is Nothing Then
            Dim Attr As System.Reflection.AssemblyCultureAttribute
            Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyCultureAttribute), False)(0)
            Return Attr.Culture
        End If
        Return Nothing
    End Function

    Public Function getDefaultAlias() As String
        If Not asm Is Nothing Then
            Dim Attr As System.Reflection.AssemblyDefaultAliasAttribute
            Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyDefaultAliasAttribute), False)(0)
            Return Attr.DefaultAlias
        End If
        Return Nothing
    End Function

    Public Function getDelaySign() As String
        If Not asm Is Nothing Then
            Dim Attr As System.Reflection.AssemblyDelaySignAttribute
            Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyDelaySignAttribute), False)(0)
            Return Attr.DelaySign
        End If
        Return Nothing
    End Function

    Public Function getFileVersion() As String
        If Not asm Is Nothing Then
            Dim Attr As System.Reflection.AssemblyFileVersionAttribute
            Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyFileVersionAttribute), False)(0)
            Return Attr.Version
        End If
        Return Nothing
    End Function

    Public Function getAssemblyFlags() As String
        If Not asm Is Nothing Then
            Dim Attr As System.Reflection.AssemblyFlagsAttribute
            Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyFlagsAttribute), False)(0)
            Return Attr.AssemblyFlags
        End If
        Return Nothing
    End Function

    Public Function getInformationalVersion() As String
        If Not asm Is Nothing Then
            Dim Attr As System.Reflection.AssemblyInformationalVersionAttribute
            Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyInformationalVersionAttribute), False)(0)
            Return Attr.InformationalVersion
        End If
        Return Nothing
    End Function

    Public Function getKeyFile() As String
        If Not asm Is Nothing Then
            Dim Attr As System.Reflection.AssemblyKeyFileAttribute
            Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyKeyFileAttribute), False)(0)
            Return Attr.KeyFile
        End If
        Return Nothing
    End Function

    Public Function getKeyName() As String
        If Not asm Is Nothing Then
            Dim Attr As System.Reflection.AssemblyKeyNameAttribute
            Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyKeyNameAttribute), False)(0)
            Return Attr.KeyName
        End If
        Return Nothing
    End Function

#End Region

    Public Function AssemblyAttribsList(ByVal a As System.Reflection.Assembly) As Specialized.NameValueCollection

        Dim TypeName As String
        Dim Name As String
        Dim Value As String
        Dim nvc As New Specialized.NameValueCollection
        Dim r As New Regex("(\.Assembly|\.)(?<Name>[^.]*)Attribute$", RegexOptions.IgnoreCase)

        For Each attrib As Object In a.GetCustomAttributes(False)
            TypeName = attrib.GetType().ToString
            Name = r.Match(TypeName).Groups("Name").ToString
            Value = ""
            Select Case TypeName
                Case "System.CLSCompliantAttribute"
                    Value = CType(attrib, CLSCompliantAttribute).IsCompliant.ToString
                Case "System.Diagnostics.DebuggableAttribute"
                    Value = CType(attrib, Diagnostics.DebuggableAttribute).IsJITTrackingEnabled.ToString
                Case "System.Reflection.AssemblyCompanyAttribute"
                    Value = CType(attrib, AssemblyCompanyAttribute).Company.ToString
                Case "System.Reflection.AssemblyConfigurationAttribute"
                    Value = CType(attrib, AssemblyConfigurationAttribute).Configuration.ToString
                Case "System.Reflection.AssemblyCopyrightAttribute"
                    Value = CType(attrib, AssemblyCopyrightAttribute).Copyright.ToString
                Case "System.Reflection.AssemblyDefaultAliasAttribute"
                    Value = CType(attrib, AssemblyDefaultAliasAttribute).DefaultAlias.ToString
                Case "System.Reflection.AssemblyDelaySignAttribute"
                    Value = CType(attrib, AssemblyDelaySignAttribute).DelaySign.ToString
                Case "System.Reflection.AssemblyDescriptionAttribute"
                    Value = CType(attrib, AssemblyDescriptionAttribute).Description.ToString
                Case "System.Reflection.AssemblyInformationalVersionAttribute"
                    Value = CType(attrib, AssemblyInformationalVersionAttribute).InformationalVersion.ToString
                Case "System.Reflection.AssemblyKeyFileAttribute"
                    Value = CType(attrib, AssemblyKeyFileAttribute).KeyFile.ToString
                Case "System.Reflection.AssemblyProductAttribute"
                    Value = CType(attrib, AssemblyProductAttribute).Product.ToString
                Case "System.Reflection.AssemblyTrademarkAttribute"
                    Value = CType(attrib, AssemblyTrademarkAttribute).Trademark.ToString
                Case "System.Reflection.AssemblyTitleAttribute"
                    Value = CType(attrib, AssemblyTitleAttribute).Title.ToString
                Case "System.Resources.NeutralResourcesLanguageAttribute"
                    Value = CType(attrib, Resources.NeutralResourcesLanguageAttribute).CultureName.ToString
                Case "System.Resources.SatelliteContractVersionAttribute"
                    Value = CType(attrib, Resources.SatelliteContractVersionAttribute).Version.ToString
                Case "System.Runtime.InteropServices.ComCompatibleVersionAttribute"
                    Dim x As Runtime.InteropServices.ComCompatibleVersionAttribute
                    x = CType(attrib, Runtime.InteropServices.ComCompatibleVersionAttribute)
                    Value = x.MajorVersion & "." & x.MinorVersion & "." & x.RevisionNumber & "." & x.BuildNumber
                Case "System.Runtime.InteropServices.ComVisibleAttribute"
                    Value = CType(attrib, Runtime.InteropServices.ComVisibleAttribute).Value.ToString
                Case "System.Runtime.InteropServices.GuidAttribute"
                    Value = CType(attrib, Runtime.InteropServices.GuidAttribute).Value.ToString
                Case "System.Runtime.InteropServices.TypeLibVersionAttribute"
                    Dim x As Runtime.InteropServices.TypeLibVersionAttribute
                    x = CType(attrib, Runtime.InteropServices.TypeLibVersionAttribute)
                    Value = x.MajorVersion & "." & x.MinorVersion
                Case "System.Security.AllowPartiallyTrustedCallersAttribute"
                    Value = "(Present)"
                Case Else
                    '-- debug.writeline("** unknown assembly attribute '" & TypeName & "'")
                    Value = TypeName
            End Select

            If nvc.Item(Name) = "" Then
                nvc.Add(Name, Value)
            End If
        Next

        '-- add some extra values that are not in the AssemblyInfo, but nice to have
        With nvc
            '-- codebase
            Try
                .Add("CodeBase", a.CodeBase.Replace("file:///", ""))
            Catch ex As System.NotSupportedException
                .Add("CodeBase", "(not supported)")
            End Try
            '-- build date
            Dim dt As DateTime = AssemblyBuildDate(a)
            If dt = DateTime.MaxValue Then
                .Add("BuildDate", "(unknown)")
            Else
                .Add("BuildDate", dt.ToString("yyyy-MM-dd hh:mm tt"))
            End If
            '-- location
            Try
                .Add("Location", a.Location)
            Catch ex As System.NotSupportedException
                .Add("Location", "(not supported)")
            End Try
            '-- version
            Try
                If a.GetName.Version.Major = 0 And a.GetName.Version.Minor = 0 Then
                    .Add("Version", "(unknown)")
                Else
                    .Add("Version", a.GetName.Version.ToString)
                End If
            Catch ex As Exception
                .Add("Version", "(unknown)")
            End Try

            .Add("FullName", a.FullName)
        End With

        Return nvc
    End Function

    Private Shared Function AssemblyBuildDate(ByVal a As System.Reflection.Assembly, _
        Optional ByVal ForceFileDate As Boolean = False) As DateTime

        Dim AssemblyVersion As System.Version = a.GetName.Version
        Dim dt As DateTime

        If ForceFileDate Then
            dt = AssemblyLastWriteTime(a)
        Else
            dt = CType("01/01/2000", DateTime). _
                AddDays(AssemblyVersion.Build). _
                AddSeconds(AssemblyVersion.Revision * 2)
            If TimeZone.IsDaylightSavingTime(dt, TimeZone.CurrentTimeZone.GetDaylightChanges(dt.Year)) Then
                dt = dt.AddHours(1)
            End If
            If dt > DateTime.Now Or AssemblyVersion.Build < 730 Or AssemblyVersion.Revision = 0 Then
                dt = AssemblyLastWriteTime(a)
            End If
        End If

        Return dt
    End Function

    Private Shared Function AssemblyLastWriteTime(ByVal a As System.Reflection.Assembly) As DateTime
        Try
            Return File.GetLastWriteTime(a.Location)
        Catch ex As Exception
            Return DateTime.MaxValue
        End Try
    End Function

End Class
