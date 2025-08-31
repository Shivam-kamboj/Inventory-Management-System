Public Class Forgot_Password
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim user As String
    Dim isPasswordVisible As Boolean = False
    Dim currentPassword As String
    Private Sub Forgot_Password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Inventory.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        ConfirmPassTextbox.PasswordChar = "*"
        ConfirmPassCheckBox.Checked = True
        LoginLinkLabel.Visible = False
    End Sub

    Private Sub QuestionVerifyBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuestionVerifyBtn.Click
        Dim SecurityAns As String
        If Len(QuestionTextBox.Text) = 0 Then
            MsgBox("Please enter a valid answer")
            QuestionTextBox.Focus()
            Exit Sub
        End If
        Dim sql As String = "SELECT * FROM auth WHERE Username = @Username"
        cmd.Connection = conn
        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@Username", user)

        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            MsgBox("No Record Found")
        End If
        SecurityAns = dt.Rows(0).Item(3).ToString()
        currentPassword = dt.Rows(0).Item(1).ToString()
        If SecurityAns = QuestionTextBox.Text Then
            QuestionVerifyBtn.Font = New Font(QuestionVerifyBtn.Font.FontFamily, 9, FontStyle.Regular)
            QuestionVerifyBtn.ForeColor = Color.Green
            QuestionVerifyBtn.Text = "✅"
        Else
            MsgBox("Wrong answer")
        End If
        conn.Close()
    End Sub
    Private Sub UserVerify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserVerify.Click
        If Len(UsernameTextBox.Text) = 0 Then
            MsgBox("Please enter a valid answer")
            UsernameTextBox.Focus()
            Exit Sub
        End If
        Dim sql As String = "SELECT * FROM auth WHERE Username = @Username"
        cmd.Connection = conn
        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@Username", UsernameTextBox.Text)

        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MsgBox("No Record Found")
        Else
            user = dt.Rows(0).Item(0).ToString()
            QuestionLabel.Text = dt.Rows(0).Item(2).ToString()
            UserVerify.Font = New Font(UserVerify.Font.FontFamily, 9, FontStyle.Regular)
            UserVerify.ForeColor = Color.Green
            UserVerify.Text = "✅"
        End If
        conn.Close()
    End Sub

    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged
        UserVerify.Font = New Font(UserVerify.Font.FontFamily, 8, FontStyle.Regular)
        UserVerify.ForeColor = Color.Black
        UserVerify.Text = "Verify"
    End Sub

    Private Sub ConfirmPassCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmPassCheckBox.CheckedChanged
        If isPasswordVisible Then
            ConfirmPassTextbox.UseSystemPasswordChar = True
        Else
            ConfirmPassTextbox.UseSystemPasswordChar = False
        End If
        isPasswordVisible = Not isPasswordVisible
    End Sub

    Private Sub ChangePassbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePassbtn.Click
        If currentPassword = ConfirmPassTextbox.Text Then
            MessageBox.Show("New password cannot be the same as the current password.Please choose a different password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf QuestionVerifyBtn.Text = "✅" And NewPassTextBox.Text = ConfirmPassTextbox.Text Then
            Dim sql As String = "update auth set [Password]='" & ConfirmPassTextbox.Text & "' where Username ='" & user & "';"
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New OleDb.OleDbCommand(sql, conn)
            Dim t As Integer = cmd.ExecuteNonQuery()
            If t > 0 Then
                MessageBox.Show("Password Changed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoginLinkLabel.Visible = True
                conn.Close()
            Else
                MsgBox("Failed to update password. User not found!", MsgBoxStyle.Exclamation, "Error")
            End If
     
            'Reseting UI to default
            UsernameTextBox.Clear()
            QuestionTextBox.Clear()
            NewPassTextBox.Clear()
            ConfirmPassTextbox.Clear()
            ConfirmPassCheckBox.Checked = True
            UserVerify.Font = New Font(UserVerify.Font.FontFamily, 8, FontStyle.Regular)
            UserVerify.ForeColor = Color.Black
            UserVerify.Text = "Verify"
            QuestionVerifyBtn.Font = New Font(QuestionVerifyBtn.Font.FontFamily, 8, FontStyle.Regular)
            QuestionVerifyBtn.ForeColor = Color.Black
            QuestionVerifyBtn.Text = "Verify"
        Else
            If NewPassTextBox.Text <> ConfirmPassCheckBox.Text Then
                MessageBox.Show("Both passwords must be the same. Please check and try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If QuestionVerifyBtn.Text <> "✅" Then
                MessageBox.Show("Please verify the security answer first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
        conn.Close()
    End Sub

    Private Sub QuestionTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuestionTextBox.TextChanged
        QuestionVerifyBtn.Font = New Font(QuestionVerifyBtn.Font.FontFamily, 8, FontStyle.Regular)
        QuestionVerifyBtn.ForeColor = Color.Black
        QuestionVerifyBtn.Text = "Verify"
    End Sub

    Private Sub LoginLinkLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginLinkLabel.Click
        Dim Login As New Login()
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back.Click
        Dim login As New Login
        login.Show()
        Me.Hide()
    End Sub
End Class