Imports System.Text
Public Class myCharacter

    Public Function user_info_wrapper(Optional ByVal ghost As String = "localhost", Optional ByVal gport As String = "3306", Optional ByVal guser As String = "root", Optional ByVal gpass As String = "", Optional ByVal gdbname As String = "", Optional ByVal gusername As String = "", Optional ByVal gThemeID As String = "1", Optional ByVal gUserID As String = "", Optional ByVal groleID As String = "", Optional ByVal gEmployee As String = "", Optional ByVal gSystemRole As String = "", Optional ByVal gThemeName As String = "Green Dock")
        Return ghost + "," + gport + "," + guser + "," + gpass + "," + gdbname + "," + gusername + "," + gThemeID + "," + gUserID + "," + groleID + "," + gEmployee + "," + gSystemRole + "," + gThemeName
    End Function

    Public Function get_char_by_grade_mode(ByVal values As String)
        Dim no As Integer = Val(values.Substring(values.Length - 1, 1))
        If no = 1 Then Return values + "st"
        If no = 2 Then Return values + "nd"
        If no = 3 Then Return values + "rd"
        Return values + "th"
    End Function

    'This function will replace single quotes to double quotes and remove excess spaces in a string
    Public Function ReplaceSingleQuotes(ByVal Param As String) As String
        Dim sbTemp As StringBuilder = New StringBuilder(Param)
        sbTemp.Replace("'", "''")
        Return TrimAll(sbTemp.ToString)
    End Function

    'This function will replace single quotes to double quotes and remove excess spaces in a string
    Public Function removeSpecialCharacter(ByVal Param As String) As String
        Dim sbTemp As StringBuilder = New StringBuilder(Param)
        sbTemp.Replace("''", "")
        sbTemp.Replace("'", "")
        Return Trim(sbTemp.ToString)
    End Function

    Public Function replaceSpecialCharacter(ByVal Param As String) As String
        Dim sbTemp As StringBuilder = New StringBuilder(Param)
        sbTemp.Replace("''", "''''")
        sbTemp.Replace("'", "''")
        Return Trim(sbTemp.ToString)
    End Function

    ' Replace ALL Duplicate Characters in String with a Single Instance
    Public Function TrimAll(ByVal TextIn As String, Optional ByVal TrimChar As String = " ", Optional ByVal CtrlChar As String = Chr(0)) As String
        Try
            TrimAll = Replace(TextIn, TrimChar, CtrlChar) ' In case of CrLf etc.

            While InStr(TrimAll, CtrlChar + CtrlChar) > 0
                TrimAll = TrimAll.Replace(CtrlChar + CtrlChar, CtrlChar)
            End While

            TrimAll = TrimAll.Trim(CtrlChar) ' Trim Begining and End
            TrimAll = TrimAll.Replace(CtrlChar, TrimChar) ' Replace with Original Trim Character(s)
        Catch Exp As Exception
            TrimAll = TextIn ' Justin Case
        End Try
        Return TrimAll
    End Function

   

    ' Copyright (c) 2010, reusablecode.blogspot.com; some rights reserved.
    '
    ' This work is licensed under the Creative Commons Attribution License. To view
    ' a copy of this license, visit http://creativecommons.org/licenses/by/3.0/ or
    ' send a letter to Creative Commons, 559 Nathan Abbott Way, Stanford, California
    ' 94305, USA.

    ' Despite the identical naming, these functions are more comprehensive than their PHP equivalents. 
    ' They go above and beyond even mysql_real_escape_string(), by including support for backspace and horizontal tab.

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

    ' Returns a string with backslashes before characters that need to be quoted in database queries
    'Function addslashes(ByVal unsafeString)
    '    addslashes = regEx.replace(unsafeString, "([\000\010\011\012\015\032\042\047\134\140])", "\$1")
    'End Function

    '' Un-quote string quoted with addslashes()
    'Function stripslashes(ByVal safeString)
    '    stripslashes = regEx.replace(safeString, "\\([\000\010\011\012\015\032\042\047\134\140])", "$1")
    'End Function

End Class
