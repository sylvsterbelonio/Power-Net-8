Public Class myLibrary

    Private based_frmz As Form

#Region "CREATE TIME LABELED RIGHT SIDE OF TOOLSTRIP"
    Private _toolstrip As ToolStrip
    Private timers As New Timer

    Public Sub create_time_ticker(ByRef toolstrip_ As ToolStrip)
        _toolstrip = toolstrip_
        timers.Interval = 200
        timers.Start()
        AddHandler timers.Tick, AddressOf Timer1_Tick
        Dim tsTime As New ToolStripLabel
        With tsTime
            .Alignment = ToolStripItemAlignment.Right
            .Text = "Synchronizing the time..."
            .Name = "lbltime"
        End With
        toolstrip_.Items.Add(tsTime)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If sender Is Nothing OrElse e Is Nothing Then
            Return
        End If
        Dim dt As New myDate.Init.Format
        Dim obj As New myObjectFetcher
        obj.set_data(_toolstrip, dt.get_current_time, "lbltime")
    End Sub

#End Region

#Region "CREATE TOOLS"

    Public Sub create_tools_application(ByRef toolstripmenuitem As ToolStripMenuItem, ByRef based_form As Form)
        based_frmz = based_form

        Dim calc As New ToolStripMenuItem
        With calc
            .Text = "Calculator"
            .Image = My.Resources.Utilities_calculator_icon
            .ToolTipText = "Open Calculator Application"
            AddHandler .Click, AddressOf My_Tools_Click
        End With
        Dim note As New ToolStripMenuItem
        With note
            .Text = "Notepad"
            .Image = My.Resources.Notepad___icon
            .ToolTipText = "Open Notepad Application"
            AddHandler .Click, AddressOf My_Tools_Click
        End With
        Dim word As New ToolStripMenuItem
        With word
            .Text = "Microsoft Word"
            .Image = My.Resources.word
            .ToolTipText = "Open Microsoft Word Application"
            AddHandler .Click, AddressOf My_Tools_Click
        End With
        Dim exel As New ToolStripMenuItem
        With exel
            .Text = "Microsoft Excel"
            .Image = My.Resources.Microsoft_Excel_icon
            .ToolTipText = "Open Microsoft Excel Application"
            AddHandler .Click, AddressOf My_Tools_Click
        End With
        Dim ppnt As New ToolStripMenuItem
        With ppnt
            .Text = "Microsoft Power Point"
            .Image = My.Resources.power_point_icon
            .ToolTipText = "Open Microsoft Power Point Application"
            AddHandler .Click, AddressOf My_Tools_Click
        End With
        Dim reader As New ToolStripMenuItem
        With reader
            .Text = "Adobe Reader"
            .Image = My.Resources.Adobe_Acrobat_Reader_icon
            .ToolTipText = "Open Adobe Reader Application"
            AddHandler .Click, AddressOf My_Tools_Click
        End With

        With toolstripmenuitem.DropDown.Items
            .Add(calc)
            .Add(note)
            .Add(word)
            .Add(exel)
            .Add(ppnt)
            .Add(reader)
        End With
    End Sub

    Private Sub My_Tools_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case CType(sender, ToolStripMenuItem).Text
            Case "Calculator"
                myForm.Open_Application(myForm.Applications.calculator, based_frmz)
            Case "Notepad"
                myForm.Open_Application(myForm.Applications.notepad, based_frmz)
            Case "Microsoft Word"
                myForm.Open_Application(myForm.Applications.winword, based_frmz)
            Case "Microsoft Excel"
                myForm.Open_Application(myForm.Applications.excel, based_frmz)
            Case "Microsoft Power Point"
                myForm.Open_Application(myForm.Applications.powerpoint, based_frmz)
            Case "Adobe Reader"
                myForm.Open_Application(myForm.Applications.adobe_reader, based_frmz)
        End Select

    End Sub

#End Region

#Region "CREATE WINDOWS"

    Public Sub create_windows_event(ByRef toolstripmenuitem As ToolStripMenuItem, ByRef form_base As Form)
        based_frmz = form_base
        Dim ArrangeIcon As New ToolStripMenuItem
        With ArrangeIcon
            .Text = "&Arrange Icons"
            .ToolTipText = "Arrange All Windows"
            .Image = My.Resources.layers_stack_arrange_icon
            AddHandler .Click, AddressOf WINDOWS_Click
        End With
        Dim Cascade As New ToolStripMenuItem
        With Cascade
            .Text = "&Cascade"
            .ToolTipText = "Cascade All Windows"
            .Image = My.Resources.Fatcow_Farm_Fresh_Application_cascade
            AddHandler .Click, AddressOf WINDOWS_Click
        End With
        Dim CloseAll As New ToolStripMenuItem
        With CloseAll
            .Text = "C&lose All Windows"
            .ToolTipText = "Close All Windows"
            '.Image = My.Resources.lock
            AddHandler .Click, AddressOf WINDOWS_Click
        End With
        Dim Horizon As New ToolStripMenuItem
        With Horizon
            .Text = "Tile Hori&zontally"
            .ToolTipText = "Tile Horizontally All Windows"
            .Image = My.Resources.Fatcow_Farm_Fresh_Application_tile_horizontal
            AddHandler .Click, AddressOf WINDOWS_Click
        End With
        Dim Vertcl As New ToolStripMenuItem
        With Vertcl
            .Text = "Tile &Vertically"
            .ToolTipText = "Tile Vertically All Windows"
            .Image = My.Resources.Fatcow_Farm_Fresh_Application_tile_vertical
            AddHandler .Click, AddressOf WINDOWS_Click
        End With
        Dim Minn As New ToolStripMenuItem
        With Minn
            .Text = "Minimize All Windows"
            .ToolTipText = "Minimize All Windows"
            '.Image = My.Resources.lock
            AddHandler .Click, AddressOf WINDOWS_Click
        End With
        With toolstripmenuitem.DropDown.Items
            .Add(ArrangeIcon)
            .Add(Cascade)
            .Add(Horizon)
            .Add(Vertcl)
            .Add(Minn)
            .Add(CloseAll)
        End With
    End Sub

    Private Sub WINDOWS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case CType(sender, ToolStripMenuItem).Text.ToLower
            Case "&arrange icons"
                based_frmz.LayoutMdi(MdiLayout.ArrangeIcons)
            Case "&cascade"
                based_frmz.LayoutMdi(MdiLayout.Cascade)
            Case "c&lose all windows"
                Dim ctl As Control
                Dim frmMdiChild As Form
                For Each ctl In based_frmz.MdiChildren
                    Try
                        ' Attempt to cast the control to type Form.
                        frmMdiChild = CType(ctl, Form)
                        frmMdiChild.Close()
                    Catch ex As Exception
                        ' Catch and ignore the error if Exception.
                        MsgBox("Error while checking if the ChildForm is loaded.", ex.Message)
                    End Try
                Next
            Case "tile hori&zontally"
                based_frmz.LayoutMdi(MdiLayout.TileHorizontal)
            Case "tile &vertically"
                based_frmz.LayoutMdi(MdiLayout.TileVertical)
            Case "minimize all windows"
                Dim ctl As Control
                Dim frmMdiChild As Form
                For Each ctl In based_frmz.MdiChildren
                    Try
                        ' Attempt to cast the control to type Form.
                        frmMdiChild = CType(ctl, Form)
                        frmMdiChild.WindowState = FormWindowState.Minimized
                    Catch ex As Exception
                        ' Catch and ignore the error if Exception.
                        MsgBox("Error while checking if the ChildForm is loaded.", ex.Message)
                    End Try
                Next
        End Select
    End Sub

#End Region

#Region "CREATE ABOUT"

    Private appDomains As System.AppDomain
    Private LicenseNames As String
    Private DevelopersNames As String
    Private URLS As String
    Private asmF As System.Reflection.Assembly
    Private location As String
    Private logoImages As Image

    Public Sub create_about(ByRef toolstripmenuitem As ToolStripMenuItem, _
    ByVal asm As System.Reflection.Assembly, _
    ByVal appDomain As System.AppDomain, _
    ByVal myLocation As String, _
    Optional ByVal LicenseName As String = "City of Malaybalay", _
    Optional ByVal DevelopersName As String = "Sylvster R. Belonio", _
    Optional ByVal URL As String = "www.sample.com", _
    Optional ByVal logoImage As Image = Nothing)
        logoImages = logoImage
        asmF = asm
        appDomains = appDomain
        location = myLocation
        LicenseNames = LicenseName
        DevelopersNames = DevelopersName
        URLS = URL
        'Mythemes = myThemes_

        Dim About As New ToolStripMenuItem
        With About
            .Text = "About"
            .ToolTipText = "About the System"
            '.Image = My.Resources.Tpdkdesign_net_Refresh_Cl_System_Security_Center
            AddHandler .Click, AddressOf ABOUT_Click
        End With

        With toolstripmenuitem.DropDown.Items
            .Add(About)
        End With

    End Sub

    Private Sub ABOUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case CType(sender, ToolStripMenuItem).Text
            Case "About"
                Dim myCP As New PowerNET8.myAbout
                'myCP.set_class(Mythemes)
                myCP.run(asmF, appDomains, location, LicenseNames, DevelopersNames, URLS, logoImages)
        End Select
    End Sub

#End Region

#Region "CREATE LOCK/LOG OUT/EXIT"

    Private form_loginz As Form
    Private curUserNames As String
    Private myTable As String
    Private usernameField As String
    Private passwordField As String
    Private myLogo As Image = Nothing
    Private myShadowImage As Image = Nothing
    Private myShaowOpacity As Decimal = 0.75
    Friend myDialog As New myDialog.messageBoxes
    Friend myCon As New myConnector
    Friend mySql As New mySQL.Init.SQL

    Public Sub create_lock_logout_exit(ByRef toolstripmenuitem As ToolStripMenuItem, _
    ByRef form_base As Form, _
    ByRef connector As myConnector, _
    ByRef mySqls As mySQL.Init.SQL, _
    ByVal asm As System.Reflection.Assembly, _
    ByVal curUsername As String, _
    ByVal myLocation As String, _
    Optional ByVal Logo As Image = Nothing, _
    Optional ByVal table As String = "tblusers", _
    Optional ByVal usernameCol As String = "username", _
    Optional ByVal passwordCol As String = "password")
        'myDialog.set_class(Mythemes)
        based_frmz = form_base
        mySql = mySqls
        myCon = connector
        asmF = asm
        location = myLocation
        myLogo = Logo
        myTable = table
        curUserNames = curUsername
        usernameField = usernameCol
        passwordField = passwordCol
        'Mythemes = myThemes_
        'myDialog.set_class(myThemes_)
        'form_loginz = form_login

        Dim ChangePassword As New ToolStripMenuItem
        With ChangePassword
            .Text = "Change User Password"
            .ToolTipText = "Change Your Password"
            .Image = My.Resources.Tpdkdesign_net_Refresh_Cl_System_Security_Center
            AddHandler .Click, AddressOf LOCKLOGEXIT_Click
        End With
        Dim systemL As New ToolStripMenuItem
        With systemL
            .Text = "System Locked"
            .ToolTipText = "Put System Locked"
            .Image = My.Resources.lock
            AddHandler .Click, AddressOf LOCKLOGEXIT_Click
        End With
        Dim signOut As New ToolStripMenuItem
        With signOut
            .Text = "Log Out"
            .ToolTipText = "Log Out the Application"
            .Image = My.Resources._exit
            AddHandler .Click, AddressOf LOCKLOGEXIT_Click
        End With
        Dim exits As New ToolStripMenuItem
        With exits
            .Text = "Exit"
            .ToolTipText = "Exit the Application"
            .Image = My.Resources.button_cancel
            AddHandler .Click, AddressOf LOCKLOGEXIT_Click
        End With
        Dim ns As New ToolStripSeparator
        Dim ne As New ToolStripSeparator
        With toolstripmenuitem.DropDown.Items
            .Add(ns)
            .Add(ChangePassword)
            .Add(systemL)
            .Add(signOut)
            .Add(ne)
            .Add(exits)
        End With
    End Sub






    Dim myShadowOpacity As Decimal = 0.75

    Private Sub LOCKLOGEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case CType(sender, ToolStripMenuItem).Text
            Case "Change User Password"
                Dim myCP As New PowerNET8.myChangePassword
                myCP.run(mySql, curUserNames, myTable, usernameField, passwordField)
            Case "System Locked"
                Dim myLock As New PowerNET8.mySystemLock
                myLock.run(based_frmz, mySql, asmF, curUserNames, myTable, usernameField, passwordField, myLogo)
            Case "Log Out"
                based_frmz.Hide()
                Dim myLogIn As New PowerNET8.myLogIns
                If myLogIn.run(myCon, mySql, asmF, location, myTable, usernameField, passwordField, curUserNames, myLogo, myShadowImage, myShadowOpacity) Then
                    based_frmz.Show()
                End If
            Case "Exit"
                If myDialog.show("Are you sure you want to exit application?", "Exit Confirm", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    based_frmz.Close()
                End If
        End Select
    End Sub

#End Region
End Class
