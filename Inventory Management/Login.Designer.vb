<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Loginbtn = New System.Windows.Forms.Button()
        Me.Passbox = New System.Windows.Forms.TextBox()
        Me.Userbox = New System.Windows.Forms.TextBox()
        Me.Signup_Label = New System.Windows.Forms.Label()
        Me.btnToggle = New System.Windows.Forms.CheckBox()
        Me.Username_Label = New System.Windows.Forms.Label()
        Me.Password_Label = New System.Windows.Forms.Label()
        Me.ForgotPassLabel = New System.Windows.Forms.Label()
        Me.SignupLabel = New System.Windows.Forms.Label()
        Me.Signup = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Loginbtn
        '
        Me.Loginbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Loginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Loginbtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loginbtn.ForeColor = System.Drawing.Color.White
        Me.Loginbtn.Location = New System.Drawing.Point(282, 524)
        Me.Loginbtn.Name = "Loginbtn"
        Me.Loginbtn.Size = New System.Drawing.Size(203, 60)
        Me.Loginbtn.TabIndex = 4
        Me.Loginbtn.Text = "Login"
        Me.Loginbtn.UseVisualStyleBackColor = False
        '
        'Passbox
        '
        Me.Passbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Passbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passbox.Location = New System.Drawing.Point(212, 392)
        Me.Passbox.Multiline = True
        Me.Passbox.Name = "Passbox"
        Me.Passbox.Size = New System.Drawing.Size(316, 45)
        Me.Passbox.TabIndex = 3
        Me.Passbox.UseSystemPasswordChar = True
        '
        'Userbox
        '
        Me.Userbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Userbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Userbox.Location = New System.Drawing.Point(212, 257)
        Me.Userbox.Multiline = True
        Me.Userbox.Name = "Userbox"
        Me.Userbox.Size = New System.Drawing.Size(316, 45)
        Me.Userbox.TabIndex = 1
        '
        'Signup_Label
        '
        Me.Signup_Label.AutoSize = True
        Me.Signup_Label.Font = New System.Drawing.Font("Open Sans Medium", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Signup_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Signup_Label.Location = New System.Drawing.Point(274, 107)
        Me.Signup_Label.Name = "Signup_Label"
        Me.Signup_Label.Size = New System.Drawing.Size(213, 46)
        Me.Signup_Label.TabIndex = 0
        Me.Signup_Label.Text = "Login Here !"
        '
        'btnToggle
        '
        Me.btnToggle.AutoSize = True
        Me.btnToggle.Location = New System.Drawing.Point(497, 403)
        Me.btnToggle.Name = "btnToggle"
        Me.btnToggle.Size = New System.Drawing.Size(22, 21)
        Me.btnToggle.TabIndex = 5
        Me.btnToggle.UseVisualStyleBackColor = True
        '
        'Username_Label
        '
        Me.Username_Label.AutoSize = True
        Me.Username_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Username_Label.Location = New System.Drawing.Point(208, 224)
        Me.Username_Label.Name = "Username_Label"
        Me.Username_Label.Size = New System.Drawing.Size(114, 26)
        Me.Username_Label.TabIndex = 6
        Me.Username_Label.Text = "Username"
        '
        'Password_Label
        '
        Me.Password_Label.AutoSize = True
        Me.Password_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Password_Label.Location = New System.Drawing.Point(213, 359)
        Me.Password_Label.Name = "Password_Label"
        Me.Password_Label.Size = New System.Drawing.Size(105, 26)
        Me.Password_Label.TabIndex = 6
        Me.Password_Label.Text = "Password"
        '
        'ForgotPassLabel
        '
        Me.ForgotPassLabel.AutoSize = True
        Me.ForgotPassLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForgotPassLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForgotPassLabel.ForeColor = System.Drawing.Color.Blue
        Me.ForgotPassLabel.Location = New System.Drawing.Point(370, 450)
        Me.ForgotPassLabel.Name = "ForgotPassLabel"
        Me.ForgotPassLabel.Size = New System.Drawing.Size(158, 28)
        Me.ForgotPassLabel.TabIndex = 7
        Me.ForgotPassLabel.Text = "Forgot Password"
        '
        'SignupLabel
        '
        Me.SignupLabel.AutoSize = True
        Me.SignupLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SignupLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignupLabel.ForeColor = System.Drawing.Color.Black
        Me.SignupLabel.Location = New System.Drawing.Point(213, 614)
        Me.SignupLabel.Name = "SignupLabel"
        Me.SignupLabel.Size = New System.Drawing.Size(228, 28)
        Me.SignupLabel.TabIndex = 7
        Me.SignupLabel.Text = "Do not have an account?"
        '
        'Signup
        '
        Me.Signup.AutoSize = True
        Me.Signup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Signup.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Signup.ForeColor = System.Drawing.Color.Blue
        Me.Signup.Location = New System.Drawing.Point(450, 614)
        Me.Signup.Name = "Signup"
        Me.Signup.Size = New System.Drawing.Size(117, 28)
        Me.Signup.TabIndex = 7
        Me.Signup.Text = "Signup here"
        '
        'Login
        '
        Me.AcceptButton = Me.Loginbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(740, 719)
        Me.Controls.Add(Me.SignupLabel)
        Me.Controls.Add(Me.Signup)
        Me.Controls.Add(Me.ForgotPassLabel)
        Me.Controls.Add(Me.Password_Label)
        Me.Controls.Add(Me.Username_Label)
        Me.Controls.Add(Me.btnToggle)
        Me.Controls.Add(Me.Signup_Label)
        Me.Controls.Add(Me.Userbox)
        Me.Controls.Add(Me.Passbox)
        Me.Controls.Add(Me.Loginbtn)
        Me.ForeColor = System.Drawing.Color.Gray
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login - Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Loginbtn As System.Windows.Forms.Button
    Friend WithEvents Passbox As System.Windows.Forms.TextBox
    Friend WithEvents Userbox As System.Windows.Forms.TextBox
    Friend WithEvents Signup_Label As System.Windows.Forms.Label
    Friend WithEvents btnToggle As System.Windows.Forms.CheckBox
    Friend WithEvents Username_Label As System.Windows.Forms.Label
    Friend WithEvents Password_Label As System.Windows.Forms.Label
    Friend WithEvents ForgotPassLabel As System.Windows.Forms.Label
    Friend WithEvents SignupLabel As System.Windows.Forms.Label
    Friend WithEvents Signup As System.Windows.Forms.Label

End Class
