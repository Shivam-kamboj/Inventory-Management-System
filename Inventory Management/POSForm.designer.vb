<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POSForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(POSForm))
        Me.Pos_btn_Scan = New System.Windows.Forms.Button()
        Me.Pos_Label_Barcode = New System.Windows.Forms.Label()
        Me.Pos_Dgv = New System.Windows.Forms.DataGridView()
        Me.Barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pos_Label_Totaltxt = New System.Windows.Forms.Label()
        Me.DiscountLabel = New System.Windows.Forms.Label()
        Me.Pos_label_gtotaltxt = New System.Windows.Forms.Label()
        Me.Pos_btn_Checkout = New System.Windows.Forms.Button()
        Me.Pos_btn_Remove = New System.Windows.Forms.Button()
        Me.Pos_btn_PrintRecipt = New System.Windows.Forms.Button()
        Me.Pos_Qty_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Pos_Label_Quantity = New System.Windows.Forms.Label()
        Me.Pos_Total_value = New System.Windows.Forms.Label()
        Me.DiscountValue = New System.Windows.Forms.Label()
        Me.Pos_GTotal_Value = New System.Windows.Forms.Label()
        Me.PageTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pos_Textbox_Barcode = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.DiscountLbl = New System.Windows.Forms.Label()
        Me.DiscountTextbox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Pos_Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pos_Qty_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pos_btn_Scan
        '
        Me.Pos_btn_Scan.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Pos_btn_Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pos_btn_Scan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pos_btn_Scan.ForeColor = System.Drawing.Color.White
        Me.Pos_btn_Scan.Location = New System.Drawing.Point(99, 284)
        Me.Pos_btn_Scan.Name = "Pos_btn_Scan"
        Me.Pos_btn_Scan.Size = New System.Drawing.Size(106, 35)
        Me.Pos_btn_Scan.TabIndex = 1
        Me.Pos_btn_Scan.Text = "Scan"
        Me.Pos_btn_Scan.UseVisualStyleBackColor = False
        '
        'Pos_Label_Barcode
        '
        Me.Pos_Label_Barcode.AutoSize = True
        Me.Pos_Label_Barcode.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pos_Label_Barcode.Location = New System.Drawing.Point(96, 134)
        Me.Pos_Label_Barcode.Name = "Pos_Label_Barcode"
        Me.Pos_Label_Barcode.Size = New System.Drawing.Size(71, 21)
        Me.Pos_Label_Barcode.TabIndex = 2
        Me.Pos_Label_Barcode.Text = "Barcode"
        '
        'Pos_Dgv
        '
        Me.Pos_Dgv.AllowUserToAddRows = False
        Me.Pos_Dgv.AllowUserToDeleteRows = False
        Me.Pos_Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Pos_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Pos_Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Barcode, Me.ProductName, Me.Quantity, Me.ProductPrice, Me.TotalPrice})
        Me.Pos_Dgv.Location = New System.Drawing.Point(64, 348)
        Me.Pos_Dgv.Name = "Pos_Dgv"
        Me.Pos_Dgv.ReadOnly = True
        Me.Pos_Dgv.Size = New System.Drawing.Size(726, 276)
        Me.Pos_Dgv.TabIndex = 3
        '
        'Barcode
        '
        Me.Barcode.HeaderText = "Barcode"
        Me.Barcode.Name = "Barcode"
        Me.Barcode.ReadOnly = True
        '
        'ProductName
        '
        Me.ProductName.HeaderText = "Product Name"
        Me.ProductName.Name = "ProductName"
        Me.ProductName.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'ProductPrice
        '
        Me.ProductPrice.HeaderText = "Price"
        Me.ProductPrice.Name = "ProductPrice"
        Me.ProductPrice.ReadOnly = True
        '
        'TotalPrice
        '
        Me.TotalPrice.HeaderText = "Total"
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.ReadOnly = True
        '
        'Pos_Label_Totaltxt
        '
        Me.Pos_Label_Totaltxt.AutoSize = True
        Me.Pos_Label_Totaltxt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pos_Label_Totaltxt.Location = New System.Drawing.Point(107, 237)
        Me.Pos_Label_Totaltxt.Name = "Pos_Label_Totaltxt"
        Me.Pos_Label_Totaltxt.Size = New System.Drawing.Size(53, 21)
        Me.Pos_Label_Totaltxt.TabIndex = 4
        Me.Pos_Label_Totaltxt.Text = "Total: "
        '
        'DiscountLabel
        '
        Me.DiscountLabel.AutoSize = True
        Me.DiscountLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountLabel.Location = New System.Drawing.Point(325, 237)
        Me.DiscountLabel.Name = "DiscountLabel"
        Me.DiscountLabel.Size = New System.Drawing.Size(86, 21)
        Me.DiscountLabel.TabIndex = 5
        Me.DiscountLabel.Text = "Discount : "
        '
        'Pos_label_gtotaltxt
        '
        Me.Pos_label_gtotaltxt.AutoSize = True
        Me.Pos_label_gtotaltxt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pos_label_gtotaltxt.Location = New System.Drawing.Point(531, 237)
        Me.Pos_label_gtotaltxt.Name = "Pos_label_gtotaltxt"
        Me.Pos_label_gtotaltxt.Size = New System.Drawing.Size(101, 21)
        Me.Pos_label_gtotaltxt.TabIndex = 6
        Me.Pos_label_gtotaltxt.Text = "Grand Total: "
        '
        'Pos_btn_Checkout
        '
        Me.Pos_btn_Checkout.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Pos_btn_Checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pos_btn_Checkout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pos_btn_Checkout.ForeColor = System.Drawing.Color.White
        Me.Pos_btn_Checkout.Location = New System.Drawing.Point(482, 284)
        Me.Pos_btn_Checkout.Name = "Pos_btn_Checkout"
        Me.Pos_btn_Checkout.Size = New System.Drawing.Size(106, 35)
        Me.Pos_btn_Checkout.TabIndex = 7
        Me.Pos_btn_Checkout.Text = "CheckOut"
        Me.Pos_btn_Checkout.UseVisualStyleBackColor = False
        '
        'Pos_btn_Remove
        '
        Me.Pos_btn_Remove.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Pos_btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pos_btn_Remove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pos_btn_Remove.ForeColor = System.Drawing.Color.White
        Me.Pos_btn_Remove.Location = New System.Drawing.Point(285, 284)
        Me.Pos_btn_Remove.Name = "Pos_btn_Remove"
        Me.Pos_btn_Remove.Size = New System.Drawing.Size(106, 35)
        Me.Pos_btn_Remove.TabIndex = 8
        Me.Pos_btn_Remove.Text = "Remove"
        Me.Pos_btn_Remove.UseVisualStyleBackColor = False
        '
        'Pos_btn_PrintRecipt
        '
        Me.Pos_btn_PrintRecipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Pos_btn_PrintRecipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pos_btn_PrintRecipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pos_btn_PrintRecipt.ForeColor = System.Drawing.Color.White
        Me.Pos_btn_PrintRecipt.Location = New System.Drawing.Point(673, 284)
        Me.Pos_btn_PrintRecipt.Name = "Pos_btn_PrintRecipt"
        Me.Pos_btn_PrintRecipt.Size = New System.Drawing.Size(106, 35)
        Me.Pos_btn_PrintRecipt.TabIndex = 7
        Me.Pos_btn_PrintRecipt.Text = "Print Recipt"
        Me.Pos_btn_PrintRecipt.UseVisualStyleBackColor = False
        '
        'Pos_Qty_NumericUpDown
        '
        Me.Pos_Qty_NumericUpDown.Location = New System.Drawing.Point(535, 139)
        Me.Pos_Qty_NumericUpDown.Name = "Pos_Qty_NumericUpDown"
        Me.Pos_Qty_NumericUpDown.Size = New System.Drawing.Size(248, 20)
        Me.Pos_Qty_NumericUpDown.TabIndex = 9
        '
        'Pos_Label_Quantity
        '
        Me.Pos_Label_Quantity.AutoSize = True
        Me.Pos_Label_Quantity.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pos_Label_Quantity.Location = New System.Drawing.Point(451, 135)
        Me.Pos_Label_Quantity.Name = "Pos_Label_Quantity"
        Me.Pos_Label_Quantity.Size = New System.Drawing.Size(72, 21)
        Me.Pos_Label_Quantity.TabIndex = 2
        Me.Pos_Label_Quantity.Text = "Quantity"
        '
        'Pos_Total_value
        '
        Me.Pos_Total_value.AutoSize = True
        Me.Pos_Total_value.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pos_Total_value.Location = New System.Drawing.Point(167, 236)
        Me.Pos_Total_value.Name = "Pos_Total_value"
        Me.Pos_Total_value.Size = New System.Drawing.Size(0, 21)
        Me.Pos_Total_value.TabIndex = 4
        '
        'DiscountValue
        '
        Me.DiscountValue.AutoSize = True
        Me.DiscountValue.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountValue.Location = New System.Drawing.Point(417, 237)
        Me.DiscountValue.Name = "DiscountValue"
        Me.DiscountValue.Size = New System.Drawing.Size(0, 21)
        Me.DiscountValue.TabIndex = 4
        '
        'Pos_GTotal_Value
        '
        Me.Pos_GTotal_Value.AutoSize = True
        Me.Pos_GTotal_Value.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pos_GTotal_Value.Location = New System.Drawing.Point(651, 237)
        Me.Pos_GTotal_Value.Name = "Pos_GTotal_Value"
        Me.Pos_GTotal_Value.Size = New System.Drawing.Size(0, 21)
        Me.Pos_GTotal_Value.TabIndex = 4
        '
        'PageTitle
        '
        Me.PageTitle.AutoSize = True
        Me.PageTitle.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageTitle.Location = New System.Drawing.Point(335, 40)
        Me.PageTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PageTitle.Name = "PageTitle"
        Me.PageTitle.Size = New System.Drawing.Size(150, 41)
        Me.PageTitle.TabIndex = 10
        Me.PageTitle.Text = "Checkout"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(189, 151)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 3)
        Me.Panel1.TabIndex = 27
        '
        'Pos_Textbox_Barcode
        '
        Me.Pos_Textbox_Barcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Pos_Textbox_Barcode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Pos_Textbox_Barcode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pos_Textbox_Barcode.ForeColor = System.Drawing.Color.Black
        Me.Pos_Textbox_Barcode.Location = New System.Drawing.Point(189, 134)
        Me.Pos_Textbox_Barcode.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Pos_Textbox_Barcode.Name = "Pos_Textbox_Barcode"
        Me.Pos_Textbox_Barcode.Size = New System.Drawing.Size(248, 22)
        Me.Pos_Textbox_Barcode.TabIndex = 26
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'DiscountLbl
        '
        Me.DiscountLbl.AutoSize = True
        Me.DiscountLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountLbl.Location = New System.Drawing.Point(96, 185)
        Me.DiscountLbl.Name = "DiscountLbl"
        Me.DiscountLbl.Size = New System.Drawing.Size(136, 21)
        Me.DiscountLbl.TabIndex = 2
        Me.DiscountLbl.Text = "Discount Coupon"
        '
        'DiscountTextbox
        '
        Me.DiscountTextbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DiscountTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DiscountTextbox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountTextbox.ForeColor = System.Drawing.Color.Black
        Me.DiscountTextbox.Location = New System.Drawing.Point(268, 187)
        Me.DiscountTextbox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DiscountTextbox.Name = "DiscountTextbox"
        Me.DiscountTextbox.Size = New System.Drawing.Size(511, 22)
        Me.DiscountTextbox.TabIndex = 26
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(267, 203)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(511, 3)
        Me.Panel2.TabIndex = 27
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(802, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(396, 718)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'POSForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(913, 487)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DiscountTextbox)
        Me.Controls.Add(Me.Pos_Textbox_Barcode)
        Me.Controls.Add(Me.PageTitle)
        Me.Controls.Add(Me.Pos_Qty_NumericUpDown)
        Me.Controls.Add(Me.Pos_btn_Remove)
        Me.Controls.Add(Me.Pos_btn_PrintRecipt)
        Me.Controls.Add(Me.Pos_btn_Checkout)
        Me.Controls.Add(Me.Pos_label_gtotaltxt)
        Me.Controls.Add(Me.DiscountLabel)
        Me.Controls.Add(Me.Pos_GTotal_Value)
        Me.Controls.Add(Me.DiscountValue)
        Me.Controls.Add(Me.Pos_Total_value)
        Me.Controls.Add(Me.Pos_Label_Totaltxt)
        Me.Controls.Add(Me.Pos_Dgv)
        Me.Controls.Add(Me.Pos_Label_Quantity)
        Me.Controls.Add(Me.DiscountLbl)
        Me.Controls.Add(Me.Pos_Label_Barcode)
        Me.Controls.Add(Me.Pos_btn_Scan)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Name = "POSForm"
        Me.Text = "Add to Cart"
        CType(Me.Pos_Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pos_Qty_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pos_btn_Scan As System.Windows.Forms.Button
    Friend WithEvents Pos_Label_Barcode As System.Windows.Forms.Label
    Friend WithEvents Pos_Dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Pos_Label_Totaltxt As System.Windows.Forms.Label
    Friend WithEvents DiscountLabel As System.Windows.Forms.Label
    Friend WithEvents Pos_label_gtotaltxt As System.Windows.Forms.Label
    Friend WithEvents Pos_btn_Checkout As System.Windows.Forms.Button
    Friend WithEvents Pos_btn_Remove As System.Windows.Forms.Button
    Friend WithEvents Pos_btn_PrintRecipt As System.Windows.Forms.Button
    Friend WithEvents Pos_Qty_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Pos_Label_Quantity As System.Windows.Forms.Label
    Friend WithEvents Barcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pos_Total_value As System.Windows.Forms.Label
    Friend WithEvents DiscountValue As System.Windows.Forms.Label
    Friend WithEvents Pos_GTotal_Value As System.Windows.Forms.Label
    Friend WithEvents PageTitle As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Pos_Textbox_Barcode As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents DiscountLbl As System.Windows.Forms.Label
    Friend WithEvents DiscountTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
