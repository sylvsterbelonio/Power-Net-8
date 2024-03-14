Public Class frmTransparentIcon
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()

        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    'Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    '    If disposing Then
    '        If Not (components Is Nothing) Then
    '            components.Dispose()
    '        End If
    '    End If
    '    MyBase.Dispose(disposing)
    'End Sub

    'Required by the Windows Form Designer
    'Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    'Form overrides dispose to clean up the component list.

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    'Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.

    Friend WithEvents PictureBox_SplashImage As System.Windows.Forms.PictureBox

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.pngImageSource = New System.Windows.Forms.PictureBox
        Me.PictureBox_SplashImage = New System.Windows.Forms.PictureBox
        CType(Me.pngImageSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_SplashImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pngImageSource
        '
        Me.pngImageSource.Image = Global.PowerNET8.My.Resources.Resources.JQMobileButton2
        Me.pngImageSource.Location = New System.Drawing.Point(3, -1)
        Me.pngImageSource.Name = "pngImageSource"
        Me.pngImageSource.Size = New System.Drawing.Size(82, 80)
        Me.pngImageSource.TabIndex = 0
        Me.pngImageSource.TabStop = False
        Me.pngImageSource.Visible = False
        '
        'PictureBox_SplashImage
        '
        Me.PictureBox_SplashImage.Location = New System.Drawing.Point(177, 12)
        Me.PictureBox_SplashImage.Name = "PictureBox_SplashImage"
        Me.PictureBox_SplashImage.Size = New System.Drawing.Size(44, 38)
        Me.PictureBox_SplashImage.TabIndex = 1
        Me.PictureBox_SplashImage.TabStop = False
        '
        'frmTransparentIcon
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(10, 23)
        Me.ClientSize = New System.Drawing.Size(116, 81)
        Me.Controls.Add(Me.pngImageSource)
        Me.Controls.Add(Me.PictureBox_SplashImage)
        Me.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTransparentIcon"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.pngImageSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_SplashImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Declare Function BitBlt Lib "gdi32" Alias "BitBlt" (ByVal hDestDC As Integer, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hSrcDC As Integer, ByVal xSrc As Integer, ByVal ySrc As Integer, ByVal dwRop As Integer) As Integer
    Private Declare Function GetDC Lib "user32" Alias "GetDC" (ByVal hwnd As IntPtr) As Integer
    Private Declare Function ReleaseDC Lib "user32" Alias "ReleaseDC" (ByVal hwnd As IntPtr, ByVal hdc As Integer) As Integer
    Private Const SRCCOPY = &HCC0020
    'Private mySql As New CustomObjects.mySql
    'Private myPicture As New CustomObjects.myPicture
    Public ImageSource As Image = My.Resources.JQMobileButton2

    Private Sub frmSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Read the PNG picture into PictureBox_PngSource -- the PNG is compiled as an embedded resource
        ' Me.PictureBox_PngSource.Image = get_Image("Type A")
        ' Me.PictureBox_SplashImage.Image = My.Resources.pbar_ani
        ' Determine the Width and Height of the splash form
        pngImageSource.Image = ImageSource
        Dim FormWidth As Integer = 60
        Dim FormHeight As Integer = 60

        ' Determine the Left and Top parameters of the splash form -- the form will be centered on screen
        Dim ScreenSize As System.Drawing.Rectangle = Screen.PrimaryScreen.WorkingArea
        Dim FormLeft As Integer = Me.Left
        Dim FormTop As Integer = Me.Top

        ' Create a bitmap buffer to draw things into
        Dim BufferBitmap As Bitmap = New Bitmap(60, 60)
        Dim BufferGraphics As Graphics = Graphics.FromImage(BufferBitmap)

        ' Get a screenshot of the desktop area where the splash form will show
        Dim DesktopDC As Integer = GetDC(Nothing)
        Dim BufferGraphicsDC As IntPtr = BufferGraphics.GetHdc
        BitBlt(BufferGraphicsDC.ToInt32, 0, 0, FormWidth, FormHeight, DesktopDC, FormLeft, FormTop, SRCCOPY)
        ReleaseDC(Nothing, DesktopDC)
        BufferGraphics.ReleaseHdc(BufferGraphicsDC)

        ' Draw the PNG image over the desktop screenshot
        BufferGraphics.DrawImage(Me.pngImageSource.Image, 0, 0, FormWidth, FormHeight)

        ' Draw some text -- this is where some product license info could be drawn on the splash picture
        Dim TextBrush As New SolidBrush(Me.ForeColor)
        'BufferGraphics.DrawString("This is a system", Me.Font, TextBrush, 25, 40)
        TextBrush.Dispose()

        BufferGraphics.Dispose()

        ' Put the final result into the PictureBox_SplashImage which will cover the entire splash form
        Me.PictureBox_SplashImage.Size = New Size(60, 60)
        Me.PictureBox_SplashImage.Location = New Point(0, 0)
        Me.PictureBox_SplashImage.Image = BufferBitmap

        ' Position the splash form exactly over the desktop area that was previously captured
        Me.Width = FormWidth
        Me.Height = FormHeight
        'Me.Top = FormTop
        'Me.Left = FormLeft
        Me.WindowState = FormWindowState.Normal

        Application.DoEvents()

        faDeIn()

    End Sub

    Private action As String
    Private intro_value As Double = 0
    Private max_opacity As Double = 1
    Private timer_ As New Timer
    Private leftAnimate As Integer
    Public incrementor As Double = 0.02
 

    Private Sub faDeIn()
        Me.Left = Me.Left + 50
        timer_.Interval = 1
        'incrementor = 0.08
        'max_opacity = 0.75
        action = "fade in"
        timer_.Enabled = True
        timer_.Start()
        AddHandler timer_.Tick, AddressOf Timer_Tick
    End Sub

    Public Sub faDeOut()
        'Me.Left = Me.Left + 50
        timer_.Interval = 1
        'incrementor = 0.08
        'max_opacity = 0.75
        action = "fade out"
        timer_.Enabled = True
        timer_.Start()
        AddHandler timer_.Tick, AddressOf Timer_Tick
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If action = "fade in" Then
            If intro_value >= max_opacity Then
                timer_.Stop()
                'action = "fade out"
                'timer_.Start()
            End If
            intro_value += CDbl(incrementor)
        ElseIf action = "fade out" Then
            If intro_value <= 0 Then
                timer_.Stop()
                Me.Close()
            End If
            'Me.Left += 2
            intro_value -= CDbl(incrementor)
        End If
        Me.Opacity = intro_value
    End Sub

End Class