Imports System.Data.OleDb
Public Class category
    
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Inventory.accdb")

    Private Sub btn_ClearCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ClearCategory.Click
        category_txtbox.Clear()
    End Sub
    Private Sub btn_AddCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddCategory.Click
        If category_txtbox.Text = "" Then
            MsgBox("Please Enter a Categoryname.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        
            conn.Open()
            Dim cmd As New OleDbCommand("INSERT INTO Category (CategoryName) VALUES (@name)", conn)
            cmd.Parameters.AddWithValue("@name", category_txtbox.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Added Successfully!", MsgBoxStyle.Information)
            category_txtbox.Clear()
            conn.Close()
            LoadCategories()
        conn.Close()
    End Sub



    Private Sub category_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCategories()
        Dim addProduct As New AddProduct()
        addProduct.MakeButtonRounded(btn_AddCategory)
        addProduct.MakeButtonRounded(btn_delcategory)
        addProduct.MakeButtonRounded(btn_ClearCategory)
    End Sub
    Private Sub LoadCategories()
        Try
            conn.Open()
            Dim da As New OleDbDataAdapter("SELECT * FROM Category", conn)
            Dim dt As New DataTable
            da.Fill(dt)
            category_Dgv.DataSource = dt
            conn.Close()


        Catch ex As Exception
            MsgBox("Error loading categories: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
        Dim dash As New Dashboard()
        dash.InitialiseColorDataGridView(category_Dgv)
    End Sub

   
    Private Sub btn_delcategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delcategory.Click
        If category_txtbox.Text = "" Then
            MessageBox.Show("Please Enter the Category Name to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to delete this categoty?", "confirm Delete",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Exit Sub
        End If
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("DELETE FROM Category WHERE CategoryName=@name", conn)
            cmd.Parameters.AddWithValue("@name", category_txtbox.Text)

            Dim rowaffected = cmd.ExecuteNonQuery()
            If rowaffected > 0 Then
                MessageBox.Show("Category Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                category_txtbox.Clear()
            Else
                MessageBox.Show("Category not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
            conn.Close()
            LoadCategories()

   
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()

        End Try
    End Sub

End Class