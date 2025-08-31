Imports System.Data.OleDb
Imports ZXing
Imports System.Drawing

Public Class AddProduct
   Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Inventory.accdb;")

    Private Sub btn_AddProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddProduct.Click
        If txtProductName.Text = "" Or txtBarcode.Text = "" Or txtQuantity.Text = "" Or txtPrice.Text = "" Or cmbCategory.SelectedIndex = -1 Then
            MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim cmd As New OleDbCommand("INSERT INTO inventory (Pid, PName, Category, Quantity, Price, [DateTime], Barcode) VALUES (@id, @name, @category, @quantity, @price, @date, @barcode)", conn)
        cmd.Parameters.AddWithValue("@id", CInt(PidTextbox.Text)) ' Ensure Pid is Number
        cmd.Parameters.AddWithValue("@name", txtProductName.Text.ToUpper())
        cmd.Parameters.AddWithValue("@category", cmbCategory.Text.ToUpper())
        cmd.Parameters.AddWithValue("@quantity", CInt(txtQuantity.Text)) ' Ensure Quantity is Number
        cmd.Parameters.AddWithValue("@price", CDbl(txtPrice.Text)) ' Ensure Price is Number
        cmd.Parameters.AddWithValue("@date", Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss"))
        ' Ensure DateTime is Date/Time
        cmd.Parameters.AddWithValue("@barcode", txtBarcode.Text.ToUpper())
        cmd.ExecuteNonQuery()
        MessageBox.Show("Product Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        PidTextbox.Clear()
        txtProductName.Clear()
        txtBarcode.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        cmbCategory.SelectedIndex = -1
        txtProductName.Focus()

    End Sub

    'Barcode Generation Code
    Private Sub txtBarcode_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtBarcode.TextChanged
        GenerateBarcode(txtBarcode.Text)
    End Sub
    Private Sub GenerateBarcode(ByVal data As String)
        If String.IsNullOrWhiteSpace(data) Then
            BarcodePictureBox.Image = Nothing
            Return
        End If


        ' Create Barcode Writer instance
        Dim writer As New BarcodeWriter()
        writer.Format = BarcodeFormat.CODE_128  ' Choose barcode format
        writer.Options = New ZXing.Common.EncodingOptions With {
            .Height = 80,
            .Width = 412
        }

        ' Generate barcode image
        Dim result As Bitmap = writer.Write(data)
        BarcodePictureBox.Image = result ' Set image in PictureBox
      
    End Sub

    Private Sub LoadCategories()

        conn.Open()
        Dim dt As New DataTable()
        Dim da As New OleDbDataAdapter("SELECT CategoryName FROM Category", conn)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            cmbCategory.DataSource = dt
            cmbCategory.DisplayMember = "CategoryName"
            cmbCategory.SelectedIndex = -1
        Else
            MessageBox.Show("No categories found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        
    End Sub

    Private Sub AddProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCategories()
        txtProductName.Clear()
        txtBarcode.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        cmbCategory.SelectedIndex = -1
        txtProductName.Focus()
        MakeButtonRounded(btn_AddProduct)
        MakeButtonRounded(btn_ClearProduct)
    End Sub

    Private Sub btn_ClearProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ClearProduct.Click
        txtProductName.Clear()
        txtBarcode.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        cmbCategory.SelectedIndex = -1
        txtProductName.Focus()
    End Sub

    Public Sub MakeButtonRounded(ByVal btn As Button)
        Dim path As New Drawing2D.GraphicsPath()
        path.AddArc(0, 0, 30, 30, 180, 90)
        path.AddArc(btn.Width - 30, 0, 30, 30, 270, 90)
        path.AddArc(btn.Width - 30, btn.Height - 30, 30, 30, 0, 90)
        path.AddArc(0, btn.Height - 30, 30, 30, 90, 90)
        path.CloseFigure()
        btn.Region = New Region(path)
    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        ' Allow only digits and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Suppress the key
            MsgBox("Only numeric values are allowed.", MsgBoxStyle.Exclamation, "Invalid Input")
        End If
    End Sub

    Private Sub PidTextbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PidTextbox.KeyPress
        ' Allow only digits and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Suppress the key
            MsgBox("Only numeric values are allowed.", MsgBoxStyle.Exclamation, "Invalid Input")
        End If
    End Sub
   


    Private Sub txtPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress
        ' Allow only digits and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Suppress the key
            MsgBox("Only numeric values are allowed.", MsgBoxStyle.Exclamation, "Invalid Input")
        End If
    End Sub

 
End Class