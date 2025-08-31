Imports System.Data.OleDb


Public Class AddProduct
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Shivam_Jaiya\Inventory_Management_System\Inventory.accdb")



    Private Sub btn_AddProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddProduct.Click
        If txtProductName.Text = "" Or txtBarcode.Text = "" Or txtQuantity.Text = "" Or txtPrice.Text = "" Or cmbCategory.SelectedIndex = -1 Then
            MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try

            conn.Open()
            Dim cmd As New OleDbCommand("INSERT INTO Product (PName, Barcode, Category, Price, Quantity, [DateTime]) VALUES (@name, @barcode, @category, @price, @quantity, @date)", conn)
            cmd.Parameters.AddWithValue("@name", txtProductName.Text.ToUpper())
            cmd.Parameters.AddWithValue("@barcode", txtBarcode.Text.ToUpper())
            cmd.Parameters.AddWithValue("@category", cmbCategory.Text.ToUpper())
            cmd.Parameters.AddWithValue("@price", txtPrice.Text)
            cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text)
            cmd.Parameters.AddWithValue("@date", Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss"))
            cmd.ExecuteNonQuery()
            MessageBox.Show("Product Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtProductName.Clear()
            txtBarcode.Clear()
            txtPrice.Clear()
            txtQuantity.Clear()
            cmbCategory.SelectedIndex = -1
            txtProductName.Focus()


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()

        End Try


    End Sub
    Private Sub LoadCategories()
        Try
            conn.Open()
            Dim dt As New DataTable()
            Dim da As New OleDbDataAdapter("SELECT CategoryName FROM Category", conn)
            da.Fill(dt)
            

            cmbCategory.DataSource = dt


            cmbCategory.DisplayMember = "CategoryName"
            cmbCategory.SelectedIndex = -1


        Catch ex As Exception
            MessageBox.Show("Error loading categories:" & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub AddProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadCategories()
        txtProductName.Clear()
        txtBarcode.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        cmbCategory.SelectedIndex = -1
        txtProductName.Focus()

    End Sub

    Private Sub btn_ClearProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ClearProduct.Click
        txtProductName.Clear()
        txtBarcode.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        cmbCategory.SelectedIndex = -1
        txtProductName.Focus()
    End Sub
End Class