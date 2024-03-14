Imports System.IO
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Drawing
Namespace mySQL


    Namespace Init

        Public Class SQL

#Region "DECLARATIONS"

            Private myEncrypt As New myEncrypt
            Private myDialog As New myDialog.messageBoxes
            Friend myObjFetcher As New myObjectFetcher
            Private conn As MySqlConnection
            Private myForm As Form
            Private GlobalMydata As DataTable
            Private connstr As String
            Public errExist As Boolean = False
            Private Fill_Data_values As New Collection
            Private table As String = ""
            Private fields As String = ""
            Private param As String

            Enum FormatStyle
                dateonly
                datetime
                time_only
            End Enum

#End Region

#Region "PRIVATE FUNCTIONS"

            ''' <summary>
            ''' Quote string with slashes
            ''' </summary>
            ''' <param name="InputTxt">Text string need to be escape with slashes</param>
            ''' 
            Private Function AddSlashes(ByVal InputTxt As String) As String
                ' List of characters handled:
                ' \000 null
                ' \010 backspace
                ' \011 horizontal tab
                ' \012 new line
                ' \015 carriage return
                ' \032 substitute
                ' \042 double quote
                ' \047 single quote
                ' \134 backslash
                ' \140 grave accent

                Dim Result As String = InputTxt

                Try
                    Result = System.Text.RegularExpressions.Regex.Replace(InputTxt, "[\000\010\011\012\015\032\042\047\134\140]", "\$0")
                Catch Ex As Exception
                    ' handle any exception here
                    Console.WriteLine(Ex.Message)
                End Try

                Return Result
            End Function

            Private Enum cursor_event
                wait
                arrow
            End Enum

            Private Function create_parameters_insert_name()
                Dim vals() As String = fields.Split(",")
                param = ""

                For i As Integer = 0 To vals.Length - 1
                    If i = 0 Then
                        param = "?_" + vals(i).Replace("`", "")
                    Else
                        param += "," + "?_" + vals(i).Replace("`", "")
                    End If
                Next
                Return param
            End Function

            Private Function create_parameters_update_name()
                Dim vals() As String = fields.Split(",")
                param = ""

                For i As Integer = 0 To vals.Length - 1
                    If i = 0 Then
                        param = " " + vals(i) + " = " + "?_" + vals(i).Replace("`", "")
                    Else
                        param += "," + vals(i) + " = " + "?_" + vals(i).Replace("`", "")
                    End If
                Next
                Return param
            End Function

            Private Function validate_entries(ByVal values As String)
                Dim myChar As New myCharacter
                values = values.Replace(vbCrLf, "")
                values = values.Replace("\", "")
                values = Trim(values)
                Return values
            End Function

            Private Function get_param(ByVal inc As Integer) As String
                Dim vals() As String = param.Split(",")
                Dim v As String = vals(inc)
                Return vals(inc)
            End Function

            Private Function get_update_param(ByVal icn As Integer) As String
                Dim vals() As String = param.Split(",")
                Dim vals2() As String = vals(icn).Split("=")
                Dim v As String = Trim(vals2(1))
                Return Trim(vals2(1))

            End Function

#End Region

#Region "PUBLIC SUB"

            Public Sub clear()
                Fill_Data_values.Clear()
                table = ""
                fields = ""
            End Sub 'clear all the values before reuse of run functions

            Public Sub disconnect()
                If Not conn Is Nothing Then
                    conn.Close()
                End If
            End Sub

            Public Sub setTable(ByVal mytable As String)
                clear()
                table = mytable
            End Sub 'set table name

            Public Sub setForm(ByRef form As Form)
                myForm = form
            End Sub 'SET THE FORM to show waiting cursor

            Private Sub wait_cursor(ByVal type As cursor_event)
                If Not myForm Is Nothing Then
                    Select Case type
                        Case cursor_event.wait
                            myForm.Cursor = Cursors.WaitCursor
                        Case cursor_event.arrow
                            myForm.Cursor = Cursors.Default
                    End Select
                End If
            End Sub

            ''StorePicture
            Private Function save_temporary_image_and_get_location(ByVal bm As Bitmap, ByVal pictureName As String) As String
                myFile.Share.Folders.createFolder(myFile.Share.Location.getBasePath, "Templates") 'I've created templates folder'
                myFile.Share.Folders.createFolder(myFile.Share.Location.getBasePath + "\Templates", "Picture")
                Dim location As String = myFile.Share.Location.getBasePath & "\Templates\Picture\" + pictureName + ".jpg"
                bm.Save(location, System.Drawing.Imaging.ImageFormat.Jpeg)
                Return location
            End Function

#Region "BLOB Controllers"

            Public Function convertAnyFilesToBLOB(ByVal filePath As String) As Byte()
                Try
                    If File.Exists(filePath) Then
                        Dim fs As New FileStream(filePath, FileMode.Open, FileAccess.Read)
                        Dim MyData(fs.Length) As Byte
                        fs.Read(MyData, 0, fs.Length)
                        fs.Close()
                        Return MyData
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    MsgBox("Error uploading, cannot store large file", MsgBoxStyle.Information, "File Size is too Large!")
                    Return Nothing
                End Try
            End Function

            Enum ExtensionStyle
                WithDots
                NoDots
            End Enum

            Public Function get_FileExtension(ByVal filename As String) As String
                If filename <> "" Then
                    Dim Ext() As String = filename.Split(".")
                    Return Ext(Ext.Length - 1)
                    'If style = ExtensionStyle.NoDots Then
                    '    Return filename.Substring(filename.Length - 3, numLength)
                    'Else
                    '    If filename.Length > 4 Then
                    '        Return filename.Substring(filename.Length - (numLength + 1), numLength + 1)
                    '    Else
                    '        Return Nothing
                    '    End If
                    'End If
                End If
                Return Nothing
            End Function

            Public Function get_FileName(ByVal filePath As String, Optional ByVal style As FileNameStyle = FileNameStyle.withExtension)
                If filePath <> "" Then
                    Dim data() As String = filePath.Split("\")
                    If style = FileNameStyle.withExtension Then
                        Return data(data.Length - 1)
                    Else
                        Dim dt2() As String = data(data.Length - 1).Split(".")
                        Return dt2(0)
                    End If
                Else
                    Return ""
                End If
            End Function

            Enum FileNameStyle
                withExtension
                noExtension
            End Enum

            Public Sub write_BLOBFIle(ByVal filePath As String, ByVal fileName As String, ByVal BLOB As Object)
                Dim fs As FileStream
                Dim lb() As Byte = BLOB
                If Not File.Exists(filePath + "\" + fileName) Then
                    Try
                        fs = New FileStream(filePath + "\" + fileName, FileMode.OpenOrCreate, FileAccess.Write)
                        fs.Write(lb, 0, lb.Length)
                        fs.Close()
                    Catch ex As Exception
                        'myDialog.show(ex.ToString, "Unable to write file", , MessageBoxIcon.Error)
                        MsgBox(ex.ToString, "Unable to write file")
                    End Try
                Else
                    If MsgBox("File Already Exist. Do you want to replace this file?", MsgBoxStyle.YesNo, "Replace Confirm") = MsgBoxResult.Yes Then
                        Try
                            File.Delete(filePath + "\" + fileName)
                            fs = New FileStream(filePath + "\" + fileName, FileMode.OpenOrCreate, FileAccess.Write)
                            fs.Write(lb, 0, lb.Length)
                            fs.Close()
                        Catch ex As Exception
                            MsgBox("Unable to replace the file. The file is already opened", MsgBoxStyle.OkOnly, "Unable to replace")
                        End Try
                    End If
                End If
            End Sub

#End Region

#End Region

#Region "PUBLIC FUNCTION"

            Public Sub addValue(ByVal value As Object, ByVal field As String)
                'get_ColumnType(field)
                If TypeOf value Is String Then

                    If Not CType(value, String) Is Nothing Then
                        value = value.Replace(vbCrLf, "")
                        value = value.Replace(vbCrLf, "")
                    End If

                    If String.IsNullOrEmpty(value) Then
                        value = ""
                    End If

                    field = field.Replace(",", " ")

                    'value = value.Replace("\", "\\")

                    If value = "NOW()" Or value.Contains("md5(") Then

                        Fill_Data_values.Add(value)
                    Else
                        value = AddSlashes(value)
                        'value = value.Replace("'", "\'")
                        value = Trim(value)

                        Fill_Data_values.Add(value)
                    End If

                ElseIf TypeOf value Is Integer Or TypeOf value Is Double Or TypeOf value Is Decimal Or TypeOf value Is Long Then
                    field = field.Replace(",", " ")

                    Fill_Data_values.Add(value.ToString)
                ElseIf TypeOf value Is Date Then
                    field = field.Replace(",", " ")

                    Fill_Data_values.Add(CType(value, Date).ToString("yyyy-MM-dd hh:mm:ss"))
                ElseIf TypeOf value Is Bitmap Or TypeOf value Is Image Then

                    Dim FileSize As UInt32
                    Dim rawData() As Byte = {}
                    Dim fs As FileStream

                    fs = New FileStream(save_temporary_image_and_get_location(value, "rawdata"), FileMode.Open, FileAccess.Read)
                    FileSize = fs.Length
                    rawData = New Byte(FileSize) {}
                    fs.Read(rawData, 0, FileSize)
                    fs.Close()

                    Fill_Data_values.Add(rawData)

                ElseIf TypeOf value Is Boolean Then
                    field = field.Replace(",", " ")
                    If value Then
                        Fill_Data_values.Add("1")
                    Else
                        Fill_Data_values.Add("0")
                    End If
                ElseIf TypeOf value Is System.Array Then
                    Fill_Data_values.Add(value)
                Else
                    'in case all of them cannot be found
                    field = field.Replace(",", " ")
                    value = myObjFetcher.get_object_value(value)
                    Fill_Data_values.Add(value)
                End If

                If fields = "" Then
                    fields = "`" + field + "`"
                Else
                    fields += "," & "`" + field + "`"
                End If
            End Sub 'adding values with fields for insert and update query

            Public Function setConnectionErrno(ByVal server As String, ByVal port As String, ByVal user As String, ByVal pass As String, ByVal db As String)
                Dim errnoLog As Boolean = False
                errExist = False
                connstr = "server=" & server & ";" _
                & "port=" & port & ";" _
                & "user id=" & user & ";" _
                & "password=" & pass & ";" _
                & "database=" & db & ";"

                Dim mycommand As New MySqlCommand
                Dim myadapter As New MySqlDataAdapter

                conn = New MySqlConnection
                conn.ConnectionString = connstr

                Try
                    conn.Open()
                Catch ex As MySqlException
                    myDialog.show("Error in setConnectionString: User Access Denied " & user, "Unable to connect", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    errnoLog = True
                    errExist = True
                Finally
                    If conn.State = ConnectionState.Open Then conn.Close()
                End Try
                Return errnoLog

            End Function 'set the connection Test if Good

            Public Function getListDatabase() As String
                'ready to begin process'
                wait_cursor(cursor_event.wait)

                Dim reader As MySqlDataReader
                Dim cbo As New ComboBox
                Dim value As String = ""
                reader = Nothing

                Dim cmd As New MySqlCommand("SHOW DATABASES", conn)
                Try
                    reader = cmd.ExecuteReader()
                    cbo.Items.Clear()

                    While (reader.Read())
                        value += reader.GetString(0) + ","
                        'cbo.Items.Add(reader.GetString(0))
                    End While
                Catch ex As MySqlException
                    'myDialog.show("Failed to populate database list: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If Not reader Is Nothing Then
                        reader.Close()
                    End If
                End Try
                wait_cursor(cursor_event.arrow)
                Return value
            End Function 'SHOW ALL DATABASES

            Public Function connectDatabase(ByVal server As String, ByVal port As String, ByVal user As String, ByVal pass As String, ByVal db As String)
                errExist = False
                connstr = "server=" & server & ";" _
                & "port=" & port & ";" _
                & "user id=" & user & ";" _
                & "password=" & pass & ";" _
                & "database=" & db & ";"

                Dim mycommand As New MySqlCommand
                Dim myadapter As New MySqlDataAdapter

                conn = New MySqlConnection
                conn.ConnectionString = connstr

                Try
                    conn.Open()
                    Return True
                Catch ex As MySqlException
                    myDialog.show("Error in setConnectionString: User Access Denied", "Unable to Connect Server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    'MsgBox("" & user, MsgBoxStyle.Critical)
                    errExist = True
                    Return False
                Finally
                    If conn.State = ConnectionState.Open Then conn.Close()
                End Try
            End Function 'set the connection

            Public Function connectServer(ByVal server As String, ByVal port As String, ByVal user As String, ByVal pass As String) As Boolean
                If Not conn Is Nothing Then conn.Close()

                Dim ConnStr As String
                ConnStr = String.Format("server={0};port={1}; user id={2}; password={3}; database={4}; pooling=false", _
                server, port, user, pass, "")

                Try
                    conn = New MySqlConnection(ConnStr)
                    conn.Open()
                    Return True
                Catch ex As MySqlException
                    MsgBox("Error connecting to the database server: ", , "Error")
                    Return False
                End Try
            End Function '

            Public Function nextID(ByVal id As String)
                Dim mydata As DataTable = Query("SELECT (IFNULL(MAX(" + id + "),0)+1) 'Max' FROM " + table)
                If mydata.Rows.Count > 0 Then
                    Return Val(mydata.Rows(0).Item(0))
                Else
                    Return Nothing
                End If
            End Function

            Public Function crypt(ByVal value As String)
                Return myEncrypt.Crypt(value)
            End Function

#Region "EXECUTION COMMAND LIST"

            Public Function Insert()
                wait_cursor(cursor_event.wait)
                errExist = False
                If Fill_Data_values Is Nothing Or table = "" Or fields = "" Then
                    Return False
                Else
                    Dim cmd As New MySqlCommand
                    Dim sql As String

                    conn = New MySqlConnection
                    conn.ConnectionString = connstr

                    Try
                        conn.Open()
                        sql = "INSERT INTO " & table & "  (" & fields & ") VALUES(" & create_parameters_insert_name() & ");"
                        cmd.Connection = conn
                        cmd.CommandText = sql

                        Dim inc As Integer = 0
                        For Each obj As Object In Fill_Data_values
                            If TypeOf obj Is String Then
                                cmd.Parameters.Add(New MySqlParameter(get_param(inc), validate_entries(obj)))
                            ElseIf TypeOf obj Is Array Then
                                cmd.Parameters.AddWithValue(get_param(inc), CType(obj, Array))
                            ElseIf TypeOf obj Is Boolean Then
                                If obj Then
                                    cmd.Parameters.AddWithValue(get_param(inc), "1")
                                Else
                                    cmd.Parameters.AddWithValue(get_param(inc), "0")
                                End If
                            End If
                            inc += 1
                        Next
                        cmd.ExecuteNonQuery()
                        conn.Close()

                        wait_cursor(cursor_event.arrow)
                        clear()
                    Catch ex As Exception
                        wait_cursor(cursor_event.arrow)
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                        errExist = True
                    Finally
                        If conn.State <> ConnectionState.Closed Then conn.Close()
                    End Try
                    Return True

                End If
            End Function 'executes insert query then clear all the data from class except connstr

            Public Function Update(ByVal fieldName As String, ByVal fieldValues As Object)
                wait_cursor(cursor_event.wait)
                Dim fValues As String = fieldValues.ToString

                errExist = False
                If Fill_Data_values Is Nothing Or table = "" Or fields = "" Then
                    Return False
                Else
                    Dim cmd As New MySqlCommand
                    Dim sql As String

                    conn = New MySqlConnection
                    conn.ConnectionString = connstr

                    Try
                        conn.Open()
                        sql = "UPDATE  " & table & " SET " & create_parameters_update_name() & " WHERE " + fieldName + " = ?_" & fieldName
                        cmd.Connection = conn
                        cmd.CommandText = sql

                        Dim inc As Integer = 0
                        For Each obj As Object In Fill_Data_values
                            If TypeOf obj Is String Then
                                cmd.Parameters.AddWithValue(get_update_param(inc), validate_entries(obj))
                            ElseIf TypeOf obj Is Array Then
                                cmd.Parameters.AddWithValue(get_update_param(inc), CType(obj, Array))
                            ElseIf TypeOf obj Is Boolean Then
                                If obj Then
                                    cmd.Parameters.AddWithValue(get_update_param(inc), "1")
                                Else
                                    cmd.Parameters.AddWithValue(get_update_param(inc), "0")
                                End If
                            End If
                            inc += 1
                        Next

                        cmd.Parameters.AddWithValue("?_" & fieldName, fValues)

                        cmd.ExecuteNonQuery()
                        conn.Close()

                        wait_cursor(cursor_event.arrow)
                        clear()
                    Catch ex As Exception
                        wait_cursor(cursor_event.arrow)
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                        errExist = True
                    Finally
                        If conn.State <> ConnectionState.Closed Then conn.Close()
                    End Try
                    Return True
                End If

            End Function 'executes update query with condition parameter then clear all data from class except connstr

            Public Function Delete(Optional ByVal condition As String = "")

                Dim con As String = ""

                If condition.Contains("where") Then
                    If condition <> "" Then
                        con = condition
                    Else
                        con = ""
                    End If
                Else
                    If condition <> "" Then
                        con = " WHERE " + condition
                    Else
                        con = ""
                    End If
                End If

                Query("DELETE FROM " + table + " " + con)

                If errExist Then
                    Return False
                Else
                    Return True
                End If

            End Function

            Public Function Query(ByVal sqlquery As String, Optional ByVal returnWhat As String = "Table")
                wait_cursor(cursor_event.wait)
                Dim mycommand As New MySqlCommand
                Dim myadapter As New MySqlDataAdapter
                Dim mydata As New DataTable
                errExist = False

                conn = New MySqlConnection
                conn.ConnectionString = connstr

                Try
                    conn.Open()

                    mycommand.Connection = conn
                    mycommand.CommandText = sqlquery

                    myadapter.SelectCommand = mycommand
                    myadapter.Fill(mydata)

                    wait_cursor(cursor_event.arrow)
                    Select Case returnWhat
                        Case "Adapter"

                            Return myadapter
                        Case "Table"
                            GlobalMydata = mydata
                            Return mydata
                    End Select

                    conn.Close()
                    clear()
                Catch ex As MySqlException
                    wait_cursor(cursor_event.arrow)
                    MsgBox("Error: " & ex.Message & vbNewLine & "Query: " & sqlquery, MsgBoxStyle.Critical)
                    errExist = True
                Finally
                    If conn.State <> ConnectionState.Closed Then conn.Close()
                End Try
                Return mydata
            End Function

            Public Function getFileSize(ByVal location As String)
                Dim FileSize As UInt32
                Dim rawData() As Byte = {}
                Dim fs As FileStream
                If location <> "" Then
                    fs = New FileStream(location, FileMode.Open, FileAccess.Read)
                    FileSize = fs.Length
                    Return FileSize
                Else
                    Return 0
                End If
            End Function

            Public Function saveImage(ByVal ID As String, ByVal Filename As String, ByVal location As String, Optional ByVal field_ID As String = "PIID", Optional ByVal field_Data As String = "file", Optional ByVal field_FileName As String = "", Optional ByVal field_Size As String = "file_size", Optional ByVal tableName As String = "tbl_personal_information_picture")
                Dim cmd As New MySqlCommand
                Dim SQL As String
                Dim errno101 As Boolean
                Dim FileSize As UInt32
                Dim rawData() As Byte = {}
                Dim fs As FileStream
                errExist = False

                'Delete File ID ...
                Query("DELETE FROM " + tableName + " where " + field_ID + " = " + ID)

                Try
                    If location <> "" Then
                        fs = New FileStream(location, FileMode.Open, FileAccess.Read)
                        FileSize = fs.Length

                        rawData = New Byte(FileSize) {}
                        fs.Read(rawData, 0, FileSize)
                        fs.Close()
                    End If

                    conn.Open()

                    If field_FileName = "" Then
                        SQL = "INSERT INTO " & tableName & "(" + field_ID + "," + field_Data + "," + field_Size + ") VALUES(?id, ?file, ?file_size)"
                    Else
                        SQL = "INSERT INTO " & tableName & "(" + field_ID + "," + field_Data + "," + field_Size + "," + field_FileName + ") VALUES(?id, ?file, ?file_size, ?file_name)"
                    End If

                    
                    cmd.Connection = conn
                    cmd.CommandText = SQL
                    cmd.Parameters.AddWithValue("?id", ID)
                    cmd.Parameters.AddWithValue("?file", rawData)
                    cmd.Parameters.AddWithValue("?file_size", FileSize)
                    If field_FileName <> "" Then
                        cmd.Parameters.AddWithValue("?file_name", Filename)
                    End If


                    cmd.ExecuteNonQuery()

                    'MsgBox("File Inserted into database successfully!", MsgBoxStyle.Critical)

                    conn.Close()
                    errno101 = True

                Catch ex As Exception
                    MsgBox("There was an error: " & ex.Message, MsgBoxStyle.Critical)
                    errno101 = False
                    errExist = True
                Finally
                    If conn.State <> ConnectionState.Closed Then conn.Close()
                End Try
                Return errno101

            End Function

            Public Function updateImage(ByVal ID As String, ByVal Filename As String, ByVal location As String, Optional ByVal field_ID As String = "PIID", Optional ByVal field_Data As String = "file", Optional ByVal field_FileName As String = "file_name", Optional ByVal field_Size As String = "file_size", Optional ByVal tableName As String = "tbl_personal_information_picture")
                Dim cmd As New MySqlCommand
                Dim SQL As String
                Dim errno101 As Boolean
                Dim FileSize As UInt32
                Dim rawData() As Byte = {}
                Dim fs As FileStream
                errExist = False

                Try
                    If location <> "" Then
                        fs = New FileStream(location, FileMode.Open, FileAccess.Read)
                        FileSize = fs.Length

                        rawData = New Byte(FileSize) {}
                        fs.Read(rawData, 0, FileSize)
                        fs.Close()
                    End If


                    conn.Open()
                    If field_FileName = "" Then
                        SQL = "UPDATE " & tableName & " SET " + field_Size + " = ?file_size ," + field_Data + " = ?file WHERE " + field_ID + " = ?ID"
                    Else
                        SQL = "UPDATE " & tableName & " SET " + field_FileName + " = ?file_name ," + field_Size + " = ?file_size ," + field_Data + " = ?file WHERE " + field_ID + " = ?ID"
                    End If
                    
                    cmd.Connection = conn
                    cmd.CommandText = SQL
                    cmd.Parameters.AddWithValue("?ID", ID)
                    cmd.Parameters.AddWithValue("?file_name", Filename)
                    cmd.Parameters.AddWithValue("?file_size", FileSize)
                    cmd.Parameters.AddWithValue("?file", rawData)

                    cmd.ExecuteNonQuery()

                    'MsgBox("File Inserted into database successfully!", MsgBoxStyle.Critical)

                    conn.Close()
                    errno101 = True

                Catch ex As Exception
                    'MsgBox("There was an error: " & ex.Message, MsgBoxStyle.Critical)
                    errno101 = False
                    errExist = True
                Finally
                    If conn.State <> ConnectionState.Closed Then conn.Close()
                End Try
                Return errno101

            End Function

            Public Function getImage(ByVal ID As String, Optional ByVal field_ID As String = "PIID", Optional ByVal field_Data As String = "file", Optional ByVal field_Size As String = "file_size", Optional ByVal tableName As String = "tbl_personal_information_picture")
                Dim cmd As New MySqlCommand
                Dim myData As MySqlDataReader
                Dim SQL As String
                Dim rawData() As Byte
                Dim FileSize As UInt32
                Dim ad As New MemoryStream(100000)
                Dim image As Bitmap
                errExist = False

                SQL = "SELECT " + field_Size + ", " + field_Data + " FROM " & tableName & " WHERE " + field_ID + " = ?id"
                Try
                    conn.Open()

                    cmd.Connection = conn
                    cmd.CommandText = SQL
                    cmd.Parameters.AddWithValue("?id", ID)
                    myData = cmd.ExecuteReader

                    If Not myData.HasRows Then Throw New Exception("There are no BLOBs to get")

                    myData.Read()

                    FileSize = myData.GetUInt32(myData.GetOrdinal(field_Size))
                    rawData = New Byte(FileSize) {}

                    myData.GetBytes(myData.GetOrdinal(field_Data), 0, rawData, 0, FileSize)
                    ad.Write(rawData, 0, FileSize)
                    myData.Close()
                    conn.Close()

                Catch ex As Exception
                    'MsgBox("There was an error: " & ex.Message, MsgBoxStyle.Critical)
                    errExist = True
                Finally
                    If conn.State <> ConnectionState.Closed Then conn.Close()
                End Try
                image = New Bitmap(ad)
                Return image
            End Function

#End Region

#End Region

        End Class


    End Namespace

End Namespace






