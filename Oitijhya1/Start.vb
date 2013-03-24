Imports System.Data.OleDb
Imports System.Data.Common
Public Class Start

    Private Sub Start_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'List1DataSet."& tableName &"' table. You can move, or remove it, as needed.
        initialiseAdaptor()
        'grid properties
        gridView.DataSource = gridDataTable
        gridView.MultiSelect = True
        gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        optFilter.Enabled = False
    End Sub
    Public Function GetExcelData(ByVal ASpreadSheet As String, ByRef AnError As String, ByVal ASheetName As String) As DataTable

        Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ASpreadSheet & ";Extended Properties=""Excel 8.0;HDR=Yes;"""
        Dim conn As OleDbConnection = New OleDbConnection(connString)
        Dim Dset As New DataTable
        AnError = ""
        Try
            Using conn
                conn.Open()
                Dim schemaTable As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
                Dim firstSheetName As String = CType(schemaTable.Rows(0).Item("TABLE_NAME"), String)
                Dim MyCommand As OleDbDataAdapter = New OleDbDataAdapter("select * from [" & ASheetName & "$]", conn)
                MyCommand.Fill(Dset)
            End Using
        Catch ex As Exception
            AnError = ex.ToString
            Return Nothing
        End Try
        Return Dset
    End Function

    Private Sub initialiseAdaptor()
        conn.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("OitijhyaDatabase").ConnectionString()

        Try
            conn.Open()
            'MsgBox("Connection established!")
        Catch
            MsgBox("Database not found. Locate database.", MsgBoxStyle.Exclamation)
            updateDatabase()
            conn.Open()
            'MsgBox("Connection established!")
        End Try
        'small code snippet to get table names
        Dim userTables As DataTable = Nothing
        Dim restrictions() As String = New String(3) {}
        restrictions(3) = "Table"
        userTables = conn.GetSchema("Tables", restrictions)
        Dim dr As DataRow = userTables.Rows(2)
        tableName = dr("TABLE_NAME")
        'end snippet
        'makes the data adaptor
        dAdaptor = New OleDb.OleDbDataAdapter("Select * From " & tableName & "", conn)
        Me.Text = tableName
        'friendly names
        'Dim custom As DataTableMapping = dAdaptor.TableMappings.Add(""& tableName &"", "Oitijhya Member List")
        'custom.ColumnMappings.Add("SNo", "Serial No.")
        gridDataTable.Clear()
        dAdaptor.Fill(gridDataTable)
        
        conn.Close()
        'delete command of adaptor
        Dim del As New OleDb.OleDbCommand
        Dim boundColumn As String = gridDataTable.Columns(0).Caption
        del.CommandText = "DELETE FROM " & tableName & " WHERE " & boundColumn & "=?"
        del.Connection = conn
        Dim Param As OleDbParameter = del.Parameters.Add(boundColumn, OleDbType.Integer, 4)
        Param.SourceColumn = boundColumn
        Param.SourceVersion = DataRowVersion.Original
        dAdaptor.DeleteCommand = del
        'insert command
        Dim ins As New OleDb.OleDbCommand
        Dim insCol As New OleDb.OleDbCommand
        Dim InsCmdStr As String = String.Empty
        Dim insParam(gridView.Columns.Count) As OleDbParameter
        InsCmdStr = "Insert into " & tableName & " values("
        For i = 0 To gridDataTable.Columns.Count - 2
            InsCmdStr = InsCmdStr & "?,"
            insParam(i) = ins.Parameters.AddWithValue(gridDataTable.Columns(i).Caption, gridDataTable.Columns(i).GetType)
            insParam(i).SourceColumn = gridDataTable.Columns(i).Caption
            insParam(i).SourceVersion = DataRowVersion.Original
        Next
        InsCmdStr = InsCmdStr & "?)"
        Dim j As Integer = gridDataTable.Columns.Count - 1
        insParam(j) = ins.Parameters.AddWithValue(gridDataTable.Columns(j).Caption, gridDataTable.Columns(j).GetType)
        insParam(j).SourceColumn = gridDataTable.Columns(j).Caption
        insParam(j).SourceVersion = DataRowVersion.Original
        ins.CommandText = InsCmdStr
        ins.Connection = conn
        dAdaptor.InsertCommand = ins
        'Update command
        Dim upd As New OleDb.OleDbCommand
        Dim updcol As New OleDb.OleDbCommand
        Dim updCmdStr As String = String.Empty
        Dim updParam(gridView.Columns.Count) As OleDbParameter
        updCmdStr = "Update " & tableName & " set "
        For i = 1 To gridView.Columns.Count - 2
            updCmdStr = updCmdStr & Chr(34) & gridDataTable.Columns(i).Caption & Chr(34) & "=?,"
            updParam(i) = upd.Parameters.AddWithValue(gridDataTable.Columns(i).Caption, gridDataTable.Columns(i).GetType)
            updParam(i).SourceColumn = gridDataTable.Columns(i).Caption
            updParam(i).SourceVersion = DataRowVersion.Original
        Next
        updCmdStr = updCmdStr & Chr(34) & gridDataTable.Columns(j).Caption & Chr(34) & "=?"
        insParam(j) = ins.Parameters.AddWithValue(gridDataTable.Columns(j).Caption, gridDataTable.Columns(j).GetType)
        insParam(j).SourceColumn = gridDataTable.Columns(j).Caption
        insParam(j).SourceVersion = DataRowVersion.Current
        updCmdStr = updCmdStr & " Where " & Chr(34) & gridDataTable.Columns(0).Caption & Chr(34) & "=?"
        insParam(0) = ins.Parameters.AddWithValue(gridDataTable.Columns(0).Caption, gridDataTable.Columns(0).GetType)
        insParam(0).SourceColumn = gridDataTable.Columns(0).Caption
        insParam(0).SourceVersion = DataRowVersion.Original
        upd.CommandText = updCmdStr
        upd.Connection = conn
        dAdaptor.UpdateCommand = upd
        'MsgBox(dAdaptor.UpdateCommand.CommandText)
    End Sub
    Private Sub updateDatabase()
        Dim fileDg As New OpenFileDialog
        fileDg.Filter = "Access Files (*.accdb)|*.accdb|Excel Files(*.xls)|*.xls|All files(*.*)|*.*"
        fileDg.ShowDialog()
        Dim source As String = fileDg.FileName
        Dim dest As String = System.IO.Directory.GetCurrentDirectory
        If System.IO.File.Exists(source) Then
            If (System.IO.Path.GetExtension(source) = ".xls") Then
                Dim tempTable = New DataTable
                Dim err As String = Nothing
                tempTable = GetExcelData(source, err, "Sheet1")
                'MsgBox(tempTable.Rows.Count.ToString())
                'My.Computer.FileSystem.DeleteFile(dest & "\dBase.accdb", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
                'creating new table in .accdb file and populating it
                Dim OLEConnection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dest & "\dBase.accdb" & ";Persist Security Info=True")
                OLEConnection.Open()
                Dim OLECommand As New OleDb.OleDbCommand("", OLEConnection)
                ' Before this line we create a string that holds build for the table structure
                Dim createStr As String = Nothing
                createStr = "CREATE TABLE " & tableName & "("
                Dim dtype As String = Nothing
                Dim dsize As Integer
                For Each dc As DataColumn In tempTable.Columns
                    dsize = 4
                    If (dc.DataType.ToString() = "System.Double") Then
                        dtype = " INTEGER"
                        createStr = createStr & "[" & dc.Caption & "] " & dtype
                    ElseIf (dc.DataType.ToString() = "System.String" Or dc.DataType.ToString() = "System.DateTime") Then
                        dtype = " TEXT"
                        createStr = createStr & "[" & dc.Caption & "] " & " " & dtype & "(" & dsize.ToString() & ")"
                    End If

                    If (dc.Caption = tempTable.Columns(0).Caption) Then
                        createStr = createStr & " NOT NULL"
                    End If
                    createStr = createStr & ","
                Next
                createStr = createStr.Substring(0, createStr.Length - 1)
                createStr = createStr & ")"
                'MsgBox(createStr)
                Dim dropCommand As New OleDb.OleDbCommand("", OLEConnection)
                dropCommand.CommandText = "DROP TABLE " & tableName
                dropCommand.ExecuteNonQuery()
                OLECommand.CommandText = createStr
                OLECommand.ExecuteNonQuery()
                conn.Open()
                dAdaptor.Update(tempTable)
                conn.Close()
                'MsgBox("Copy Started")
            ElseIf System.IO.File.Exists(dest & "\dBase.accdb") Then
                My.Computer.FileSystem.CopyFile(dest & "\dBase.accdb", dest & "\rollback.accdb", FileIO.UIOption.AllDialogs, _
                FileIO.UICancelOption.DoNothing)
                My.Computer.FileSystem.CopyFile(source, dest & "\dBase.accdb", FileIO.UIOption.OnlyErrorDialogs, _
                FileIO.UICancelOption.DoNothing)
            Else
                My.Computer.FileSystem.CopyFile(source, dest & "\dBase.accdb", FileIO.UIOption.AllDialogs, _
                FileIO.UICancelOption.DoNothing)
                My.Computer.FileSystem.CopyFile(dest & "\dBase.accdb", dest & "\rollback.accdb", FileIO.UIOption.AllDialogs, _
               FileIO.UICancelOption.DoNothing)
            End If
            'MsgBox("Update successful")
        End If
    End Sub
    Private Sub dbRollback()
        Dim root As String = System.IO.Directory.GetCurrentDirectory
        If System.IO.File.Exists(root & "\rollback.accdb") Then
            My.Computer.FileSystem.RenameFile(root & "\dBase.accdb", "dBaseTemp.accdb")
            My.Computer.FileSystem.RenameFile(root & "\rollback.accdb", "dBase.accdb")
            My.Computer.FileSystem.RenameFile(root & "\dBaseTemp.accdb", "rollback.accdb")
        End If
    End Sub

    Private Sub updateDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        updateDatabase()
        initialiseAdaptor()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRollback.Click
        dbRollback()
        MsgBox("Hurray! Database rolled back.")
        initialiseAdaptor()
    End Sub

    Private Sub gridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridView.CellContentClick

    End Sub

    Private Sub gridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gridView.CellMouseDown
        If e.RowIndex >= 0 & e.ColumnIndex >= 0 & e.Button = Windows.Forms.MouseButtons.Right Then
            gridView.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub SetFilterCriteriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetFilterCriteriaToolStripMenuItem.Click
        SelectFilter.Show()
        Me.Enabled = False
    End Sub
    Sub showFilteredResults(ByRef filt() As Integer)
        'creating filter structure
        filteredData = New DataTable
        Dim MemberCol(gridView.Columns.Count) As DataColumn
        For i = 0 To filt.Length() - 1
            If (filt(i) <> -1) Then
                'MsgBox(gridView.Columns(filt(i)).Name.ToString)
                MemberCol(i) = New DataColumn(gridView.Columns(filt(i)).Name.ToString)
                MemberCol(i).Caption = gridView.Columns(filt(i)).Name.ToString
                filteredData.Columns.AddRange(New DataColumn() {MemberCol(i)})
            End If
        Next
        'populating filter
        Dim selectRow As DataRow
        Dim tempRow As DataGridViewRow
        For Each tempRow In gridView.SelectedRows
            selectRow = filteredData.NewRow()
            For i = 0 To filt.Length() - 1
                If (filt(i) <> -1) Then
                    selectRow(i) = tempRow.Cells(filt(i)).Value
                End If
            Next
            filteredData.Rows.Add(selectRow)
        Next
        gridView.DataSource = filteredData
        Me.optFilter.Checked = True
        Me.Enabled() = True
        SelectFilter.Close()
        optFilter.Enabled = True
    End Sub

    Private Sub GridRCMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridRCMenu.Opening

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim row As DataGridViewRow
        Dim del As OleDb.OleDbCommand = dAdaptor.DeleteCommand
        For Each row In gridView.SelectedRows
            If Not row.IsNewRow Then
                gridView.Rows.Remove(row)
            End If
        Next

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optFilter.CheckedChanged
        If optFilter.Checked = True Then
            cmdLoad.Enabled = False
            cmdSave.Enabled = False
            cmdRollback.Enabled = False
            cmdPrint.Enabled = True
            If filteredData Is Nothing Then
                MsgBox("Set a Filter First")
            Else
                gridView.DataSource = filteredData
            End If
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optFull.CheckedChanged
        If optFull.Checked = True Then
            cmdSave.Enabled = True
            cmdLoad.Enabled = True
            cmdRollback.Enabled = True
            cmdPrint.Enabled = False
            gridView.Columns.Clear()
            gridView.DataSource = gridDataTable
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If MsgBox("Are you sure? Changes will be permanent.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            dAdaptor.Update(gridDataTable)
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        printDialog.Show()
    End Sub
End Class