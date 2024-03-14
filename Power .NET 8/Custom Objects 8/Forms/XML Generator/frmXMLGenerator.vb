Imports System.Xml
Imports System.Xml.Schema

Public Class frmXMLGenerator
    Friend myb As New PowerNET8.myBrowseDialog
    Friend myFile As New PowerNET8.myFile.Share.Files
    Friend myDataTable As New PowerNET8.myDataTableCreator
    Friend myDialog As New PowerNET8.myDialog.messageBoxes
    Friend myObject As New PowerNET8.myObject

    'Friend myThemes As CustomObjects.MyObject.ThemeNames = MyObject.ThemeNames.Original
    Private myData As New DataTable
    Private myDataView As New DataView
    Private myCol As New Collection
    Private frm As New frmXMLGeneratorSQL
    Private colobject As New Collection

    Private Sub frmXMLGenerator_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If myDialog.show("Do you want to exit this application?", "Exit Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmXMLGenerator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myObject.get_all_objects_data(colobject, Me)
        'myObject.load(colobject, myThemes)
        'myDialog.set_class(myThemes)
    End Sub

#Region "TABLENAME"

    Private Function validateT(ByVal value As String)
        Dim blnfound As Boolean = False
        For i As Integer = 0 To lstT.Items.Count - 1
            If value = lstT.Items(i).Text Then
                blnfound = True
                Exit For
            End If
        Next
        If Not blnfound Then
            If value <> "" Then
                lstT.Items.Add(value)

                'creating a tablname
                Dim tbl As DataTable
                With myDataTable
                    .new_table(value)
                    .add_columnField("columname")
                    .add_columnField("datatype")
                    tbl = .get_table
                End With

                myCol.Add(tbl, "key-" + value)
                ''''''''''''''''''''
                Return True
            End If

        Else
            Return False
        End If
        Return False
    End Function

    Private Sub cmdT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTAdd.Click, cmdTEdit.Click, cmdTDelete.Click
        Select Case CType(sender, Button).Text.ToLower
            Case "add"
                validateT(txtTName.Text.Replace(" ", "_"))
                txtTName.Text = ""
                validationTEvent()
            Case "edit"
                If lstT.SelectedIndex <> -1 Then
                    txtTName.Text = lstT.Items(lstT.SelectedIndex).Text
                    cmdTAdd.Text = "Update"
                Else
                    myDialog.show("Please select a tablename to edit", "Unable to edit", , MessageBoxIcon.Information)
                End If
            Case "update"
                If lstT.SelectedIndex <> -1 Then
                    Dim tbl As DataTable = get_TableName(lstT.Items(lstT.SelectedIndex).Text)
                    lstT.Items(lstT.SelectedIndex).Text = txtTName.Text
                    tbl.TableName = txtTName.Text
                    cmdTAdd.Text = "Add"
                    txtTName.Text = ""
                    lstT.Refresh()
                End If
            Case "del"
                If lstT.SelectedIndex <> -1 Then
                    remove_TableName(lstT.Items(lstT.SelectedIndex).Text)
                    lstT.Items.RemoveAt(lstT.SelectedIndex)
                Else
                    myDialog.show("Please select a tablename to delete", "Unable to delete", , MessageBoxIcon.Information)
                End If
                cmdTAdd.Text = "Add"
                txtTName.Text = ""
                validationTEvent()
        End Select
    End Sub

    Private Sub txtTName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTName.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdT_Click(cmdTAdd, Nothing)
        End If
    End Sub

    Private Sub lstT_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstT.MouseDoubleClick
        cmdT_Click(cmdTEdit, Nothing)
    End Sub

    Private Sub validationTEvent()
        If lstT.Items.Count > 0 Then
            cmdTEdit.Enabled = True
            cmdTDelete.Enabled = True
        Else
            cmdTEdit.Enabled = False
            cmdTDelete.Enabled = False
        End If
    End Sub

    Private Function get_TableName(ByVal value As String) As DataTable
        For Each obj As Object In myCol
            If TypeOf obj Is DataTable Then
                If CType(obj, DataTable).TableName = value Then
                    Return CType(obj, DataTable)
                End If
            End If
        Next
        Return Nothing
    End Function

    Private Sub remove_TableName(ByVal value As String)
        Dim i As Integer = 0
        For Each obj As Object In myCol
            If CType(obj, DataTable).TableName = value Then
                myCol.Remove("key-" + value)
                Exit Sub
            End If
            i += 1
        Next
    End Sub

    Private selected_tblvalue As DataTable

    Private Sub lstT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstT.SelectedIndexChanged
        If lstT.SelectedIndex <> -1 Then
            selected_tblvalue = get_TableName(lstT.Items(lstT.SelectedIndex).Text)
            lstC.Items.Clear()
            lstCType.Items.Clear()
            For i As Integer = 0 To selected_tblvalue.Rows.Count - 1
                lstC.Items.Add(selected_tblvalue.Rows(i).Item("columname"))
                lstCType.Items.Add(selected_tblvalue.Rows(i).Item("datatype"))
            Next
            cmdTEdit.Enabled = True
            cmdTDelete.Enabled = True
        Else
            lstC.Items.Clear()
            lstCType.Items.Clear()
            cmdTEdit.Enabled = False
            cmdTDelete.Enabled = False
        End If
    End Sub

#End Region

#Region "COLUMN NAME"

    Private Sub validateC(ByVal value As String)
        If lstT.SelectedIndex <> -1 Then
            Dim blnfound As Boolean = False
            For i As Integer = 0 To lstC.Items.Count - 1
                If value = lstC.Items(i).Text Then
                    blnfound = True
                    Exit For
                End If
            Next
            If Not blnfound Then
                If value <> "" Then
                    lstC.Items.Add(value)
                    If cboType.SelectedIndex = -1 Then
                        cboType.SelectedIndex = 0
                    End If
                    lstCType.Items.Add(cboType.Text)

                    selected_tblvalue.Rows.Add()
                    selected_tblvalue.Rows(selected_tblvalue.Rows.Count - 1).Item("columname") = value
                    selected_tblvalue.Rows(selected_tblvalue.Rows.Count - 1).Item("datatype") = cboType.Text
                End If
            End If
        End If
    End Sub

    Private Sub deleteItems_column(ByVal values As String)
        For i As Integer = 0 To selected_tblvalue.Rows.Count - 1
            If selected_tblvalue.Rows(i).Item("columname") = values Then
                selected_tblvalue.Rows(i).Delete()
            End If
        Next
    End Sub

    Private Sub cmdC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCAdd.Click, cmdCEdit.Click, cmdCDel.Click
        Select Case CType(sender, Button).Text.ToLower
            Case "add"
                If lstT.SelectedIndex <> -1 And lstT.Items.Count > 0 Then
                    validateC(txtCName.Text.Replace(" ", "_"))
                    validationCEvent()
                    txtCName.Text = ""
                Else
                    myDialog.show("You cannot add column name if there is no table exist", "Unable to add column")
                End If
            Case "edit"
                If lstC.SelectedIndex <> -1 Then
                    txtCName.Text = lstC.Items(lstC.SelectedIndex).Text
                    cboType.Text = lstCType.Items(lstC.SelectedIndex).Text
                    cmdCAdd.Text = "Update"
                Else
                    myDialog.show("Please select a tablename to edit", "Unable to edit", , MessageBoxIcon.Information)
                End If
            Case "update"
                If lstC.SelectedIndex <> -1 Then
                    'Dim tbl As DataTable = get_TableName(lstc.Items(lstT.SelectedIndex).Text)
                    lstC.Items(lstC.SelectedIndex).Text = txtCName.Text
                    lstCType.Items(lstC.SelectedIndex).Text = cboType.Text

                    selected_tblvalue.Rows(lstC.SelectedIndex).Item("columname") = txtCName.Text
                    selected_tblvalue.Rows(lstC.SelectedIndex).Item("datatype") = cboType.Text

                    'tbl.TableName = txtTName.Text
                    cmdCAdd.Text = "Add"
                    txtCName.Text = ""
                    lstC.Refresh()
                    lstCType.Refresh()
                End If
            Case "del"
                If lstC.SelectedIndex <> -1 Then
                    deleteItems_column(lstC.Items(lstC.SelectedIndex).Text)
                    lstCType.Items.RemoveAt(lstC.SelectedIndex)
                    lstC.Items.RemoveAt(lstC.SelectedIndex)
                Else
                    myDialog.show("Please select a tablename to delete", "Unable to delete", , MessageBoxIcon.Information)
                End If
                cmdCAdd.Text = "Add"
                txtCName.Text = ""
                validationCEvent()
        End Select
    End Sub

    Private Sub validationCEvent()
        If lstT.Items.Count > 0 Then
            cmdCEdit.Enabled = True
            cmdCDel.Enabled = True
        Else
            cmdCEdit.Enabled = False
            cmdCDel.Enabled = False
        End If
    End Sub

    Private Sub txtCName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCName.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdC_Click(cmdCAdd, Nothing)
        End If
    End Sub

    Private Sub lstC_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstC.MouseDoubleClick, lstCType.MouseDoubleClick
        cmdC_Click(cmdCEdit, Nothing)
    End Sub

    Private Sub lstC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstC.SelectedIndexChanged
        lstCType.SelectedIndex = lstC.SelectedIndex
        If lstCType.SelectedIndex <> -1 Then
            cmdCEdit.Enabled = True
            cmdCDel.Enabled = True
        Else
            cmdCEdit.Enabled = False
            cmdCDel.Enabled = False
        End If
    End Sub

#End Region

#Region "XML COMPILER"

    Private Sub create_XML(ByVal loc As String)

        'Dim myData As New DataSet

        'For i As Integer = 0 To lstT.Items.Count - 1
        '    Dim select_ As DataTable = get_TableName(lstT.Items(i).Text)
        '    Dim ntable As New DataTable
        '    With myDataTable
        '        .new_table(lstT.Items(i).Text)
        '        For a As Integer = 0 To select_.Rows.Count - 1
        '            .add_columnField_String_Style(select_.Rows(a).Item("columname"), select_.Rows(a).Item("datatype"))
        '        Next
        '        ntable = .get_table
        '        myData.Tables.Add(ntable)
        '    End With
        'Next
        'myData.DataSetName = txtDataset.Text
        'myData.WriteXml(loc, XmlWriteMode.WriteSchema)


        Dim StringAppend As New System.Text.StringBuilder

        With StringAppend
            .Append("<?xml version=""1.0"" standalone=""yes""?>")
            .Append(vbCrLf)
            .Append("<xs:schema id=""" + txtDataset.Text + """ xmlns="""" xmlns:xs=""http://www.w3.org/2001/XMLSchema"" xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">")
            .Append(vbCrLf)
            .Append("   <xs:element name=""" + txtDataset.Text + """ msdata:IsDataSet=""true"" msdata:UseCurrentLocale=""true"">")
            .Append(vbCrLf)
            .Append("       <xs:complexType>")
            .Append(vbCrLf)
            .Append("           <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">")
            .Append(vbCrLf)

            'you can encode here'
            For i As Integer = 0 To lstT.Items.Count - 1
                'ADD NEW ELEMENT''''''''''''''''''''
                .Append("               <xs:element name=""" + lstT.Items(i).Text + """>")
                .Append(vbCrLf)
                .Append("                   <xs:complexType>")
                .Append(vbCrLf)
                .Append("                       <xs:sequence>")
                .Append(vbCrLf)
                ''''''''''''''''''''''''''''''''''''

                Dim select_ As DataTable = get_TableName(lstT.Items(i).Text)
                For a As Integer = 0 To select_.Rows.Count - 1
                    .Append("                       <xs:element name=""" + select_.Rows(a).Item("columname") + """ type=""xs:" + select_.Rows(a).Item("datatype") + """ minOccurs=""0"" />")
                    .Append(vbCrLf)
                Next

                'CLOSE ELEMENT'''''''''''''''''''''
                .Append("                       </xs:sequence>")
                .Append(vbCrLf)
                .Append("                   </xs:complexType>")
                .Append(vbCrLf)
                .Append("               </xs:element>")
                .Append(vbCrLf)
                '''''''''''''''''''''''''''''''''''
            Next

            .Append("           </xs:choice>")
            .Append(vbCrLf)
            .Append("       </xs:complexType>")
            .Append(vbCrLf)
            .Append("   </xs:element>")
            .Append(vbCrLf)
            .Append("</xs:schema>")
        End With

        My.Computer.FileSystem.WriteAllText(loc, StringAppend.ToString, False)
        myDialog.show("You have successfully created an XML file!", "XML Generated Successfully", , MessageBoxIcon.Information)

    End Sub

#End Region

    Private Sub clear_all()
        myData.Rows.Clear()
        txtDataset.Text = ""
        txtTName.Text = ""
        cmdTAdd.Text = "Add"
        cmdTEdit.Enabled = False
        cmdTDelete.Enabled = False
        lstT.Items.Clear()
        lblS.Text = "-"
        txtCName.Text = ""
        cboType.SelectedIndex = -1
        lstC.Items.Clear()
        lstCType.Items.Clear()
        cmdCEdit.Enabled = False
        cmdCAdd.Text = "Add"
        cmdCDel.Enabled = False
    End Sub

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        If cboType.SelectedIndex <> -1 Then
            Select Case cboType.Text
                Case "integer"
                    lblS.Text = "supports integer."
                Case "string"
                    lblS.Text = "supports string."
                Case "positiveInteger"
                    lblS.Text = "supports non negative number."
                Case "number"
                    lblS.Text = "supports number."
                Case "date"
                    lblS.Text = "supports date/time values."
                Case "boolean"
                    lblS.Text = "supports true/false value."
                Case "language"
                    lblS.Text = "supports string values."
                Case "base64Binary"
                    lblS.Text = "supports image/BLOB format."
            End Select
        Else
            lblS.Text = "-"
        End If
    End Sub

    Private Function get_ValidateValues(ByVal value As String) As String
        Select Case value.ToLower
            Case "system.string"
                Return "string"
            Case "system.int64"
                Return "integer"
            Case "system.uint64"
                Return "positiveInteger"
            Case "system.datetime"
                Return "date"
            Case "system.boolean"
                Return "boolean"
            Case "system.byte[]"
                Return "base64Binary"
            Case Else
                Return "string"
        End Select
        Return "string"
    End Function

    Private FF As String
    Private Sub FileSelected(ByVal fileName As String)
        FF = fileName
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        myDialog.show("This program will help the developer create an xml file for importing in the crystal report. The user can easily import or export file." + vbCrLf + vbCrLf + "Programmed and Developed by: Sylvster R. Belonio", "About the Creator", , MessageBoxIcon.Information, 400, 170)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If myDialog.show("Do you want to create new file?", "Create File Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            clear_all()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem3.Click
        Me.Close()
    End Sub

    Private Sub ExportXMLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportXMLToolStripMenuItem.Click
        Dim frm As New frmXMLBrowser
        With frm
            '.set_class(myThemes)
            .type_method(frmXMLBrowser.MethodLoad.load_file)
            .ShowInTaskbar = False
            .ShowDialog()
            If .allow_return Then
                Dim fff As String = .FileName
                Dim x As String = myFile.get_FileExtension(fff)
                If fff <> "" And x = ".xml" Then
                    clear_all()
                    myCol.Clear()
                    Dim xmlFile As XmlReader
                    xmlFile = XmlReader.Create(fff, New XmlReaderSettings())
                    Dim ds As New DataSet
                    ds.ReadXml(xmlFile)
                    Dim i As Integer
                    txtDataset.Text = ds.DataSetName

                    For ii As Integer = 0 To ds.Tables.Count - 1
                        'create a list here'
                        lstT.Items.Add(ds.Tables(ii).TableName)
                        Dim tbl As DataTable
                        With myDataTable
                            .new_table(ds.Tables(ii).TableName)
                            .add_columnField("columname")
                            .add_columnField("datatype")
                            tbl = .get_table
                        End With
                        For i = 0 To ds.Tables(ii).Columns.Count - 1
                            tbl.Rows.Add()
                            tbl.Rows(tbl.Rows.Count - 1).Item("columname") = ds.Tables(ii).Columns(i).ColumnName
                            tbl.Rows(tbl.Rows.Count - 1).Item("datatype") = get_ValidateValues(ds.Tables(ii).Columns(i).DataType.ToString)
                        Next
                        myCol.Add(tbl, "key-" + ds.Tables(ii).TableName)
                    Next
                    myDialog.show("You have successfully imported the xml file", "Imported Completed", , MessageBoxIcon.Information)
                Else
                    myDialog.show("Unable to load the file.", "Error", , MessageBoxIcon.Information)
                End If
            End If
        End With
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        If txtDataset.Text <> "" And lstT.Items.Count > 0 Then
            Dim frm As New frmXMLBrowser
            With frm
                '.set_class(myThemes)
                .type_method(frmXMLBrowser.MethodLoad.save_file)
                .ShowInTaskbar = False
                .ShowDialog()
                If .allow_return Then
                    create_XML(.FileName)
                End If
            End With
        Else
            myDialog.show("Please input dataset name and table name.")
        End If
    End Sub

    Private Sub LoagSQLQueryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoagSQLQueryToolStripMenuItem.Click

        With frm

            .ShowInTaskbar = False
            .ShowDialog()
            If .allow_pass Then

                Dim blnfound As Boolean = False
                For i As Integer = 0 To lstT.Items.Count - 1
                    If .txttablename.Text = lstT.Items(i).Text Then
                        blnfound = True
                        Exit For
                    End If
                Next
                If Not blnfound Then
                    lstT.Items.Add(.txttablename.Text)

                    'creating a tablname
                    Dim tbl As DataTable
                    myDataTable.new_table(.txttablename.Text)
                    myDataTable.add_columnField("columname")
                    myDataTable.add_columnField("datatype")
                    tbl = myDataTable.get_table

                    For a As Integer = 0 To .lstColumnName.Items.Count - 1
                        tbl.Rows.Add()
                        Dim c() As String = .lstColumnName.Items(a).Text.Split("-")
                        tbl.Rows(a).Item("columname") = Trim(c(0))
                        tbl.Rows(a).Item("datatype") = "string"
                    Next

                    myCol.Add(tbl)
                    ''''''''''''''''''''
                End If
            End If


        End With
    End Sub
End Class