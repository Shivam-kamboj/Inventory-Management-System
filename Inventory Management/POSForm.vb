Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.IO
Public Class POSForm
    Dim checkbtn As Boolean = False
    Dim DiscountOrNot As Boolean = False
    Dim discountAmount As Double
    Dim discountPercent As Double
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Inventory.accdb")
    Dim newQty As Integer = 0

    ' This function generate the sale id's for each transaction
    Private Function GetNextSaleID() As Integer
        Dim nextSaleID As Integer = 1

        If conn.State = ConnectionState.Closed Then conn.Open() ' Open connection

        Dim da As New OleDbDataAdapter("SELECT MAX(SaleID) FROM Sales", conn)
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count > 0 AndAlso Not IsDBNull(dt.Rows(0)(0)) Then
            nextSaleID = CInt(dt.Rows(0)(0)) + 1

        End If
        
        conn.Close()

        Return nextSaleID
    End Function

    Private Sub Pos_btn_Scan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos_btn_Scan.Click
        If conn.State = ConnectionState.Closed Then conn.Open()


        'checking if barcode is entered
        If String.IsNullOrWhiteSpace(Pos_Textbox_Barcode.Text) Then
            MessageBox.Show("Please enter a barcode!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'check if valid Quantity is entered
        Dim ProductQuantity As Integer = CInt(Pos_Qty_NumericUpDown.Value)
        If ProductQuantity <= 0 Then
            MessageBox.Show("Please enter a valid quantity (minimum 1)", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub 'exit sub if valid quantity is not entered
        End If
        'Fetching product details from database
        Dim query As String = " SELECT * FROM inventory WHERE Barcode=@barcode"
        Dim da As New OleDbDataAdapter(query, conn)

        da.SelectCommand.Parameters.AddWithValue("@barcode", Pos_Textbox_Barcode.Text)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim Productname As String = dt(0)("Pname").ToString()
            Dim AvailableStock As Integer = CInt(dt(0)("Quantity"))
            Dim Productprice As Double = CDbl(dt(0)("Price"))

            'Checking if stock Quantity is enough before adding
            If AvailableStock < ProductQuantity Then
                MessageBox.Show("Not Enough Stock Avaliable" & AvailableStock & "left.", "Stock error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            'check if product already exist in cart
            For Each row As DataGridViewRow In Pos_Dgv.Rows
                If row.Cells("Barcode").Value IsNot Nothing AndAlso row.Cells("Barcode").Value.ToString() = Pos_Textbox_Barcode.Text Then

                    Dim currentQty As Integer = CInt(row.Cells("Quantity").Value)
                    Dim newQty As Integer = currentQty + ProductQuantity
                    'Ensuring new total quantity doesnot exceed stock
                    If newQty > AvailableStock Then
                        MessageBox.Show("Not enough stock! You can only add " & (AvailableStock - currentQty) & " more.", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    row.Cells("Quantity").Value = newQty
                    row.Cells("TotalPrice").Value = CDbl(row.Cells("ProductPrice").Value) * newQty
                    CalculateTotal()
                    Exit Sub
                End If

            Next
            'If product is not already in cart then add it
            Pos_Dgv.Rows.Add(Pos_Textbox_Barcode.Text, Productname, ProductQuantity, Productprice, Productprice * ProductQuantity)
            CalculateTotal()
        Else
            MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        conn.Close()

    End Sub

    Private Sub CalculateTotal()

        Dim subtotal As Double = 0

        For Each row As DataGridViewRow In Pos_Dgv.Rows
            subtotal += CDbl(row.Cells("TotalPrice").Value)
        Next

        ' Default values
        discountPercent = 0
        discountAmount = 0

        ' Check Discount Code in Database
        If Not String.IsNullOrWhiteSpace(DiscountTextbox.Text) Then

            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim da As New OleDbDataAdapter("SELECT Discount FROM DiscountCoupons WHERE DiscountCodes = @code", conn)
            da.SelectCommand.Parameters.AddWithValue("@code", DiscountTextbox.Text)
            Dim dt As New DataTable()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                DiscountOrNot = True
                discountPercent = CInt(dt.Rows(0)("Discount"))
                discountAmount = (discountPercent / 100) * subtotal
            Else
                MsgBox("No Discount Coupon available")
            End If
           
            conn.Close()

        End If

        ' Apply discount
        Dim grandTotal As Double = subtotal - discountAmount

        Pos_Total_value.Text = subtotal.ToString("0.00")
        DiscountValue.Text = discountAmount.ToString("0.00")
        Pos_GTotal_Value.Text = grandTotal.ToString("0.00")
    End Sub


    Private Sub Pos_btn_Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos_btn_Remove.Click
        If Pos_Dgv.SelectedRows.Count > 0 Then
            Pos_Dgv.Rows.Remove(Pos_Dgv.SelectedRows(0)) 'remove the first selected row
            CalculateTotal()
        Else
            MessageBox.Show("Select the Product to Remove", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Pos_btn_Checkout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos_btn_Checkout.Click

        If Pos_Dgv.Rows.Count = 0 Then
            MessageBox.Show("Cart is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        ' My.Computer.Audio.Play("D:\VB .net\Practice\Inventory Management\Sounds\PaymentSound.wav", AudioPlayMode.Background)
        Dim saleID As Integer = GetNextSaleID()
        If saleID = -1 Then Exit Sub ' If Sale ID retrieval failed, stop execution.

        If conn.State = ConnectionState.Closed Then conn.Open()

        For Each row As DataGridViewRow In Pos_Dgv.Rows

            ' If row.IsNewRow Then Continue For 'This  function the new empty row in dgv,empty raw gives nothing value which cause error

            ' Ensure all required cells have values before proceeding
            If row.Cells("Barcode").Value Is Nothing Then
                MessageBox.Show("Invalid product details detected in the cart!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If row.Cells("ProductName").Value Is Nothing Then
                MessageBox.Show("Invalid product details detected in the cart!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If row.Cells("Quantity").Value Is Nothing Then
                MessageBox.Show("Invalid product details detected in the cart!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If row.Cells("ProductPrice").Value Is Nothing Then
                MessageBox.Show("Invalid product details detected in the cart!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If row.Cells("TotalPrice").Value Is Nothing Then
                MessageBox.Show("Invalid product details detected in the cart!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            ' Now, safely retrieve values
            Dim barcode As String = row.Cells("Barcode").Value.ToString()
            Dim pname As String = row.Cells("ProductName").Value.ToString()
            Dim qty As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
            Dim price As Double = Convert.ToDouble(row.Cells("ProductPrice").Value)
            Dim total As Double = Convert.ToDouble(row.Cells("TotalPrice").Value)

            ' Insert into Sales table
            Dim cmd As New OleDbCommand("INSERT INTO Sales (SaleID, Barcode, ProductName, Quantity, Price, Total, SaleDate) VALUES (@id, @barcode, @pname, @qty, @price, @total, @date)", conn)
            cmd.Parameters.AddWithValue("@id", saleID)
            cmd.Parameters.AddWithValue("@barcode", barcode)
            cmd.Parameters.AddWithValue("@pname", pname)
            cmd.Parameters.AddWithValue("@qty", qty)
            cmd.Parameters.AddWithValue("@price", price)

            cmd.Parameters.AddWithValue("@total", total)

            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"))
            cmd.ExecuteNonQuery()

            ' Reduce stock quantity
            Dim updateCmd As New OleDbCommand("UPDATE inventory SET Quantity = Quantity - @qty WHERE Barcode=@barcode", conn)
            updateCmd.Parameters.AddWithValue("@qty", qty)
            updateCmd.Parameters.AddWithValue("@barcode", barcode)
            updateCmd.ExecuteNonQuery()
        Next

        'MessageBox.Show("Sale completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        CalculateTotal()
        If DiscountOrNot Then
            MsgBox("Discount Coupon Applied")
        End If
      
        conn.Close()
        Pos_btn_Checkout.Enabled = False
        checkbtn = True
    End Sub


    Dim storename As String = ""
    Dim storeadress As String = ""
    Dim storephone As String = ""
    Dim invoicetext As String = ""

    Private Sub Pos_btn_PrintRecipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos_btn_PrintRecipt.Click
        '  My.Computer.Audio.Play("D:\VB .net\Practice\Inventory Management\Sounds\Print.wav", AudioPlayMode.Background)
        If checkbtn Then


            ' Load store details from the text file
            loadstoredetails()

            ' Generate receipt text
            GenerateReciptText()

            ' Show print preview
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.WindowState = FormWindowState.Maximized ' Open print preview in full screen
            PrintPreviewDialog1.ShowDialog()

            checkbtn = False
            DiscountOrNot = False
            Pos_Total_value.Text = Nothing
            DiscountValue.Text = Nothing
            Pos_GTotal_Value.Text = Nothing
            Pos_Dgv.Rows.Clear()
            Pos_Textbox_Barcode.Clear()
            Pos_Qty_NumericUpDown.Value = Pos_Qty_NumericUpDown.Minimum
            DiscountTextbox.Clear()
            Pos_btn_Checkout.Enabled = True
        Else
            MsgBox("Please Checkout first")

        End If

    End Sub

    Private Sub loadstoredetails()
        Dim storedetailspath As String = "StoreDetails.txt"

        If File.Exists(storedetailspath) Then
            Dim lines() As String = File.ReadAllLines(storedetailspath)
            If lines.Length > 0 Then storename = lines(0)
            If lines.Length > 1 Then storeadress = lines(1)
            If lines.Length > 2 Then storephone = lines(2)
        End If

    End Sub

    Private Sub GenerateReciptText()
        Dim SaleID As Integer = GetNextSaleID()
        Dim InvoiceDate As String = DateTime.Now.ToString("dd-MM-yyyy")
        Dim InvoiceTime As String = DateTime.Now.ToString("hh:mm tt")
        Dim subtotal As Double = 0
        Dim GrandTotal As Double = 0
        Dim discountAmount As Double = 0
        Dim borderLine As String = New String("="c, 60)
        Dim dotLine As String = New String("."c, 60)

        invoicetext = ""

        ' ===== Store Header =====
        invoicetext &= borderLine & Environment.NewLine
        invoicetext &= storename.PadLeft((50 + storename.Length) \ 2).PadRight(48) & Environment.NewLine
        invoicetext &= borderLine & Environment.NewLine
        invoicetext &= storeadress & Environment.NewLine
        invoicetext &= "Tel: " & storephone & Environment.NewLine
        invoicetext &= dotLine & Environment.NewLine


        invoicetext &= "[INVOICE #]: " & SaleID.ToString().PadRight(15)
        invoicetext &= "[DATE]: " & InvoiceDate & Environment.NewLine
        invoicetext &= "[TIME]: " & InvoiceTime & Environment.NewLine
        invoicetext &= dotLine & Environment.NewLine


        invoicetext &= "Item".PadRight(22) & "Qty".PadLeft(5) & "Rate".PadLeft(10) & "Total".PadLeft(13) & Environment.NewLine
        invoicetext &= New String("-"c, 50) & Environment.NewLine

        '  Table Rows 
        For Each row As DataGridViewRow In Pos_Dgv.Rows
            If row.IsNewRow OrElse row.Cells("ProductName").Value Is Nothing Then Continue For

            Dim pname As String = row.Cells("ProductName").Value.ToString()
            Dim qty As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
            Dim price As Double = Convert.ToDouble(row.Cells("ProductPrice").Value)
            Dim total As Double = Convert.ToDouble(row.Cells("TotalPrice").Value)
            subtotal += total

            If pname.Length > 22 Then pname = pname.Substring(0, 22)

            invoicetext &= pname.PadRight(22) &
                           qty.ToString().PadLeft(5) &
                           price.ToString("F2").PadLeft(10) &
                           total.ToString("F2").PadLeft(13) & Environment.NewLine
        Next

        ' Totals 
        discountAmount = subtotal * (discountPercent / 100)
        GrandTotal = subtotal - discountAmount

        invoicetext &= New String("-"c, 50) & Environment.NewLine
        invoicetext &= "[SUBTOTAL]:".PadRight(35) & subtotal.ToString("F2").PadLeft(15) & Environment.NewLine
        invoicetext &= "(-) Discount (" & discountPercent & "%):".PadRight(30) & "-" & discountAmount.ToString("F2").PadLeft(2) & Environment.NewLine
        invoicetext &= "=> GRAND TOTAL:".PadRight(35) & GrandTotal.ToString("F2").PadLeft(15) & Environment.NewLine
        invoicetext &= "[+] You Saved:".PadRight(35) & discountAmount.ToString("F2").PadLeft(15) & Environment.NewLine
        invoicetext &= borderLine & Environment.NewLine


        invoicetext &= "   *** THANK YOU FOR SHOPPING AT " & storename & "! ***" & Environment.NewLine
        invoicetext &= "                --- PLEASE VISIT AGAIN ---" & Environment.NewLine
        invoicetext &= borderLine
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim Font As New Font("Courier New", 10)
        e.Graphics.DrawString(invoicetext, Font, Brushes.Black, 50, 50)
    End Sub

    Private Sub POSForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dash As New Dashboard()
        dash.InitialiseColorDataGridView(Pos_Dgv)
        MakeButtonRound(Pos_btn_Scan)
        MakeButtonRound(Pos_btn_Remove)
        MakeButtonRound(Pos_btn_Checkout)
        MakeButtonRound(Pos_btn_PrintRecipt)
    End Sub

    Private Sub MakeButtonRound(ByVal btn As Button)
        Dim path As New Drawing2D.GraphicsPath()
        path.AddArc(0, 0, 30, 30, 180, 90)
        path.AddArc(btn.Width - 30, 0, 30, 30, 270, 90)
        path.AddArc(btn.Width - 30, btn.Height - 30, 30, 30, 0, 90)
        path.AddArc(0, btn.Height - 30, 30, 30, 90, 90)
        path.CloseFigure()
        btn.Region = New Region(path)
    End Sub

    ' New Automatic Code:
    ' Declare Timer
    Private WithEvents BarcodeCheckTimer As New Timer()

    Public Sub New()
        ' Call the custom function for initialization
        InitializeForm()
    End Sub

    ' Custom function for initializing components and timer
    Private Sub InitializeForm()
        ' This ensures that the designer-generated components are initialized
        InitializeComponent()

        ' Initialize the Timer
        BarcodeCheckTimer = New Timer()
        BarcodeCheckTimer.Interval = 700 ' Delay before checking barcode
        BarcodeCheckTimer.Enabled = False

    End Sub

    ' Restart Timer when barcode textbox changes
    Private Sub Pos_Textbox_Barcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pos_Textbox_Barcode.TextChanged
        BarcodeCheckTimer.Stop()
        BarcodeCheckTimer.Start()
    End Sub

    ' When Timer ticks, check barcode
    Private Sub BarcodeCheckTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles BarcodeCheckTimer.Tick
        BarcodeCheckTimer.Stop() ' Stop timer to prevent repeated execution
        CheckBarcode() ' Call barcode validation
    End Sub

    ' Function to check barcode after delay
    Private Sub CheckBarcode()
        If conn.State = ConnectionState.Closed Then conn.Open()


        ' Check if barcode is entered
        If String.IsNullOrWhiteSpace(Pos_Textbox_Barcode.Text) Then
            MessageBox.Show("Please enter a barcode!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Fetch product details from database
        Dim query As String = "SELECT * FROM inventory WHERE Barcode=@barcode"
        Dim da As New OleDbDataAdapter(query, conn)
        da.SelectCommand.Parameters.AddWithValue("@barcode", Pos_Textbox_Barcode.Text)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim Productname As String = dt(0)("Pname").ToString()
            Dim AvailableStock As Integer = CInt(dt(0)("Quantity"))
            Dim Productprice As Double = CDbl(dt(0)("Price"))

            ' Default quantity to 1
            Dim ProductQuantity As Integer = 1
            Dim found As Boolean = False

            ' Check if product already exists in cart
            For Each row As DataGridViewRow In Pos_Dgv.Rows

                If row.Cells("Barcode").Value IsNot Nothing AndAlso row.Cells("Barcode").Value.ToString() = Pos_Textbox_Barcode.Text Then

                    Dim currentQty As Integer = CInt(row.Cells("Quantity").Value)
                    If Pos_Qty_NumericUpDown.Value <> 0 Then
                        newQty = currentQty + Pos_Qty_NumericUpDown.Value ' Increment quantity by quantity

                    Else
                        newQty = currentQty + 1 ' Increment quantity by 1
                    End If


                    ' Ensure new total quantity does not exceed stock
                    If newQty > AvailableStock Then
                        MessageBox.Show("Not enough stock! You can only add " & (AvailableStock - currentQty) & " more.", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    ' Update quantity and total price in DataGridView
                    row.Cells("Quantity").Value = newQty
                    row.Cells("TotalPrice").Value = CDbl(row.Cells("ProductPrice").Value) * newQty
                    found = True
                    Exit For
                End If
            Next

            ' If product is not already in cart, add it with quantity = 1
            If Not found Then
                Pos_Dgv.Rows.Add(Pos_Textbox_Barcode.Text, Productname, ProductQuantity, Productprice, Productprice * ProductQuantity)
            End If

            ' Recalculate total after update
            CalculateTotal()

        Else
            MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


        Pos_Textbox_Barcode.Clear()
        Pos_Textbox_Barcode.Focus()
        BarcodeCheckTimer.Stop()
        conn.Close()

    End Sub



End Class