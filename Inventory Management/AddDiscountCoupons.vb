Public Class AddDiscountCoupons
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim i, t As Integer

    Private Sub AddDiscountCoupons_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Inventory.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim getDiscounts As String = "SELECT * FROM DiscountCoupons"
        cmd = New OleDb.OleDbCommand(getDiscounts, conn)
        da = New OleDb.OleDbDataAdapter(cmd)
        da.Fill(dt)
        CouponsDGV.DataSource = dt

        Dim dash As New Dashboard()
        dash.InitialiseColorDataGridView(CouponsDGV)

        conn.Close()
    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        Dim sql As String = "insert into DiscountCoupons values('" & AddCouponTextBox.Text & "'," & CInt(DiscountValueTextBox.Text) & ")"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd = New OleDb.OleDbCommand(sql, conn)
        t = cmd.ExecuteNonQuery()
        MsgBox("Record Saved")
        AddCouponTextBox.Clear()
        DiscountValueTextBox.Clear()

        'Update DataGridView
        dt.Clear()
        CouponsDGV.DataSource = Nothing
        CouponsDGV.Rows.Clear()
        CouponsDGV.Columns.Clear()
        Dim getDiscounts As String = "SELECT * FROM DiscountCoupons"
        cmd = New OleDb.OleDbCommand(getDiscounts, conn)
        da = New OleDb.OleDbDataAdapter(cmd)
        da.Fill(dt)
        CouponsDGV.DataSource = dt

    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        Dim sql As String = "delete from DiscountCoupons where DiscountCodes ='" & AddCouponTextBox.Text & "';"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd = New OleDb.OleDbCommand(sql, conn)
        t = cmd.ExecuteNonQuery()
        MsgBox("Record Deleted")
        AddCouponTextBox.Clear()
        DiscountValueTextBox.Clear()

        'Update DataGridView
        dt.Clear()
        CouponsDGV.DataSource = Nothing
        CouponsDGV.Rows.Clear()
        CouponsDGV.Columns.Clear()
        Dim getDiscounts As String = "SELECT * FROM DiscountCoupons"
        cmd = New OleDb.OleDbCommand(getDiscounts, conn)
        da = New OleDb.OleDbDataAdapter(cmd)
        da.Fill(dt)
        CouponsDGV.DataSource = dt
    End Sub

    Private Sub DiscountValueTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DiscountValueTextBox.KeyPress
        ' Allow only digits and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Suppress the key
            MsgBox("Only numeric values are allowed.", MsgBoxStyle.Exclamation, "Invalid Input")
        End If
    End Sub

End Class