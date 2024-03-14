Public Class frmXMLBrowser

    Friend myObject As New PowerNET8.myObject
    'Private Thm As CustomObjects.MyObject.ThemeNames = CustomObjects.MyObject.ThemeNames.Original
    Private myBrowseOpen As New PowerNET8.myBrowseDialog
    Private colObjects As New Collection

    Public openFilter As String = ""
    Public openFilterTitle As String = ""
    Public allow_return As Boolean = False

    Enum MethodLoad
        save_file
        load_file
    End Enum

    Private mType As MethodLoad
    Public Sub type_method(ByVal type As MethodLoad)
        mType = type
    End Sub

    Private Sub frmXMLBrowser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialized_form()
        allow_return = False
    End Sub

    Private Sub initialized_form()
        myObject.get_all_objects_data(colObjects, Me)
        'myObject.load(colObjects, Thm)
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Public FileName As String = ""

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        If mType = MethodLoad.load_file Then
            Select Case cmdBrowse.Text.ToLower
                Case "browse"
                    With myBrowseOpen
                        If openFilter <> "" Then .my_open_filter = openFilter
                        If openFilterTitle <> "" Then .my_open_filter_title = openFilterTitle
                        .browse_open_file()
                        AddHandler .get_SourceFileName, AddressOf openFile
                    End With
                    cmdBrowse.Text = "Select"
                Case "select"
                    allow_return = True
                    cmdBrowse.Text = "Browse"
                    Me.Close()
            End Select
        ElseIf mType = MethodLoad.save_file Then
            Select Case cmdBrowse.Text.ToLower
                Case "browse"
                    With myBrowseOpen
                        .browse_save_file()
                        AddHandler .get_SourceFileName, AddressOf openFile
                    End With
                    cmdBrowse.Text = "Save"
                Case "save"
                    allow_return = True
                    cmdBrowse.Text = "Browse"
                    Me.Close()
            End Select
        End If
    End Sub

    Private Sub openFile(ByVal file As String)
        FileName = file
    End Sub

End Class