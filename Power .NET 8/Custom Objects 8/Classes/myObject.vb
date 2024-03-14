Public Class myObject

    Enum Lock
        Yes
        No
    End Enum
#Region "OBJECT IDENTIFIER FUNCTIONS"

    Public Sub get_all_objects_data(ByRef colObjects As Collection, ByRef forms As Form)
        IdentifyMainObject(colObjects, forms)
    End Sub

    Private Sub IdentifyMainObject(ByRef colObjects As Collection, ByRef forms As Form)
        With colObjects
            .Clear()
            Dim cControl As Control
            For Each cControl In forms.Controls
                If (TypeOf cControl Is GroupBox) Then
                    .Add(CType(cControl, GroupBox))
                    IdentifySubMainObject(colObjects, cControl)
                ElseIf TypeOf cControl Is Panel Then
                    .Add(CType(cControl, Panel))
                    IdentifySubMainObject(colObjects, cControl)
                ElseIf TypeOf cControl Is CheckBox Then
                    .Add(CType(cControl, CheckBox))
                ElseIf (TypeOf cControl Is SplitContainer) Then
                    .Add(CType(cControl, SplitContainer))
                    IdentifySubMainObject(colObjects, cControl)
                ElseIf (TypeOf cControl Is TableLayoutPanel) Then
                    .Add(CType(cControl, TableLayoutPanel))
                    IdentifySubMainObject(colObjects, cControl)
                ElseIf TypeOf cControl Is Infragistics.Win.UltraWinEditors.UltraDateTimeEditor Then
                    .Add(CType(cControl, Infragistics.Win.UltraWinEditors.UltraDateTimeEditor))
                ElseIf (TypeOf cControl Is Infragistics.Win.UltraWinTabControl.UltraTabControl) Then
                    .Add(CType(cControl, Infragistics.Win.UltraWinTabControl.UltraTabControl))
                    IdentifySubMainObject(colObjects, cControl)
                ElseIf (TypeOf cControl Is TabControl) Then
                    .Add(CType(cControl, TabControl))
                    IdentifySubMainObject(colObjects, cControl)
                Else
                    .Add(cControl)
                End If
            Next cControl
            .Add(forms)
        End With
    End Sub

    Private Sub IdentifySubMainObject(ByRef colObjects As Collection, ByRef listOjbect As Object)
        Dim cControl As Control
        With colObjects
            For i As Integer = (listOjbect.Controls.Count - 1) To 0 Step -1
                cControl = listOjbect.Controls(i)
                If (TypeOf cControl Is GroupBox) Then
                    .Add(CType(cControl, GroupBox))
                    IdentifySubMainObject(colObjects, cControl)
                ElseIf (TypeOf cControl Is Infragistics.Win.UltraWinTabControl.UltraTabControl) Then
                    .Add(CType(cControl, Infragistics.Win.UltraWinTabControl.UltraTabControl))
                    IdentifySubMainObject(colObjects, cControl)
                ElseIf TypeOf cControl Is Infragistics.Win.UltraWinTabControl.UltraTabPageControl Then
                    .Add(CType(cControl, Infragistics.Win.UltraWinTabControl.UltraTabPageControl))
                    IdentifySubMainObject(colObjects, cControl)
                ElseIf TypeOf cControl Is Panel Then
                    .Add(CType(cControl, Panel))
                    IdentifySubMainObject(colObjects, cControl)
                ElseIf TypeOf cControl Is CheckBox Then
                    .Add(CType(cControl, CheckBox))
                ElseIf (TypeOf cControl Is SplitContainer) Then
                    .Add(CType(cControl, SplitContainer))
                    IdentifySubMainObject(colObjects, cControl)
                ElseIf (TypeOf cControl Is TableLayoutPanel) Then
                    .Add(CType(cControl, TableLayoutPanel))
                    IdentifySubMainObject(colObjects, cControl)
                ElseIf (TypeOf cControl Is Infragistics.Win.UltraWinTabControl.UltraTabPageControl) Then
                    .Add(CType(cControl, Infragistics.Win.UltraWinTabControl.UltraTabPageControl))
                    IdentifySubMainObject(colObjects, cControl)
                ElseIf (TypeOf cControl Is TabPage) Then
                    .Add(CType(cControl, TabPage))
                    IdentifySubMainObject(colObjects, cControl)
                ElseIf TypeOf cControl Is StatusStrip Then
                    .Add(cControl)
                Else
                    .Add(cControl)
                End If
            Next i
        End With
    End Sub

#End Region
    Public Sub Lock_Mode_All(ByRef objects As Collection, Optional ByVal do_you_want_to_lock As Lock = Lock.Yes)
        Dim readOnly_ As Boolean
        Dim Enable As Boolean
        If do_you_want_to_lock = Lock.Yes Then
            readOnly_ = True
            Enable = False
        ElseIf do_you_want_to_lock = Lock.No Then
            readOnly_ = False
            Enable = True
        End If

        For Each O As Object In objects
            If TypeOf O Is TextBox Then
                CType(O, TextBox).ReadOnly = readOnly_
            ElseIf TypeOf O Is ListBox Then
                CType(O, ListBox).Enabled = Enable
            ElseIf TypeOf O Is CheckBox Then
                CType(O, CheckBox).Enabled = Enable
            ElseIf TypeOf O Is DataGridView Then
                With CType(O, DataGridView)
                    Try
                        .AllowUserToAddRows = Enable
                        .AllowUserToDeleteRows = Enable
                    Catch ex As Exception
                    End Try
                    If Enable Then
                        .EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
                        .SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
                    Else
                        .EditMode = DataGridViewEditMode.EditProgrammatically
                        .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    End If
                End With
            ElseIf TypeOf O Is MaskedTextBox Then
                With CType(O, MaskedTextBox)
                    .ReadOnly = readOnly_
                    If readOnly_ Then
                        '.BackColor = Validate.validateColor(disabled_BackColor)
                    Else
                        '.BackColor = Validate.validateColor(clrLostFocusTxtCbo_BackColor)
                    End If
                End With
            ElseIf TypeOf O Is ComboBox Then
                With CType(O, ComboBox)
                    .Enabled = Enable
                    If Enable = False Then
                        '.BackColor = Validate.validateColor(disabled_BackColor)
                    Else
                        '.BackColor = Validate.validateColor(clrLostFocusTxtCbo_BackColor)
                    End If
                End With
            ElseIf TypeOf O Is RadioButton Then
                CType(O, RadioButton).Enabled = Enable
            ElseIf TypeOf O Is DateTimePicker Then
                CType(O, DateTimePicker).Enabled = Enable
                If Enable = False Then
                    'CType(O, DateTimePicker).BackColor = Validate.validateColor(clrLostFocusTxtCbo_BackColor)
                Else
                    'CType(O, DateTimePicker).BackColor = Validate.validateColor(disabled_BackColor)
                End If
            ElseIf TypeOf O Is NumericUpDown Then
                With CType(O, NumericUpDown)
                    .ReadOnly = readOnly_
                    If readOnly_ Then
                        '.BackColor = ColorPicker(ui_textbox_readonly, PickStyle.backColor)
                        '.ForeColor = ColorPicker(ui_textbox_readonly, PickStyle.fontColor)
                    Else
                        '.BackColor = ColorPicker(ui_textbox_normal, PickStyle.backColor)
                        '.ForeColor = ColorPicker(ui_textbox_normal, PickStyle.fontColor)
                    End If
                End With
            ElseIf TypeOf O Is Infragistics.Win.UltraWinEditors.UltraDateTimeEditor Then
                CType(O, Infragistics.Win.UltraWinEditors.UltraDateTimeEditor).ReadOnly = readOnly_
                ' ElseIf TypeOf O Is MyCheckBoxExtension Then
                '    With CType(O, MyCheckBoxExtension)
                '  .Enabled = Enable
                '    End With
            End If
        Next
    End Sub

    Public Sub Clear_All(ByRef objects As Collection)
        Dim myobjects As Object
        For Each myobjects In objects
            If TypeOf myobjects Is TextBox Then
                With CType(myobjects, TextBox)
                    .Text = ""
                    'If Not myAutoSuggest.get_Specified_Word(.Tag, CustomObjects.myAutoSuggest.WordTypes.suggest) Is Nothing Then
                    'If myAutoSuggest.get_Specified_Word(.Tag, CustomObjects.myAutoSuggest.WordTypes.suggest).ToString.Contains("-loaded") Then
                    'Dim suggest As String = myAutoSuggest.get_Specified_Word(.Tag, myAutoSuggest.WordTypes.suggest)
                    'Dim icon As String = myAutoSuggest.get_Specified_Word(.Tag, myAutoSuggest.WordTypes.ui)
                    'Dim tooltip As String = myAutoSuggest.get_Specified_Word(.Tag, myAutoSuggest.WordTypes.tooltip)
                    'Dim wrapper As String = ""
                    'suggest = suggest.ToString.Substring(0, suggest.Length - 7)
                    'wrapper = suggest
                    'If Not icon Is Nothing Then wrapper += ";" + icon
                    'If Not tooltip Is Nothing Then wrapper += ";" + tooltip
                    '.Tag = wrapper
                    '.Tag = .Tag.ToString.Substring(0, .Tag.length - 7)
                    'End If
                    'End If
                End With
            ElseIf TypeOf myobjects Is ComboBox Then
                CType(myobjects, ComboBox).SelectedIndex = -1
                CType(myobjects, ComboBox).Text = ""
            ElseIf TypeOf myobjects Is MaskedTextBox Then
                CType(myobjects, MaskedTextBox).Text = ""
            ElseIf TypeOf myobjects Is ListBox Then
                CType(myobjects, ListBox).Items.Clear()
            ElseIf TypeOf myobjects Is CheckBox Then
                CType(myobjects, CheckBox).Checked = False
            ElseIf TypeOf myobjects Is RadioButton Then
                CType(myobjects, RadioButton).Checked = False
            ElseIf TypeOf myobjects Is DateTimePicker Then
                CType(myobjects, DateTimePicker).Value = Now
            ElseIf TypeOf myobjects Is Infragistics.Win.UltraWinEditors.UltraDateTimeEditor Then
                CType(myobjects, Infragistics.Win.UltraWinEditors.UltraDateTimeEditor).Text = ""
            ElseIf TypeOf myobjects Is DataGridView Then
                If Not CType(myobjects, DataGridView).Tag Is Nothing Then
                    If CType(myobjects, DataGridView).Tag.ToString.ToLower = "custom" Then
                        'nothing
                    Else
                        Try
                            CType(myobjects, DataGridView).Rows.Clear()
                        Catch ex As Exception
                        End Try
                    End If
                Else
                    Try
                        CType(myobjects, DataGridView).Rows.Clear()
                    Catch ex As Exception
                    End Try
                End If
            End If
        Next
    End Sub

End Class
