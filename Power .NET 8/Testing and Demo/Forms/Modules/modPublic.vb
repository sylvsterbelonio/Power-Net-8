Module modPublic

    Public gBasePath As String = PowerNET8.myFile.Share.Location.getBasePath 'BasePath of the System
    Public gAssemblyInfo As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly
    Public gDomainInfo As AppDomain = AppDomain.CurrentDomain
    Public gmySQL As New PowerNET8.mySQL.Init.SQL 'General Variables

    Public gUsername As String = ""
    Public gDatabaseName As String = ""

   

End Module
