'
' * This code is provided under the Code Project Open Licence (CPOL)
' * See http://www.codeproject.com/info/cpol10.aspx for details
' 


Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms



<System.ComponentModel.ToolboxItem(False)> _
Public Class TabStyleNoneProvider
    Inherits TabStyleProvider
    Public Sub New(ByVal tabControl As My8TabControl)
        MyBase.New(tabControl)
    End Sub

    Public Overrides Sub AddTabBorder(ByVal path As System.Drawing.Drawing2D.GraphicsPath, ByVal tabBounds As System.Drawing.Rectangle)
    End Sub
End Class

