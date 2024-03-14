Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Xml
Imports System.IO
Imports myDocument.Share.XMLDesigner
Imports myString.Share
Imports Word = Microsoft.Office.Interop.Word

Namespace myDocument

    Namespace Init

        ''' <summary>
        ''' You can invoke the crystal report viewer functions. Make sure that you have successfully installed the crystal report in your computer and have the right crystal decision libraries to run this class otherwise it will not work correctly. IMPORTANT NOTE: It requires this important DLL as follows: <list>CrystalDecisions.CrystalReports.Engine</list> || CrystalDecisions.Enterprise.Framework || CrystalDecisions.Enterprise.InfoStore || CrystalDecisions.ReportSource || CrystalDecisions.Shared and CrystalDecisions.Windows.Forms 
        ''' </summary>
        ''' <remarks></remarks>
        Public Class CrystalReportViewer

            Private collectionFields As New ParameterFields
            Private ds As New DataSet
            Private PServerName As String = ""
            Private PUserID As String = ""
            Private Pdatabase As String = ""
            Private PPassword As String = ""
            Private myTitle As String = "Crystal Report Viewer"
            Private location_file As String = ""
            Private PrintStyles As ReportStyle = ReportStyle.None
            Private Mypaper_size As ReportSize = ReportSize.None

            ''' <summary>
            ''' You can select either of this type you want to reflect in your report
            ''' </summary>
            ''' <remarks></remarks>
            Enum ReportStyle
                Portrait
                LandScape
                None
            End Enum

            ''' <summary>
            ''' You can select either of this type you want to reflect in your report
            ''' </summary>
            ''' <remarks></remarks>
            Enum ReportSize
                Letter
                Legal
                A3
                A4
                None
            End Enum

            ''' <summary>
            ''' It sets the title of your report
            ''' </summary>
            ''' <value>You can specify anything about your report title</value>
            ''' <remarks></remarks>
            <CLSCompliant(False)> _
            Public WriteOnly Property title() As String
                Set(ByVal value As String)
                    myTitle = value
                End Set
            End Property

            ''' <summary>
            ''' It sets print style of your report
            ''' </summary>
            ''' <value>You can specify what kinds of style you want to generate in your report</value>
            ''' <remarks></remarks>
            <CLSCompliant(False)> _
            Public WriteOnly Property printStyle() As ReportStyle
                Set(ByVal value As ReportStyle)
                    PrintStyles = value
                End Set
            End Property

            ''' <summary>
            ''' It sets print size of your report
            ''' </summary>
            ''' <value>You can specify what kind of paper size you want to generate in your report</value>
            ''' <remarks></remarks>
            Public WriteOnly Property printSize() As ReportSize
                Set(ByVal value As ReportSize)
                    Mypaper_size = value
                End Set
            End Property

            ''' <summary>
            ''' It clears the dataset and all of the tables added in it will be permanently removed
            ''' </summary>
            ''' <remarks></remarks>
            Public Sub clearDataSet()
                ds.Clear()
            End Sub

            ''' <summary>
            ''' You can set your own dataset name for your reference in your report
            ''' </summary>
            ''' <param name="dataSetName">Write the dataset name of your report</param>
            ''' <remarks></remarks>
            Public Sub setDatasetName(Optional ByVal dataSetName As String = "myDatasetname")
                ds.DataSetName = dataSetName
            End Sub

            ''' <summary>
            ''' It clears all the parameters you have previously added to pass into your report
            ''' </summary>
            ''' <remarks></remarks>
            Public Sub clearParameters()
                collectionFields = New ParameterFields
            End Sub

            ''' <summary>
            ''' You can add your own parameter here to pass into your report. Make sure you that have check the name of the parameter so that it will avoid errors during the generation of the report 
            ''' </summary>
            ''' <param name="name">It calls the parameter name object inside of your report</param>
            ''' <param name="value">Set the value of the parameter name field</param>
            ''' <remarks></remarks>
            Public Sub addParameterField(ByVal name As String, ByVal value As Object)
                Dim param1Field As New ParameterField
                Dim param1Range As New ParameterDiscreteValue
                param1Field.ParameterFieldName = name 'set the name object from crystal report
                param1Range.Value = value 'set the value into the object from crystal report
                param1Field.CurrentValues.Add(param1Range) 'assigning the values into the object
                collectionFields.Add(param1Field) 'add the assigned objects into collection
            End Sub


            ''' <summary>
            ''' It clears all the previous tables you have added in the dataset
            ''' </summary>
            ''' <remarks></remarks>
            Public Sub clearTables()
                ds.Tables.Clear()
            End Sub

            ''' <summary>
            ''' You can add your own tables here to pass into your report. Make sure that you have check the table name and his field set that match into your report so that it will display properly.
            ''' </summary>
            ''' <param name="myDataTable">Add your own datatable here</param>
            ''' <remarks></remarks>
            Public Sub addTableField(ByVal myDataTable As DataTable)
                ds.Tables.Add(myDataTable)
            End Sub

            ''' <summary>
            ''' You must set the path of your report in order to load the report
            ''' </summary>
            ''' <param name="location">Specify the current location of your report</param>
            ''' <param name="IsApplicationSourceIncluded">THIS IS OPTIONAL:[default=true] If you set as true then the system will automatically find your base path of your system otherwise you can specify manually other than your system suggest</param>
            ''' <remarks></remarks>
            Public Sub reportPath(ByVal location As String, Optional ByVal IsApplicationSourceIncluded As Boolean = True)
                If IsApplicationSourceIncluded Then
                    location_file = myFile.Share.Location.getBasePath + "\" + location
                Else
                    location_file = location
                End If
            End Sub

            ''' <summary>
            ''' It writes down all your dataset created in your report for verification purpose only
            ''' </summary>
            ''' <param name="location">You can specify the current location to where you want to create an XML file for your report</param>
            ''' <remarks></remarks>
            Public Sub setXML(Optional ByVal location As String = "sample.xml")
                ds.WriteXml(location, XmlWriteMode.WriteSchema)
            End Sub

            ''' <summary>
            ''' It writes down all your dataset schema in your report for verification purpose only
            ''' </summary>
            ''' <param name="location">You can specify the current location to where you want to create an XML Schema file for your report</param>
            ''' <remarks></remarks>
            Public Sub setXMLSchema(Optional ByVal location As String = "sample.xsd")
                ds.WriteXmlSchema(location)
            End Sub

            ''' <summary>
            ''' It reads an XML file that will be used as your reference in your report
            ''' </summary>
            ''' <param name="location">Set location to find the existing XML file</param>
            ''' <remarks></remarks>
            Public Sub readXML(Optional ByVal location As String = "sample.xml")
                Try
                    Dim fs1 = New System.IO.FileStream(location, IO.FileMode.Open)
                    ds.ReadXml(fs1)
                Catch ex As Exception
                    myExceptionHandler.OnThreadException(ex)
                End Try
            End Sub

            ''' <summary>
            ''' It reads an XML Schema file that will be used as your reference in your report
            ''' </summary>
            ''' <param name="location">Set location to find the existing XML Schema file</param>
            ''' <remarks></remarks>
            Public Sub readXMLSchema(Optional ByVal location As String = "sample.xsd")
                Try
                    Dim fs1 = New System.IO.FileStream(location, IO.FileMode.Open)
                    ds.ReadXmlSchema(fs1)
                Catch ex As Exception
                    myExceptionHandler.OnThreadException(ex)
                End Try
            End Sub

            ''' <summary>
            ''' You can manually set your log in settings in your report
            ''' </summary>
            ''' <param name="serverName">Set your server name</param>
            ''' <param name="userID">Set your user ID</param>
            ''' <param name="database">Set your database name</param>
            ''' <param name="password">Set your password</param>
            ''' <remarks></remarks>
            Public Sub setLogOnSettings(ByVal serverName As String, ByVal userID As String, ByVal database As String, ByVal password As String)
                PServerName = serverName
                PUserID = userID
                Pdatabase = database
                PPassword = password
            End Sub

            ''' <summary>
            ''' Execute the final action command once you have successfully set all the datasets,tables,parameter fields, report style and report path
            ''' </summary>
            ''' <remarks></remarks>
            Public Sub launchReport()
                Dim frm As New frmCrystalReportViewer
                'formz.Hide()
                With frm

                    .ci_serverName = PServerName
                    .ci_userID = PUserID
                    .ci_database = Pdatabase
                    .ci_password = PPassword

                    .setPaperStyle(PrintStyles)
                    .setPaperSize(Mypaper_size)

                    If Not collectionFields Is Nothing Then
                        If collectionFields.Count > 0 Then
                            .collectionFields = collectionFields
                            .rptViewer.ParameterFieldInfo = collectionFields 'set parameters
                        End If
                    End If

                    'FILE INFO
                    .ReportPath = location_file

                    'crystal report attributes
                    .rptViewer.DisplayGroupTree = False
                    .rptViewer.EnableDrillDown = False

                    'form attributes
                    .ShowInTaskbar = False
                    .setTitle(myTitle)
                    'PARAMETER FILTER AND DISPLAY
                    If Not ds Is Nothing Then
                        If ds.Tables.Count > 0 Then .setDS(ds) 'set data set
                    End If

                    If location_file <> "" Then
                        .ShowDialog()
                    Else
                        MsgBox("There is no file loaded")
                    End If

                End With
            End Sub

        End Class

        ''' <summary>
        ''' You can allow to invoke the Microsoft Report Viewer functions. Make you have successfuly designed a report and have the right .dll libraries to use this function. IMPORTANT NOTE: It requires this kind of dll as follows: Microsoft.ReportViewer.Common and Microsoft.ReportViewer.WinForms
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Public Class MicrosoftReportViewer

            Private ds As New DataSet
            Private ParameterCollection(99) As ParameterField
            Private countParameter As Integer = 0
            Private myTitle As String = "Microsoft Report Viewer"
            Private location_file As String = ""
            Private myEmbeddedType As EmbeddedType = EmbeddedType.ReportEmbeddedResource

            ''' <summary>
            ''' This structure lets the one object carries two sub variables such as Name and Value of the parameter field
            ''' </summary>
            ''' <remarks></remarks>
            Public Structure ParameterField
                Public name As String
                Public value As Object
            End Structure

            ''' <summary>
            ''' Report Path is used for outside file to be called in your system. ReportEmbeddedResource is used if your report is inside of your solution project
            ''' </summary>
            ''' <remarks></remarks>
            Enum EmbeddedType
                ReportPath
                ReportEmbeddedResource
            End Enum

            ''' <summary>
            ''' It sets the title of your report
            ''' </summary>
            ''' <value>You can specify anything about your report title</value>
            ''' <remarks></remarks>
            <CLSCompliant(False)> _
            Public WriteOnly Property title() As String
                Set(ByVal value As String)
                    myTitle = value
                End Set
            End Property

            ''' <summary>
            ''' You can specify what type of path that will take your report to be displayed. You can choose the location either in your project solution or outside of your project solution
            ''' </summary>
            ''' <value></value>
            ''' <remarks></remarks>
            <CLSCompliant(False)> _
            Public WriteOnly Property reportPathType() As EmbeddedType
                Set(ByVal value As EmbeddedType)
                    myEmbeddedType = value
                End Set
            End Property


            ''' <summary>
            ''' It clears the dataset and all of the tables added in it will be permanently removed
            ''' </summary>
            ''' <remarks></remarks>
            Public Sub clearDataSet()
                ds.Clear()
            End Sub

            ''' <summary>
            ''' You can set your own dataset name for your reference in your report
            ''' </summary>
            ''' <param name="dataSetName">Write the dataset name of your report</param>
            ''' <remarks></remarks>
            Public Sub setDatasetName(Optional ByVal dataSetName As String = "myDatasetname")
                ds.DataSetName = dataSetName
            End Sub


            ''' <summary>
            ''' It clears all the parameters you have previously added to pass into your report
            ''' </summary>
            ''' <remarks></remarks>
            Public Sub clearParameters()
                countParameter = 0
            End Sub

            ''' <summary>
            ''' You can add your own parameter here to pass into your report. Make sure you that have check the name of the parameter so that it will avoid errors during the generation of the report 
            ''' </summary>
            ''' <param name="name">It calls the parameter name object inside of your report</param>
            ''' <param name="value">Set the value of the parameter name field</param>
            ''' <remarks></remarks>
            Public Sub addParameterField(ByVal name As String, ByVal value As Object)
                ParameterCollection(countParameter).name = name
                ParameterCollection(countParameter).value = value
                countParameter += 1
            End Sub


            ''' <summary>
            ''' It clears all the previous tables you have added in the dataset
            ''' </summary>
            ''' <remarks></remarks>
            Public Sub clearTables()
                ds.Tables.Clear()
            End Sub

            ''' <summary>
            ''' You can add your own tables here to pass into your report. Make sure that you have check the table name and his field set that match into your report so that it will display properly.
            ''' </summary>
            ''' <param name="myDataTable">Add your own datatable here</param>
            ''' <remarks></remarks>
            Public Sub addTableField(ByVal myDataTable As DataTable)
                ds.Tables.Add(myDataTable)
            End Sub


            ''' <summary>
            ''' You must set the path of your report in order to load the report
            ''' </summary>
            ''' <param name="location">Specify the current location of your report</param>
            ''' <param name="IsApplicationSourceIncluded">THIS IS OPTIONAL:[default=true] If you set as true then the system will automatically find your base path of your system otherwise you can specify manually other than your system suggest</param>
            ''' <remarks></remarks>
            Public Sub reportPath(ByVal location As String, Optional ByVal IsApplicationSourceIncluded As Boolean = True)
                If IsApplicationSourceIncluded And myEmbeddedType = EmbeddedType.ReportPath Then
                    location_file = myFile.Share.Location.getBasePath + "\" + location
                Else
                    location_file = location
                End If
            End Sub


            ''' <summary>
            ''' It writes down all your dataset created in your report for verification purpose only
            ''' </summary>
            ''' <param name="location">You can specify the current location to where you want to create an XML file for your report</param>
            ''' <remarks></remarks>
            Public Sub setXML(Optional ByVal location As String = "sample.xml")
                ds.WriteXml(location, XmlWriteMode.WriteSchema)
            End Sub

            ''' <summary>
            ''' It writes down all your dataset schema in your report for verification purpose only
            ''' </summary>
            ''' <param name="location">You can specify the current location to where you want to create an XML Schema file for your report</param>
            ''' <remarks></remarks>
            Public Sub setXMLSchema(Optional ByVal location As String = "sample.xsd")
                ds.WriteXmlSchema(location)
            End Sub

            ''' <summary>
            ''' It reads an XML file that will be used as your reference in your report
            ''' </summary>
            ''' <param name="location">Set location to find the existing XML file</param>
            ''' <remarks></remarks>
            Public Sub readXML(Optional ByVal location As String = "sample.xml")
                Dim fs1 = New System.IO.FileStream(location, IO.FileMode.Open)
                Try
                    ds.ReadXml(fs1)
                Catch ex As Exception
                End Try
            End Sub

            ''' <summary>
            ''' It reads an XML Schema file that will be used as your reference in your report
            ''' </summary>
            ''' <param name="location">Set location to find the existing XML Schema file</param>
            ''' <remarks></remarks>
            Public Sub readXMLSchema(Optional ByVal location As String = "sample.xsd")
                Dim fs1 = New System.IO.FileStream(location, IO.FileMode.Open)
                ds.ReadXmlSchema(fs1)
            End Sub


            ''' <summary>
            ''' Execute the final action command once you have successfully set all the datasets,tables,parameter fields, report style and report path
            ''' </summary>
            ''' <remarks></remarks>
            Public Sub launchReport()
                Dim frm As New MRV
                With frm

                    'DataTable Field
                    .ds = ds

                    'Parameter Field
                    .ParameterCollection = ParameterCollection
                    .countParameter = countParameter

                    'Report Path/Report Resources
                    .EmbeddedResource = location_file
                    .EmbeddedType = myEmbeddedType

                    'Properties
                    .ReportTitle = myTitle
                    .ShowInTaskbar = False
                    .MaximizeBox = False
                    .WindowState = FormWindowState.Maximized
                    .MinimizeBox = False

                    'show event 
                    .ShowDialog()
                End With
            End Sub

        End Class

        Public Class MicrosoftWordViewer
            Dim word_app As Word._Application = New Word.ApplicationClass()

            ' Create the Word document.
            Dim word_doc As Word._Document = word_app.Documents.Add()
            Public Sub outlineConverter(ByRef treeView As TreeView, ByVal title As String, Optional ByVal author As String = "", Optional ByVal outlineHeader As String = "")
                first = 0
                word_doc.PageSetup.PaperSize = Word.WdPaperSize.wdPaperLetter

                'MARGIN SIZE
                word_doc.PageSetup.TopMargin = 50
                word_doc.PageSetup.BottomMargin = 50
                word_doc.PageSetup.LeftMargin = 50
                word_doc.PageSetup.RightMargin = 50

                word_app.Visible = True

                Dim footerRange As Word.Range = word_doc.Sections(1).Footers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range
                Dim headerRange As Word.Range = word_doc.Sections(1).Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range

                headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                headerRange.Text = "OUTLINE SUBJECT STUDIES - Alliance In Motion Global Inc."
                footerRange.Font.Size = 8
                footerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                footerRange.Text = "Date Printed: " + Now.ToString("yyyy-MM-dd hh:mm:ss tt")

                ' Set the Range to the first paragraph.
                Dim rng As Word.Range = word_doc.Paragraphs(1).Range
                ' Change the formatting. To change the font size for a right-to-left language, 
                ' such as Arabic or Hebrew, use the Font.SizeBi property instead of Font.Size.
                'Insert a paragraph at the beginning of the document.
                Dim oPara1 As Word.Paragraph, oPara2 As Word.Paragraph


                oPara1 = word_doc.Content.Paragraphs.Add
                oPara1.Range.Text = title
                oPara1.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                oPara1.Range.Font.Size = 24
                oPara1.Range.Font.Bold = True
                oPara1.Format.SpaceAfter = 10    '24 pt spacing after paragraph.
                oPara1.Range.InsertParagraphAfter()

                'Insert a paragraph at the end of the document.
                '** \endofdoc is a predefined bookmark.
                oPara2 = word_doc.Content.Paragraphs.Add
                oPara2.Range.Text = author
                oPara1.Range.Font.Size = 14
                oPara2.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                oPara2.Range.Font.Bold = False
                oPara2.Range.Font.Italic = True
                oPara2.Format.SpaceAfter = 14
                oPara2.Range.InsertParagraphAfter()
                oPara2.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify

                Dim aNode As TreeNode
                Dim count As Integer = 0
                For Each aNode In treeView.Nodes
                    recursiveNodePrint(0, aNode, outlineHeader)
                Next

                ' Save the document.

                Dim WorkingFolder = "Templates\"
                Dim FileNamex As String = title
                FileNamex = FileNamex.Replace("\", "")
                FileNamex = FileNamex.Replace("/", "")

                Dim NameExt As String = ".docx"

                Dim WorkingFile As String

                ''//The file that we are creating
                If Not NameExt Is Nothing Then
                    If NameExt.ToLower = "" Then
                        WorkingFile = Path.Combine(WorkingFolder, FileNamex)
                    Else
                        WorkingFile = Path.Combine(WorkingFolder, FileNamex + ".docx")
                    End If
                Else
                    WorkingFile = Path.Combine(WorkingFolder, "output.docx")
                End If


                Dim filename As Object = WorkingFile
                Try
                    word_doc.SaveAs(FileName:=filename)
                Catch ex As Exception
                    'myDialog.show("You cannot save this file because it is either the system is write protected/secured. Try another location to save the document")
                End Try


                ' Close.
                Dim save_changes As Object = False

                'If .chkAutoOpen.Checked = False Then
                '    word_doc.Close(save_changes)
                '    word_app.Quit(save_changes)
                'End If
            End Sub

            Dim first As Integer = 0

            Private Sub recursiveNodePrint(ByVal Listlevel As Integer, ByRef treenode As TreeNode, Optional ByVal outH As String = "")
                Dim node As TreeNode

                If first = 0 Then
                    first += 1
                    Dim paragraphx As Word.Paragraph
                    paragraphx = word_doc.Content.Paragraphs.Add
                    paragraphx.Range.Text = outH
                    paragraphx.Format.SpaceAfter = 10
                    paragraphx.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
                    paragraphx.Range.InsertParagraphAfter()
                    paragraphx.Range.ListFormat.ApplyOutlineNumberDefault()
                End If

                Dim paragraph As Word.Paragraph

                paragraph = word_doc.Content.Paragraphs.Add

                paragraph.Range.Text = treenode.Text
                paragraph.Format.SpaceAfter = 10
                paragraph.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
                formatNodeFont(treenode, paragraph)
                paragraph.Range.ListFormat.ListLevelNumber = 1 + Listlevel
                paragraph.Range.InsertParagraphAfter()


                For Each node In treenode.Nodes
                    recursiveNodePrint(Listlevel + 1, node)
                Next

            End Sub

            Private Sub formatNodeFont(ByRef nodes As TreeNode, ByRef paragraph As Word.Paragraph)
                With paragraph.Range.Font
                    If nodes.NodeFont.Italic And nodes.NodeFont.Underline And nodes.NodeFont.Bold Then
                        .Italic = True
                        .Bold = True
                        .Underline = True
                    ElseIf nodes.NodeFont.Bold And nodes.NodeFont.Italic Then
                        .Italic = True
                        .Bold = True
                        .Underline = False
                    ElseIf nodes.NodeFont.Bold And nodes.NodeFont.Underline Then
                        .Italic = False
                        .Bold = True
                        .Underline = True
                    ElseIf nodes.NodeFont.Italic And nodes.NodeFont.Underline Then
                        .Italic = True
                        .Bold = False
                        .Underline = True
                    ElseIf nodes.NodeFont.Bold Then
                        .Italic = False
                        .Bold = True
                        .Underline = False
                    ElseIf nodes.NodeFont.Italic Then
                        .Italic = True
                        .Bold = False
                        .Underline = False
                    ElseIf nodes.NodeFont.Underline Then
                        .Italic = False
                        .Bold = False
                        .Underline = True
                    Else
                        .Italic = False
                        .Bold = False
                        .Underline = False
                    End If
                End With
            End Sub


        End Class

    End Namespace



    Namespace Share

        Namespace XMLDesigner

            ''' <summary>
            ''' This class is for writing and reading an XML file for the purpose of reconnecting the mySQL server everytime the system will launch by the user. You just don't need to hard code the SQL configuration. PURPOSE: To avoid static variables when the settings of the SQL has been changed and to minimize inconsistency of the program code
            ''' </summary>
            ''' <remarks></remarks>
            Public Class DatabaseConfig

                ''' <summary>
                ''' It gets a local XML file within your system that helps to load your previous MSQL configuration settings
                ''' </summary>
                ''' <param name="basePath">Specify the current location of your XML file</param>
                ''' <remarks></remarks>
                Public Shared Sub readDatabaseConfig(ByVal basePath As String)

                    'CREATE TEMPLATES FOLDER'
                    myFile.Share.Folders.createFolder(basePath, "Templates")
                    myFile.Share.Folders.setHiddenFolder(basePath + "\Templates")

                    Dim FilePath As String = basePath + "\Templates\myConnectionString.xml"
                    If File.Exists(FilePath) Then
                        Using reader As XmlReader = XmlReader.Create(FilePath)
                            If Not reader Is Nothing Then
                                Try
                                    While reader.Read()
                                        ' Check for start elements.
                                        If reader.IsStartElement() Then
                                            ' See if perls element or article element.
                                            If reader.Name <> "DatabaseConfigurationList" And reader.Name <> "" Then
                                                With reader
                                                    Dim frm As New Form
                                                    frm.Tag = "ACCESS SQL CONFIGURATION"
                                                    add_configMysql(frm, myString.Share.EnDecryption.Execute(.GetAttribute("DatabaseName")), myString.Share.EnDecryption.Execute(.GetAttribute("ServerName")), myString.Share.EnDecryption.Execute(.GetAttribute("UserName")), myString.Share.EnDecryption.Execute(.GetAttribute("Password")), myString.Share.EnDecryption.Execute(.GetAttribute("Port")))
                                                End With
                                            End If
                                        End If
                                    End While
                                Catch ex As Exception
                                    MsgBox("There is no database configuration found in the file")
                                End Try
                            End If
                        End Using
                    Else
                        MsgBox("Please configure the mysql settings")
                        Dim frm As New PowerNET8.SC
                        With frm
                            .runCode = ""
                            .ShowDialog()
                        End With
                    End If
                End Sub

                ''' <summary>
                ''' It writes and creates an XML File to save your current MYSQL configuration settings
                ''' </summary>
                ''' <param name="basePath">Specify the current location of your XML file</param>
                ''' <remarks></remarks>
                Public Shared Sub writeDatabaseConfig(ByVal basePath As String)
                    ' Create XmlWriterSettings.
                    Dim settings As XmlWriterSettings = New XmlWriterSettings()
                    Dim rows As Integer = 1
                    settings.Indent = True
                    ' Create XmlWriter.
                    Using writer As XmlWriter = XmlWriter.Create(basePath + "\Templates\myConnectionString.xml", settings)
                        ' Begin writing.
                        With writer
                            .WriteStartDocument()
                            .WriteStartElement("DatabaseConfigurationList") ' Root.
                            .WriteAttributeString("Type", "String Connection")
                            .WriteAttributeString("Product", modApp.getProduct)
                            .WriteAttributeString("Company", modApp.getCompany)
                            .WriteAttributeString("Copyright", modApp.getCopyright)
                            .WriteAttributeString("Version", modApp.getVersionProduct)
                            .WriteAttributeString("Developer", DeveloperProgrammer)

                            Dim myData As New ArrayList
                            showListDatabase(myData)
                            For i As Integer = 0 To myData.Count - 1
                                Dim col() As String = getListDatabaseInfo(myData.Item(i)).ToString.Split(",")
                                .WriteStartElement("DatabaseNo" + rows.ToString) 'DATABASE NAME HERE:'
                                .WriteAttributeString("ServerName", myString.Share.EnDecryption.Execute(col(0)))
                                .WriteAttributeString("UserName", myString.Share.EnDecryption.Execute(col(1)))
                                .WriteAttributeString("Password", myString.Share.EnDecryption.Execute(col(2)))
                                .WriteAttributeString("Port", myString.Share.EnDecryption.Execute(col(3)))
                                .WriteAttributeString("DatabaseName", myString.Share.EnDecryption.Execute(col(4)))
                                .WriteAttributeString("USER", myString.Share.EnDecryption.Execute(col(5)))
                                .WriteEndElement()
                                rows += 1
                            Next
                            .WriteEndElement()
                            .WriteEndDocument()
                        End With
                    End Using


                End Sub

            End Class

            ''' <summary>
            ''' This class is for writing and reading an XML File for the purpose of restoring the previous program locatin everytime the user launced the system
            ''' </summary>
            ''' <remarks></remarks>
            Public Class PathConfig

                ''' <summary>
                ''' It writes and creates an XML File to store your current base path location of your system
                ''' </summary>
                ''' <param name="basePath">Specify the current location of your XML file</param>
                ''' <remarks></remarks>
                Public Shared Sub writePath(ByVal basePath As String)
                    Dim settings As XmlWriterSettings = New XmlWriterSettings()
                    Dim rows As Integer = 1
                    settings.Indent = True

                    'CREATE TEMPLATES FOLDER'
                    myFile.Share.Folders.createFolder(basePath, "Templates")
                    myFile.Share.Folders.setHiddenFolder(basePath + "\Templates")
                    myFile.Share.Folders.createFolder(basePath + "\Templates", "Applications")
                    myFile.Share.Folders.setHiddenFolder(basePath + "\Templates\Applications")

                    myFile.Share.Files.deleteFile(basePath + "\Templates\Applications\myPath.xml")
                    Try
                        Using writer As XmlWriter = XmlWriter.Create(basePath + "\Templates\Applications\myPath.xml", settings)
                            With writer
                                .WriteStartDocument()
                                .WriteStartElement("systemPathConfiguration") ' Root.

                                .WriteStartElement("basePath") ''
                                .WriteAttributeString("value", myString.Share.EnDecryption.Execute(basePath))

                                .WriteEndElement()
                                .WriteEndDocument()
                            End With
                        End Using

                        PowerNET8.myFile.Share.Files.setHiddenFile(basePath + "\Templates\myPath.xml")
                    Catch ex As Exception
                        myExceptionHandler.OnThreadException(ex)
                    End Try


                End Sub

                ''' <summary>
                ''' It reads an XML File to retrieve the previouse base path location of your system
                ''' </summary>
                ''' <returns>Specify the current location of your XML file</returns>
                ''' <remarks></remarks>
                Public Shared Function readPath()

                    Dim FilePath As String = Application.StartupPath + "\Templates\Applications\myPath.xml"
                    If File.Exists(FilePath) Then
                        Using reader As XmlReader = XmlReader.Create(FilePath)
                            If Not reader Is Nothing Then
                                Try
                                    While reader.Read()
                                        ' Check for start elements.
                                        If reader.IsStartElement() Then
                                            ' See if perls element or article element.
                                            If reader.Name <> "systemPathConfiguration" And reader.Name <> "" Then
                                                With reader
                                                    Return myString.Share.EnDecryption.Execute(.GetAttribute("value"))
                                                End With

                                            End If
                                        End If
                                    End While
                                Catch ex As Exception
                                    myExceptionHandler.OnThreadException(ex, "There is no database configuration found in the file")
                                End Try
                            End If
                        End Using
                    Else
                        writePath(Application.StartupPath)
                        Return readPath()
                    End If
                    Return Nothing
                End Function

            End Class

            ''' <summary>
            ''' This clas is not intented to use from other programmer because this is for privacy of the developer of this class. This is for private purpose only to auto generate the updates, credits and other licences
            ''' </summary>
            ''' <remarks></remarks>
            Public Class License

                ''' <summary>
                ''' The system will auto generate a license agreement for the legalities of the project being made by the .NET programmers
                ''' </summary>
                ''' <param name="runCode">It needs an authentication by the developer to use this shared function</param>
                ''' <remarks></remarks>
                Public Shared Sub writeLicense(Optional ByVal runCode As String = "")
                    If runCode = "masterkey" Then

                        myFile.Share.Folders.createFolder(myDocument.Share.XMLDesigner.PathConfig.readPath + "\Templates", "Help")

                        'myFile.Share.Files.deleteFile(PathConfig.readPath + "\Templates\Help\license.rtf")
                        'File.Create(PathConfig.readPath + "\Templates\license.rtf")
                        Dim filepath_fromtextbox As String = PathConfig.readPath + "\Templates\Help\license.rtf"

                        If Not File.Exists(filepath_fromtextbox) Then

                            Dim AI As New myDocument.Share.XMLDesigner.AssemblyInfoConfig
                            AI.readAssemblyInfo()

                            Dim myAssembly As New myApplication.Init.AssemblyInformation

                            Using sw As IO.StreamWriter = New IO.StreamWriter(filepath_fromtextbox)

                                sw.WriteLine("I. End-User License Agreement" + vbCrLf + vbCrLf)
                                sw.WriteLine("IMPORTANT-READ CAREFULLY: This End-User License Agreement EULA is a legal agreement between you (either an individual or a single entity) and " + AI.Company.ToUpper + " for the software product identified above, which includes computer software and may include associated media, printed materials, ""online"" or electronic documentation, and Internet-based services (""Product""). An amendment or addendum to this EULA may accompany the Product. YOU AGREE TO BE BOUND BY THE TERMS OF THIS EULA BY INSTALLING, COPYING, OR OTHERWISE USING THE PRODUCT. IF YOU DO NOT AGREE, DO NOT INSTALL OR USE THE PRODUCT; YOU MAY RETURN IT TO YOUR PLACE OF PURCHASE." + vbCrLf + vbCrLf)
                                With sw
                                    .WriteLine("1. GRANT OF LICENSE. " + AI.Company.ToUpper + " grants you the following rights provided that you comply with all terms and conditions of this EULA:" + vbCrLf + vbCrLf)
                                    .WriteLine("* Installation and use.  You may install, use, access, display and run one copy of the Product on a single computer, such as a workstation, terminal or other device (""Workstation Computer""). The Product may not be used by more than two (2) processors at  any one time on any single Workstation Computer. " + vbCrLf + vbCrLf)
                                    .WriteLine("* In case of Local Area Network (LAN) release of the product, an amendment to this EULA shall be issued accordingly to govern the use of such release." + vbCrLf + vbCrLf)
                                    .WriteLine("* Reservation of Rights. " + AI.Company.ToUpper + " reserves all rights not expressly granted to you in this EULA." + vbCrLf + vbCrLf)
                                    .WriteLine("2. UPGRADES. To use a Product identified as an upgrade, you must first be licensed for the product identified by " + AI.Company.ToUpper + " as eligible for the upgrade. After upgrading, you may no longer use the product that formed the basis for your upgrade eligibility." + vbCrLf + vbCrLf)
                                    .WriteLine("3. ADDITIONAL SOFTWARE/SERVICES. This EULA applies to updates, supplements, add-on components, or Internet-based services components, of the Product that " + AI.Company.ToUpper + " may provide to you or make available to you after the date you obtain your initial copy of the Product, unless we provide other terms along with the update, supplement, add-on component, or Internet-based services    component.  " + AI.Company.ToUpper + " reserves the right to discontinue any    Internet-based services provided to you or made available to you through the use of the Product.  This EULA does not grant you any rights to modify, use and alter any of the components created and used by the " + AI.Company.ToUpper + " software in offering services and products." + vbCrLf + vbCrLf)
                                    .WriteLine("4. TRANSFER-Internal.  You may move the Product to a different    Workstation Computer.  After the transfer, you must completely remove the Product from the former Workstation Computer. Transfer to Third Party. The initial user of the Product may not make any transfer of the Product to another end user. No Rental. You may not rent, lease, lend or provide commercial services to third parties with the    Product. " + vbCrLf + vbCrLf)
                                    .WriteLine("5. LIMITATION ON REVERSE ENGINEERING, DECOMPILATION, AND DISASSEMBLY. You may not reverse engineer, decompile, or disassemble the Product, except and only to the extent that it is expressly permitted by applicable law notwithstanding this limitation.  " + vbCrLf + vbCrLf)
                                    .WriteLine("6. TERMINATION. Without prejudice to any other rights, " + AI.Company.ToUpper + " may cancel this EULA if you do not abide by the terms and conditions of this EULA, in which case you must destroy all copies of the Product and all of its component parts." + vbCrLf + vbCrLf)
                                    .WriteLine("7. DESCRIPTION OF OTHER RIGHTS AND LIMITATIONS. Consent to Use of Data. You agree that " + AI.Company.ToUpper + " and its affiliates may collect and use technical information gathered in any manner as part of the product support services provided to you, if any, related to the Product. " + AI.Company.ToUpper + " may use this information solely to improve      our products or to provide customized services or technologies to you. " + AI.Company.ToUpper + " may disclose this information to others, but not in a form that personally identifies you, unless with your express consent. Your identity, however, as a client of " + AI.Company.ToUpper + ", or this product is not confidential information." + vbCrLf + vbCrLf)
                                    .WriteLine("8. NOT FOR RESALE SOFTWARE. Product identified as ""Not for Resale"" or ""NFR,"" may not be resold, transferred or used for any purpose." + vbCrLf + vbCrLf)
                                    .WriteLine("9. LIMITED WARRANTY FOR PRODUCT " + vbCrLf + vbCrLf)
                                    .WriteLine("" + AI.Company.ToUpper + " warrants that the Product will perform substantially in accordance with the accompanying materials for a period of thirty days from the date of receipt. " + vbCrLf + vbCrLf)
                                    .WriteLine("If an implied warranty or condition is created by your state/jurisdiction and federal or state/provincial law prohibits disclaimer of it, you also have an implied warranty or condition, BUT ONLY AS TO DEFECTS DISCOVERED DURING THE PERIOD OF THIS LIMITED WARRANTY (THIRTY DAYS).    AS TO ANY DEFECTS DISCOVERED AFTER THE THIRTY (30) DAY PERIOD, THERE IS NO WARRANTY OR CONDITION OF ANY KIND. " + vbCrLf + vbCrLf)
                                    .WriteLine("Any supplements or updates to the Product, including without limitation, any (if any) service packs or hot fixes provided to you after the expiration of the thirty day Limited Warranty period are not covered by any warranty or   condition, express, implied or statutory" + vbCrLf + vbCrLf)
                                    .WriteLine("LIMITATION ON REMEDIES; NO CONSEQUENTIAL OR OTHER DAMAGES. Your exclusive remedy for any breach of this Limited Warranty is as set forth below.  Except for any refund elected by " + AI.Company.ToUpper + ", YOU ARE NOT ENTITLED TO ANY DAMAGES, INCLUDING BUT NOT    LIMITED TO CONSEQUENTIAL DAMAGES, if the Product does not meet " + AI.Company.ToUpper + "'s Limited Warranty, and, to the maximum extent allowed by applicable law, even if any remedy fails of its essential purpose. This    Limited Warranty gives you specific legal rights.  You may have others which vary from state/jurisdiction to state/jurisdiction. YOUR EXCLUSIVE REMEDY.  " + AI.Company.ToUpper + "'s and its suppliers' entire liability and your exclusive    remedy shall be, at " + AI.Company.ToUpper + "'s option from time to time exercised subject to applicable law, (a) return of the price paid (if any) for the Product, or (b) repair or replacement of the Product, that does not meet this Limited Warranty and that is returned to " + AI.Company.ToUpper + " with a copy of your receipt. You will receive the remedy elected by " + AI.Company.ToUpper + " without charge, except that you are responsible for any expenses you may incur (e.g. cost of    shipping the Product to " + AI.Company.ToUpper + ").  This Limited Warranty is void if failure of the Product has resulted from accident, abuse, misapplication, abnormal use or a virus. Any replacement Product will be warranted for the    remainder of the original warranty period or ten (10) days, whichever is longer." + vbCrLf + vbCrLf)
                                    .WriteLine("12. DISCLAIMER OF WARRANTIES. The Limited Warranty that appears above is the only express warranty made to you and is provided in lieu of any other express warranties (if any) created by any documentation,    packaging, or other communications.  Except for the Limited    Warranty and to the maximum extent permitted by applicable law, " + AI.Company.ToUpper + " and its suppliers provide the Product and support services (if any) AS IS AND WITH ALL FAULTS, and hereby disclaim all other warranties and conditions, either express, implied or statutory, including, but not limited to, any (if any) implied warranties, duties or conditions of merchantability, of fitness for a particular purpose, of reliability or availability, of accuracy or completeness of responses, of results, of workmanlike effort, of lack of viruses, and of lack of negligence, all with regard to the Product, and the provision of or failure to provide support or other services, information, software, and    related content through the Product or otherwise arising out of the use of the Product.  ALSO, THERE IS NO WARRANTY OR CONDITION OF TITLE, QUIET ENJOYMENT, QUIET POSSESSION, AND CORRESPONDENCE TO DESCRIPTION OR NON-INFRINGEMENT WITH REGARD TO THE PRODUCT." + vbCrLf + vbCrLf)
                                    .WriteLine("13. EXCLUSION OF INCIDENTAL, CONSEQUENTIAL AND CERTAIN OTHER DAMAGES.  TO THE MAXIMUM EXTENT PERMITTED BY APPLICABLE LAW, IN NO EVENT SHALL " + AI.Company.ToUpper + " OR ITS    SUPPLIERS BE LIABLE FOR ANY SPECIAL, INCIDENTAL, PUNITIVE, INDIRECT, OR CONSEQUENTIAL DAMAGES WHATSOEVER (INCLUDING, BUT NOT LIMITED TO, DAMAGES    FOR LOSS OF PROFITS OR CONFIDENTIAL OR OTHER INFORMATION, FOR BUSINESS INTERRUPTION, FOR PERSONAL INJURY, FOR LOSS OF PRIVACY, FOR FAILURE TO MEET ANY DUTY INCLUDING OF GOOD FAITH OR OF REASONABLE CARE, FOR NEGLIGENCE, AND FOR ANY OTHER PECUNIARY OR OTHER LOSS WHATSOEVER) ARISING OUT OF OR IN ANY WAY RELATED TO THE USE OF OR INABILITY TO USE THE PRODUCT, THE PROVISION OF OR FAILURE TO PROVIDE SUPPORT OR OTHER SERVICES, INFORMATON, SOFTWARE, AND RELATED CONTENT THROUGH THE PRODUCT OR OTHERWISE ARISING OUT OF THE USE OF THE PRODUCT, OR OTHERWISE UNDER OR IN CONNECTION WITH ANY PROVISION OF THIS EULA, EVEN IN THE EVENT OF THE FAULT, TORT (INCLUDING NEGLIGENCE), STRICT LIABILITY, BREACH OF CONTRACT OR BREACH OF WARRANTY OF " + AI.Company.ToUpper + " OR ANY SUPPLIER, AND EVEN IF " + AI.Company.ToUpper + " OR ANY SUPPLIER HAS BEEN ADVISED OF THE    POSSIBILITY OF SUCH DAMAGES. " + vbCrLf + vbCrLf)
                                    .WriteLine("14. LINKS TO THIRD PARTY SITES.  You may link to third party sites through the use of the Product.  The third party sites are not under the control of " + AI.Company.ToUpper + ", and " + AI.Company.ToUpper + " is not responsible for the contents of any third party sites, any links contained in third party    sites, or any changes or updates to third party sites. " + AI.Company.ToUpper + " is not responsible for webcasting or any other form of transmission received from any third party sites. " + AI.Company.ToUpper + " is providing these links to third party sites to you only as a convenience, and the inclusion of any link does not imply an endorsement by " + AI.Company.ToUpper + " of the third party site." + vbCrLf + vbCrLf)
                                    .WriteLine("15. LIMITATION OF LIABILITY AND REMEDIES. Notwithstanding any damages that you might incur for any reason whatsoever (including, without limitation, all damages referenced above and all direct or general damages), the entire liability of " + AI.Company.ToUpper + " and any of its    suppliers under any provision of this EULA and your exclusive remedy for all of the foregoing (except for any remedy of repair or replacement elected by " + AI.Company.ToUpper + " with respect to any breach of the Limited Warranty) shall be limited to the greater of the amount actually paid by you for the Product or U.S.$5.00.  " + vbCrLf + vbCrLf)
                                    .WriteLine("16. ENTIRE AGREEMENT.  This EULA (including any addendum or amendment to this EULA which is included with the Product) are the entire agreement between you and " + AI.Company.ToUpper + " relating to the Product and the support services (if any) and they supersede all prior or contemporaneous oral or written communications,  proposals and    representations with respect to the Product or any other subject matter covered by this EULA.  To the extent the terms of any " + AI.Company.ToUpper + " policies or programs for support services conflict with the terms of this EULA, the terms of this EULA shall control." + vbCrLf + vbCrLf)
                                    .WriteLine("The Product is protected by copyright and other intellectual property laws and treaties. " + AI.Company.ToUpper + " or its suppliers own the title, copyright, and other intellectual property rights in the Product.  The Product is licensed, not sold.")
                                End With

                                sw.Close()

                            End Using

                        End If
                    Else
                        MsgBox("Unable to procress", MsgBoxStyle.Critical, "Restricted Function")
                    End If
                End Sub

                ''' <summary>
                ''' The system will auto generate a credits here: The one who originally develop the POWER .NET 8 development toolkit package for .NET Programmers
                ''' </summary>
                ''' <param name="runCode">It needs an authentication by the developer to use this shared function</param>
                ''' <remarks></remarks>
                Public Shared Sub writeCredits(Optional ByVal runCode As String = "")
                    If runCode = "masterkey" Then

                        myFile.Share.Folders.createFolder(myDocument.Share.XMLDesigner.PathConfig.readPath + "\Templates", "Help")

                        Dim filepath_fromtextbox As String = PathConfig.readPath + "\Templates\Help\credits.rtf"

                        If Not File.Exists(filepath_fromtextbox) Then

                            Using sw As IO.StreamWriter = New IO.StreamWriter(filepath_fromtextbox)

                                With sw
                                    .WriteLine("=========================================================================" + vbCrLf)
                                    .WriteLine("POWER .NET 8 " + vbCrLf)
                                    .WriteLine("Program Development Toolkit" + vbCrLf)
                                    .WriteLine("=========================================================================" + vbCrLf + vbCrLf)

                                    .WriteLine("Solely Programmed and Developed by:" + vbCrLf)
                                    .WriteLine("    SYLVSTER R. BELONIO" + vbCrLf + vbCrLf)


                                    .WriteLine("Learned from an Advanced Library Code, the Veteran Programmer" + vbCrLf)
                                    .WriteLine("    ALDWIN GALAPON" + vbCrLf + vbCrLf)

                                    .WriteLine("Learned to make a library, the Lead Programmer" + vbCrLf)
                                    .WriteLine("    ZHALICK O. DARANGINA" + vbCrLf + vbCrLf)


                                    .WriteLine("Special Thanks To:" + vbCrLf)
                                    .WriteLine("    VETERAN PROGRAMMERS" + vbCrLf)
                                    .WriteLine("    CODE PROJECT TEAMS" + vbCrLf + vbCrLf)

                                    .WriteLine("WANTS MORE INFORMATION" + vbCrLf)
                                    .WriteLine("    https://www.facebook.com/sylvster.belonio" + vbCrLf + vbCrLf)

                                    .WriteLine("BUILD UPDATES" + vbCrLf)
                                    .WriteLine("    https://www.facebook.com/MyPowerNET8/" + vbCrLf + vbCrLf)

                                    .WriteLine("POWERED BY" + vbCrLf)
                                    .WriteLine("    VB .NET 2008" + vbCrLf)
                                    .WriteLine("    JQUERY" + vbCrLf)
                                    .WriteLine("    JQUERY Mobile" + vbCrLf)
                                    .WriteLine("    Windows 8.1 Platform" + vbCrLf + vbCrLf)

                                    .WriteLine("=========================================================================" + vbCrLf)
                                    .WriteLine("CITY PROGRAMMERS GROUP (CPG)" + vbCrLf)
                                    .WriteLine("All Rights Reserved 2014" + vbCrLf)
                                    .WriteLine("=========================================================================" + vbCrLf)

                                End With

                                sw.Close()

                            End Using

                        End If
                    Else
                        MsgBox("Unable to procress", MsgBoxStyle.Critical, "Restricted Function")
                    End If
                End Sub

                ''' <summary>
                ''' The system will auto generate the current logs of what other features of hte POWER .NET 8 haved been added in the package
                ''' </summary>
                ''' <param name="runCode">It needs an authentication by the developer to use this shared function</param>
                ''' <remarks></remarks>
                Public Shared Sub writeSystemLogs(Optional ByVal runCode As String = "")
                    If runCode = "masterkey" Then

                        myFile.Share.Folders.createFolder(myDocument.Share.XMLDesigner.PathConfig.readPath + "\Templates", "Help")
                        Dim filepath_fromtextbox As String = PathConfig.readPath + "\Templates\Help\LogUpdates.rtf"

                        If Not File.Exists(filepath_fromtextbox) Then

                            Using sw As IO.StreamWriter = New IO.StreamWriter(filepath_fromtextbox)

                                With sw

                                    .WriteLine("POWER .NET 8 Toolkit Updates" + vbCrLf)
                                    .WriteLine("=========================================================================" + vbCrLf)
                                    .WriteLine("1.0.0.0 The successor of Custom Objects" + vbCrLf)
                                    .WriteLine("1.0.0.1 Added Namespaces and Classes to classify when using it." + vbCrLf)
                                    .WriteLine("1.0.0.2 Added Customized Windowss 8.1 Buttons" + vbCrLf)
                                    .WriteLine("1.0.0.3 Added Crystal Report and Microsoft Report Viewer Tools" + vbCrLf)
                                    .WriteLine("1.0.0.4 Added Background Color and Accent Color Controls" + vbCrLf)
                                    .WriteLine("1.0.0.5 Added Autogerate Assembly Info, and Licences (June 5, 2014)" + vbCrLf)
                                    .WriteLine("1.0.0.6 Added document XML definition to help the programmers to undertand the library functions (June 6, 2014)" + vbCrLf)
                                    .WriteLine("1.0.0.7 Added New Reserved event and skins for button,checkbox and text (June 7, 2014)" + vbCrLf)
                                    .WriteLine("1.0.0.8 Added New Custom Tab Control " + vbCrLf)
                                    .WriteLine("1.0.0.9 Added New Search Textbox Control " + vbCrLf)
                                    .WriteLine("1.0.1.0 Added New Custom Dialog Box (Plain Dialog) and Put Some Shadow Mode form. (July 16, 2014)" + vbCrLf)

                                    .WriteLine("=========================================================================" + vbCrLf)
                                    .WriteLine("This toolkit is under development and always updating the changes in order to improve the development toolkit for efficient use." + vbCrLf)
                                End With

                                sw.Close()

                            End Using

                        End If
                    Else
                        MsgBox("Unable to procress", MsgBoxStyle.Critical, "Restricted Function")
                    End If
                End Sub

            End Class

            ''' <summary>
            ''' This class is for writing and reading an XML file for the purpose of restoring the previous assembly information
            ''' </summary>
            ''' <remarks></remarks>
            Public Class AssemblyInfoConfig

#Region "VARIABLES"

                Public Shared AssemblyFlags As String = ""
                Public Shared BuildDate As String = ""
                Public Shared Company As String = ""
                Public Shared ConfigurationAttribute As String = ""
                Public Shared Copyright As String = ""
                Public Shared Culture As String = ""
                Public Shared DefaultAlias As String = ""
                Public Shared DelaySign As String = ""
                Public Shared Description As String = ""
                Public Shared FileVersion As String = ""
                Public Shared InformationalVersion As String = ""
                Public Shared KeyFile As String = ""
                Public Shared KeyName As String = ""
                Public Shared Product As String = ""
                Public Shared Title As String = ""
                Public Shared Trademark As String = ""
                Public Shared VersionProduct As String = ""
                Public Shared AssemblyVersion As String = ""

#End Region

                ''' <summary>
                ''' It writes and creates an XML file for your current assembly information of your project
                ''' </summary>
                ''' <param name="asm">Set the current Assembly Information Project</param>
                ''' <remarks></remarks>
                Public Shared Sub writeAssemblyInfo(ByVal asm As System.Reflection.Assembly)
                    Dim settings As XmlWriterSettings = New XmlWriterSettings()
                    Dim rows As Integer = 1
                    Dim myAssemblyInfo As New myApplication.Init.AssemblyInformation
                    myAssemblyInfo.setAssembly(asm)

                    settings.Indent = True

                    'CREATE TEMPLATES FOLDER'
                    myFile.Share.Folders.createFolder(PathConfig.readPath, "Templates")
                    myFile.Share.Folders.setHiddenFolder(PathConfig.readPath + "\Templates")
                    myFile.Share.Folders.createFolder(PathConfig.readPath + "\Templates", "Applications")
                    myFile.Share.Folders.setHiddenFolder(PathConfig.readPath + "\Templates\Applications")

                    myFile.Share.Files.deleteFile(PathConfig.readPath + "\Templates\Applications\myAssemblyInfo.xml")

                    Try
                        Using writer As XmlWriter = XmlWriter.Create(PathConfig.readPath + "\Templates\Applications\myAssemblyInfo.xml", settings)
                            With writer
                                .WriteStartDocument()
                                .WriteStartElement("System.Assembly") ' Root.


                                .WriteStartElement("AssemblyFlags") ''
                                .WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getAssemblyFlags))
                                .WriteEndElement()
                                .WriteStartElement("BuildDate") ''
                                .WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getBuildDate))
                                .WriteEndElement()
                                .WriteStartElement("Company") ''
                                .WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getCompany))
                                .WriteEndElement()
                                .WriteStartElement("ConfigurationAttribute") ''
                                .WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getConfigurationAttribute))
                                .WriteEndElement()
                                .WriteStartElement("Copyright") ''
                                .WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getCopyright))
                                .WriteEndElement()
                                .WriteStartElement("Culture") ''
                                .WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getCulture))
                                .WriteEndElement()
                                .WriteStartElement("DefaultAlias") ''
                                .WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getDefaultAlias))
                                .WriteEndElement()
                                .WriteStartElement("DelaySign") ''
                                .WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getDelaySign))
                                .WriteEndElement()
                                .WriteStartElement("Description") ''
                                .WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getDescription))
                                .WriteEndElement()
                                .WriteStartElement("FileVersion") ''
                                .WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getFileVersion))
                                .WriteEndElement()
                                .WriteStartElement("InformationalVersion") ''
                                .WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getInformationalVersion))
                                .WriteEndElement()
                                .WriteStartElement("KeyFile") ''
                                .WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getKeyFile))
                                .WriteEndElement()
                                .WriteStartElement("KeyName") ''
                                .WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getKeyName))
                                .WriteEndElement()
                                .WriteStartElement("Product") ''
                                .WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getProduct))
                                .WriteEndElement()
                                .WriteStartElement("Title") ''
                                .WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getTitle))
                                .WriteEndElement()
                                .WriteStartElement("Trademark") ''
                                .WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getTrademark))
                                .WriteEndElement()
                                .WriteStartElement("VersionProduct") ''
                                .WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getVersionProduct))
                                .WriteEndElement()
                                .WriteStartElement("AssemblyVersion") ''
                                .WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getAssemblyVersion))
                                .WriteEndElement()

                                .WriteStartElement("List") ''
                                .WriteEndElement()

                            End With
                            PowerNET8.myFile.Share.Files.setHiddenFile(PathConfig.readPath + "\Templates\myAssemblyInfo.xml")
                        End Using
                        'MAKING OF LICENSE
                        License.writeLicense("masterkey")
                        License.writeCredits("masterkey")
                        License.writeSystemLogs("masterkey")
                    Catch ex As Exception
                        myExceptionHandler.OnThreadException(ex)
                    End Try

                End Sub

                ''' <summary>
                ''' It reads an XML file to retrieve the previous assembly information everytime the user will launch the system
                ''' </summary>
                ''' <remarks></remarks>
                Public Shared Sub readAssemblyInfo()

                    Dim FilePath As String = Application.StartupPath + "\Templates\Applications\myAssemblyInfo.xml"
                    If File.Exists(FilePath) Then
                        Using reader As XmlReader = XmlReader.Create(FilePath)
                            If Not reader Is Nothing Then
                                Try
                                    Dim count As Integer = -1
                                    While reader.Read()
                                        count += 1
                                        ' Check for start elements.
                                        If reader.IsStartElement() Then
                                            ' See if perls element or article element.
                                            If reader.Name <> "System.Assembly" And reader.Name <> "" Then
                                                With reader
                                                    Select Case reader.Name
                                                        Case "AssemblyFlags"
                                                            '.WriteStartElement("AssemblyFlags") ''
                                                            '.WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getAssemblyFlags))
                                                            AssemblyFlags = myString.Share.EnDecryption.Execute(.GetAttribute("value"))
                                                        Case "BuildDate"
                                                            '.WriteStartElement("BuildDate") ''
                                                            '.WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getBuildDate))
                                                            BuildDate = myString.Share.EnDecryption.Execute(.GetAttribute("value"))
                                                        Case "Company"
                                                            '.WriteStartElement("Company") ''
                                                            '.WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getCompany))
                                                            Company = myString.Share.EnDecryption.Execute(.GetAttribute("value"))
                                                        Case "ConfigurationAttribute"
                                                            '.WriteStartElement("ConfigurationAttribute") ''
                                                            '.WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getConfigurationAttribute))
                                                            ConfigurationAttribute = myString.Share.EnDecryption.Execute(.GetAttribute("value"))
                                                        Case "Copyright"
                                                            '.WriteStartElement("Copyright") ''
                                                            '.WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getCopyright))
                                                            Copyright = myString.Share.EnDecryption.Execute(.GetAttribute("value"))
                                                        Case "Culture"
                                                            '.WriteStartElement("Culture") ''
                                                            '.WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getCulture))
                                                            Culture = myString.Share.EnDecryption.Execute(.GetAttribute("value"))
                                                        Case "DefaultAlias"
                                                            '.WriteStartElement("DefaultAlias") ''
                                                            '.WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getDefaultAlias))
                                                            DefaultAlias = myString.Share.EnDecryption.Execute(.GetAttribute("value"))
                                                        Case "DelaySign"
                                                            '.WriteStartElement("DelaySign") ''
                                                            '.WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getDelaySign))
                                                            DelaySign = myString.Share.EnDecryption.Execute(.GetAttribute("value"))
                                                        Case "Description"
                                                            '.WriteStartElement("Description") ''
                                                            '.WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getDescription))
                                                            Description = myString.Share.EnDecryption.Execute(.GetAttribute("value"))
                                                        Case "FileVersion"
                                                            '.WriteStartElement("FileVersion") ''
                                                            '.WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getFileVersion))
                                                            FileVersion = myString.Share.EnDecryption.Execute(.GetAttribute("value"))
                                                        Case "InformationalVersion"
                                                            '.WriteStartElement("InformationalVersion") ''
                                                            '.WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getInformationalVersion))
                                                            InformationalVersion = myString.Share.EnDecryption.Execute(.GetAttribute("value"))
                                                        Case "KeyFile"
                                                            '.WriteStartElement("KeyFile") ''
                                                            '.WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getKeyFile))
                                                            KeyFile = myString.Share.EnDecryption.Execute(.GetAttribute("value"))
                                                        Case "KeyName"
                                                            '.WriteStartElement("KeyName") ''
                                                            '.WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getKeyName))
                                                            KeyName = myString.Share.EnDecryption.Execute(.GetAttribute("value"))
                                                        Case "Product"
                                                            '.WriteStartElement("Product") ''
                                                            '.WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getProduct))
                                                            Product = myString.Share.EnDecryption.Execute(.GetAttribute("value"))
                                                        Case "Title"
                                                            '.WriteStartElement("Title") ''
                                                            '.WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getTitle))
                                                            Title = myString.Share.EnDecryption.Execute(.GetAttribute("value"))
                                                        Case "Trademark"
                                                            '.WriteStartElement("Trademark") ''
                                                            '.WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getTrademark))
                                                            Trademark = myString.Share.EnDecryption.Execute(.GetAttribute("value"))
                                                        Case "VersionProduct"
                                                            '.WriteStartElement("VersionProduct") ''
                                                            '.WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getVersionProduct))
                                                            VersionProduct = myString.Share.EnDecryption.Execute(.GetAttribute("value"))
                                                        Case "AssemblyVersion"
                                                            '.WriteStartElement("VersionProduct") ''
                                                            '.WriteAttributeString("value", myString.Share.EnDecryption.Execute(myAssemblyInfo.getVersionProduct))
                                                            AssemblyVersion = myString.Share.EnDecryption.Execute(.GetAttribute("value"))

                                                    End Select
                                                End With
                                            End If
                                        End If
                                    End While
                                Catch ex As Exception
                                    MsgBox("There is no database configuration found in the file")
                                End Try
                            End If
                        End Using
                    
                    End If

                End Sub

            End Class

            ''' <summary>
            ''' This class is for writing and reading an XML file for the purpose of retriving the previouse theme color in every users that have entered into the system
            ''' </summary>
            ''' <remarks></remarks>
            Public Class ThemesConfig

                Enum Type
                    Standard
                    Customize
                End Enum

                Structure ThemesValue
                    Public userName As String
                    Public backgroundColor As String
                    Public backgroundColor_mainValue As String
                    Public backgroundCOlor_subValue As String
                    Public accentColor As String
                    Public accentColor_mainValue As String
                    Public accentColor_subValue As String
                    Public form_backColor As String
                    Public form_borderColor As String
                    Public text_focusBackColor As String
                    Public text_focusForeColor As String
                    Public text_lostFocusBackColor As String
                    Public text_lostFocusForeColor As String
                    Public text_readOnlyBackColor As String
                    Public text_readOnlyForeColor As String
                    Public text_forecolor As String
                End Structure

                Public Shared Sub updateThemes(ByVal userName As String, ByVal setTheme As myDocument.Share.XMLDesigner.ThemesConfig.ThemesValue)
                    ' Create XmlWriterSettings.
                    Dim basePath As String = PathConfig.readPath + "\Templates\"
                    basePath += "Themes\"

                    Dim settings As XmlWriterSettings = New XmlWriterSettings()
                    Dim rows As Integer = 1
                    settings.Indent = True

                    Dim createFile As String = basePath + userName + ".xml"
                    myFile.Share.Files.deleteFile(createFile)

                    Using writer As XmlWriter = XmlWriter.Create(createFile, settings)
                        Try
                            With writer
                                .WriteStartDocument()
                                .WriteStartElement("System.Windows.8.Themes") ' Root.
                                'back ground color dialog box
                                .WriteStartElement("Background.Color")
                                .WriteAttributeString("value", setTheme.backgroundColor)
                                .WriteAttributeString("colorPicker", setTheme.backgroundColor_mainValue + "," + setTheme.backgroundCOlor_subValue)
                                .WriteEndElement()
                                'accent color dialog box
                                .WriteStartElement("Accent.Color")
                                .WriteAttributeString("value", setTheme.accentColor)
                                .WriteAttributeString("colorPicker", setTheme.accentColor_mainValue + "," + setTheme.accentColor_subValue)
                                .WriteEndElement()
                                'windows form
                                .WriteStartElement("Windows.Form")
                                .WriteAttributeString("backColor", "FAFBFB")
                                .WriteAttributeString("borderColor", "E1A61E")
                                .WriteEndElement()
                                .WriteEndDocument()


                            End With
                        Catch ex As Exception
                            myExceptionHandler.OnThreadException(ex)
                        End Try

                    End Using
                    'PowerNET8.myFile.Share.Files.setHiddenFile(createFile)

                End Sub

                Private Shared Sub createThemes(ByVal basePath As String, ByVal userName As String, ByVal customValues As ThemesValue, Optional ByVal type As Type = Type.Standard)
                    ' Create XmlWriterSettings.
                    Dim settings As XmlWriterSettings = New XmlWriterSettings()
                    Dim rows As Integer = 1
                    settings.Indent = True
                    ' Create XmlWriter.
                    If type = ThemesConfig.Type.Standard Then
                        If Not File.Exists(basePath + "DefaultTheme.xml") Then
                            Try

                                Dim createFile As String
                                If userName = "" Then
                                    createFile = basePath + "DefaultTheme.xml"
                                Else
                                    createFile = basePath + userName + ".xml"
                                End If

                                myFile.Share.Files.deleteFile(createFile)
                                Using writer As XmlWriter = XmlWriter.Create(createFile, settings)

                                    With writer
                                        .WriteStartDocument()
                                        .WriteStartElement("System.Windows.8.Themes") ' Root.

                                        'back ground color dialog box
                                        .WriteStartElement("Background.Color")
                                        .WriteAttributeString("value", "146CE8")
                                        .WriteAttributeString("colorPicker", "A6,A6")
                                        .WriteEndElement()
                                        'accent color dialog box
                                        .WriteStartElement("Accent.Color")
                                        .WriteAttributeString("value", "3D6099")
                                        .WriteAttributeString("colorPicker", "A6,A6")
                                        .WriteEndElement()
                                        'windows form
                                        .WriteStartElement("Windows.Form")
                                        .WriteAttributeString("backColor", "FAFBFB")
                                        .WriteAttributeString("borderColor", "E1A61E")
                                        .WriteEndElement()
                                        'texbox
                                        .WriteStartElement("Windows.Form.Text")
                                        .WriteAttributeString("focus.backcolor", "fffccd")
                                        .WriteAttributeString("focus.forecolor", "000000")
                                        .WriteAttributeString("lostfocus.backcolor", "FFFFFF")
                                        .WriteAttributeString("readOnly.backcolor", "efefef")
                                        .WriteAttributeString("lostfocus.forecolor", "000000")
                                        .WriteAttributeString("readOnly.forecolor", "6D6D6D")
                                        .WriteAttributeString("forecolor", "000000")
                                        .WriteEndElement()
                                        'highlight
                                        .WriteStartElement("Windows.Form.Text.Highlight")
                                        .WriteAttributeString("select.backcolor", "fffccd")
                                        .WriteAttributeString("select.forecolor", "fffccd")
                                        .WriteAttributeString("unselect.backcolor", "fffccd")
                                        .WriteAttributeString("unselect.forecolor", "fffccd")
                                        'datagridview
                                        .WriteStartElement("Windows.Form.Datagridview")
                                        .WriteAttributeString("backcolor", "fffccd")
                                        .WriteAttributeString("gridcolor", "ffffff")
                                        .WriteAttributeString("defaultcell.backcolor", "fffccd")
                                        .WriteAttributeString("defaultcell.forecolor", "fffccd")
                                        .WriteAttributeString("alternatecell.backcolor", "fffccd")
                                        .WriteAttributeString("alternatecell.forecolor", "fffccd")



                                        .WriteEndDocument()
                                    End With
                                    'PowerNET8.myFile.Share.Files.setHiddenFile(createFile)

                                End Using
                            Catch ex As Exception
                                myExceptionHandler.OnThreadException(ex)
                            End Try
                        End If

                    End If


                End Sub

                Public Shared getThemes As ThemesValue
                Private Shared Sub assignedEmptyValues()
                    With getThemes
                        .userName = ""
                        .accentColor = ""
                        .accentColor_mainValue = ""
                        .accentColor_subValue = ""
                        .backgroundColor = ""
                        .backgroundColor_mainValue = ""
                        .backgroundCOlor_subValue = ""
                        .form_backColor = ""
                        .form_borderColor = ""
                    End With
                End Sub

                Private Shared Sub assignedValues(ByVal filePath As String)
                    Using reader As XmlReader = XmlReader.Create(filePath)
                        If Not reader Is Nothing Then
                            Try
                                While reader.Read()
                                    If reader.Name <> "systemPathConfiguration" And reader.Name <> "" Then
                                        With reader
                                            Select Case reader.Name
                                                Case "Background.Color"
                                                    getThemes.backgroundColor = .GetAttribute("value")
                                                    Dim col() As String = .GetAttribute("colorPicker").Split(",")
                                                    getThemes.backgroundColor_mainValue = col(0)
                                                    getThemes.backgroundCOlor_subValue = col(1)
                                                Case "Accent.Color"
                                                    getThemes.accentColor = .GetAttribute("value")
                                                    Dim col() As String = .GetAttribute("colorPicker").Split(",")
                                                    getThemes.accentColor_mainValue = col(0)
                                                    getThemes.accentColor_subValue = col(1)
                                                Case "Windows.Form"
                                                    getThemes.form_backColor = .GetAttribute("backColor")
                                                    getThemes.form_borderColor = .GetAttribute("borderColor")
                                                Case "Windows.Form.Text"
                                                    getThemes.text_focusBackColor = .GetAttribute("focus.backcolor")
                                                    getThemes.text_focusForeColor = .GetAttribute("focus.forecolor")
                                                    getThemes.text_lostFocusBackColor = .GetAttribute("lostfocus.backcolor")
                                                    getThemes.text_lostFocusForeColor = .GetAttribute("lostfocus.forecolor")
                                                    getThemes.text_readOnlyBackColor = .GetAttribute("readOnly.backcolor")
                                                    getThemes.text_readOnlyForeColor = .GetAttribute("readOnly.forecolor")
                                                    getThemes.text_forecolor = .GetAttribute("forecolor")
                                            End Select
                                        End With
                                    End If
                                End While
                            Catch ex As Exception
                                myExceptionHandler.OnThreadException(ex, "There is no themes configuration found in the file")
                            End Try
                        End If
                    End Using
                End Sub

                Public Shared Function readThemes(Optional ByVal userName As String = "")

                    assignedEmptyValues()
                    Dim basePath As String = PathConfig.readPath + "\Templates\"

                    'CREATE TEMPLATES FOLDER'
                    myFile.Share.Folders.createFolder(basePath, "Themes")
                    myFile.Share.Folders.setHiddenFolder(basePath + "\Themes")

                    basePath += "Themes\"

                    If File.Exists(basePath + userName + ".xml") Then
                        assignedValues(basePath + userName + ".xml")
                    ElseIf File.Exists(basePath + "DefaultTheme.xml") Then
                        assignedValues(basePath + "DefaultTheme.xml")
                    Else
                        createThemes(basePath, userName, Nothing)
                        readThemes(userName)
                    End If
                    Return getThemes
                End Function

            End Class


        End Namespace

    End Namespace


End Namespace


