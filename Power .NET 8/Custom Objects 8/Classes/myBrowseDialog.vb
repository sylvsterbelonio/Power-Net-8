Imports System.IO
Public Class myBrowseDialog
    Dim d_locations As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    Dim default_location As String
    Dim B_Folder As New FolderBrowserDialog
    Dim S_File_Location As String
    Dim S_File_Return_Value As String
    Dim frm As New Form

    Public Event get_SourceFileName(ByVal filename As String)

    Private Sub get_File(ByVal fileName As String)
        RaiseEvent get_SourceFileName(fileName)
    End Sub

    Public Function browse_folder(Optional ByVal default_location As String = "")
        B_Folder.Description = "Select Location"

        If default_location = "" Then
            default_location = d_locations
        End If
        B_Folder.ShowDialog()

        Return B_Folder.SelectedPath
    End Function

    Public Sub browse_save_file(Optional ByVal default_location As String = "")
        If default_location = "" Then
            default_location = d_locations
        End If
        S_File_Location = default_location
        Dim _newThread As New Threading.Thread(AddressOf Descarga)
        _newThread.SetApartmentState(Threading.ApartmentState.STA)
        _newThread.Start(S_File_Location + "\myXML.xml")
    End Sub

    Private Sub Descarga(ByVal _ruta As Object)

        Dim Dialog As New System.Windows.Forms.SaveFileDialog

        Dialog.InitialDirectory = S_File_Location
        Dialog.Title = "Save xml Files"
        'Dialog.CheckFileExists = True
        Dialog.CheckPathExists = True
        Dialog.DefaultExt = "xml"
        Dialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        Dialog.FilterIndex = 2
        Dialog.RestoreDirectory = True

        If Dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            get_File(Dialog.FileName)
            _newThread.Abort()
        Else
            get_File("")
            _newThread.Abort()
        End If

    End Sub

    Dim _newThread As New Threading.Thread(AddressOf Descarga2)
    Public Sub browse_open_file(Optional ByVal default_locationx As String = "")
        If default_location = "" Then
            default_location = default_locationx
        End If
        _newThread = New Threading.Thread(AddressOf Descarga2)
        _newThread.SetApartmentState(Threading.ApartmentState.STA)
        _newThread.Start(default_location + "\myXML.xml")
    End Sub

    Private open_filter As String = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
    Public WriteOnly Property my_open_filter() As String
        Set(ByVal value As String)
            open_filter = value
        End Set
    End Property
    Private open_filter_title As String = "Open xml Files"
    Public WriteOnly Property my_open_filter_title() As String
        Set(ByVal value As String)
            open_filter_title = value
        End Set
    End Property

    Private Sub Descarga2(ByVal _ruta As Object)
        Dim Dialog As New System.Windows.Forms.OpenFileDialog
        Dialog.InitialDirectory = default_location
        Dialog.Title = open_filter_title
        'Dialog.CheckFileExists = True
        Dialog.CheckPathExists = True
        Dialog.DefaultExt = "xml"
        Dialog.Filter = open_filter
        Dialog.FilterIndex = 1
        Dialog.RestoreDirectory = True
        If Dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            get_File(Dialog.FileName)
            _newThread.Abort()
        Else
            get_File("")
            _newThread.Abort()
        End If
    End Sub

    Public Function browse_any_file(Optional ByVal default_location As String = "")
        Dim dialog As New OpenFileDialog()

        If default_location <> "" Then dialog.InitialDirectory = default_location
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Return dialog.FileName
        Else
            Return ""
        End If
    End Function

    Public Shared Function browseImage(Optional ByVal defaultLoc As String = "@Desktop")
        If defaultLoc = "@Desktop" Then
            defaultLoc = myFile.Share.Location.getDesktopPath
        End If
        Dim dlg_openfile As New OpenFileDialog
        With dlg_openfile 'Executes a series of statements making repeated reference to a single object or structure.
            .Title = "Please Select a Image" 'title
            .InitialDirectory = defaultLoc 'browse start directory
            .Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*" 'only possible to select this extensions
            .FilterIndex = 0 'index number filter
            .FileName = "" 'empty
            Dim answ = .ShowDialog
            If answ = DialogResult.OK Then 'if answer not cancel, etc..
                Return .FileName 'picterebox imagelocation = dlg_openfile.filename
            End If
            Return ""
        End With
    End Function

End Class

