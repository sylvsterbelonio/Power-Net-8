Namespace myValidation

    Namespace Share

        Namespace Controls

            ''' <summary>
            ''' This class handles the panel object for validation purpose only
            ''' </summary>
            ''' <remarks></remarks>
            Public Class Panels

                ''' <summary>
                ''' Checks the panel object if it is exist in the form
                ''' </summary>
                ''' <param name="form">Set the form as reference to this class</param>
                ''' <param name="searchFilter">Set the panel name you wanted to search</param>
                ''' <returns>Return true if the panel is exist</returns>
                ''' <remarks></remarks>
                Public Shared Function checkNameExist(ByVal form As Object, ByVal searchFilter As String)
                    'checking if there is a control that exist
                    With CType(form, Form)
                        For i As Integer = 0 To .Controls.Count - 1
                            Dim ob As Object = .Controls(i)
                            If TypeOf ob Is Panel Then
                                If CType(ob, Panel).Name = searchFilter Then
                                    Return True
                                    Exit For
                                End If
                            End If
                        Next
                    End With
                    Return False
                End Function

            End Class

            ''' <summary>
            ''' This class handles the form object for validation purpose only
            ''' </summary>
            ''' <remarks></remarks>
            Public Class Forms

                ''' <summary>
                ''' Use this function when checking if a childform is already loaded based on the form name.
                ''' </summary>
                ''' <param name="frmMe">Set the Form</param>
                ''' <param name="strFormName">Set the name of the form</param>
                ''' <returns></returns>
                ''' <remarks></remarks>
                Public Shared Function checkChildForm(ByVal frmMe As Form, ByVal strFormName As String) As Boolean
                    Dim ctl As Control
                    Dim frmMdiChild As Form

                    ' Loop through all child of the MDI Parent to check whether the selected from was loaded.
                    For Each ctl In frmMe.MdiChildren
                        Try
                            ' Attempt to cast the control to type Form.
                            frmMdiChild = CType(ctl, Form)
                            If frmMdiChild.Name() = strFormName Then
                                ' Set the function to true, form was activated already
                                Return True
                            End If
                        Catch ex As Exception
                            ' Catch and ignore the error if Exception.
                            MsgBox("Error while checking if the ChildForm is loaded.", ex.Message)
                        End Try
                    Next
                    Return False
                End Function

                ''' <summary>
                ''' Use this function when activating a childform that is already loaded based on the form name.
                ''' </summary>
                ''' <param name="frmMe">Set the form</param>
                ''' <param name="strFormName">Set the name of the form</param>
                ''' <returns></returns>
                ''' <remarks></remarks>
                Public Shared Function getMDIChildForm(ByVal frmMe As Form, ByVal strFormName As String) As Form
                    Dim ctl As Control
                    Dim frmMdiChild As Form

                    getMDIChildForm = Nothing

                    ' Loop through all child of the MDI Parent to check whether the selected from was loaded.
                    For Each ctl In frmMe.MdiChildren
                        Try
                            ' Attempt to cast the control to type Form.
                            frmMdiChild = CType(ctl, Form)
                            If frmMdiChild.Name() = strFormName Then
                                ' Set the function to true, form was activated already
                                getMDIChildForm = frmMdiChild
                            End If
                        Catch ex As Exception
                            ' Catch and ignore the error if Exception.
                            MsgBox("Error while getting the ChildForm of " & strFormName, ex.Message)
                        End Try
                    Next
                    Return getMDIChildForm
                End Function

            End Class

        End Namespace

        ''' <summary>
        ''' This class handles the application for validation purpose only
        ''' </summary>
        ''' <remarks></remarks>
        Public Class Application

            ''' <summary>
            ''' It verifies the system if the same system is running to avoid multiple launch
            ''' </summary>
            ''' <param name="system_Name">Set the name of the system</param>
            ''' <returns>Return true the system is run twice</returns>
            ''' <remarks></remarks>
            Public Function verifyDoubleSystemOpened(ByVal system_Name As String) As Boolean 'THIS IS CHECKING THE SYSTEM DUPLICATIONS
                Dim emssMutex As System.Threading.Mutex
                emssMutex = New System.Threading.Mutex(False, system_Name)
                If emssMutex.WaitOne(0, False) Then
                    Return True
                Else
                    Return False
                End If
            End Function


        End Class

 

    End Namespace

    Namespace Init

        ''' <summary>
        ''' This class handles a bunch of items that needs to be searched if one of them is available from the list
        ''' </summary>
        ''' <remarks></remarks>
        Public Class StringReader
            Private colObjects As New Collection

            ''' <summary>
            ''' It clears the containers of all items
            ''' </summary>
            ''' <remarks></remarks>
            Public Sub clear()
                colObjects.Clear()
            End Sub

            ''' <summary>
            ''' It adds the item and will be stored in the container
            ''' </summary>
            ''' <param name="Value">Set the name of the item</param>
            ''' <remarks></remarks>
            Public Sub addParameter(ByVal Value As String)
                colObjects.Add(Value)
            End Sub 'ADD by individual

            ''' <summary>
            ''' It adds the item directly in one line. Make your you have a comma separator
            ''' </summary>
            ''' <param name="value">Set the group of items that needs to be added in the container</param>
            ''' <remarks></remarks>
            Public Sub groupParameters(Optional ByVal value As String = "sample 1,sample 2, sample 3, etc")
                Dim col() As String = value.Split(",")
                For i As Integer = 0 To col.Length - 1
                    colObjects.Add(Trim(col(i)))
                Next
            End Sub 'ADD in single LINE

            ''' <summary>
            ''' Validates the item if the search filter is match among the following items which you have previously added
            ''' </summary>
            ''' <param name="testValue">Set the search filter name</param>
            ''' <returns>Return true if the search name is match among the list item</returns>
            ''' <remarks></remarks>
            Public Function validateIFContains(ByVal testValue As String)
                If Not colObjects Is Nothing Then
                    For Each obj As Object In colObjects
                        If CType(obj, String).Contains(Trim(testValue)) Then
                            Return True
                        End If
                    Next
                End If
                Return False
            End Function

        End Class 'THE PURPOSE OF THIS READER IS TO...

        Public Class Validation
            Private Shared colobject As New Collection
            Private titles As String = "Indicated Fields Required"
            Private contents As String = "Please enter all required fields:"
            Public Property Title() As String
                Get
                    Return titles
                End Get
                Set(ByVal value As String)
                    titles = value
                End Set
            End Property

            Public Property Content() As String
                Get
                    Return contents
                End Get
                Set(ByVal value As String)
                    contents = value
                End Set
            End Property

            Public Sub New()
                colobject.Clear()
            End Sub

            Public Sub clear()
                colobject.Clear()
            End Sub

            Public Sub add(ByVal controlName As Object)
                colobject.Add(controlName)
            End Sub

            Public Function validateData() As Boolean
                Dim invalidControl As New Collection
                Dim argument As String = contents + vbCrLf

                For Each obj As Object In colobject
                    If TypeOf obj Is TextBox Then If CType(obj, TextBox).Text = "" Then invalidControl.Add(obj)
                    If TypeOf obj Is ComboBox Then If CType(obj, ComboBox).SelectedIndex = -1 Then invalidControl.Add(obj)
                    If TypeOf obj Is CheckBox Then If CType(obj, CheckBox).Checked = False Then invalidControl.Add(obj)
                    If TypeOf obj Is My8TextBox Then If CType(obj, My8TextBox).Text_ = "" Then invalidControl.Add(obj)
                    If TypeOf obj Is DataGridView Then If CType(obj, DataGridView).RowCount < 1 And CType(obj, DataGridView).AllowUserToAddRows Then invalidControl.Add(obj)
                Next
                Dim inc As Integer = 1
                For Each obj As Object In invalidControl
                    If TypeOf obj Is TextBox Then
                        myString.Share.Concat.Append(argument, inc.ToString + ". " + IIf(CType(obj, TextBox).Tag Is Nothing, CType(obj, TextBox).Name, CType(obj, TextBox).Tag), " " + vbCrLf + " ")
                        inc += 1
                    ElseIf TypeOf obj Is ComboBox Then
                        myString.Share.Concat.Append(argument, inc.ToString + ". " + IIf(CType(obj, ComboBox).Tag Is Nothing, CType(obj, ComboBox).Name, CType(obj, ComboBox).Tag), " " + vbCrLf + " ")
                        inc += 1
                    ElseIf TypeOf obj Is CheckBox Then
                        myString.Share.Concat.Append(argument, inc.ToString + ". " + IIf(CType(obj, CheckBox).Tag Is Nothing, CType(obj, CheckBox).Name, CType(obj, CheckBox).Tag), " " + vbCrLf + " ")
                        inc += 1
                    ElseIf TypeOf obj Is My8TextBox Then
                        myString.Share.Concat.Append(argument, inc.ToString + ". " + IIf(CType(obj, My8TextBox).Tag Is Nothing, CType(obj, My8TextBox).Name, CType(obj, My8TextBox).Tag), " " + vbCrLf + " ")
                        inc += 1
                    ElseIf TypeOf obj Is DataGridView Then
                        myString.Share.Concat.Append(argument, inc.ToString + ". " + IIf(CType(obj, DataGridView).Tag Is Nothing, CType(obj, DataGridView).Name, CType(obj, DataGridView).Tag), " " + vbCrLf + " ")
                        inc += 1
                    End If
                Next
                If argument <> "Please enter all required fields:" + vbCrLf Then
                    MsgBox(argument, MsgBoxStyle.Critical, Title)
                    Return False
                Else
                    Return True
                End If
            End Function

        End Class

    End Namespace


End Namespace


