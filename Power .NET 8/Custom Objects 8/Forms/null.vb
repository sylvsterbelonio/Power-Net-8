Public Class null



    Dim timer1 As New Timer


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        PowerNET8.pWindowsFormColor = "D81313"
        myControls.Share.Forms.TitleBar.createTitleBar(Me, "", "masterkey")
        myEvents.Share.TitleBar.ActiveWindow.addEvent(timer1, Me, "", "masterkey")

    End Sub

    Private Sub My8Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles My8Button1.Click

        If Me.ControlBox Then
            Me.ControlBox = False

        Else
            Me.ControlBox = True
        End If


        'Dim myGraphics As Graphics = Me.CreateGraphics
        'Dim myRectangle As New Rectangle

        'myRectangle.X = txtX.Text
        'myRectangle.Y = txtY.Text
        'myRectangle.Width = txtWidth.Text
        'myRectangle.Height = txtHeight.Text

        'Dim img As Image = New Bitmap(myRectangle.Width, myRectangle.Height, myGraphics)
        'Dim imageGraphics As Graphics = Graphics.FromImage(img)

        'imageGraphics.FillEllipse(Brushes.Gray, myRectangle)
        'imageGraphics.DrawImage(My.Resources.TitleBarIcon, New Point(5, 5))
        'imageGraphics.DrawEllipse(Pens.White, New Rectangle(0, 0, 23, 23))

        'PictureBox1.Image = img
        'PictureBox1.BackColor = Color.Red
    End Sub

    Private Sub My8Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles My8Button3.Click

        Dim cropX As Integer = Val(txtX.Text)
        Dim cropY As Integer = Val(txtY.Text)
        Dim cropWidth As Integer = Val(txtWidth.Text)
        Dim cropHeight As Integer = Val(txtHeight.Text)
        Dim rect As New Rectangle(cropX, cropY, cropWidth, cropHeight)

        Dim bmp As Bitmap = My.Resources.TitleBarIcons4
        Dim cropped As Bitmap = bmp.Clone(rect, bmp.PixelFormat)
        PictureBox2.Image = myImage.Share.Tools.resizeImage(cropped, 48, 48)

        'bmp = My.Resources.Window8_white
        'cropped = bmp.Clone(rect, bmp.PixelFormat)
        'PictureBox2.Image = myImage.Tools.resizeImage(cropped, 48, 48)

    End Sub

    Private Sub My8Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmPromptDialog As New frmSideContainer
        frmPromptDialog.ShowDialog()
    End Sub

    Private Sub BackgroundColor1_Click(ByVal color As Color)
        My8Button3.BackColor = color
    End Sub


End Class