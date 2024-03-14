Imports System.IO

Namespace myFile

    Namespace Share

        ''' <summary>
        ''' This class handles the location of the folders or files of your computer
        ''' </summary>
        ''' <remarks></remarks>
        Public Class Location

            ''' <summary>
            ''' It gets the desktop path of your computer
            ''' </summary>
            ''' <returns>Get the desktop path</returns>
            ''' <remarks></remarks>
            Public Shared Function getDesktopPath() As String
                Return Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            End Function

            ''' <summary>
            ''' It gets the location of your system program
            ''' </summary>
            ''' <returns>Get the base path of your system</returns>
            ''' <remarks></remarks>
            Public Shared Function getBasePath() As String
                Return Application.StartupPath
            End Function

        End Class

        ''' <summary>
        ''' This class handles the file folder of your computer
        ''' </summary>
        ''' <remarks></remarks>
        Public Class Folders

            ''' <summary>
            ''' It creates a folder
            ''' </summary>
            ''' <param name="path">Set the path of your folder</param>
            ''' <param name="folderName">Set the name of your folder</param>
            ''' <remarks></remarks>
            Public Shared Sub createFolder(ByVal path As String, Optional ByVal folderName As String = "New Folder")
                'Check if folder exists, if not: create it
                If Not Directory.Exists(path + "\" + folderName) Then

                    Dim dr As New DirectoryInfo(path + "\" + folderName)
                    dr.Create()
                    'Folder created message
                Else
                    'MsgBox("Folder already exist")
                    'Folder already exists
                End If
            End Sub

            ''' <summary>
            ''' It deletes the folder permanently
            ''' </summary>
            ''' <param name="folderPath">Set the path of your foloder</param>
            ''' <remarks></remarks>
            Public Shared Sub deleteFolder(ByVal folderPath As String)

                If Not Directory.Exists(folderPath) Then
                    Return
                End If

                Dim files() As String
                files = Directory.GetFileSystemEntries(folderPath)

                For Each element As String In files
                    If (Not Directory.Exists(element)) Then
                        File.Delete(Path.Combine(folderPath, Path.GetFileName(element)))
                    End If
                Next

            End Sub

            ''' <summary>
            ''' It sets the attributes of your folder 
            ''' </summary>
            ''' <param name="folderPath">Set the path of your folder</param>
            ''' <remarks></remarks>
            Public Shared Sub setHiddenFolder(ByVal folderPath As String)
                If Directory.Exists(folderPath) Then
                    Dim aDirInfo As New System.IO.DirectoryInfo(folderPath)
                    aDirInfo.Attributes = FileAttributes.Directory Or FileAttributes.Hidden Or FileAttributes.System Or FileAttributes.ReadOnly
                End If
            End Sub

        End Class

        ''' <summary>
        ''' This class handles the file of your computer
        ''' </summary>
        ''' <remarks></remarks>
        Public Class Files

            Enum ExtensionStyle
                WithDots
                NoDots
            End Enum

            Public Function get_FileExtension(ByVal filename As String, Optional ByVal style As ExtensionStyle = ExtensionStyle.WithDots, Optional ByVal numLength As Integer = 3) As String
                If filename <> "" Then
                    If style = ExtensionStyle.NoDots Then
                        Return filename.Substring(filename.Length - 3, numLength)
                    Else
                        If filename.Length > 4 Then
                            Return filename.Substring(filename.Length - (numLength + 1), numLength + 1)
                        Else
                            Return Nothing
                        End If
                    End If
                End If
                Return Nothing
            End Function

            ''' <summary>
            ''' It checks wehter the file exist or not exist
            ''' </summary>
            ''' <param name="filePath">Set the path of your file</param>
            ''' <returns>Returns true if file exist otherwise false if not</returns>
            ''' <remarks></remarks>
            Public Shared Function checkFileExist(ByVal filePath As String)
                If File.Exists(filePath) Then
                    Return True
                Else
                    Return False
                End If
            End Function

            ''' <summary>
            ''' It copies the selected file from one place to another location
            ''' </summary>
            ''' <param name="fromPath">Set the path of the selected file to copy as reference</param>
            ''' <param name="toPath">Set the path of the selected file you want to copy</param>
            ''' <remarks></remarks>
            Public Shared Sub copyFile(ByVal fromPath As String, ByVal toPath As String)
                File.Copy(fromPath, toPath, True)
            End Sub

            ''' <summary>
            ''' It deletes the selected file in your computer
            ''' </summary>
            ''' <param name="filePath">Set the path of your selected file</param>
            ''' <remarks></remarks>
            Public Shared Sub deleteFile(ByVal filePath As String)
                If File.Exists(filePath) Then
                    System.IO.File.SetAttributes(filePath, IO.FileAttributes.Normal)
                    File.Delete(filePath)
                End If
            End Sub

            ''' <summary>
            ''' It moves the selected file from one place to another
            ''' </summary>
            ''' <param name="fromPath">Set the path of the selected file as to be moved into other location</param>
            ''' <param name="toPath">Set the path to where the file to be placed</param>
            ''' <remarks></remarks>
            Public Shared Sub moveFile(ByVal fromPath As String, ByVal toPath As String)
                If File.Exists(fromPath) Then
                    File.Copy(fromPath, toPath)
                    File.Delete(fromPath)
                End If
            End Sub

            ''' <summary>
            ''' It sets the attribute of the selected file
            ''' </summary>
            ''' <param name="filePath">Set the path of your selected file</param>
            ''' <remarks></remarks>
            Public Shared Sub setHiddenFile(ByVal filePath As String)
                Dim aFileInfo As New System.IO.FileInfo(filePath)
                If File.Exists(filePath) Then
                    If (aFileInfo.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then
                        aFileInfo.Attributes = aFileInfo.Attributes And Not FileAttributes.Hidden
                    Else
                        File.SetAttributes(filePath, FileAttributes.Hidden)
                        Dim fileDetail As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(filePath)
                        fileDetail.IsReadOnly = True
                        fileDetail.Attributes = fileDetail.Attributes Or IO.FileAttributes.Hidden Or FileAttributes.System
                    End If
                End If



            End Sub

        End Class

    End Namespace

End Namespace


