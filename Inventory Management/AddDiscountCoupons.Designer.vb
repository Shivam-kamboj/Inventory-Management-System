<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDiscountCoupons
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddDiscountCoupons))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AddCouponTextBox = New System.Windows.Forms.TextBox()
        Me.AddCouponLabel = New System.Windows.Forms.Label()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.CouponsDGV = New System.Windows.Forms.DataGridView()
        Me.DiscountValLbl = New System.Windows.Forms.Label()
        Me.DiscountValueTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.CouponsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(522, 155)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 4)
        Me.Panel1.TabIndex = 32
        '
        'AddCouponTextBox
        '
        Me.AddCouponTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.AddCouponTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AddCouponTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddCouponTextBox.ForeColor = System.Drawing.Color.Black
        Me.AddCouponTextBox.Location = New System.Drawing.Point(521, 128)
        Me.AddCouponTextBox.Margin = New System.Windows.Forms.Padding(7, 10, 7, 10)
        Me.AddCouponTextBox.Name = "AddCouponTextBox"
        Me.AddCouponTextBox.Size = New System.Drawing.Size(288, 27)
        Me.AddCouponTextBox.TabIndex = 31
        '
        'AddCouponLabel
        '
        Me.AddCouponLabel.AutoSize = True
        Me.AddCouponLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddCouponLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.AddCouponLabel.Location = New System.Drawing.Point(261, 126)
        Me.AddCouponLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddCouponLabel.Name = "AddCouponLabel"
        Me.AddCouponLabel.Size = New System.Drawing.Size(168, 30)
        Me.AddCouponLabel.TabIndex = 30
        Me.AddCouponLabel.Text = "Dicount Coupan"
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoEllipsis = True
        Me.SaveBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.White
        Me.SaveBtn.Location = New System.Drawing.Point(359, 258)
        Me.SaveBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(118, 60)
        Me.SaveBtn.TabIndex = 33
        Me.SaveBtn.Text = "Add"
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.AutoEllipsis = True
        Me.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.Location = New System.Drawing.Point(554, 258)
        Me.DeleteBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(129, 60)
        Me.DeleteBtn.TabIndex = 33
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'CouponsDGV
        '
        Me.CouponsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CouponsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CouponsDGV.Location = New System.Drawing.Point(219, 350)
        Me.CouponsDGV.Name = "CouponsDGV"
        Me.CouponsDGV.RowTemplate.Height = 28
        Me.CouponsDGV.Size = New System.Drawing.Size(637, 365)
        Me.CouponsDGV.TabIndex = 34
        '
        'DiscountValLbl
        '
        Me.DiscountValLbl.AutoSize = True
        Me.DiscountValLbl.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountValLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.DiscountValLbl.Location = New System.Drawing.Point(261, 182)
        Me.DiscountValLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DiscountValLbl.Name = "DiscountValLbl"
        Me.DiscountValLbl.Size = New System.Drawing.Size(165, 30)
        Me.DiscountValLbl.TabIndex = 30
        Me.DiscountValLbl.Text = "Dicount Percent"
        '
        'DiscountValueTextBox
        '
        Me.DiscountValueTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DiscountValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DiscountValueTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountValueTextBox.ForeColor = System.Drawing.Color.Black
        Me.DiscountValueTextBox.Location = New System.Drawing.Point(521, 184)
        Me.DiscountValueTextBox.Margin = New System.Windows.Forms.Padding(7, 10, 7, 10)
        Me.DiscountValueTextBox.Name = "DiscountValueTextBox"
        Me.DiscountValueTextBox.Size = New System.Drawing.Size(288, 27)
        Me.DiscountValueTextBox.TabIndex = 31
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(522, 211)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(288, 4)
        Me.Panel2.TabIndex = 32
        '
        'AddDiscountCoupons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1090, 742)
        Me.Controls.Add(Me.CouponsDGV)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DiscountValueTextBox)
        Me.Controls.Add(Me.AddCouponTextBox)
        Me.Controls.Add(Me.DiscountValLbl)
        Me.Controls.Add(Me.AddCouponLabel)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AddDiscountCoupons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Discount Coupons"
        CType(Me.CouponsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AddCouponTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddCouponLabel As System.Windows.Forms.Label
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents CouponsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents DiscountValLbl As System.Windows.Forms.Label
    Friend WithEvents DiscountValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
