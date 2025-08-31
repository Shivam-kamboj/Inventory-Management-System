<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forgot_Password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Forgot_Password))
        Me.ConfirmPass_Label = New System.Windows.Forms.Label()
        Me.NewPass_Label = New System.Windows.Forms.Label()
        Me.ConfirmPassCheckBox = New System.Windows.Forms.CheckBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.NewPassTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmPassTextbox = New System.Windows.Forms.TextBox()
        Me.ChangePassbtn = New System.Windows.Forms.Button()
        Me.QuestionTextBox = New System.Windows.Forms.TextBox()
        Me.QuestionLabel = New System.Windows.Forms.Label()
        Me.QuestionVerifyBtn = New System.Windows.Forms.Button()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.UserVerify = New System.Windows.Forms.Button()
        Me.LoginLinkLabel = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.PictureBox()
        CType(Me.Back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConfirmPass_Label
        '
        Me.ConfirmPass_Label.AutoSize = True
        Me.ConfirmPass_Label.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPass_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.ConfirmPass_Label.Location = New System.Drawing.Point(200, 492)
        Me.ConfirmPass_Label.Name = "ConfirmPass_Label"
        Me.ConfirmPass_Label.Size = New System.Drawing.Size(168, 28)
        Me.ConfirmPass_Label.TabIndex = 13
        Me.ConfirmPass_Label.Text = "Confirm Password"
        '
        'NewPass_Label
        '
        Me.NewPass_Label.AutoSize = True
        Me.NewPass_Label.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPass_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.NewPass_Label.Location = New System.Drawing.Point(200, 378)
        Me.NewPass_Label.Name = "NewPass_Label"
        Me.NewPass_Label.Size = New System.Drawing.Size(137, 28)
        Me.NewPass_Label.TabIndex = 14
        Me.NewPass_Label.Text = "New Password"
        '
        'ConfirmPassCheckBox
        '
        Me.ConfirmPassCheckBox.AutoSize = True
        Me.ConfirmPassCheckBox.Location = New System.Drawing.Point(484, 536)
        Me.ConfirmPassCheckBox.Name = "ConfirmPassCheckBox"
        Me.ConfirmPassCheckBox.Size = New System.Drawing.Size(22, 21)
        Me.ConfirmPassCheckBox.TabIndex = 12
        Me.ConfirmPassCheckBox.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Open Sans Medium", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.TitleLabel.Location = New System.Drawing.Point(220, 60)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(300, 46)
        Me.TitleLabel.TabIndex = 8
        Me.TitleLabel.Tag = " "
        Me.TitleLabel.Text = "Forgot Password?"
        '
        'NewPassTextBox
        '
        Me.NewPassTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.NewPassTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPassTextBox.Location = New System.Drawing.Point(204, 411)
        Me.NewPassTextBox.Multiline = True
        Me.NewPassTextBox.Name = "NewPassTextBox"
        Me.NewPassTextBox.Size = New System.Drawing.Size(316, 45)
        Me.NewPassTextBox.TabIndex = 9
        '
        'ConfirmPassTextbox
        '
        Me.ConfirmPassTextbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ConfirmPassTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPassTextbox.Location = New System.Drawing.Point(199, 525)
        Me.ConfirmPassTextbox.Multiline = True
        Me.ConfirmPassTextbox.Name = "ConfirmPassTextbox"
        Me.ConfirmPassTextbox.Size = New System.Drawing.Size(316, 45)
        Me.ConfirmPassTextbox.TabIndex = 10
        Me.ConfirmPassTextbox.UseSystemPasswordChar = True
        '
        'ChangePassbtn
        '
        Me.ChangePassbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ChangePassbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ChangePassbtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangePassbtn.ForeColor = System.Drawing.Color.White
        Me.ChangePassbtn.Location = New System.Drawing.Point(261, 620)
        Me.ChangePassbtn.Name = "ChangePassbtn"
        Me.ChangePassbtn.Size = New System.Drawing.Size(221, 77)
        Me.ChangePassbtn.TabIndex = 11
        Me.ChangePassbtn.Text = "Reset Password"
        Me.ChangePassbtn.UseVisualStyleBackColor = False
        '
        'QuestionTextBox
        '
        Me.QuestionTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.QuestionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestionTextBox.Location = New System.Drawing.Point(204, 301)
        Me.QuestionTextBox.Multiline = True
        Me.QuestionTextBox.Name = "QuestionTextBox"
        Me.QuestionTextBox.Size = New System.Drawing.Size(316, 45)
        Me.QuestionTextBox.TabIndex = 9
        '
        'QuestionLabel
        '
        Me.QuestionLabel.AutoSize = True
        Me.QuestionLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.QuestionLabel.Location = New System.Drawing.Point(200, 268)
        Me.QuestionLabel.Name = "QuestionLabel"
        Me.QuestionLabel.Size = New System.Drawing.Size(211, 28)
        Me.QuestionLabel.TabIndex = 14
        Me.QuestionLabel.Text = "What is you pet name?"
        '
        'QuestionVerifyBtn
        '
        Me.QuestionVerifyBtn.BackColor = System.Drawing.SystemColors.Control
        Me.QuestionVerifyBtn.Location = New System.Drawing.Point(558, 301)
        Me.QuestionVerifyBtn.Name = "QuestionVerifyBtn"
        Me.QuestionVerifyBtn.Size = New System.Drawing.Size(96, 45)
        Me.QuestionVerifyBtn.TabIndex = 15
        Me.QuestionVerifyBtn.Text = "Verify"
        Me.QuestionVerifyBtn.UseVisualStyleBackColor = False
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(204, 198)
        Me.UsernameTextBox.Multiline = True
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(316, 45)
        Me.UsernameTextBox.TabIndex = 9
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.UsernameLabel.Location = New System.Drawing.Point(200, 165)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(99, 28)
        Me.UsernameLabel.TabIndex = 14
        Me.UsernameLabel.Text = "Username"
        '
        'UserVerify
        '
        Me.UserVerify.BackColor = System.Drawing.SystemColors.Control
        Me.UserVerify.Location = New System.Drawing.Point(558, 198)
        Me.UserVerify.Name = "UserVerify"
        Me.UserVerify.Size = New System.Drawing.Size(96, 45)
        Me.UserVerify.TabIndex = 15
        Me.UserVerify.Text = "Verify"
        Me.UserVerify.UseVisualStyleBackColor = False
        '
        'LoginLinkLabel
        '
        Me.LoginLinkLabel.AutoSize = True
        Me.LoginLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginLinkLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginLinkLabel.ForeColor = System.Drawing.Color.Blue
        Me.LoginLinkLabel.Location = New System.Drawing.Point(326, 736)
        Me.LoginLinkLabel.Name = "LoginLinkLabel"
        Me.LoginLinkLabel.Size = New System.Drawing.Size(96, 38)
        Me.LoginLinkLabel.TabIndex = 16
        Me.LoginLinkLabel.Text = "SignIn"
        '
        'Back
        '
        Me.Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Back.Image = CType(resources.GetObject("Back.Image"), System.Drawing.Image)
        Me.Back.Location = New System.Drawing.Point(39, 31)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(40, 39)
        Me.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Back.TabIndex = 30
        Me.Back.TabStop = False
        '
        'Forgot_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(799, 846)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.LoginLinkLabel)
        Me.Controls.Add(Me.UserVerify)
        Me.Controls.Add(Me.QuestionVerifyBtn)
        Me.Controls.Add(Me.ConfirmPass_Label)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.QuestionLabel)
        Me.Controls.Add(Me.NewPass_Label)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.ConfirmPassCheckBox)
        Me.Controls.Add(Me.QuestionTextBox)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.NewPassTextBox)
        Me.Controls.Add(Me.ConfirmPassTextbox)
        Me.Controls.Add(Me.ChangePassbtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Forgot_Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forgot Password"
        CType(Me.Back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConfirmPass_Label As System.Windows.Forms.Label
    Friend WithEvents NewPass_Label As System.Windows.Forms.Label
    Friend WithEvents ConfirmPassCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents NewPassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmPassTextbox As System.Windows.Forms.TextBox
    Friend WithEvents ChangePassbtn As System.Windows.Forms.Button
    Friend WithEvents QuestionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuestionLabel As System.Windows.Forms.Label
    Friend WithEvents QuestionVerifyBtn As System.Windows.Forms.Button
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents UserVerify As System.Windows.Forms.Button
    Friend WithEvents LoginLinkLabel As System.Windows.Forms.Label
    Friend WithEvents Back As System.Windows.Forms.PictureBox
End Class
