
Public Class Dashboard
    



    ' Database Variables
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim daAdapter As OleDb.OleDbDataAdapter
    Dim dtTable As New DataTable
    Dim dt As New DataTable
    Dim tot_pro As Integer
    Dim sumResult As Object
    Dim i As Integer
    Public Shared lowStockProducts As New List(Of String)
    Public Shared tot_units As Integer
    Public Shared tot_rows As Integer
    Public Shared quantity As Integer
    Dim secondsPassed As Integer = 0
    Private Blinking As New Timer()

    Public Sub InitialiseColorDataGridView(ByVal dgv As DataGridView)
        ' Background Color
        dgv.BackgroundColor = Color.FromArgb(240, 240, 240) ' Light Gray Background

        ' Column Headers Styling
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(21, 101, 192) ' Dark Blue
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White ' White Text
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

        ' Row Styling (Alternating Colors)
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(227, 242, 253) ' Light Blue
        dgv.RowsDefaultCellStyle.BackColor = Color.White ' White for default rows
        dgv.RowsDefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33) ' Dark Gray Text
        dgv.RowsDefaultCellStyle.Font = New Font("Segoe UI", 9)

        ' Selection Highlight
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246) ' Soft Blue Selection
        dgv.DefaultCellStyle.SelectionForeColor = Color.White

        ' Grid Line Color
        dgv.GridColor = Color.FromArgb(189, 189, 189) ' Light Gray Grid Lines

        ' Borders and Cell Styles
        dgv.EnableHeadersVisualStyles = False
        dgv.BorderStyle = BorderStyle.None
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

        ' Row Header Style
        dgv.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(189, 189, 189) ' Light Gray Row Headers
        dgv.RowHeadersDefaultCellStyle.ForeColor = Color.Black

        ' Padding for better spacing
        dgv.DefaultCellStyle.Padding = New Padding(5)

        'Cell height
        dgv.RowTemplate.Height = 40 ' Increase Row Height (Adjust as needed)
    End Sub


    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width,
                 Screen.PrimaryScreen.WorkingArea.Height)
        ' Database Connection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Inventory.accdb"

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        ' Fetching recent 5 records
        Dim query As String = "SELECT TOP 5 * FROM inventory ORDER BY DateTime DESC"
        cmd = New OleDb.OleDbCommand(query, conn)
        daAdapter = New OleDb.OleDbDataAdapter(cmd)

        dtTable.Clear()
        daAdapter.Fill(dtTable)
        RecentInventory.DataSource = dtTable

        Dim stock_query As String = "SELECT Pname,Quantity FROM inventory"
        cmd.Connection = conn
        dtTable.Clear()
        daAdapter.SelectCommand = cmd
        dt.Clear()

        daAdapter.Fill(dtTable)

        For Each row As DataRow In dtTable.Rows

            Dim productName As String = row("Pname").ToString()
            quantity = CInt(row("Quantity"))

            tot_rows = tot_rows + 1

            If quantity < 25 Then
                lowStockProducts.Add("Product: " & productName & " Quantity: " & quantity)
            End If
            If lowStockProducts.Count > 0 Then
                Alert_Label.Visible = True
                Alert_Label.Text = "Low Stock Alert!" & Environment.NewLine & String.Join(Environment.NewLine, lowStockProducts)
                Alert_Label.ForeColor = Color.Red
                If Not Blink.Enabled Then
                    Blink.Interval = 500
                    AddHandler Blink.Tick, AddressOf BlinkLabel
                    Blink.Start()
                End If
            Else
                Alert_Label.ForeColor = Color.Blue
                Alert_Label.Text = "No Stock Alerts"
                Blink.Stop()
            End If
        Next


        Dim SumUnits As String = "SELECT SUM(Quantity) As Tot_Units FROM inventory"
        cmd.Connection = conn
        cmd = New OleDb.OleDbCommand(SumUnits, conn)
        daAdapter = New OleDb.OleDbDataAdapter(cmd)

        dt.Clear()
        daAdapter.Fill(dt)

        ' Checking if the DataTable has rows before accessing them
        If dt.Rows.Count > 0 AndAlso Not IsDBNull(dt.Rows(0)("Tot_Units")) Then
            tot_units = dt.Rows(0)("Tot_Units").ToString()
            TotalProduct_Label.Text = dt.Rows(0)("Tot_Units").ToString()
        Else
            TotalProduct_Label.Text = 0
        End If


        'Components
        Timer_DateTime.Enabled = True
        Panel2.Visible = False
        Panel3.Visible = False
        Label7.Visible = False
        InitialiseColorDataGridView(RecentInventory)
        OpenChildForm(New Dash_Panel())
        conn.Close()
    End Sub

    Private Sub BlinkLabel(ByVal sender As Object, ByVal e As EventArgs)
        Alert_Label.Visible = Not Alert_Label.Visible
    End Sub

    Private Sub Timer_DateTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_DateTime.Tick
        DateTime.Text = Date.Now.ToString("dd-MM-yyy  hh:mm:ss")
        ToolStripStatusLabel2.Text = "Welcome " & Login.LoggedInUser
    End Sub

    Private Sub Stockbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Stockbtn.Click
        buttoncloser_timer.Interval = 1000
        buttoncloser_timer.Start()
        Panel2.Visible = Not Panel2.Visible
        Panel3.Visible = Not Panel3.Visible
    End Sub

    Private Sub buttoncloser_timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttoncloser_timer.Tick
        secondsPassed += 1
        If secondsPassed = 3 Then
            Panel2.Visible = False
            Panel3.Visible = False
            buttoncloser_timer.Stop()
            buttoncloser_timer.Start()
            secondsPassed = 0
        End If
    End Sub

    Private Sub LogoutBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutBtn.Click
        Dim Login As New Login
        Login.Show()
        Me.Hide()
    End Sub
    Private Sub OpenChildForm(ByVal childForm As Form)

        TotalProducts_Grpbox.Visible = False
        StockAlert_GrpBox.Visible = False
        RecentTraction_GrpBox.Visible = False

        ' Clear previous form from PanelContainer
        MainPanel.Controls.Clear()

        ' Set properties for the child form
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill ' Fit inside PanelContainer

        ' Add child form to PanelContainer
        MainPanel.Controls.Add(childForm)
        childForm.Show()
    End Sub

    Private Sub ShowStockBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowStockBtn.Click
        OpenChildForm(New ShowInventory())
    End Sub

    Public Sub ShowDefaultPanel()
        ' Remove all dynamically added controls (forms)
        MainPanel.Controls.Clear()

        ' Now, re-add the default controls back
        TotalProducts_Grpbox.Visible = True
        StockAlert_GrpBox.Visible = True
        RecentTraction_GrpBox.Visible = True
    End Sub

    Private Sub DashboardBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DashboardBtn.Click
        OpenChildForm(New Dash_Panel())
    End Sub

    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click
        OpenChildForm(New AddProduct())
    End Sub

    Private Sub UpdateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateBtn.Click
        OpenChildForm(New ManageStock())
    End Sub

    Private Sub AddCategoryBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCategoryBtn.Click
        OpenChildForm(New category())
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub SalesBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesBtn.Click
        OpenChildForm(New POSForm)
    End Sub

    Private Sub ManageCustomerBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageCustomerBtn.Click
        OpenChildForm(New Transactions)
    End Sub

    Private Sub StockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem.Click
        OpenChildForm(New ShowInventory)
    End Sub

    Private Sub SalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesToolStripMenuItem.Click
        OpenChildForm(New Transactions)
    End Sub

    Private Sub ProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductToolStripMenuItem.Click
        OpenChildForm(New category)
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        OpenChildForm(New Dash_Panel)
    End Sub

    Private Sub EditStoreDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditStoreDetailsToolStripMenuItem.Click
        Dim storeForm As New StoreDetailsForm
        storeForm.StartPosition = FormStartPosition.CenterParent
        storeForm.ShowDialog()
    End Sub

    Private Sub AddDiscountCouponsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddDiscountCouponsToolStripMenuItem.Click
        Dim DiscountPage As New AddDiscountCoupons
        DiscountPage.StartPosition = FormStartPosition.CenterParent
        DiscountPage.ShowDialog()
    End Sub


 
    Private Sub TotalProduct_Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalProduct_Label.Click

    End Sub
End Class
