Imports PowerNET8.myDocument.Share.XMLDesigner


Module modMain
    Dim init As New PowerNET8.myApplication.Share.SystemCore
    Dim myExceptionHandler As New PowerNET8.myExceptionHandler
'''
    Sub Main()

        PathConfig.writePath(Application.StartupPath)
        AssemblyInfoConfig.writeAssemblyInfo(gAssemblyInfo)

        Dim asd As String = PathConfig.readPath

        myExceptionHandler.Assembly = gAssemblyInfo
        AddHandler Application.ThreadException, AddressOf PowerNET8.myExceptionHandler.OnThreadException
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Dim a As New frmMain
        init.Initialize(a, gBasePath)


    End Sub

End Module
