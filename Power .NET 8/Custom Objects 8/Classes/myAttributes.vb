Namespace myAttributes

    Namespace Init


    End Namespace

    Namespace Share

        Public Class ScreenWindows

            Public Shared Function getScreenWidth() As Integer
                Return Screen.PrimaryScreen.Bounds.Width
            End Function

            Public Shared Function getScreenHeight() As Integer
                Return Screen.PrimaryScreen.Bounds.Height
            End Function

        End Class

        Public Class Forms

            Public Enum AtrPosition
                Top
                TopLeft
                TopRight
                MiddleLeft
                Bottom
                Center
                Right
            End Enum

            Public Shared Sub Position(ByRef form As Form, ByVal Style As AtrPosition)
                With form
                    .StartPosition = FormStartPosition.Manual
                    Select Case Style
                        Case AtrPosition.Right
                            .Location = New Point(ScreenWindows.getScreenWidth - .Width, 0)
                        Case AtrPosition.Right

                        Case AtrPosition.Top

                        Case AtrPosition.Bottom

                        Case AtrPosition.Center
                            .StartPosition = FormStartPosition.CenterScreen
                    End Select
                End With
            End Sub





        End Class

    End Namespace

End Namespace

