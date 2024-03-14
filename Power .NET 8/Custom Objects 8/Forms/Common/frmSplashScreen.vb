Public Class frmSplashScreen
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
        Me.PictureBox_PngSource = New System.Windows.Forms.PictureBox
        Me.PictureBox_SplashImage = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox_PngSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_SplashImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox_PngSource
        '
        Me.PictureBox_PngSource.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox_PngSource.Name = "PictureBox_PngSource"
        Me.PictureBox_PngSource.Size = New System.Drawing.Size(800, 900)
        Me.PictureBox_PngSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_PngSource.TabIndex = 0
        Me.PictureBox_PngSource.TabStop = False
        Me.PictureBox_PngSource.Visible = False
        '
        'PictureBox_SplashImage
        '
        Me.PictureBox_SplashImage.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox_SplashImage.Name = "PictureBox_SplashImage"
        Me.PictureBox_SplashImage.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox_SplashImage.TabIndex = 1
        Me.PictureBox_SplashImage.TabStop = False
        '
        'frmSplashScreen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(10, 23)
        Me.ClientSize = New System.Drawing.Size(116, 14)
        Me.Controls.Add(Me.PictureBox_PngSource)
        Me.Controls.Add(Me.PictureBox_SplashImage)
        Me.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSplashScreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SplashForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.PictureBox_PngSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_SplashImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Declare Function BitBlt Lib "gdi32" Alias "BitBlt" (ByVal hDestDC As Integer, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hSrcDC As Integer, ByVal xSrc As Integer, ByVal ySrc As Integer, ByVal dwRop As Integer) As Integer
    Private Declare Function GetDC Lib "user32" Alias "GetDC" (ByVal hwnd As IntPtr) As Integer
    Private Declare Function ReleaseDC Lib "user32" Alias "ReleaseDC" (ByVal hwnd As IntPtr, ByVal hdc As Integer) As Integer
    Private Const SRCCOPY = &HCC0020
    Private mySql As New PowerNET8.mySQL.Init.SQL
    Private myPicture As New PowerNET8.myPicture
    Public SplahImage As Image = Nothing

    Private Function get_Image(Optional ByVal type As String = "") As Image
        Dim mydata As New DataTable
        'mySql.setConnection(ghost, gport, guser, gpass, gdbname)
        'Connect(mySql)
        'myPicture.set_class(mySql, gThemeID, Nothing)
        'mydata = mySql.runQuery("SELECT * from reserved_tblimage_library where ClassName='PictureBox' and TagName='SplashScreen' and GroupName='User' ")
        'If mydata.Rows.Count > 0 Then
        '    'Return myPicture.get_CustomObjectThemes("PictureBox", "SplashScreen", "User")
        '    'Return My.Resources.new_logo_2013
        'Else
        '    Return My.Resources.cipg_SPASHSCREEN
        'End If
        Return SplahImage
    End Function

    Private Sub frmSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Read the PNG picture into PictureBox_PngSource -- the PNG is compiled as an embedded resource
        Me.PictureBox_PngSource.Image = get_Image("Type A")
        ' Me.PictureBox_SplashImage.Image = My.Resources.pbar_ani
        ' Determine the Width and Height of the splash form
        Dim FormWidth As Integer = Me.PictureBox_PngSource.Width
        Dim FormHeight As Integer = Me.PictureBox_PngSource.Height

        ' Determine the Left and Top parameters of the splash form -- the form will be centered on screen
        Dim ScreenSize As System.Drawing.Rectangle = Screen.PrimaryScreen.WorkingArea
        Dim FormLeft As Integer = (ScreenSize.Width - Me.PictureBox_PngSource.Width) / 2
        Dim FormTop As Integer = (ScreenSize.Height - Me.PictureBox_PngSource.Height) / 2

        ' Create a bitmap buffer to draw things into
        Dim BufferBitmap As Bitmap = New Bitmap(FormWidth, FormHeight)
        Dim BufferGraphics As Graphics = Graphics.FromImage(BufferBitmap)

        ' Get a screenshot of the desktop area where the splash form will show
        Dim DesktopDC As Integer = GetDC(Nothing)
        Dim BufferGraphicsDC As IntPtr = BufferGraphics.GetHdc
        BitBlt(BufferGraphicsDC.ToInt32, 0, 0, FormWidth, FormHeight, DesktopDC, FormLeft, FormTop, SRCCOPY)
        ReleaseDC(Nothing, DesktopDC)
        BufferGraphics.ReleaseHdc(BufferGraphicsDC)

        ' Draw the PNG image over the desktop screenshot
        BufferGraphics.DrawImage(Me.PictureBox_PngSource.Image, 0, 0, FormWidth, FormHeight)

        ' Draw some text -- this is where some product license info could be drawn on the splash picture
        Dim TextBrush As New SolidBrush(Me.ForeColor)
        'BufferGraphics.DrawString("This is a system", Me.Font, TextBrush, 25, 40)
        TextBrush.Dispose()

        BufferGraphics.Dispose()

        ' Put the final result into the PictureBox_SplashImage which will cover the entire splash form
        Me.PictureBox_SplashImage.Size = New Size(FormWidth, FormHeight)
        Me.PictureBox_SplashImage.Image = BufferBitmap

        ' Position the splash form exactly over the desktop area that was previously captured
        Me.Width = FormWidth
        Me.Height = FormHeight
        Me.Top = FormTop
        Me.Left = FormLeft
        Me.WindowState = FormWindowState.Normal

        ' Allow the splash form to show itself properly


        'making of progress bar

        ''pbLoading.Image = My.Resources.pbar_ani
        'FormWidth = Me.PictureBox1.Width
        'FormHeight = Me.PictureBox1.Height

        '' Determine the Left and Top parameters of the splash form -- the form will be centered on screen
        'Dim ScreenSize2 As System.Drawing.Rectangle = Screen.PrimaryScreen.WorkingArea
        'FormLeft = (ScreenSize.Width - Me.PictureBox_PngSource.Width) / 2
        'FormTop = (ScreenSize.Height - Me.PictureBox_PngSource.Height) / 2

        'PictureBox1.Location = New System.Drawing.Point(FormLeft, FormTop - 800)
        'PictureBox1.BringToFront()


        Application.DoEvents()
    End Sub

    Private Sub PictureBox_PngSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_PngSource.Click

    End Sub
End Class