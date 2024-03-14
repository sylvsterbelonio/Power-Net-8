Public Class PDB
    Public runCode As String = ""
    Private timer As New Timer
    Public typeDialog As String
    Public return_values As MsgBoxResult
    Public userThemes As String
    Dim content_ As String
    Dim title_ As String
    Dim style_ As MessageBoxButtons
    Dim icon_ As MessageBoxIcon
    Dim timer1 As New Timer
    Dim slowTimer As New Timer


    Sub New(Optional ByVal content As String = "", Optional ByVal title As String = "The system said", Optional ByVal style As MessageBoxButtons = MessageBoxButtons.OK, Optional ByVal icons As MessageBoxIcon = MessageBoxIcon.None, Optional ByVal DialogWidth As Integer = 314, Optional ByVal DialogHeight As Integer = 114)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        'myThemes = themes
        title_ = title
        content_ = content
        icon_ = icons
        style_ = style
        If title_ <> "" Then
            Me.Text = title_
        Else
            Me.Text = "The system said:"
        End If
        Me.Width = DialogWidth
        Me.Height = DialogHeight

    End Sub

    Private Sub PDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        slowTimer.Interval = 50
        AddHandler slowTimer.Tick, AddressOf Timer2_Tick
        If runCode = "masterkey" Then
            If typeDialog = "plain" Then
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                imgClose.Visible = True
                imgClose.Image = myIcons.Share.Jquery.GetJqueryIcons(myIcons.Share.Jquery.JqueryIconTypes.close, My.Resources.ui_icons_070603_256x240, 16, 16)
                imgClose.Top = 10
                imgClose.Left = Me.Width - imgClose.Width

                'myEvents.Share.TitleBar.ActiveWindow.addEvent(timer1, Me, "", "masterkey")
                Dim getThemes As New myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue
                getThemes = myDocument.Share.XMLDesigner.ThemesConfig.readThemes(userThemes)
                Dim colObjects As New Collection

                myEvents.Share.Buttons.AddEvent(Button1, getThemes, "masterkey")
                myEvents.Share.Buttons.AddEvent(Button2, getThemes, "masterkey")
                myEvents.Share.Buttons.AddEvent(Button3, getThemes, "masterkey")
                Panel1.BackColor = myColor.Share.Tools.Brightness.Apply(myColor.Share.Converter.StringToColor.getHTMLColor(getThemes.accentColor), 0.9)

                SplitContainer1.BackColor = myColor.Share.Tools.Brightness.Apply(myColor.Share.Converter.StringToColor.getHTMLColor(getThemes.backgroundColor), sCONTENT)
                SplitContainer1.Panel1.BackColor = myColor.Share.Tools.Brightness.Apply(myColor.Share.Converter.StringToColor.getHTMLColor(getThemes.backgroundColor), sCONTENT)
                SplitContainer1.Panel2.BackColor = myColor.Share.Tools.Brightness.Apply(myColor.Share.Converter.StringToColor.getHTMLColor(getThemes.backgroundColor), sCONTENT)
                lblContent.BackColor = Color.Transparent
                imgClose.BackColor = myColor.Share.Tools.Brightness.Apply(myColor.Share.Converter.StringToColor.getHTMLColor(getThemes.backgroundColor), sCONTENT)
            ElseIf typeDialog = "windows8" Then
                PowerNET8.myFunctions.Share.Themes.GetThemes(Me, timer, userThemes, True)
                lblContent.BackColor = Color.Transparent

                Dim getThemes As New myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue
                getThemes = myDocument.Share.XMLDesigner.ThemesConfig.readThemes(userThemes)
                Panel1.BackColor = myColor.Share.Tools.Brightness.Apply(myColor.Share.Converter.StringToColor.getHTMLColor(getThemes.accentColor), 0.9)

                SplitContainer1.BackColor = myColor.Share.Tools.Brightness.Apply(myColor.Share.Converter.StringToColor.getHTMLColor(getThemes.backgroundColor), sCONTENT)
                SplitContainer1.Panel1.BackColor = myColor.Share.Tools.Brightness.Apply(myColor.Share.Converter.StringToColor.getHTMLColor(getThemes.backgroundColor), sCONTENT)
                SplitContainer1.Panel2.BackColor = myColor.Share.Tools.Brightness.Apply(myColor.Share.Converter.StringToColor.getHTMLColor(getThemes.backgroundColor), sCONTENT)
                lblContent.BackColor = Color.Transparent

            End If
            initialize_form()
        Else
            activationRequired("PDB_Load.Form")
        End If
        slowTimer.Start()
    End Sub

    Private Sub click_event_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click, Button3.Click
        Select Case DirectCast(sender, Button).Text
            Case "Abort"
                return_values = MsgBoxResult.Abort
            Case "Retry"
                return_values = MsgBoxResult.Retry
            Case "Ignore"
                return_values = MsgBoxResult.Ignore
            Case "Cancel"
                return_values = MsgBoxResult.Cancel
            Case "Yes"
                return_values = MsgBoxResult.Yes
            Case "No"
                return_values = MsgBoxResult.No
            Case Else
                return_values = MsgBoxResult.Ok
        End Select
        Me.Close()
    End Sub

    Private Sub initialize_form()
        'TableLayoutPanel1.ColumnStyles.Item(0).Width = 50
        picIcon.Visible = True

        lblContent.Text = content_

        Select Case icon_
            Case MessageBoxIcon.Asterisk
                picIcon.Image = myIcons.Share.DialogBox.getIcon(myIcons.Share.DialogBox.Type.Information, , "masterkey")
                System.Media.SystemSounds.Asterisk.Play()
            Case MessageBoxIcon.Error
                picIcon.Image = myIcons.Share.DialogBox.getIcon(myIcons.Share.DialogBox.Type.Errors, , "masterkey")
                System.Media.SystemSounds.Hand.Play()
            Case MessageBoxIcon.Exclamation
                picIcon.Image = myIcons.Share.DialogBox.getIcon(myIcons.Share.DialogBox.Type.Errors, , "masterkey")
                System.Media.SystemSounds.Hand.Play()
            Case MessageBoxIcon.Hand
                System.Media.SystemSounds.Hand.Play()
            Case MessageBoxIcon.Information
                picIcon.Image = myIcons.Share.DialogBox.getIcon(myIcons.Share.DialogBox.Type.Information, , "masterkey")
                System.Media.SystemSounds.Asterisk.Play()
            Case MessageBoxIcon.Question
                picIcon.Image = myIcons.Share.DialogBox.getIcon(myIcons.Share.DialogBox.Type.Question, , "masterkey")
                System.Media.SystemSounds.Asterisk.Play()
            Case MessageBoxIcon.Stop
                picIcon.Image = myIcons.Share.DialogBox.getIcon(myIcons.Share.DialogBox.Type.Errors, , "masterkey")
                System.Media.SystemSounds.Hand.Play()
            Case MessageBoxIcon.Warning
                picIcon.Image = myIcons.Share.DialogBox.getIcon(myIcons.Share.DialogBox.Type.Warning, , "masterkey")
                System.Media.SystemSounds.Beep.Play()
            Case Else
                SplitContainer1.Panel1Collapsed = True
                picIcon.Image = Nothing
                picIcon.Visible = False
                picIcon.BackColor = Color.White
                System.Media.SystemSounds.Beep.Play()
        End Select

        Select Case style_
            Case MessageBoxButtons.AbortRetryIgnore

                Button3.Text = "Abort"
                Button3.Visible = True
                Button2.Text = "Retry"
                Button2.Visible = True
                Button1.Text = "Ignore"
                Button1.Visible = True
                Me.AcceptButton = Button3
                Me.CancelButton = Button1

            Case MessageBoxButtons.OKCancel

                Button3.Visible = False
                Button2.Text = "Ok"
                Button1.Text = "Cancel"
                Me.AcceptButton = Button2
                Me.CancelButton = Button1

            Case MessageBoxButtons.RetryCancel

                Button3.Visible = False
                Button2.Text = "Retry"
                Button1.Text = "Cancel"
                Me.AcceptButton = Button2
                Me.CancelButton = Button1

            Case MessageBoxButtons.YesNo

                Button3.Visible = False
                Button2.Text = "Yes"
                Button1.Text = "No"
                Me.AcceptButton = Button2
                Me.CancelButton = Button1

            Case MessageBoxButtons.YesNoCancel

                Button3.Text = "Yes"
                Button3.Visible = True
                Button2.Text = "No"
                Button2.Visible = True
                Button1.Text = "Cancel"
                Button1.Visible = True
                Me.AcceptButton = Button3
                Me.CancelButton = Button1

            Case Else

                Button3.Visible = False
                Button2.Visible = False
                Button1.Visible = True
                Button1.Text = "Ok"
                Me.AcceptButton = Button1

        End Select

    End Sub

    Private Sub imgClose_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgClose.MouseClick
        Me.Close()
    End Sub

    Private Sub imgClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles imgClose.MouseLeave
        imgClose.Image = myIcons.Share.Jquery.GetJqueryIcons(myIcons.Share.Jquery.JqueryIconTypes.close, My.Resources.ui_icons_070603_256x240, 16, 16)
    End Sub

    Private Sub imgClose_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgClose.MouseMove
        imgClose.Image = myIcons.Share.Jquery.GetJqueryIcons(myIcons.Share.Jquery.JqueryIconTypes.close, My.Resources.gray_jquery, 16, 16)
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        slowTimer.Stop()
        Me.Opacity = 1
    End Sub

End Class