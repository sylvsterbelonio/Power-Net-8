Imports System.Reflection
Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports Microsoft.Win32
Public Class myAbout

    'Friend myDialog As New myDialog
    Friend myAssembly As New myAssemblyInfo
    Friend myFile As New myFile.Share.Files
    Private ProjectName As String = ""
    Private frm As New frmAbout
    Private _ExecutingAssemblyName As String
    Private _EntryAssemblyName As String
    Private _CallingAssemblyName As String
    'Private myThemes As MyObject.ThemeNames = MyObject.ThemeNames.Original

    'Public Sub set_class(Optional ByVal myTheme As MyObject.ThemeNames = MyObject.ThemeNames.Original)
    '    myThemes = myTheme
    'End Sub

    Public Sub run(ByRef asm As System.Reflection.Assembly, ByRef appDomains As System.AppDomain, ByVal location As String, Optional ByVal underLicenseName As String = "City of Malaybalay", Optional ByVal developersName As String = "City Programmers Group", Optional ByVal url As String = "http://www.myurl.com", Optional ByVal LogoImage As Image = Nothing)

        Dim Comments As String = ""
        Dim Credits As String = ""

        myAssembly.set_assembly(asm)
        With myAssembly
            'frm.set_class(myThemes)
            frm.lblProjectName.Text = .getTitle
            frm.rtbDescription.Text = .getDescription
            frm.lblCompany.Text = .getCompany
            frm.lblBuildDate.Text = .getBuildDate
            frm.lblCopyRight.Text = .getCopyright
            frm.lblProduct.Text = .getProduct
            frm.lblVersion.Text = .getVersionProduct
            frm.lblDeveloper.Text = developersName
            frm.lnkURL.Text = url
            frm.LogoImage = LogoImage
        End With

        'myDialog.set_class(myThemes)

        'LOAD LICENSES HERE'
        If (Comments = "") Then
            Dim lic As String = location & "\Templates\Help\license.rtf"
            If System.IO.File.Exists(lic) Then
                frm.rtfLicense1.LoadFile(lic, System.Windows.Forms.RichTextBoxStreamType.RichText)
            End If
        ElseIf (Comments.ToLower().EndsWith(".txt") Or Comments.ToLower().EndsWith(".rtf")) And System.IO.File.Exists(Comments) Then
            If Comments.ToLower().EndsWith(".txt") Then
                frm.rtfLicense1.LoadFile(Comments, System.Windows.Forms.RichTextBoxStreamType.RichText)
            Else
                frm.rtfLicense1.LoadFile(Comments, System.Windows.Forms.RichTextBoxStreamType.PlainText)
            End If
        Else
            frm.rtfLicense1.Text = Comments
        End If

        'LOAD CREDITS HERE'
        If (Credits = "") Then
            Dim cre As String = location & "\Templates\Help\credits.rtf"
            If System.IO.File.Exists(cre) Then
                frm.rtfCredits.LoadFile(cre, System.Windows.Forms.RichTextBoxStreamType.RichText)
            End If
        ElseIf (Credits.ToLower().EndsWith(".txt") Or Credits.ToLower().EndsWith(".rtf")) And System.IO.File.Exists(Credits) Then
            If Credits.ToLower().EndsWith(".txt") Then
                frm.rtfCredits.LoadFile(Credits, System.Windows.Forms.RichTextBoxStreamType.RichText)
            Else
                frm.rtfCredits.LoadFile(Credits, System.Windows.Forms.RichTextBoxStreamType.PlainText)
            End If
        Else
            frm.rtfCredits.Text = Credits
        End If

        '-- if the user didn't provide an assembly, try to guess which one is the entry assembly
        If asm Is Nothing Then
            asm = [Assembly].GetEntryAssembly
        End If
        If asm Is Nothing Then
            asm = [Assembly].GetExecutingAssembly
        End If

        _ExecutingAssemblyName = [Assembly].GetExecutingAssembly.GetName.Name
        _CallingAssemblyName = [Assembly].GetCallingAssembly.GetName.Name
        Try
            '-- for web hosted apps, GetEntryAssembly = nothing
            _EntryAssemblyName = [Assembly].GetEntryAssembly.GetName.Name
        Catch ex As Exception
        End Try

        PopulateAssemblies(asm)
        PopulateAppInfo(appDomains)
        PopulateAssemblyDetails(asm, frm.lvAssemblyDetails)
        Dim mydia As New myDialog.messageBoxes
        mydia.show_form(frm, "About")
    End Sub

    Private Sub PopulateAssemblies(ByVal asm As System.Reflection.Assembly)
        For Each a As [Assembly] In AppDomain.CurrentDomain.GetAssemblies
            PopulateAssemblySummary(a)
        Next
        'frm.cboAssemblyNames.SelectedIndex = cboAssemblyNames.FindStringExact(_EntryAssemblyName)
    End Sub

    Private Sub PopulateAssemblySummary(ByVal a As [Assembly])
        Dim nvc As Specialized.NameValueCollection = myAssembly.AssemblyAttribsList(a)

        Dim strAssemblyName As String = a.GetName.Name

        Dim lvi As New ListViewItem
        With lvi
            .Text = strAssemblyName
            .Tag = strAssemblyName
            If strAssemblyName = _CallingAssemblyName Then
                .Text &= " (calling)"
            End If
            If strAssemblyName = _ExecutingAssemblyName Then
                .Text &= " (executing)"
            End If
            If strAssemblyName = _EntryAssemblyName Then
                .Text &= " (entry)"
            End If
            .SubItems.Add(nvc.Item("version"))
            .SubItems.Add(nvc.Item("builddate"))
            .SubItems.Add(nvc.Item("codebase"))
        End With
        frm.lvAssemblyInfo.Items.Add(lvi)
        'frm.cboAssemblyNames.Items.Add(strAssemblyName)
    End Sub

    Private Sub PopulateAssemblyDetails(ByVal a As System.Reflection.Assembly, ByVal lvw As ListView)
        lvw.Items.Clear()

        '-- this assembly property is only available in framework versions 1.1+
        Populate(lvw, "Image Runtime Version", a.ImageRuntimeVersion)
        Populate(lvw, "Loaded from GAC", a.GlobalAssemblyCache.ToString)

        Dim nvc As Specialized.NameValueCollection = myAssembly.AssemblyAttribsList(a)
        For Each strKey As String In nvc
            Populate(lvw, strKey, nvc.Item(strKey))
        Next

    End Sub

    Private Sub Populate(ByVal lvw As ListView, ByVal Key As String, ByVal Value As String)
        If Value = "" Then Return
        Dim lvi As New ListViewItem
        lvi.Text = Key
        lvi.SubItems.Add(Value)
        lvw.Items.Add(lvi)
    End Sub

    Private Sub PopulateAppInfo(ByVal d As System.AppDomain)
        'Dim d As System.AppDomain = System.AppDomain.CurrentDomain
        Populate(frm.lvAppInfo, "Application Name", d.SetupInformation.ApplicationName)
        Populate(frm.lvAppInfo, "Application Base", d.SetupInformation.ApplicationBase)
        Populate(frm.lvAppInfo, "Cache Path", d.SetupInformation.CachePath)
        Populate(frm.lvAppInfo, "Configuration File", d.SetupInformation.ConfigurationFile)
        Populate(frm.lvAppInfo, "Dynamic Base", d.SetupInformation.DynamicBase)
        Populate(frm.lvAppInfo, "Friendly Name", d.FriendlyName)
        Populate(frm.lvAppInfo, "License File", d.SetupInformation.LicenseFile)
        Populate(frm.lvAppInfo, "Private Bin Path", d.SetupInformation.PrivateBinPath)
        Populate(frm.lvAppInfo, "Shadow Copy Directories", d.SetupInformation.ShadowCopyDirectories)
        Populate(frm.lvAppInfo, " ", " ")
        Populate(frm.lvAppInfo, "Entry Assembly", _EntryAssemblyName)
        Populate(frm.lvAppInfo, "Executing Assembly", _ExecutingAssemblyName)
        Populate(frm.lvAppInfo, "Calling Assembly", _CallingAssemblyName)
    End Sub

End Class
