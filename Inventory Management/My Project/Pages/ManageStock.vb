Imports System.Data.OleDb
Public Class ManageStock
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Shivam_Jaiya\Inventory_Management_System\Inventory.accdb")
    Private Sub ManageStock_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Set default states
        Ms_btn_Update.Enabled = False
        Ms_btn_Delete.Enabled = False
        Ms_btn_Search.Enabled = True

        Ms_Quantity_txt.Enabled = False
        Ms_Price_txt.Enabled = False
        Ms_Date_dtp.Enabled = False


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
        Ms_btn_Search.Enabled = False
        Ms_btn_Update.Enabled = True
        Ms_btn_Delete.Enabled = False

        Ms_Quantity_txt.Enabled = True
        Ms_Price_txt.Enabled = True
        Ms_Date_dtp.Enabled = True
    End Sub

    Private Sub RadioDelete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioDelete.CheckedChanged, RadioUpdate.CheckedChanged
        Ms_btn_Search.Enabled = False
        Ms_btn_Update.Enabled = False
        Ms_btn_Delete.Enabled = True

        Ms_Quantity_txt.Enabled = False
        Ms_Price_txt.Enabled = False
        Ms_Date_dtp.Enabled = False
    End Sub

    Private Sub Ms_btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ms_btn_Search.Click
        Dim query As String = "SELECT * FROM Product WHERE Pname=@name OR Barcode=@barcode"
        Dim cmd As New OleDb.OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("@name", Ms_Pname_txt.Text.Trim().ToUpper())
        cmd.Parameters.AddWithValue("@barcode", Ms_Barcode_txt.Text.Trim().ToUpper())


        Try
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
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

    End Sub

 
    Private Sub Ms_btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ms_btn_Update.Click
        Dim query As String = "UPDATE ProductTable SET Quantity=@qty, Price=@price, DateTime=@date WHERE Pname=@name OR Barcode=@barcode"
        Dim cmd As New OleDb.OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("@qty", Ms_Quantity_txt.Text)
        cmd.Parameters.AddWithValue("@price", Ms_Price_txt.Text)
        cmd.Parameters.AddWithValue("@date", Ms_Date_dtp.Value)
        cmd.Parameters.AddWithValue("@name", Ms_Pname_txt.Text.ToUpper())
        cmd.Parameters.AddWithValue("@barcode", Ms_Barcode_txt.Text)

        Try
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
                cmd.Parameters.AddWithValue("@date", Ms_Date_dtp.Value.ToString("MM/dd/yyyy HH:mm:ss"))

            Else
                MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
End Class