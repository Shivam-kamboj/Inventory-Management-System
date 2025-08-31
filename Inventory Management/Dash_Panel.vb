Public Class Dash_Panel
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim da As OleDb.OleDbDataAdapter
    Dim dtTable As New DataTable
    Dim lowStockProducts As New List(Of String)
    Private Blinking As New Timer()

    Private Sub Dash_Panel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Inventory.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim stock_query As String = "SELECT Pname,Quantity FROM inventory"
        cmd = New OleDb.OleDbCommand(stock_query, conn)
        da = New OleDb.OleDbDataAdapter(cmd)
        dtTable.Clear()
        da.Fill(dtTable)

        lowStockProducts.Clear()
        For Each row As DataRow In dtTable.Rows

            Dim productName As String = row("Pname").ToString()
            Dim quantity As Integer = CInt(row("Quantity"))

            If quantity < 5 Then
                lowStockProducts.Add("Product: " & productName & " Quantity: " & quantity)
            End If
            If lowStockProducts.Count > 0 Then
                Alert_Label.Visible = True
                Alert_Label.Text = "Low Stock Alert!" & Environment.NewLine & String.Join(Environment.NewLine, lowStockProducts)
                Alert_Label.ForeColor = Color.Red
                If Not Blinking.Enabled Then
                    Blinking.Interval = 500
                    AddHandler Blinking.Tick, AddressOf BlinkLabel
                    Blinking.Start()
                End If
            Else
                Alert_Label.ForeColor = Color.Blue
                Alert_Label.Text = "No Stock Alerts"
                Blinking.Stop()
            End If
        Next
        dtTable.Clear()
        Dim query As String = "SELECT TOP 5 * FROM inventory ORDER BY DateTime DESC"
        cmd = New OleDb.OleDbCommand(query, conn)
        da = New OleDb.OleDbDataAdapter(cmd)

        da.Fill(dtTable)
        RecentInventory.DataSource = dtTable

        TotalProduct_Label.Text = Dashboard.tot_units
        Dim dash As New Dashboard()
        dash.InitialiseColorDataGridView(RecentInventory)
        conn.Close()

    End Sub
    Private Sub BlinkLabel(ByVal sender As Object, ByVal e As EventArgs)
        Alert_Label.Visible = Not Alert_Label.Visible
    End Sub

  
End Class