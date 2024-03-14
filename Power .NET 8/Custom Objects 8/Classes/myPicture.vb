Public Class myPicture

    Public Function get_Icons(ByRef bmp As Bitmap, ByVal tags As String, ByVal img_width As Integer, ByVal img_height As Integer) As Bitmap
        Dim rec() As String = Get_Tag_Icons_Jquery(tags).Split(",")
        Dim cropX As Integer = Val(rec(0))
        Dim cropY As Integer = Val(rec(1))
        Dim cropWidth As Integer = Val(rec(2))
        Dim cropHeight As Integer = Val(rec(3))
        Dim rect As New Rectangle(cropX, cropY, cropWidth, cropHeight)
        Try
            Dim cropped As Bitmap = bmp.Clone(rect, bmp.PixelFormat)
            Return myImage.Share.Tools.resizeImage(cropped, img_width, img_height)

        Catch ex As Exception
            MsgBox("There was a problem of getting icons.", "MyPicture[Get_Icons]. " + ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Sub ui_Icons(ByRef sender As Object, ByVal bm As Bitmap, ByVal img_width As Integer, ByVal img_height As Integer)
        If Not bm Is Nothing Then
            If TypeOf sender Is Button Then
                If Not CType(sender, Button).Tag Is Nothing Then
                    If get_Tag_Icons_Jquery(get_Specified_Word(CType(sender, Button).Tag, WordTypes.ui)) <> "0,0,0,0" Then
                        CType(sender, Button).Image = get_Icons(bm, get_Specified_Word(CType(sender, Button).Tag, WordTypes.ui), img_width, img_height)
                    End If
                End If
            ElseIf TypeOf sender Is CButton Then
                If Not CType(sender, CButton).Tag Is Nothing Then
                    If get_Tag_Icons_Jquery(get_Specified_Word(CType(sender, CButton).Tag, WordTypes.ui)) <> "0,0,0,0" Then
                        CType(sender, CButton).Image = get_Icons(bm, get_Specified_Word(CType(sender, CButton).Tag, WordTypes.ui), img_width, img_height)
                    End If
                End If
            ElseIf TypeOf sender Is PictureBox Then
                If Not CType(sender, PictureBox).Tag Is Nothing Then
                    If get_Tag_Icons_Jquery(get_Specified_Word(CType(sender, PictureBox).Tag, WordTypes.ui)) <> "0,0,0,0" Then
                        CType(sender, PictureBox).Image = get_Icons(bm, get_Specified_Word(CType(sender, PictureBox).Tag, WordTypes.ui), img_width, img_height)
                    End If
                End If
            ElseIf TypeOf sender Is Infragistics.Win.UltraWinTabControl.UltraTabControl Then
                If Not CType(sender, Infragistics.Win.UltraWinTabControl.UltraTabControl).Tag Is Nothing Then

                End If
            ElseIf TypeOf sender Is Form Then
                If Not CType(sender, Form).Tag Is Nothing Then
                    If get_Tag_Icons_Jquery(get_Specified_Word(CType(sender, Form).Tag, WordTypes.ui)) <> "0,0,0,0" Then
                        CType(sender, Form).Icon = myImage.Share.Converter.BitmapToIcon16(get_Icons(bm, get_Specified_Word(CType(sender, Form).Tag, WordTypes.ui), img_width, img_height))
                    End If
                End If
            ElseIf TypeOf sender Is ToolStripMenuItem Then
                If Not CType(sender, ToolStripMenuItem).Tag Is Nothing Then
                    If get_Tag_Icons_Jquery(get_Specified_Word(CType(sender, ToolStripMenuItem).Tag, WordTypes.ui)) <> "0,0,0,0" Then
                        CType(sender, ToolStripMenuItem).Image = get_Icons(bm, get_Specified_Word(CType(sender, ToolStripMenuItem).Tag, WordTypes.ui), img_width, img_height)
                    End If
                End If
            ElseIf TypeOf sender Is ToolStripButton Then
                If Not CType(sender, ToolStripButton).Tag Is Nothing Then
                    If get_Tag_Icons_Jquery(get_Specified_Word(CType(sender, ToolStripButton).Tag, WordTypes.ui)) <> "0,0,0,0" Then
                        CType(sender, ToolStripButton).Image = get_Icons(bm, get_Specified_Word(CType(sender, ToolStripButton).Tag, WordTypes.ui), img_width, img_height)
                    End If
                End If
            ElseIf TypeOf sender Is ToolStripSplitButton Then
                If Not CType(sender, ToolStripSplitButton).Tag Is Nothing Then
                    If get_Tag_Icons_Jquery(get_Specified_Word(CType(sender, ToolStripSplitButton).Tag, WordTypes.ui)) <> "0,0,0,0" Then
                        CType(sender, ToolStripSplitButton).Image = get_Icons(bm, get_Specified_Word(CType(sender, ToolStripSplitButton).Tag, WordTypes.ui), img_width, img_height)
                    End If
                End If
            ElseIf TypeOf sender Is ToolStripLabel Then
                If Not CType(sender, ToolStripLabel).Tag Is Nothing Then
                    If get_Tag_Icons_Jquery(get_Specified_Word(CType(sender, ToolStripLabel).Tag, WordTypes.ui)) <> "0,0,0,0" Then
                        CType(sender, ToolStripLabel).Image = get_Icons(bm, get_Specified_Word(CType(sender, ToolStripLabel).Tag, WordTypes.ui), img_width, img_height)
                    End If
                End If
            ElseIf TypeOf sender Is ToolStripDropDownButton Then
                If Not CType(sender, ToolStripDropDownButton).Tag Is Nothing Then
                    If get_Tag_Icons_Jquery(get_Specified_Word(CType(sender, ToolStripDropDownButton).Tag, WordTypes.ui)) <> "0,0,0,0" Then
                        CType(sender, ToolStripDropDownButton).Image = get_Icons(bm, get_Specified_Word(CType(sender, ToolStripDropDownButton).Tag, WordTypes.ui), img_width, img_height)
                    End If
                End If
            End If
        End If
    End Sub

    Private Function get_Tag_Icons_Jquery(ByVal type As String) As String
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
            Case "ui-icon-carat-1-w"
                S = "99,2,10,10"
            Case "ui-icon-arrow-1-w"
                S = "99,2,10,10"
            Case "ui-icon-arrow-1-nw"
                S = "115,2,10,10"
            Case "ui-icon-carrat-2-n-s"
                S = "131,2,10,10"
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
                S = "66,115,10,10"
            Case "ui-icon-clock"
                S = "83,115,10,10"
            Case "ui-icon-disk"
                S = "99,115,10,10"
            Case "ui-icon-calendar"
                S = "115,115,10,10"
            Case "ui-icon-zoomin"
                S = "131,115,10,10"
            Case "ui-icon-zoomout"
                S = "147,115,10,10"
            Case "ui-icon-search"
                S = "163,115,10,10"
            Case "ui-icon-wrench"
                S = "179,115,10,10"
            Case "ui-icon-gear"
                S = "196,115,10,10"
            Case "ui-icon-heart"
                S = "211,115,10,10"
            Case "ui-icon-star"
                S = "226,115,10,10"
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
                S = "51,145,10,10"
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

    Enum WordTypes
        ui
        tooltip
        suggest
    End Enum

    Private Function get_Specified_Word(ByVal values As String, ByVal condition As WordTypes) As String
        Dim vals() As String = values.Split(";")
        For i As Integer = 0 To vals.Length - 1
            Dim cols() As String = vals(i).Split("-")
            Select Case condition
                Case WordTypes.ui
                    If Trim(cols(0)) = "ui" Then
                        Return vals(i)
                    End If
            End Select
        Next
        Return Nothing
    End Function

End Class
