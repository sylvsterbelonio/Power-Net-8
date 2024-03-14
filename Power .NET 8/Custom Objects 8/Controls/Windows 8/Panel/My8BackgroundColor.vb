<ToolboxBitmapAttribute(GetType(Panel))> _
Public Class My8BackgroundColor

    Private colObjects_BackgroundColor As New Collection
    Private colObjects_SColor As New Collection
    Private timer As New Timer
    Private validateGroupName As New myValidation.Init.StringReader
    Private validateColorName As New myValidation.Init.StringReader
    Public Event ColorPicked(ByVal color As Color)

#Region "PROPERTIES"

    Private myThemeColor As String = "black"
    Public Property groupColorNameTag() As String
        Get
            Return myThemeColor
        End Get
        Set(ByVal value As String)
            If validateGroupName.validateIFContains(value.ToLower) Then
                myThemeColor = value.ToLower
            Else
                myThemeColor = "black"
            End If
            programSelectionSColor()
        End Set
    End Property

    Private myColorName As String = "A1"
    Public Property ColorNameTag() As String
        Get
            Return myColorName
        End Get
        Set(ByVal value As String)
            If validateColorName.validateIFContains(value.ToUpper) Then
                myColorName = value.ToUpper
            Else
                myColorName = "A1"
            End If
            programSelectionBackgroundColor()
        End Set
    End Property

    Private Sub addControls()
        With colObjects_BackgroundColor
            .Clear()
            .Add(pnl01)
            .Add(pnl02)
            .Add(pnl03)
            .Add(pnl04)
            .Add(pnl05)
            .Add(pnl06)

            .Add(pnl11)
            .Add(pnl12)
            .Add(pnl13)
            .Add(pnl14)
            .Add(pnl15)
            .Add(pnl16)

            .Add(pnl21)
            .Add(pnl22)
            .Add(pnl23)
            .Add(pnl24)
            .Add(pnl25)
            .Add(pnl26)
        End With

        With colObjects_SColor
            .Add(pnlS1)
            .Add(pnlS2)
            .Add(pnlS3)
            .Add(pnlS4)
            .Add(pnlS5)
            .Add(pnlS6)

            .Add(pnlS7)
            .Add(pnlS8)
            .Add(pnlS9)
            .Add(pnlS10)
            .Add(pnlS11)
            .Add(pnlS12)

            .Add(pnlS13)
            .Add(pnlS14)
            .Add(pnlS15)
            .Add(pnlS16)
            .Add(pnlS17)
            .Add(pnlS18)
        End With
    End Sub

#End Region

#Region "BACKGROUND COLOR"

    Private Sub initializeValidation()
        With validateGroupName
            .clear()
            .groupParameters("black,gray,red,scarlet,orange,orangeyellow,yelloworange,yellow,yellowgreen,green")
            .groupParameters("bluegreen,skyblue,cyan,blue,blueviolete,violete,pink,hotpink")
        End With
        With validateColorName
            .clear()
            .groupParameters("A1,A2,A3,A4,A5,A6")
            .groupParameters("B1,B2,B3,B4,B5,B6")
            .groupParameters("C1,C2,C3,C4,C5,C6")
        End With
    End Sub

    Private Sub reloadBackgroundColor(ByVal SColor As String)
        Select Case SColor
            Case "black"
                assignColors(myColor.Share.SystemColor.BackgroundColor.General.TypeColor.black)

            Case "gray"
                assignColors(myColor.Share.SystemColor.BackgroundColor.General.TypeColor.gray)

            Case "blueviolete"
                assignColors(myColor.Share.SystemColor.BackgroundColor.General.TypeColor.blueviolete)

            Case "violete"
                assignColors(myColor.Share.SystemColor.BackgroundColor.General.TypeColor.violete)

            Case "pink"
                assignColors(myColor.Share.SystemColor.BackgroundColor.General.TypeColor.pink)

            Case "hotpink"
                assignColors(myColor.Share.SystemColor.BackgroundColor.General.TypeColor.hotpink)

            Case "red"
                assignColors(myColor.Share.SystemColor.BackgroundColor.General.TypeColor.red)

            Case "scarlet"
                assignColors(myColor.Share.SystemColor.BackgroundColor.General.TypeColor.scarlet)

            Case "orange"
                assignColors(myColor.Share.SystemColor.BackgroundColor.General.TypeColor.orange)

            Case "orangeyellow"
                assignColors(myColor.Share.SystemColor.BackgroundColor.General.TypeColor.orangeyellow)

            Case "yelloworange"
                assignColors(myColor.Share.SystemColor.BackgroundColor.General.TypeColor.yelloworange)

            Case "yellow"
                assignColors(myColor.Share.SystemColor.BackgroundColor.General.TypeColor.yellow)

            Case "yellowgreen"
                assignColors(myColor.Share.SystemColor.BackgroundColor.General.TypeColor.yellowgreen)

            Case "green"
                assignColors(myColor.Share.SystemColor.BackgroundColor.General.TypeColor.green)

            Case "bluegreen"
                assignColors(myColor.Share.SystemColor.BackgroundColor.General.TypeColor.bluegreen)

            Case "skyblue"
                assignColors(myColor.Share.SystemColor.BackgroundColor.General.TypeColor.skyblue)

            Case "cyan"
                assignColors(myColor.Share.SystemColor.BackgroundColor.General.TypeColor.cyan)

            Case "blue"
                assignColors(myColor.Share.SystemColor.BackgroundColor.General.TypeColor.blue)

        End Select
    End Sub

    Private Sub assignColors(ByVal type As myColor.Share.SystemColor.BackgroundColor.General.TypeColor)
        Dim row As Integer = 0
        Dim column As Integer = 0
        For Each obj As Object In colObjects_BackgroundColor
            If column <= 5 Then
                CType(obj, Panel).BackColor = myColor.Share.SystemColor.BackgroundColor.General.GetBackgroundColor(type, row, column)
                column += 1
            Else
                row += 2
                CType(obj, Panel).BackColor = myColor.Share.SystemColor.BackgroundColor.General.GetBackgroundColor(type, row, 0)
                column = 1
            End If
        Next
    End Sub

    Private Sub resetBackGroundColor()
        For Each obj As Object In colObjects_BackgroundColor
            With CType(obj, Panel)
                .Tag = ""
                .Refresh()
            End With
        Next
    End Sub

    Private Sub check(ByVal g As Graphics)
        Dim img As Bitmap = myIcons.Share.Jquery.GetJqueryIcons(myIcons.Share.Jquery.JqueryIconTypes.check, myImage.Share.Controls.Buttons.Icon.getJqueryImage, 16, 16)
        g.DrawImage(img, New Point(40, 1))
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        find_and_check("stoping the object....")
    End Sub

    Private Sub find_and_check(Optional ByVal type As String = "")
        For Each obj As Object In colObjects_BackgroundColor
            If CType(obj, Panel).Tag = "locked" Then
                'MsgBox(CType(obj, Panel).Name + "," + CType(obj, Panel).Tag)
                If type = "" Then
                    timer.Interval = 50
                    AddHandler timer.Tick, AddressOf Timer1_Tick
                    timer.Start()
                Else
                    timer.Stop()
                    CType(obj, Panel).Refresh()
                    check(CType(obj, Panel).CreateGraphics)
                End If
                RaiseEvent ColorPicked(obj.backcolor)
                Exit Sub
            End If
        Next
    End Sub

#Region "EVENTS"

    Private Sub findBackgroundColor(ByVal name As String)
        For Each obj As Object In colObjects_BackgroundColor
            With CType(obj, Panel)
                If .Name = name Then
                    check(obj.createGraphics)
                    .Tag = "locked"
                    Exit Sub
                End If
            End With
        Next
    End Sub

    Private Sub programSelectionBackgroundColor()
        resetBackGroundColor()
        Select Case myColorName
            Case "A1"
                findBackgroundColor("pnl01")
            Case "A2"
                findBackgroundColor("pnl02")
            Case "A3"
                findBackgroundColor("pnl03")
            Case "A4"
                findBackgroundColor("pnl04")
            Case "A5"
                findBackgroundColor("pnl05")
            Case "A6"
                findBackgroundColor("pnl06")

            Case "B1"
                findBackgroundColor("pnl11")
            Case "B2"
                findBackgroundColor("pnl12")
            Case "B3"
                findBackgroundColor("pnl13")
            Case "B4"
                findBackgroundColor("pnl14")
            Case "B5"
                findBackgroundColor("pnl15")
            Case "B6"
                findBackgroundColor("pnl16")

            Case "C1"
                findBackgroundColor("pnl21")
            Case "C2"
                findBackgroundColor("pnl22")
            Case "C3"
                findBackgroundColor("pnl23")
            Case "C4"
                findBackgroundColor("pnl24")
            Case "C5"
                findBackgroundColor("pnl25")
            Case "C6"
                findBackgroundColor("pnl26")
        End Select
    End Sub

    Private myColorTagName As String = ""

    Public Sub setColorTagName(ByVal value As String)
        myColorTagName = value
    End Sub
    Public Function getColorTagName()
        Return myColorTagName
    End Function
    Private Sub changeTagName(ByVal obj As Panel)
        Select Case obj.Name
            Case "pnl01"
                myColorTagName = "A1"
            Case "pnl02"
                myColorTagName = "A2"
            Case "pnl03"
                myColorTagName = "A3"
            Case "pnl04"
                myColorTagName = "A4"
            Case "pnl05"
                myColorTagName = "A5"
            Case "pnl06"
                myColorTagName = "A6"

            Case "pnl11"
                myColorTagName = "B1"
            Case "pnl12"
                myColorTagName = "B2"
            Case "pnl13"
                myColorTagName = "B3"
            Case "pnl14"
                myColorTagName = "B4"
            Case "pnl15"
                myColorTagName = "B5"
            Case "pnl16"
                myColorTagName = "B6"

            Case "pnl21"
                myColorTagName = "C1"
            Case "pnl22"
                myColorTagName = "C2"
            Case "pnl23"
                myColorTagName = "C3"
            Case "pnl24"
                myColorTagName = "C4"
            Case "pnl25"
                myColorTagName = "C5"
            Case "pnl26"
                myColorTagName = "C6"
        End Select


    End Sub

    Private Sub pnl01_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnl01.MouseClick, pnl02.MouseClick, pnl03.MouseClick, pnl04.MouseClick, pnl05.MouseClick, pnl06.MouseClick, _
                                pnl11.MouseClick, pnl12.MouseClick, pnl13.MouseClick, pnl14.MouseClick, pnl15.MouseClick, pnl16.MouseClick, _
                                pnl21.MouseClick, pnl22.MouseClick, pnl23.MouseClick, pnl24.MouseClick, pnl25.MouseClick, pnl26.MouseClick

        If CType(sender, Panel).Tag <> "locked" Then
            resetBackGroundColor()
            check(sender.createGraphics)
            sender.tag = "locked"
        End If
        changeTagName(sender)
        RaiseEvent ColorPicked(sender.backcolor)
    End Sub

    Private Sub pnl01_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnl01.MouseLeave, pnl02.MouseLeave, pnl03.MouseLeave, pnl04.MouseLeave, pnl05.MouseLeave, pnl06.MouseLeave, _
                                pnl11.MouseLeave, pnl12.MouseLeave, pnl13.MouseLeave, pnl14.MouseLeave, pnl15.MouseLeave, pnl16.MouseLeave, _
                                pnl21.MouseLeave, pnl22.MouseLeave, pnl23.MouseLeave, pnl24.MouseLeave, pnl25.MouseLeave, pnl26.MouseLeave
        If sender.tag <> "locked" Then
            drawRectangle(sender, CType(sender, Panel).CreateGraphics, sender.width - 2, sender.height - 2, "leave")
        End If
    End Sub

    Private Sub pnl01_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnl01.MouseMove, pnl02.MouseMove, pnl03.MouseMove, pnl04.MouseMove, pnl05.MouseMove, pnl06.MouseMove, _
                                pnl11.MouseMove, pnl12.MouseMove, pnl13.MouseMove, pnl14.MouseMove, pnl15.MouseMove, pnl16.MouseMove, _
                                pnl21.MouseMove, pnl22.MouseMove, pnl23.MouseMove, pnl24.MouseMove, pnl25.MouseMove, pnl26.MouseMove
        If sender.tag <> "locked" Then
            drawRectangle(sender, CType(sender, Panel).CreateGraphics, sender.width - 2, sender.height - 2)
        End If
    End Sub

#End Region

#End Region

#Region "S COLOR"

    Private Sub reloadSBackgroundColor()
        Dim count As Integer = 0
        For Each obj As Object In colObjects_SColor
            CType(obj, Panel).BackColor = myColor.Share.SystemColor.BackgroundColor.General.getSColor(count)
            count += 1
        Next
    End Sub

    Private Sub drawRectangle(ByVal obj As Object, ByVal g As Graphics, ByVal width As Integer, ByVal height As Integer, Optional ByVal type As String = "move")
        If type = "move" Then
            g.DrawRectangle(New Pen(Color.White, 2), New Rectangle(1, 1, width, height))
        Else
            Dim pen As Pen = New Pen(CType(obj, Panel).BackColor, 2)
            g.DrawRectangle(pen, New Rectangle(1, 1, width, height))
        End If
    End Sub

    Private Sub resetSHeight()
        For Each obj As Object In colObjects_SColor
            With CType(obj, Panel)
                .Height = 21
                .Tag = ""
                drawRectangle(obj, .CreateGraphics, .Width - 2, .Height - 2, "leave")
            End With
        Next
    End Sub

    Private myGroupNameTag As String
    Public Sub setGroupNameTag(ByVal value As String)
        myGroupNameTag = value
    End Sub
    Public Function getGroupNameTag()
        Return myGroupNameTag
    End Function
    Private Sub changeGroupTagName(ByVal obj As Panel)
        Select Case obj.Name
            Case "pnlS1"
                myGroupNameTag = "black"
            Case "pnlS2"
                myGroupNameTag = "gray"
            Case "pnlS3"
                myGroupNameTag = "blueviolete"
            Case "pnlS4"
                myGroupNameTag = "violete"
            Case "pnlS5"
                myGroupNameTag = "pink"
            Case "pnlS6"
                myGroupNameTag = "hotpink"
            Case "pnlS7"
                myGroupNameTag = "scarlet"
            Case "pnlS8"
                myGroupNameTag = "red"
            Case "pnlS9"
                myGroupNameTag = "orange"
            Case "pnlS10"
                myGroupNameTag = "orangeyellow"
            Case "pnlS11"
                myGroupNameTag = "yelloworange"
            Case "pnlS12"
                myGroupNameTag = "yellow"
            Case "pnlS13"
                myGroupNameTag = "yellowgreen"
            Case "pnlS14"
                myGroupNameTag = "green"
            Case "pnlS15"
                myGroupNameTag = "bluegreen"
            Case "pnlS16"
                myGroupNameTag = "skyblue"
            Case "pnlS17"
                myGroupNameTag = "cyan"
            Case "pnlS18"
                myGroupNameTag = "blue"
        End Select
    End Sub


    Private Sub selectBackground(ByVal name As String)
        Select Case name
            Case "pnlS1"
                reloadBackgroundColor("black")
            Case "pnlS2"
                reloadBackgroundColor("gray")
            Case "pnlS3"
                reloadBackgroundColor("blueviolete")
            Case "pnlS4"
                reloadBackgroundColor("violete")
            Case "pnlS5"
                reloadBackgroundColor("pink")
            Case "pnlS6"
                reloadBackgroundColor("hotpink")
            Case "pnlS7"
                reloadBackgroundColor("scarlet")
            Case "pnlS8"
                reloadBackgroundColor("red")
            Case "pnlS9"
                reloadBackgroundColor("orange")
            Case "pnlS10"
                reloadBackgroundColor("orangeyellow")
            Case "pnlS11"
                reloadBackgroundColor("yelloworange")
            Case "pnlS12"
                reloadBackgroundColor("yellow")
            Case "pnlS13"
                reloadBackgroundColor("yellowgreen")
            Case "pnlS14"
                reloadBackgroundColor("green")
            Case "pnlS15"
                reloadBackgroundColor("bluegreen")
            Case "pnlS16"
                reloadBackgroundColor("skyblue")
            Case "pnlS17"
                reloadBackgroundColor("cyan")
            Case "pnlS18"
                reloadBackgroundColor("blue")
        End Select
        find_and_check()
    End Sub

#Region "EVENTS"

    Private Sub findSelectedSColor(ByVal name As String)
        For Each obj As Object In colObjects_SColor
            With CType(obj, Panel)
                If .Name = name Then
                    .Tag = "locked"
                    drawRectangle(obj, .CreateGraphics, .Width - 2, .Height - 2, "leave")
                    .Height = 34
                    drawRectangle(obj, .CreateGraphics, .Width - 2, .Height - 2)
                    selectBackground(.Name)
                End If
            End With
        Next
    End Sub

    Private Sub programSelectionSColor()
        resetSHeight()
        Select Case myThemeColor
            Case "black"
                findSelectedSColor("pnlS1")
            Case "gray"
                findSelectedSColor("pnlS2")
            Case "blueviolete"
                findSelectedSColor("pnlS3")
            Case "violete"
                findSelectedSColor("pnlS4")
            Case "pink"
                findSelectedSColor("pnlS5")
            Case "hotpink"
                findSelectedSColor("pnlS6")
            Case "scarlet"
                findSelectedSColor("pnlS7")
            Case "red"
                findSelectedSColor("pnlS8")
            Case "orange"
                findSelectedSColor("pnlS9")
            Case "orangeyellow"
                findSelectedSColor("pnlS10")
            Case "yelloworange"
                findSelectedSColor("pnlS11")
            Case "yellow"
                findSelectedSColor("pnlS12")
            Case "yellowgreen"
                findSelectedSColor("pnlS13")
            Case "green"
                findSelectedSColor("pnlS14")
            Case "bluegreen"
                findSelectedSColor("pnlS15")
            Case "skyblue"
                findSelectedSColor("pnlS16")
            Case "cyan"
                findSelectedSColor("pnlS17")
            Case "blue"
                findSelectedSColor("pnlS18")
        End Select
    End Sub

    Private Sub pnlS1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlS1.MouseClick, pnlS2.MouseClick, pnlS3.MouseClick, pnlS4.MouseClick, pnlS5.MouseClick, pnlS6.MouseClick, pnlS7.MouseClick, pnlS8.MouseClick, pnlS9.MouseClick, pnlS10.MouseClick, pnlS11.MouseClick, pnlS12.MouseClick, pnlS13.MouseClick, pnlS14.MouseClick, pnlS15.MouseClick, pnlS16.MouseClick, pnlS17.MouseClick, pnlS18.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            resetSHeight()
            CType(sender, Panel).Tag = "locked"
            drawRectangle(sender, CType(sender, Panel).CreateGraphics, sender.width - 2, sender.height - 2, "leave")
            CType(sender, Panel).Height = 34
            drawRectangle(sender, CType(sender, Panel).CreateGraphics, sender.width - 2, sender.height - 2)
            selectBackground(sender.name)
            changeGroupTagName(sender)
        End If
    End Sub

    Private Sub pnlS1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlS1.MouseLeave, pnlS2.MouseLeave, pnlS3.MouseLeave, pnlS4.MouseLeave, pnlS5.MouseLeave, pnlS6.MouseLeave, pnlS7.MouseLeave, pnlS8.MouseLeave, pnlS9.MouseLeave, pnlS10.MouseLeave, pnlS11.MouseLeave, pnlS12.MouseLeave, pnlS13.MouseLeave, pnlS14.MouseLeave, pnlS15.MouseLeave, pnlS16.MouseLeave, pnlS17.MouseLeave, pnlS18.MouseLeave
        If CType(sender, Panel).Tag <> "locked" Then
            drawRectangle(sender, CType(sender, Panel).CreateGraphics, sender.width - 2, sender.height - 2, "leave")
        End If
    End Sub

    Private Sub pnlS1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlS1.MouseMove, pnlS2.MouseMove, pnlS3.MouseMove, pnlS4.MouseMove, pnlS5.MouseMove, pnlS6.MouseMove, pnlS7.MouseMove, pnlS8.MouseMove, pnlS9.MouseMove, pnlS10.MouseMove, pnlS11.MouseMove, pnlS12.MouseMove, pnlS13.MouseMove, pnlS14.MouseMove, pnlS15.MouseMove, pnlS16.MouseMove, pnlS17.MouseMove, pnlS18.MouseMove
        If CType(sender, Panel).Tag <> "locked" Then
            drawRectangle(sender, CType(sender, Panel).CreateGraphics, sender.width - 2, sender.height - 2)
        End If
    End Sub

#End Region

#End Region

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        addControls()
        initializeValidation()

        Me.BackColor = myColor.Share.Converter.StringToColor.getHTMLColor("#EAEAEA")
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub pnlBackgroundColor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reloadSBackgroundColor()
        reloadBackgroundColor("black")
        resetSHeight()
    End Sub

    Private Sub pnl01_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnl01.Paint

    End Sub

    Private Sub pnl06_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnl06.Paint

    End Sub
End Class
