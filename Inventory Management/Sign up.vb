Public Class Sign_up
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim isPasswordVisible As Boolean = False
    Private Sub Sign_up_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Inventory.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        ConfirmPassTextbox.PasswordChar = "*"
        ConfirmPassCheckBox.Checked = True
        SignInLabel.Visible = False
        conn.Close()
    End Sub
    
    Private Sub SignupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignupBtn.Click
        If String.IsNullOrWhiteSpace(UsernameTextBox.Text) OrElse
       String.IsNullOrWhiteSpace(PassTextBox.Text) OrElse
       String.IsNullOrWhiteSpace(ConfirmPassTextbox.Text) OrElse
       SQComboBox.SelectedItem Is Nothing OrElse
       String.IsNullOrWhiteSpace(SecurityAnsTextBox.Text) Then

            MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If PassTextBox.Text <> ConfirmPassTextbox.Text Then
            MessageBox.Show("Both Passwords should be same! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        'Checking the username is already existed in the database or not 
        Dim sql As String = "SELECT * FROM auth WHERE Username = @Username"
        cmd.Connection = conn
        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@Username", UsernameTextBox.Text)

        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            MessageBox.Show("Username already exists! Choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Inserting the new user in the database
        sql = "INSERT INTO auth (Username, [Password], SecurityQue, SecurityAns) VALUES (@Username, @Password, @SecurityQue, @SecurityAns)"
        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@Username", UsernameTextBox.Text)
        cmd.Parameters.AddWithValue("@Password", PassTextBox.Text)
        cmd.Parameters.AddWithValue("@SecurityQue", SQComboBox.SelectedItem.ToString())
        cmd.Parameters.AddWithValue("@SecurityAns", SecurityAnsTextBox.Text)

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

        If rowsAffected > 0 Then
            MessageBox.Show("Signup Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SignInLabel.Visible = True

            'Clearing Fields After Successful Signup
            UsernameTextBox.Clear()
            PassTextBox.Clear()
            ConfirmPassTextbox.Clear()
            SQComboBox.SelectedIndex = -1
            SecurityAnsTextBox.Clear()
        Else
            MessageBox.Show("Signup Failed! Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

    End Sub

    Private Sub ConfirmPassCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmPassCheckBox.CheckedChanged
        If isPasswordVisible Then
            ConfirmPassTextbox.UseSystemPasswordChar = True
        Else
            ConfirmPassTextbox.UseSystemPasswordChar = False
        End If
        isPasswordVisible = Not isPasswordVisible
    End Sub

    Private Sub SignInLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignInLabel.Click
        Dim SignIn As New Login()
        SignIn.Show()
        Me.Hide()
    End Sub

   
    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back.Click
        Dim login As New Login
        login.Show()
        Me.Hide()
    End Sub
End Class