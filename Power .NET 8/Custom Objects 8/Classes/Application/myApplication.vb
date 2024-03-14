Imports System.Reflection
Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports Microsoft.Win32
Imports System.Threading

Namespace myApplication

    Namespace Init

        ''' <summary>
        ''' You can set assembly information project within this class and this will not work if you don't make it as variable name
        ''' </summary>
        ''' <remarks></remarks>
        Public Class AssemblyInformation

            Dim asm As System.Reflection.Assembly = Nothing
            Private titleAttr As System.Reflection.AssemblyTitleAttribute
            ' <Assembly: AssemblyDescription("My Assembly Description")>
            Private descAttr As System.Reflection.AssemblyDescriptionAttribute
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

            ''' <summary>
            ''' This method is just an example of how to get the complete information of the assembly project and current domain.
            ''' </summary>
            ''' <param name="asm">A right format for assembly information</param>
            ''' <param name="appDomain">A right format for Current Domain</param>
            ''' <returns>It will return nothing, anyway just for reference code only and not to be used.</returns>
            ''' <remarks>A reference.</remarks>
            Public Function getInstanceAssembly(Optional ByVal asm As String = "System.Reflection.Assembly.GetExecutingAssembly", Optional ByVal appDomain As String = "AppDomain.CurrentDomain")
                'ASM = System.Reflection.Assembly.GetExecutingAssembly
                'AppDomain = AppDomain.CurrentDomain
                Return asm + "   " + appDomain
            End Function

            ''' <summary>
            ''' It sets an assembly to be used as reference within the class
            ''' </summary>
            ''' <param name="asms">Specify the project <c>assembly</c> information</param>
            ''' <remarks></remarks>
            Public Sub setAssembly(ByRef asms As System.Reflection.Assembly)
                asm = asms
            End Sub

            ''' <summary>
            ''' It gets the title of the project
            ''' </summary>
            ''' <returns>Get the title of the assembly project</returns>
            ''' <remarks></remarks>
            Public Function getTitle() As String
                If Not asm Is Nothing Then
                    Dim Attr As System.Reflection.AssemblyTitleAttribute
                    Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyTitleAttribute), False)(0)
                    Return Attr.Title.ToString
                End If
                Return Nothing
            End Function

            ''' <summary>
            ''' It gets the description of the project
            ''' </summary>
            ''' <returns>get the description of the assembly project</returns>
            ''' <remarks></remarks>
            Public Function getDescription() As String
                If Not asm Is Nothing Then
                    Dim Attr As System.Reflection.AssemblyDescriptionAttribute
                    Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyDescriptionAttribute), False)(0)
                    Return Attr.Description.ToString
                End If
                Return Nothing
            End Function

            ''' <summary>
            ''' It gets the company name of the project
            ''' </summary>
            ''' <returns>Get the company name of the assembly information</returns>
            ''' <remarks></remarks>
            Public Function getCompany() As String
                If Not asm Is Nothing Then
                    Dim Attr As System.Reflection.AssemblyCompanyAttribute
                    Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyCompanyAttribute), False)(0)
                    Return Attr.Company.ToString
                End If
                Return Nothing
            End Function

            ''' <summary>
            ''' It gets the product name of the project
            ''' </summary>
            ''' <returns>Get the product name of the assembly information</returns>
            ''' <remarks></remarks>
            Public Function getProduct() As String
                If Not asm Is Nothing Then
                    Dim Attr As System.Reflection.AssemblyProductAttribute
                    Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyProductAttribute), False)(0)
                    Return Attr.Product.ToString
                End If
                Return Nothing
            End Function

            ''' <summary>
            ''' It gets the Trademark of the project
            ''' </summary>
            ''' <returns>Get the trademark of the assembly project</returns>
            ''' <remarks></remarks>
            Public Function getTrademark() As String
                If Not asm Is Nothing Then
                    Dim Attr As System.Reflection.AssemblyTrademarkAttribute
                    Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyTrademarkAttribute), False)(0)
                    Return Attr.Trademark.ToString
                End If
                Return Nothing
            End Function

            ''' <summary>
            ''' It gets the copyright of the project
            ''' </summary>
            ''' <returns>Get the copyright of the assembly information</returns>
            ''' <remarks></remarks>
            Public Function getCopyright() As String
                If Not asm Is Nothing Then
                    Dim Attr As System.Reflection.AssemblyCopyrightAttribute
                    Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyCopyrightAttribute), False)(0)
                    Return Attr.Copyright.ToString
                End If
                Return Nothing
            End Function

            ''' <summary>
            ''' It gets the buiid date of the project
            ''' </summary>
            ''' <returns>Get the build date of the assembly information</returns>
            ''' <remarks></remarks>
            Public Function getBuildDate() As String
                If Not asm Is Nothing Then
                    Return System.IO.File.GetLastWriteTime(asm.Location).ToShortDateString()
                End If
                Return Nothing
            End Function

            ''' <summary>
            ''' It gets the version product of the project
            ''' </summary>
            ''' <returns>Get the version product of the assembly information</returns>
            ''' <remarks></remarks>
            Public Function getVersionProduct() As String
                If Not asm Is Nothing Then
                    With System.Diagnostics.FileVersionInfo.GetVersionInfo(asm.Location)
                        Return .FileMajorPart & "." & .FileMinorPart & "." & .FileBuildPart
                    End With
                End If
                Return Nothing
            End Function

#Region "NON ESSENTIALS INFO"

            ''' <summary>
            ''' It gets the configuration attribute of the project
            ''' </summary>
            ''' <returns>Get the configuration attribute of the assembly information</returns>
            ''' <remarks></remarks>
            Public Function getConfigurationAttribute() As String
                If Not asm Is Nothing Then
                    Try
                        Dim Attr As System.Reflection.AssemblyConfigurationAttribute
                        Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyConfigurationAttribute), False)(0)
                        Return Attr.Configuration.ToString
                    Catch ex As Exception
                        Return ""
                    End Try
                End If
                Return Nothing
            End Function

            ''' <summary>
            ''' It gets the culture of the project
            ''' </summary>
            ''' <returns>Get the culture of the assembly information</returns>
            ''' <remarks></remarks>
            Public Function getCulture() As String
                If Not asm Is Nothing Then
                    Try
                        Dim Attr As System.Reflection.AssemblyCultureAttribute
                        Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyCultureAttribute), False)(0)
                        Return Attr.Culture.ToString
                    Catch ex As Exception
                        Return ""
                    End Try
                End If
                Return Nothing
            End Function

            ''' <summary>
            ''' It gets the assembly version of the project
            ''' </summary>
            ''' <returns>Get the assembly version of the assembly information</returns>
            ''' <remarks></remarks>
            Public Function getAssemblyVersion() As String
                If Not asm Is Nothing Then
                    Try
                        Dim Attr As System.Reflection.AssemblyVersionAttribute
                        Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyVersionAttribute), False)(0)
                        Return Attr.Version.ToString
                    Catch ex As Exception
                        Return ""
                    End Try
                End If
                Return Nothing
            End Function

            ''' <summary>
            ''' It gets the default alias of the project
            ''' </summary>
            ''' <returns>Get the default alias of the assembly information</returns>
            ''' <remarks></remarks>
            Public Function getDefaultAlias() As String
                If Not asm Is Nothing Then
                    Try
                        Dim Attr As System.Reflection.AssemblyDefaultAliasAttribute
                        Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyDefaultAliasAttribute), False)(0)
                        Return Attr.DefaultAlias.ToString
                    Catch ex As Exception
                        Return ""
                    End Try
                End If
                Return Nothing
            End Function

            ''' <summary>
            ''' It gets the delay sign of the project
            ''' </summary>
            ''' <returns>Get the delay sign of the assembly information</returns>
            ''' <remarks></remarks>
            Public Function getDelaySign() As String
                If Not asm Is Nothing Then
                    Try
                        Dim Attr As System.Reflection.AssemblyDelaySignAttribute
                        Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyDelaySignAttribute), False)(0)
                        Return Attr.DelaySign.ToString
                    Catch ex As Exception
                        Return ""
                    End Try
                End If
                Return Nothing
            End Function

            ''' <summary>
            ''' It gets the file verion of the project
            ''' </summary>
            ''' <returns>Get the file version of the assembly information</returns>
            ''' <remarks></remarks>
            Public Function getFileVersion() As String
                If Not asm Is Nothing Then
                    Try
                        Dim Attr As System.Reflection.AssemblyFileVersionAttribute
                        Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyFileVersionAttribute), False)(0)
                        Return Attr.Version.ToString
                    Catch ex As Exception
                        Return ""
                    End Try
                End If
                Return Nothing
            End Function

            ''' <summary>
            ''' It gets the assembly flags of the project
            ''' </summary>
            ''' <returns>Get the assembly flags of the assembly information</returns>
            ''' <remarks></remarks>
            Public Function getAssemblyFlags() As String
                If Not asm Is Nothing Then
                    Try
                        Dim Attr As System.Reflection.AssemblyFlagsAttribute
                        Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyFlagsAttribute), False)(0)
                        Return Attr.AssemblyFlags.ToString
                    Catch ex As Exception
                        Return ""
                    End Try
                End If
                Return Nothing
            End Function

            ''' <summary>
            ''' It gets the information version of the project
            ''' </summary>
            ''' <returns>Get the information version of the assembly information</returns>
            ''' <remarks></remarks>
            Public Function getInformationalVersion() As String
                If Not asm Is Nothing Then
                    Try
                        Dim Attr As System.Reflection.AssemblyInformationalVersionAttribute
                        Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyInformationalVersionAttribute), False)(0)
                        Return Attr.InformationalVersion.ToString
                    Catch ex As Exception
                        Return ""
                    End Try
                End If
                Return Nothing
            End Function

            ''' <summary>
            ''' It gets the keyfile of the project
            ''' </summary>
            ''' <returns>Get the keyfile of the assembly information</returns>
            ''' <remarks></remarks>
            Public Function getKeyFile() As String
                If Not asm Is Nothing Then
                    Try
                        Dim Attr As System.Reflection.AssemblyKeyFileAttribute
                        Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyKeyFileAttribute), False)(0)
                        Return Attr.KeyFile.ToString
                    Catch ex As Exception
                        Return ""
                    End Try
                End If
                Return Nothing
            End Function

            ''' <summary>
            ''' It gets the keyname of the project
            ''' </summary>
            ''' <returns>Get the keyfile of the assembly information</returns>
            ''' <remarks></remarks>
            Public Function getKeyName() As String
                If Not asm Is Nothing Then
                    Try
                        Dim Attr As System.Reflection.AssemblyKeyNameAttribute
                        Attr = asm.GetCustomAttributes(GetType(System.Reflection.AssemblyKeyNameAttribute), False)(0)
                        Return Attr.KeyName.ToString
                    Catch ex As Exception
                        Return ""
                    End Try
                End If
                Return Nothing
            End Function

#End Region

            ''' <summary>
            ''' It gets the assembly attribute list of the project
            ''' </summary>
            ''' <param name="Assembly">Set Assembly Information Project</param>
            ''' <returns>Get the specialized name value collection</returns>
            ''' <remarks></remarks>
            Public Function AssemblyAttribsList(ByVal Assembly As System.Reflection.Assembly) As Specialized.NameValueCollection

                Dim TypeName As String
                Dim Name As String
                Dim Value As String
                Dim nvc As New Specialized.NameValueCollection
                Dim r As New Regex("(\.Assembly|\.)(?<Name>[^.]*)Attribute$", RegexOptions.IgnoreCase)

                For Each attrib As Object In Assembly.GetCustomAttributes(False)
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
                        .Add("CodeBase", Assembly.CodeBase.Replace("file:///", ""))
                    Catch ex As System.NotSupportedException
                        .Add("CodeBase", "(not supported)")
                    End Try
                    '-- build date
                    Dim dt As DateTime = AssemblyBuildDate(Assembly)
                    If dt = DateTime.MaxValue Then
                        .Add("BuildDate", "(unknown)")
                    Else
                        .Add("BuildDate", dt.ToString("yyyy-MM-dd hh:mm tt"))
                    End If
                    '-- location
                    Try
                        .Add("Location", Assembly.Location)
                    Catch ex As System.NotSupportedException
                        .Add("Location", "(not supported)")
                    End Try
                    '-- version
                    Try
                        If Assembly.GetName.Version.Major = 0 And Assembly.GetName.Version.Minor = 0 Then
                            .Add("Version", "(unknown)")
                        Else
                            .Add("Version", Assembly.GetName.Version.ToString)
                        End If
                    Catch ex As Exception
                        .Add("Version", "(unknown)")
                    End Try

                    .Add("FullName", Assembly.FullName)
                End With

                Return nvc
            End Function

            ''' <summary>
            ''' It gets the assembly buildate of the project
            ''' </summary>
            ''' <param name="Assembly">Set Assembly Information Project</param>
            ''' <param name="ForceFileDate">It enables to force the file date of the assembly</param>
            ''' <returns>Get the assembly information build date</returns>
            ''' <remarks></remarks>
            Private Shared Function AssemblyBuildDate(ByVal Assembly As System.Reflection.Assembly, _
                Optional ByVal ForceFileDate As Boolean = False) As DateTime

                Dim AssemblyVersion As System.Version = Assembly.GetName.Version
                Dim dt As DateTime

                If ForceFileDate Then
                    dt = AssemblyLastWriteTime(Assembly)
                Else
                    dt = CType("01/01/2000", DateTime). _
                        AddDays(AssemblyVersion.Build). _
                        AddSeconds(AssemblyVersion.Revision * 2)
                    If TimeZone.IsDaylightSavingTime(dt, TimeZone.CurrentTimeZone.GetDaylightChanges(dt.Year)) Then
                        dt = dt.AddHours(1)
                    End If
                    If dt > DateTime.Now Or AssemblyVersion.Build < 730 Or AssemblyVersion.Revision = 0 Then
                        dt = AssemblyLastWriteTime(Assembly)
                    End If
                End If

                Return dt
            End Function

            ''' <summary>
            ''' It gets the last write time of the assembly information project
            ''' </summary>
            ''' <param name="Assembly">Set the assembly information project</param>
            ''' <returns>Get the last write time of the assembly information</returns>
            ''' <remarks></remarks>
            Private Shared Function AssemblyLastWriteTime(ByVal Assembly As System.Reflection.Assembly) As DateTime
                Try
                    Return File.GetLastWriteTime(Assembly.Location)
                Catch ex As Exception
                    Return DateTime.MaxValue
                End Try
            End Function

        End Class

    End Namespace

    Namespace Share

        ''' <summary>
        ''' This class is used for saving or loading registry information of the system. It is also good alternative other than saving into database or local file.
        ''' </summary>
        ''' <remarks></remarks>
        Public Class Registry

            ''' <summary>
            ''' It sets and save the registry information
            ''' </summary>
            ''' <param name="strSection">Specify the section of the registry settings</param>
            ''' <param name="strKey">Specify the key of the registry settings</param>
            ''' <param name="strVal">Write the value of the registry that you have specified</param>
            ''' <remarks></remarks>
            Public Shared Sub SaveRegistrySetting(ByVal strSection As String, ByVal strKey As String, ByVal strVal As String)
                SaveSetting(modApp.getTitle, strSection, strKey, strVal)
            End Sub

            ''' <summary>
            ''' It gets the previous data of the registry information
            ''' </summary>
            ''' <param name="strSection">Specify the section of the registry settings</param>
            ''' <param name="strKey">Specify the key of the registry settings</param>
            ''' <returns>Get the value of the previous registry settings that have been saved</returns>
            ''' <remarks></remarks>
            Public Shared Function GetRegistrySetting(ByVal strSection As String, ByVal strKey As String) As String
                Return GetSetting(modApp.getTitle, strSection, strKey)
            End Function

        End Class


        Public Class SystemCore

            Private emssMutex As Mutex

            Public Shared Sub Initialize(ByRef Parent As Form, ByVal basePath As String)

                AddHandler Application.ThreadException, AddressOf myExceptionHandler.OnThreadException

                'checking if sql connection exist...'
                'myDocument.Share.XMLDesigner.DatabaseConfig.readDatabaseConfig(basePath)


                Parent.ShowDialog()

            End Sub

        End Class

    End Namespace

End Namespace




