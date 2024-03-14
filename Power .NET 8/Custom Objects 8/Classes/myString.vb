Namespace myString

    Namespace Share

        ''' <summary>
        ''' This class will help to encrypt or decrypt the data to maintain the privacy of the content. This is for security purpose only
        ''' </summary>
        ''' <remarks></remarks>
        Public Class EnDecryption

            ''' <summary>
            ''' It adds the security for the data which is very confidential to anyone who will gain access into it
            ''' </summary>
            ''' <param name="Text">Set the data to be encrypted or decrypted</param>
            ''' <returns>Get the encrypted or decrypted data</returns>
            ''' <remarks></remarks>
            Public Shared Function Execute(ByVal Text As String) As String
                Dim strTempChar As String = ""
                Dim i As Integer
                For i = 1 To Len(Text)
                    'Decrypt
                    If Asc(Mid$(Text, i, 1)) < 128 Then
                        strTempChar = Asc(Mid$(Text, i, 1)) + 128
                        'Encrypt
                    ElseIf Asc(Mid$(Text, i, 1)) > 128 Then
                        strTempChar = Asc(Mid$(Text, i, 1)) - 128
                    End If
                    Mid$(Text, i, 1) = Chr(strTempChar)
                Next i
                Execute = Text
            End Function

        End Class

        Public Class Fonts



        End Class

        Public Class Concat

            Public Shared Sub Append(ByRef based_value As String, Optional ByVal pass_value As String = "", Optional ByVal limiter As String = ",")
                If based_value Is Nothing Or based_value = "" Then
                    based_value = pass_value
                Else
                    based_value += limiter + pass_value
                End If
            End Sub

        End Class

        Public Class Formatter

            Public Shared Function zeroFill(ByVal values As Integer, Optional ByVal length As Integer = 1, Optional ByVal maskedFormat As String = "0") As String
                Dim vT As String = ""
                For i As Integer = values.ToString.Length To length - 1
                    Concat.Append(vT, maskedFormat, "")
                Next
                Concat.Append(vT, values, "")
                Return vT
            End Function

        End Class


    End Namespace

End Namespace


