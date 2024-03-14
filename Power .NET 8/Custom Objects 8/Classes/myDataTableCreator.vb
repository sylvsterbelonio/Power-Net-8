Public Class myDataTableCreator
    Dim myOwnTable As New DataTable

    Public Sub new_table(ByVal name As String)
        myOwnTable = New DataTable
        myOwnTable.TableName = name
    End Sub

    Enum FieldType
        String_
        Image_
        Integer_
        Decimal_
        blob_
        datetime_
    End Enum

    Private Sub set_field(ByVal field_type As FieldType)
        Select Case field_type
            Case FieldType.String_
                myOwnTable.Columns.Add("Name_Employee", System.Type.GetType("System.String"))
        End Select
    End Sub

    Public Sub borrow_table(ByRef dgv As DataTable, ByVal tablename As String)
        If Not dgv Is Nothing Then
            myOwnTable = New DataTable
            myOwnTable = dgv
            myOwnTable.TableName = tablename
        Else
            MsgBox("There is no datatable set. Data table creation failed. Your By reference is nothing please try to fill it.")
        End If
    End Sub

    Public Sub add_columnField(ByVal name As String, Optional ByVal field_type As FieldType = FieldType.String_)
        Select Case field_type
            Case FieldType.String_
                myOwnTable.Columns.Add(name, GetType(String))
            Case FieldType.Image_
                myOwnTable.Columns.Add(name, GetType(Image))
            Case FieldType.Decimal_
                myOwnTable.Columns.Add(name, GetType(Decimal))
            Case FieldType.Integer_
                myOwnTable.Columns.Add(name, GetType(Integer))
            Case FieldType.blob_
                myOwnTable.Columns.Add(name, GetType(Byte()))
            Case FieldType.datetime_
                myOwnTable.Columns.Add(name, GetType(DateTime()))
        End Select
    End Sub

    Public Sub add_columnField_String_Style(ByVal name As String, Optional ByVal field_type As String = "")
        Select Case Trim(field_type).ToLower
            Case "", "string", "language"
                myOwnTable.Columns.Add(name, GetType(String))
            Case "integer", "number", "positiveinteger"
                myOwnTable.Columns.Add(name, GetType(Integer))
            Case "date"
                myOwnTable.Columns.Add(name, GetType(Date))
            Case "boolean"
                myOwnTable.Columns.Add(name, GetType(Boolean))
            Case "base64binary"
                myOwnTable.Columns.Add(name, GetType(Base64FormattingOptions))
            Case Else
                myOwnTable.Columns.Add(name, GetType(String))
        End Select
    End Sub

    Public Function get_table() As DataTable
        Return myOwnTable
    End Function
End Class
