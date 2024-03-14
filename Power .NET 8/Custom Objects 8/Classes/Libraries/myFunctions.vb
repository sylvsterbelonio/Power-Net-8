Namespace myFunctions

    Namespace Share

        Public Class Themes

            ''' <summary>
            ''' Get the themes of windows 8
            ''' </summary>
            ''' <param name="form">Set the form as reference</param>
            ''' <param name="timer">Set the timer as for active windows event</param>
            ''' <remarks></remarks>
            Public Shared Sub GetThemes(ByRef form As Form, ByRef timer As Timer, ByVal userName As String, Optional ByVal isShowDialog As Boolean = False)

                myControls.Share.Forms.TitleBar.createTitleBar(form, userName, "masterkey")

                If isShowDialog = False Then
                    myEvents.Share.TitleBar.ActiveWindow.addEvent(timer, form, userName, "masterkey")
                End If

                'THIS IS HOW TO GET MY THEMES
                Dim getThemes As New myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue
                getThemes = myDocument.Share.XMLDesigner.ThemesConfig.readThemes(userName)


                Dim colObjects As New Collection
                colObjects = myControls.Share.Objects.getAllObject(form)

                For Each obj As Object In colObjects
                    If TypeOf obj Is Button Then
                        myEvents.Share.Buttons.AddEvent(obj, getThemes, "masterkey")
                    ElseIf TypeOf obj Is TextBox Or TypeOf obj Is DomainUpDown Or TypeOf obj Is MaskedTextBox Or TypeOf obj Is ComboBox Or TypeOf obj Is ListBox Or TypeOf obj Is CheckedListBox Or TypeOf obj Is RichTextBox Or TypeOf obj Is NumericUpDown Then
                        myEvents.Share.Text.AddEvent(obj, getThemes, "masterkey")
                    ElseIf TypeOf obj Is CheckBox Or TypeOf obj Is RadioButton Then
                        myEvents.Share.Checks.AddEvent(obj, getThemes, "masterkey")
                    ElseIf TypeOf obj Is DataGridView Then
                        myEvents.Share.DatagridViews.AddEvent(obj, getThemes, "masterkey")
                    ElseIf TypeOf obj Is TabControl Then
                        myEvents.Share.TabControls.AddEvent(obj, getThemes, "masterkey")
                    ElseIf TypeOf obj Is TabPage Then
                        myEvents.Share.TabControls.AddEvent(obj, getThemes, "masterkey")
                    ElseIf TypeOf obj Is Panel Then
                        myEvents.Share.Panels.AddEvent(obj, getThemes, "masterkey")
                    ElseIf TypeOf obj Is MenuStrip Then
                        myEvents.Share.MenuStrips.AddEvent(obj, getThemes, "masterkey")
                    ElseIf TypeOf obj Is ToolStrip Then
                        myEvents.Share.Toolstrips.AddEvent(obj, getThemes, "masterkey")


                    ElseIf TypeOf obj Is My8AccentColor Then
                        With CType(obj, My8AccentColor)
                            .groupColorNameTag = getThemes.accentColor_subValue
                            .ColorNameTag = getThemes.accentColor_mainValue
                            .setColorTagName(getThemes.accentColor_mainValue)
                            .setGroupNameTag(getThemes.accentColor_subValue)
                        End With
                    ElseIf TypeOf obj Is My8BackgroundColor Then
                        With CType(obj, My8BackgroundColor)
                            .groupColorNameTag = getThemes.backgroundCOlor_subValue
                            .ColorNameTag = getThemes.backgroundColor_mainValue
                            .setColorTagName(getThemes.backgroundColor_mainValue)
                            .setGroupNameTag(getThemes.backgroundCOlor_subValue)
                        End With
                    End If
                Next


            End Sub

            Public Shared Sub GetThemesContextMenuStrip(ByRef contextMenuStrip As ContextMenuStrip, ByVal userName As String)
                'THIS IS HOW TO GET MY THEMES
                Dim getThemes As New myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue
                getThemes = myDocument.Share.XMLDesigner.ThemesConfig.readThemes(userName)

                myEvents.Share.ContextMenuStrips.AddEvent(contextMenuStrip, getThemes, "masterkey")

            End Sub

        End Class

    End Namespace



End Namespace



