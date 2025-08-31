Imports System.Data.OleDb
Public Class ManageStock
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Inventory.accdb")
    Private Sub ManageStock_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Set default states

        Ms_btn_Update.Enabled = False
        Ms_btn_Delete.Enabled = False
        Ms_btn_Search.Enabled = True

        Ms_Quantity_txt.Enabled = False
        Ms_Price_txt.Enabled = False
        Ms_Date_dtp.Enabled = False
        Dim dash As New Dashboard()
        dash.InitialiseColorDataGridView(Ms_Dgv)
        Dim addProduct As New AddProduct()
        addProduct.MakeButtonRounded(Ms_btn_Search)
        addProduct.MakeButtonRounded(Ms_btn_Update)
        addProduct.MakeButtonRounded(Ms_btn_Delete)
    End Sub

    Private Sub RadioSearch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioSearch.CheckedChanged
        Ms_btn_Search.Enabled = True
        Ms_btn_Update.Enabled = False
        Ms_btn_Delete.Enabled = False

        Ms_Quantity_txt.Enabled = False
        Ms_Price_txt.Enabled = False
        Ms_Date_dtp.Enabled = False
    End Sub

    Private Sub RadioUpdate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioUpdate.CheckedChanged
        Ms_btn_Update.Enabled = True
        Ms_btn_Search.Enabled = False
        Ms_btn_Delete.Enabled = False

        Ms_Quantity_txt.Enabled = True
        Ms_Price_txt.Enabled = True
        Ms_Date_dtp.Enabled = True
    End Sub

    Private Sub RadioDelete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioDelete.CheckedChanged
        Ms_btn_Search.Enabled = False
        Ms_btn_Update.Enabled = False
        Ms_btn_Delete.Enabled = True

        Ms_Quantity_txt.Enabled = False
        Ms_Price_txt.Enabled = False
        Ms_Date_dtp.Enabled = False
    End Sub

    Private Sub Ms_btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ms_btn_Search.Click
        Dim query As String = "SELECT * FROM inventory WHERE Pname=@name OR Barcode=@barcode"
        Dim cmd As New OleDb.OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("@name", Ms_Pname_txt.Text.Trim().ToUpper())
        cmd.Parameters.AddWithValue("@barcode", Ms_Barcode_txt.Text.Trim().ToUpper())



        conn.Open()
        Dim dt As New DataTable()
        Dim adapter As New OleDb.OleDbDataAdapter(cmd)
        adapter.Fill(dt)
        Ms_Dgv.DataSource = dt  ' Display results in DataGridView

        If dt.Rows.Count > 0 Then
            ' Fill textboxes with first row of data
            Ms_Pname_txt.Text = dt.Rows(0)("Pname").ToString()
            Ms_Barcode_txt.Text = dt.Rows(0)("Barcode").ToString()
            Ms_Quantity_txt.Text = dt.Rows(0)("Quantity").ToString()
            Ms_Price_txt.Text = dt.Rows(0)("Price").ToString()
            Ms_Date_dtp.Value = Convert.ToDateTime(dt.Rows(0)("DateTime"))

        Else
            MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
       
        conn.Close()



    End Sub


    Private Sub Ms_btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ms_btn_Update.Click
        Dim query As String = "UPDATE inventory SET Quantity=@qty, Price=@price, [DateTime]=@date WHERE Pname=@name OR Barcode=@barcode"
        Dim cmd As New OleDb.OleDbCommand(query, conn)

        cmd.Parameters.AddWithValue("@qty", Ms_Quantity_txt.Text)
        cmd.Parameters.AddWithValue("@price", Ms_Price_txt.Text)
        cmd.Parameters.AddWithValue("@date", Ms_Date_dtp.Value)
        cmd.Parameters.AddWithValue("@name", Ms_Pname_txt.Text.ToUpper())
        cmd.Parameters.AddWithValue("@barcode", Ms_Barcode_txt.Text)


        conn.Open()
        Dim rowsAffected As Integer = cmd.ExecuteNonQuery() ' Execute update query

        If rowsAffected > 0 Then
            MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshDataGridView()
        Else
            MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

       
        conn.Close()

    End Sub
    Private Sub RefreshDataGridView()
        ' We are Closing the Connection again because when any row is update it calls this function and the connection doesn't closed   
        conn.Close()
        Dim query As String = "SELECT * FROM inventory where Pname = @pname or Barcode = @barcode"

        Dim cmd As New OleDb.OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("@pname", Ms_Pname_txt.Text)
        cmd.Parameters.AddWithValue("@barcode", Ms_Barcode_txt.Text)

        Dim adapter As New OleDb.OleDbDataAdapter(cmd)
        Dim dt As New DataTable()


        conn.Open()
        adapter.Fill(dt)
        Ms_Dgv.DataSource = dt
      
        conn.Close()

    End Sub
    Private Sub LoadInventory()
        ' We are Closing the Connection again because when any row is update it calls this function and the connection doesn't closed   
        conn.Close()
        Dim query As String = "SELECT * FROM inventory"

        Dim cmd As New OleDb.OleDbCommand(query, conn)
        Dim adapter As New OleDb.OleDbDataAdapter(cmd)
        Dim dt As New DataTable()


        conn.Open()
        adapter.Fill(dt)
        Ms_Dgv.DataSource = dt
        
        conn.Close()

    End Sub

    Private Sub Ms_btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ms_btn_Delete.Click
        Dim query As String = "DELETE FROM inventory WHERE Pname=@pname OR Barcode=@barcode"


        Using cmd As New OleDb.OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@pname", Ms_Pname_txt.Text.Trim().ToUpper())
            cmd.Parameters.AddWithValue("@barcode", Ms_Barcode_txt.Text.Trim().ToUpper())

            conn.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadInventory() ' Refresh DataGridView
            Else
                MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using

        conn.Close()

    End Sub

    Private Sub Ms_Price_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Ms_Price_txt.KeyPress
        ' Allow only digits and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Suppress the key
            MsgBox("Only numeric values are allowed.", MsgBoxStyle.Exclamation, "Invalid Input")
        End If
    End Sub

    Private Sub Ms_Quantity_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Ms_Quantity_txt.KeyPress
        ' Allow only digits and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Suppress the key
            MsgBox("Only numeric values are allowed.", MsgBoxStyle.Exclamation, "Invalid Input")
        End If
    End Sub

End Class