Public Class Login

    Public Shared LoggedInUser As String
    Public Shared conn As New OleDb.OleDbConnection
    Public Shared cmd As OleDb.OleDbCommand
    Dim i, t As Integer
    Public Shared da As OleDb.OleDbDataAdapter
    Dim dt As DataTable
    Dim isPasswordVisible As Boolean = False

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.AliceBlue
        Me.Text = "Login - Inventory System"

        Me.Invalidate()
        Me.Refresh()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Inventory.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sql As String = "Select * from auth"
        da = New OleDb.OleDbDataAdapter(cmd)
        cmd = New OleDb.OleDbCommand
        dt = New DataTable
        Passbox.PasswordChar = "*"
        btnToggle.Checked = True
        conn.Close()
    End Sub



    Private Sub Loginbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Loginbtn.Click
        Dim pass As String
        Dim user As String
        If Userbox.Text = "" Or Userbox.Text = "UserName" Then
            MsgBox("Please enter a valid Name")
            Exit Sub
        End If
        If Passbox.Text = "" Or Passbox.Text = "Password" Then
            MsgBox("Please enter a valid Password")
            Passbox.Focus()
            Exit Sub
        End If
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sql As String = "select Username,Password from auth where Username = ?;"
        cmd.Connection = conn
        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@username", Userbox.Text)

        dt.Clear()
        da.SelectCommand = cmd
        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            MsgBox("No Record Found")
        Else
            LoggedInUser = dt.Rows(0).Item(0).ToString()
            user = dt.Rows(0).Item(0).ToString()
            pass = dt.Rows(0).Item(1).ToString()

            If pass = Passbox.Text Then
                Dim dashboard As New Dashboard()
                dashboard.Icon = Me.Icon
                dashboard.Show()
                Me.Hide()
            Else
                MsgBox("Incorrect Password")
            End If
        End If
        conn.Close()
    End Sub
  
    Private Sub btnToggle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToggle.CheckedChanged
        If isPasswordVisible Then
            Passbox.UseSystemPasswordChar = True
        Else
            Passbox.UseSystemPasswordChar = False
        End If
        isPasswordVisible = Not isPasswordVisible
    End Sub
    Private Sub ForgotPassLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForgotPassLabel.Click
        Dim forgotpass As New Forgot_Password()
        forgotpass.Show()
        Me.Hide()
    End Sub
    Private Sub Signup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Signup.Click
        Dim signup As New Sign_up()
        Signup.Show()
        Me.Hide()
    End Sub
End Class
