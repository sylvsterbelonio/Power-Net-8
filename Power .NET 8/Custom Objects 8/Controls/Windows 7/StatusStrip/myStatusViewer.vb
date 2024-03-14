Public Class MyStatusViewer

#Region "PROPERTIES"

    Private timer As New Timer
    Private users As String = "{user}"

    Public Property My_User() As String
        Get
            Return users
        End Get
        Set(ByVal value As String)
            users = value
            lblcuser.Text = "User: " + users
        End Set
    End Property

    Private role As String = "{role}"

    Public Property My_RoleName() As String
        Get
            Return role
        End Get
        Set(ByVal value As String)
            role = value
            lblcrole.Text = "Role: " + value
        End Set
    End Property

    Private database As String = "{database}"

    Public Property My_Database() As String
        Get
            Return database
        End Get
        Set(ByVal value As String)
            database = value
            lblcdatabase.Text = "Database: " + value
        End Set
    End Property

    Private FillbackColor As Color = Color.White

    'Public Property My_Fill_Backcolor() As Color
    '    Get
    '        Return FillbackColor
    '    End Get
    '    Set(ByVal value As Color)
    '        FillbackColor = value
    '        Me.Invalidate()
    '    End Set
    'End Property

    Private CaptionBackcolor As Color = Color.White

    Public Property My_Caption_Backcolor() As Color
        Get
            Return CaptionBackcolor
        End Get
        Set(ByVal value As Color)
            CaptionBackcolor = value
            Me.Invalidate()
        End Set
    End Property

    Private FillforeColor As Color = Color.Black

    Public Property My_Fill_Forecolor() As Color
        Get
            Return FillforeColor
        End Get
        Set(ByVal value As Color)
            FillforeColor = value
            Me.Invalidate()
        End Set
    End Property

    Private CaptionForecolor As Color = Color.Green

    Public Property My_Caption_Forecolor() As Color
        Get
            Return CaptionForecolor
        End Get
        Set(ByVal value As Color)
            CaptionForecolor = value
            Me.Invalidate()
        End Set
    End Property

    Private GoodColor As Color = Color.Green
    Private MedColor As Color = Color.Orange
    Private BadColor As Color = Color.Red

    Public Property My_Connection_Quality_Good() As Color
        Get
            Return GoodColor
        End Get
        Set(ByVal value As Color)
            GoodColor = value
        End Set
    End Property

    Public Property My_Connection_Quality_Intermediate() As Color
        Get
            Return MedColor
        End Get
        Set(ByVal value As Color)
            MedColor = value
            Me.Invalidate()
        End Set
    End Property

    Public Property My_Connection_Quality_Poor() As Color
        Get
            Return BadColor
        End Get
        Set(ByVal value As Color)
            BadColor = value
            Me.Invalidate()
        End Set
    End Property

    Public Property My_BackgroundColor_Top1() As Color
        Get
            Return stMain.My_BackGround_TopColor1
        End Get
        Set(ByVal value As Color)
            stMain.My_BackGround_TopColor1 = value
        End Set
    End Property

    Public Property My_BackgroundColor_Top2() As Color
        Get
            Return stMain.My_BackGround_TopColor2
        End Get
        Set(ByVal value As Color)
            stMain.My_BackGround_TopColor2 = value
        End Set
    End Property

    Public Property My_BackgroundColor_Bottom1() As Color
        Get
            Return stMain.My_BackGround_BottomColor1
        End Get
        Set(ByVal value As Color)
            stMain.My_BackGround_BottomColor1 = value
        End Set
    End Property

    Public Property My_BackgroundColor_Bottom2() As Color
        Get
            Return stMain.My_BackGround_BottomColor2
        End Get
        Set(ByVal value As Color)
            stMain.My_BackGround_BottomColor2 = value
        End Set
    End Property

    Public Property My_Background_BorderColor() As Color
        Get
            Return stMain.My_BackGround_BorderColor
        End Get
        Set(ByVal value As Color)
            stMain.My_BackGround_BorderColor = value
        End Set
    End Property

    Public Property My_Background_Has_Border() As Boolean
        Get
            Return stMain.My_BackGround_Has_Border
        End Get
        Set(ByVal value As Boolean)
            stMain.My_BackGround_Has_Border = value
        End Set
    End Property

#End Region

    Private Sub update_colors()
        With stMain
            .My_Label_BackColor = CaptionBackcolor
            With lblcuser 'Caption Users
                .ForeColor = CaptionForecolor
                .BackColor = CaptionBackcolor
            End With
            'With lbluser 'Fill Users
            '    .ForeColor = FillforeColor
            '    .BackColor = FillbackColor
            'End With
            With lblcrole 'Caption Role
                .ForeColor = CaptionForecolor
                .BackColor = CaptionBackcolor
            End With
            'With lblrole 'Fill Role
            '    .ForeColor = FillforeColor
            '    .BackColor = FillbackColor
            'End With
            With lblcConnectionQuality 'Caption Connection Quality
                .ForeColor = CaptionForecolor
                .BackColor = CaptionBackcolor
            End With
            'With lblConnectionQuality 'Fill Connection Quality
            '    '.ForeColor = FillforeColor
            '    .BackColor = FillbackColor
            'End With
            With lblcConnectionType 'Caption Connection Type
                .ForeColor = CaptionForecolor
                .BackColor = CaptionBackcolor
            End With
            'With lblConnectionType 'Fill Connection Type
            '    .ForeColor = FillforeColor
            '    '.BackColor = FillbackColor
            'End With
            With lblcdatabase 'Caption Database
                .ForeColor = CaptionForecolor
                .BackColor = CaptionBackcolor
            End With
            'With lblDatabase 'Fill Database
            '    .ForeColor = FillforeColor
            '    .BackColor = FillbackColor
            'End With
            With lblVacant 'Caption Vacant
                .ForeColor = CaptionForecolor
                .BackColor = CaptionBackcolor
            End With
            With lblnum 'Caption NUM
                .ForeColor = CaptionForecolor
                .BackColor = CaptionBackcolor
            End With
            With lblcap 'Caption CAP
                .ForeColor = CaptionForecolor
                .BackColor = CaptionBackcolor
            End With
            With lblscr 'Caption SCR
                .ForeColor = CaptionForecolor
                .BackColor = CaptionBackcolor
            End With
        End With
    End Sub

    Private Sub myStatusViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timer.Interval = 1000
        Timer.Start()
        AddHandler Timer.Tick, AddressOf Time_Tick
    End Sub

    Private Sub Time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If sender Is Nothing OrElse e Is Nothing Then
            Return
        End If
        StatusStrip_UpdateLocks()
        CheckInetConnection()
    End Sub

    Public Enum InetConnState
        modem = &H1
        lan = &H2
        proxy = &H4
        ras = &H10
        offline = &H20
        configured = &H40
    End Enum

    Private Declare Function InternetGetConnectedState Lib "wininet.dll" (ByRef lpSFlags As Int32, ByVal dwReserved As Int32) As Boolean
    Private ConnectionStateString As String
    Private ConnectionQualityString As String = "Off"
    Private ConnectionColor As Color

    Public Function CheckInetConnection() As Boolean

        Dim lngFlags As Long
        CheckInetConnection = False

        If InternetGetConnectedState(lngFlags, 0) Then
            ' True
            If lngFlags And InetConnState.lan Then
                ConnectionStateString = "LAN"
                Select Case ConnectionQualityString
                    Case "Good"
                        ConnectionColor = My_Connection_Quality_Good
                        ConnectionQualityString = "Good"
                    Case "Intermittent"
                        ConnectionColor = My_Connection_Quality_Intermediate
                        ConnectionQualityString = "Good"
                    Case "Off"
                        ConnectionColor = My_Connection_Quality_Poor
                        ConnectionQualityString = "Intermittent"
                End Select
            ElseIf lngFlags And InetConnState.modem Then
                ConnectionStateString = "Modem"
                Select Case ConnectionQualityString
                    Case "Good"
                        ConnectionColor = My_Connection_Quality_Good
                        ConnectionQualityString = "Good"
                    Case "Intermittent"
                        ConnectionColor = My_Connection_Quality_Intermediate
                        ConnectionQualityString = "Good"
                    Case "Off"
                        ConnectionColor = My_Connection_Quality_Poor
                        ConnectionQualityString = "Intermittent"
                End Select
            ElseIf lngFlags And InetConnState.configured Then
                ConnectionStateString = "Configured"
                Select Case ConnectionQualityString
                    Case "Good"
                        ConnectionColor = My_Connection_Quality_Good
                        ConnectionQualityString = "Good"
                    Case "Intermittent"
                        ConnectionColor = My_Connection_Quality_Intermediate
                        ConnectionQualityString = "Good"
                    Case "Off"
                        ConnectionColor = My_Connection_Quality_Poor
                        ConnectionQualityString = "Intermittent"
                End Select
            ElseIf lngFlags And InetConnState.proxy Then
                ConnectionStateString = "Proxy"
                Select Case ConnectionQualityString
                    Case "Good"
                        ConnectionColor = My_Connection_Quality_Good
                        ConnectionQualityString = "Good"
                    Case "Intermittent"
                        ConnectionColor = My_Connection_Quality_Intermediate
                        ConnectionQualityString = "Good"
                    Case "Off"
                        ConnectionColor = My_Connection_Quality_Poor
                        ConnectionQualityString = "Intermittent"
                End Select
            ElseIf lngFlags And InetConnState.ras Then
                Select Case ConnectionQualityString
                    Case "Good"
                        ConnectionColor = My_Connection_Quality_Good
                        ConnectionQualityString = "Good"
                    Case "Intermittent"
                        ConnectionColor = My_Connection_Quality_Intermediate
                        ConnectionQualityString = "Good"
                    Case "Off"
                        ConnectionColor = My_Connection_Quality_Poor
                        ConnectionQualityString = "Intermittent"
                End Select
            ElseIf lngFlags And InetConnState.offline Then
                ConnectionStateString = "Offline"
                Select Case ConnectionQualityString
                    Case "Good"
                        ConnectionColor = My_Connection_Quality_Good
                        ConnectionQualityString = "Good"
                    Case "Intermittent"
                        ConnectionColor = My_Connection_Quality_Intermediate
                        ConnectionQualityString = "Good"
                    Case "Off"
                        ConnectionColor = My_Connection_Quality_Poor
                        ConnectionQualityString = "Intermittent"
                End Select
            End If
        Else
            ' False
            ConnectionStateString = "Not Connected"
            Select Case ConnectionQualityString
                Case "Good"
                    ConnectionColor = My_Connection_Quality_Good
                    ConnectionQualityString = "Good"
                Case "Intermittent"
                    ConnectionColor = My_Connection_Quality_Intermediate
                    ConnectionQualityString = "Good"
                Case "Off"
                    ConnectionColor = My_Connection_Quality_Poor
                    ConnectionQualityString = "Intermittent"
            End Select
        End If

        lblcConnectionType.Text = "Connection Type: " + ConnectionStateString
        lblcConnectionQuality.Text = "Connection Quality: " + ConnectionQualityString
        lblcConnectionQuality.ForeColor = ConnectionColor
        Dim width As Integer = stMain.Width
        Dim total As Integer = lblcuser.Width + lblcrole.Width + lblcConnectionType.Width + lblcdatabase.Width + lblnum.Width + lblcap.Width + lblscr.Width
        Dim diff As Integer = width - total
        lblVacant.Width = diff - 180
    End Function

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        Me.Dock = DockStyle.Bottom
        update_colors()
    End Sub

    Private Sub adjust_vacancies()
        Dim total_Width As Integer = 0
        total_Width = (lblcuser.Width + lblcuser.Width + lblcrole.Width + lblcrole.Width + lblcConnectionQuality.Width + lblcConnectionQuality.Width + lblcConnectionType.Width + lblcConnectionType.Width + lblcdatabase.Width + lblcdatabase.Width + lblnum.Width + lblcap.Width + lblscr.Width)
        total_Width = (stMain.Width - 15) - total_Width
        If total_Width > 0 Then
            lblVacant.Width = total_Width
        Else
            lblVacant.Width = 1
        End If
    End Sub

    Private Sub stMain_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles stMain.SizeChanged
        adjust_vacancies()
    End Sub

    Private Sub lbl_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        adjust_vacancies()
    End Sub

    Public Sub StatusStrip_UpdateLocks()
        lblnum.ForeColor = IIf(My.Computer.Keyboard.NumLock, Color.Black, Color.Beige)
        lblcap.ForeColor = IIf(My.Computer.Keyboard.CapsLock, Color.Black, Color.Beige)
        lblscr.ForeColor = IIf(My.Computer.Keyboard.ScrollLock, Color.Black, Color.Beige)
    End Sub

    Private Sub lblcuser_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblcuser.TextChanged
        lblcuser.Width = lblcuser.Width + 15
        adjust_vacancies()
    End Sub

    Private Sub lblcrole_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblcrole.TextChanged
        lblcrole.Width = lblcrole.Width + 15
        adjust_vacancies()
    End Sub

    Private Sub lblcConnectionQuality_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblcConnectionQuality.TextChanged
        lblcConnectionQuality.Width = lblcConnectionQuality.Width + 15
        adjust_vacancies()
    End Sub

    Private Sub lblcConnectionType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcConnectionType.Click
        lblcConnectionType.Width = lblcConnectionType.Width + 15
        adjust_vacancies()
    End Sub

    Private Sub lblcdatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcdatabase.Click
        lblcdatabase.Width = lblcdatabase.Width + 15
        adjust_vacancies()
    End Sub

    Private Sub stMain_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles stMain.ItemClicked

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub
End Class
