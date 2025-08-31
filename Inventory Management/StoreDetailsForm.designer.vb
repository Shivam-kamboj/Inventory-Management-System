<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StoreDetailsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StoreDetailsForm))
        Me.Label_StoreName = New System.Windows.Forms.Label()
        Me.Label_Adress = New System.Windows.Forms.Label()
        Me.Label_Contact = New System.Windows.Forms.Label()
        Me.btn_Storeinfo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txtbox_Storename = New System.Windows.Forms.TextBox()
        Me.Txtbox_Adress = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Txtbox_Contact = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MailLabel = New System.Windows.Forms.Label()
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label_StoreName
        '
        Me.Label_StoreName.AutoSize = True
        Me.Label_StoreName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_StoreName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label_StoreName.Location = New System.Drawing.Point(307, 220)
        Me.Label_StoreName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_StoreName.Name = "Label_StoreName"
        Me.Label_StoreName.Size = New System.Drawing.Size(128, 30)
        Me.Label_StoreName.TabIndex = 10
        Me.Label_StoreName.Text = "Store Name"
        '
        'Label_Adress
        '
        Me.Label_Adress.AutoSize = True
        Me.Label_Adress.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Adress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label_Adress.Location = New System.Drawing.Point(307, 281)
        Me.Label_Adress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Adress.Name = "Label_Adress"
        Me.Label_Adress.Size = New System.Drawing.Size(78, 30)
        Me.Label_Adress.TabIndex = 10
        Me.Label_Adress.Text = "Adress"
        '
        'Label_Contact
        '
        Me.Label_Contact.AutoSize = True
        Me.Label_Contact.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Contact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label_Contact.Location = New System.Drawing.Point(307, 350)
        Me.Label_Contact.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Contact.Name = "Label_Contact"
        Me.Label_Contact.Size = New System.Drawing.Size(87, 30)
        Me.Label_Contact.TabIndex = 10
        Me.Label_Contact.Text = "Contact"
        '
        'btn_Storeinfo
        '
        Me.btn_Storeinfo.AutoEllipsis = True
        Me.btn_Storeinfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btn_Storeinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Storeinfo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Storeinfo.ForeColor = System.Drawing.Color.White
        Me.btn_Storeinfo.Location = New System.Drawing.Point(481, 514)
        Me.btn_Storeinfo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_Storeinfo.Name = "btn_Storeinfo"
        Me.btn_Storeinfo.Size = New System.Drawing.Size(112, 51)
        Me.btn_Storeinfo.TabIndex = 12
        Me.btn_Storeinfo.Text = "Save"
        Me.btn_Storeinfo.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(536, 251)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(372, 4)
        Me.Panel1.TabIndex = 29
        '
        'Txtbox_Storename
        '
        Me.Txtbox_Storename.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Txtbox_Storename.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtbox_Storename.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_Storename.ForeColor = System.Drawing.Color.Black
        Me.Txtbox_Storename.Location = New System.Drawing.Point(535, 224)
        Me.Txtbox_Storename.Margin = New System.Windows.Forms.Padding(7, 10, 7, 10)
        Me.Txtbox_Storename.Name = "Txtbox_Storename"
        Me.Txtbox_Storename.Size = New System.Drawing.Size(372, 27)
        Me.Txtbox_Storename.TabIndex = 28
        '
        'Txtbox_Adress
        '
        Me.Txtbox_Adress.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Txtbox_Adress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtbox_Adress.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_Adress.ForeColor = System.Drawing.Color.Black
        Me.Txtbox_Adress.Location = New System.Drawing.Point(536, 295)
        Me.Txtbox_Adress.Margin = New System.Windows.Forms.Padding(7, 10, 7, 10)
        Me.Txtbox_Adress.Name = "Txtbox_Adress"
        Me.Txtbox_Adress.Size = New System.Drawing.Size(372, 27)
        Me.Txtbox_Adress.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(537, 322)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(372, 4)
        Me.Panel2.TabIndex = 29
        '
        'Txtbox_Contact
        '
        Me.Txtbox_Contact.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Txtbox_Contact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtbox_Contact.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_Contact.ForeColor = System.Drawing.Color.Black
        Me.Txtbox_Contact.Location = New System.Drawing.Point(535, 364)
        Me.Txtbox_Contact.Margin = New System.Windows.Forms.Padding(7, 10, 7, 10)
        Me.Txtbox_Contact.Name = "Txtbox_Contact"
        Me.Txtbox_Contact.Size = New System.Drawing.Size(372, 27)
        Me.Txtbox_Contact.TabIndex = 28
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(536, 391)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(372, 4)
        Me.Panel3.TabIndex = 29
        '
        'MailLabel
        '
        Me.MailLabel.AutoSize = True
        Me.MailLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MailLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.MailLabel.Location = New System.Drawing.Point(307, 418)
        Me.MailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MailLabel.Name = "MailLabel"
        Me.MailLabel.Size = New System.Drawing.Size(54, 30)
        Me.MailLabel.TabIndex = 10
        Me.MailLabel.Text = "Mail"
        '
        'MailTextBox
        '
        Me.MailTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.MailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MailTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MailTextBox.ForeColor = System.Drawing.Color.Black
        Me.MailTextBox.Location = New System.Drawing.Point(535, 427)
        Me.MailTextBox.Margin = New System.Windows.Forms.Padding(7, 10, 7, 10)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.Size = New System.Drawing.Size(372, 27)
        Me.MailTextBox.TabIndex = 28
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(536, 454)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(372, 4)
        Me.Panel4.TabIndex = 29
        '
        'StoreDetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1090, 706)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MailTextBox)
        Me.Controls.Add(Me.Txtbox_Contact)
        Me.Controls.Add(Me.Txtbox_Adress)
        Me.Controls.Add(Me.Txtbox_Storename)
        Me.Controls.Add(Me.btn_Storeinfo)
        Me.Controls.Add(Me.MailLabel)
        Me.Controls.Add(Me.Label_Contact)
        Me.Controls.Add(Me.Label_Adress)
        Me.Controls.Add(Me.Label_StoreName)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "StoreDetailsForm"
        Me.Text = "Store Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_StoreName As System.Windows.Forms.Label
    Friend WithEvents Label_Adress As System.Windows.Forms.Label
    Friend WithEvents Label_Contact As System.Windows.Forms.Label
    Friend WithEvents btn_Storeinfo As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Txtbox_Storename As System.Windows.Forms.TextBox
    Friend WithEvents Txtbox_Adress As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Txtbox_Contact As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents MailLabel As System.Windows.Forms.Label
    Friend WithEvents MailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
End Class
