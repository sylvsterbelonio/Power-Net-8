Imports Infragistics.Win.UltraWinTabs

Namespace myDate
    Namespace Init

        Public Class Format

            Friend mychar As New myCharacter

            Public Function get_Month_String_Full(ByVal index As Integer) As String
                If index < 0 Then index = 1
                If index > 12 Then index = 12
                Dim month() As String = {"", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
                Return month(index)
            End Function 'You can get A full word of month by specifying the number of index from 1-12'

            Public Function get_current_time()
                Return "Today is " + Now.DayOfWeek.ToString + ", " + Now.ToString("MMMM") + " " + mychar.get_char_by_grade_mode(Now.Day.ToString) + ", " + Now.ToString("yyyy hh:mm:ss tt")
            End Function 'You can get the current time of your personal system but not the server time.

            Public Function get_Month_String_3Char(ByVal index As Integer) As String
                If index < 0 Then index = 1
                If index > 12 Then index = 12
                Dim month() As String = {"", "Jan.", "Feb.", "Mar.", "Apr.", "May", "Jun.", "Jul.", "Aug.", "Sep.", "Oct.", "Nov.", "Dec."}
                Return month(index)
            End Function 'You can get A three letter abbreviated words in month by specifying from 1 to 12.

            Public Function get_LastDay_of_Month(ByVal myDate As Date) As Integer
                Dim GetLastDay As Date = DateSerial(myDate.Year, myDate.Month + 1, 0)
                Return GetLastDay.Day
            End Function

            Public Function get_DayOfWeek(ByVal dt As Date)
                Return dt.DayOfWeek.ToString
            End Function

            Public Function ObjectDates(ByVal sender As Object, ByVal type As String, Optional ByVal mydates As Date = Nothing) As Date
                Try
                    If type = "get" Then
                        If TypeOf sender Is Infragistics.Win.UltraWinEditors.UltraDateTimeEditor Then
                            Return CType(sender, Infragistics.Win.UltraWinEditors.UltraDateTimeEditor).Value
                        ElseIf TypeOf sender Is DateTimePicker Then
                            Return CType(sender, DateTimePicker).Value
                        End If
                    Else
                        If TypeOf sender Is Infragistics.Win.UltraWinEditors.UltraDateTimeEditor Then
                            CType(sender, Infragistics.Win.UltraWinEditors.UltraDateTimeEditor).Value = mydates
                        ElseIf TypeOf sender Is DateTimePicker Then
                            CType(sender, DateTimePicker).Value = mydates
                        End If
                    End If
                Catch ex As Exception
                End Try
                Return Nothing
            End Function 'You can "set" or "get" a date datatype in ultratimeeditor based from the pass by value of dates

            Public Sub set_AutoSuggestRangeDate(ByVal Based_Date As Object, ByRef Assigned_Object As Object, Optional ByVal number_of_days As Integer = 0)
                Dim mydates As Date = ObjectDates(Based_Date, "get")
                Dim day As Integer = mydates.Day
                Dim month As Integer = mydates.Month
                Dim year As Integer = mydates.Year
                Dim remaining_day As Integer
                Dim lastday As Integer = get_LastDay_of_Month(mydates)
                Dim newDates As Date
                day += number_of_days
                If day <= lastday Then
                    newDates = New Date(year, month, day)
                Else
                    remaining_day = day - lastday
                    month += 1
                    If month <= 12 Then
                        newDates = New Date(year, month, remaining_day)
                    Else
                        remaining_day = day - lastday
                        year += 1
                        month = 1
                        newDates = New Date(year, month, remaining_day)
                    End If
                End If
                ObjectDates(Assigned_Object, "set", newDates)
            End Sub

            Enum DateStyle
                From_String_to_Number
                From_Number_to_String
            End Enum

            Enum FormatMonthStyle
                ThreeWordsWithDot
                ThreeWordsNoDot
                FullWords
            End Enum

            Public Function getFormatWords(ByVal values As String, ByVal style As FormatMonthStyle)
                Select Case style
                    Case FormatMonthStyle.FullWords
                        Return values
                    Case FormatMonthStyle.ThreeWordsNoDot
                        Return values.Substring(0, 3)
                    Case FormatMonthStyle.ThreeWordsWithDot
                        Return values.Substring(0, 3) + "."
                End Select
                Return Nothing
            End Function

            Public Function get_Date_Convertion(ByVal values As String, Optional ByVal style As DateStyle = DateStyle.From_String_to_Number, Optional ByVal WordFormatStyle As FormatMonthStyle = FormatMonthStyle.FullWords)
                If style = DateStyle.From_String_to_Number Then
                    If values = "January" Or values = "Jan." Then Return "1"
                    If values = "February" Or values = "Feb." Then Return "2"
                    If values = "March" Or values = "Mar." Then Return "3"
                    If values = "April" Or values = "Apr." Then Return "4"
                    If values = "May" Then Return "5"
                    If values = "June" Or values = "Jun." Then Return "6"
                    If values = "July" Or values = "Jul." Then Return "7"
                    If values = "August" Or values = "Aug." Then Return "8"
                    If values = "September" Or values = "Sep." Then Return "9"
                    If values = "October" Or values = "Oct." Then Return "10"
                    If values = "November" Or values = "Nov." Then Return "11"
                    If values = "December" Or values = "Dec." Then Return "12"
                ElseIf style = DateStyle.From_Number_to_String Then
                    If values = "1" Then Return getFormatWords("January", WordFormatStyle)
                    If values = "2" Then Return getFormatWords("February", WordFormatStyle)
                    If values = "3" Then Return getFormatWords("March", WordFormatStyle)
                    If values = "4" Then Return getFormatWords("April", WordFormatStyle)
                    If values = "5" Then Return getFormatWords("May", WordFormatStyle)
                    If values = "6" Then Return getFormatWords("June", WordFormatStyle)
                    If values = "7" Then Return getFormatWords("July", WordFormatStyle)
                    If values = "8" Then Return getFormatWords("August", WordFormatStyle)
                    If values = "9" Then Return getFormatWords("September", WordFormatStyle)
                    If values = "10" Then Return getFormatWords("October", WordFormatStyle)
                    If values = "11" Then Return getFormatWords("November", WordFormatStyle)
                    If values = "12" Then Return getFormatWords("December", WordFormatStyle)
                End If
                Return Nothing
            End Function ' You can convert the integer into string format of MOnths or you can reverse it.

            Enum Operands
                Subraction
                Addition
                Multiplication
                Division
            End Enum

            Public Function get_DateOperands(ByVal dates As Date, ByVal value As Integer, Optional ByVal type_operator As Operands = Operands.Addition)
                Try
                    Dim lastDay As Integer = get_LastDay_of_Month(dates)
                    Dim day As Integer = dates.Day
                    Dim month As Integer = dates.Month
                    Dim year As Integer = dates.Year
                    Select Case type_operator
                        Case Operands.Addition
                            day += value
                        Case Operands.Subraction
                            day -= value
                        Case Operands.Multiplication
                            day *= value
                        Case Operands.Division
                            day /= value
                    End Select
                    If day <= 0 Then
                        If month > 1 Then
                            month -= 1
                            lastDay = get_LastDay_of_Month(New Date(year, month, 1))
                            lastDay += day
                            day = lastDay
                        ElseIf month = 1 Then
                            month = 12
                            year -= 1
                            lastDay = get_LastDay_of_Month(New Date(year, month, 1))
                            lastDay += day
                            day = lastDay
                        End If
                    ElseIf day > lastDay Then
                        If month < 12 Then
                            lastDay = get_LastDay_of_Month(New Date(year, month, 1))
                            month += 1
                            day = day - lastDay
                        ElseIf month = 12 Then
                            lastDay = get_LastDay_of_Month(New Date(year, month, 1))
                            month = 1
                            year += 1
                            day = day - lastDay
                        End If
                    End If
                    Return New Date(year, month, day)
                Catch ex As Exception
                    Return Now
                End Try
            End Function 'You can add, multiply, minus and divide the day and will get the exact date.

#Region "SIR ALDWINS CODE"

            Public Function ConvertoDate(ByVal dateString As String, ByRef result As DateTime) As Boolean
                Try
                    Dim supportedFormats() As String = New String() {"MM/dd/yyyy", "MM/dd/yy", "ddMMMyyyy", "dMMMyyyy"}
                    result = DateTime.ParseExact(dateString, supportedFormats, System.Globalization.CultureInfo.CurrentCulture, System.Globalization.DateTimeStyles.None)
                    Return True
                Catch ex As Exception
                    Return False
                End Try
            End Function

            Public Function ConvertoDate(ByVal dateString As String) As Date
                Dim supportedFormats() As String = New String() {"MM/dd/yyyy", "MM/dd/yy", "ddMMMyyyy", "dMMMyyyy"}
                Return DateTime.ParseExact(dateString, supportedFormats, System.Globalization.CultureInfo.CurrentCulture, System.Globalization.DateTimeStyles.None)
            End Function

#End Region

            Public Function String_to_Date(Optional ByVal dateString As String = "YYYY-mm-dd") As Date
                Try
                    Return Date.Parse(dateString)
                Catch ex As Exception
                    MsgBox("Error conversion of string into date. You must follow the proper format (yyyy-MM-dd)")
                End Try
            End Function ' Conversion from string into date but you must follow the proper format.

        End Class
    End Namespace

    Namespace Share

        Public Class Convert
            Private Shared Function validateDate(ByVal value As Integer)
                If value > 23 Then
                    Return 23
                Else
                    Return value
                End If
            End Function

            Public Shared Function toStringDate(ByVal dates As DateTime) As String
                Dim str() As String = dates.ToString.Split(" ")
                Dim dt() As String = str(0).Split("/")
                Dim tm() As String = str(1).Split(":")
                If str(2) = "AM" Then
                    Return dt(2) + "-" + dt(0) + "-" + dt(1) + " " + str(1)
                Else
                    Return dt(2) + "-" + dt(0) + "-" + dt(1) + " " + (validateDate(Val(tm(0)) + 12)).ToString + ":" + tm(1) + ":" + tm(2)
                End If
            End Function

        End Class

    End Namespace
End Namespace