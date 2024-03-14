'
' * This code is provided under the Code Project Open Licence (CPOL)
' * See http://www.codeproject.com/info/cpol10.aspx for details
' 


Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms


<System.ComponentModel.ToolboxItem(False)> _
    Public Class TabStyleIE8Provider
    Inherits TabStyleRoundedProvider
    Public Sub New(ByVal tabControl As My8TabControl)
        MyBase.New(tabControl)
        Me._Radius = 3
        Me._ShowTabCloser = True
        Me._CloserColorActive = Color.Red

        '	Must set after the _Radius as this is used in the calculations of the actual padding

        Me._appearanceTabDark = Color.FromArgb(227, 238, 251)
        Me._apperanceTabLight = Color.FromArgb(227, 238, 251)


        'dark = Color.FromArgb(196, 222, 251)
        'light = SystemColors.Window
        Me.SelectedTabDark = Color.FromArgb(196, 222, 251)
        Me.SelectedTabLight = SystemColors.Window

        'light = SystemColors.Window
        'dark = Color.FromArgb(166, 203, 248)
        Me.HotTrackTabLight = SystemColors.Window
        Me.HotTrackTabDark = Color.FromArgb(166, 203, 248)

        Me.CloseColorHotTrackButtonBackColor = Color.White

        Me.Padding = New Point(6, 5)
    End Sub

    Public Overrides Function GetTabRect(ByVal index As Integer) As Rectangle
        If index < 0 Then
            Return New Rectangle()
        End If
        Dim tabBounds As Rectangle = MyBase.GetTabRect(index)
        Dim firstTabinRow As Boolean = Me._TabControl.IsFirstTabInRow(index)

        '	Make non-SelectedTabs smaller and selected tab bigger
        If index <> Me._TabControl.SelectedIndex Then
            Select Case Me._TabControl.Alignment
                Case TabAlignment.Top
                    tabBounds.Y += 1
                    tabBounds.Height -= 1
                    Exit Select
                Case TabAlignment.Bottom
                    tabBounds.Height -= 1
                    Exit Select
                Case TabAlignment.Left
                    tabBounds.X += 1
                    tabBounds.Width -= 1
                    Exit Select
                Case TabAlignment.Right
                    tabBounds.Width -= 1
                    Exit Select
            End Select
        Else
            Select Case Me._TabControl.Alignment
                Case TabAlignment.Top
                    tabBounds.Y -= 1
                    tabBounds.Height += 1

                    If firstTabinRow Then
                        tabBounds.Width += 1
                    Else
                        tabBounds.X -= 1
                        tabBounds.Width += 2
                    End If
                    Exit Select
                Case TabAlignment.Bottom
                    tabBounds.Height += 1

                    If firstTabinRow Then
                        tabBounds.Width += 1
                    Else
                        tabBounds.X -= 1
                        tabBounds.Width += 2
                    End If
                    Exit Select
                Case TabAlignment.Left
                    tabBounds.X -= 1
                    tabBounds.Width += 1

                    If firstTabinRow Then
                        tabBounds.Height += 1
                    Else
                        tabBounds.Y -= 1
                        tabBounds.Height += 2
                    End If
                    Exit Select
                Case TabAlignment.Right
                    tabBounds.Width += 1
                    If firstTabinRow Then
                        tabBounds.Height += 1
                    Else
                        tabBounds.Y -= 1
                        tabBounds.Height += 2
                    End If
                    Exit Select
            End Select
        End If

        '	Adjust first tab in the row to align with tabpage
        Me.EnsureFirstTabIsInView(tabBounds, index)
        Return tabBounds
    End Function

    Protected Overrides Function GetTabBackgroundBrush(ByVal index As Integer) As Brush
        Dim fillBrush As LinearGradientBrush = Nothing

        '	Capture the colours dependant on selection state of the tab
        'Dim dark As Color = Color.FromArgb(227, 238, 251)
        'Dim light As Color = Color.FromArgb(227, 238, 251)
        Dim dark As Color = Me.AppearanceTabDark
        Dim light As Color = Me.AppearanceTabLight

        If Me._TabControl.SelectedIndex = index Then
            dark = Color.FromArgb(196, 222, 251)
            light = SystemColors.Window
            dark = Me.SelectedTabDark
            light = Me.SelectedTabLight
        ElseIf Not Me._TabControl.TabPages(index).Enabled Then
            light = dark
        ElseIf Me.HotTrack AndAlso index = Me._TabControl.ActiveIndex Then
            '	Enable hot tracking
            light = SystemColors.Window
            dark = Color.FromArgb(166, 203, 248)
            light = Me.HotTrackTabLight
            dark = Me.HotTrackTabDark
        End If

        '	Get the correctly aligned gradient
        Dim tabBounds As Rectangle = Me.GetTabRect(index)
        tabBounds.Inflate(3, 3)
        tabBounds.X -= 1
        tabBounds.Y -= 1
        Select Case Me._TabControl.Alignment
            Case TabAlignment.Top
                fillBrush = New LinearGradientBrush(tabBounds, dark, light, LinearGradientMode.Vertical)
                Exit Select
            Case TabAlignment.Bottom
                fillBrush = New LinearGradientBrush(tabBounds, light, dark, LinearGradientMode.Vertical)
                Exit Select
            Case TabAlignment.Left
                fillBrush = New LinearGradientBrush(tabBounds, dark, light, LinearGradientMode.Horizontal)
                Exit Select
            Case TabAlignment.Right
                fillBrush = New LinearGradientBrush(tabBounds, light, dark, LinearGradientMode.Horizontal)
                Exit Select
        End Select

        '	Add the blend
        fillBrush.Blend = Me.GetBackgroundBlend(index)

        Return fillBrush
    End Function

    Private Overloads Function GetBackgroundBlend(ByVal index As Integer) As Blend
        Dim relativeIntensities As Single() = New Single() {0.0F, 0.7F, 1.0F}
        Dim relativePositions As Single() = New Single() {0.0F, 0.8F, 1.0F}

        If Me._TabControl.SelectedIndex <> index Then
            relativeIntensities = New Single() {0.0F, 0.3F, 1.0F}
            relativePositions = New Single() {0.0F, 0.2F, 1.0F}
        End If

        Dim blend As New Blend()
        blend.Factors = relativeIntensities
        blend.Positions = relativePositions

        Return blend
    End Function

    Protected Overrides Sub DrawTabCloser(ByVal index As Integer, ByVal graphics As Graphics)
        If Me._ShowTabCloser Then
            If Not Me._TabControl.TabPages(index).Tag Is Nothing Then
                If Me._TabControl.TabPages(index).Tag = "add-tabpage" Or Me._TabControl.TabPages(index).Tag = "disable-close" Then
                    'Do nothing
                Else
                    Dim closerRect As Rectangle = Me._TabControl.GetTabCloserRect(index)
                    graphics.SmoothingMode = SmoothingMode.AntiAlias
                    If closerRect.Contains(Me._TabControl.MousePosition) Then
                        Using closerPath As GraphicsPath = GetCloserButtonPath(closerRect)
                            graphics.FillPath(New SolidBrush(Me.CloseColorHotTrackButtonBackColor), closerPath)
                            Using closerPen As New Pen(Me.BorderColor)
                                graphics.DrawPath(closerPen, closerPath)
                            End Using
                        End Using
                        Using closerPath As GraphicsPath = GetCloserPath(closerRect)
                            Using closerPen As New Pen(Me._CloserColorActive)
                                closerPen.Width = 2
                                graphics.DrawPath(closerPen, closerPath)
                            End Using
                        End Using
                    Else
                        Using closerPath As GraphicsPath = GetCloserPath(closerRect)
                            Using closerPen As New Pen(Me._CloserColor)
                                closerPen.Width = 2

                                graphics.DrawPath(closerPen, closerPath)
                            End Using
                        End Using

                    End If
                End If
            Else
                Dim closerRect As Rectangle = Me._TabControl.GetTabCloserRect(index)
                graphics.SmoothingMode = SmoothingMode.AntiAlias
                If closerRect.Contains(Me._TabControl.MousePosition) Then
                    Using closerPath As GraphicsPath = GetCloserButtonPath(closerRect)
                        graphics.FillPath(New SolidBrush(Me.CloseColorHotTrackButtonBackColor), closerPath)
                        Using closerPen As New Pen(Me.BorderColor)
                            graphics.DrawPath(closerPen, closerPath)
                        End Using
                    End Using
                    Using closerPath As GraphicsPath = GetCloserPath(closerRect)
                        Using closerPen As New Pen(Me._CloserColorActive)
                            closerPen.Width = 2
                            graphics.DrawPath(closerPen, closerPath)
                        End Using
                    End Using
                Else
                    Using closerPath As GraphicsPath = GetCloserPath(closerRect)
                        Using closerPen As New Pen(Me._CloserColor)
                            closerPen.Width = 2

                            graphics.DrawPath(closerPen, closerPath)
                        End Using
                    End Using

                End If
            End If

            End If
    End Sub

    Private Shared Function GetCloserButtonPath(ByVal closerRect As Rectangle) As GraphicsPath
        Dim closerPath As New GraphicsPath()
        closerPath.AddLine(closerRect.X - 1, closerRect.Y - 2, closerRect.Right + 1, closerRect.Y - 2)
        closerPath.AddLine(closerRect.Right + 2, closerRect.Y - 1, closerRect.Right + 2, closerRect.Bottom + 1)
        closerPath.AddLine(closerRect.Right + 1, closerRect.Bottom + 2, closerRect.X - 1, closerRect.Bottom + 2)
        closerPath.AddLine(closerRect.X - 2, closerRect.Bottom + 1, closerRect.X - 2, closerRect.Y - 1)
        closerPath.CloseFigure()
        Return closerPath
    End Function

    Public Overrides Function GetPageBackgroundBrush(ByVal index As Integer) As Brush

        '	Capture the colours dependant on selection state of the tab
        'Dim light As Color = Color.FromArgb(227, 238, 251)
        Dim light As Color = Color.Green

        If Me._TabControl.SelectedIndex = index Then
            light = SystemColors.Window
        ElseIf Not Me._TabControl.TabPages(index).Enabled Then
            light = Color.FromArgb(207, 207, 207)
        ElseIf Me._HotTrack AndAlso index = Me._TabControl.ActiveIndex Then
            '	Enable hot tracking
            light = Color.FromArgb(234, 246, 253)
        End If

        Return New SolidBrush(light)
    End Function

End Class
