Imports System.Threading
Public Class myConnector
#Region "GLOBAL DECLARATIONS"

    Private Localhost As String
    Private Port As String
    Private UserRoot As String
    Private Password As String
    Private Database As String
    Private Users As String
    Private themes As String

#End Region

#Region "PROPERTIES"

    <CLSCompliant(False)> _
Public Property _Localhost() As String
        Get
            Return Localhost
        End Get
        Set(ByVal value As String)
            Localhost = value
        End Set
    End Property

    <CLSCompliant(False)> _
Public Property _Port() As String
        Get
            Return Port
        End Get
        Set(ByVal value As String)
            Port = value
        End Set
    End Property

    <CLSCompliant(False)> _
Public Property _UserRoot() As String
        Get
            Return UserRoot
        End Get
        Set(ByVal value As String)
            UserRoot = value
        End Set
    End Property

    <CLSCompliant(False)> _
Public Property _Password() As String
        Get
            Return Password
        End Get
        Set(ByVal value As String)
            Password = value
        End Set
    End Property

    <CLSCompliant(False)> _
Public Property _Database() As String
        Get
            Return Database
        End Get
        Set(ByVal value As String)
            Database = value
        End Set
    End Property

    <CLSCompliant(False)> _
Public Property _User() As String
        Get
            Return Users
        End Get
        Set(ByVal value As String)
            Users = value
        End Set
    End Property

    <CLSCompliant(False)> _
Public Property _themes() As String
        Get
            Return themes
        End Get
        Set(ByVal value As String)
            themes = value
        End Set
    End Property

#End Region

    Friend mySql As New mySQL.Init.SQL
    Friend wrapper As New myEncrypt
    Friend myFile As New myFile.Share.Folders
    Friend myDialog As New myDialog.messageBoxes
    'Friend Thmes As myObject.ThemeNames
    Private Locations As String
    Private fileNames As String
    Private setup As String
    Private emssMutex As Mutex

    Public Sub set_class()
        'Thmes = myThemes
        'myDialog.set_class(Thmes)
    End Sub

    Public Function connection_MYSQL_Settings(ByVal location As String, ByVal filename As String) As Boolean
        Locations = location
        fileNames = filename

        myFile.createFolder(location, "Templates") 'I've created templates folder'
        myFile.createFolder(location + "\Templates", "MySql Settings")

        If My.Computer.FileSystem.FileExists(location + "\Templates\MySql Settings\" + filename) Then

            setup = My.Computer.FileSystem.ReadAllText(location + "\Templates\MySql Settings\" + filename)
            Try
                setup = wrapper.DecryptData(setup)
            Catch ex As Exception
                myDialog.show("Please re-check setup. " + vbCr + ex.Message.ToString, "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                show_connector()
                Exit Function
            End Try

            Dim setupvar() As String
            setupvar = setup.Split(",")

            Localhost = setupvar(0)
            Port = setupvar(1)
            UserRoot = setupvar(2)
            Password = setupvar(3)
            Database = setupvar(4)
            Users = setupvar(5)

            Dim mySql As New mySQL.Init.SQL
            mySql.connectDatabase(Localhost, Port, UserRoot, Password, Database)

            If mySql.errExist = False Then
                Return True
            Else
                myDialog.show("Unable to load database connection, please reconfigure it again", "Error Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                show_connector()
                Return False
            End If

        Else
            myDialog.show("There is no file exist to connect the server, please try to configure it", "No File Configuration Exist")
            show_connector()
            Return False
        End If
    End Function

    Public Function check_No_Multi_System_Running(ByVal system_Name As String) As Boolean 'THIS IS CHECKING THE SYSTEM DUPLICATIONS
        emssMutex = New Mutex(False, system_Name)
        If emssMutex.WaitOne(0, False) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub show_connector()
        Dim frm As New frmConnector
        With frm
            .ShowInTaskbar = False
            .ShowDialog()
            If .allow_save Then
                Dim setup As String
                setup = .txtServer.Text + "," + .txtPort.Text + "," + .txtUserID.Text + "," + .txtPassword.Text + "," + .cboDBName.Text + ",administrator,original"
                setup = wrapper.EncryptData(setup)
                My.Computer.FileSystem.WriteAllText(Locations + "\Templates\MySql Settings\" + fileNames, setup, False)
                myDialog.show("You may now start and launch the system", "Configuration Successfully Completed!")
            End If
        End With
    End Sub

    Public Sub update_setup(ByVal locations As String, ByVal filenames As String)
        Dim setup As String
        setup = Localhost + "," + Port + "," + UserRoot + "," + Password + "," + Database + "," + Users + "," + themes
        setup = wrapper.EncryptData(setup)
        My.Computer.FileSystem.WriteAllText(locations + "\Templates\MySql Settings\" + filenames, setup, False)
    End Sub
End Class
