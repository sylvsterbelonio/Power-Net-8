Public Class myNavigationGrid
    Friend myPicture As New PowerNET8.myPicture
    Friend myObject As New PowerNET8.MyObject

    Private ui_icon_normal As Image = My.Resources.ui_icons_2e83ff_256x240
    Private ui_icon_hover As Image = My.Resources.red_jquery_icon
    Private ui_icon_active As Image = My.Resources.ui_icons_2e83ff_256x240
    Private ui_icon_disable As Image
    Private myObjectData As New DataTable
    Private sql_loader As Boolean = False

    Private isSetDatagridView As Boolean = False
    Private colObjects As New Collection

    Friend mySql As New PowerNET8.mySQL.Init.SQL
    Friend myDialog As New PowerNET8.myDialog.messageBoxes


    Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub reload_images()
        myPicture.ui_Icons(cmdFirst, ui_icon_normal, 24, 24)
        myPicture.ui_Icons(cmdPrev, ui_icon_normal, 24, 24)
        myPicture.ui_Icons(cmdNext, ui_icon_normal, 24, 24)
        myPicture.ui_Icons(cmdLast, ui_icon_normal, 24, 24)
    End Sub

    Private Sub initialize_forms()
        txtPageNum.BackColor = OnLostBack
        txtPageNum.ForeColor = OnLostFore
        cboPageType.BackColor = OnLostBack
        cboPageType.ForeColor = OnLostFore
        lblPageTotal.ForeColor = OnLostFore
        lblRemarks.ForeColor = OnLostFore
        cboPageType.Text = "25"

        colObjects.Add(tsMain)
        'myObject.load(colObjects, myThm, mySql)

        'If Not myObject.get_ui_icon_normal Is Nothing Then ui_icon_normal = myObject.get_ui_icon_normal
        'If Not myObject.get_ui_icon_hover Is Nothing Then ui_icon_hover = myObject.get_ui_icon_hover
        'If Not myObject.get_ui_icon_active Is Nothing Then ui_icon_active = myObject.get_ui_icon_active

    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        reload_images()
    End Sub

    Private Sub mySearchTool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize_forms()
        reload_images()
    End Sub

    Public Sub set_class(ByVal mysqls As PowerNET8.mySQL.Init.SQL)
        mySql = mysqls
        'myDialog.set_class(myThm)
    End Sub

    Private max_page As Long = 1
    Private ini_page As Long = 1
    Private max_record As Long = 1
    Private start_record As Long = 1
    Private end_record As Long = 1
    Private DGV As DataGridView

#Region "SKIN CONTROL"
#Region "SELECTION STYLE"

    Public Property My_Skin_Selection_Style_Custom_Select_Has_Border() As Boolean
        Get
            Return Me.tsMain.My_Selection_Style_Custom_Select_Has_Border
        End Get
        Set(ByVal value As Boolean)
            tsMain.My_Selection_Style_Custom_Select_Has_Border = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_Skin_Standard_Select_FontColor() As Color
        Get
            Return Me.tsMain.My_Standard_Select_FontColor
        End Get
        Set(ByVal value As Color)
            tsMain.My_Standard_Select_FontColor = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_Skin_Selection_Style_Custom_Select_BorderColor() As Color
        Get
            Return Me.tsMain.My_Selection_Style_Custom_Select_BorderColor
        End Get
        Set(ByVal value As Color)
            tsMain.My_Selection_Style_Custom_Select_BorderColor = value
        End Set
    End Property
    Public Property My_Skin_Selection_Style_Custom_Select_TopColor1() As Color
        Get
            Return Me.tsMain.My_Selection_Style_Custom_Select_TopColor1
        End Get
        Set(ByVal value As Color)
            tsMain.My_Selection_Style_Custom_Select_TopColor1 = value
        End Set
    End Property
    Public Property My_Skin_Selection_Style_Custom_Select_TopColor2() As Color
        Get
            Return Me.tsMain.My_Selection_Style_Custom_Select_TopColor2
        End Get
        Set(ByVal value As Color)
            tsMain.My_Selection_Style_Custom_Select_TopColor2 = value
        End Set
    End Property
    Public Property My_Skin_Selection_Style_Custom_Select_BottomColor1() As Color
        Get
            Return Me.tsMain.My_Selection_Style_Custom_Select_BottomColor1
        End Get
        Set(ByVal value As Color)
            tsMain.My_Selection_Style_Custom_Select_BottomColor1 = value
        End Set
    End Property
    Public Property My_Skin_Selection_Style_Custom_Select_BottomColor2() As Color
        Get
            Return Me.tsMain.My_Selection_Style_Custom_Select_BottomColor2
        End Get
        Set(ByVal value As Color)
            tsMain.My_Selection_Style_Custom_Select_BottomColor2 = value
        End Set
    End Property
#End Region
#Region "UNSELECTION STYLE"
    Public Property My_Skin_Selection_Style_Custom_UnSelect_Has_Border() As Boolean
        Get
            Return Me.tsMain.My_Selection_Style_Custom_UnSelect_Has_Border
        End Get
        Set(ByVal value As Boolean)
            tsMain.My_Selection_Style_Custom_UnSelect_Has_Border = value
        End Set
    End Property
    Public Property My_Skin_Standard_UnSelect_FontColor() As Color
        Get
            Return Me.tsMain.My_Standard_UnSelect_FontColor
        End Get
        Set(ByVal value As Color)
            tsMain.My_Standard_UnSelect_FontColor = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_Skin_Selection_Style_Custom_UnSelect_BorderColor() As Color
        Get
            Return Me.tsMain.My_Selection_Style_Custom_UnSelect_BorderColor
        End Get
        Set(ByVal value As Color)
            tsMain.My_Selection_Style_Custom_UnSelect_BorderColor = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_Skin_Selection_Style_Custom_UnSelect_TopColor1() As Color
        Get
            Return Me.tsMain.My_Selection_Style_Custom_UnSelect_TopColor1
        End Get
        Set(ByVal value As Color)
            tsMain.My_Selection_Style_Custom_UnSelect_TopColor1 = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_Skin_Selection_Style_Custom_UnSelect_TopColor2() As Color
        Get
            Return Me.tsMain.My_Selection_Style_Custom_UnSelect_TopColor2
        End Get
        Set(ByVal value As Color)
            tsMain.My_Selection_Style_Custom_UnSelect_TopColor2 = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_Skin_Selection_Style_Custom_UnSelect_BottomColor1() As Color
        Get
            Return Me.tsMain.My_Selection_Style_Custom_UnSelect_BottomColor1
        End Get
        Set(ByVal value As Color)
            tsMain.My_Selection_Style_Custom_UnSelect_BottomColor1 = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_Skin_Selection_Style_Custom_UnSelect_BottomColor2() As Color
        Get
            Return Me.tsMain.My_Selection_Style_Custom_UnSelect_BottomColor2
        End Get
        Set(ByVal value As Color)
            tsMain.My_Selection_Style_Custom_UnSelect_BottomColor2 = value
            Me.Invalidate()
        End Set
    End Property
#End Region
#Region "BACKGROUND COLOR"
    Public Property My_Skin_BackGround_TopColor1() As Color
        Get
            Return Me.tsMain.My_BackGround_TopColor1
        End Get
        Set(ByVal value As Color)
            tsMain.My_BackGround_TopColor1 = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_Skin_BackGround_TopColor2() As Color
        Get
            Return Me.tsMain.My_BackGround_TopColor2
        End Get
        Set(ByVal value As Color)
            tsMain.My_BackGround_TopColor2 = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_Skin_BackGround_BottomColor1() As Color
        Get
            Return Me.tsMain.My_BackGround_BottomColor1
        End Get
        Set(ByVal value As Color)
            tsMain.My_BackGround_BottomColor1 = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_Skin_BackGround_BottomColor2() As Color
        Get
            Return Me.tsMain.My_BackGround_BottomColor2
        End Get
        Set(ByVal value As Color)
            tsMain.My_BackGround_BottomColor2 = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_Skin_BackGround_BorderColor() As Color
        Get
            Return Me.tsMain.My_BackGround_BorderColor
        End Get
        Set(ByVal value As Color)
            tsMain.My_BackGround_BorderColor = value
            Me.Invalidate()
        End Set
    End Property
    Public Property My_Skin_BackGround_Has_Border() As Boolean
        Get
            Return Me.tsMain.My_BackGround_Has_Border
        End Get
        Set(ByVal value As Boolean)
            tsMain.My_BackGround_Has_Border = value
            Me.Invalidate()
        End Set
    End Property
#End Region
#End Region

#Region "TEXTBOX AND COMBOBOX FIELD"
#Region "GLOBAL VARIABLES"
    Private OnLostBack As Color = Color.White
    Private OnLostFore As Color = Color.Black
    Private OnGotBack As Color = Color.Azure
    Private OnGotFore As Color = Color.SteelBlue
#End Region
#Region "PROPERTY"

    Public Property My_TxtCbo_Backcolor_LostFocus() As Color
        Get
            Return Me.OnLostBack
        End Get
        Set(ByVal value As Color)
            OnLostBack = value
            initialize_forms()
        End Set
    End Property

    Public Property My_TxtCbo_Fontcolor_LostFocus() As Color
        Get
            Return Me.OnLostFore
        End Get
        Set(ByVal value As Color)
            OnLostFore = value
            initialize_forms()
        End Set
    End Property

    Public Property My_TxtCbo_Backcolor_GotFocus() As Color
        Get
            Return Me.OnGotBack
        End Get
        Set(ByVal value As Color)
            OnGotBack = value
        End Set
    End Property

    Public Property My_TxtCbo_Fontcolor_GotFocus() As Color
        Get
            Return Me.OnGotFore
        End Get
        Set(ByVal value As Color)
            OnGotFore = value
        End Set
    End Property

    

    Public Property My_UI_ICON_NORMAL_JQUERY() As Image
        Get
            Return ui_icon_normal
        End Get
        Set(ByVal value As Image)
            ui_icon_normal = value
            Me.Invalidate()
        End Set
    End Property

    Public Property My_UI_ICON_HOVER_JQUERY() As Image
        Get
            Return ui_icon_hover
        End Get
        Set(ByVal value As Image)
            ui_icon_hover = value
            Me.Invalidate()
        End Set
    End Property

#End Region
#Region "EVENTS"
    Private Sub txtPageNum_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPageNum.GotFocus, cboPageType.GotFocus
        sender.BackColor = OnGotBack
        sender.ForeColor = OnGotFore
    End Sub

    Private Sub txtPageNum_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPageNum.LostFocus, cboPageType.LostFocus
        sender.BackColor = OnLostBack
        sender.ForeColor = OnLostFore
    End Sub
#End Region
#End Region

#Region "BUTTONGS FIELD"

    Private allowDown As Boolean = False
    Private Sub cmd_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdFirst.MouseDown, cmdPrev.MouseDown, cmdNext.MouseDown, cmdLast.MouseDown
        allowDown = True
        'myPicture.ui_Icons(sender, ui_icon_active, 24, 24)
    End Sub

    Private Sub cmd_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdFirst.MouseUp, cmdPrev.MouseUp, cmdNext.MouseUp, cmdLast.MouseUp
        allowDown = False
        'myPicture.ui_Icons(sender, ui_icon_normal, 24, 24)
    End Sub

    Private Sub cmd_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdFirst.MouseLeave, cmdPrev.MouseLeave, cmdNext.MouseLeave, cmdLast.MouseLeave
        'myPicture.ui_Icons(sender, ui_icon_normal, 24, 24)
    End Sub

    Private Sub cmd_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdFirst.MouseMove, cmdPrev.MouseMove, cmdNext.MouseMove, cmdLast.MouseMove
        If allowDown = False Then
            'myPicture.ui_Icons(sender, ui_icon_hover, 24, 24)
        End If
    End Sub

#End Region

#Region "SQL COMMAND BUILDER"

    Private SELECT_ As String
    Private TABLE_ As String
    Private WHERE_ As String
    Private GROUP_ As String
    Private HAVING_ As String
    Private ORDER_ As String

    Enum AutoSuggestSQL
        auto
        manual
    End Enum

    Public Sub Set_SELECT(ByVal values As String, Optional ByVal type As AutoSuggestSQL = AutoSuggestSQL.auto)
        If type = AutoSuggestSQL.auto Then
            SELECT_ = "SELECT " + values + " "
        Else
            SELECT_ = values + " "
        End If
    End Sub

    Public Sub Set_FROM(ByVal values As String, Optional ByVal type As AutoSuggestSQL = AutoSuggestSQL.auto)
        If type = AutoSuggestSQL.auto Then
            TABLE_ = "FROM " + values + " "
        Else
            TABLE_ = values + " "
        End If
    End Sub

    Public Sub Set_WHERE(ByVal values As String, Optional ByVal type As AutoSuggestSQL = AutoSuggestSQL.auto)
        If type = AutoSuggestSQL.auto Then
            If values <> "" And values <> Nothing Then
                WHERE_ = "WHERE " + values + " "
            Else
                WHERE_ = " "
            End If
        Else
            WHERE_ = values + " "
        End If
    End Sub

    Public Sub Set_GROUP(ByVal values As String, Optional ByVal type As AutoSuggestSQL = AutoSuggestSQL.auto)
        If type = AutoSuggestSQL.auto Then
            If values <> "" And values <> Nothing Then
                GROUP_ = "GROUP BY " + values + " "
            Else
                GROUP_ = ""
            End If
        Else
            GROUP_ = values + " "
        End If
    End Sub

    Public Sub Set_HAVING(ByVal values As String, Optional ByVal type As AutoSuggestSQL = AutoSuggestSQL.auto)
        If type = AutoSuggestSQL.auto Then
            If values <> "" And values <> Nothing Then
                HAVING_ = "HAVING BY " + values + " "
            Else
                HAVING_ = ""
            End If
        Else
            HAVING_ = values + " "
        End If
    End Sub

    Public Sub Set_ORDER(ByVal values As String, Optional ByVal type As AutoSuggestSQL = AutoSuggestSQL.auto)
        If type = AutoSuggestSQL.auto Then
            If values <> "" And values <> Nothing Then
                ORDER_ = "ORDER BY " + values + " "
            Else
                ORDER_ = ""
            End If
        Else
            ORDER_ = values + " "
        End If
    End Sub

#End Region

#Region "NAVIGATION FIELD"

#Region "FUNCTIONS"

    Private Sub CBOPage(ByVal type As String)
        If type = "custom" Then
            With cboPageType
                .Items.Clear()
                With .Items
                    .Add("5")
                    .Add("10")
                    .Add("25")
                    .Add("50")
                    .Add("75")
                    .Add("100")
                    .Add("250")
                    .Add("500")
                    .Add("500")
                    .Add("750")
                    .Add("998")
                End With
                .Text = "25"
            End With
        Else
            With cboPageType
                .Items.Clear()
                With .Items
                    .Add("5")
                    .Add("10")
                    .Add("25")
                    .Add("50")
                    .Add("75")
                    .Add("100")
                    .Add("250")
                    .Add("500")
                    .Add("500")
                    .Add("750")
                    .Add("1000")
                    .Add("2500")
                    .Add("5000")
                    .Add("10000")
                    .Add("50000")
                    .Add("1000000")
                End With
                .Text = "25"
            End With
        End If

    End Sub

    Public Sub Set_Data(ByRef obj As Object)
        If TypeOf obj Is DataGridView Then
            CBOPage("Standard")
            DGV = obj
        End If
        isSetDatagridView = True
    End Sub

    Public Sub Execute()
        cb_refresh_navigation()
    End Sub

    Private Function cb_refresh_navigation() As DataTable
        Try
            If isSetDatagridView Then
                Dim mydata As DataTable
                Dim cbolimiter As String = cboPageType.Text

                If GROUP_ = "" Then
                    mydata = mySql.Query("SELECT COUNT(*) " + TABLE_ + " " + WHERE_ + " " + GROUP_ + " " + HAVING_ + " " + ORDER_)
                Else
                    mydata = mySql.Query("SELECT * " + TABLE_ + " " + WHERE_ + " " + GROUP_ + " " + HAVING_ + " " + ORDER_)
                End If

                If mydata.Rows.Count > 0 Then
                    If GROUP_ = "" Then
                        If IsNumeric(mydata.Rows(0).Item(0)) Then
                            max_record = mydata.Rows(0).Item(0)
                        Else
                            max_record = 1
                        End If
                    Else
                        max_record = mydata.Rows.Count
                    End If
                Else
                    max_record = 1
                End If

                'Dim objects As Object = ToolStrip_list(5)
                Dim max_page_float As Double = CDbl(max_record) / CDbl(cbolimiter)
                Dim max_ As Long = max_record

                max_page = 0
                Do Until (max_ < Val(cbolimiter))
                    max_ -= Val(cbolimiter)
                    max_page += 1
                Loop
                If max_ > 0 Then max_page += 1

                If max_page = 0 Then max_page = 1
                ini_page = 1

                txtPageNum.Text = ini_page.ToString
                'st_Navigation_("cmsPage_Num", ini_page.ToString, TypeReturnValueNavigation.set_)
                lblPageTotal.Text = " / " + max_page.ToString("#,#")
                'st_Navigation_("cmsTotal_Num", " / " + max_page.ToString("#,#"), TypeReturnValueNavigation.set_)

                start_record = (Val(cbolimiter) * ini_page) - Val(cbolimiter)
                If start_record <= 0 Then start_record = 1

                If max_record = 0 Then
                    lblRemarks.Text = "View " + start_record.ToString("#,#") + " of 1"
                    'st_Navigation_("cmsComment_View", "View " + start_record.ToString("#,#") + " of 1", TypeReturnValueNavigation.set_)
                Else
                    lblRemarks.Text = "View " + start_record.ToString("#,#") + " of " + max_record.ToString("#,#")
                    'st_Navigation_("cmsComment_View", "View " + start_record.ToString("#,#") + " of " + max_record.ToString("#,#"), TypeReturnValueNavigation.set_)
                End If

                'bt_Navigation_("cmsFirst", False)
                'bt_Navigation_("cmsPrev", False)
                'bt_Navigation_("cmsNext", True)
                'bt_Navigation_("cmsLast", True)
                cmdFirst.Enabled = False
                cmdPrev.Enabled = False
                cmdNext.Enabled = True
                cmdLast.Enabled = True


                If ini_page = max_page Then
                    'bt_Navigation_("cmsFirst", False)
                    'bt_Navigation_("cmsPrev", False)
                    'bt_Navigation_("cmsNext", False)
                    'bt_Navigation_("cmsLast", False)
                    cmdFirst.Enabled = False
                    cmdPrev.Enabled = False
                    cmdNext.Enabled = False
                    cmdLast.Enabled = False
                End If

                If isSetDatagridView Then
                    DGV.DataSource = mySql.Query(SELECT_ + " " + TABLE_ + " " + WHERE_ + " " + GROUP_ + " " + HAVING_ + " " + ORDER_ + " LIMIT " + (ini_page - 1).ToString + "," + cbolimiter.ToString)
                    DGV.Refresh()
                    If sql_loader = False Then
                        myObjectData = mySql.Query(SELECT_ + " " + TABLE_ + " " + WHERE_ + " " + GROUP_ + " " + HAVING_ + " " + ORDER_)
                        sql_loader = True
                    End If
                Else
                    myDialog.show("There is no datagridview set in your program, please provide and initialize the grid", "No Datagridview Set")
                End If
            End If
        Catch ex As Exception
            myDialog.show("Unable to load the grid from cb_Navigation_Calc() - " + ex.ToString, "Unable to proceed the event", MessageBoxButtons.OK)
        End Try
        Return Nothing
    End Function

    Private manual As Boolean = False
    Private myDataPasser As DataTable

    Public Sub manual_type(Optional ByVal allow As Boolean = False)
        manual = False
    End Sub

    Public Sub reload_mydata(ByRef myData As DataTable)
        myDataPasser = myData
    End Sub

    Private Sub reload_page_events()
        If manual = False Then
            Try
                If isSetDatagridView Then
                    Dim cbolimiter As String = cboPageType.Text
                    Dim page_no As Integer
                    If ini_page = 1 Then
                        page_no = 0
                    Else
                        page_no = (Val(cbolimiter) * ini_page) - Val(cbolimiter)
                    End If
                    If isSetDatagridView Then
                        Dim examine As Integer = page_no - 1
                        If examine < 0 Then examine = 0
                        DGV.DataSource = mySql.Query(SELECT_ + " " + TABLE_ + " " + WHERE_ + " " + GROUP_ + " " + HAVING_ + " " + ORDER_ + " LIMIT " + (examine).ToString + "," + cbolimiter.ToString)
                        DGV.Refresh()
                    Else
                        myDialog.show("There is no datagridview set in your program, please provide and initialize the grid", "No Datagridview Set")
                    End If

                    'st_Navigation_("cmsPage_Num", ini_page.ToString, TypeReturnValueNavigation.set_)
                    'st_Navigation_("cmsTotal_Num", " / " + max_page.ToString("#,#"), TypeReturnValueNavigation.set_)
                    txtPageNum.Text = ini_page.ToString
                    lblPageTotal.Text = " / " + max_page.ToString("#,#")

                    start_record = (Val(cbolimiter) * ini_page) - Val(cbolimiter)
                    If start_record <= 0 Then start_record = 1
                    If start_record = 1 Then
                        'st_Navigation_("cmsComment_View", "View " + (start_record).ToString("#,#") + " of " + max_record.ToString("#,#"), TypeReturnValueNavigation.set_)
                        lblRemarks.Text = "View " + (start_record).ToString("#,#") + " of " + max_record.ToString("#,#")
                    Else
                        'st_Navigation_("cmsComment_View", "View " + (start_record + 1).ToString("#,#") + " of " + max_record.ToString("#,#"), TypeReturnValueNavigation.set_)
                        lblRemarks.Text = "View " + (start_record + 1).ToString("#,#") + " of " + max_record.ToString("#,#")
                    End If

                End If
            Catch ex As Exception
                myDialog.show("There is an error from reload_page_events() - " + ex.ToString, "Unable to load")
            End Try
        Else
            Try
                If isSetDatagridView Then
                    Dim cbolimiter As String = cboPageType.Text
                    Dim page_no As Integer
                    If ini_page = 1 Then
                        page_no = 0
                    Else
                        page_no = (Val(cbolimiter) * ini_page) - Val(cbolimiter)
                    End If
                    If isSetDatagridView Then
                        Dim examine As Integer = page_no - 1
                        If examine < 0 Then examine = 0
                        DGV.DataSource = myDataPasser
                        DGV.Refresh()
                    Else
                        myDialog.show("There is no datagridview set in your program, please provide and initialize the grid", "No Datagridview Set")
                    End If

                    'st_Navigation_("cmsPage_Num", ini_page.ToString, TypeReturnValueNavigation.set_)
                    'st_Navigation_("cmsTotal_Num", " / " + max_page.ToString("#,#"), TypeReturnValueNavigation.set_)
                    txtPageNum.Text = ini_page.ToString
                    lblPageTotal.Text = " / " + max_page.ToString("#,#")

                    start_record = (Val(cbolimiter) * ini_page) - Val(cbolimiter)
                    If start_record <= 0 Then start_record = 1
                    If start_record = 1 Then
                        'st_Navigation_("cmsComment_View", "View " + (start_record).ToString("#,#") + " of " + max_record.ToString("#,#"), TypeReturnValueNavigation.set_)
                        lblRemarks.Text = "View " + (start_record).ToString("#,#") + " of " + max_record.ToString("#,#")
                    Else
                        'st_Navigation_("cmsComment_View", "View " + (start_record + 1).ToString("#,#") + " of " + max_record.ToString("#,#"), TypeReturnValueNavigation.set_)
                        lblRemarks.Text = "View " + (start_record + 1).ToString("#,#") + " of " + max_record.ToString("#,#")
                    End If

                End If
            Catch ex As Exception
                myDialog.show("There is an error from reload_page_events() - " + ex.ToString, "Unable to load")
            End Try
        End If

    End Sub

    Public Function get_SQL_Query_Result() As DataTable
        Return myObjectData
    End Function

#Region "CONTROLS"

#Region "NAVIGATION CONTROLS"

    Public Sub navigation_first()
        ini_page = 1
        'bt_Navigation_("cmsFirst", False)
        'bt_Navigation_("cmsPrev", False)
        'bt_Navigation_("cmsNext", True)
        'bt_Navigation_("cmsLast", True)
        'st_Navigation_("cmsPage_Num", ini_page.ToString, TypeReturnValueNavigation.set_)
        cmdFirst.Enabled = False
        cmdPrev.Enabled = False
        cmdNext.Enabled = True
        cmdLast.Enabled = True
        txtPageNum.Text = ini_page.ToString
        reload_page_events()
    End Sub

    Public Sub navigation_prev()
        ini_page -= 1
        If ini_page <= 1 Then
            'bt_Navigation_("cmsFirst", False)
            'bt_Navigation_("cmsPrev", False)
            cmdFirst.Enabled = False
            cmdPrev.Enabled = False
        End If
        'bt_Navigation_("cmsNext", True)
        'bt_Navigation_("cmsLast", True)
        'st_Navigation_("cmsPage_Num", ini_page.ToString, TypeReturnValueNavigation.set_)
        cmdNext.Enabled = True
        cmdLast.Enabled = True
        txtPageNum.Text = ini_page.ToString
        reload_page_events()
    End Sub

    Public Sub navigation_next()
        ini_page += 1
        If ini_page >= max_page Then
            'bt_Navigation_("cmsNext", False)
            'bt_Navigation_("cmsLast", False)
            cmdNext.Enabled = False
            cmdLast.Enabled = False
            ini_page = max_page
        End If
        'bt_Navigation_("cmsFirst", True)
        'bt_Navigation_("cmsPrev", True)
        'st_Navigation_("cmsPage_Num", ini_page.ToString, TypeReturnValueNavigation.set_)
        cmdFirst.Enabled = True
        cmdPrev.Enabled = True
        txtPageNum.Text = ini_page.ToString

        reload_page_events()
    End Sub

    Public Sub navigation_last()
        ini_page = max_page
        'bt_Navigation_("cmsNext", False)
        'bt_Navigation_("cmsLast", False)
        'bt_Navigation_("cmsFirst", True)
        'bt_Navigation_("cmsPrev", True)
        cmdNext.Enabled = False
        cmdLast.Enabled = False
        cmdFirst.Enabled = True
        cmdPrev.Enabled = True
        txtPageNum.Text = ini_page.ToString
        'st_Navigation_("cmsPage_Num", ini_page.ToString, TypeReturnValueNavigation.set_)
        reload_page_events()
    End Sub

#End Region

#End Region

#End Region

#Region "EVENTS"

    Private Sub txtPageNum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPageNum.Click
        txtPageNum.SelectAll()
    End Sub

    Private Sub txtPageNum_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPageNum.TextChanged
        If IsNumeric(txtPageNum.Text) Then
            If Val(txtPageNum.Text) > max_page Then
                txtPageNum.Text = max_page.ToString
            ElseIf Val(txtPageNum.Text) = 0 Then
                txtPageNum.Text = "1"
            End If
        ElseIf txtPageNum.Text = "" Then
            'nothing
        Else
            txtPageNum.Text = "1"
        End If
    End Sub

    Private Sub txtPageNum_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPageNum.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IsNumeric(txtPageNum.Text) Then
                ini_page = Val(txtPageNum.Text)
                reload_page_events()
            Else
                cb_refresh_navigation()
            End If
        End If
    End Sub

    Private Sub cboPageType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPageType.SelectedIndexChanged
        cb_refresh_navigation()
    End Sub

    Private Sub cmdFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFirst.Click
        navigation_first()
    End Sub

    Private Sub cmdPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrev.Click
        navigation_prev()
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        navigation_next()
    End Sub

    Private Sub cmdLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLast.Click
        navigation_last()
    End Sub

#End Region

#End Region

    Private Sub tsMain_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsMain.ItemClicked

    End Sub
End Class
