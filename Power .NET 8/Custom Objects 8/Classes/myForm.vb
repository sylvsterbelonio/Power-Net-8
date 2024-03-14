Imports System.Diagnostics
Imports System.Runtime.InteropServices

Public Class myForm
    <DllImport("User32", CharSet:=CharSet.Auto, ExactSpelling:=True)> _
Public Shared Function SetParent(ByVal hWndChild As IntPtr, ByVal hWndParent As IntPtr) As IntPtr
    End Function
    Private Declare Function FindWindow Lib "user32.dll" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer

    Private Function Get_MDIChild_Form(ByVal frmMe As Form, ByVal strFormName As String) As Form
        Dim ctl As Control
        Dim frmMdiChild As Form

        Get_MDIChild_Form = Nothing

        ' Loop through all child of the MDI Parent to check whether the selected from was loaded.
        For Each ctl In frmMe.MdiChildren
            Try
                ' Attempt to cast the control to type Form.
                frmMdiChild = CType(ctl, Form)
                If frmMdiChild.Name() = strFormName Then
                    ' Set the function to true, form was activated already
                    Get_MDIChild_Form = frmMdiChild
                End If
            Catch ex As Exception
                ' Catch and ignore the error if Exception.
                MsgBox("Error while getting the ChildForm of " & strFormName, ex.Message)
            End Try
        Next
        Return Get_MDIChild_Form
    End Function

    Public Function Load_Form(ByVal parent_form As Form, ByRef objForm As Form, Optional ByVal strFormTag As String = "") As Boolean
        'this procedure loads a form based on its name. it activates the form if existing already
        parent_form.Cursor = Cursors.WaitCursor
        Dim NwObjForm As Form
        If Not Check_If_Child_Is_Loaded(parent_form, objForm.Name) Then
            objForm.MdiParent = parent_form
            objForm.Show()
            parent_form.Cursor = Cursors.Arrow
            Return True
        Else
            objForm.Dispose()
            NwObjForm = Get_MDIChild_Form(parent_form, objForm.Name)
            NwObjForm.WindowState = FormWindowState.Normal
            NwObjForm.Activate()
            parent_form.Cursor = Cursors.Arrow
            Return False
        End If
    End Function

    'use this function when checking if a childform is already loaded based on the form name.
    Private Function Check_If_Child_Is_Loaded(ByVal frmMe As Form, ByVal strFormName As String) As Boolean
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

    Public Function Load_SubForm(ByVal parent_form As Form, ByRef objForm As Form)
        'parent_form.Cursor = Cursors.WaitCursor
        Dim NwObjForm As Form
        'objForm.Cursor = Cursors.WaitCursor
        If parent_form.IsMdiChild Then
            If Not Check_If_Child_Is_Loaded(parent_form.MdiParent, objForm.Name) Then
                objForm.MdiParent = parent_form.MdiParent
                objForm.Show()
                objForm.Cursor = Cursors.Default
                parent_form.Cursor = Cursors.Default
                Return True
            Else
                objForm.Dispose()
                NwObjForm = Get_MDIChild_Form(parent_form.MdiParent, objForm.Name)
                NwObjForm.WindowState = FormWindowState.Normal
                NwObjForm.Activate()
                parent_form.Cursor = Cursors.Default
                Return False
            End If
        Else
            objForm.ShowInTaskbar = False
            objForm.ShowDialog()
            Return True
        End If
    End Function

    Enum HideApp
        yes
        no
    End Enum

    Public Sub Load_Standard_Modal_Form(ByRef objForm As Form, Optional ByVal behavior_form As HideApp = HideApp.yes)
        If behavior_form = HideApp.yes Then objForm.ShowInTaskbar = False
        objForm.ShowDialog()
    End Sub

    Public Enum Applications
        notepad
        winword
        excel
        powerpoint
        calculator
        adobe_reader
    End Enum

    Private Shared Function get_app(ByVal op As Applications) As String
        Select Case op
            Case Applications.notepad
                Return "notepad.exe"
            Case Applications.calculator
                Return "calc.exe"
            Case Applications.winword
                Return "winword.exe"
            Case Applications.powerpoint
                Return "POWERPNT.exe"
            Case Applications.excel
                Return "excel.exe"
            Case Applications.adobe_reader
                Return "acroRD32.exe"
        End Select
        Return ""
    End Function

    Public Shared Sub Open_Application(ByVal app As Applications, ByRef frm As Form)
        Try
            Dim myProcess As Process = New Process()
            Dim MyHandle As IntPtr
            myProcess.StartInfo.FileName = get_app(app)
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            myProcess.Start()
            MyHandle = FindWindow(vbNullString, "C:\Windows\" + get_app(app))
            SetParent(MyHandle, frm.Handle)
            myProcess.WaitForExit()
        Catch ex As Exception
            MsgBox("Failed to launch the application, please check the application if it is correctly installed in your computer.", "Failed to Launch")
        End Try
    End Sub

  
End Class
