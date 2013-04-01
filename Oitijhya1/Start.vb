﻿Imports System.Data.OleDb
Imports System.Data.Common
Public Class Start

    Private Sub Start_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdLoad.Image = Image.FromFile(Application.StartupPath & "\Images\new.png")
        cmdInfo.Image = Image.FromFile(Application.StartupPath & "\Images\info.png")
        cmdSave.Image = Image.FromFile(Application.StartupPath & "\Images\save.png")
        cmdRollback.Image = Image.FromFile(Application.StartupPath & "\Images\undo.png")
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
    Private Function makeDelCommand(ByRef table As DataTable) As OleDb.OleDbCommand
        Dim del As New OleDb.OleDbCommand
        Dim boundColumn As String = table.Columns(0).Caption
        del.CommandText = "DELETE FROM " & tableName & " WHERE " & boundColumn & "=?"
        del.Connection = conn
        Dim Param As OleDbParameter = del.Parameters.Add(boundColumn, OleDbType.Integer, 4)
        Param.SourceColumn = boundColumn
        Param.SourceVersion = DataRowVersion.Original
        Return del
    End Function
    Private Function makeInsCommand(ByRef table As DataTable) As OleDb.OleDbCommand
        Dim ins As New OleDb.OleDbCommand
        Dim insCol As New OleDb.OleDbCommand
        Dim InsCmdStr As String = String.Empty
        Dim insParam(table.Columns.Count) As OleDbParameter
        InsCmdStr = "Insert into " & tableName & " values("
        For i = 0 To table.Columns.Count - 2
            InsCmdStr = InsCmdStr & "?,"
            insParam(i) = ins.Parameters.AddWithValue(table.Columns(i).Caption, table.Columns(i).GetType)
            insParam(i).SourceColumn = table.Columns(i).Caption
            insParam(i).SourceVersion = DataRowVersion.Original
        Next
        InsCmdStr = InsCmdStr & "?)"
        Dim j As Integer = table.Columns.Count - 1
        insParam(j) = ins.Parameters.AddWithValue(table.Columns(j).Caption, table.Columns(j).GetType)
        insParam(j).SourceColumn = table.Columns(j).Caption
        insParam(j).SourceVersion = DataRowVersion.Original
        ins.CommandText = InsCmdStr
        ins.Connection = conn
        Return ins
    End Function
    Private Function makeUpdCommand(ByRef table As DataTable) As OleDb.OleDbCommand
        Dim upd As New OleDb.OleDbCommand
        Dim updcol As New OleDb.OleDbCommand
        Dim updCmdStr As String = String.Empty
        Dim updParam(table.Columns.Count) As OleDbParameter
        updCmdStr = "Update " & tableName & " set "
        For i = 1 To table.Columns.Count - 2
            updCmdStr = updCmdStr & "[" & table.Columns(i).Caption & "]" & "=?,"
            updParam(i) = upd.Parameters.AddWithValue(table.Columns(i).Caption, table.Columns(i).GetType)
            updParam(i).SourceColumn = table.Columns(i).Caption
            updParam(i).SourceVersion = DataRowVersion.Original
        Next
        Dim j As Integer = table.Columns.Count - 1
        updCmdStr = updCmdStr & "[" & table.Columns(j).Caption & "]" & "=?"
        updParam(j) = upd.Parameters.AddWithValue(table.Columns(j).Caption, table.Columns(j).GetType)
        updParam(j).SourceColumn = table.Columns(j).Caption
        updParam(j).SourceVersion = DataRowVersion.Current
        updCmdStr = updCmdStr & " Where " & "" & table.Columns(0).Caption & "" & "=?"
        updParam(0) = upd.Parameters.AddWithValue(table.Columns(0).Caption, table.Columns(0).GetType)
        updParam(0).SourceColumn = table.Columns(0).Caption
        updParam(0).SourceVersion = DataRowVersion.Original
        upd.CommandText = updCmdStr
        upd.Connection = conn
        Return upd
        'MsgBox(dAdaptor.UpdateCommand.CommandText)
    End Function
    Private Function getTableName(ByRef connection As OleDb.OleDbConnection) As String
        Dim flag As Boolean = False
        If (connection.State = ConnectionState.Closed) Then
            connection.Open()
            flag = True
        End If
        Dim userTables As DataTable = Nothing
        Dim restrictions() As String = New String(3) {}
        restrictions(3) = "Table"
        userTables = conn.GetSchema("Tables", restrictions)
        Try
            Dim dr As DataRow = userTables.Rows(2)
            tableName = dr("TABLE_NAME")
        Catch ex As Exception

            tableName = "Members"
        End Try

        Return tableName
        If (flag = True) Then
            connection.Close()
        End If
    End Function
    Private Sub initialiseAdaptor()
        conn.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("OitijhyaDatabase").ConnectionString()

        Try
            conn.Open()
        Catch
            MsgBox("Database not found. Locate database.", MsgBoxStyle.Exclamation)
            updateDatabase()
            conn.Open()
        End Try
        tableName = getTableName(conn)
        'end snippet
        'makes the data adaptor
        dAdaptor = New OleDb.OleDbDataAdapter("Select * From " & tableName & "", conn)
        Me.Text = tableName
        'friendly names
        'Dim custom As DataTableMapping = dAdaptor.TableMappings.Add(""& tableName &"", "Oitijhya Member List")
        'custom.ColumnMappings.Add("SNo", "Serial No.")
        'gridDataTable.Clear()
        gridDataTable = New DataTable()
        dAdaptor.Fill(gridDataTable)
        gridView.DataSource = gridDataTable
        dAdaptorCB = New OleDb.OleDbCommandBuilder(dAdaptor)
        dAdaptor.UpdateCommand = dAdaptorCB.GetUpdateCommand()
        dAdaptor.InsertCommand = makeInsCommand(gridDataTable)
        dAdaptor.DeleteCommand = makeDelCommand(gridDataTable)
        conn.Close()
    End Sub
    Private Function createTableQuery(ByRef tableName As String, ByRef table As DataTable) As String
        Dim createStr As String = Nothing
        createStr = "CREATE TABLE " & tableName & "("
        Dim dtype As String = Nothing
        Dim dsize As Integer
        Dim colName As String = Nothing
        For Each dc As DataColumn In table.Columns
            dsize = 255
            colName = trimString(dc.Caption)
            If (dc.DataType.ToString() = "System.Double") Then
                dtype = " INTEGER"
                createStr = createStr & "[" & colName & "] " & dtype
            ElseIf (dc.DataType.ToString() = "System.String" Or dc.DataType.ToString() = "System.DateTime") Then
                dtype = " TEXT"
                createStr = createStr & "[" & colName & "] " & " " & dtype & "(" & dsize.ToString() & ")"
            End If

            If (dc.Caption = table.Columns(0).Caption) Then
                createStr = createStr & " NOT NULL"
            End If
            createStr = createStr & ","
        Next
        colName = trimString(table.Columns(0).Caption)
        createStr = createStr & "Primary Key ([" & colName & "])"
        createStr = createStr & ")"
        Return createStr
    End Function
    Private Function trimString(ByRef str As String) As String
        str = str.Replace(".", "")
        str = str.Replace("#", "")
        str = str.Replace(" ", "")
        str = str.Trim
        Return str
    End Function
    Private Sub updateDatabase()
        Dim fileDg As New OpenFileDialog
        fileDg.Filter = "Excel Files(*.xls)|*.xls|Access Files (*.accdb)|*.accdb|All files(*.*)|*.*"
        fileDg.ShowDialog()
        Dim source As String = fileDg.FileName
        Dim dest As String = System.IO.Directory.GetCurrentDirectory
        If System.IO.File.Exists(source) Then
            If (System.IO.Path.GetExtension(source) = ".xls") Then
                My.Computer.FileSystem.CopyFile(dest & "\dBase.accdb", dest & "\rollback.accdb", FileIO.UIOption.AllDialogs, _
                    FileIO.UICancelOption.DoNothing)
                Dim tempTable = New DataTable
                Dim err As String = Nothing
                tempTable = GetExcelData(source, err, "Sheet1")
                conn.Open()
                Dim createCommand As New OleDb.OleDbCommand("", conn)
                Dim dropCommand As New OleDb.OleDbCommand("", conn)
                dropCommand.CommandText = "DROP TABLE " & tableName
                createCommand.CommandText = createTableQuery(tableName, tempTable)
                dropCommand.ExecuteNonQuery()
                createCommand.ExecuteNonQuery()
                conn.Close()
                gridDataTable = New DataTable
                gridDataTable = tempTable.Clone()
                Dim updAdaptor As New OleDb.OleDbDataAdapter("Select * From " & tableName & "", conn)
                Dim updAdCommandBuilder As OleDb.OleDbCommandBuilder = New OleDb.OleDbCommandBuilder(updAdaptor)
                updAdaptor.InsertCommand = makeInsCommand(tempTable)
                gridDataTable.Clear()
                Dim temprow As DataRow = Nothing
                conn.Open()
                For Each row As DataRow In tempTable.Rows
                    gridDataTable.Rows.Add(row.ItemArray)
                    Try
                        updAdaptor.Update(gridDataTable)
                    Catch ex As Exception
                    End Try
                Next
                conn.Close()
            Else
                If System.IO.File.Exists(dest & "\dBase.accdb") Then
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
        'MsgBox("Hurray! Database rolled back.")
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
        optFilter.Visible = True
        optFull.Visible = True
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
            'MsgBox(dAdaptor.UpdateCommand.CommandText.ToString)
            conn.Open()
            dAdaptor.Update(gridDataTable)
            conn.Close()
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        printDialog.Show()
    End Sub

    Private Sub PrintSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSelectedToolStripMenuItem.Click
        'reportDset.reportTableDataTable = gridDataTable
        reportTable = gridDataTable.Clone
        Dim selectrow As DataRow
        If (gridView.SelectedRows.Count > 0) Then
            For Each temprow As DataGridViewRow In gridView.SelectedRows
                selectrow = reportTable.NewRow()
                For i = 0 To reportTable.Columns.Count - 1
                    selectrow(i) = temprow.Cells(i).Value
                Next
                reportTable.Rows.Add(selectrow)
            Next
        Else
            MsgBox("Please select rows to be printed")
        End If

        ReportViewer.Show()

    End Sub

    Private Sub cmdInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInfo.Click
        AboutBox1.Show()
    End Sub
End Class