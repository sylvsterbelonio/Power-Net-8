Namespace myColor

    Namespace Share

        Namespace SystemColor

            ''' <summary>
            ''' This class is used for getting the default color of the system before the user customize their color they want
            ''' </summary>
            ''' <remarks></remarks>
            Public Class DefaultColor

                ''' <summary>
                ''' It gets the content backcolor of the form
                ''' </summary>
                ''' <returns>Get the content backcolor of the form</returns>
                ''' <remarks></remarks>
                Public Shared Function getContentBackColor() As String
                    Return "FAFBFB"
                End Function

                ''' <summary>
                ''' It gets the background color of all objects of the entire system
                ''' </summary>
                ''' <returns>Get the background color of the object</returns>
                ''' <remarks></remarks>
                Public Shared Function getBackGroundColor() As String
                    Return "cyan-A6-#0093E1"
                End Function

                ''' <summary>
                ''' It gets the accent color of all objects of the entire system
                ''' </summary>
                ''' <returns>Get the accent color of the object</returns>
                ''' <remarks></remarks>
                Public Shared Function getAccentColor() As String
                    Return "cyan-A6-#5D9DD7"
                End Function

            End Class

            Namespace BackgroundColor

                ''' <summary>
                ''' This class is used to get the standard color of windows 8 platform themes
                ''' </summary>
                ''' <remarks></remarks>
                Public Class StandardColor

                    Dim myColor As New myColor.Share.Converter.StringToColor
                    Private BackColor As Color
                    Private HoverBackColor As Color
                    Private PressedBackColor As Color
                    Private ForeColor As Color
                    Private HoverForeColor As Color
                    Private PressedForeColor As Color

                    ''' <summary>
                    ''' List of standard colors of windows 9
                    ''' </summary>
                    ''' <remarks></remarks>
                    Public Enum DColors
                        Teal
                        Blue
                        Purple
                        DarkPurple
                        Red
                        Orange
                        Green
                        SkyBlue
                        Disabled
                        SilverGlass
                    End Enum

                    ''' <summary>
                    ''' You can set the standard color of windows 8 by specifying the list
                    ''' </summary>
                    ''' <param name="type">Specify what list of standard colors of windows 8</param>
                    ''' <remarks></remarks>
                    Public Sub getDefaultColor(Optional ByVal type As DColors = DColors.Blue)
                        Select Case type
                            Case DColors.Teal

                                BackColor = myColor.getHTMLColor("#008299")
                                HoverBackColor = myColor.getHTMLColor("#00A0B1")
                                PressedBackColor = Color.White

                                ForeColor = Color.White
                                HoverForeColor = Color.White
                                PressedForeColor = myColor.getHTMLColor("#008299")

                            Case DColors.Blue

                                BackColor = myColor.getHTMLColor("#2672EC")
                                HoverBackColor = myColor.getHTMLColor("#2E8DEF")
                                PressedBackColor = Color.White

                                ForeColor = Color.White
                                HoverForeColor = Color.White
                                PressedForeColor = myColor.getHTMLColor("#2672EC")

                            Case DColors.Purple

                                BackColor = myColor.getHTMLColor("#8C0095")
                                HoverBackColor = myColor.getHTMLColor("#A700AE")
                                PressedBackColor = Color.White

                                ForeColor = Color.White
                                HoverForeColor = Color.White
                                PressedForeColor = myColor.getHTMLColor("#8C0095")

                            Case DColors.DarkPurple

                                BackColor = myColor.getHTMLColor("#5133AB")
                                HoverBackColor = myColor.getHTMLColor("#643EBF")
                                PressedBackColor = Color.White

                                ForeColor = Color.White
                                HoverForeColor = Color.White
                                PressedForeColor = myColor.getHTMLColor("#643EBF")

                            Case DColors.Red

                                BackColor = myColor.getHTMLColor("#AC193D")
                                HoverBackColor = myColor.getHTMLColor("#BF1E4B")
                                PressedBackColor = Color.White

                                ForeColor = Color.White
                                HoverForeColor = Color.White
                                PressedForeColor = myColor.getHTMLColor("#AC193D")

                            Case DColors.Orange

                                BackColor = myColor.getHTMLColor("#D24726")
                                HoverBackColor = myColor.getHTMLColor("#DC572E")
                                PressedBackColor = Color.White

                                ForeColor = Color.White
                                HoverForeColor = Color.White
                                PressedForeColor = myColor.getHTMLColor("#D24726")

                            Case DColors.Green

                                BackColor = myColor.getHTMLColor("#008A00")
                                HoverBackColor = myColor.getHTMLColor("#00A600")
                                PressedBackColor = Color.White

                                ForeColor = Color.White
                                HoverForeColor = Color.White
                                PressedForeColor = myColor.getHTMLColor("#008A00")

                            Case DColors.SkyBlue

                                BackColor = myColor.getHTMLColor("#094AB2")
                                HoverBackColor = myColor.getHTMLColor("#0A5BC4")
                                PressedBackColor = Color.White

                                ForeColor = Color.White
                                HoverForeColor = Color.White
                                PressedForeColor = myColor.getHTMLColor("#094AB2")


                            Case DColors.SilverGlass

                                BackColor = myColor.getHTMLColor("#CCCCCC")
                                HoverBackColor = myColor.getHTMLColor("#D8D8D8")
                                PressedBackColor = Color.Black

                                ForeColor = Color.Black
                                HoverForeColor = Color.Black
                                PressedForeColor = Color.White


                            Case DColors.Disabled

                                BackColor = myColor.getHTMLColor("#A4A8AA")
                                'HoverBackColor = myColor.readHTMLColor("#0A5BC4")
                                'PressedBackColor = Color.White

                                ForeColor = Color.White
                                'HoverForeColor = Color.White
                                'PressedForeColor = myColor.readHTMLColor("#094AB2")

                        End Select
                    End Sub

                    ''' <summary>
                    ''' It gets a color for backcolor purpose
                    ''' </summary>
                    ''' <returns>Get the backcolor</returns>
                    ''' <remarks></remarks>
                    Public Function gBackColor() As Color
                        Return BackColor
                    End Function

                    ''' <summary>
                    ''' It gets a mousemove event color for backcolor purpose
                    ''' </summary>
                    ''' <returns>Get the MouseMove Event Backcolor</returns>
                    ''' <remarks></remarks>
                    Public Function gHoverBackColor() As Color
                        Return HoverBackColor
                    End Function

                    ''' <summary>
                    ''' It gets a mousedown event color for backcolor purpose
                    ''' </summary>
                    ''' <returns>Get the MouseDown Event Backcolor</returns>
                    ''' <remarks></remarks>
                    Public Function gPressedBackColor() As Color
                        Return PressedBackColor
                    End Function

                    ''' <summary>
                    ''' It gets a color for forecolor purpose
                    ''' </summary>
                    ''' <returns>Get the forecolor</returns>
                    ''' <remarks></remarks>
                    Public Function gForeColor() As Color
                        Return ForeColor
                    End Function

                    ''' <summary>
                    ''' It gets a MouseMove event for forecolor purpose
                    ''' </summary>
                    ''' <returns>Get the MouseMove event forecolor</returns>
                    ''' <remarks></remarks>
                    Public Function gHoverForeColor() As Color
                        Return HoverForeColor
                    End Function

                    ''' <summary>
                    ''' It gets a MouseDown event for forecolor purpose
                    ''' </summary>
                    ''' <returns>Get the MouseDown event forecolor</returns>
                    ''' <remarks></remarks>
                    Public Function gPressedForeColor() As Color
                        Return PressedForeColor
                    End Function

                End Class

                ''' <summary>
                ''' The class will let the system select what type of color is used to be displayed in the background color and selection color of the color picker panel such as BACKGROUND and ACCENT themecolor for windows 8
                ''' </summary>
                ''' <remarks></remarks>
                Public Class General

                    ''' <summary>
                    ''' List of colors of windows 8 skin
                    ''' </summary>
                    ''' <remarks></remarks>
                    Enum TypeColor
                        black
                        gray
                        red
                        scarlet
                        orange
                        orangeyellow
                        yelloworange
                        yellow
                        yellowgreen
                        green
                        bluegreen
                        skyblue
                        cyan
                        blue
                        blueviolete
                        violete
                        pink
                        hotpink
                    End Enum

                    ''' <summary>
                    ''' It gets the specific color within the specified dialog color picker in the system
                    ''' </summary>
                    ''' <param name="type">Set Type of Color</param>
                    ''' <param name="row">Set the number of row from [0-5]</param>
                    ''' <param name="column">Set the number of columns from [0-5]</param>
                    ''' <returns>Get the color based on the specified color type, rows and columns</returns>
                    ''' <remarks></remarks>
                    Public Shared Function GetBackgroundColor(ByVal type As TypeColor, ByVal row As Integer, ByVal column As Integer)
                        Select Case type
                            Case TypeColor.black
                                Return myColor.Share.SystemColor.BackgroundColor.Black.getColor(row, column)
                            Case TypeColor.gray
                                Return myColor.Share.SystemColor.BackgroundColor.Gray.getColor(row, column)
                            Case TypeColor.blueviolete
                                Return myColor.Share.SystemColor.BackgroundColor.BlueViolete.getColor(row, column)
                            Case TypeColor.violete
                                Return myColor.Share.SystemColor.BackgroundColor.Violete.getColor(row, column)
                            Case TypeColor.pink
                                Return myColor.Share.SystemColor.BackgroundColor.Pink.getColor(row, column)
                            Case TypeColor.hotpink
                                Return myColor.Share.SystemColor.BackgroundColor.HotPink.getColor(row, column)
                            Case TypeColor.red
                                Return myColor.Share.SystemColor.BackgroundColor.Red.getColor(row, column)
                            Case TypeColor.scarlet
                                Return myColor.Share.SystemColor.BackgroundColor.Scarlet.getColor(row, column)
                            Case TypeColor.orange
                                Return myColor.Share.SystemColor.BackgroundColor.Orange.getColor(row, column)
                            Case TypeColor.orangeyellow
                                Return myColor.Share.SystemColor.BackgroundColor.OrangeYellow.getColor(row, column)
                            Case TypeColor.yelloworange
                                Return myColor.Share.SystemColor.BackgroundColor.YellowOrange.getColor(row, column)
                            Case TypeColor.yellow
                                Return myColor.Share.SystemColor.BackgroundColor.Yellow.getColor(row, column)
                            Case TypeColor.yellowgreen
                                Return myColor.Share.SystemColor.BackgroundColor.YellowGreen.getColor(row, column)
                            Case TypeColor.green
                                Return myColor.Share.SystemColor.BackgroundColor.Green.getColor(row, column)
                            Case TypeColor.bluegreen
                                Return myColor.Share.SystemColor.BackgroundColor.BlueGreen.getColor(row, column)
                            Case TypeColor.skyblue
                                Return myColor.Share.SystemColor.BackgroundColor.SkyBlue.getColor(row, column)
                            Case TypeColor.cyan
                                Return myColor.Share.SystemColor.BackgroundColor.Cyan.getColor(row, column)
                            Case TypeColor.blue
                                Return myColor.Share.SystemColor.BackgroundColor.Blue.getColor(row, column)
                            Case Else
                                Return myColor.Share.SystemColor.BackgroundColor.Black.getColor(row, column)
                        End Select
                    End Function

                    ''' <summary>
                    ''' It gets the selection color which is found beneath the diolog colode picker
                    ''' </summary>
                    ''' <param name="column">Set the column number from [0-17] to get the color</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Public Shared Function getSColor(ByVal column As Integer)
                        If column > 17 Then column = 17
                        Dim col() As String = "383838/71786A/4301C7/8319E6/D62EB3/D7006F/AD2C4A/D81313/D02E10/D76712/E1A61E/E5C12B/61A917/3AB411/19B160/1DA89A/159DCE/146CE8".Split("/")
                        Return myColor.Share.Converter.StringToColor.getHTMLColor("#" + col(column))
                    End Function

                End Class

                ''' <summary>
                ''' It gets the black color
                ''' </summary>
                ''' <remarks></remarks>
                Public Class Black
                    ''' <summary>
                    ''' Get color Black
                    ''' </summary>
                    ''' <param name="row">Set the number of row from [0-5] to pick a color</param>
                    ''' <param name="column">Set the number of column from [0-5] to pick a color</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Friend Shared Function getColor(ByVal row As Integer, ByVal column As Integer)
                        Dim colorValue As String = ""
                        If row > 5 Then row = 5
                        If column > 5 Then column = 5
                        Select Case row
                            Case 0
                                colorValue = "020606/181E1F/2F3435/444B4D/5B6364/757C7D"
                            Case 1
                                colorValue = "232626/363B3C/4A4E4F/5C6264/707778/878D8E"
                            Case 2
                                colorValue = "040709/171B1C/2B2E2F/3E4344/54595A/6A7171"
                            Case 3
                                colorValue = "242729/353839/46494A/575B5C/6A6E6F/7D8383"
                            Case 4
                                colorValue = "000000/151515/1D1D1D/343434/4A4A4A/636363"
                            Case 5
                                colorValue = "212121/333333/3A3A3A/4E4E4E/616161/777777"
                        End Select
                        Dim col() As String = colorValue.Split("/")
                        Return myColor.Share.Converter.StringToColor.getHTMLColor("#" + col(column))
                    End Function
                End Class

                ''' <summary>
                ''' It gets the gray color
                ''' </summary>
                ''' <remarks></remarks>
                Public Class Gray
                    ''' <summary>
                    ''' Get color Gray
                    ''' </summary>
                    ''' <param name="row">Set the number of row from [0-5] to pick a color</param>
                    ''' <param name="column">Set the number of column from [0-5] to pick a color</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Friend Shared Function getColor(ByVal row As Integer, ByVal column As Integer)
                        Dim colorValue As String = ""
                        If row > 5 Then row = 5
                        If column > 5 Then column = 5
                        Select Case row
                            Case 0
                                colorValue = "131211/2F2D2B/3F3C3A/504D49/625F5B/74716D"
                            Case 1
                                colorValue = "323130/4A4846/585553/676461/767470/868380"
                            Case 2
                                colorValue = "050505/161616/292827/3C3A39/4F4E4D/636363"
                            Case 3
                                colorValue = "252525/343434/454443/555353/666564/777777"
                            Case 4
                                colorValue = "000000/151515/1D1D1D/343434/4A4A4A/636261"
                            Case 5
                                colorValue = "212121/333333/3A3A3A/4E4E4E/616161/777777"
                        End Select
                        Dim col() As String = colorValue.Split("/")
                        Return myColor.Share.Converter.StringToColor.getHTMLColor("#" + col(column))
                    End Function
                End Class

                ''' <summary>
                ''' It gets the blue violete color
                ''' </summary>
                ''' <remarks></remarks>
                Public Class BlueViolete
                    ''' <summary>
                    ''' Get color Blue Violete
                    ''' </summary>
                    ''' <param name="row">Set the number of row from [0-5] to pick a color</param>
                    ''' <param name="column">Set the number of column from [0-5] to pick a color</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Friend Shared Function getColor(ByVal row As Integer, ByVal column As Integer)
                        Dim colorValue As String = ""
                        If row > 5 Then row = 5
                        If column > 5 Then column = 5
                        Select Case row
                            Case 0
                                colorValue = "000060/000075/1C008A/3103A9/4A17C1/6020E3"
                            Case 1
                                colorValue = "212175/212187/392199/4C24B4/6135C9/753DE7"
                            Case 2
                                colorValue = "0C002F/140044/270F5B/3A1D72/4D2C89/613C9F"
                            Case 3
                                colorValue = "2B214A/32215C/432E70/533A84/644798/7555AB"
                            Case 4
                                colorValue = "0A0015/150A2C/261641/362455/49336A/5B4381"
                            Case 5
                                colorValue = "2A2133/332A47/42345A/50406B/614D7D/705B91"
                        End Select
                        Dim col() As String = colorValue.Split("/")
                        Return myColor.Share.Converter.StringToColor.getHTMLColor("#" + col(column))
                    End Function
                End Class

                ''' <summary>
                ''' It gets the violete color
                ''' </summary>
                ''' <remarks></remarks>
                Public Class Violete
                    ''' <summary>
                    ''' Get color Violete
                    ''' </summary>
                    ''' <param name="row">Set the number of row from [0-5] to pick a color</param>
                    ''' <param name="column">Set the number of column from [0-5] to pick a color</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Friend Shared Function getColor(ByVal row As Integer, ByVal column As Integer)
                        Dim colorValue As String = ""
                        If row > 5 Then row = 5
                        If column > 5 Then column = 5
                        Select Case row
                            Case 0
                                colorValue = "240066/410082/5E009B/7C00B9/9A00D5/B500F0"
                            Case 1
                                colorValue = "40217A/5A2192/7321A8/8D21C2/A721DA/BF21F2"
                            Case 2
                                colorValue = "1E0039/330051/4E006A/6B0F8E/8928AE/A637D0"
                            Case 3
                                colorValue = "3B2153/4D2168/65217D/7E2E9D/9844B8/B251D6"
                            Case 4
                                colorValue = "15001E/290138/411454/5C2671/793D8F/924EAB"
                            Case 5
                                colorValue = "33213B/452252/5A326A/714283/8A569D/A065B6"
                        End Select
                        Dim col() As String = colorValue.Split("/")
                        Return myColor.Share.Converter.StringToColor.getHTMLColor("#" + col(column))
                    End Function
                End Class

                ''' <summary>
                ''' It gets the pink color
                ''' </summary>
                ''' <remarks></remarks>
                Public Class Pink
                    ''' <summary>
                    ''' Get color Pink
                    ''' </summary>
                    ''' <param name="row">Set the number of row from [0-5] to pick a color</param>
                    ''' <param name="column">Set the number of column from [0-5] to pick a color</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Friend Shared Function getColor(ByVal row As Integer, ByVal column As Integer)
                        Dim colorValue As String = ""
                        If row > 5 Then row = 5
                        If column > 5 Then column = 5
                        Select Case row
                            Case 0
                                colorValue = "60002E/7D0045/9B0059/BB0075/DB008E/FF13AC"
                            Case 1
                                colorValue = "752149/8E215D/A8216E/C42187/E0219D/FF32B7"
                            Case 2
                                colorValue = "460025/62003A/7D0052/A61A6D/CE2F87/EC4A9F"
                            Case 3
                                colorValue = "5E2141/762153/8E2168/B23880/D44A97/EE61AB"
                            Case 4
                                colorValue = "35001F/550635/731E4D/933365/B5467D/D06098"
                            Case 5
                                colorValue = "4F213C/6B264F/853B64/A14D79/BF5E8E/D675A5"
                        End Select
                        Dim col() As String = colorValue.Split("/")
                        Return myColor.Share.Converter.StringToColor.getHTMLColor("#" + col(column))
                    End Function
                End Class

                ''' <summary>
                ''' It gets the hot pink color
                ''' </summary>
                ''' <remarks></remarks>
                Public Class HotPink
                    ''' <summary>
                    ''' Get color Hot Pink
                    ''' </summary>
                    ''' <param name="row">Set the number of row from [0-5] to pick a color</param>
                    ''' <param name="column">Set the number of column from [0-5] to pick a color</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Friend Shared Function getColor(ByVal row As Integer, ByVal column As Integer)
                        Dim colorValue As String = ""
                        If row > 5 Then row = 5
                        If column > 5 Then column = 5
                        Select Case row
                            Case 0
                                colorValue = "71001F/8E0032/AE0046/CE005C/F00078/FF2F92"
                            Case 1
                                colorValue = "83213C/9D214D/B8215E/D42171/F22189/FF4AA0"
                            Case 2
                                colorValue = "51001F/6C0031/951548/B52F5E/DC4576/F85F8C"
                            Case 3
                                colorValue = "68213C/7F214C/A33360/BF4A73/E15D88/F9749B"
                            Case 4
                                colorValue = "40061C/601C32/7C3047/9A455C/BD5B76/D6768E"
                            Case 5
                                colorValue = "592639/75394D/8D4B5F/A75D71/C67088/DB889D"
                        End Select
                        Dim col() As String = colorValue.Split("/")
                        Return myColor.Share.Converter.StringToColor.getHTMLColor("#" + col(column))
                    End Function
                End Class

                ''' <summary>
                ''' It gets the red color
                ''' </summary>
                ''' <remarks></remarks>
                Public Class Red
                    ''' <summary>
                    ''' Get color Red
                    ''' </summary>
                    ''' <param name="row">Set the number of row from [0-5] to pick a color</param>
                    ''' <param name="column">Set the number of column from [0-5] to pick a color</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Friend Shared Function getColor(ByVal row As Integer, ByVal column As Integer)
                        Dim colorValue As String = ""
                        If row > 5 Then row = 5
                        If column > 5 Then column = 5
                        Select Case row
                            Case 0
                                colorValue = "600011/7D0016/9D001C/BF0022/E10022/FF1E29"
                            Case 1
                                colorValue = "752130/8E2134/AA2139/C7213F/E5213F/FF3B45"
                            Case 2
                                colorValue = "460018/620020/80002D/AB1D32/D63034/F34E49"
                            Case 3
                                colorValue = "5E2136/76213D/902148/B63A4D/DB4B4E/F56561"
                            Case 4
                                colorValue = "350016/560A21/761F2E/97353A/BD4842/D8615A"
                            Case 5
                                colorValue = "4F2134/6C2A3E/883C49/A44F53/C6605A/DD756F"
                        End Select
                        Dim col() As String = colorValue.Split("/")
                        Return myColor.Share.Converter.StringToColor.getHTMLColor("#" + col(column))
                    End Function
                End Class

                ''' <summary>
                ''' It gets the scarlet color
                ''' </summary>
                ''' <remarks></remarks>
                Public Class Scarlet
                    ''' <summary>
                    ''' Get color Scarlet
                    ''' </summary>
                    ''' <param name="row">Set the number of row from [0-5] to pick a color</param>
                    ''' <param name="column">Set the number of column from [0-5] to pick a color</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Friend Shared Function getColor(ByVal row As Integer, ByVal column As Integer)
                        Dim colorValue As String = ""
                        If row > 5 Then row = 5
                        If column > 5 Then column = 5
                        Select Case row
                            Case 0
                                colorValue = "400005/5E0002/7D0000/9D0000/BD0000/DF0000"
                            Case 1
                                colorValue = "592125/732123/8E2121/AA2121/C62121/E32121"
                            Case 2
                                colorValue = "280002/420000/600000/7D1000/A6290F/C84322"
                            Case 3
                                colorValue = "442123/5A2121/752121/8E2F21/B2452E/CF5B3F"
                            Case 4
                                colorValue = "1A0001/310100/501405/6D2916/8D4029/AE573E"
                            Case 5
                                colorValue = "382122/4C2221/673225/804534/9C5945/B86D57"
                        End Select
                        Dim col() As String = colorValue.Split("/")
                        Return myColor.Share.Converter.StringToColor.getHTMLColor("#" + col(column))
                    End Function
                End Class

                ''' <summary>
                ''' It gets the orange color
                ''' </summary>
                ''' <remarks></remarks>
                Public Class Orange
                    ''' <summary>
                    ''' Get color Orange
                    ''' </summary>
                    ''' <param name="row">Set the number of row from [0-5] to pick a color</param>
                    ''' <param name="column">Set the number of column from [0-5] to pick a color</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Friend Shared Function getColor(ByVal row As Integer, ByVal column As Integer)
                        Dim colorValue As String = ""
                        If row > 5 Then row = 5
                        If column > 5 Then column = 5
                        Select Case row
                            Case 0
                                colorValue = "570002/770000/950000/B70000/D71B00/F93F00 "
                            Case 1
                                colorValue = "6D2123/892121/A32121/C02121/DC3821/FA5821"
                            Case 2
                                colorValue = "420000/5E0000/791500/A32F07/C5451B/EF5927"
                            Case 3
                                colorValue = "5A2121/732121/8A3321/AF4A27/CD5D38/F16E43"
                            Case 4
                                colorValue = "2D0400/4D1804/6B2C16/8A4128/A95A3D/CC714F"
                            Case 5
                                colorValue = "482421/643624/7E4734/995A44/B46F56/D38366"
                        End Select
                        Dim col() As String = colorValue.Split("/")
                        Return myColor.Share.Converter.StringToColor.getHTMLColor("#" + col(column))
                    End Function
                End Class

                ''' <summary>
                ''' It gets the orange yellow color
                ''' </summary>
                ''' <remarks></remarks>
                Public Class OrangeYellow
                    ''' <summary>
                    ''' Get color Orange Yellow
                    ''' </summary>
                    ''' <param name="row">Set the number of row from [0-5] to pick a color</param>
                    ''' <param name="column">Set the number of column from [0-5] to pick a color</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Friend Shared Function getColor(ByVal row As Integer, ByVal column As Integer)
                        Dim colorValue As String = ""
                        If row > 5 Then row = 5
                        If column > 5 Then column = 5
                        Select Case row
                            Case 0
                                colorValue = "660000/840000/A42500/C44000/E35B00/FF740D"
                            Case 1
                                colorValue = "7A2121/942121/B04121/CC5921/E77021/FF862C"
                            Case 2
                                colorValue = "511000/6C2600/933D09/B5561E/DC6C29/FB8444"
                            Case 3
                                colorValue = "682F21/7F4221/A15629/BF6C3B/E17F45/FC945C"
                            Case 4
                                colorValue = "441D02/643115/834727/A0603D/C4764D/DF9268"
                            Case 5
                                colorValue = "5C3A23/784C33/935F43/AC7556/CC8864/E3A07C"
                        End Select
                        Dim col() As String = colorValue.Split("/")
                        Return myColor.Share.Converter.StringToColor.getHTMLColor("#" + col(column))
                    End Function
                End Class

                ''' <summary>
                ''' It gets the yellow orange color
                ''' </summary>
                ''' <remarks></remarks>
                Public Class YellowOrange
                    ''' <summary>
                    ''' Get color Yellow Orange
                    ''' </summary>
                    ''' <param name="row">Set the number of row from [0-5] to pick a color</param>
                    ''' <param name="column">Set the number of column from [0-5] to pick a color</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Friend Shared Function getColor(ByVal row As Integer, ByVal column As Integer)
                        Dim colorValue As String = ""
                        If row > 5 Then row = 5
                        If column > 5 Then column = 5
                        Select Case row
                            Case 0
                                colorValue = "622C00/804300/9D5A00/BD7600/DD8F00/FFAF09"
                            Case 1
                                colorValue = "764721/905B21/AA6F21/C68821/E19D21/FFB929"
                            Case 2
                                colorValue = "3E1F00/593300/754900/9A640A/BC7E21/E39C31"
                            Case 3
                                colorValue = "573C21/6E4D21/876121/A7782A/C58F3E/E7A94C"
                            Case 4
                                colorValue = "372000/563805/765118/95682D/B58340/D59C57"
                            Case 5
                                colorValue = "513D21/6C5225/886836/A37C48/BF9359/DAA96D"
                        End Select
                        Dim col() As String = colorValue.Split("/")
                        Return myColor.Share.Converter.StringToColor.getHTMLColor("#" + col(column))
                    End Function
                End Class

                ''' <summary>
                ''' It gets the yellow color
                ''' </summary>
                ''' <remarks></remarks>
                Public Class Yellow
                    ''' <summary>
                    ''' Get color Yellow
                    ''' </summary>
                    ''' <param name="row">Set the number of row from [0-5] to pick a color</param>
                    ''' <param name="column">Set the number of column from [0-5] to pick a color</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Friend Shared Function getColor(ByVal row As Integer, ByVal column As Integer)
                        Dim colorValue As String = ""
                        If row > 5 Then row = 5
                        If column > 5 Then column = 5
                        Select Case row
                            Case 0
                                colorValue = "573400/734A00/916200/AE7A00/CE9600/F0B500"
                            Case 1
                                colorValue = "6D4E21/856121/9F7621/B88B21/D4A421/F2BF21"
                            Case 2
                                colorValue = "352000/513600/6A4E00/916900/B0841C/DAA22C"
                            Case 3
                                colorValue = "4F3D21/685021/7D6521/9F7C21/BA9439/DFAE47"
                            Case 4
                                colorValue = "332200/503A01/705516/8E6D2B/AC8940/CEA353"
                            Case 5
                                colorValue = "4D3F21/675322/836B34/9D8046/B79859/D4AF69"
                        End Select
                        Dim col() As String = colorValue.Split("/")
                        Return myColor.Share.Converter.StringToColor.getHTMLColor("#" + col(column))
                    End Function
                End Class

                ''' <summary>
                ''' It gets the yellow green color
                ''' </summary>
                ''' <remarks></remarks>
                Public Class YellowGreen
                    ''' <summary>
                    ''' Get color Yellow Green
                    ''' </summary>
                    ''' <param name="row">Set the number of row from [0-5] to pick a color</param>
                    ''' <param name="column">Set the number of column from [0-5] to pick a color</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Friend Shared Function getColor(ByVal row As Integer, ByVal column As Integer)
                        Dim colorValue As String = ""
                        If row > 5 Then row = 5
                        If column > 5 Then column = 5
                        Select Case row
                            Case 0
                                colorValue = "001A00/002D00/004600/1B6000/397900/549300"
                            Case 1
                                colorValue = "213821/214821/215E21/387521/538A21/6AA121"
                            Case 2
                                colorValue = "001300/102800/264000/3D5700/5E7B0F/779926"
                            Case 3
                                colorValue = "213221/2F4421/425921/566D21/738C2E/89A642"
                            Case 4
                                colorValue = "0A1100/1E2800/354413/506026/6A7C3A/849850"
                            Case 5
                                colorValue = "2A3021/3B4421/4F5C32/677542/7D8D53/94A567"
                        End Select
                        Dim col() As String = colorValue.Split("/")
                        Return myColor.Share.Converter.StringToColor.getHTMLColor("#" + col(column))
                    End Function
                End Class

                ''' <summary>
                ''' It gets the green color
                ''' </summary>
                ''' <remarks></remarks>
                Public Class Green
                    ''' <summary>
                    ''' Get color Green
                    ''' </summary>
                    ''' <param name="row">Set the number of row from [0-5] to pick a color</param>
                    ''' <param name="column">Set the number of column from [0-5] to pick a color</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Friend Shared Function getColor(ByVal row As Integer, ByVal column As Integer)
                        Dim colorValue As String = ""
                        If row > 5 Then row = 5
                        If column > 5 Then column = 5
                        Select Case row
                            Case 0
                                colorValue = "003100/004800/006400/007D00/2B9900/4DB500"
                            Case 1
                                colorValue = "214C21/216021/217821/218E21/46A621/64BF21"
                            Case 2
                                colorValue = "002B00/174200/305B00/4B8011/669D28/82C13C"
                            Case 3
                                colorValue = "214621/355A21/4B7021/629030/7AAA44/92C955"
                            Case 4
                                colorValue = "172C01/2D4613/466327/60803C/789B51/93BA67"
                            Case 5
                                colorValue = "354722/485E32/5E7743/759055/89A868/A1C37B"
                        End Select
                        Dim col() As String = colorValue.Split("/")
                        Return myColor.Share.Converter.StringToColor.getHTMLColor("#" + col(column))
                    End Function
                End Class

                ''' <summary>
                ''' It gets the blue green color
                ''' </summary>
                ''' <remarks></remarks>
                Public Class BlueGreen
                    ''' <summary>
                    ''' Get color Blue Green
                    ''' </summary>
                    ''' <param name="row">Set the number of row from [0-5] to pick a color</param>
                    ''' <param name="column">Set the number of column from [0-5] to pick a color</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Friend Shared Function getColor(ByVal row As Integer, ByVal column As Integer)
                        Dim colorValue As String = ""
                        If row > 5 Then row = 5
                        If column > 5 Then column = 5
                        Select Case row
                            Case 0
                                colorValue = "001A00/003312/004A25/00663A/008251/009B55"
                            Case 1
                                colorValue = "213821/214D31/216141/217A53/219268/21A86B"
                            Case 2
                                colorValue = "001709/002D1A/00442E/005E44/188361/35A271"
                            Case 3
                                colorValue = "213529/214838/215C49/21735C/369375/4FAE83"
                            Case 4
                                colorValue = "00130C/052E21/1A4838/2E6551/448269/58A07A"
                            Case 5
                                colorValue = "21322B/25493E/386052/497968/5C927C/6EAC8B"
                        End Select
                        Dim col() As String = colorValue.Split("/")
                        Return myColor.Share.Converter.StringToColor.getHTMLColor("#" + col(column))
                    End Function
                End Class

                ''' <summary>
                ''' It gets the sky blue color
                ''' </summary>
                ''' <remarks></remarks>
                Public Class SkyBlue
                    ''' <summary>
                    ''' Get color Sky Blue
                    ''' </summary>
                    ''' <param name="row">Set the number of row from [0-5] to pick a color</param>
                    ''' <param name="column">Set the number of column from [0-5] to pick a color</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Friend Shared Function getColor(ByVal row As Integer, ByVal column As Integer)
                        Dim colorValue As String = ""
                        If row > 5 Then row = 5
                        If column > 5 Then column = 5
                        Select Case row
                            Case 0
                                colorValue = "001D20/003135/00484D/006466/007C80/009B9B"
                            Case 1
                                colorValue = "213A3D/214C4F/216064/21787A/218D90/21A8A8"
                            Case 2
                                colorValue = "001617/002C2D/004444/005B5B/1A8282/359F9F"
                            Case 3
                                colorValue = "213435/214748/215C5C/217070/389292/4FABAB"
                            Case 4
                                colorValue = "001313/052E2D/1B4747/2F6463/458180/5A9E9C"
                            Case 5
                                colorValue = "213232/254948/385F5F/4A7877/5D9190/6FABA9"
                        End Select
                        Dim col() As String = colorValue.Split("/")
                        Return myColor.Share.Converter.StringToColor.getHTMLColor("#" + col(column))
                    End Function
                End Class

                ''' <summary>
                ''' It gets the cyan color
                ''' </summary>
                ''' <remarks></remarks>
                Public Class Cyan
                    ''' <summary>
                    ''' Get color Cyan
                    ''' </summary>
                    ''' <param name="row">Set the number of row from [0-5] to pick a color</param>
                    ''' <param name="column">Set the number of column from [0-5] to pick a color</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Friend Shared Function getColor(ByVal row As Integer, ByVal column As Integer)
                        Dim colorValue As String = ""
                        If row > 5 Then row = 5
                        If column > 5 Then column = 5
                        Select Case row
                            Case 0
                                colorValue = "001F59/003473/00498C/0061A8/007BC6/0093E1"
                            Case 1
                                colorValue = "213C6E/214E85/21619B/2175B3/218CCD/21A1E5"
                            Case 2
                                colorValue = "001A39/002E53/00436A/135F91/3176AE/458ED1"
                            Case 3
                                colorValue = "213853/214969/215B7D/32749F/4C88B8/5D9DD7"
                            Case 4
                                colorValue = "001626/0C2C45/204260/355B7D/4D749B/628BB9"
                            Case 5
                                colorValue = "213442/2B475D/3D5A75/4F708E/6486A8/769AC2"
                        End Select
                        Dim col() As String = colorValue.Split("/")
                        Return myColor.Share.Converter.StringToColor.getHTMLColor("#" + col(column))
                    End Function
                End Class

                ''' <summary>
                ''' It gets the blue color
                ''' </summary>
                ''' <remarks></remarks>
                Public Class Blue
                    ''' <summary>
                    ''' Get color Blue
                    ''' </summary>
                    ''' <param name="row">Set the number of row from [0-5] to pick a color</param>
                    ''' <param name="column">Set the number of column from [0-5] to pick a color</param>
                    ''' <returns></returns>
                    ''' <remarks></remarks>
                    Friend Shared Function getColor(ByVal row As Integer, ByVal column As Integer)
                        Dim colorValue As String = ""
                        If row > 5 Then row = 5
                        If column > 5 Then column = 5
                        Select Case row
                            Case 0
                                colorValue = "00006A/001786/0028A2/003EBD/0052DB/0066F0"
                            Case 1
                                colorValue = "21217D/213596/2144AE/2157C6/2168E0/217AF2"
                            Case 2
                                colorValue = "00003C/001555/00286C/173993/334DB3/435BCF"
                            Case 3
                                colorValue = "212155/21336B/21447F/3553A1/4D64BD/5B70D5"
                            Case 4
                                colorValue = "000020/04133C/1A2657/2E3874/454D8F/535BAA"
                            Case 5
                                colorValue = "21213D/243255/38426D/495286/5D649D/6970B5"
                        End Select
                        Dim col() As String = colorValue.Split("/")
                        Return myColor.Share.Converter.StringToColor.getHTMLColor("#" + col(column))
                    End Function
                End Class

            End Namespace

        End Namespace

        Namespace Converter

            ''' <summary>
            ''' It converts the string value into color value
            ''' </summary>
            ''' <remarks></remarks>
            Public Class StringToColor

                ''' <summary>
                ''' It gets HTML color code and converts into system color
                ''' </summary>
                ''' <param name="values">Set the HTML Color code to convert it. It must be #[000000] format</param>
                ''' <returns>Get Converted System Color</returns>
                ''' <remarks></remarks>
                Public Shared Function getHTMLColor(ByVal values As String) As Color
                    If Not values Is Nothing Or values <> "" Then
                        If Not values.Contains("#") Then values = "#" + values
                        Return ColorTranslator.FromHtml(values)
                    Else
                        Return Color.Empty
                    End If
                End Function

                ''' <summary>
                ''' It gets an RGB color string and converts into system color
                ''' </summary>
                ''' <param name="values">Set the RBB string color to convert it</param>
                ''' <returns>Get Converted System Color</returns>
                ''' <remarks></remarks>
                Public Shared Function getRGBColor(ByVal values As String) As Color
                    If values Is Nothing Or values <> "" Then
                        Return Color.FromArgb(CInt(values))
                    Else
                        Return Color.Empty
                    End If
                End Function

            End Class

            ''' <summary>
            ''' It converts the color value into string color
            ''' </summary>
            ''' <remarks></remarks>
            Public Class ColorToString

                ''' <summary>
                ''' It gets the HTML color code
                ''' </summary>
                ''' <param name="color">Set the system color to convert it</param>
                ''' <returns>Get the string color</returns>
                ''' <remarks></remarks>
                Public Shared Function getHTMLColor(ByVal color As Color) As String
                    If color <> Drawing.Color.Transparent Then
                        Return System.Drawing.ColorTranslator.ToHtml(color)
                    End If
                    Return ""
                End Function

            End Class

        End Namespace

        Namespace Tools

            Public Class Brightness

                Public Shared Function Apply(ByVal color As Color, Optional ByVal value As Double = 0.0)
                    Return ControlPaint.Light(color, value)
                End Function

            End Class

            Public Class Darkness

                Public Shared Function Apply(ByVal color As Color, Optional ByVal value As Double = 0.0)
                    Return ControlPaint.Dark(color, value)
                End Function

            End Class

        End Namespace

    End Namespace

End Namespace


