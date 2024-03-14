Imports System.ComponentModel
Namespace myVisualEffects

    Public Class ColorFadeEffects
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Dim Move As Boolean = True
        'Dim Leave As Boolean = True
        'Private Sub Button7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseLeave
        '    Move = True
        '    If Leave Then
        '        Leave = False
        '        Visual.FadeColor(Button7, "BackColor", Color.Blue, Color.Blue, 25, Color.White, 25, 5)
        '    End If
        'End Sub
        'Private Sub Button7_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button7.MouseMove
        '    If Move Then
        '        Leave = True
        '        Move = False
        '        Visual.FadeColor(Button7, "BackColor", Color.White, Color.Blue, 25, Color.Blue, 25, 10)
        '    End If
        'End Sub
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Private Shared colorsFading As New Dictionary(Of String, BackgroundWorker) 'Keeps track of any backgroundworkers already fading colors
        Private Shared backgroundWorkers As New Dictionary(Of BackgroundWorker, ColorFaderInformation) 'Associate each background worker with information it needs

        ' The delegate of a method that will be called when the color finishes fading
        Public Delegate Sub DoneFading(ByVal container As Object, ByVal colorProperty As String)

        ''' <summary>
        '''  Fades a color property from one color to another
        ''' </summary>
        ''' <param name="container">The object that contains the color property</param>
        ''' <param name="colorProperty">The name of the color property to change</param>
        ''' <param name="startColor">The color to start the fade with</param>
        ''' <param name="endColor">The color to end the fade with</param>
        ''' <param name="steps">The number of steps to take to fade from the start color to the end color</param>
        ''' <param name="delay">The delay in milliseconds between each step in the fade.</param>
        ''' <param name="callback">A function to be called when the fade completes</param>
        ''' <remarks></remarks>
        Public Shared Sub AddEffects(ByVal container As Object, ByVal colorProperty As String, ByVal startColor As Color, ByVal endColor As Color, ByVal steps As Integer, ByVal delay As Integer, Optional ByVal callback As DoneFading = Nothing)
            Dim colorSteps(0) As ColorStep
            colorSteps(0) = New ColorStep(endColor, steps)
            AddEffects(container, colorProperty, startColor, colorSteps, delay, callback)
        End Sub

        ''' <summary>
        '''  Fades a color property from one color to another, and then to yet another
        ''' </summary>
        ''' <param name="container">The object that contains the color property</param>
        ''' <param name="colorProperty">The name of the color property to change</param>
        ''' <param name="startColor">The color to start the fade with</param>
        ''' <param name="middleColor">The color to fade to first</param>
        ''' <param name="middleSteps">The number of steps to take in fading to the first color</param>
        ''' <param name="endcolor">The last color to fade to</param>
        ''' <param name="endSteps">The number of steps to take in fading to the last color</param>
        ''' <param name="delay">The delay between each step in the fade</param>
        ''' <param name="callback">A function that will be called after the fading has completed</param>
        ''' <remarks></remarks>
        Public Shared Sub AddEffects(ByVal container As Object, ByVal colorProperty As String, ByVal startColor As Color, ByVal middleColor As Color, ByVal middleSteps As Integer, ByVal endcolor As Color, ByVal endSteps As Integer, ByVal delay As Integer, Optional ByVal callback As DoneFading = Nothing)
            Dim colorSteps(1) As ColorStep
            colorSteps(0) = New ColorStep(middleColor, middleSteps)
            colorSteps(1) = New ColorStep(endcolor, endSteps)
            AddEffects(container, colorProperty, startColor, colorSteps, delay, callback)
        End Sub

        ''' <summary>
        '''  Fades a color property to various colors
        ''' </summary>
        ''' <param name="container">The object that contains the color property</param>
        ''' <param name="colorProperty">The name of the color property to change</param>
        ''' <param name="startColor">The color to start the fade with</param>
        ''' <param name="colorSteps">A list of steps in fading the color - an enumerable list of colors and the steps to get to that color</param>
        ''' <param name="delay">The delay between each step in fading the color</param>
        ''' <param name="callBack">A method to call when the fading has completed</param>
        ''' <remarks></remarks>
        Public Shared Sub AddEffects(ByVal container As Object, ByVal colorProperty As String, ByVal startColor As Color, ByVal colorSteps As IEnumerable(Of ColorStep), ByVal delay As Integer, Optional ByVal callBack As DoneFading = Nothing)

            Dim colorFader As BackgroundWorker

            ' Stores all the parameter information into a class that the background worker will access
            Dim colorFaderInfo As New ColorFaderInformation(container, colorProperty, startColor, colorSteps, delay, callBack)

            ' Checks if the color is already in the process of fading.
            If colorsFading.TryGetValue(GenerateHashCode(container, colorProperty), colorFader) Then

                ' Cancels the backgroundWorkers process and sets a flag indicating that it should restart itself with
                ' the new information.
                colorFader.CancelAsync()
                colorFaderInfo.Rerun = True
                backgroundWorkers(colorFader) = colorFaderInfo

            Else

                ' Creates a new backgroundWorker and adds handlers to all its events
                colorFader = New BackgroundWorker()
                AddHandler colorFader.DoWork, AddressOf BackgroundWorker_DoWork
                AddHandler colorFader.ProgressChanged, AddressOf BackgroundWorker_ProgressChanged
                AddHandler colorFader.RunWorkerCompleted, AddressOf BackgroundWorker_RunWorkerCompleted
                colorFader.WorkerReportsProgress = True
                colorFader.WorkerSupportsCancellation = True

                backgroundWorkers.Add(colorFader, colorFaderInfo)
                colorsFading.Add(GenerateHashCode(container, colorProperty), colorFader)

            End If

            ' Starts the backgroundWorker beginning the fade
            If Not colorFader.IsBusy() Then
                colorFader.RunWorkerAsync(colorFaderInfo)
            End If
        End Sub

        ''' <summary>
        '''  The work that the background worker does in fading the color
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Shared Sub BackgroundWorker_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)

            Dim info As ColorFaderInformation = e.Argument

            ' These are calculated with each iteration (step) and used to set the color
            ' when the background worker reports its progress.
            Dim curR As Double
            Dim curG As Double
            Dim curB As Double

            Dim startStepColor As Color = info.StartColor
            Dim endStepColor As Color

            For Each colorStep As ColorStep In info.Colors

                endStepColor = colorStep.Color

                ' Gets the amount to change each color part per step
                Dim rStep As Double = (CType(endStepColor.R, Double) - startStepColor.R) / colorStep.Steps
                Dim gStep As Double = (CType(endStepColor.G, Double) - startStepColor.G) / colorStep.Steps
                Dim bStep As Double = (CType(endStepColor.B, Double) - startStepColor.B) / colorStep.Steps

                ' the red, green and blue parts of the current color
                curR = startStepColor.R
                curG = startStepColor.G
                curB = startStepColor.B

                ' loop through, and fade
                For i As Integer = 1 To colorStep.Steps

                    curR += rStep
                    curB += bStep
                    curG += gStep

                    CType(sender, BackgroundWorker).ReportProgress(0, Color.FromArgb(curR, curG, curB))

                    System.Threading.Thread.Sleep(info.Delay)

                    If CType(sender, BackgroundWorker).CancellationPending Then
                        e.Cancel = True
                        Exit For
                    End If
                Next

                startStepColor = endStepColor

            Next

        End Sub

        ''' <summary>
        '''  Calls to this method are marshalled back to the original thread, so here is where we actually change the color.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Shared Sub BackgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)

            Dim info As ColorFaderInformation
            If backgroundWorkers.TryGetValue(sender, info) Then
                Dim currentColor As Color = e.UserState

                Try
                    CallByName(info.Container, info.ColorProperty, CallType.Let, currentColor)
                Catch
                End Try

            End If

        End Sub

        ''' <summary>
        '''  This is raised when the background method completes.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Shared Sub BackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)

            Dim info As ColorFaderInformation

            If backgroundWorkers.TryGetValue(sender, info) Then


                If Not e.Cancelled Then

                    If info.CallBack IsNot Nothing Then
                        info.CallBack.Invoke(info.Container, info.ColorProperty)
                    End If

                    backgroundWorkers.Remove(sender)
                    colorsFading.Remove(GenerateHashCode(info.Container, info.ColorProperty))

                Else

                    If info.Rerun Then

                        info.Rerun = False
                        CType(sender, BackgroundWorker).RunWorkerAsync(info)

                    End If

                End If


            End If

        End Sub

        ''' <summary>
        '''  Generates a hashcode for an object and its color that are in the process of fading
        ''' </summary>
        ''' <param name="container">The object whose color property needs to be faded</param>
        ''' <param name="colorProperty">The string name of the property to fade</param>
        ''' <returns>A unique string representing the object and it's color property</returns>
        ''' <remarks></remarks>
        Private Shared Function GenerateHashCode(ByVal container As Object, ByVal colorProperty As String) As String
            Return container.GetHashCode() & colorProperty
        End Function

        ''' <summary>
        '''  A simple class for storing information a backgroundWorker needs to perform the fading.
        ''' </summary>
        ''' <remarks></remarks>
        Private Class ColorFaderInformation

            Public CallBack As DoneFading
            Public Container As Object
            Public ColorProperty As String
            Public StartColor As Color
            Public Colors As IEnumerable(Of ColorStep)
            Public Delay As Integer
            Public Rerun As Boolean

            Public Sub New(ByVal container As Object, ByVal colorProperty As String, ByVal startColor As Color, ByVal colorSteps As IEnumerable(Of ColorStep), ByVal delay As Integer, Optional ByVal callBack As DoneFading = Nothing)
                Me.Container = container
                Me.ColorProperty = colorProperty
                Me.StartColor = startColor
                Me.Colors = colorSteps
                Me.Delay = delay
                Me.CallBack = callBack
                Me.Rerun = False
            End Sub

        End Class

        ''' <summary>
        '''  A simple class needed to represent a single step in the fading process
        ''' </summary>
        ''' <remarks></remarks>
        Public Structure ColorStep

            Public Color As Color
            Public Steps As Integer

            Public Sub New(ByVal color As Color, ByVal steps As Integer)
                Me.Color = color
                Me.Steps = steps
            End Sub

        End Structure

    End Class

    Public Class ShrinkEffects
        Private Shared MyObj As New Object
        Private Shared inc As Integer = 0
        Private Shared Fsize As Double

        Private Shared Sub Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
            If inc = 5 Then
                Fsize -= 0.1
                If TypeOf MyObj Is CheckBox Then
                    With CType(MyObj, CheckBox)
                        Dim oldFont As Font = New Font(.Font.FontFamily, .Font.Size, FontStyle.Underline, .Font.Unit)
                    End With
                End If
            End If
        End Sub

        Public Shared Sub AddEffects(ByRef obj As Object, ByRef timer As Timer)
            inc = 0
            MyObj = obj
            timer.Interval = 200
            Fsize = obj.Font.Size
            AddHandler timer.Tick, AddressOf Tick
            timer.Start()
        End Sub

    End Class

    Public Class myVisualEffects


#Region "CREATE PANEL TOOLS EVENT"

        Public Sub create_click_panel_event(ByRef BasedForm As Form)
            Dim frm As New frmPanelClickSetting
            Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
            Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
            With frm
                .set_BasedForm(BasedForm)
                .Width = 10
                .Left = screenWidth - frm.Width
                .Top = 0
                .Opacity = 0.5
                .Height = 5
                .Owner = BasedForm
                .Show()
            End With

        End Sub

#End Region 'this is creation of panel click event


#Region "ICON SHOW PANEL"

        Private myBaseForm As Form
        Public Sub slide_icon(ByRef obj As Object, ByRef frmz As Form)
            myBaseForm = frmz
            If TypeOf obj Is PowerNET8.My7PanelExtension Then
                'AddHandler frmz.MouseMove, AddressOf frmFloatPanel_MouseMove
            End If
        End Sub

#End Region

#Region "SIDE BAR PANEL"

        Private panel_sideBar As Form
        Private callFadeOutIcon As frmPanelClickSetting

        Public Sub side_bar(ByRef obj As Form, ByRef callFadeOutIcons As Form)
            callFadeOutIcon = callFadeOutIcons
            Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
            Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

            With obj
                .Left = screenWidth
                .Top = 0
                .Height = screenHeight
                .Opacity = 1
                .Show()
            End With

            panel_sideBar = obj
            slide_in()
        End Sub

        Private Sub slide_in()
            max_width = panel_sideBar.Width - 10
            calculate_animation(max_width)
            Dim timerx As New Timer
            timerx.Start()
            timerx.Interval = 1
            AddHandler timerx.Tick, AddressOf ShowPanel_Tick
        End Sub

        Private slide_in_activate As Boolean = False
        Private max_width As Integer = 280
        Private inc_width As Integer = 0

        Private Animate_1st As Integer
        Private Animate_2nd As Integer
        Private Animate_3rd As Integer
        Private Animate_4th As Integer

        Private Sub calculate_animation(ByVal value As Integer)
            Animate_1st = Val(CDbl(value) * 0.72)
            Animate_2nd = Val(CDbl(value) * 0.8)
            Animate_3rd = Val(CDbl(value) * 0.92)
            Animate_4th = Val(CDbl(value) * 0.96)
        End Sub

        Private Sub ShowPanel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
            If max_width > 0 Then
                If max_width >= Animate_1st Then
                    max_width -= 9
                    panel_sideBar.Left -= 9
                ElseIf max_width >= Animate_2nd Then
                    max_width -= 9
                    panel_sideBar.Left -= 9
                ElseIf max_width >= Animate_3rd Then
                    max_width -= 9
                    panel_sideBar.Left -= 9
                ElseIf max_width >= Animate_4th Then
                    max_width -= 5
                    panel_sideBar.Left -= 5
                Else
                    max_width -= 5
                    panel_sideBar.Left -= 5
                End If
            Else
                callFadeOutIcon.hideIcons()
                sender.Stop()
                'isEnteredToPicture = False
            End If
        End Sub



        'Private Sub pnlSideBar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        '    slide_in_activate = True
        '    panel_sideBar.BackColor = Color.Black
        '    'slide_in()
        'End Sub

        Private Sub HidePanel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
            If inc_width >= 0 Then
                panel_sideBar.Width = 10 + inc_width
                inc_width -= 18
            Else
                sender.Stop()
                slide_out_activate = False
                slide_in_activate = False
            End If
        End Sub

        Private slide_out_activate As Boolean = False

        Private Sub slide_out()
            inc_width = max_width
            Dim timerx As New Timer
            timerx.Start()
            timerx.Interval = 1
            AddHandler timerx.Tick, AddressOf HidePanel_Tick
        End Sub

        Private Sub pnlSideBar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            'sender.BackColor = Color.Transparent
            'sender.Width = 10
            'inc_width = 0
            'slide_out_activate = False
            'slide_in_activate = False
        End Sub

#End Region

    End Class

    Public Class SlideRightEffects

        Private lbl As New Collection
        Private interval As Integer = 20
        Private TotalInterval As Integer

        Private Animate_1st As Integer
        Private Animate_2nd As Integer
        Private Animate_3rd As Integer
        Private Animate_4th As Integer

        Private Sub calculate_animation(ByVal value As Integer)
            Animate_1st = Val(CDbl(value) * 0.75)
            Animate_2nd = Val(CDbl(value) * 0.2)
        End Sub

        Private Sub Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
            If interval > 0 Then

                If interval > Animate_1st Then
                    sender.Interval = 10
                    For Each o As Object In lbl
                        If TypeOf o Is Label Then
                            CType(o, Label).Left += 4
                        End If
                    Next
                    interval -= 4
                ElseIf interval > Animate_2nd Then
                    For Each o As Object In lbl
                        If TypeOf o Is Label Then
                            CType(o, Label).Left += 2
                        End If
                    Next
                    interval -= 2
                Else
                    For Each o As Object In lbl
                        If TypeOf o Is Label Then
                            CType(o, Label).Left += 1
                        End If
                    Next
                    interval -= 1
                End If

            Else
                sender.stop()
                CType(sender, Timer).Dispose()
            End If
        End Sub

        Public Sub clearControl()
            lbl.Clear()
        End Sub

        Public Sub AddControl(ByRef obj As Object)
            If TypeOf obj Is Label Then
                ' CType(obj, Label).Tag = "left-" + CType(obj, Label).Left.ToString + ";forecolor-" + myColor.Share.Converter.ColorToString.getHTMLColor(CType(obj, Label).ForeColor)
                lbl.Add(obj)
            End If
        End Sub

        Public Sub AddEffects(Optional ByVal LeftRange As Integer = 20)
            'lbl = obj

            'lbl.Left = lbl.Left - LeftRange
            For Each o As Object In lbl
                If TypeOf o Is Label Then
                    With CType(o, Label)
                        .Left = Val(.Left) - LeftRange
                        '.ForeColor = myColor.Share.Converter.StringToColor.getHTMLColor(fColor(1))
                        Dim parent As Object = .Parent
                        ColorFadeEffects.AddEffects(o, "ForeColor", parent.backcolor, .ForeColor, 25, .ForeColor, 25, 20)
                    End With
                End If
            Next

            interval = LeftRange
            TotalInterval = LeftRange
            calculate_animation(LeftRange)
            Dim time As New Timer
            AddHandler time.Tick, AddressOf Tick
            time.Interval = 100
            time.Start()

        End Sub

    End Class




End Namespace


