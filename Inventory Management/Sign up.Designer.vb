<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sign_up
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sign_up))
        Me.ConfirmPass_Label = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.QuestionLabel = New System.Windows.Forms.Label()
        Me.NewPass_Label = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmPassCheckBox = New System.Windows.Forms.CheckBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.PassTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmPassTextbox = New System.Windows.Forms.TextBox()
        Me.SignupBtn = New System.Windows.Forms.Button()
        Me.SignInLabel = New System.Windows.Forms.Label()
        Me.SQComboBox = New System.Windows.Forms.ComboBox()
        Me.SecurityAnsTextBox = New System.Windows.Forms.TextBox()
        Me.SecurityAnsLabel = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.PictureBox()
        CType(Me.Back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConfirmPass_Label
        '
        Me.ConfirmPass_Label.AutoSize = True
        Me.ConfirmPass_Label.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPass_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.ConfirmPass_Label.Location = New System.Drawing.Point(241, 626)
        Me.ConfirmPass_Label.Name = "ConfirmPass_Label"
        Me.ConfirmPass_Label.Size = New System.Drawing.Size(168, 28)
        Me.ConfirmPass_Label.TabIndex = 23
        Me.ConfirmPass_Label.Text = "Confirm Password"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.UsernameLabel.Location = New System.Drawing.Point(241, 210)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(99, 28)
        Me.UsernameLabel.TabIndex = 24
        Me.UsernameLabel.Text = "Username"
        '
        'QuestionLabel
        '
        Me.QuestionLabel.AutoSize = True
        Me.QuestionLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.QuestionLabel.Location = New System.Drawing.Point(241, 311)
        Me.QuestionLabel.Name = "QuestionLabel"
        Me.QuestionLabel.Size = New System.Drawing.Size(251, 28)
        Me.QuestionLabel.TabIndex = 26
        Me.QuestionLabel.Text = "Choose a Security Question"
        '
        'NewPass_Label
        '
        Me.NewPass_Label.AutoSize = True
        Me.NewPass_Label.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPass_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.NewPass_Label.Location = New System.Drawing.Point(241, 510)
        Me.NewPass_Label.Name = "NewPass_Label"
        Me.NewPass_Label.Size = New System.Drawing.Size(143, 28)
        Me.NewPass_Label.TabIndex = 25
        Me.NewPass_Label.Text = "Enter Password"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(245, 243)
        Me.UsernameTextBox.Multiline = True
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(316, 45)
        Me.UsernameTextBox.TabIndex = 19
        '
        'ConfirmPassCheckBox
        '
        Me.ConfirmPassCheckBox.AutoSize = True
        Me.ConfirmPassCheckBox.Location = New System.Drawing.Point(525, 670)
        Me.ConfirmPassCheckBox.Name = "ConfirmPassCheckBox"
        Me.ConfirmPassCheckBox.Size = New System.Drawing.Size(22, 21)
        Me.ConfirmPassCheckBox.TabIndex = 22
        Me.ConfirmPassCheckBox.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Open Sans Medium", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.TitleLabel.Location = New System.Drawing.Point(296, 85)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(227, 46)
        Me.TitleLabel.TabIndex = 16
        Me.TitleLabel.Tag = " "
        Me.TitleLabel.Text = "Signup Here!"
        '
        'PassTextBox
        '
        Me.PassTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PassTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassTextBox.Location = New System.Drawing.Point(245, 545)
        Me.PassTextBox.Multiline = True
        Me.PassTextBox.Name = "PassTextBox"
        Me.PassTextBox.Size = New System.Drawing.Size(316, 45)
        Me.PassTextBox.TabIndex = 18
        '
        'ConfirmPassTextbox
        '
        Me.ConfirmPassTextbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ConfirmPassTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPassTextbox.Location = New System.Drawing.Point(240, 659)
        Me.ConfirmPassTextbox.Multiline = True
        Me.ConfirmPassTextbox.Name = "ConfirmPassTextbox"
        Me.ConfirmPassTextbox.Size = New System.Drawing.Size(316, 45)
        Me.ConfirmPassTextbox.TabIndex = 20
        Me.ConfirmPassTextbox.UseSystemPasswordChar = True
        '
        'SignupBtn
        '
        Me.SignupBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.SignupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SignupBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignupBtn.ForeColor = System.Drawing.Color.White
        Me.SignupBtn.Location = New System.Drawing.Point(316, 747)
        Me.SignupBtn.Name = "SignupBtn"
        Me.SignupBtn.Size = New System.Drawing.Size(170, 71)
        Me.SignupBtn.TabIndex = 21
        Me.SignupBtn.Text = "Signup"
        Me.SignupBtn.UseVisualStyleBackColor = False
        '
        'SignInLabel
        '
        Me.SignInLabel.AutoSize = True
        Me.SignInLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SignInLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignInLabel.ForeColor = System.Drawing.Color.Blue
        Me.SignInLabel.Location = New System.Drawing.Point(366, 851)
        Me.SignInLabel.Name = "SignInLabel"
        Me.SignInLabel.Size = New System.Drawing.Size(70, 28)
        Me.SignInLabel.TabIndex = 27
        Me.SignInLabel.Text = "SignIn"
        '
        'SQComboBox
        '
        Me.SQComboBox.DropDownHeight = 150
        Me.SQComboBox.DropDownWidth = 400
        Me.SQComboBox.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SQComboBox.FormattingEnabled = True
        Me.SQComboBox.IntegralHeight = False
        Me.SQComboBox.Items.AddRange(New Object() {"What is your pet name?", "In which year did you start managing inventory?", "Which city is your main warehouse located in?", "Who is your first business partner?", "What is the name of your most trusted supplier?"})
        Me.SQComboBox.Location = New System.Drawing.Point(241, 342)
        Me.SQComboBox.Name = "SQComboBox"
        Me.SQComboBox.Size = New System.Drawing.Size(315, 46)
        Me.SQComboBox.TabIndex = 28
        '
        'SecurityAnsTextBox
        '
        Me.SecurityAnsTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.SecurityAnsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityAnsTextBox.Location = New System.Drawing.Point(245, 440)
        Me.SecurityAnsTextBox.Multiline = True
        Me.SecurityAnsTextBox.Name = "SecurityAnsTextBox"
        Me.SecurityAnsTextBox.Size = New System.Drawing.Size(316, 45)
        Me.SecurityAnsTextBox.TabIndex = 18
        '
        'SecurityAnsLabel
        '
        Me.SecurityAnsLabel.AutoSize = True
        Me.SecurityAnsLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityAnsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.SecurityAnsLabel.Location = New System.Drawing.Point(241, 407)
        Me.SecurityAnsLabel.Name = "SecurityAnsLabel"
        Me.SecurityAnsLabel.Size = New System.Drawing.Size(167, 28)
        Me.SecurityAnsLabel.TabIndex = 25
        Me.SecurityAnsLabel.Text = "Enter your answer"
        '
        'Back
        '
        Me.Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Back.Image = CType(resources.GetObject("Back.Image"), System.Drawing.Image)
        Me.Back.Location = New System.Drawing.Point(39, 30)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(40, 39)
        Me.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Back.TabIndex = 29
        Me.Back.TabStop = False
        '
        'Sign_up
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(799, 932)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.SQComboBox)
        Me.Controls.Add(Me.SignInLabel)
        Me.Controls.Add(Me.ConfirmPass_Label)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.QuestionLabel)
        Me.Controls.Add(Me.SecurityAnsLabel)
        Me.Controls.Add(Me.NewPass_Label)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.ConfirmPassCheckBox)
        Me.Controls.Add(Me.SecurityAnsTextBox)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.PassTextBox)
        Me.Controls.Add(Me.ConfirmPassTextbox)
        Me.Controls.Add(Me.SignupBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Sign_up"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Signup"
        CType(Me.Back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConfirmPass_Label As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents QuestionLabel As System.Windows.Forms.Label
    Friend WithEvents NewPass_Label As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmPassCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents PassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmPassTextbox As System.Windows.Forms.TextBox
    Friend WithEvents SignupBtn As System.Windows.Forms.Button
    Friend WithEvents SignInLabel As System.Windows.Forms.Label
    Friend WithEvents SQComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SecurityAnsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SecurityAnsLabel As System.Windows.Forms.Label
    Friend WithEvents Back As System.Windows.Forms.PictureBox
End Class
