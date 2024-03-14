Namespace myIcons

    Namespace Share

        ''' <summary>
        ''' This class is used to get the listed type of icons in an object
        ''' </summary>
        ''' <remarks></remarks>
        Public Class General

            ''' <summary>
            ''' List of Icons
            ''' </summary>
            ''' <remarks></remarks>
            Public Enum IconLibraryTypes
                NotSet
                JqueryMobile
                Jquery
                Windows8
            End Enum

        End Class

        ''' <summary>
        ''' It used to load all icons in the jquery mobile for the object
        ''' </summary>
        ''' <remarks></remarks>
        Public Class JqueryMobile

            ''' <summary>
            ''' Type of icon to be displayed during MouseLeave and MouseMove event
            ''' </summary>
            ''' <remarks></remarks>
            Public Enum JqueryMobileImageSelect
                Normal
                Hover
            End Enum

            ''' <summary>
            ''' List of icons which is found in the Jquery Mobile
            ''' </summary>
            ''' <remarks></remarks>
            Public Enum JqueryMobileIconTypes
                NotSet
                left_arrow
                right_arrow
                up_arrow
                down_arrow
                close
                plus
                minus
                check
                settings
                arrow_return_full_e
                arrow_return_e
                arrow_return_w
                menu
                star
                alert
                exclamation
                home
                search
            End Enum

            ''' <summary>
            ''' List of icons that reflects the color
            ''' </summary>
            ''' <remarks></remarks>
            Public Enum JqueryMobileIconColor
                NotSet
                black
                blue
                gray
            End Enum

            Private Shared Function get_Tag_Icons_JqueryMobile(ByVal type As JqueryMobileIconTypes, Optional ByVal color As JqueryMobileIconColor = JqueryMobileIconColor.gray)
                Select Case type
                    Case JqueryMobileIconTypes.left_arrow
                        Select Case color
                            Case JqueryMobileIconColor.black
                                Return "7,1,24,24"
                            Case JqueryMobileIconColor.blue
                                Return "7,57,24,23"
                            Case Else
                                Return "8,86,22,22"
                        End Select
                    Case JqueryMobileIconTypes.right_arrow
                        Select Case color
                            Case JqueryMobileIconColor.black
                                Return "34,1,24,24"
                            Case JqueryMobileIconColor.blue
                                Return "35,58,24,23"
                            Case Else
                                Return "34,112,24,23"
                        End Select
                    Case JqueryMobileIconTypes.up_arrow
                        Select Case color
                            Case JqueryMobileIconColor.black
                                Return "62,1,24,24"
                            Case JqueryMobileIconColor.blue
                                Return "62,58,24,23"
                            Case Else
                                Return "63,113,24,23"
                        End Select
                    Case JqueryMobileIconTypes.down_arrow
                        Select Case color
                            Case JqueryMobileIconColor.black
                                Return "90,1,24,24"
                            Case JqueryMobileIconColor.blue
                                Return "90,58,24,24"
                            Case Else
                                Return "91,113,24,23"
                        End Select
                    Case JqueryMobileIconTypes.close
                        Select Case color
                            Case JqueryMobileIconColor.black
                                Return "119,1,24,24"
                            Case JqueryMobileIconColor.blue
                                Return "118,58,24,23"
                            Case Else
                                Return "119,113,24,23"
                        End Select
                    Case JqueryMobileIconTypes.plus
                        Select Case color
                            Case JqueryMobileIconColor.black
                                Return "147,1,24,24"
                            Case JqueryMobileIconColor.blue
                                Return "146,58,24,24"
                            Case Else
                                Return "147,113,24,23"
                        End Select
                    Case JqueryMobileIconTypes.minus
                        Select Case color
                            Case JqueryMobileIconColor.black
                                Return "175,1,24,24"
                            Case JqueryMobileIconColor.blue
                                Return "175,58,24,23"
                            Case Else
                                Return "175,113,24,23"
                        End Select
                    Case JqueryMobileIconTypes.check
                        Select Case color
                            Case JqueryMobileIconColor.black
                                Return "203,1,24,24"
                            Case JqueryMobileIconColor.blue
                                Return "202,58,24,24"
                            Case Else
                                Return "202,113,24,23"
                        End Select
                    Case JqueryMobileIconTypes.settings
                        Select Case color
                            Case JqueryMobileIconColor.black
                                Return "231,1,24,24"
                            Case JqueryMobileIconColor.blue
                                Return "229,58,24,23"
                            Case Else
                                Return "232,113,24,23"
                        End Select
                    Case JqueryMobileIconTypes.arrow_return_full_e
                        Select Case color
                            Case JqueryMobileIconColor.black
                                Return "259,1,24,24"
                            Case JqueryMobileIconColor.blue
                                Return "259,58,24,23"
                            Case Else
                                Return "259,113,24,23"
                        End Select
                    Case JqueryMobileIconTypes.arrow_return_e
                        Select Case color
                            Case JqueryMobileIconColor.black
                                Return "287,1,24,24"
                            Case JqueryMobileIconColor.blue
                                Return "287,58,24,23"
                            Case Else
                                Return "287,113,24,23"
                        End Select
                    Case JqueryMobileIconTypes.arrow_return_w
                        Select Case color
                            Case JqueryMobileIconColor.black
                                Return "315,1,24,24"
                            Case JqueryMobileIconColor.blue
                                Return "315,58,24,23"
                            Case Else
                                Return "314,113,24,22"
                        End Select
                    Case JqueryMobileIconTypes.menu
                        Select Case color
                            Case JqueryMobileIconColor.black
                                Return "343,1,24,24"
                            Case JqueryMobileIconColor.blue
                                Return "343,58,24,23"
                            Case Else
                                Return "343,113,24,23"
                        End Select
                    Case JqueryMobileIconTypes.star
                        Select Case color
                            Case JqueryMobileIconColor.black
                                Return "371,1,24,24"
                            Case JqueryMobileIconColor.blue
                                Return "371,58,24,24"
                            Case Else
                                Return "371,113,24,23"
                        End Select
                    Case JqueryMobileIconTypes.alert
                        Select Case color
                            Case JqueryMobileIconColor.black
                                Return "399,1,24,24"
                            Case JqueryMobileIconColor.blue
                                Return "399,58,24,23"
                            Case Else
                                Return "398,113,24,23"
                        End Select
                    Case JqueryMobileIconTypes.exclamation
                        Select Case color
                            Case JqueryMobileIconColor.black
                                Return "428,1,24,24"
                            Case JqueryMobileIconColor.blue
                                Return "427,58,24,23"
                            Case Else
                                Return "427,113,24,23"
                        End Select
                    Case JqueryMobileIconTypes.home
                        Select Case color
                            Case JqueryMobileIconColor.black
                                Return "455,1,24,24"
                            Case JqueryMobileIconColor.blue
                                Return "455,58,23,24"
                            Case Else
                                Return "455,113,24,23"
                        End Select
                    Case JqueryMobileIconTypes.search
                        Select Case color
                            Case JqueryMobileIconColor.black
                                Return "484,1,24,23"
                            Case JqueryMobileIconColor.blue
                                Return "483,58,24,23"
                            Case Else
                                Return "484,86,22,22"
                        End Select
                    Case Else
                        Return "0,0,0,0"
                End Select
            End Function

            ''' <summary>
            ''' It invokes the function to get the jquery mobile icon based on the specified properties loaded
            ''' </summary>
            ''' <param name="type">Set the type of jquery mobile icon</param>
            ''' <param name="img_width">Specifies the width of the icon</param>
            ''' <param name="img_height">Specifies the height of the icon</param>
            ''' <param name="color">Specifies the jquery mobile icon color</param>
            ''' <returns>Get the selected jquery mobile icon</returns>
            ''' <remarks></remarks>
            Public Shared Function GetJqueryMobileIcon(ByVal type As JqueryMobileIconTypes, ByVal img_width As Integer, ByVal img_height As Integer, Optional ByVal color As JqueryMobileIconColor = JqueryMobileIconColor.gray) As Bitmap
                Dim bmp As Bitmap = My.Resources.JQMobileButton2
                Dim rec() As String = get_Tag_Icons_JqueryMobile(type, color).Split(",")
                Dim cropX As Integer = Val(rec(0))
                Dim cropY As Integer = Val(rec(1))
                Dim cropWidth As Integer = Val(rec(2))
                Dim cropHeight As Integer = Val(rec(3))
                Dim rect As New Rectangle(cropX, cropY, cropWidth, cropHeight)
                Try
                    Dim cropped As Bitmap = bmp.Clone(rect, bmp.PixelFormat)
                    Return myImage.Share.Tools.resizeImage(cropped, img_width, img_height)
                Catch ex As Exception
                    myExceptionHandler.OnThreadException(ex, "There was a problem of getting icons. [MyPicture[Get_Icons]]. ")
                    Return Nothing
                End Try
            End Function

        End Class

        ''' <summary>
        ''' Ir used to load all icons in the Jquery for the object
        ''' </summary>
        ''' <remarks></remarks>
        Public Class Jquery

            ''' <summary>
            ''' List of Jquery icon colors
            ''' </summary>
            ''' <remarks></remarks>
            Public Enum JqueryIconColor
                NotSet
                White
                Black
                Red
            End Enum

            ''' <summary>
            ''' List of Jquery Icons
            ''' </summary>
            ''' <remarks></remarks>
            Public Enum JqueryIconTypes
                NotSet
                carrat_1_n
                carrat_1_ne
                carrat_1_e
                carrat_1_se
                carrat_1_s
                carrat_1_sw
                carrat_1_w
                carrat_1_nw
                carrat_2_n_s
                carrat_2_e_w
                triangle_1_n
                triangle_1_ne
                triangle_1_e
                triangle_1_se
                triangle_1_s
                triangle_1_sw
                triangle_1_w
                triangle_1_nw
                arrow_1_n
                arrow_1_ne
                arrow_1_e
                arrow_1_se
                arrow_1_s
                arrow_1_sw
                arrow_1_w
                arrow_1_nw
                arrow_2_n_s
                arrow_2_ne_sw
                arrow_2_e_w
                arrow_2_se_nw
                arrow_stop_1_n
                arrow_stop_1_e
                arrow_stop_1_s
                arrow_stop_1_w
                arrowthick_1_n
                arrowthick_1_ne
                arrowthick_1_e
                arrowthick_1_se
                arrowthick_1_s
                arrowthick_1_sw
                arrowthick_1_w
                arrowthick_1_nw
                arrowthick_2_n_s
                arrowthick_2_ne_sw
                arrowthick_2_e_w
                arrowthick_2_se_nw
                arrowthick_stop_1_n
                arrowthick_stop_1_e
                arrowthick_stop_1_s
                arrowthick_stop_1_w
                arrowreturnthick_1_w
                arrowreturnthick_1_n
                arrowreturnthick_1_e
                arrowreturnthick_1_s
                arrowreturn_1_w
                arrowreturn_1_n
                arrowreturn_1_e
                arrowreturn_1_s
                arrowrefrsh_1_w
                arrowrefrsh_1_n
                arrowrefrsh_1_e
                arrowrefrsh_1_s
                arrow_4
                arrow_4_diag
                extlink
                newwin
                refresh
                shaffle
                transfer_e_w
                folder_collapsed
                folder_open
                document
                document_b
                note
                closed
                open
                suitcase
                comment
                person
                print
                trash
                locked
                unlocked
                bookmark
                tag
                home
                flag
                calculator
                cart
                pencil
                clock
                disk
                calendar
                zoomin
                zoomout
                search
                wrench
                gear
                heart
                star
                link
                cancel
                plus
                plusthick
                minus
                minusthick
                close
                closethick
                key
                lightbulb
                scissors
                clipboard
                copy
                contact
                image
                video
                scroll
                alert
                info
                notice
                help
                check
                bullet
                radio_off
                radio_on
                unpin
                pin
                play
                pause
                seek_next
                seek_prev
                seek_end
                seek_first
                stop_
                eject
                volume_off
                volume_on
                power
                signal_diag
                signal
                battery_0
                battery_1
                battery_2
                battery_3
                circle_plus
                circle_minus
                circle_close
                circle_triangle_e
                circle_triangle_s
                circle_triangle_w
                circle_triangle_n
                circle_arrow_e
                circle_arrow_s
                circle_arrow_w
                circle_arrow_n
                circle_zoomin
                circle_zoomout
                circle_check
                circle_small_plus
                circle_small_minus
                circle_small_close
                square_small_plus
                square_small_minus
                square_small_close
                grip_dotted_vertical
                grip_dotted_horizontal
                grip_solid_vertical
                grip_solid_horizontal
                grip_small_diagonal_se
                grip_diagonal_se
            End Enum

            Private Shared Function get_Tag_Icons_Jquery(ByVal type As String) As String
                Dim S As String = ""
                If type Is Nothing Then Return "0,0,0,0"
                If Trim(type) = "" Then Return "0,0,0,0"
                '0=x-position
                '1=y-position
                '2=width of images
                '3=height of image
                Select Case type
                    Case "ui-icon-carat-1-n"
                        S = "3,3,10,10"
                    Case "ui-icon-carat-1-ne"
                        S = "18,3,10,10"
                    Case "ui-icon-carat-1-e"
                        S = "35,3,10,10"
                    Case "ui-icon-carat-1-se"
                        S = "50,3,10,10"
                    Case "ui-icon-carat-1-s"
                        S = "67,2,10,10"
                    Case "ui-icon-carat-1-sw"
                        S = "83,2,10,10"
                    Case "ui-icon-carat-1-nw"
                        S = "115,2,10,10"
                    Case "ui-icon-carat-1-w"
                        S = "99,2,10,10"
                    Case "ui-icon-arrow-1-w"
                        S = "99,2,10,10"
                    Case "ui-icon-arrow-1-nw"
                        S = "115,2,10,10"
                    Case "ui-icon-carrat-2-n-s"
                        S = "131,2,10,12"
                    Case "ui-icon-carrat-2-e-w"
                        S = "147,3,10,10"

                    Case "ui-icon-triangle-1-n"
                        S = "2,18,10,10"
                    Case "ui-icon-triangle-1-ne"
                        S = "19,18,10,10"
                    Case "ui-icon-triangle-1-e"
                        S = "35,19,10,10"
                    Case "ui-icon-triangle-1-se"
                        S = "50,18,10,10"
                    Case "ui-icon-triangle-1-s"
                        S = "66,18,10,10"
                    Case "ui-icon-triangle-1-sw"
                        S = "83,18,10,10"
                    Case "ui-icon-triangle-1-w"
                        S = "99,18,10,10"
                    Case "ui-icon-triangle-1-nw"
                        S = "115,18,10,10"

                    Case "ui-icon-arrow-1-n"
                        S = "2,35,10,10"
                    Case "ui-icon-arrow-1-ne"
                        S = "18,35,10,10"
                    Case "ui-icon-arrow-1-e"
                        S = "34,35,10,10"
                    Case "ui-icon-arrow-1-se"
                        S = "50,35,10,10"
                    Case "ui-icon-arrow-1-s"
                        S = "67,35,10,10"
                    Case "ui-icon-arrow-1-sw"
                        S = "83,35,10,10"
                    Case "ui-icon-arrow-1-w"
                        S = "99,35,10,10"
                    Case "ui-icon-arrow-1-nw"
                        S = "115,35,10,10"
                    Case "ui-icon-arrow-2-n-s"
                        S = "131,35,10,10"
                    Case "ui-icon-arrow-2-ne-sw"
                        S = "147,35,10,10"
                    Case "ui-icon-arrow-2-e-w"
                        S = "163,35,10,10"
                    Case "ui-icon-arrow-2-se-nw"
                        S = "179,35,10,10"
                    Case "ui-icon-arrow-stop-1-n"
                        S = "195,34,10,10"
                    Case "ui-icon-arrow-stop-1-e"
                        S = "211,35,10,10"
                    Case "ui-icon-arrow-stop-1-s"
                        S = "227,35,10,10"
                    Case "ui-icon-arrow-stop-1-w"
                        S = "243,35,10,10"

                    Case "ui-icon-arrowthick-1-n"
                        S = "2,50,10,10"
                    Case "ui-icon-arrowthick-1-ne"
                        S = "19,50,10,10"
                    Case "ui-icon-arrowthick-1-e"
                        S = "35,51,10,10"
                    Case "ui-icon-arrowthick-1-se"
                        S = "49,51,10,10"
                    Case "ui-icon-arrowthick-1-s"
                        S = "65,51,10,10"
                    Case "ui-icon-arrowthick-1-sw"
                        S = "83,51,10,10"
                    Case "ui-icon-arrowthick-1-w"
                        S = "99,51,10,10"
                    Case "ui-icon-arrowthick-1-nw"
                        S = "115,51,10,10"
                    Case "ui-icon-arrowthick-2-n-s"
                        S = "131,51,10,10"
                    Case "ui-icon-arrowthick-2-ne-sw"
                        S = "146,51,10,10"
                    Case "ui-icon-arrowthick-2-e-w"
                        S = "163,51,10,10"
                    Case "ui-icon-arrowthick-2-se-nw"
                        S = "178,51,10,10"
                    Case "ui-icon-arrowthickstop-1-n"
                        S = "195,51,10,10"
                    Case "ui-icon-arrowthickstop-1-e"
                        S = "211,50,10,10"
                    Case "ui-icon-arrowthickstop-1-s"
                        S = "226,51,10,10"
                    Case "ui-icon-arrowthickstop-1-w"
                        S = "243,50,10,10"


                    Case "ui-icon-arrowreturnthick-1-w"
                        S = "2,67,10,10"
                    Case "ui-icon-arrowreturnthick-1-n"
                        S = "19,67,10,10"
                    Case "ui-icon-arrowreturnthick-1-e"
                        S = "35,67,10,10"
                    Case "ui-icon-arrowreturnthick-1-s"
                        S = "49,67,10,10"

                    Case "ui-icon-arrow_stop-1-w"
                        S = "3,66,10,10"
                    Case "ui-icon-arrow_stop-1-n"
                        S = "18,67,10,10"
                    Case "ui-icon-arrow_stop-1-e"
                        S = "35,67,10,10"
                    Case "ui-icon-arrow_stop-1-s"
                        S = "50,67,10,10"
                    Case "ui-icon-arrowreturn-1-w"
                        S = "66,67,10,10"
                    Case "ui-icon-arrowreturn-1-n"
                        S = "83,67,10,10"
                    Case "ui-icon-arrowreturn-1-e"
                        S = "99,67,10,10"
                    Case "ui-icon-arrowreturn-1-s"
                        S = "115,67,10,10"
                    Case "ui-icon-arrowrefresh-1-w"
                        S = "131,67,10,10"
                    Case "ui-icon-arrowrefresh-1-n"
                        S = "147,67,10,10"
                    Case "ui-icon-arrowrefresh-1-e"
                        S = "162,67,10,10"
                    Case "ui-icon-arrowrefresh-1-s"
                        S = "178,67,10,10"

                    Case "ui-icon-arrow-4"
                        S = "2,83,10,10"
                    Case "ui-icon-arrow-4-diag"
                        S = "19,83,10,10"
                    Case "ui-icon-extlink"
                        S = "35,83,10,10"
                    Case "ui-icon-newwin"
                        S = "51,83,10,10"
                    Case "ui-icon-refresh"
                        S = "67,83,10,10"
                    Case "ui-icon-shaffle"
                        S = "83,83,10,10"
                    Case "ui-icon-transfer-e-w"
                        S = "99,83,10,10"

                    Case "ui-icon-folder-collapsed"
                        S = "1,99,12,10"
                    Case "ui-icon-folder-open"
                        S = "18,99,12,10"
                    Case "ui-icon-document"
                        S = "34,99,12,10"
                    Case "ui-icon-document-b"
                        S = "51,99,12,10"
                    Case "ui-icon-note"
                        S = "66,99,12,10"
                    Case "ui-icon-closed"
                        S = "81,99,12,10"
                    Case "ui-icon-open"
                        S = "98,99,12,10"
                    Case "ui-icon-suitcase"
                        S = "113,99,12,10"
                    Case "ui-icon-comment"
                        S = "130,99,12,10"
                    Case "ui-icon-person"
                        S = "146,99,12,10"
                    Case "ui-icon-print"
                        S = "162,99,12,10"
                    Case "ui-icon-trash"
                        S = "179,99,10,10"
                    Case "ui-icon-locked"
                        S = "195,99,10,10"
                    Case "ui-icon-unlocked"
                        S = "211,99,10,10"
                    Case "ui-icon-bookmark"
                        S = "226,99,10,10"
                    Case "ui-icon-tag"
                        S = "243,99,10,10"

                    Case "ui-icon-home"
                        S = "2,115,10,10"
                    Case "ui-icon-flag"
                        S = "18,115,10,10"
                    Case "ui-icon-calculator"
                        S = "34,115,10,10"
                    Case "ui-icon-cart"
                        S = "51,113,11,14"
                    Case "ui-icon-pencil"
                        S = "66,115,11,10"
                    Case "ui-icon-clock"
                        S = "83,115,10,10"
                    Case "ui-icon-disk"
                        S = "99,115,10,10"
                    Case "ui-icon-calendar"
                        S = "115,115,10,10"
                    Case "ui-icon-zoomin"
                        S = "131,115,11,11"
                    Case "ui-icon-zoomout"
                        S = "147,115,11,11"
                    Case "ui-icon-search"
                        S = "163,115,10,10"
                    Case "ui-icon-wrench"
                        S = "179,115,10,10"
                    Case "ui-icon-gear"
                        S = "196,115,10,10"
                    Case "ui-icon-heart"
                        S = "211,115,10,10"
                    Case "ui-icon-star"
                        S = "226,115,11,10"
                    Case "ui-icon-link"
                        S = "243,115,10,10"

                    Case "ui-icon-cancel"
                        S = "3,131,10,10"
                    Case "ui-icon-plus"
                        S = "19,132,10,10"
                    Case "ui-icon-plusthick"
                        S = "35,131,10,10"
                    Case "ui-icon-minus"
                        S = "51,131,10,10"
                    Case "ui-icon-minusthick"
                        S = "66,131,10,10"
                    Case "ui-icon-close"
                        S = "83,131,10,10"
                    Case "ui-icon-closethick"
                        S = "99,131,10,10"
                    Case "ui-icon-key"
                        S = "115,131,10,10"
                    Case "ui-icon-lightbulb"
                        S = "131,131,10,10"
                    Case "ui-icon-scissors"
                        S = "147,131,10,10"
                    Case "ui-icon-clipboard"
                        S = "163,131,12,12"
                    Case "ui-icon-copy"
                        S = "179,131,12,12"
                    Case "ui-icon-contact"
                        S = "195,131,10,10"
                    Case "ui-icon-image"
                        S = "211,131,11,11"
                    Case "ui-icon-video"
                        S = "227,131,11,11"
                    Case "ui-icon-scroll" ' scroll or script is the same
                        S = "243,131,10,10"
                    Case "ui-icon-script"
                        S = "243,131,10,10"

                    Case "ui-icon-alert"
                        S = "2,146,12,10"
                    Case "ui-icon-info"
                        S = "18,145,14,14"
                    Case "ui-icon-notice"
                        S = "35,145,10,10"
                    Case "ui-icon-help"
                        S = "51,145,10,12"
                    Case "ui-icon-check"
                        S = "66,147,12,10"
                    Case "ui-icon-bullet"
                        S = "83,147,10,10"
                    Case "ui-icon-radio-off"
                        S = "99,147,10,10"
                    Case "ui-icon-radio-on"
                        S = "115,147,10,10"
                    Case "ui-icon-unpin"
                        S = "131,147,10,10"
                    Case "ui-icon-pin"
                        S = "147,147,10,10"

                    Case "ui-icon-play"
                        S = "3,163,10,10"
                    Case "ui-icon-pause"
                        S = "20,163,10,10"
                    Case "ui-icon-seek-next"
                        S = "35,163,10,10"
                    Case "ui-icon-seek-prev"
                        S = "51,163,10,10"
                    Case "ui-icon-seek-end"
                        S = "66,163,11,10"
                    Case "ui-icon-seek-first"
                        S = "83,163,10,10"
                    Case "ui-icon-stop"
                        S = "99,163,10,10"
                    Case "ui-icon-eject"
                        S = "115,163,10,10"
                    Case "ui-icon-volume-off"
                        S = "131,163,10,10"
                    Case "ui-icon-volume-on"
                        S = "147,163,10,10"

                    Case "ui-icon-power"
                        S = "2,179,10,10"
                    Case "ui-icon-signal-diag"
                        S = "20,179,10,10"
                    Case "ui-icon-signal"
                        S = "35,179,10,10"
                    Case "ui-icon-battery-0"
                        S = "51,179,10,10"
                    Case "ui-icon-battery-1"
                        S = "67,179,10,10"
                    Case "ui-icon-battery-2"
                        S = "83,179,10,10"
                    Case "ui-icon-battery-3"
                        S = "99,179,10,10"

                    Case "ui-icon-circle-plus"
                        S = "1,193,13,13"
                    Case "ui-icon-circle-minus"
                        S = "17,193,13,13"
                    Case "ui-icon-circle-close"
                        S = "33,193,13,13"
                    Case "ui-icon-circle-triangle-e"
                        S = "49,193,13,13"
                    Case "ui-icon-circle-triangle-s"
                        S = "65,193,13,13"
                    Case "ui-icon-circle-triangle-w"
                        S = "81,193,13,13"
                    Case "ui-icon-circle-triangle-n"
                        S = "97,193,13,13"
                    Case "ui-icon-circle-arrow-e"
                        S = "113,193,13,13"
                    Case "ui-icon-circle-arrow-s"
                        S = "129,193,13,13"
                    Case "ui-icon-circle-arrow-w"
                        S = "145,193,13,13"
                    Case "ui-icon-circle-arrow-n"
                        S = "161,193,13,13"
                    Case "ui-icon-circle-zoomin"
                        S = "177,193,13,13"
                    Case "ui-icon-circle-zoomout"
                        S = "193,193,13,13"
                    Case "ui-icon-circle-check"
                        S = "209,193,13,13"

                    Case "ui-icon-circlesmall-plus"
                        S = "3,211,10,10"
                    Case "ui-icon-circlesmall-minus"
                        S = "19,211,10,10"
                    Case "ui-icon-circlesmall-close"
                        S = "35,211,10,10"
                    Case "ui-icon-squaresmall-plus"
                        S = "51,211,10,10"
                    Case "ui-icon-squaresmall-minus"
                        S = "67,211,10,10"
                    Case "ui-icon-squaresmall-close"
                        S = "83,211,10,10"

                    Case "ui-icon-grip-dotted-vertical"
                        S = "2,227,10,10"
                    Case "ui-icon-grip-dotted-horizontal"
                        S = "18,227,10,10"
                    Case "ui-icon-grip-solid-vertical"
                        S = "35,227,10,10"
                    Case "ui-icon-grip-solid-horizontal"
                        S = "51,227,10,10"
                    Case "ui-icon-gripsmall-diagonal-se"
                        S = "67,227,10,10"
                    Case "ui-icon-grip-diagonal-se"
                        S = "83,227,10,10"
                    Case Else
                        S = "0,0,0,0"
                End Select
                Return S
            End Function

            Private Shared Function generateTagJqueryIcons(ByVal type As JqueryIconTypes)
                Dim S As String = ""
                Select Case type
                    Case JqueryIconTypes.NotSet
                        S = "0,0,0,0"
                    Case JqueryIconTypes.carrat_1_n
                        S = "ui-icon-carat-1-n"
                    Case JqueryIconTypes.carrat_1_ne
                        S = "ui-icon-carat-1-ne"
                    Case JqueryIconTypes.carrat_1_e
                        S = "ui-icon-carat-1-e"
                    Case JqueryIconTypes.carrat_1_se
                        S = "ui-icon-carat-1-se"
                    Case JqueryIconTypes.carrat_1_nw
                        S = "ui-icon-carat-1-nw"
                    Case JqueryIconTypes.carrat_1_s
                        S = "ui-icon-carat-1-s"
                    Case JqueryIconTypes.carrat_1_sw
                        S = "ui-icon-carat-1-sw"
                    Case JqueryIconTypes.carrat_1_w
                        S = "ui-icon-carat-1-w"

                    Case JqueryIconTypes.arrow_1_w
                        S = "ui-icon-arrow-1-w"
                    Case JqueryIconTypes.arrow_1_nw
                        S = "ui-icon-arrow-1-nw"

                    Case JqueryIconTypes.carrat_2_n_s
                        S = "ui-icon-carrat-2-n-s"
                    Case JqueryIconTypes.carrat_2_e_w
                        S = "ui-icon-carrat-2-e-w"

                    Case JqueryIconTypes.triangle_1_n
                        S = "ui-icon-triangle-1-n"
                    Case JqueryIconTypes.triangle_1_ne
                        S = "ui-icon-triangle-1-ne"
                    Case JqueryIconTypes.triangle_1_e
                        S = "ui-icon-triangle-1-e"
                    Case JqueryIconTypes.triangle_1_se
                        S = "ui-icon-triangle-1-se"
                    Case JqueryIconTypes.triangle_1_s
                        S = "ui-icon-triangle-1-s"
                    Case JqueryIconTypes.triangle_1_sw
                        S = "ui-icon-triangle-1-sw"
                    Case JqueryIconTypes.triangle_1_w
                        S = "ui-icon-triangle-1-w"
                    Case JqueryIconTypes.triangle_1_nw
                        S = "ui-icon-triangle-1-nw"

                    Case JqueryIconTypes.arrow_1_n
                        S = "ui-icon-arrow-1-n"
                    Case JqueryIconTypes.arrow_1_ne
                        S = "ui-icon-arrow-1-ne"
                    Case JqueryIconTypes.arrow_1_e
                        S = "ui-icon-arrow-1-e"
                    Case JqueryIconTypes.arrow_1_se
                        S = "ui-icon-arrow-1-se"
                    Case JqueryIconTypes.arrow_1_s
                        S = "ui-icon-arrow-1-s"
                    Case JqueryIconTypes.arrow_1_sw
                        S = "ui-icon-arrow-1-sw"
                    Case JqueryIconTypes.arrow_1_w
                        S = "ui-icon-arrow-1-w"
                    Case JqueryIconTypes.arrow_1_nw
                        S = "ui-icon-arrow-1-nw"

                    Case JqueryIconTypes.arrow_2_n_s
                        S = "ui-icon-arrow-2-n-s"
                    Case JqueryIconTypes.arrow_2_ne_sw
                        S = "ui-icon-arrow-2-ne-sw"
                    Case JqueryIconTypes.arrow_2_e_w
                        S = "ui-icon-arrow-2-e-w"
                    Case JqueryIconTypes.arrow_2_se_nw
                        S = "ui-icon-arrow-2-se-nw"

                    Case JqueryIconTypes.arrow_stop_1_n
                        S = "ui-icon-arrow-stop-1-n"
                    Case JqueryIconTypes.arrow_stop_1_e
                        S = "ui-icon-arrow-stop-1-e"
                    Case JqueryIconTypes.arrow_stop_1_s
                        S = "ui-icon-arrow-stop-1-s"
                    Case JqueryIconTypes.arrow_stop_1_w
                        S = "ui-icon-arrow-stop-1-w"

                    Case JqueryIconTypes.arrowthick_1_n
                        S = "ui-icon-arrowthick-1-n"
                    Case JqueryIconTypes.arrowthick_1_ne
                        S = "ui-icon-arrowthick-1-ne"
                    Case JqueryIconTypes.arrowthick_1_e
                        S = "ui-icon-arrowthick-1-e"
                    Case JqueryIconTypes.arrowthick_1_se
                        S = "ui-icon-arrowthick-1-se"
                    Case JqueryIconTypes.arrowthick_1_s
                        S = "ui-icon-arrowthick-1-s"
                    Case JqueryIconTypes.arrowthick_1_sw
                        S = "ui-icon-arrowthick-1-sw"
                    Case JqueryIconTypes.arrowthick_1_w
                        S = "ui-icon-arrowthick-1-w"
                    Case JqueryIconTypes.arrowthick_1_nw
                        S = "ui-icon-arrowthick-1-nw"

                    Case JqueryIconTypes.arrowthick_2_n_s
                        S = "ui-icon-arrowthick-2-n-s"
                    Case JqueryIconTypes.arrowthick_2_ne_sw
                        S = "ui-icon-arrowthick-2-ne-sw"
                    Case JqueryIconTypes.arrowthick_2_e_w
                        S = "ui-icon-arrowthick-2-e-w"
                    Case JqueryIconTypes.arrowthick_2_se_nw
                        S = "ui-icon-arrowthick-2-se-nw"


                    Case JqueryIconTypes.arrowthick_stop_1_n
                        S = "ui-icon-arrowthickstop-1-n"
                    Case JqueryIconTypes.arrowthick_stop_1_e
                        S = "ui-icon-arrowthickstop-1-e"
                    Case JqueryIconTypes.arrowthick_stop_1_s
                        S = "ui-icon-arrowthickstop-1-s"
                    Case JqueryIconTypes.arrowthick_stop_1_w
                        S = "ui-icon-arrowthickstop-1-w"

                    Case JqueryIconTypes.arrowreturnthick_1_e
                        S = "ui-icon-arrowreturnthick-1-e"
                    Case JqueryIconTypes.arrowreturnthick_1_n
                        S = "ui-icon-arrowreturnthick-1-n"
                    Case JqueryIconTypes.arrowreturnthick_1_w
                        S = "ui-icon-arrowreturnthick-1-w"
                    Case JqueryIconTypes.arrowreturnthick_1_s
                        S = "ui-icon-arrowreturnthick-1-s"

                    Case JqueryIconTypes.arrow_stop_1_w
                        S = "ui-icon-arrow_stop-1-w"
                    Case JqueryIconTypes.arrow_stop_1_n
                        S = "ui-icon-arrow_stop-1-n"
                    Case JqueryIconTypes.arrow_stop_1_e
                        S = "ui-icon-arrow_stop-1-e"
                    Case JqueryIconTypes.arrow_stop_1_s
                        S = "ui-icon-arrow_stop-1-s"

                    Case JqueryIconTypes.arrowreturn_1_w
                        S = "ui-icon-arrowreturn-1-w"
                    Case JqueryIconTypes.arrowreturn_1_n
                        S = "ui-icon-arrowreturn-1-n"
                    Case JqueryIconTypes.arrowreturn_1_e
                        S = "ui-icon-arrowreturn-1-e"
                    Case JqueryIconTypes.arrowreturn_1_s
                        S = "ui-icon-arrowreturn-1-s"

                    Case JqueryIconTypes.arrowrefrsh_1_w
                        S = "ui-icon-arrowrefresh-1-w"
                    Case JqueryIconTypes.arrowrefrsh_1_n
                        S = "ui-icon-arrowrefresh-1-n"
                    Case JqueryIconTypes.arrowrefrsh_1_e
                        S = "ui-icon-arrowrefresh-1-e"
                    Case JqueryIconTypes.arrowrefrsh_1_s
                        S = "ui-icon-arrowrefresh-1-s"

                    Case JqueryIconTypes.arrow_4
                        S = "ui-icon-arrow-4"
                    Case JqueryIconTypes.arrow_4_diag
                        S = "ui-icon-arrow-4-diag"
                    Case JqueryIconTypes.extlink
                        S = "ui-icon-extlink"
                    Case JqueryIconTypes.newwin
                        S = "ui-icon-newwin"
                    Case JqueryIconTypes.refresh
                        S = "ui-icon-refresh"
                    Case JqueryIconTypes.shaffle
                        S = "ui-icon-shaffle"
                    Case JqueryIconTypes.transfer_e_w
                        S = "ui-icon-transfer-e-w"

                    Case JqueryIconTypes.folder_collapsed
                        S = "ui-icon-folder-collapsed"
                    Case JqueryIconTypes.folder_open
                        S = "ui-icon-folder-open"
                    Case JqueryIconTypes.document
                        S = "ui-icon-document"
                    Case JqueryIconTypes.document_b
                        S = "ui-icon-document-b"
                    Case JqueryIconTypes.note
                        S = "ui-icon-note"
                    Case JqueryIconTypes.closed
                        S = "ui-icon-closed"
                    Case JqueryIconTypes.open
                        S = "ui-icon-open"
                    Case JqueryIconTypes.suitcase
                        S = "ui-icon-suitcase"
                    Case JqueryIconTypes.comment
                        S = "ui-icon-comment"
                    Case JqueryIconTypes.person
                        S = "ui-icon-person"
                    Case JqueryIconTypes.print
                        S = "ui-icon-print"
                    Case JqueryIconTypes.trash
                        S = "ui-icon-trash"
                    Case JqueryIconTypes.locked
                        S = "ui-icon-locked"
                    Case JqueryIconTypes.unlocked
                        S = "ui-icon-unlocked"
                    Case JqueryIconTypes.bookmark
                        S = "ui-icon-bookmark"
                    Case JqueryIconTypes.tag
                        S = "ui-icon-tag"

                    Case JqueryIconTypes.home
                        S = "ui-icon-home"
                    Case JqueryIconTypes.flag
                        S = "ui-icon-flag"
                    Case JqueryIconTypes.calculator
                        S = "ui-icon-calculator"
                    Case JqueryIconTypes.cart
                        S = "ui-icon-cart"
                    Case JqueryIconTypes.pencil
                        S = "ui-icon-pencil"
                    Case JqueryIconTypes.clock
                        S = "ui-icon-clock"
                    Case JqueryIconTypes.disk
                        S = "ui-icon-disk"
                    Case JqueryIconTypes.calendar
                        S = "ui-icon-calendar"
                    Case JqueryIconTypes.zoomin
                        S = "ui-icon-zoomin"
                    Case JqueryIconTypes.zoomout
                        S = "ui-icon-zoomout"
                    Case JqueryIconTypes.search
                        S = "ui-icon-search"
                    Case JqueryIconTypes.wrench
                        S = "ui-icon-wrench"
                    Case JqueryIconTypes.gear
                        S = "ui-icon-gear"
                    Case JqueryIconTypes.heart
                        S = "ui-icon-heart"
                    Case JqueryIconTypes.star
                        S = "ui-icon-star"
                    Case JqueryIconTypes.link
                        S = "ui-icon-link"

                    Case JqueryIconTypes.cancel
                        S = "ui-icon-cancel"
                    Case JqueryIconTypes.plus
                        S = "ui-icon-plus"
                    Case JqueryIconTypes.plusthick
                        S = "ui-icon-plusthick"
                    Case JqueryIconTypes.minus
                        S = "ui-icon-minus"
                    Case JqueryIconTypes.minusthick
                        S = "ui-icon-minusthick"
                    Case JqueryIconTypes.close
                        S = "ui-icon-close"
                    Case JqueryIconTypes.closethick
                        S = "ui-icon-closethick"
                    Case JqueryIconTypes.key
                        S = "ui-icon-key"
                    Case JqueryIconTypes.lightbulb
                        S = "ui-icon-lightbulb"
                    Case JqueryIconTypes.scissors
                        S = "ui-icon-scissors"
                    Case JqueryIconTypes.clipboard
                        S = "ui-icon-clipboard"
                    Case JqueryIconTypes.copy
                        S = "ui-icon-copy"
                    Case JqueryIconTypes.contact
                        S = "ui-icon-contact"
                    Case JqueryIconTypes.image
                        S = "ui-icon-image"
                    Case JqueryIconTypes.video
                        S = "ui-icon-video"
                    Case JqueryIconTypes.scroll ' scroll or script is the same
                        S = "ui-icon-scroll"
                    Case JqueryIconTypes.scroll
                        S = "ui-icon-script"

                    Case JqueryIconTypes.alert
                        S = "ui-icon-alert"
                    Case JqueryIconTypes.info
                        S = "ui-icon-info"
                    Case JqueryIconTypes.notice
                        S = "ui-icon-notice"
                    Case JqueryIconTypes.help
                        S = "ui-icon-help"
                    Case JqueryIconTypes.check
                        S = "ui-icon-check"
                    Case JqueryIconTypes.bullet
                        S = "ui-icon-bullet"
                    Case JqueryIconTypes.radio_off
                        S = "ui-icon-radio-off"
                    Case JqueryIconTypes.radio_on
                        S = "ui-icon-radio-on"
                    Case JqueryIconTypes.unpin
                        S = "ui-icon-unpin"
                    Case JqueryIconTypes.pin
                        S = "ui-icon-pin"

                    Case JqueryIconTypes.play
                        S = "ui-icon-play"
                    Case JqueryIconTypes.pause
                        S = "ui-icon-pause"
                    Case JqueryIconTypes.seek_next
                        S = "ui-icon-seek-next"
                    Case JqueryIconTypes.seek_prev
                        S = "ui-icon-seek-prev"
                    Case JqueryIconTypes.seek_end
                        S = "ui-icon-seek-end"
                    Case JqueryIconTypes.seek_first
                        S = "ui-icon-seek-first"
                    Case JqueryIconTypes.stop_
                        S = "ui-icon-stop"
                    Case JqueryIconTypes.eject
                        S = "ui-icon-eject"
                    Case JqueryIconTypes.volume_off
                        S = "ui-icon-volume-off"
                    Case JqueryIconTypes.volume_on
                        S = "ui-icon-volume-on"

                    Case JqueryIconTypes.power
                        S = "ui-icon-power"
                    Case JqueryIconTypes.signal_diag
                        S = "ui-icon-signal-diag"
                    Case JqueryIconTypes.signal
                        S = "ui-icon-signal"
                    Case JqueryIconTypes.battery_0
                        S = "ui-icon-battery-0"
                    Case JqueryIconTypes.battery_1
                        S = "ui-icon-battery-1"
                    Case JqueryIconTypes.battery_2
                        S = "ui-icon-battery-2"
                    Case JqueryIconTypes.battery_3
                        S = "ui-icon-battery-3"

                    Case JqueryIconTypes.circle_plus
                        S = "ui-icon-circle-plus"
                    Case JqueryIconTypes.circle_minus
                        S = "ui-icon-circle-minus"
                    Case JqueryIconTypes.circle_close
                        S = "ui-icon-circle-close"
                    Case JqueryIconTypes.circle_triangle_e
                        S = "ui-icon-circle-triangle-e"
                    Case JqueryIconTypes.circle_triangle_s
                        S = "ui-icon-circle-triangle-s"
                    Case JqueryIconTypes.circle_triangle_w
                        S = "ui-icon-circle-triangle-w"
                    Case JqueryIconTypes.circle_triangle_n
                        S = "ui-icon-circle-triangle-n"
                    Case JqueryIconTypes.circle_arrow_e
                        S = "ui-icon-circle-arrow-e"
                    Case JqueryIconTypes.circle_arrow_s
                        S = "ui-icon-circle-arrow-s"
                    Case JqueryIconTypes.circle_arrow_w
                        S = "ui-icon-circle-arrow-w"
                    Case JqueryIconTypes.circle_arrow_n
                        S = "ui-icon-circle-arrow-n"
                    Case JqueryIconTypes.circle_zoomin
                        S = "ui-icon-circle-zoomin"
                    Case JqueryIconTypes.circle_zoomout
                        S = "ui-icon-circle-zoomout"
                    Case JqueryIconTypes.circle_check
                        S = "ui-icon-circle-check"

                    Case JqueryIconTypes.circle_small_plus
                        S = "ui-icon-circlesmall-plus"
                    Case JqueryIconTypes.circle_small_minus
                        S = "ui-icon-circlesmall-minus"
                    Case JqueryIconTypes.circle_small_close
                        S = "ui-icon-circlesmall-close"
                    Case JqueryIconTypes.square_small_plus
                        S = "ui-icon-squaresmall-plus"
                    Case JqueryIconTypes.square_small_minus
                        S = "ui-icon-squaresmall-minus"
                    Case JqueryIconTypes.square_small_close
                        S = "ui-icon-squaresmall-close"

                    Case JqueryIconTypes.grip_dotted_vertical
                        S = "ui-icon-grip-dotted-vertical"
                    Case JqueryIconTypes.grip_dotted_horizontal
                        S = "ui-icon-grip-dotted-horizontal"
                    Case JqueryIconTypes.grip_solid_vertical
                        S = "ui-icon-grip-solid-vertical"
                    Case JqueryIconTypes.grip_solid_horizontal
                        S = "ui-icon-grip-solid-horizontal"
                    Case JqueryIconTypes.grip_small_diagonal_se
                        S = "ui-icon-gripsmall-diagonal-se"
                    Case JqueryIconTypes.grip_diagonal_se
                        S = "ui-icon-grip-diagonal-se"
                    Case Else
                        S = "0,0,0,0"
                End Select
                Return S
            End Function

            ''' <summary>
            ''' It invokes the function to get the jquery icon based on the specified properties loaded
            ''' </summary>
            ''' <param name="JIconType">Set the type of Jquery Icon</param>
            ''' <param name="bmp">Set the jquery icon image to be used as reference for cropping purposes</param>
            ''' <param name="img_width">Set the width of the icon</param>
            ''' <param name="img_height">Set the height of the icon</param>
            ''' <returns>Get the selected Jquery Icon</returns>
            ''' <remarks></remarks>
            Public Shared Function GetJqueryIcons(ByVal JIconType As JqueryIconTypes, ByRef bmp As Bitmap, ByVal img_width As Integer, ByVal img_height As Integer) As Bitmap

                Dim tags As String = generateTagJqueryIcons(JIconType)

                Dim rec() As String = get_Tag_Icons_Jquery(tags).Split(",")
                Dim cropX As Integer = Val(rec(0))
                Dim cropY As Integer = Val(rec(1))
                Dim cropWidth As Integer = Val(rec(2))
                Dim cropHeight As Integer = Val(rec(3))
                Dim rect As New Rectangle(cropX, cropY, cropWidth, cropHeight)
                Try
                    Dim cropped As Bitmap = bmp.Clone(rect, bmp.PixelFormat)
                    Return myImage.Share.Tools.resizeImage(cropped, img_width, img_height)
                Catch ex As Exception
                    myExceptionHandler.OnThreadException(ex, "There was a problem of getting icons. [MyPicture[Get_Icons]]. ")
                    Return Nothing
                End Try
            End Function

        End Class

        ''' <summary>
        ''' It used to all icons of the windows 8 for the object
        ''' </summary>
        ''' <remarks></remarks>
        Public Class Windows8

            ''' <summary>
            ''' List of Windows 8 icons
            ''' </summary>
            ''' <remarks></remarks>
            Public Enum Windows8IconTypes
                NotSet
                skipBack
                skipAhead
                play
                pause
                edit
                save
                delete
                discard
                remove
                add
                no
                yes
                more
                redo
                undo
                home
                out
                next_
                previous
                favorite
                photo
                settings
                video
                refresh
                download
                mail
                search
                help
                upload
                emoji
                twoPage
                upload2
                forwardMail
                clock
                send
                crop
                rotateCamera
                people
                closePane
                openPane
                world
                flag
                previewLink
                globe
                trim
                attachCamera
                zoomIn
                bookmarks
                document
                protectedDocument
                page
                bullets
                comment
                mail2
                contactInfo
                hangUp
                viewAll
                mapPin
                phone
                videoChat
                switch
                contact
                rename
                pin
                musicInfo
                go
                keyboard
                dockLeft
                dockRight
                dockBottom
                remote
                sync
                rotate
                shuffle
                list
                shop
                selectAll
                orientation
                import
                importAll
                browsePhotos
                webcam
                pictures
                saveLocal
                caption
                stop_
                showResults
                volume
                repair
                message
                page2
                day
                week
                calendar
                characters
                replayAll
                read
                link
                accounts
                showBcc
                hideBcc
                cut
                attach
                paste
                filter
                copy
                emoji2
                important
                slideshow
                sort
                manage
                allApps
                disconnectDrive
                mapDrive
                newWindow
                openWith
                presence
                priority
                skyDrive
                today
                font
                fontColor
                contact2
                folder
                audio
                peaceHolder
                view
                setLockScreen
                setTitle
                cc
                stopSlideshow
                permissions
                highlight
                disableUpdates
                unfavorite
                unpin
                openLoal
                mute
                italic
                bold
                moveToFolder
                likeDislike
                dislike
                like_
                alignRight
                alignCenter
                alignLeft
                zoom
                zoomOut
                openFile
                otherUser
                admin
                street
                map
                clearSelection
                decreaseFont
                increaseFont
                fontSize
                cellphone
                reshare
                tag
                repeatOnce
                repeatAll
                outlineStar
                solidStar
                calculator
                directions
                target
                library
                phoneBook
                memo
                microphone
                postUpdate
                backtoWindow
                fullScreen
                newFolder
                calendarReply
                unsyncFolder
                reportHacked
                syncFolder
                blockContact
                swithApps
                phoneBook2
                memo2
                microphone2
                postUpdate2
                backToWindow2
                fullScreen2
                newFolder2
                calendarReply2
                unsyncFolder2
                reportHacked2
                syncFolder2
                blockContact2
                addFriend
                touchPointer
                gotoStart
                zeroBars
                oneBar
                twoBars
                threeBars
                fourBars
            End Enum

            Private Shared Function setPos(ByVal x As Integer, ByVal y As Integer) As String
                Dim totX As Integer = (x * 100) + 35
                Dim totY As Integer = (y * 100) + 10
                Return totX.ToString + "," + totY.ToString + "," + "48,48"
            End Function

            Private Shared Function get_Tag_Icons_Windows8(ByVal type As Windows8.Windows8IconTypes) As String
                Select Case type
                    Case Windows8IconTypes.skipBack
                        Return setPos(0, 0)
                    Case Windows8IconTypes.skipAhead
                        Return setPos(1, 0)
                    Case Windows8IconTypes.play
                        Return setPos(2, 0)
                    Case Windows8IconTypes.pause
                        Return setPos(3, 0)
                    Case Windows8IconTypes.edit
                        Return setPos(4, 0)
                    Case Windows8IconTypes.save
                        Return setPos(5, 0)
                    Case Windows8IconTypes.delete
                        Return setPos(6, 0)
                    Case Windows8IconTypes.discard
                        Return setPos(7, 0)
                    Case Windows8IconTypes.remove
                        Return setPos(8, 0)
                    Case Windows8IconTypes.add
                        Return setPos(9, 0)
                    Case Windows8IconTypes.no
                        Return setPos(10, 0)
                    Case Windows8IconTypes.yes
                        Return setPos(11, 0)
                    Case Windows8IconTypes.more
                        Return setPos(12, 0)
                    Case Windows8IconTypes.redo
                        Return setPos(13, 0)
                    Case Windows8IconTypes.undo
                        Return setPos(14, 0)
                    Case Windows8IconTypes.home
                        Return setPos(15, 0)
                    Case Windows8IconTypes.out
                        Return setPos(16, 0)
                    Case Windows8IconTypes.next_
                        Return setPos(17, 0)
                    Case Windows8IconTypes.previous
                        Return setPos(18, 0)

                    Case Windows8IconTypes.favorite
                        Return setPos(0, 1)
                    Case Windows8IconTypes.photo
                        Return setPos(1, 1)
                    Case Windows8IconTypes.settings
                        Return setPos(2, 1)
                    Case Windows8IconTypes.video
                        Return setPos(3, 1)
                    Case Windows8IconTypes.refresh
                        Return setPos(4, 1)
                    Case Windows8IconTypes.download
                        Return setPos(5, 1)
                    Case Windows8IconTypes.mail
                        Return setPos(6, 1)
                    Case Windows8IconTypes.search
                        Return setPos(7, 1)
                    Case Windows8IconTypes.help
                        Return setPos(8, 1)
                    Case Windows8IconTypes.upload
                        Return setPos(9, 1)
                    Case Windows8IconTypes.emoji
                        Return setPos(10, 1)
                    Case Windows8IconTypes.twoPage
                        Return setPos(11, 1)
                    Case Windows8IconTypes.upload2
                        Return setPos(12, 1)
                    Case Windows8IconTypes.forwardMail
                        Return setPos(13, 1)
                    Case Windows8IconTypes.clock
                        Return setPos(14, 1)
                    Case Windows8IconTypes.send
                        Return setPos(15, 1)
                    Case Windows8IconTypes.crop
                        Return setPos(16, 1)
                    Case Windows8IconTypes.rotateCamera
                        Return setPos(17, 1)
                    Case Windows8IconTypes.people
                        Return setPos(18, 1)
                    Case Windows8IconTypes.closePane
                        Return setPos(0, 2)
                    Case Windows8IconTypes.openPane
                        Return setPos(1, 2)
                    Case Windows8IconTypes.world
                        Return setPos(2, 2)
                    Case Windows8IconTypes.flag
                        Return setPos(3, 2)
                    Case Windows8IconTypes.previewLink
                        Return setPos(4, 2)
                    Case Windows8IconTypes.globe
                        Return setPos(5, 2)
                    Case Windows8IconTypes.trim
                        Return setPos(6, 2)
                    Case Windows8IconTypes.attachCamera
                        Return setPos(7, 2)
                    Case Windows8IconTypes.zoomIn
                        Return setPos(8, 2)
                    Case Windows8IconTypes.bookmarks
                        Return setPos(9, 2)
                    Case Windows8IconTypes.document
                        Return setPos(10, 2)
                    Case Windows8IconTypes.protectedDocument
                        Return setPos(11, 2)
                    Case Windows8IconTypes.page
                        Return setPos(12, 2)
                    Case Windows8IconTypes.bullets
                        Return setPos(13, 2)
                    Case Windows8IconTypes.comment
                        Return setPos(14, 2)
                    Case Windows8IconTypes.mail2
                        Return setPos(15, 2)
                    Case Windows8IconTypes.contactInfo
                        Return setPos(16, 2)
                    Case Windows8IconTypes.hangUp
                        Return setPos(17, 2)
                    Case Windows8IconTypes.viewAll
                        Return setPos(18, 2)

                    Case Windows8IconTypes.mapPin
                        Return setPos(0, 3)
                    Case Windows8IconTypes.phone
                        Return setPos(1, 3)
                    Case Windows8IconTypes.videoChat
                        Return setPos(2, 3)
                    Case Windows8IconTypes.switch
                        Return setPos(3, 3)
                    Case Windows8IconTypes.contact
                        Return setPos(4, 3)
                    Case Windows8IconTypes.rename
                        Return setPos(5, 3)
                    Case Windows8IconTypes.pin
                        Return setPos(6, 3)
                    Case Windows8IconTypes.musicInfo
                        Return setPos(7, 3)
                    Case Windows8IconTypes.go
                        Return setPos(8, 3)
                    Case Windows8IconTypes.keyboard
                        Return setPos(9, 3)
                    Case Windows8IconTypes.dockLeft
                        Return setPos(10, 3)
                    Case Windows8IconTypes.dockRight
                        Return setPos(11, 3)
                    Case Windows8IconTypes.dockBottom
                        Return setPos(12, 3)
                    Case Windows8IconTypes.remote
                        Return setPos(13, 3)
                    Case Windows8IconTypes.sync
                        Return setPos(14, 3)
                    Case Windows8IconTypes.rotate
                        Return setPos(15, 3)
                    Case Windows8IconTypes.shuffle
                        Return setPos(16, 3)
                    Case Windows8IconTypes.list
                        Return setPos(17, 3)
                    Case Windows8IconTypes.shop
                        Return setPos(18, 3)

                    Case Windows8IconTypes.selectAll
                        Return setPos(0, 4)
                    Case Windows8IconTypes.orientation
                        Return setPos(1, 4)
                    Case Windows8IconTypes.import
                        Return setPos(2, 4)
                    Case Windows8IconTypes.importAll
                        Return setPos(3, 4)
                    Case Windows8IconTypes.browsePhotos
                        Return setPos(4, 4)
                    Case Windows8IconTypes.webcam
                        Return setPos(5, 4)
                    Case Windows8IconTypes.pictures
                        Return setPos(6, 4)
                    Case Windows8IconTypes.saveLocal
                        Return setPos(7, 4)
                    Case Windows8IconTypes.caption
                        Return setPos(8, 4)
                    Case Windows8IconTypes.stop_
                        Return setPos(9, 4)
                    Case Windows8IconTypes.showResults
                        Return setPos(10, 4)
                    Case Windows8IconTypes.volume
                        Return setPos(11, 4)
                    Case Windows8IconTypes.repair
                        Return setPos(12, 4)
                    Case Windows8IconTypes.message
                        Return setPos(13, 4)
                    Case Windows8IconTypes.page2
                        Return setPos(14, 4)
                    Case Windows8IconTypes.day
                        Return setPos(15, 4)
                    Case Windows8IconTypes.week
                        Return setPos(16, 4)
                    Case Windows8IconTypes.calendar
                        Return setPos(17, 4)
                    Case Windows8IconTypes.characters
                        Return setPos(18, 4)

                    Case Windows8IconTypes.replayAll
                        Return setPos(0, 5)
                    Case Windows8IconTypes.read
                        Return setPos(1, 5)
                    Case Windows8IconTypes.link
                        Return setPos(2, 5)
                    Case Windows8IconTypes.accounts
                        Return setPos(3, 5)
                    Case Windows8IconTypes.showBcc
                        Return setPos(4, 5)
                    Case Windows8IconTypes.hideBcc
                        Return setPos(5, 5)
                    Case Windows8IconTypes.cut
                        Return setPos(6, 5)
                    Case Windows8IconTypes.attach
                        Return setPos(7, 5)
                    Case Windows8IconTypes.paste
                        Return setPos(8, 5)
                    Case Windows8IconTypes.filter
                        Return setPos(9, 5)
                    Case Windows8IconTypes.copy
                        Return setPos(10, 5)
                    Case Windows8IconTypes.emoji2
                        Return setPos(11, 5)
                    Case Windows8IconTypes.important
                        Return setPos(12, 5)
                    Case Windows8IconTypes.slideshow
                        Return setPos(13, 5)
                    Case Windows8IconTypes.sort
                        Return setPos(14, 5)
                    Case Windows8IconTypes.manage
                        Return setPos(15, 5)
                    Case Windows8IconTypes.allApps
                        Return setPos(16, 5)
                    Case Windows8IconTypes.disconnectDrive
                        Return setPos(17, 5)
                    Case Windows8IconTypes.mapDrive
                        Return setPos(18, 5)

                    Case Windows8IconTypes.newWindow
                        Return setPos(0, 6)
                    Case Windows8IconTypes.openWith
                        Return setPos(1, 6)
                    Case Windows8IconTypes.presence
                        Return setPos(2, 6)
                    Case Windows8IconTypes.priority
                        Return setPos(3, 6)
                    Case Windows8IconTypes.skyDrive
                        Return setPos(4, 6)
                    Case Windows8IconTypes.today
                        Return setPos(5, 6)
                    Case Windows8IconTypes.font
                        Return setPos(6, 6)
                    Case Windows8IconTypes.fontColor
                        Return setPos(7, 6)
                    Case Windows8IconTypes.contact2
                        Return setPos(8, 6)
                    Case Windows8IconTypes.folder
                        Return setPos(9, 6)
                    Case Windows8IconTypes.audio
                        Return setPos(10, 6)
                    Case Windows8IconTypes.peaceHolder
                        Return setPos(11, 6)
                    Case Windows8IconTypes.view
                        Return setPos(12, 6)
                    Case Windows8IconTypes.setLockScreen
                        Return setPos(13, 6)
                    Case Windows8IconTypes.setTitle
                        Return setPos(14, 6)
                    Case Windows8IconTypes.cc
                        Return setPos(15, 6)
                    Case Windows8IconTypes.stopSlideshow
                        Return setPos(16, 6)
                    Case Windows8IconTypes.permissions
                        Return setPos(17, 6)
                    Case Windows8IconTypes.highlight
                        Return setPos(18, 6)

                    Case Windows8IconTypes.disableUpdates
                        Return setPos(0, 7)
                    Case Windows8IconTypes.unfavorite
                        Return setPos(1, 7)
                    Case Windows8IconTypes.unpin
                        Return setPos(2, 7)
                    Case Windows8IconTypes.openLoal
                        Return setPos(3, 7)
                    Case Windows8IconTypes.mute
                        Return setPos(4, 7)
                    Case Windows8IconTypes.italic
                        Return setPos(5, 7)
                    Case Windows8IconTypes.bold
                        Return setPos(6, 7)
                    Case Windows8IconTypes.moveToFolder
                        Return setPos(7, 7)
                    Case Windows8IconTypes.likeDislike
                        Return setPos(8, 7)
                    Case Windows8IconTypes.dislike
                        Return setPos(9, 7)
                    Case Windows8IconTypes.like_
                        Return setPos(10, 7)
                    Case Windows8IconTypes.alignRight
                        Return setPos(11, 7)
                    Case Windows8IconTypes.alignCenter
                        Return setPos(12, 7)
                    Case Windows8IconTypes.alignLeft
                        Return setPos(13, 7)
                    Case Windows8IconTypes.zoom
                        Return setPos(14, 7)
                    Case Windows8IconTypes.zoomOut
                        Return setPos(15, 7)
                    Case Windows8IconTypes.openFile
                        Return setPos(16, 7)
                    Case Windows8IconTypes.otherUser
                        Return setPos(17, 7)
                    Case Windows8IconTypes.admin
                        Return setPos(18, 7)

                    Case Windows8IconTypes.street
                        Return setPos(0, 8)
                    Case Windows8IconTypes.map
                        Return setPos(1, 8)
                    Case Windows8IconTypes.clearSelection
                        Return setPos(2, 8)
                    Case Windows8IconTypes.decreaseFont
                        Return setPos(3, 8)
                    Case Windows8IconTypes.increaseFont
                        Return setPos(4, 8)
                    Case Windows8IconTypes.fontSize
                        Return setPos(5, 8)
                    Case Windows8IconTypes.cellphone
                        Return setPos(6, 8)
                    Case Windows8IconTypes.reshare
                        Return setPos(7, 8)
                    Case Windows8IconTypes.tag
                        Return setPos(8, 8)
                    Case Windows8IconTypes.repeatOnce
                        Return setPos(9, 8)
                    Case Windows8IconTypes.repeatAll
                        Return setPos(10, 8)
                    Case Windows8IconTypes.outlineStar
                        Return setPos(11, 8)
                    Case Windows8IconTypes.solidStar
                        Return setPos(12, 8)
                    Case Windows8IconTypes.calculator
                        Return setPos(13, 8)
                    Case Windows8IconTypes.directions
                        Return setPos(14, 8)
                    Case Windows8IconTypes.target
                        Return setPos(15, 8)
                    Case Windows8IconTypes.library
                        Return setPos(16, 8)
                    Case Windows8IconTypes.phoneBook
                        Return setPos(17, 8)
                    Case Windows8IconTypes.memo
                        Return setPos(18, 8)

                    Case Windows8IconTypes.microphone
                        Return setPos(0, 9)
                    Case Windows8IconTypes.postUpdate
                        Return setPos(1, 9)
                    Case Windows8IconTypes.backtoWindow
                        Return setPos(2, 9)
                    Case Windows8IconTypes.fullScreen
                        Return setPos(3, 9)
                    Case Windows8IconTypes.newFolder
                        Return setPos(4, 9)
                    Case Windows8IconTypes.calendarReply
                        Return setPos(5, 9)
                    Case Windows8IconTypes.unsyncFolder
                        Return setPos(6, 9)
                    Case Windows8IconTypes.reportHacked
                        Return setPos(7, 9)
                    Case Windows8IconTypes.syncFolder
                        Return setPos(8, 9)
                    Case Windows8IconTypes.blockContact
                        Return setPos(9, 9)
                    Case Windows8IconTypes.swithApps
                        Return setPos(10, 9)
                    Case Windows8IconTypes.phoneBook2
                        Return setPos(11, 9)
                    Case Windows8IconTypes.memo2
                        Return setPos(12, 9)
                    Case Windows8IconTypes.microphone2
                        Return setPos(13, 9)
                    Case Windows8IconTypes.postUpdate2
                        Return setPos(14, 9)
                    Case Windows8IconTypes.backToWindow2
                        Return setPos(15, 9)
                    Case Windows8IconTypes.fullScreen2
                        Return setPos(16, 9)
                    Case Windows8IconTypes.newFolder2
                        Return setPos(17, 9)
                    Case Windows8IconTypes.calendarReply2
                        Return setPos(18, 9)

                    Case Windows8IconTypes.unsyncFolder2
                        Return setPos(0, 10)
                    Case Windows8IconTypes.reportHacked2
                        Return setPos(1, 10)
                    Case Windows8IconTypes.syncFolder2
                        Return setPos(2, 10)
                    Case Windows8IconTypes.blockContact2
                        Return setPos(3, 10)
                    Case Windows8IconTypes.addFriend
                        Return setPos(4, 10)
                    Case Windows8IconTypes.touchPointer
                        Return setPos(5, 10)
                    Case Windows8IconTypes.gotoStart
                        Return setPos(6, 10)
                    Case Windows8IconTypes.zeroBars
                        Return setPos(7, 10)
                    Case Windows8IconTypes.oneBar
                        Return setPos(8, 10)
                    Case Windows8IconTypes.twoBars
                        Return setPos(9, 10)
                    Case Windows8IconTypes.threeBars
                        Return setPos(10, 10)
                    Case Windows8IconTypes.fourBars
                        Return setPos(11, 10)
                    Case Else
                        Return "0,0,0,0"
                End Select
            End Function

            ''' <summary>
            ''' It invokes the function to get the windows 8 icon based on the specified properties loaded
            ''' </summary>
            ''' <param name="windows8IconTypes">Set the type of windows 8 icon</param>
            ''' <param name="bmp">Set the windows 8 icon image to be used as reference for cropping purposes</param>
            ''' <param name="img_width">Set the width of the icon</param>
            ''' <param name="img_height">Set the height of the icon</param>
            ''' <param name="color">Set the color when there is MouseDown Event occurred for the purpose of adopting the backcolor of the object that applies into the windows 8 icon</param>
            ''' <param name="type">Specify the type either during MouseUp or MouseDown Event</param>
            ''' <returns>Get the selected windows 8 icon</returns>
            ''' <remarks></remarks>
            Public Shared Function GetWindows8Icons(ByVal windows8IconTypes As Windows8IconTypes, ByRef bmp As Bitmap, ByVal img_width As Integer, ByVal img_height As Integer, ByVal color As Color, Optional ByVal type As String = "") As Bitmap
                Dim rec() As String = get_Tag_Icons_Windows8(windows8IconTypes).Split(",")
                Dim cropX As Integer = Val(rec(0))
                Dim cropY As Integer = Val(rec(1))
                Dim cropWidth As Integer = Val(rec(2))
                Dim cropHeight As Integer = Val(rec(3))
                Dim rect As New Rectangle(cropX, cropY, cropWidth, cropHeight)
                Try
                    Dim cropped As Bitmap = bmp.Clone(rect, bmp.PixelFormat)
                    Return myImage.Share.Tools.resizeImage_Windows8(cropped, img_width, img_height, color, type)
                Catch ex As Exception
                    myExceptionHandler.OnThreadException(ex, "There was a problem of getting icons. [MyPicture[Get_Icons]]. ")
                    Return Nothing
                End Try
            End Function

        End Class

        ''' <summary>
        ''' It used to load all icons for the title bar only
        ''' </summary>
        ''' <remarks></remarks>
        Public Class TitleBar

            ''' <summary>
            ''' This type is used to classify the title bar image which is found at the right top corner of the form
            ''' </summary>
            ''' <remarks></remarks>
            Enum Type
                minimize
                restore
                maximize
                close
            End Enum

            Private Shared Function getImageCrop(ByVal type As Type, ByVal eventType As String) As String
                Select Case type
                    Case TitleBar.Type.minimize
                        If eventType = "normal" Then
                            Return "1,18,15,13"
                        ElseIf eventType = "gray" Then
                            Return "1,32,15,13"
                        Else
                            Return "1,4,15,13"
                        End If
                    Case TitleBar.Type.restore
                        If eventType = "normal" Then
                            Return "15,18,15,13"
                        ElseIf eventType = "gray" Then
                            Return "15,32,15,13"
                        Else
                            Return "15,4,15,13"
                        End If
                    Case TitleBar.Type.maximize
                        If eventType = "normal" Then
                            Return "30,18,15,13"
                        ElseIf eventType = "gray" Then
                            Return "30,32,15,13"
                        Else
                            Return "30,4,15,13"
                        End If
                    Case TitleBar.Type.close
                        Return "15,45,15,13"
                    Case Else
                        Return Nothing
                End Select
            End Function

            ''' <summary>
            ''' This function is not intended to be used as reference to other purpose.
            ''' </summary>
            ''' <param name="iconType">Specify the classification of the icon</param>
            ''' <param name="eventType">Specify the action either MouseMove or MouseUp event</param>
            ''' <returns>Get the selected title bar icon for the use of the form</returns>
            ''' <remarks></remarks>
            Public Shared Function getIcon(ByVal iconType As Type, Optional ByVal eventType As String = "normal", Optional ByVal runCode As String = "") As Bitmap
                If runCode = "masterkey" Then
                    Dim bmp As Bitmap = My.Resources.TitleBarIcons4
                    Dim rec() As String = getImageCrop(iconType, eventType).ToString.Split(",")
                    Dim cropX As Integer = Val(rec(0))
                    Dim cropY As Integer = Val(rec(1))
                    Dim cropWidth As Integer = Val(rec(2))
                    Dim cropHeight As Integer = Val(rec(3))
                    Dim rect As New Rectangle(cropX, cropY, cropWidth, cropHeight)
                    Try
                        Dim cropped As Bitmap = bmp.Clone(rect, bmp.PixelFormat)
                        Return myImage.Share.Tools.resizeImage(cropped, cropWidth, cropHeight)
                    Catch ex As Exception
                        myExceptionHandler.OnThreadException(ex, "There was a problem of getting icons. [MyPicture[Get_Icons]]. ")
                        Return Nothing
                    End Try
                Else
                    activationRequired("TitleBar.getIcon")
                End If
                Return Nothing
            End Function

        End Class

        ''' <summary>
        ''' It used to load all icons for the dialog box only
        ''' </summary>
        ''' <remarks></remarks>
        Public Class DialogBox

            ''' <summary>
            ''' This type is used to classify the dialog box icon
            ''' </summary>
            ''' <remarks></remarks>
            Enum Type
                Errors
                Warning
                Information
                Question
            End Enum

            Private Shared Function getImageCrop(ByVal type As Type) As String
                Select Case type
                    Case DialogBox.Type.Errors
                        Return "10,5,56,60"
                    Case DialogBox.Type.Warning
                        Return "8,78,59,55"
                    Case DialogBox.Type.Question
                        Return "9,153,56,58"
                    Case DialogBox.Type.Warning
                        Return "8,226,56,57"
                End Select
                Return Nothing
            End Function

            Public Shared Function getIcon(ByVal iconType As Type, Optional ByVal eventType As String = "normal", Optional ByVal runCode As String = "") As Bitmap
                If runCode = "masterkey" Then
                    Dim bmp As Bitmap = My.Resources.DialogBoxIcon
                    Dim rec() As String = getImageCrop(iconType).ToString.Split(",")
                    Dim cropX As Integer = Val(rec(0))
                    Dim cropY As Integer = Val(rec(1))
                    Dim cropWidth As Integer = Val(rec(2))
                    Dim cropHeight As Integer = Val(rec(3))
                    Dim rect As New Rectangle(cropX, cropY, cropWidth, cropHeight)
                    Try
                        Dim cropped As Bitmap = bmp.Clone(rect, bmp.PixelFormat)
                        Return myImage.Share.Tools.resizeImage(cropped, cropWidth, cropHeight)
                    Catch ex As Exception
                        myExceptionHandler.OnThreadException(ex, "There was a problem of getting icons. [MyPicture[Get_Icons]]. ")
                        Return Nothing
                    End Try
                Else
                    activationRequired("DialogBox.getIcon")
                End If
                Return Nothing
            End Function

        End Class

    End Namespace

End Namespace
