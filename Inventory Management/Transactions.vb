Public Class Transactions
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim da As OleDb.OleDbDataAdapter
    Dim dtTable As New DataTable

    Private Sub Transactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Padding = New Padding(0, TitleLabel.Height, 0, 0)
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Inventory.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim getStock As String = "SELECT * FROM Sales ORDER BY SaleDate DESC"
        cmd = New OleDb.OleDbCommand(getStock, conn)
        da = New OleDb.OleDbDataAdapter(cmd)
        da.Fill(dtTable)
        TotSales_DataGridView.DataSource = dtTable

        Dim dash As New Dashboard()
        dash.InitialiseColorDataGridView(TotSales_DataGridView)
        conn.Close()
    End Sub
End Class