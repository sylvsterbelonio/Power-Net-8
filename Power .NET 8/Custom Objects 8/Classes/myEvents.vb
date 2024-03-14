Imports PowerNET8.myColor.Share.Converter.StringToColor
Imports PowerNET8.myColor.Share.Tools

Namespace myEvents

    Namespace Share

        Namespace TitleBar

            ''' <summary>
            ''' This class is not intented to used for other purposes
            ''' </summary>
            ''' <remarks></remarks>
            Public Class Drag

                Private Shared posX As Integer = 0
                Private Shared posY As Integer = 0
                Private Shared drag As Boolean = False
                Private Shared imgMaximize As PictureBox
                Private Shared maximize As Boolean = False
                Private Shared myForm As Form

                Private Shared Sub _MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                    If e.Button = Windows.Forms.MouseButtons.Left And myForm.MaximizeBox Then
                        If myForm.WindowState = FormWindowState.Maximized Then
                            myForm.WindowState = FormWindowState.Normal
                            myForm.Padding = New Padding(5, 0, 5, 5)
                            maximize = False
                            imgMaximize.Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.maximize, , "masterkey")
                        Else
                            myForm.WindowState = FormWindowState.Maximized
                            maximize = True
                            myForm.Padding = New Padding(0, 0, 0, 0)
                            imgMaximize.Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.restore, , "masterkey")
                        End If
                    End If
                End Sub

                Private Shared Sub _MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                    If e.Button = Windows.Forms.MouseButtons.Left Then
                        drag = True
                        posX = Cursor.Position.X - myForm.Left
                        posY = Cursor.Position.Y - myForm.Top
                    End If
                End Sub

                Private Shared Sub _MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                    If drag Then
                        myForm.Top = System.Windows.Forms.Cursor.Position.Y - posY
                        myForm.Left = System.Windows.Forms.Cursor.Position.X - posX
                    End If
                    myForm.Cursor = Cursors.Default
                End Sub

                Private Shared Sub _MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                    drag = False
                End Sub

                ''' <summary>
                ''' This class will help simulate the drag and drop of the form
                ''' </summary>
                ''' <param name="obj">Set the objects which is required to add another event</param>
                ''' <param name="form">Set the form as reference for this class</param>
                ''' <param name="maximize">Set the maximize button</param>
                ''' <param name="runCode">It needs an authentication of the one who made this function</param>
                ''' <remarks></remarks>
                Public Shared Sub addEvent(ByVal obj As Object, ByRef form As Form, ByRef maximize As PictureBox, Optional ByVal runCode As String = "")
                    imgMaximize = maximize
                    If runCode = "masterkey" Then
                        If TypeOf obj Is Label Then
                            With CType(obj, Label)
                                AddHandler .MouseDoubleClick, AddressOf _MouseDoubleClick
                                AddHandler .MouseDown, AddressOf _MouseDown
                                AddHandler .MouseMove, AddressOf _MouseMove
                                AddHandler .MouseUp, AddressOf _MouseUp
                            End With
                        ElseIf TypeOf obj Is PictureBox Then
                            With CType(obj, PictureBox)
                                AddHandler .MouseDoubleClick, AddressOf _MouseDoubleClick
                                AddHandler .MouseDown, AddressOf _MouseDown
                                AddHandler .MouseMove, AddressOf _MouseMove
                                AddHandler .MouseUp, AddressOf _MouseUp
                            End With
                        ElseIf TypeOf obj Is Panel Then
                            With CType(obj, Panel)
                                AddHandler .MouseDoubleClick, AddressOf _MouseDoubleClick
                                AddHandler .MouseDown, AddressOf _MouseDown
                                AddHandler .MouseMove, AddressOf _MouseMove
                                AddHandler .MouseUp, AddressOf _MouseUp
                            End With
                        End If
                        myForm = form
                    End If
                End Sub

            End Class

            ''' <summary>
            ''' This class is not intented to used for other purposes
            ''' </summary>
            ''' <remarks></remarks>
            Public Class Resize

                Private Shared onFullScreen As Boolean
                Private Shared maximized As Boolean
                Private Shared on_MinimumSize As Boolean
                Private Shared minimumWidth As Short = 350
                Private Shared minimumHeight As Short = 26
                Private Shared borderSpace As Short = 20
                Private Shared borderDiamyFormter As Short = 3
                Private Shared borderDiameter As Short = 3
                Private Shared onBorderRight As Boolean
                Private Shared onBorderLeft As Boolean
                Private Shared onBorderTop As Boolean
                Private Shared onBorderBottom As Boolean
                Private Shared onCornerTopRight As Boolean
                Private Shared onCornerTopLeft As Boolean
                Private Shared onCornerBottomRight As Boolean
                Private Shared onCornerBottomLeft As Boolean

                Private Shared movingRight As Boolean
                Private Shared movingLeft As Boolean
                Private Shared movingTop As Boolean
                Private Shared movingBottom As Boolean
                Private Shared movingCornerTopRight As Boolean
                Private Shared movingCornerTopLeft As Boolean
                Private Shared movingCornerBottomRight As Boolean
                Private Shared movingCornerBottomLeft As Boolean
                Private Shared myForm As Form
                Private Shared myPanel As Panel

                Private Shared Sub _MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                    If myForm.SizeGripStyle <> SizeGripStyle.Hide Then
                        If e.Button = Windows.Forms.MouseButtons.Left Then
                            If onBorderRight Then movingRight = True Else movingRight = False
                            If onBorderLeft Then movingLeft = True Else movingLeft = False
                            If onBorderTop Then movingTop = True Else movingTop = False
                            If onBorderBottom Then movingBottom = True Else movingBottom = False
                            If onCornerTopRight Then movingCornerTopRight = True Else movingCornerTopRight = False
                            If onCornerTopLeft Then movingCornerTopLeft = True Else movingCornerTopLeft = False
                            If onCornerBottomRight Then movingCornerBottomRight = True Else movingCornerBottomRight = False
                            If onCornerBottomLeft Then movingCornerBottomLeft = True Else movingCornerBottomLeft = False
                        End If
                    End If
                End Sub

                Private Shared Sub _MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                    If myForm.SizeGripStyle <> SizeGripStyle.Hide Then
                        stopResizer()
                    End If
                End Sub

                Private Shared Sub _MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                    If myForm.SizeGripStyle <> SizeGripStyle.Hide Then
                        If onFullScreen Or maximized Then Exit Sub
                        If myForm.WindowState = FormWindowState.Maximized Then Exit Sub

                        If myForm.Width <= minimumWidth Then myForm.Width = (minimumWidth + 5) : on_MinimumSize = True
                        If myForm.Height <= minimumHeight Then myForm.Height = (minimumHeight + 5) : on_MinimumSize = True
                        If on_MinimumSize Then stopResizer() Else startResizer()


                        If (Cursor.Position.X > (myForm.Location.X + myForm.Width) - borderDiamyFormter) _
                            And (Cursor.Position.Y > (myForm.Location.Y + borderSpace)) _
                            And (Cursor.Position.Y < ((myForm.Location.Y + myForm.Height) - borderSpace)) Then
                            myForm.Cursor = Cursors.SizeWE
                            onBorderRight = True

                        ElseIf (Cursor.Position.X < (myForm.Location.X + borderDiamyFormter)) _
                            And (Cursor.Position.Y > (myForm.Location.Y + borderSpace)) _
                            And (Cursor.Position.Y < ((myForm.Location.Y + myForm.Height) - borderSpace)) Then
                            myForm.Cursor = Cursors.SizeWE
                            onBorderLeft = True

                        ElseIf (Cursor.Position.Y < (myForm.Location.Y + borderDiameter)) _
                            And (Cursor.Position.X > (myForm.Location.X + borderSpace)) _
                            And (Cursor.Position.X < ((myForm.Location.X + myPanel.Width) - borderSpace)) Then
                            myForm.Cursor = Cursors.SizeNS
                            onBorderTop = True

                        ElseIf (Cursor.Position.Y > ((myForm.Location.Y + myForm.Height) - borderDiameter)) _
                            And (Cursor.Position.X > (myForm.Location.X + borderSpace)) _
                            And (Cursor.Position.X < ((myForm.Location.X + myForm.Width) - borderSpace)) Then
                            myForm.Cursor = Cursors.SizeNS
                            onBorderBottom = True

                        ElseIf (Cursor.Position.X = ((myPanel.Location.X + myPanel.Width) - 1)) _
                            And (Cursor.Position.Y = myPanel.Location.Y) Then
                            myPanel.Cursor = Cursors.SizeNESW
                            onCornerTopRight = True

                        ElseIf (Cursor.Position.X = myPanel.Location.X) _
                            And (Cursor.Position.Y = myPanel.Location.Y) Then
                            myPanel.Cursor = Cursors.SizeNWSE
                            onCornerTopLeft = True

                        ElseIf (Cursor.Position.X = ((myForm.Location.X + myForm.Width) - 5)) _
                            And (Cursor.Position.Y = ((myForm.Location.Y + myForm.Height) - 5)) Then
                            myForm.Cursor = Cursors.SizeNWSE
                            onCornerBottomRight = True

                        ElseIf (Cursor.Position.X = myForm.Location.X) _
                            And (Cursor.Position.Y = ((myForm.Location.Y + myForm.Height) - 1)) Then
                            myForm.Cursor = Cursors.SizeNESW
                            onCornerBottomLeft = True

                        Else

                            If myForm.Cursor = Cursors.SizeNESW Or myForm.Cursor = Cursors.SizeNS Or myForm.Cursor = Cursors.SizeNWSE Or myForm.Cursor = Cursors.SizeWE Then
                                myForm.Cursor = Cursors.Default
                            End If

                            onBorderRight = False
                            onBorderLeft = False
                            onBorderTop = False
                            onBorderBottom = False
                            onCornerTopRight = False
                            onCornerTopLeft = False
                            onCornerBottomRight = False
                            onCornerBottomLeft = False
                            myForm.Cursor = Cursors.Default
                        End If
                    End If
                End Sub

                Private Shared Sub startResizer()
                    Select Case True

                        Case movingRight
                            myForm.Width = (Cursor.Position.X - myForm.Location.X)

                        Case movingLeft
                            myForm.Width = ((myForm.Width + myForm.Location.X) - Cursor.Position.X)
                            myForm.Location = New Point(Cursor.Position.X, myForm.Location.Y)

                        Case movingTop
                            myForm.Height = ((myForm.Height + myForm.Location.Y) - Cursor.Position.Y)
                            myForm.Location = New Point(myForm.Location.X, Cursor.Position.Y)

                        Case movingBottom
                            myForm.Height = (Cursor.Position.Y - myForm.Location.Y)

                        Case movingCornerTopRight
                            myForm.Width = (Cursor.Position.X - myForm.Location.X)
                            myForm.Height = ((myForm.Location.Y - Cursor.Position.Y) + myForm.Height)
                            myForm.Location = New Point(myForm.Location.X, Cursor.Position.Y)

                        Case movingCornerTopLeft
                            myForm.Width = ((myForm.Width + myForm.Location.X) - Cursor.Position.X)
                            myForm.Location = New Point(Cursor.Position.X, myForm.Location.Y)
                            myForm.Height = ((myForm.Height + myForm.Location.Y) - Cursor.Position.Y)
                            myForm.Location = New Point(myForm.Location.X, Cursor.Position.Y)

                        Case movingCornerBottomRight
                            myForm.Size = New Point((Cursor.Position.X - myForm.Location.X), (Cursor.Position.Y - myForm.Location.Y))

                        Case movingCornerBottomLeft
                            myForm.Width = ((myForm.Width + myForm.Location.X) - Cursor.Position.X)
                            myForm.Height = (Cursor.Position.Y - myForm.Location.Y)
                            myForm.Location = New Point(Cursor.Position.X, myForm.Location.Y)

                    End Select
                End Sub

                Private Shared Sub stopResizer()
                    movingRight = False
                    movingLeft = False
                    movingTop = False
                    movingBottom = False
                    movingCornerTopRight = False
                    movingCornerTopLeft = False
                    movingCornerBottomRight = False
                    movingCornerBottomLeft = False
                    myForm.Cursor = Cursors.Default
                    Threading.Thread.Sleep(300)
                    on_MinimumSize = False
                End Sub

                ''' <summary>
                ''' It simulate the resize form of the system
                ''' </summary>
                ''' <param name="panel">Set the Panel Object to add other event</param>
                ''' <param name="form">Set the form as reference for this class</param>
                ''' <param name="runCode">It needs an authentication of the one who made this function</param>
                ''' <remarks></remarks>
                Public Shared Sub addEvent(ByVal panel As Panel, ByVal form As Form, Optional ByVal runCode As String = "")
                    If runCode = "masterkey" Then
                        With form
                            AddHandler .MouseDown, AddressOf _MouseDown
                            AddHandler .MouseMove, AddressOf _MouseMove
                            AddHandler .MouseUp, AddressOf _MouseUp
                        End With
                        myForm = form
                        myPanel = panel
                    End If
                End Sub

            End Class

            ''' <summary>
            ''' This class is not intented to used for other purposes
            ''' </summary>
            ''' <remarks></remarks>
            Public Class ClickTitleButton

                Private Shared myForm As Form
                Private Shared imgMinimize As PictureBox
                Private Shared imgMaximize As PictureBox
                Private Shared imgClose As PictureBox
                Private Shared imgIcon As PictureBox
                Private Shared getThemes As myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue


                Private Shared Sub _MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                    With CType(sender, PictureBox)
                        Select Case .Name
                            Case "imgMinimize"
                                .Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.minimize, "hover", "masterkey")
                                .BackColor = myColor.Share.Converter.StringToColor.getHTMLColor(getThemes.accentColor)
                            Case "imgMaximize"
                                If myForm.WindowState = FormWindowState.Maximized Then
                                    .Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.restore, "hover", "masterkey")
                                    .BackColor = myColor.Share.Converter.StringToColor.getHTMLColor(getThemes.accentColor)
                                Else
                                    .Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.maximize, "hover", "masterkey")
                                    .BackColor = myColor.Share.Converter.StringToColor.getHTMLColor(getThemes.accentColor)
                                End If
                            Case "imgClose"
                                .BackColor = myColor.Share.Converter.StringToColor.getHTMLColor("993D3D")
                        End Select
                    End With
                End Sub

                Private Shared Sub _MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                    With CType(sender, PictureBox)
                        Select Case .Name
                            Case "imgMinimize"
                                .Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.minimize, "hover", "masterkey")
                                .BackColor = myColor.Share.Converter.StringToColor.getHTMLColor(getThemes.backgroundColor)
                            Case "imgMaximize"
                                If myForm.WindowState = FormWindowState.Maximized Then
                                    .Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.restore, "hover", "masterkey")
                                    .BackColor = myColor.Share.Converter.StringToColor.getHTMLColor(getThemes.backgroundColor)
                                Else
                                    .Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.maximize, "hover", "masterkey")
                                    .BackColor = myColor.Share.Converter.StringToColor.getHTMLColor(getThemes.backgroundColor)
                                End If
                            Case "imgClose"
                                .BackColor = myColor.Share.Converter.StringToColor.getHTMLColor("E04343")
                        End Select
                    End With
                End Sub

                Private Shared Sub _MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
                    With CType(sender, PictureBox)
                        Select Case .Name
                            Case "imgMinimize"
                                .Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.minimize, , "masterkey")
                                .BackColor = Color.Transparent
                            Case "imgMaximize"
                                If myForm.WindowState = FormWindowState.Maximized Then
                                    .Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.restore, , "masterkey")
                                    .BackColor = Color.Transparent
                                Else
                                    .Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.maximize, , "masterkey")
                                    .BackColor = Color.Transparent
                                End If
                            Case "imgClose"
                                .BackColor = myColor.Share.Converter.StringToColor.getHTMLColor("C75050")
                        End Select
                    End With
                End Sub

                Private Shared Sub _MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                    With CType(sender, PictureBox)
                        Select Case .Name
                            Case "imgMinimize"
                                .Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.minimize, , "masterkey")
                                .BackColor = Color.Transparent
                            Case "imgMaximize"
                                If myForm.WindowState = FormWindowState.Maximized Then
                                    .Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.restore, , "masterkey")
                                    .BackColor = Color.Transparent
                                Else
                                    .Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.maximize, , "masterkey")
                                    .BackColor = Color.Transparent
                                End If
                            Case "imgClose"
                                .BackColor = myColor.Share.Converter.StringToColor.getHTMLColor("C75050")
                        End Select
                    End With
                End Sub

                Private Shared Sub _MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                    With CType(sender, PictureBox)
                        Select Case .Name
                            Case "imgMinimize"
                                myForm.WindowState = FormWindowState.Minimized
                            Case "imgMaximize"
                                If myForm.WindowState = FormWindowState.Normal Then
                                    myForm.WindowState = FormWindowState.Maximized
                                    imgMaximize.Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.restore, , "masterkey")
                                    myForm.Padding = New Padding(0, 0, 0, 0)
                                Else
                                    myForm.WindowState = FormWindowState.Normal
                                    imgMaximize.Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.maximize, , "masterkey")
                                    myForm.Padding = New Padding(5, 0, 5, 5)
                                End If
                            Case "imgClose"
                                myForm.Close()
                        End Select
                    End With
                End Sub

                Private Shared Sub _StyleChanged(ByVal sender As Object, ByVal e As System.EventArgs)

                    If myForm.MinimizeBox = False And myForm.MaximizeBox = False Then
                        imgMinimize.Visible = False
                        imgMaximize.Visible = False
                    ElseIf myForm.MinimizeBox = False Then
                        imgMinimize.Enabled = False
                        imgMinimize.Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.minimize, "gray", "masterkey")
                    Else
                        imgMinimize.Visible = True
                        imgMaximize.Visible = True
                        imgMinimize.Enabled = True
                        imgMinimize.Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.minimize, , "masterkey")
                    End If

                    If myForm.MaximizeBox = False Then
                        imgMaximize.Enabled = False
                        imgMaximize.Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.maximize, "gray", "masterkey")
                    Else
                        imgMaximize.Enabled = True
                        imgMaximize.Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.maximize, , "masterkey")
                    End If

                    If myForm.ControlBox Then
                        imgMinimize.Visible = True
                        imgMaximize.Visible = True
                        imgClose.Visible = True
                        If myForm.ShowIcon Then
                            imgIcon.Visible = True
                        End If
                    Else
                        imgMinimize.Visible = False
                        imgMaximize.Visible = False
                        imgClose.Visible = False
                        imgIcon.Visible = False
                    End If

                End Sub

                ''' <summary>
                ''' It simulate the click event of the title bar such as minimize, maximize, and close button
                ''' </summary>
                ''' <param name="form">Set the form as reference of this class</param>
                ''' <param name="icon">Set the icon of the title bar</param>
                ''' <param name="minimize">Set the minimize button</param>
                ''' <param name="maximize">Set the Maximize button</param>
                ''' <param name="close">Set the Close button</param>
                ''' <param name="runCode">It needs an authentication the one who made this function</param>
                ''' <remarks></remarks>
                Public Shared Sub addEvent(ByRef form As Form, ByRef icon As PictureBox, ByRef minimize As PictureBox, ByRef maximize As PictureBox, ByRef close As PictureBox, ByRef userName As String, Optional ByVal runCode As String = "")
                    getThemes = myDocument.Share.XMLDesigner.ThemesConfig.readThemes(userName)

                    If runCode = "masterkey" Then
                        myForm = form
                        imgIcon = icon
                        AddHandler myForm.StyleChanged, AddressOf _StyleChanged

                        imgMinimize = minimize

                        If myForm.MinimizeBox = False And myForm.MaximizeBox = False Then
                            minimize.Visible = False
                            minimize.Visible = False
                        ElseIf myForm.MinimizeBox = False Then
                            minimize.Enabled = False
                            minimize.Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.minimize, "gray", "masterkey")
                        End If

                        If myForm.MaximizeBox = False Then
                            maximize.Enabled = False
                            maximize.Image = myIcons.Share.TitleBar.getIcon(myIcons.Share.TitleBar.Type.maximize, "gray", "masterkey")
                        End If

                        With minimize
                            AddHandler .MouseDown, AddressOf _MouseDown
                            AddHandler .MouseMove, AddressOf _MouseMove
                            AddHandler .MouseUp, AddressOf _MouseUp
                            AddHandler .MouseLeave, AddressOf _MouseLeave
                            AddHandler .MouseClick, AddressOf _MouseClick
                        End With
                        imgMaximize = maximize
                        With maximize
                            AddHandler .MouseDown, AddressOf _MouseDown
                            AddHandler .MouseMove, AddressOf _MouseMove
                            AddHandler .MouseUp, AddressOf _MouseUp
                            AddHandler .MouseLeave, AddressOf _MouseLeave
                            AddHandler .MouseClick, AddressOf _MouseClick
                        End With
                        imgClose = close
                        With close
                            AddHandler .MouseDown, AddressOf _MouseDown
                            AddHandler .MouseMove, AddressOf _MouseMove
                            AddHandler .MouseUp, AddressOf _MouseUp
                            AddHandler .MouseLeave, AddressOf _MouseLeave
                            AddHandler .MouseClick, AddressOf _MouseClick
                        End With

                        If myForm.ControlBox = False Then
                            imgMaximize.Visible = False
                            imgMinimize.Visible = False
                            imgClose.Visible = False
                            imgIcon.Visible = False
                        End If
                    Else
                        activationRequired("ClickTitleButton.AddEvent")
                    End If
                End Sub

            End Class

            ''' <summary>
            ''' This class is not intented to used for other purposes
            ''' </summary>
            ''' <remarks></remarks>
            Public Class ActiveWindow

                Private Declare Function GetForegroundWindow Lib "user32" Alias "GetForegroundWindow" () As IntPtr
                Private Declare Auto Function GetWindowText Lib "user32" (ByVal hWnd As System.IntPtr, ByVal lpString As System.Text.StringBuilder, ByVal cch As Integer) As Integer
                Private Shared makel As String
                Private Shared timer1 As New Timer
                Private Shared myForm As Form
                Private Shared getThemes As myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue
                Private Shared gUserName As String


                Public Enum Type
                    active
                    inactive
                End Enum

                Private Shared Function GetCaption() As String
                    Dim Caption As New System.Text.StringBuilder(256)
                    Dim hWnd As IntPtr = GetForegroundWindow()
                    GetWindowText(hWnd, Caption, Caption.Capacity)
                    Return Caption.ToString()
                End Function

                Private Shared Sub _Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
                    Dim CapTxt As String = GetCaption()
                    If makel <> CapTxt Then
                        makel = CapTxt
                        ' stop timer before showing msgbox so it is not detected!
                        timer1.Stop()
                        'MsgBox(CapTxt)
                        ' resume timer 
                        timer1.Start()

                        If CapTxt = myForm.Name Then
                            'MsgBox(CapTxt)
                            setForm(myForm, Type.active)
                        Else
                            setForm(myForm, Type.inactive)
                        End If
                    End If
                End Sub

                Public Shared Sub setForm(ByRef form As Form, ByVal type As Type, Optional ByVal userName As String = "", Optional ByVal runCode As String = "")
                    getThemes = myDocument.Share.XMLDesigner.ThemesConfig.readThemes(gUserName)

                    Dim objects As New myControls.Init.Objects
                    objects.getAllObject(form)
                    Dim imgClose As Object = objects.getObjectName("imgClose")
                    Dim pnlHeader As Object = objects.getObjectName("pnlHeader")
                    Select Case type
                        Case type.active
                            If Not imgClose Is Nothing Then CType(imgClose, PictureBox).BackColor = myColor.Share.Converter.StringToColor.getHTMLColor("C75050")
                            form.BackColor = myColor.Share.Converter.StringToColor.getHTMLColor(getThemes.form_borderColor)
                            If Not pnlHeader Is Nothing Then CType(pnlHeader, Panel).BackColor = myColor.Share.Converter.StringToColor.getHTMLColor(getThemes.form_borderColor)
                        Case type.inactive
                            If Not imgClose Is Nothing Then CType(imgClose, PictureBox).BackColor = myColor.Share.Converter.StringToColor.getHTMLColor("BCBCBC")
                            form.BackColor = myColor.Share.Converter.StringToColor.getHTMLColor("EBEBEB")
                            If Not pnlHeader Is Nothing Then CType(pnlHeader, Panel).BackColor = myColor.Share.Converter.StringToColor.getHTMLColor("EBEBEB")
                    End Select
                End Sub

                ''' <summary>
                ''' It simulate the active or inactive windows
                ''' </summary>
                ''' <param name="timer">Set the timer to process the event</param>
                ''' <param name="form">Set the form as reference to this class</param>
                ''' <remarks></remarks>
                Public Shared Sub addEvent(ByRef timer As Timer, ByRef form As Form, ByVal userName As String, Optional ByVal runCode As String = "")
                    getThemes = myDocument.Share.XMLDesigner.ThemesConfig.readThemes(userName)
                    gUserName = userName
                    If runCode = "masterkey" Then
                        timer1 = timer
                        myForm = form
                        timer.Interval = 50
                        AddHandler timer.Tick, AddressOf _Tick
                        timer1.Start()
                    Else
                        activationRequired("ActiveWindow.AddEvent")
                    End If
                End Sub

            End Class

        End Namespace

        Public Class Buttons
            Private Shared Move As Boolean = True
            Private Shared Leave As Boolean = True
            Private Shared getThemes As New myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue

            Private Shared Sub _MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                If sender.enabled Then
                    If sender.FlatStyle <> FlatStyle.Flat Then sender.backcolor = Color.White
                    sender.forecolor = getHTMLColor(getThemes.backgroundColor)
                    sender.refresh()
                    If TypeOf sender Is My8Button Then
                        With CType(sender, My8Button)

                        End With

                    End If
                End If
            End Sub

            Private Shared Sub _MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
                If sender.enabled Then
                    Move = True
                    If Leave Then
                        myVisualEffects.ColorFadeEffects.AddEffects(sender, "BackColor", myColor.Share.Tools.Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sBUTTON), getHTMLColor(getThemes.backgroundColor), 25, getHTMLColor(getThemes.backgroundColor), 25, 10)
                    End If
                    sender.cursor = Cursors.Default
                    sender.forecolor = Color.White
                End If
            End Sub

            Private Shared Sub _MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                If sender.enabled Then
                    sender.cursor = Cursors.Hand
                    'sender.backcolor = getHTMLColor(getThemes.accentColor)
                    sender.forecolor = Color.White
                    If Move Then
                        Leave = True
                        Move = False
                        myVisualEffects.ColorFadeEffects.AddEffects(sender, "BackColor", getHTMLColor(getThemes.backgroundColor), myColor.Share.Tools.Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sBUTTON), 25, myColor.Share.Tools.Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sBUTTON), 25, 10)
                        'Visual.FadeColor(Button7, "BackColor", Color.White, Color.Blue, 25, Color.Blue, 25, 10)
                    End If
                End If
            End Sub

            Private Shared Sub _MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                If sender.enabled Then
                    If sender.FlatStyle <> FlatStyle.Flat Then sender.backcolor = myColor.Share.Tools.Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sBUTTON)
                    sender.forecolor = Color.White
                    'sender.invalidate()
                End If
            End Sub

            Private Shared Sub _EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs)
                If sender.enabled Then
                    sender.backcolor = getHTMLColor(getThemes.backgroundColor)
                Else
                    Dim d As New myColor.Share.SystemColor.BackgroundColor.StandardColor
                    d.getDefaultColor(myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Disabled)
                    sender.BackColor = d.gBackColor
                    sender.ForeColor = d.gForeColor
                End If
            End Sub

            Public Shared Sub AddEvent(ByRef obj As Object, ByRef getTheme As myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue, Optional ByVal runCode As String = "")
                getThemes = getTheme
                If TypeOf obj Is PowerNET8.My8Button Then
                    'Do code here
                    With CType(obj, My8Button)
                        .BackColor = getHTMLColor(getThemes.backgroundColor)
                        .ForeColor = Color.White
                        With .FlatAppearance
                            .MouseDownBackColor = Color.White
                            .MouseOverBackColor = myColor.Share.Tools.Brightness.Apply(getHTMLColor(getTheme.backgroundColor), sBUTTON)
                        End With
                        .MousePressedForeColor = getHTMLColor(getThemes.backgroundColor)

                        AddHandler .MouseDown, AddressOf _MouseDown
                        AddHandler .MouseUp, AddressOf _MouseUp
                    End With
                ElseIf TypeOf obj Is Button Then

                    With CType(obj, Button)
                        If .FlatStyle = FlatStyle.Flat Then
                            .BackColor = getHTMLColor(getThemes.backgroundColor)
                            .ForeColor = Color.White
                            With .FlatAppearance
                                .BorderSize = 1
                                .BorderColor = Color.White
                                .MouseDownBackColor = Color.White
                                .MouseOverBackColor = myColor.Share.Tools.Brightness.Apply(getHTMLColor(getTheme.backgroundColor), sBUTTON)

                            End With
                            AddHandler .MouseDown, AddressOf _MouseDown
                            AddHandler .MouseUp, AddressOf _MouseUp
                        Else
                            .BackColor = getHTMLColor(getThemes.backgroundColor)
                            .ForeColor = Color.White
                            AddHandler .MouseMove, AddressOf _MouseMove
                            AddHandler .MouseLeave, AddressOf _MouseLeave
                            AddHandler .MouseUp, AddressOf _MouseUp
                            AddHandler .MouseDown, AddressOf _MouseDown
                            AddHandler .EnabledChanged, AddressOf _EnabledChanged
                        End If
                    End With
                End If
            End Sub

        End Class

        ''' <summary>
        ''' This class is not used for other purposes.
        ''' </summary>
        ''' <remarks></remarks>
        Public Class Text

            Private Shared getThemes As New myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue

            Private Shared Sub EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs)
                If sender.enabled Then
                    sender.backcolor = getHTMLColor(getThemes.text_lostFocusBackColor)
                    sender.forecolor = getHTMLColor(getThemes.text_lostFocusForeColor)
                Else
                    sender.backcolor = getHTMLColor(getThemes.text_readOnlyBackColor)
                    sender.forecolor = getHTMLColor(getThemes.text_readOnlyForeColor)
                End If
            End Sub

            Private Shared Sub GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
                Dim GotFocus As Color = Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sALTERNATE)
                Dim lostFocus As Color = Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sDEFAULT)

                If Not TypeOf sender Is ComboBox And Not TypeOf sender Is ListBox And Not TypeOf sender Is CheckedListBox Then
                    If sender.readonly = False Then
                        'sender.backcolor = getHTMLColor(getThemes.text_focusBackColor)
                        sender.forecolor = Color.Black
                        myVisualEffects.ColorFadeEffects.AddEffects(sender, "BackColor", LostFocus, GotFocus, 25, GotFocus, 25, 15)
                    End If
                Else
                    sender.backcolor = GotFocus
                    'myVisualEffects.ColorFadeEffects.AddEffects(sender, "BackColor", getHTMLColor(getThemes.text_lostFocusBackColor), getHTMLColor(getThemes.text_focusBackColor), 25, getHTMLColor(getThemes.text_focusBackColor), 25, 15)
                    sender.forecolor = Color.Black
                End If
            End Sub

            Private Shared Sub KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
                If e.KeyCode = Keys.ControlKey + Keys.A Then
                    sender.SelectAll()
                End If
            End Sub

            Private Shared Sub LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
                Dim GotFocus As Color = Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sALTERNATE)
                Dim lostFocus As Color = Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sDEFAULT)
                If Not TypeOf sender Is ComboBox And Not TypeOf sender Is ListBox And Not TypeOf sender Is CheckedListBox Then
                    If sender.readonly = False Then
                        'sender.backcolor = getHTMLColor(getThemes.text_lostFocusBackColor)
                        sender.forecolor = getHTMLColor(getThemes.text_lostFocusForeColor)
                        myVisualEffects.ColorFadeEffects.AddEffects(sender, "BackColor", GotFocus, LostFocus, 25, LostFocus, 25, 20)
                    End If
                Else
                    sender.backcolor = lostFocus
                    'myVisualEffects.ColorFadeEffects.AddEffects(sender, "BackColor", getHTMLColor(getThemes.text_focusBackColor), getHTMLColor(getThemes.text_lostFocusBackColor), 25, getHTMLColor(getThemes.text_lostFocusBackColor), 25, 20)
                    sender.forecolor = Color.Black
                End If
            End Sub

            Private Shared Sub ReadOnlyChanged(ByVal sender As Object, ByVal e As System.EventArgs)
                If sender.readonly Then
                    sender.backcolor = getHTMLColor(cdisBACKCOLOR)
                    sender.forecolor = getHTMLColor(cdisFORECOLOR)
                Else
                    Dim lostFocus As Color = Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sDEFAULT)
                    sender.backcolor = lostFocus
                    sender.forecolor = Color.Black
                End If
            End Sub

            Public Shared Sub AddEvent(ByRef obj As Object, ByRef getTheme As myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue, Optional ByVal runCode As String = "")
                Dim lostFocuses As Color = Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sDEFAULT)
                If runCode = "masterkey" Then
                    getThemes = getTheme
                    If TypeOf obj Is TextBox Then
                        With CType(obj, TextBox)
                            .BackColor = lostFocuses
                            .ForeColor = Color.Black
                            AddHandler .GotFocus, AddressOf GotFocus
                            AddHandler .LostFocus, AddressOf LostFocus
                            AddHandler .ReadOnlyChanged, AddressOf ReadOnlyChanged
                            AddHandler .KeyDown, AddressOf KeyDown
                            If .ReadOnly Then
                                .BackColor = getHTMLColor(cdisBACKCOLOR)
                                .ForeColor = getHTMLColor(cdisFORECOLOR)
                            End If
                        End With
                    ElseIf TypeOf obj Is DomainUpDown Then
                        With CType(obj, DomainUpDown)
                            .BackColor = lostFocuses
                            .ForeColor = Color.Black
                            AddHandler .GotFocus, AddressOf GotFocus
                            AddHandler .LostFocus, AddressOf LostFocus
                            AddHandler .KeyDown, AddressOf KeyDown
                            AddHandler .EnabledChanged, AddressOf EnabledChanged
                            If .ReadOnly Then
                                .BackColor = getHTMLColor(cdisBACKCOLOR)
                                .ForeColor = getHTMLColor(cdisFORECOLOR)
                            End If
                        End With
                    ElseIf TypeOf obj Is MaskedTextBox Then
                        With CType(obj, MaskedTextBox)
                            .BackColor = lostFocuses
                            .ForeColor = Color.Black
                            AddHandler .GotFocus, AddressOf GotFocus
                            AddHandler .LostFocus, AddressOf LostFocus
                            AddHandler .ReadOnlyChanged, AddressOf ReadOnlyChanged
                            AddHandler .KeyDown, AddressOf KeyDown
                            If .ReadOnly Then
                                .BackColor = getHTMLColor(cdisBACKCOLOR)
                                .ForeColor = getHTMLColor(cdisFORECOLOR)
                            End If
                        End With
                    ElseIf TypeOf obj Is ComboBox Then
                        With CType(obj, ComboBox)
                            .BackColor = lostFocuses
                            .ForeColor = Color.Black
                            AddHandler .GotFocus, AddressOf GotFocus
                            AddHandler .LostFocus, AddressOf LostFocus
                            AddHandler .KeyDown, AddressOf KeyDown
                            AddHandler .EnabledChanged, AddressOf EnabledChanged
                            If .Enabled = False Then
                                .BackColor = getHTMLColor(cdisBACKCOLOR)
                                .ForeColor = getHTMLColor(cdisFORECOLOR)
                            End If
                        End With
                    ElseIf TypeOf obj Is ListBox Then
                        With CType(obj, ListBox)
                            .BackColor = lostFocuses
                            .ForeColor = Color.Black
                            AddHandler .GotFocus, AddressOf GotFocus
                            AddHandler .LostFocus, AddressOf LostFocus
                            AddHandler .KeyDown, AddressOf KeyDown
                            AddHandler .EnabledChanged, AddressOf EnabledChanged
                            If .Enabled = False Then
                                .BackColor = getHTMLColor(cdisBACKCOLOR)
                                .ForeColor = getHTMLColor(cdisFORECOLOR)
                            End If
                        End With
                    ElseIf TypeOf obj Is CheckedListBox Then
                        With CType(obj, CheckedListBox)
                            .BackColor = lostFocuses
                            .ForeColor = Color.Black
                            AddHandler .GotFocus, AddressOf GotFocus
                            AddHandler .LostFocus, AddressOf LostFocus
                            AddHandler .KeyDown, AddressOf KeyDown
                            AddHandler .EnabledChanged, AddressOf EnabledChanged
                            If .Enabled = False Then
                                .BackColor = getHTMLColor(cdisBACKCOLOR)
                                .ForeColor = getHTMLColor(cdisFORECOLOR)
                            End If
                        End With
                    ElseIf TypeOf obj Is RichTextBox Then
                        With CType(obj, RichTextBox)
                            .BackColor = lostFocuses
                            .ForeColor = Color.Black
                            AddHandler .GotFocus, AddressOf GotFocus
                            AddHandler .LostFocus, AddressOf LostFocus
                            AddHandler .ReadOnlyChanged, AddressOf ReadOnlyChanged
                            AddHandler .KeyDown, AddressOf KeyDown
                            If .ReadOnly Then
                                .BackColor = getHTMLColor(cdisBACKCOLOR)
                                .ForeColor = getHTMLColor(cdisFORECOLOR)
                            End If
                        End With
                    ElseIf TypeOf obj Is NumericUpDown Then
                        With CType(obj, NumericUpDown)
                            .BackColor = lostFocuses
                            .ForeColor = Color.Black
                            AddHandler .GotFocus, AddressOf GotFocus
                            AddHandler .LostFocus, AddressOf LostFocus
                            AddHandler .EnabledChanged, AddressOf EnabledChanged
                            AddHandler .KeyDown, AddressOf KeyDown
                            If .ReadOnly Then
                                .BackColor = getHTMLColor(cdisBACKCOLOR)
                                .ForeColor = getHTMLColor(cdisFORECOLOR)
                            End If
                        End With
                    End If
                Else
                    activationRequired("Text.TextBoxes")
                End If
            End Sub

        End Class

        Public Class Checks
            Private Shared getThemes As New myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue
            Private Shared timer As New Timer

            Private Shared Sub MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
                If TypeOf sender Is CheckBox Then
                    With CType(sender, CheckBox)
                        Dim oldFont As Font = New Font(.Font.FontFamily, .Font.Size, FontStyle.Regular, .Font.Unit)
                        .Cursor = Cursors.Default
                        .Font = oldFont
                    End With
                ElseIf TypeOf sender Is RadioButton Then
                    With CType(sender, RadioButton)
                        Dim oldFont As Font = New Font(.Font.FontFamily, .Font.Size, FontStyle.Regular, .Font.Unit)
                        .Cursor = Cursors.Default
                        .Font = oldFont
                    End With
                End If

            End Sub

            Private Shared Sub MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

                If TypeOf sender Is CheckBox Then
                    With CType(sender, CheckBox)
                        Dim oldFont As Font = New Font(.Font.FontFamily, .Font.Size, FontStyle.Underline, .Font.Unit)
                        .Cursor = Cursors.Hand
                        .Font = oldFont
                    End With
                ElseIf TypeOf sender Is RadioButton Then
                    With CType(sender, RadioButton)
                        Dim oldFont As Font = New Font(.Font.FontFamily, .Font.Size, FontStyle.Underline, .Font.Unit)
                        .Cursor = Cursors.Hand
                        .Font = oldFont
                    End With

                End If

            End Sub

            Private Shared Sub MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                If TypeOf sender Is CheckBox Then
                    With CType(sender, CheckBox)
                        Dim oldFont As Font = New Font(.Font.FontFamily, .Font.Size - 1, FontStyle.Underline, .Font.Unit)
                        .Cursor = Cursors.Hand
                        .Font = oldFont
                    End With
                ElseIf TypeOf sender Is RadioButton Then
                    With CType(sender, RadioButton)
                        Dim oldFont As Font = New Font(.Font.FontFamily, .Font.Size - 1, FontStyle.Underline, .Font.Unit)
                        .Cursor = Cursors.Hand
                        .Font = oldFont
                    End With

                End If
            End Sub

            Private Shared Sub MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                If TypeOf sender Is CheckBox Then
                    With CType(sender, CheckBox)
                        Dim oldFont As Font = New Font(.Font.FontFamily, .Font.Size + 1, FontStyle.Underline, .Font.Unit)
                        .Cursor = Cursors.Hand
                        .Font = oldFont
                    End With
                ElseIf TypeOf sender Is RadioButton Then
                    With CType(sender, RadioButton)
                        Dim oldFont As Font = New Font(.Font.FontFamily, .Font.Size + 1, FontStyle.Underline, .Font.Unit)
                        .Cursor = Cursors.Hand
                        .Font = oldFont
                    End With

                End If
            End Sub

            Public Shared Sub AddEvent(ByRef obj As Object, ByRef getTheme As myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue, Optional ByVal runCode As String = "")
                If runCode = "masterkey" Then
                    getThemes = getTheme
                    If TypeOf obj Is CheckBox Then
                        With CType(obj, CheckBox)
                            .ForeColor = getHTMLColor(getTheme.text_forecolor)
                            AddHandler .MouseMove, AddressOf MouseMove
                            AddHandler .MouseLeave, AddressOf MouseLeave
                            AddHandler .MouseDown, AddressOf MouseDown
                            AddHandler .MouseUp, AddressOf MouseUp
                        End With
                    ElseIf TypeOf obj Is RadioButton Then
                        With CType(obj, RadioButton)
                            .ForeColor = getHTMLColor(getTheme.text_forecolor)
                            AddHandler .MouseMove, AddressOf MouseMove
                            AddHandler .MouseLeave, AddressOf MouseLeave
                            AddHandler .MouseDown, AddressOf MouseDown
                            AddHandler .MouseUp, AddressOf MouseUp
                        End With
                    End If
                Else
                    activationRequired("Checks.AddEvent")
                End If
            End Sub

        End Class

        Public Class Comboboxes
            Private Shared getThemes As New myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue

            Public Class SearchFilter

                Public Shared Sub AddEvent(ByRef obj As Object, Optional ByVal runCode As String = "")
                    If runCode = "masterkey" Then
                        If TypeOf obj Is ComboBox Then
                            With CType(obj, ComboBox)
                                AddHandler .Leave, AddressOf Leave
                                AddHandler .KeyUp, AddressOf KeyUp
                            End With

                        End If
                    Else
                        activationRequired("Combobox.AddEvent")
                    End If
                End Sub

                Private Shared Sub KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
                    AutoCompleteCombo_KeyUp(sender, e)
                End Sub

                Private Shared Sub Leave(ByVal sender As Object, ByVal e As System.EventArgs)
                    AutoCompleteCombo_Leave(sender)
                End Sub

                Private Shared Sub AutoCompleteCombo_KeyUp(ByVal cbo As Windows.Forms.ComboBox, ByVal e As KeyEventArgs)
                    Dim sTypedText As String
                    Dim iFoundIndex As Integer
                    Dim oFoundItem As Object
                    Dim sFoundText As String
                    Dim sAppendText As String

                    'Allow select keys without Autocompleting
                    Select Case e.KeyCode
                        Case Keys.Back, Keys.Left, Keys.Right, Keys.Up, Keys.Delete, Keys.Down
                            Return
                    End Select

                    'Get the Typed Text and Find it in the list
                    sTypedText = cbo.Text
                    iFoundIndex = cbo.FindString(sTypedText)

                    'If we found the Typed Text in the list then Autocomplete
                    If iFoundIndex >= 0 Then

                        'Get the Item from the list (Return Type depends if Datasource was bound 
                        ' or List Created)
                        oFoundItem = cbo.Items(iFoundIndex)

                        'Use the ListControl.GetItemText to resolve the Name in case the Combo 
                        ' was Data bound
                        sFoundText = cbo.GetItemText(oFoundItem)

                        'Append then found text to the typed text to preserve case
                        sAppendText = sFoundText.Substring(sTypedText.Length)
                        cbo.Text = sTypedText & sAppendText

                        'Select the Appended Text
                        cbo.SelectionStart = sTypedText.Length
                        cbo.SelectionLength = sAppendText.Length

                    End If

                End Sub

                Private Shared Sub AutoCompleteCombo_Leave(ByVal cbo As Windows.Forms.ComboBox)
                    Dim iFoundIndex As Integer
                    iFoundIndex = cbo.FindStringExact(cbo.Text)
                    cbo.SelectedIndex = iFoundIndex
                End Sub

            End Class

        End Class

        Public Class DatagridViews
            Private Shared getThemes As New myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue

            Private Shared Sub RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs)
                'If sender Is Nothing OrElse e Is Nothing Then Return
                Using b As SolidBrush = New SolidBrush(Color.Black)
                    e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), _
                                          sender.DefaultCellStyle.Font, _
                                           b, _
                                           e.RowBounds.Location.X + 15, _
                                           e.RowBounds.Location.Y + 4)
                End Using
            End Sub

            Private Shared Sub RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs)
                'get the row number in leading zero format, 
                'where the width of the number = the width of the maximum number 
                Dim RowNumWidth As Integer = sender.RowCount.ToString().Length
                Dim RowNumber As String = RowNumWidth.ToString
                RowNumber += " " + (e.RowIndex + 1).ToString
                'While RowNumber.Length < RowNumWidth
                '    RowNumber.Insert(0, " ")
                'End While

                ''get the size of the row number string 
                Dim Sz As SizeF = e.Graphics.MeasureString(RowNumber.ToString(), sender.Font)

                ''adjust the width of the column that contains the row header cells 
                If sender.RowHeadersWidth < CInt((Sz.Width + 20)) Then
                    sender.RowHeadersWidth = CInt((Sz.Width + 20))
                End If

                'draw the row number 
                'e.Graphics.DrawString(RowNumber.ToString(), sender.Font, SystemBrushes.ControlText, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - Sz.Height) / 2))

            End Sub

            Public Shared Sub AddEvent(ByRef obj As Object, ByRef getTheme As myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue, Optional ByVal runCode As String = "")
                If runCode = "masterkey" Then
                    getThemes = getTheme
                    Dim Color As Color = getHTMLColor(getThemes.backgroundColor)
                    Dim aCOlor As Color = getHTMLColor(getThemes.accentColor)
                    If TypeOf obj Is DataGridView Then
                        With CType(obj, DataGridView)

                            .BorderStyle = BorderStyle.None
                            .GridColor = Drawing.Color.White

                            .BackgroundColor = ControlPaint.Light(Color, sBACKCOLOR)

                            .DefaultCellStyle.BackColor = Drawing.Color.White
                            .AlternatingRowsDefaultCellStyle.BackColor = ControlPaint.Light(aCOlor, sALTERNATE)

                            'DataGridView1.GridColor = ControlPaint.Light(b, txtAlternate.Text)
                            .DefaultCellStyle.SelectionBackColor = aCOlor
                            .DefaultCellStyle.SelectionForeColor = Drawing.Color.White

                            .AlternatingRowsDefaultCellStyle.SelectionBackColor = aCOlor
                            .AlternatingRowsDefaultCellStyle.SelectionForeColor = Drawing.Color.White

                            For i As Integer = 0 To .ColumnCount - 1
                                If .Columns(i).ReadOnly Then
                                    .Columns(i).DefaultCellStyle.BackColor = ControlPaint.Light(aCOlor, sALTERNATE)
                                End If
                           
                            Next

                            AddHandler .RowPostPaint, AddressOf RowPostPaint
                            AddHandler .RowPrePaint, AddressOf RowPrePaint
                        End With
                    End If

                Else
                    activationRequired("Datagridviews.AddEvent")
                End If
            End Sub

        End Class

        Public Class Panels

            Private Shared getThemes As New myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue
            Private Shared sources_Form As Form
            'Mouse move event of the FORM
            Private Shared X_axis As Integer
            Private Shared y_axis As Integer
            Private Shared Move_Form As Boolean = False

            Public Shared Sub AddEvent(ByRef obj As Object, ByRef getTheme As myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue, Optional ByVal runCode As String = "")
                If runCode = "masterkey" Then
                    getThemes = getTheme
                    With CType(obj, Panel)

                        If .Name = "pnlContent" Then
                            Dim bc As Color = Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sCONTENT)
                            .BackColor = bc
                        Else
                            Dim parentobj As Object = CType(obj, Panel).Parent
                            Dim name As String = CallByName(parentobj, "Name", CallType.Get)

                            If name.ToLower.Contains("pnl") Or name.ToLower.Contains("panel") Then
                                If name <> "pnlHeader" Then
                                    Try
                                        Dim pC As Color = Darkness.Apply(parentobj.backcolor, 0.0001)
                                        CType(obj, Panel).BackColor = pC
                                        CType(obj, Panel).ForeColor = Color.White
                                    Catch ex As Exception
                                        myExceptionHandler.OnThreadException(ex, "Wrong object set.")
                                    End Try
                                End If
                            Else
                                If .Name <> "pnlHeader" Then
                                    Dim bc As Color = Brightness.Apply(getHTMLColor(getThemes.accentColor), 1)
                                    obj.backcolor = bc
                                End If
                            End If
                        End If
                    End With

                Else
                    activationRequired("Datagridviews.AddEvent")
                End If
            End Sub

            Public Shared Sub MoveForms(ByRef frm As Form, ByRef panel As Panel)
                sources_Form = frm
                With panel
                    AddHandler panel.MouseDown, AddressOf MoveForm_MouseDown
                    AddHandler panel.MouseMove, AddressOf MoveForm_MouseMove
                    AddHandler panel.MouseUp, AddressOf MoveForm_MouseUp
                End With
            End Sub

            Private Shared Sub MoveForm_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                Move_Form = False
            End Sub

            Private Shared Sub MoveForm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                If e.Button = MouseButtons.Left Then
                    Move_Form = True
                    X_axis = e.X
                    y_axis = e.Y
                    'sender.Cursor = Cursors.SizeAll
                End If
                If CType(sources_Form, Form).Cursor = Cursors.SizeAll Then
                    CType(sources_Form, Form).Cursor = Cursors.Default
                End If
            End Sub

            Private Shared Sub MoveForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                If Move_Form Then
                    Dim pt As New Point(e.X - X_axis, e.Y - y_axis)
                    CType(sources_Form, Form).Left += pt.X
                    CType(sources_Form, Form).Top += pt.Y
                End If
            End Sub

        End Class

        Public Class Toolstrips

            Private Shared getThemes As New myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue

            Private Shared Sub MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)

            End Sub

            Private Shared Sub MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

            End Sub

            Private Shared Sub GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
                Dim GotFocus As Color = Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sALTERNATE)
                Dim lostFocus As Color = Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sDEFAULT)

                If TypeOf sender Is ToolStripTextBox Then
                    If sender.readonly = False Then
                        'sender.backcolor = getHTMLColor(getThemes.text_focusBackColor)
                        sender.forecolor = Color.Black
                        myVisualEffects.ColorFadeEffects.AddEffects(sender, "BackColor", lostFocus, GotFocus, 25, GotFocus, 25, 15)
                    End If
                Else
                    sender.backcolor = GotFocus
                    'myVisualEffects.ColorFadeEffects.AddEffects(sender, "BackColor", getHTMLColor(getThemes.text_lostFocusBackColor), getHTMLColor(getThemes.text_focusBackColor), 25, getHTMLColor(getThemes.text_focusBackColor), 25, 15)
                    sender.forecolor = Color.Black
                End If
            End Sub

            Private Shared Sub LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
                Dim GotFocus As Color = Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sALTERNATE)
                Dim lostFocus As Color = Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sDEFAULT)
                If TypeOf sender Is ToolStripTextBox Then
                    If sender.readonly = False Then
                        'sender.backcolor = getHTMLColor(getThemes.text_lostFocusBackColor)
                        sender.forecolor = getHTMLColor(getThemes.text_lostFocusForeColor)
                        myVisualEffects.ColorFadeEffects.AddEffects(sender, "BackColor", GotFocus, lostFocus, 25, lostFocus, 25, 20)
                    End If
                Else
                    sender.backcolor = lostFocus
                    'myVisualEffects.ColorFadeEffects.AddEffects(sender, "BackColor", getHTMLColor(getThemes.text_focusBackColor), getHTMLColor(getThemes.text_lostFocusBackColor), 25, getHTMLColor(getThemes.text_lostFocusBackColor), 25, 20)
                    sender.forecolor = Color.Black
                End If
            End Sub

            Private Shared Sub subDistributeEvents(ByRef obj As Object)
                If TypeOf obj Is ToolStripDropDownButton Then
                    For i As Integer = 0 To CType(obj, ToolStripDropDownButton).DropDownItems.Count - 1

                        Dim o As Object = CType(obj, ToolStripDropDownButton).DropDownItems(i)
                        'myPicture.ui_Icons(o, ui_icon_normal, 24, 24)


                        If TypeOf o Is ToolStripMenuItem Then
                            If CType(o, ToolStripMenuItem).HasDropDownItems Then

                                AddHandler CType(o, ToolStripMenuItem).MouseMove, AddressOf MouseMove
                                AddHandler CType(o, ToolStripMenuItem).MouseLeave, AddressOf MouseLeave

                                subDistributeEvents(o)

                            End If
                        End If

                    Next
                ElseIf TypeOf obj Is ToolStripSplitButton Then
                    For i As Integer = 0 To CType(obj, ToolStripSplitButton).DropDownItems.Count - 1
                        Dim o As ToolStripMenuItem = CType(obj, ToolStripSplitButton).DropDownItems(i)
                        'myPicture.ui_Icons(o, ui_icon_normal, 24, 24)

                        AddHandler o.MouseMove, AddressOf MouseMove
                        AddHandler o.MouseLeave, AddressOf MouseLeave

                        If CType(o, ToolStripMenuItem).HasDropDownItems Then
                            subDistributeEvents(o)
                        End If
                    Next
                ElseIf TypeOf obj Is ToolStripMenuItem Then
                    For i As Integer = 0 To CType(obj, ToolStripMenuItem).DropDownItems.Count - 1
                        Dim o As Object = CType(obj, ToolStripMenuItem).DropDownItems(i)

                        If TypeOf o Is ToolStripComboBox Then
                            Dim oo As ToolStripComboBox = o
                            'myPicture.ui_Icons(oo, ui_icon_normal, 24, 24)
                            'oo.BackColor = ColorPicker(ui_textbox_normal, PickStyle.backColor)
                            'oo.ForeColor = ColorPicker(ui_textbox_normal, PickStyle.fontColor)
                            AddHandler oo.GotFocus, AddressOf GotFocus
                            AddHandler oo.LostFocus, AddressOf LostFocus

                        ElseIf TypeOf o Is ToolStripMenuItem Then
                            Dim oo As ToolStripMenuItem = o
                            'myPicture.ui_Icons(o, ui_icon_normal, 24, 24)

                            AddHandler oo.MouseMove, AddressOf MouseMove
                            AddHandler oo.MouseLeave, AddressOf MouseLeave

                            If CType(o, ToolStripMenuItem).HasDropDownItems Then
                                subDistributeEvents(o)
                            End If
                        ElseIf TypeOf o Is ToolStripTextBox Then
                            Dim oo As ToolStripTextBox = o
                            'myPicture.ui_Icons(oo, ui_icon_normal, 24, 24)
                            'oo.BackColor = ColorPicker(ui_textbox_normal, PickStyle.backColor)
                            'oo.ForeColor = ColorPicker(ui_textbox_normal, PickStyle.fontColor)
                            AddHandler oo.GotFocus, AddressOf GotFocus
                            AddHandler oo.LostFocus, AddressOf LostFocus
                        End If
                    Next
                End If

            End Sub

            Public Shared Sub AddEvent(ByRef obj As Object, ByRef getTheme As myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue, Optional ByVal runCode As String = "")
                If runCode = "masterkey" Then
                    getThemes = getTheme
                    Dim Color As Color = getHTMLColor(getThemes.backgroundColor)
                    Dim aCOlor As Color = getHTMLColor(getThemes.accentColor)

                    CType(obj, ToolStrip).BackColor = Brightness.Apply(Color, 0.55)

                    getThemes = getTheme
                    Dim myRenderer As New myControls.Init.toolStripRenderer

                    With myRenderer

                        '.separatorBarColor = getHTMLColor(getThemes.backgroundColor)
                        .OutColorButton = Brightness.Apply(Color, sTOOLSTRIP)
                        .select_border_color = Drawing.Color.White
                        .select_bottom1 = aCOlor
                        .select_bottom2 = aCOlor
                        .select_font_color = Drawing.Color.White
                        .select_top1 = aCOlor
                        .select_top2 = aCOlor
                        '._My_Selection_Style_Custom_Select_Has_Border = True

                        .unselect_border_color = Drawing.Color.White
                        .unselect_bottom1 = myColor.Share.Tools.Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sMENUSTRIP)
                        .unselect_bottom2 = myColor.Share.Tools.Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sMENUSTRIP)
                        .unselect_top1 = myColor.Share.Tools.Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sMENUSTRIP)
                        .unselect_top2 = myColor.Share.Tools.Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sMENUSTRIP)
                        .unselect_font_color = Drawing.Color.White
                        .SelectionStyle = myControls.Init.contextMenuStripRenderer.SelectStyleType.Custom_Select_and_Unselect

                        .assign_colors()

                    End With
                    With CType(obj, ToolStrip)
                        .BackColor = Brightness.Apply(Color, sTOOLSTRIP)
                        '.RenderMode = ToolStripRenderMode.Custom
                        .Renderer = myRenderer
                    End With

                    For i As Integer = 0 To CType(obj, ToolStrip).Items.Count - 1
                        'myPicture.ui_Icons(CType(obj, ToolStrip).Items(i), ui_icon_normal, CType(obj, ToolStrip).Items(i).Width, CType(obj, ToolStrip).Items(i).Height)

                        Dim ob As Object = CType(obj, ToolStrip).Items(i)

                        If TypeOf ob Is ToolStripSplitButton Then
                            Dim o As ToolStripSplitButton = ob
                            'AddHandler o.MouseMove, AddressOf ToolStrip_MouseMove
                            'AddHandler o.MouseLeave, AddressOf ToolStrip_MouseLeave
                            If CType(ob, ToolStripSplitButton).HasDropDownItems Then
                                subDistributeEvents(ob)
                            End If
                        ElseIf TypeOf ob Is ToolStripDropDownButton Then
                            Dim o As ToolStripDropDownButton = ob
                            'AddHandler o.MouseMove, AddressOf ToolStrip_MouseMove
                            'AddHandler o.MouseLeave, AddressOf ToolStrip_MouseLeave
                            If CType(ob, ToolStripDropDownButton).HasDropDownItems Then
                                subDistributeEvents(ob)
                            End If
                        ElseIf TypeOf ob Is ToolStripButton Then
                            Dim o As ToolStripButton = ob
                            AddHandler o.MouseMove, AddressOf MouseMove
                            AddHandler o.MouseLeave, AddressOf MouseLeave
                        ElseIf TypeOf ob Is ToolStripTextBox Then
                            Dim o As ToolStripTextBox = ob
                            'o.ForeColor = ColorPicker(ui_textbox_normal, PickStyle.fontColor)
                            'o.BackColor = ColorPicker(ui_textbox_normal, PickStyle.backColor)
                            AddHandler o.GotFocus, AddressOf GotFocus
                            AddHandler o.LostFocus, AddressOf LostFocus
                        ElseIf TypeOf ob Is ToolStripComboBox Then
                            Dim o As ToolStripComboBox = ob
                            'o.ForeColor = ColorPicker(ui_textbox_normal, PickStyle.fontColor)
                            'o.BackColor = ColorPicker(ui_textbox_normal, PickStyle.backColor)
                            AddHandler o.GotFocus, AddressOf GotFocus
                            AddHandler o.LostFocus, AddressOf LostFocus
                        ElseIf TypeOf ob Is ToolStripLabel Then
                            With CType(ob, ToolStripLabel)
                                If Not .Tag Is Nothing Then
                                    If .Tag <> "custom" Then
                                        '.ForeColor = ColorPicker(ui_label_normal, PickStyle.fontColor)
                                    End If
                                Else
                                    ' .ForeColor = ColorPicker(ui_label_normal, PickStyle.fontColor)
                                End If
                            End With
                        End If
                    Next

                Else
                    activationRequired("Toolstrips.AddEvent")
                End If

            End Sub

        End Class

        Public Class MenuStrips

            Private Shared getThemes As New myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue

            Private Shared Sub MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                If TypeOf sender Is ToolStripMenuItem Then
                    With CType(sender, ToolStripMenuItem)
                        Dim oldFont As Font = New Font(.Font.FontFamily, .Font.Size - 1, FontStyle.Regular, .Font.Unit)
                        '.Font = oldFont
                    End With
                End If
            End Sub

            Private Shared Sub MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                If TypeOf sender Is ToolStripMenuItem Then
                    With CType(sender, ToolStripMenuItem)
                        Dim oldFont As Font = New Font(.Font.FontFamily, .Font.Size + 1, FontStyle.Regular, .Font.Unit)
                        '.Font = oldFont
                    End With
                End If
            End Sub

            Private Shared Sub MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)

            End Sub

            Private Shared Sub MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

            End Sub

            Private Shared Sub GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
                Dim GotFocus As Color = Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sALTERNATE)
                Dim lostFocus As Color = Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sDEFAULT)

                If TypeOf sender Is ToolStripTextBox Then
                    If sender.readonly = False Then
                        'sender.backcolor = getHTMLColor(getThemes.text_focusBackColor)
                        sender.forecolor = Color.Black
                        myVisualEffects.ColorFadeEffects.AddEffects(sender, "BackColor", lostFocus, GotFocus, 25, GotFocus, 25, 15)
                    End If
                Else
                    sender.backcolor = GotFocus
                    'myVisualEffects.ColorFadeEffects.AddEffects(sender, "BackColor", getHTMLColor(getThemes.text_lostFocusBackColor), getHTMLColor(getThemes.text_focusBackColor), 25, getHTMLColor(getThemes.text_focusBackColor), 25, 15)
                    sender.forecolor = Color.Black
                End If

            End Sub

            Private Shared Sub LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
                Dim GotFocus As Color = Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sALTERNATE)
                Dim lostFocus As Color = Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sDEFAULT)
                If TypeOf sender Is ToolStripTextBox Then
                    If sender.readonly = False Then
                        'sender.backcolor = getHTMLColor(getThemes.text_lostFocusBackColor)
                        sender.forecolor = getHTMLColor(getThemes.text_lostFocusForeColor)
                        myVisualEffects.ColorFadeEffects.AddEffects(sender, "BackColor", GotFocus, lostFocus, 25, lostFocus, 25, 20)
                    End If
                Else
                    sender.backcolor = lostFocus
                    'myVisualEffects.ColorFadeEffects.AddEffects(sender, "BackColor", getHTMLColor(getThemes.text_focusBackColor), getHTMLColor(getThemes.text_lostFocusBackColor), 25, getHTMLColor(getThemes.text_lostFocusBackColor), 25, 20)
                    sender.forecolor = Color.Black
                End If
            End Sub

            Private Shared Sub subDistributeEvents(ByRef obj As Object)
                If TypeOf obj Is ToolStripDropDownButton Then
                    For i As Integer = 0 To CType(obj, ToolStripDropDownButton).DropDownItems.Count - 1
                        Dim o As ToolStripMenuItem = CType(obj, ToolStripDropDownButton).DropDownItems(i)
                        'myPicture.ui_Icons(o, ui_icon_normal, 24, 24)

                        AddHandler o.MouseMove, AddressOf MouseMove
                        AddHandler o.MouseLeave, AddressOf MouseLeave
                        AddHandler o.MouseDown, AddressOf MouseDown
                        AddHandler o.MouseUp, AddressOf MouseUp

                        If CType(o, ToolStripMenuItem).HasDropDownItems Then
                            subDistributeEvents(o)
                        End If
                    Next
                ElseIf TypeOf obj Is ToolStripSplitButton Then
                    For i As Integer = 0 To CType(obj, ToolStripSplitButton).DropDownItems.Count - 1
                        Dim o As ToolStripMenuItem = CType(obj, ToolStripSplitButton).DropDownItems(i)
                        'myPicture.ui_Icons(o, ui_icon_normal, 24, 24)

                        AddHandler o.MouseMove, AddressOf MouseMove
                        AddHandler o.MouseLeave, AddressOf MouseLeave

                        If CType(o, ToolStripMenuItem).HasDropDownItems Then
                            subDistributeEvents(o)
                        End If
                    Next
                ElseIf TypeOf obj Is ToolStripMenuItem Then
                    For i As Integer = 0 To CType(obj, ToolStripMenuItem).DropDownItems.Count - 1
                        Dim o As Object = CType(obj, ToolStripMenuItem).DropDownItems(i)

                        If TypeOf o Is ToolStripComboBox Then
                            Dim oo As ToolStripComboBox = o
                            'myPicture.ui_Icons(oo, ui_icon_normal, 24, 24)
                            'oo.BackColor = ColorPicker(ui_textbox_normal, PickStyle.backColor)
                            'oo.ForeColor = ColorPicker(ui_textbox_normal, PickStyle.fontColor)
                            AddHandler oo.GotFocus, AddressOf GotFocus
                            AddHandler oo.LostFocus, AddressOf LostFocus

                        ElseIf TypeOf o Is ToolStripMenuItem Then
                            Dim oo As ToolStripMenuItem = o
                            'myPicture.ui_Icons(o, ui_icon_normal, 24, 24)

                            AddHandler oo.MouseMove, AddressOf MouseMove
                            AddHandler oo.MouseLeave, AddressOf MouseLeave
                            AddHandler oo.MouseDown, AddressOf MouseDown
                            AddHandler oo.MouseUp, AddressOf MouseUp
                            If CType(o, ToolStripMenuItem).HasDropDownItems Then
                                subDistributeEvents(o)
                            End If
                        ElseIf TypeOf o Is ToolStripTextBox Then
                            Dim oo As ToolStripTextBox = o
                            'myPicture.ui_Icons(oo, ui_icon_normal, 24, 24)
                            'oo.BackColor = ColorPicker(ui_textbox_normal, PickStyle.backColor)
                            'oo.ForeColor = ColorPicker(ui_textbox_normal, PickStyle.fontColor)
                            AddHandler oo.GotFocus, AddressOf GotFocus
                            AddHandler oo.LostFocus, AddressOf LostFocus
                        End If
                    Next
                End If

            End Sub

            Public Shared Sub AddEvent(ByRef obj As Object, ByRef getTheme As myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue, Optional ByVal runCode As String = "")
                If runCode = "masterkey" Then
                    getThemes = getTheme
                    Dim Color As Color = getHTMLColor(getThemes.backgroundColor)
                    Dim aCOlor As Color = getHTMLColor(getThemes.accentColor)
                    Dim myRenderer As New myControls.Init.contextMenuStripRenderer

                    With myRenderer

                        .separatorBarColor = getHTMLColor(getThemes.backgroundColor)
                        .select_border_color = Drawing.Color.White
                        .select_bottom1 = getHTMLColor(getThemes.accentColor)
                        .select_bottom2 = getHTMLColor(getThemes.accentColor)
                        .select_font_color = Drawing.Color.White
                        .select_top1 = getHTMLColor(getThemes.accentColor)
                        .select_top2 = getHTMLColor(getThemes.accentColor)
                        '._My_Selection_Style_Custom_Select_Has_Border = True

                        .unselect_border_color = Drawing.Color.White
                        .unselect_bottom1 = myColor.Share.Tools.Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sMENUSTRIP)
                        .unselect_bottom2 = myColor.Share.Tools.Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sMENUSTRIP)
                        .unselect_top1 = myColor.Share.Tools.Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sMENUSTRIP)
                        .unselect_top2 = myColor.Share.Tools.Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sMENUSTRIP)
                        .unselect_font_color = Drawing.Color.White
                        .SelectionStyle = myControls.Init.contextMenuStripRenderer.SelectStyleType.Custom_Select_and_Unselect
                        .assign_colors()

                    End With
                    With CType(obj, MenuStrip)
                        .BackColor = Brightness.Apply(Color, sMENUSTRIP)
                        '.RenderMode = ToolStripRenderMode.Custom
                        .Renderer = myRenderer
                    End With


                    For i As Integer = 0 To CType(obj, MenuStrip).Items.Count - 1
                        'myPicture.ui_Icons(CType(obj, MenuStrip).Items(i), ui_icon_normal, 24, 24)

                        Dim ob As Object = CType(obj, MenuStrip).Items(i)

                        If TypeOf ob Is ToolStripTextBox Then
                            Dim o As ToolStripTextBox = ob
                            'o.ForeColor = ColorPicker(ui_textbox_normal, PickStyle.fontColor)
                            'o.BackColor = ColorPicker(ui_textbox_normal, PickStyle.backColor)
                            AddHandler o.GotFocus, AddressOf GotFocus
                            AddHandler o.LostFocus, AddressOf LostFocus
                        ElseIf TypeOf ob Is ToolStripComboBox Then
                            Dim o As ToolStripComboBox = ob
                            'o.ForeColor = ColorPicker(ui_textbox_normal, PickStyle.fontColor)
                            'o.BackColor = ColorPicker(ui_textbox_normal, PickStyle.backColor)
                            AddHandler o.GotFocus, AddressOf GotFocus
                            AddHandler o.LostFocus, AddressOf LostFocus
                        ElseIf TypeOf ob Is ToolStripMenuItem Then
                            Dim o As ToolStripMenuItem = ob
                            AddHandler o.MouseMove, AddressOf MouseMove
                            AddHandler o.MouseLeave, AddressOf MouseLeave
                            AddHandler o.MouseDown, AddressOf MouseDown
                            AddHandler o.MouseUp, AddressOf MouseUp
                            If CType(ob, ToolStripMenuItem).HasDropDownItems Then
                                subDistributeEvents(ob)
                            End If
                        End If
                    Next

                Else
                    activationRequired("Menustrip.AddEvent")
                End If
            End Sub

        End Class

        Public Class ContextMenuStrips

            Private Shared getThemes As New myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue

            Private Shared Sub MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                If TypeOf sender Is ToolStripMenuItem Then
                    With CType(sender, ToolStripMenuItem)
                        Dim oldFont As Font = New Font(.Font.FontFamily, .Font.Size - 1, FontStyle.Regular, .Font.Unit)
                        '.Font = oldFont
                    End With
                End If
            End Sub

            Private Shared Sub MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                If TypeOf sender Is ToolStripMenuItem Then
                    With CType(sender, ToolStripMenuItem)
                        Dim oldFont As Font = New Font(.Font.FontFamily, .Font.Size + 1, FontStyle.Regular, .Font.Unit)
                        '.Font = oldFont
                    End With
                End If
            End Sub

            Private Shared Sub MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)

            End Sub

            Private Shared Sub MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

            End Sub

            Private Shared Sub GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
                Dim GotFocus As Color = Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sALTERNATE)
                Dim lostFocus As Color = Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sDEFAULT)

                If TypeOf sender Is ToolStripTextBox Then
                    If sender.readonly = False Then
                        'sender.backcolor = getHTMLColor(getThemes.text_focusBackColor)
                        sender.forecolor = Color.Black
                        myVisualEffects.ColorFadeEffects.AddEffects(sender, "BackColor", lostFocus, GotFocus, 25, GotFocus, 25, 15)
                    End If
                Else
                    sender.backcolor = GotFocus
                    'myVisualEffects.ColorFadeEffects.AddEffects(sender, "BackColor", getHTMLColor(getThemes.text_lostFocusBackColor), getHTMLColor(getThemes.text_focusBackColor), 25, getHTMLColor(getThemes.text_focusBackColor), 25, 15)
                    sender.forecolor = Color.Black
                End If

            End Sub

            Private Shared Sub LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
                Dim GotFocus As Color = Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sALTERNATE)
                Dim lostFocus As Color = Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sDEFAULT)
                If TypeOf sender Is ToolStripTextBox Then
                    If sender.readonly = False Then
                        'sender.backcolor = getHTMLColor(getThemes.text_lostFocusBackColor)
                        sender.forecolor = getHTMLColor(getThemes.text_lostFocusForeColor)
                        myVisualEffects.ColorFadeEffects.AddEffects(sender, "BackColor", GotFocus, lostFocus, 25, lostFocus, 25, 20)
                    End If
                Else
                    sender.backcolor = lostFocus
                    'myVisualEffects.ColorFadeEffects.AddEffects(sender, "BackColor", getHTMLColor(getThemes.text_focusBackColor), getHTMLColor(getThemes.text_lostFocusBackColor), 25, getHTMLColor(getThemes.text_lostFocusBackColor), 25, 20)
                    sender.forecolor = Color.Black
                End If
            End Sub

            Private Shared Sub subDistributeEvents(ByRef obj As Object)
                If TypeOf obj Is ToolStripDropDownButton Then
                    For i As Integer = 0 To CType(obj, ToolStripDropDownButton).DropDownItems.Count - 1
                        Dim o As ToolStripMenuItem = CType(obj, ToolStripDropDownButton).DropDownItems(i)
                        'myPicture.ui_Icons(o, ui_icon_normal, 24, 24)

                        AddHandler o.MouseMove, AddressOf MouseMove
                        AddHandler o.MouseLeave, AddressOf MouseLeave
                        AddHandler o.MouseDown, AddressOf MouseDown
                        AddHandler o.MouseUp, AddressOf MouseUp

                        If CType(o, ToolStripMenuItem).HasDropDownItems Then
                            subDistributeEvents(o)
                        End If
                    Next
                ElseIf TypeOf obj Is ToolStripSplitButton Then
                    For i As Integer = 0 To CType(obj, ToolStripSplitButton).DropDownItems.Count - 1
                        Dim o As ToolStripMenuItem = CType(obj, ToolStripSplitButton).DropDownItems(i)
                        'myPicture.ui_Icons(o, ui_icon_normal, 24, 24)

                        AddHandler o.MouseMove, AddressOf MouseMove
                        AddHandler o.MouseLeave, AddressOf MouseLeave

                        If CType(o, ToolStripMenuItem).HasDropDownItems Then
                            subDistributeEvents(o)
                        End If
                    Next
                ElseIf TypeOf obj Is ToolStripMenuItem Then
                    For i As Integer = 0 To CType(obj, ToolStripMenuItem).DropDownItems.Count - 1
                        Dim o As Object = CType(obj, ToolStripMenuItem).DropDownItems(i)

                        If TypeOf o Is ToolStripComboBox Then
                            Dim oo As ToolStripComboBox = o
                            'myPicture.ui_Icons(oo, ui_icon_normal, 24, 24)
                            'oo.BackColor = ColorPicker(ui_textbox_normal, PickStyle.backColor)
                            'oo.ForeColor = ColorPicker(ui_textbox_normal, PickStyle.fontColor)
                            AddHandler oo.GotFocus, AddressOf GotFocus
                            AddHandler oo.LostFocus, AddressOf LostFocus

                        ElseIf TypeOf o Is ToolStripMenuItem Then
                            Dim oo As ToolStripMenuItem = o
                            'myPicture.ui_Icons(o, ui_icon_normal, 24, 24)

                            AddHandler oo.MouseMove, AddressOf MouseMove
                            AddHandler oo.MouseLeave, AddressOf MouseLeave
                            AddHandler oo.MouseDown, AddressOf MouseDown
                            AddHandler oo.MouseUp, AddressOf MouseUp
                            If CType(o, ToolStripMenuItem).HasDropDownItems Then
                                subDistributeEvents(o)
                            End If
                        ElseIf TypeOf o Is ToolStripTextBox Then
                            Dim oo As ToolStripTextBox = o
                            'myPicture.ui_Icons(oo, ui_icon_normal, 24, 24)
                            'oo.BackColor = ColorPicker(ui_textbox_normal, PickStyle.backColor)
                            'oo.ForeColor = ColorPicker(ui_textbox_normal, PickStyle.fontColor)
                            AddHandler oo.GotFocus, AddressOf GotFocus
                            AddHandler oo.LostFocus, AddressOf LostFocus
                        End If
                    Next
                End If

            End Sub

            Public Shared Sub AddEvent(ByRef obj As Object, ByRef getTheme As myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue, Optional ByVal runCode As String = "")
                If runCode = "masterkey" Then
                    getThemes = getTheme
                    Dim Color As Color = getHTMLColor(getThemes.backgroundColor)
                    Dim aCOlor As Color = getHTMLColor(getThemes.accentColor)
                    Dim myRenderer As New myControls.Init.contextMenuStripRenderer

                    With myRenderer

                        .separatorBarColor = getHTMLColor(getThemes.backgroundColor)
                        .select_border_color = Drawing.Color.White
                        .select_bottom1 = getHTMLColor(getThemes.accentColor)
                        .select_bottom2 = getHTMLColor(getThemes.accentColor)
                        .select_font_color = Drawing.Color.White
                        .select_top1 = getHTMLColor(getThemes.accentColor)
                        .select_top2 = getHTMLColor(getThemes.accentColor)
                        '._My_Selection_Style_Custom_Select_Has_Border = True

                        .unselect_border_color = Drawing.Color.White
                        .unselect_bottom1 = myColor.Share.Tools.Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sMENUSTRIP)
                        .unselect_bottom2 = myColor.Share.Tools.Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sMENUSTRIP)
                        .unselect_top1 = myColor.Share.Tools.Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sMENUSTRIP)
                        .unselect_top2 = myColor.Share.Tools.Brightness.Apply(getHTMLColor(getThemes.backgroundColor), sMENUSTRIP)
                        .unselect_font_color = Drawing.Color.White
                        .SelectionStyle = myControls.Init.contextMenuStripRenderer.SelectStyleType.Custom_Select_and_Unselect
                        .assign_colors()

                    End With
                    With CType(obj, ContextMenuStrip)
                        .BackColor = Brightness.Apply(Color, sMENUSTRIP)
                        '.RenderMode = ToolStripRenderMode.Custom
                        .Renderer = myRenderer
                    End With


                    For i As Integer = 0 To CType(obj, ContextMenuStrip).Items.Count - 1
                        'myPicture.ui_Icons(CType(obj, MenuStrip).Items(i), ui_icon_normal, 24, 24)

                        Dim ob As Object = CType(obj, ContextMenuStrip).Items(i)

                        If TypeOf ob Is ToolStripTextBox Then
                            Dim o As ToolStripTextBox = ob
                            'o.ForeColor = ColorPicker(ui_textbox_normal, PickStyle.fontColor)
                            'o.BackColor = ColorPicker(ui_textbox_normal, PickStyle.backColor)
                            AddHandler o.GotFocus, AddressOf GotFocus
                            AddHandler o.LostFocus, AddressOf LostFocus
                        ElseIf TypeOf ob Is ToolStripComboBox Then
                            Dim o As ToolStripComboBox = ob
                            'o.ForeColor = ColorPicker(ui_textbox_normal, PickStyle.fontColor)
                            'o.BackColor = ColorPicker(ui_textbox_normal, PickStyle.backColor)
                            AddHandler o.GotFocus, AddressOf GotFocus
                            AddHandler o.LostFocus, AddressOf LostFocus
                        ElseIf TypeOf ob Is ToolStripMenuItem Then
                            Dim o As ToolStripMenuItem = ob
                            AddHandler o.MouseMove, AddressOf MouseMove
                            AddHandler o.MouseLeave, AddressOf MouseLeave
                            AddHandler o.MouseDown, AddressOf MouseDown
                            AddHandler o.MouseUp, AddressOf MouseUp
                            If CType(ob, ToolStripMenuItem).HasDropDownItems Then
                                subDistributeEvents(ob)
                            End If
                        End If
                    Next

                Else
                    activationRequired("ContextMenuStrip.AddEvent")
                End If
            End Sub

        End Class

        Public Class TabControls
            Private Shared TAB_MARGIN As Integer = 2
            Private Shared m_Xwid As Integer = 5
            Private Shared getThemes As New myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue

            Private Shared Sub MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                ' See if this is over a tab.
                For i As Integer = 0 To sender.TabPages.Count - 1
                    ' Get the TabRect plus room for margins.
                    Dim tab_rect As Rectangle = _
                        sender.GetTabRect(i)
                    Dim rect As New RectangleF( _
                        tab_rect.Left + TAB_MARGIN, _
                        tab_rect.Y + TAB_MARGIN, _
                        tab_rect.Width - 2 * TAB_MARGIN, _
                        tab_rect.Height - 2 * TAB_MARGIN)
                    If e.X >= rect.Right - m_Xwid AndAlso _
                       e.X <= rect.Right AndAlso _
                       e.Y >= rect.Top AndAlso _
                       e.Y <= rect.Top + m_Xwid _
                    Then
                        Debug.WriteLine("Tab " & i)
                        sender.TabPages.RemoveAt(i)
                        Exit Sub
                    End If
                Next i
            End Sub

            Private Shared Sub DrawOnTab(ByVal sender As Object, ByVal e As DrawItemEventArgs)
                Dim page As TabPage = sender.TabPages(e.Index)
                sender.DrawMode = System.Windows.Forms.TabDrawMode.Normal
                e.Graphics.FillRectangle(New SolidBrush(page.BackColor), e.Bounds)
            End Sub

            Public Shared Sub AddEvent(ByRef obj As Object, ByRef getTheme As myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue, Optional ByVal runCode As String = "")
                If runCode = "masterkey" Then
                    getThemes = getTheme
                    Dim aCOlor As Color = getHTMLColor(getThemes.accentColor)

                    If TypeOf obj Is TabControl Then
                        With CType(obj, TabControl)
                            .DrawMode = TabDrawMode.OwnerDrawFixed
                            AddHandler .DrawItem, AddressOf DrawOnTab
                            AddHandler .MouseDown, AddressOf MouseDown
                        End With
                    ElseIf TypeOf obj Is TabPage Then
                        With CType(obj, TabPage)
                            .BackColor = Brightness.Apply(aCOlor, sCONTENT)
                        End With

                    End If

                End If
            End Sub

        End Class

    End Namespace




End Namespace


