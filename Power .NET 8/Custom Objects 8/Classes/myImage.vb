Namespace myImage

    Namespace Share

        Namespace Controls

            ''' <summary>
            ''' This class is used to control the image instance for the buttons
            ''' </summary>
            ''' <remarks></remarks>
            Public Class Buttons

                ''' <summary>
                ''' It helps to manage the icon within the button images
                ''' </summary>
                ''' <remarks></remarks>
                Public Class Icon

                    Private Shared Function adjustSize(ByVal size As Integer) As Integer
                        If size <= 24 Then
                            Return 1
                        ElseIf size <= 50 Then
                            Return 2
                        ElseIf size <= 75 Then
                            Return 3
                        ElseIf size < 100 Then
                            Return 4
                        End If
                    End Function

                    ''' <summary>
                    ''' It gets the jquery image style icon. This is a source image file
                    ''' </summary>
                    ''' <param name="type">Specify the type of jquery event</param>
                    ''' <param name="JqueryColor">Specify the jquery color</param>
                    ''' <returns>Geth the cropped image to be used as icon in the button</returns>
                    ''' <remarks></remarks>
                    Public Shared Function getJqueryImage(Optional ByVal type As myIcons.Share.JqueryMobile.JqueryMobileImageSelect = myIcons.Share.JqueryMobile.JqueryMobileImageSelect.Normal, Optional ByVal JqueryColor As myIcons.Share.Jquery.JqueryIconColor = myIcons.Share.Jquery.JqueryIconColor.White)
                        If type = myIcons.Share.JqueryMobile.JqueryMobileImageSelect.Normal Then JqueryColor = myIcons.Share.Jquery.JqueryIconColor.White
                        Select Case JqueryColor
                            Case myIcons.Share.Jquery.JqueryIconColor.White
                                Return My.Resources.ui_darkness_white_ui_icon
                            Case myIcons.Share.Jquery.JqueryIconColor.Black, myIcons.Share.Jquery.JqueryIconColor.NotSet
                                Return My.Resources.ui_icons_070603_256x240
                            Case myIcons.Share.Jquery.JqueryIconColor.Red
                                Return My.Resources.ui_icons_cd0a0a_256x240
                        End Select
                        Return myIcons.Share.Jquery.JqueryIconColor.White
                    End Function

                    ''' <summary>
                    ''' It helps to resize the respective jquery mobile icon based on the specified size from the properties of the button
                    ''' </summary>
                    ''' <param name="JqueryMobileIcon">Specify the jquery mobile icon</param>
                    ''' <param name="width">Set the width of the icon</param>
                    ''' <param name="height">Set the height of the icon</param>
                    ''' <param name="Color">Set the jquery mobile icon color</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Public Shared Function resizeJqueryMobileImageButton(ByVal JqueryMobileIcon As myIcons.Share.JqueryMobile.JqueryMobileIconTypes, ByVal width As Integer, ByVal height As Integer, Optional ByVal Color As myIcons.Share.JqueryMobile.JqueryMobileIconColor = myIcons.Share.JqueryMobile.JqueryMobileIconColor.gray)
                        Try
                            Return myIcons.Share.JqueryMobile.GetJqueryMobileIcon(JqueryMobileIcon, width, height, Color)
                        Catch ex As Exception
                            MsgBox("There was a problem when resizing a picture.", "myPicture[Resize_Image] error occured ")
                        End Try
                        Return Nothing
                    End Function

                    ''' <summary>
                    ''' It helps to resize the respective jquery image based on the specified size from the properties of the button
                    ''' </summary>
                    ''' <param name="JqueryIcon">Specify the jquery icon style</param>
                    ''' <param name="width">Set the width of the icon</param>
                    ''' <param name="height">Set the height of the icon</param>
                    ''' <param name="KindImage">Specify the image source</param>
                    ''' <param name="jqueryColor">Speciry the jquery icon color</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Public Shared Function resizeJqueryImageButton(ByVal JqueryIcon As myIcons.Share.Jquery.JqueryIconTypes, ByVal width As Integer, ByVal height As Integer, Optional ByVal KindImage As myIcons.Share.JqueryMobile.JqueryMobileImageSelect = myIcons.Share.JqueryMobile.JqueryMobileImageSelect.Normal, Optional ByVal jqueryColor As myIcons.Share.Jquery.JqueryIconColor = myIcons.Share.Jquery.JqueryIconColor.White)
                        Try
                            Return myIcons.Share.Jquery.GetJqueryIcons(JqueryIcon, getJqueryImage(KindImage, jqueryColor), width, height)
                        Catch ex As Exception
                            myExceptionHandler.OnThreadException(ex, "There was a problem when resizing a picture. [myPicture[Resize_Image] error occured]")
                        End Try
                        Return Nothing
                    End Function

                    ''' <summary>
                    ''' It helps to resize the respective windows 8 based on the specified size from the properties of the button
                    ''' </summary>
                    ''' <param name="windows8Icon">Specify the windows 8 icon</param>
                    ''' <param name="width">Set the width of the icon</param>
                    ''' <param name="height">Set the height of the icon</param>
                    ''' <param name="color">Set the windows 8 color</param>
                    ''' <param name="KindImage">Specify the MouseMove or MouseDown event</param>
                    ''' <param name="type">Set the during the MouseUp and Mousedown event</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Public Shared Function resizeWindows8ImageButton(ByVal windows8Icon As myIcons.Share.Windows8.Windows8IconTypes, ByVal width As Integer, ByVal height As Integer, ByVal color As Color, Optional ByVal KindImage As myIcons.Share.JqueryMobile.JqueryMobileImageSelect = myIcons.Share.JqueryMobile.JqueryMobileImageSelect.Normal, Optional ByVal type As String = "")
                        Try
                            If KindImage = myIcons.Share.JqueryMobile.JqueryMobileImageSelect.Hover Then
                                Return myIcons.Share.Windows8.GetWindows8Icons(windows8Icon, My.Resources.Window8_white, width, height, color, type)
                            Else
                                Return myIcons.Share.Windows8.GetWindows8Icons(windows8Icon, My.Resources.Window8_white_edited, width, height, color, type)
                            End If
                        Catch ex As Exception
                            myExceptionHandler.OnThreadException(ex, "There was a problem when resizing a picture. [myPicture[Resize_Image] error occured]")
                        End Try
                        Return Nothing
                    End Function

                End Class

            End Class

        End Namespace

        ''' <summary>
        ''' This class helps to convert the image type into other type
        ''' </summary>
        ''' <remarks></remarks>
        Public Class Converter

            ''' <summary>
            ''' It converts the bitmap into icon16
            ''' </summary>
            ''' <param name="bitmap">Set the image to convert</param>
            ''' <returns>Get the icon16</returns>
            ''' <remarks></remarks>
            Public Shared Function BitmapToIcon16(ByVal bitmap As Bitmap) As Icon
                'This little sniplet of code will convert a 16 color bitmap to a icon file.
                'Check that bitmap file is here.
                'Load bitmap
                Dim bmp As Bitmap = bitmap
                'Set trans color.
                bmp.MakeTransparent(Color.Transparent)
                'Convert bitmap to icon from bitmap handle

                Dim ico As Icon = Icon.FromHandle(bmp.GetHicon())
                'Create the file that we use for the icon.
                Dim sw As System.IO.StreamWriter = System.IO.File.CreateText("creating file name for icon")
                'Save icon data to filename.
                ico.Save(sw.BaseStream)
                'Close file
                sw.Close()
                'Clear up
                ico.Dispose()
                bmp.Dispose()
                sw.Dispose()
                Return ico
                ico.ToBitmap()
            End Function

            ''' <summary>
            ''' It converts the icon16 into bitmap
            ''' </summary>
            ''' <param name="icons">Set the icon16 to convert</param>
            ''' <returns>Get the bitmap</returns>
            ''' <remarks></remarks>
            Public Shared Function IconToBitmap(ByVal icons As Icon) As Bitmap
                Return icons.ToBitmap
            End Function

        End Class

        ''' <summary>
        ''' This class handles the other tools to provide more features in handling an image attributes
        ''' </summary>
        ''' <remarks></remarks>
        Public Class Tools

            Private Shared cropBitmap As Bitmap

            ''' <summary>
            ''' It rotates the image in any degree you want to change
            ''' </summary>
            ''' <param name="bitmap">Set the bitmap as reference to this class</param>
            ''' <param name="rotationStyle">Specify what style to apply for the rotation of the image</param>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Shared Function rotateImage(ByVal bitmap As Bitmap, ByVal rotationStyle As System.Drawing.RotateFlipType)
                If Not bitmap Is Nothing Then
                    Dim bm2 As New Bitmap(bitmap)
                    bm2.RotateFlip(rotationStyle)
                    Return bm2
                End If
                Return Nothing
            End Function

            ''' <summary>
            ''' It handles to resize the image size
            ''' </summary>
            ''' <param name="bmp">Set the bitmap as reference to this class</param>
            ''' <param name="width">Set the width of the image</param>
            ''' <param name="height">Set the height of the image</param>
            ''' <returns>Get the resized image</returns>
            ''' <remarks></remarks>
            Public Shared Function resizeImage(ByRef bmp As Bitmap, ByVal width As Integer, ByVal height As Integer) As Bitmap
                Try
                    Dim bm_dest As Bitmap
                    Dim bm_source As Bitmap
                    Dim img1 As New PictureBox

                    img1.Image = cropBitmap
                    bm_source = New Bitmap(bmp)
                    bm_dest = New Bitmap( _
                        CInt(width), _
                        CInt(height))
                    Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)

                    gr_dest.DrawImage(bm_source, 0, 0, width, height)
                    Return bm_dest
                Catch ex As Exception
                    myExceptionHandler.OnThreadException(ex, "There was a problem when resizing a picture. [myPicture[Resize_Image] error occured]")
                End Try
                Return Nothing
            End Function

            ''' <summary>
            ''' It handles to resize the image size. FOR WINDOWS 8 only
            ''' </summary>
            ''' <param name="bmp">Set the bitmap as reference to this class</param>
            ''' <param name="width">Set the width of the image</param>
            ''' <param name="height">Set the height of the image</param>
            ''' <returns>Get the resized image</returns>
            ''' <remarks></remarks>
            Public Shared Function resizeImage_Windows8(ByRef bmp As Bitmap, ByVal width As Integer, ByVal height As Integer, ByVal color As Color, Optional ByVal type As String = "")
                Try
                    Dim bm_dest As Bitmap
                    Dim bm_source As Bitmap
                    Dim img1 As New PictureBox

                    img1.Image = cropBitmap
                    bm_source = New Bitmap(bmp)
                    bm_dest = New Bitmap( _
                        CInt(width), _
                        CInt(height))
                    Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)
                    If type <> "" Then
                        If width >= 48 Then
                            gr_dest.FillEllipse(New SolidBrush(color), New Rectangle(4, 4, width - 10, height - 10))
                        Else
                            gr_dest.FillEllipse(New SolidBrush(color), New Rectangle(3, 3, width - 7, height - 7))
                        End If

                    End If

                    gr_dest.DrawImage(bm_source, 0, 0, width, height)
                    Return bm_dest
                Catch ex As Exception
                    myExceptionHandler.OnThreadException(ex, "There was a problem when resizing a picture. [myPicture[Resize_Image] error occured]")
                End Try
                Return Nothing
            End Function

        End Class

    End Namespace

End Namespace
