Module Connection
    Public conn As New OleDb.OleDbConnection()
    Public cmd As New OleDb.OleDbCommand()
    Public gridDataTable As New DataTable 'primary data that has all information
    Public dAdaptor As New OleDb.OleDbDataAdapter
    Public filteredData As DataTable  'filtered data
End Module
