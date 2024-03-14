Imports System.IO
Public Class myObjectFetcher
    Private Function BLOB_getPics(ByVal rawdata)
        If Not IsDBNull(rawdata) Then
            Try
                Dim lb() As Byte = rawdata
                Dim lstr As New System.IO.MemoryStream(lb)
                Return Image.FromStream(lstr)
            Catch ex As Exception
                Return Nothing
            End Try
        End If
        Return Nothing
    End Function

    Private Function testchar(ByVal v As String)
        If v <> "" Then
            Select Case v.Length
                Case 1
                    Return "#,##" + v
                Case 2
                    Return "#,#" + v
                Case 3
                    Return "#," + v
                Case 4
                    Return v.Substring(0, 1) + "," + v.Substring(1, v.Length - 2)
                Case Else
            End Select
        End If
        Return "#,##"

    End Function

    Public Function format_NumberOnly(ByVal value As Object, ByVal allow_withcomma As Boolean, Optional ByVal default_value As String = "")
        Dim cn As String = ""
        If default_value <> "" Then cn = default_value
        If allow_withcomma Then
            If cn = "" Then
                cn = "#,###"
            Else
                cn = testchar(default_value.ToString)
            End If
            Return Format(value, cn)
        Else
            Return value
        End If
    End Function

    Public Function get_object_data(ByVal sender As Object, Optional ByVal type_fetch As String = "name")
        Dim name As String = ""
        Dim text_context As String = ""
        If TypeOf sender Is ToolStripButton Then
            name = DirectCast(sender, ToolStripButton).Name
            text_context = DirectCast(sender, ToolStripButton).ToolTipText
        ElseIf TypeOf sender Is ToolStripItem Then
            name = DirectCast(sender, ToolStripItem).Name
            text_context = DirectCast(sender, ToolStripItem).Text
        ElseIf TypeOf sender Is ToolStripDropDownButton Then
            name = DirectCast(sender, ToolStripDropDownButton).Name
            text_context = DirectCast(sender, ToolStripDropDownButton).Text
        ElseIf TypeOf sender Is ToolStripTextBox Then
            name = DirectCast(sender, ToolStripTextBox).Name
            text_context = DirectCast(sender, ToolStripTextBox).Text
        ElseIf TypeOf sender Is ToolStripComboBox Then
            name = DirectCast(sender, ToolStripComboBox).Name
            text_context = DirectCast(sender, ToolStripComboBox).Text
        ElseIf TypeOf sender Is ToolStripLabel Then
            name = DirectCast(sender, ToolStripLabel).Name
            text_context = DirectCast(sender, ToolStripLabel).Text
        ElseIf TypeOf sender Is ToolStripSplitButton Then
            name = DirectCast(sender, ToolStripSplitButton).Name
            text_context = DirectCast(sender, ToolStripSplitButton).Text
        ElseIf TypeOf sender Is ToolStripProgressBar Then
            name = DirectCast(sender, ToolStripProgressBar).Name
            'text_context = DirectCast(sender, ToolStripProgressBar).Tag
        ElseIf TypeOf sender Is ToolStripSeparator Then
            name = DirectCast(sender, ToolStripSeparator).Name
            'text_context = DirectCast(sender, ToolStripSeparator).Name
        End If
        If type_fetch = "text" Then
            Return text_context
        Else
            Return name
        End If
    End Function

    Public Sub set_data(ByRef sender As Object, ByVal value_pass As String, ByVal object_name As String)
        If TypeOf sender Is ToolStrip Then
            For Each c As Object In DirectCast(sender, ToolStrip).Items
                If TypeOf c Is ToolStripLabel Then
                    If CType(c, ToolStripLabel).Name = object_name Then
                        DirectCast(c, ToolStripLabel).Text = value_pass
                    End If
                End If
            Next
        End If
    End Sub

    Enum FormatStyle
        none
        numbers_with_comma
        one_decimal_points
        two_decimal_points
        three_decimal_points
        four_decimal_points
        five_decimal_points
        six_decimal_points
        dateonly__yyyy_mm_ss__DASH_type
        dateonly__mm_dd_yyyy__SLASH_type
        datetime_yyyy_mm_dd_hh_mm_ss__DASH_type
        datetime_mm_dd_yyyy_hh_mm_ss__SLASH_type
        upper_case
        lower_case
    End Enum

    Public Function format_DecimalOnly(ByRef obj As Object, Optional ByVal decimal_range As Integer = 0)
        If Not obj Is Nothing Then
            Dim value As Double = CDbl(obj)
            Return (value).ToString("N" + decimal_range.ToString) ' 2,793,882.42
        End If
        Return Nothing
    End Function

    Private Function validate(ByVal value As Object, ByVal formatters As FormatStyle)
        If TypeOf value Is String Then
            Select Case formatters
                Case FormatStyle.upper_case
                    If Not IsDBNull(value) Then
                        Return value.ToString.ToUpper
                    Else
                        Return value
                    End If
                Case FormatStyle.lower_case
                    If Not IsDBNull(value) Then
                        Return value.ToString.ToLower
                    Else
                        Return value
                    End If
                Case Else
                    Return value
            End Select
        ElseIf IsNumeric(value) Then
            Select Case formatters
                Case FormatStyle.one_decimal_points
                    If Not IsDBNull(value) Then Return format_DecimalOnly(value, 1)
                Case FormatStyle.two_decimal_points
                    If Not IsDBNull(value) Then Return format_DecimalOnly(value, 2)
                Case FormatStyle.three_decimal_points
                    If Not IsDBNull(value) Then Return format_DecimalOnly(value, 3)
                Case FormatStyle.four_decimal_points
                    If Not IsDBNull(value) Then Return format_DecimalOnly(value, 4)
                Case FormatStyle.five_decimal_points
                    If Not IsDBNull(value) Then Return format_DecimalOnly(value, 5)
                Case FormatStyle.six_decimal_points
                    If Not IsDBNull(value) Then Return format_DecimalOnly(value, 6)
                Case FormatStyle.numbers_with_comma
                    If Not IsDBNull(value) Then Return format_NumberOnly(value, True, "0")
                Case Else
                    If Not IsDBNull(value) Then Return value.ToString
            End Select
        ElseIf TypeOf value Is Date Then
            Select Case formatters
                Case FormatStyle.dateonly__mm_dd_yyyy__SLASH_type
                    If Not IsDBNull(value) Then Return CType(value, Date).ToString("MM/dd/yyyy")
                Case FormatStyle.dateonly__yyyy_mm_ss__DASH_type
                    If Not IsDBNull(value) Then Return CType(value, Date).ToString("yyyy-MM-dd")
                Case FormatStyle.datetime_mm_dd_yyyy_hh_mm_ss__SLASH_type
                    If Not IsDBNull(value) Then Return CType(value, Date).ToString("MM/dd/yyyy hh:mm:ss")
                Case FormatStyle.datetime_yyyy_mm_dd_hh_mm_ss__DASH_type
                    If Not IsDBNull(value) Then Return CType(value, Date).ToString("yyyy-MM-dd hh:mm:ss")
                Case Else
                    If Not IsDBNull(value) Then Return CType(value, Date).ToString
            End Select
        End If
        Return Nothing
    End Function

    Public Sub set_object_value(ByRef obj As Object, ByVal value As Object, Optional ByVal Formatters As FormatStyle = FormatStyle.none)
        Try
            If TypeOf obj Is TextBox Then
                If Not IsDBNull(value) Then CType(obj, TextBox).Text = validate(value, Formatters)
            ElseIf TypeOf obj Is MaskedTextBox Then
                If Not IsDBNull(value) Then CType(obj, MaskedTextBox).Text = validate(value, Formatters)
            ElseIf TypeOf obj Is ComboBox Then
                If Not IsDBNull(value) Then CType(obj, ComboBox).Text = validate(value, Formatters)
            ElseIf TypeOf obj Is RadioButton Then
                If Not IsDBNull(value) Then CType(obj, RadioButton).Checked = value
            ElseIf TypeOf obj Is CheckBox Then
                If Not IsDBNull(value) Then CType(obj, CheckBox).Checked = value
            ElseIf TypeOf obj Is DateTimePicker Then
                If Not IsDBNull(value) Then CType(obj, DateTimePicker).Value = value
            ElseIf TypeOf obj Is Infragistics.Win.UltraWinEditors.UltraDateTimeEditor Then
                If Not IsDBNull(value) Then CType(obj, Infragistics.Win.UltraWinEditors.UltraDateTimeEditor).Value = value
            ElseIf TypeOf obj Is Label Then
                If Not IsDBNull(value) Then CType(obj, Label).Text = validate(value, Formatters)
            ElseIf TypeOf obj Is LinkLabel Then
                If Not IsDBNull(value) Then CType(obj, LinkLabel).Text = validate(value, Formatters)
            ElseIf TypeOf obj Is PictureBox Or TypeOf obj Is Image Or TypeOf obj Is Bitmap Then
                If Not IsDBNull(value) Then
                    If TypeOf value Is Array Then
                        If TypeOf obj Is PictureBox Then
                            If Not IsDBNull(value) Then CType(obj, PictureBox).Image = BLOB_getPics(value)
                        ElseIf TypeOf obj Is Image Then
                            If Not IsDBNull(value) Then obj = BLOB_getPics(value)
                        ElseIf TypeOf obj Is Bitmap Then
                            If Not IsDBNull(value) Then obj = BLOB_getPics(value)
                        End If
                    End If
                End If
            ElseIf obj Is Nothing And TypeOf value Is Array Then
                If Not IsDBNull(value) Then obj = BLOB_getPics(value)
            ElseIf TypeOf obj Is NumericUpDown Then
                If Not IsDBNull(value) Then CType(obj, NumericUpDown).Value = value
            ElseIf TypeOf obj Is RichTextBox Then
                If Not IsDBNull(value) Then CType(obj, RichTextBox).Text = validate(value, Formatters)


                'Data Type Value'
            ElseIf TypeOf obj Is String Then
                If Not IsDBNull(value) Then obj = validate(value, Formatters)
            ElseIf TypeOf obj Is Integer Then
                If Not IsDBNull(value) Then obj = value
            ElseIf TypeOf obj Is Decimal Then
                If Not IsDBNull(value) Then obj = value
            Else
                If Not IsDBNull(value) Then obj = validate(value, Formatters)
            End If
        Catch ex As Exception
            MsgBox("There was an error incorrect assignment of objects: " + ex.ToString)
        End Try
    End Sub

    Public Function get_object_value(ByVal obj As Object) As Object
        Try
            If TypeOf obj Is TextBox Then
                Return CType(obj, TextBox).Text
            ElseIf TypeOf obj Is MaskedTextBox Then
                Return CType(obj, MaskedTextBox).Text
            ElseIf TypeOf obj Is ComboBox Then
                Return CType(obj, ComboBox).Text
            ElseIf TypeOf obj Is RadioButton Then
                Return CType(obj, RadioButton).Checked
            ElseIf TypeOf obj Is CheckBox Then
                Return CType(obj, CheckBox).Checked
            ElseIf TypeOf obj Is DateTimePicker Then
                Return CType(obj, DateTimePicker).Value.ToString("yyyy-MM-dd hh:mm:ss")
            ElseIf TypeOf obj Is Infragistics.Win.UltraWinEditors.UltraDateTimeEditor Then
                Dim dt As Date = CType(obj, Infragistics.Win.UltraWinEditors.UltraDateTimeEditor).Value
                Return dt.ToString("yyyy-MM-dd hh:mm:ss")
            ElseIf TypeOf obj Is Label Then
                Return CType(obj, Label).Text
            ElseIf TypeOf obj Is LinkLabel Then
                Return CType(obj, LinkLabel).Text
            ElseIf TypeOf obj Is PictureBox Or TypeOf obj Is Image Or TypeOf obj Is Bitmap Then

                Dim img As Bitmap = Nothing

                If TypeOf obj Is PictureBox Then
                    img = CType(obj, PictureBox).Image
                ElseIf TypeOf obj Is Image Then
                    img = obj
                ElseIf TypeOf obj Is Bitmap Then
                    img = obj
                End If

                If Not img Is Nothing Then
                    Dim FileSize As UInt32
                    Dim rawData() As Byte = {}
                    Dim fs As FileStream

                    fs = New FileStream(save_temporary_image_and_get_location(img, "rawdata"), FileMode.Open, FileAccess.Read)
                    FileSize = fs.Length
                    rawData = New Byte(FileSize) {}
                    fs.Read(rawData, 0, FileSize)
                    fs.Close()
                    Return rawData
                Else
                    Return ""
                End If

            ElseIf TypeOf obj Is NumericUpDown Then
                Return CType(obj, NumericUpDown).Value.ToString
            ElseIf TypeOf obj Is RichTextBox Then
                Return CType(obj, RichTextBox).Text
            ElseIf obj Is Nothing Then
                Return ""
            Else
                Return obj.ToString
            End If
        Catch ex As Exception
            MsgBox("There was an error incorrect assignment of objects: " + ex.ToString)
        End Try
        Return False
    End Function

    Private Function save_temporary_image_and_get_location(ByVal bm As Bitmap, ByVal pictureName As String) As String
        myFile.Share.Folders.createFolder(myFile.Share.Location.getBasePath, "Templates") 'I've created templates folder'
        myFile.Share.Folders.createFolder(myFile.Share.Location.getBasePath + "\Templates", "Picture")
        Dim location As String = myFile.Share.Location.getBasePath & "\Templates\Picture\" + pictureName + ".jpg"
        bm.Save(location, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return location
    End Function

End Class
