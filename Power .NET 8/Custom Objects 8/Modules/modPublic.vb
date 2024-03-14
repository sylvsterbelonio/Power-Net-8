Module modPublic


    Private lstConfig(1) As ConfigDB
    Private counter As Integer = -1

    Public activationCode As String = "masterkey"

    Public pContentBackColor As String = "FAFBFB"
    Public pBackGroundColor As String = "146CE8"


    Public pWindowsFormColor As String = "E1A61E"

    Public pAccentColor As String = "3D6099"

    Public Const sBUTTON As Double = 0.2
    Public Const sHIGHLIGHT As Double = 1.1
    Public Const sDEFAULT As Double = 1.95
    Public Const sALTERNATE As Double = 1.4
    Public Const sBACKCOLOR As Double = 0.25
    Public Const sTOOLSTRIP As Double = 0.8
    Public Const sTOOLSTRIPHover As Double = 0.9
    Public Const sMENUSTRIP As Double = 0.25
    Public Const sMENUSTRIPHover As Double = 0.45
    Public Const sCONTENT As Double = 1.75

    Public Const cdisBACKCOLOR As String = "efefef"
    Public Const cdisFORECOLOR As String = "6D6D6D"

    Structure ConfigDB
        Public Servername As String
        Public Username As String
        Public Password As String
        Public Port As String
        Public Databasename As String
        Public USER As String
    End Structure

    Private Sub promptBox(ByVal content As String)
        MsgBox(content, , modApp.getTitle)
    End Sub

    Public Sub add_configMysql(ByVal form As Form, ByVal databaseName As String, Optional ByVal serverName As String = "localhost", Optional ByVal userName As String = "root", Optional ByVal password As String = "", Optional ByVal port As String = "3306")
        If Not form.Tag Is Nothing Then
            If form.Tag = "ACCESS SQL CONFIGURATION" Then
                counter += 1
                ReDim Preserve lstConfig(UBound(lstConfig) + 1)
                With lstConfig(counter)
                    .Databasename = databaseName
                    .Servername = serverName
                    .Password = password
                    .Port = port
                    .Username = userName
                    .USER = ""
                End With
            Else
                promptBox("Unable to access add config mysql. Please use the Mysql Settings form to add.")
            End If
        Else
            promptBox("Unable to access add config mysql. Please use the Mysql Settings form to add.")
        End If
    End Sub

    Public Sub remove_configMysql(ByVal databaseName As String)
        For i As Integer = 0 To counter
            If lstConfig(i).Databasename = databaseName Then
                For ix As Integer = i To UBound(lstConfig) - 1
                    With lstConfig(ix)
                        .Databasename = lstConfig(ix + 1).Databasename
                        .Password = lstConfig(ix + 1).Password
                        .Port = lstConfig(ix + 1).Port
                        .Servername = lstConfig(ix + 1).Servername
                        .USER = lstConfig(ix + 1).USER
                        .Username = lstConfig(ix + 1).Username
                    End With
                Next ix
                counter -= 1
            End If
        Next
    End Sub

    Public Sub clear_configMysql()
        counter = -1
        lstConfig(0).Databasename = ""
    End Sub

    Public Function getListDatabaseInfo(ByVal databaseName As String)
        For i As Integer = 0 To counter
            With lstConfig(i)
                If .Databasename = databaseName Then
                    Return .Servername + "," + .Username + "," + .Password + "," + .Port + "," + .Databasename + "," + .USER
                End If
            End With
        Next
        Return ",,,,,"
    End Function

    Public Sub showListDatabase(ByRef obj As Object)
        If TypeOf obj Is DataGridView Then
            With CType(obj, DataGridView)
                .Rows.Clear()
                For i As Integer = 0 To counter
                    .Rows.Add()
                    With .Rows(i)
                        .Cells(0).Value = lstConfig(i).Databasename
                    End With
                Next
            End With
        ElseIf TypeOf obj Is ArrayList Then
            With CType(obj, ArrayList)
                .Clear()
                For i As Integer = 0 To counter
                    .Add(lstConfig(i).Databasename).ToString()
                Next
            End With
        End If
    End Sub







    Public Sub activationRequired(ByVal fromError As String)
        MsgBox("Unathorized function used. [" + fromError + "]", MsgBoxStyle.Critical, "Restricted Code")
    End Sub


End Module
