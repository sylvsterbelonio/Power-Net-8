Imports PowerNET8.myDialog.msgBox

Public Class iconCropper

    Private Sub My8Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCrop.Click
        Dim cropX As Integer = Val(txtX.Text)
        Dim cropY As Integer = Val(txtY.Text)
        Dim cropWidth As Integer = Val(txtWidth.Text)
        Dim cropHeight As Integer = Val(txtHeight.Text)
        Dim rect As New Rectangle(cropX, cropY, cropWidth, cropHeight)

        Dim bmp As Bitmap = My.Resources.DialogBoxIcon
        Dim cropped As Bitmap = bmp.Clone(rect, bmp.PixelFormat)
        picImage.Image = myImage.Share.Tools.resizeImage(cropped, 48, 48)
    End Sub

    Private Sub My8Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles My8Button1.Click
        ' msgBox("This is my fi", , MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information)

    End Sub
End Class