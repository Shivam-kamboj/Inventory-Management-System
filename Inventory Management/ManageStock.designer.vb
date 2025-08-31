<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageStock
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
        Me.Ms_Dgv = New System.Windows.Forms.DataGridView()
        Me.RadioSearch = New System.Windows.Forms.RadioButton()
        Me.RadioDelete = New System.Windows.Forms.RadioButton()
        Me.Ms_Date_dtp = New System.Windows.Forms.DateTimePicker()
        Me.Ms_ProductName = New System.Windows.Forms.Label()
        Me.Ms_Barcode = New System.Windows.Forms.Label()
        Me.Ms_Quantity = New System.Windows.Forms.Label()
        Me.Ms_Price = New System.Windows.Forms.Label()
        Me.Ms_Date = New System.Windows.Forms.Label()
        Me.Ms_btn_Delete = New System.Windows.Forms.Button()
        Me.Ms_btn_Update = New System.Windows.Forms.Button()
        Me.Ms_btn_Search = New System.Windows.Forms.Button()
        Me.Ms_GroupBox = New System.Windows.Forms.GroupBox()
        Me.RadioUpdate = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Ms_Pname_txt = New System.Windows.Forms.TextBox()
        Me.Ms_Barcode_txt = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Ms_Quantity_txt = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Ms_Price_txt = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PageTitleLabel = New System.Windows.Forms.Label()
        CType(Me.Ms_Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ms_GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ms_Dgv
        '
        Me.Ms_Dgv.AllowUserToAddRows = False
        Me.Ms_Dgv.AllowUserToDeleteRows = False
        Me.Ms_Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Ms_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Ms_Dgv.Location = New System.Drawing.Point(341, 479)
        Me.Ms_Dgv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ms_Dgv.Name = "Ms_Dgv"
        Me.Ms_Dgv.ReadOnly = True
        Me.Ms_Dgv.Size = New System.Drawing.Size(735, 387)
        Me.Ms_Dgv.TabIndex = 6
        '
        'RadioSearch
        '
        Me.RadioSearch.AutoSize = True
        Me.RadioSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioSearch.Location = New System.Drawing.Point(22, 30)
        Me.RadioSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioSearch.Name = "RadioSearch"
        Me.RadioSearch.Size = New System.Drawing.Size(67, 23)
        Me.RadioSearch.TabIndex = 7
        Me.RadioSearch.TabStop = True
        Me.RadioSearch.Text = "Search"
        Me.RadioSearch.UseVisualStyleBackColor = True
        '
        'RadioDelete
        '
        Me.RadioDelete.AutoSize = True
        Me.RadioDelete.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioDelete.Location = New System.Drawing.Point(783, 30)
        Me.RadioDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioDelete.Name = "RadioDelete"
        Me.RadioDelete.Size = New System.Drawing.Size(66, 23)
        Me.RadioDelete.TabIndex = 7
        Me.RadioDelete.TabStop = True
        Me.RadioDelete.Text = "Delete"
        Me.RadioDelete.UseVisualStyleBackColor = True
        '
        'Ms_Date_dtp
        '
        Me.Ms_Date_dtp.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ms_Date_dtp.Location = New System.Drawing.Point(346, 320)
        Me.Ms_Date_dtp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ms_Date_dtp.Name = "Ms_Date_dtp"
        Me.Ms_Date_dtp.Size = New System.Drawing.Size(298, 25)
        Me.Ms_Date_dtp.TabIndex = 8
        '
        'Ms_ProductName
        '
        Me.Ms_ProductName.AutoSize = True
        Me.Ms_ProductName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ms_ProductName.Location = New System.Drawing.Point(124, 150)
        Me.Ms_ProductName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Ms_ProductName.Name = "Ms_ProductName"
        Me.Ms_ProductName.Size = New System.Drawing.Size(115, 21)
        Me.Ms_ProductName.TabIndex = 9
        Me.Ms_ProductName.Text = "Product Name"
        '
        'Ms_Barcode
        '
        Me.Ms_Barcode.AutoSize = True
        Me.Ms_Barcode.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ms_Barcode.Location = New System.Drawing.Point(761, 233)
        Me.Ms_Barcode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Ms_Barcode.Name = "Ms_Barcode"
        Me.Ms_Barcode.Size = New System.Drawing.Size(71, 21)
        Me.Ms_Barcode.TabIndex = 9
        Me.Ms_Barcode.Text = "Barcode"
        '
        'Ms_Quantity
        '
        Me.Ms_Quantity.AutoSize = True
        Me.Ms_Quantity.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ms_Quantity.Location = New System.Drawing.Point(761, 150)
        Me.Ms_Quantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Ms_Quantity.Name = "Ms_Quantity"
        Me.Ms_Quantity.Size = New System.Drawing.Size(72, 21)
        Me.Ms_Quantity.TabIndex = 9
        Me.Ms_Quantity.Text = "Quantity"
        '
        'Ms_Price
        '
        Me.Ms_Price.AutoSize = True
        Me.Ms_Price.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ms_Price.Location = New System.Drawing.Point(135, 233)
        Me.Ms_Price.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Ms_Price.Name = "Ms_Price"
        Me.Ms_Price.Size = New System.Drawing.Size(46, 21)
        Me.Ms_Price.TabIndex = 9
        Me.Ms_Price.Text = "Price"
        '
        'Ms_Date
        '
        Me.Ms_Date.AutoSize = True
        Me.Ms_Date.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ms_Date.Location = New System.Drawing.Point(136, 318)
        Me.Ms_Date.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Ms_Date.Name = "Ms_Date"
        Me.Ms_Date.Size = New System.Drawing.Size(44, 21)
        Me.Ms_Date.TabIndex = 9
        Me.Ms_Date.Text = "Date"
        '
        'Ms_btn_Delete
        '
        Me.Ms_btn_Delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Ms_btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ms_btn_Delete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ms_btn_Delete.ForeColor = System.Drawing.Color.White
        Me.Ms_btn_Delete.Location = New System.Drawing.Point(1141, 308)
        Me.Ms_btn_Delete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ms_btn_Delete.Name = "Ms_btn_Delete"
        Me.Ms_btn_Delete.Size = New System.Drawing.Size(159, 54)
        Me.Ms_btn_Delete.TabIndex = 10
        Me.Ms_btn_Delete.Text = "Delete"
        Me.Ms_btn_Delete.UseVisualStyleBackColor = False
        '
        'Ms_btn_Update
        '
        Me.Ms_btn_Update.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Ms_btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ms_btn_Update.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ms_btn_Update.ForeColor = System.Drawing.Color.White
        Me.Ms_btn_Update.Location = New System.Drawing.Point(965, 308)
        Me.Ms_btn_Update.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ms_btn_Update.Name = "Ms_btn_Update"
        Me.Ms_btn_Update.Size = New System.Drawing.Size(159, 54)
        Me.Ms_btn_Update.TabIndex = 11
        Me.Ms_btn_Update.Text = "Update"
        Me.Ms_btn_Update.UseVisualStyleBackColor = False
        '
        'Ms_btn_Search
        '
        Me.Ms_btn_Search.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Ms_btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ms_btn_Search.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ms_btn_Search.ForeColor = System.Drawing.Color.White
        Me.Ms_btn_Search.Location = New System.Drawing.Point(782, 308)
        Me.Ms_btn_Search.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ms_btn_Search.Name = "Ms_btn_Search"
        Me.Ms_btn_Search.Size = New System.Drawing.Size(159, 54)
        Me.Ms_btn_Search.TabIndex = 12
        Me.Ms_btn_Search.Text = "Search"
        Me.Ms_btn_Search.UseVisualStyleBackColor = False
        '
        'Ms_GroupBox
        '
        Me.Ms_GroupBox.Controls.Add(Me.RadioSearch)
        Me.Ms_GroupBox.Controls.Add(Me.RadioUpdate)
        Me.Ms_GroupBox.Controls.Add(Me.RadioDelete)
        Me.Ms_GroupBox.Location = New System.Drawing.Point(296, 372)
        Me.Ms_GroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ms_GroupBox.Name = "Ms_GroupBox"
        Me.Ms_GroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ms_GroupBox.Size = New System.Drawing.Size(909, 97)
        Me.Ms_GroupBox.TabIndex = 13
        Me.Ms_GroupBox.TabStop = False
        '
        'RadioUpdate
        '
        Me.RadioUpdate.AutoSize = True
        Me.RadioUpdate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioUpdate.Location = New System.Drawing.Point(386, 30)
        Me.RadioUpdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioUpdate.Name = "RadioUpdate"
        Me.RadioUpdate.Size = New System.Drawing.Size(72, 23)
        Me.RadioUpdate.TabIndex = 7
        Me.RadioUpdate.TabStop = True
        Me.RadioUpdate.Text = "Update"
        Me.RadioUpdate.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(339, 181)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(372, 4)
        Me.Panel1.TabIndex = 25
        '
        'Ms_Pname_txt
        '
        Me.Ms_Pname_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Ms_Pname_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Ms_Pname_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ms_Pname_txt.ForeColor = System.Drawing.Color.Black
        Me.Ms_Pname_txt.Location = New System.Drawing.Point(338, 159)
        Me.Ms_Pname_txt.Margin = New System.Windows.Forms.Padding(7, 10, 7, 10)
        Me.Ms_Pname_txt.Name = "Ms_Pname_txt"
        Me.Ms_Pname_txt.Size = New System.Drawing.Size(372, 22)
        Me.Ms_Pname_txt.TabIndex = 24
        '
        'Ms_Barcode_txt
        '
        Me.Ms_Barcode_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Ms_Barcode_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Ms_Barcode_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ms_Barcode_txt.ForeColor = System.Drawing.Color.Black
        Me.Ms_Barcode_txt.Location = New System.Drawing.Point(939, 242)
        Me.Ms_Barcode_txt.Margin = New System.Windows.Forms.Padding(7, 10, 7, 10)
        Me.Ms_Barcode_txt.Name = "Ms_Barcode_txt"
        Me.Ms_Barcode_txt.Size = New System.Drawing.Size(372, 22)
        Me.Ms_Barcode_txt.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(940, 265)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(372, 4)
        Me.Panel2.TabIndex = 25
        '
        'Ms_Quantity_txt
        '
        Me.Ms_Quantity_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Ms_Quantity_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Ms_Quantity_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ms_Quantity_txt.ForeColor = System.Drawing.Color.Black
        Me.Ms_Quantity_txt.Location = New System.Drawing.Point(939, 159)
        Me.Ms_Quantity_txt.Margin = New System.Windows.Forms.Padding(7, 10, 7, 10)
        Me.Ms_Quantity_txt.Name = "Ms_Quantity_txt"
        Me.Ms_Quantity_txt.Size = New System.Drawing.Size(372, 22)
        Me.Ms_Quantity_txt.TabIndex = 24
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(940, 181)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(372, 4)
        Me.Panel3.TabIndex = 25
        '
        'Ms_Price_txt
        '
        Me.Ms_Price_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Ms_Price_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Ms_Price_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ms_Price_txt.ForeColor = System.Drawing.Color.Black
        Me.Ms_Price_txt.Location = New System.Drawing.Point(340, 243)
        Me.Ms_Price_txt.Margin = New System.Windows.Forms.Padding(7, 10, 7, 10)
        Me.Ms_Price_txt.Name = "Ms_Price_txt"
        Me.Ms_Price_txt.Size = New System.Drawing.Size(372, 22)
        Me.Ms_Price_txt.TabIndex = 24
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(341, 265)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(372, 4)
        Me.Panel4.TabIndex = 25
        '
        'PageTitleLabel
        '
        Me.PageTitleLabel.AutoSize = True
        Me.PageTitleLabel.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageTitleLabel.ForeColor = System.Drawing.Color.Gray
        Me.PageTitleLabel.Location = New System.Drawing.Point(617, 30)
        Me.PageTitleLabel.Name = "PageTitleLabel"
        Me.PageTitleLabel.Size = New System.Drawing.Size(245, 37)
        Me.PageTitleLabel.TabIndex = 26
        Me.PageTitleLabel.Text = "Update Inventory"
        '
        'ManageStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.PageTitleLabel)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Ms_Price_txt)
        Me.Controls.Add(Me.Ms_Quantity_txt)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Ms_Barcode_txt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Ms_Pname_txt)
        Me.Controls.Add(Me.Ms_GroupBox)
        Me.Controls.Add(Me.Ms_btn_Search)
        Me.Controls.Add(Me.Ms_btn_Update)
        Me.Controls.Add(Me.Ms_btn_Delete)
        Me.Controls.Add(Me.Ms_Date)
        Me.Controls.Add(Me.Ms_Price)
        Me.Controls.Add(Me.Ms_Quantity)
        Me.Controls.Add(Me.Ms_Barcode)
        Me.Controls.Add(Me.Ms_ProductName)
        Me.Controls.Add(Me.Ms_Date_dtp)
        Me.Controls.Add(Me.Ms_Dgv)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ManageStock"
        Me.Text = "Update Stock"
        CType(Me.Ms_Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ms_GroupBox.ResumeLayout(False)
        Me.Ms_GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ms_Dgv As System.Windows.Forms.DataGridView
    Friend WithEvents RadioSearch As System.Windows.Forms.RadioButton
    Friend WithEvents RadioDelete As System.Windows.Forms.RadioButton
    Friend WithEvents Ms_Date_dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Ms_ProductName As System.Windows.Forms.Label
    Friend WithEvents Ms_Barcode As System.Windows.Forms.Label
    Friend WithEvents Ms_Quantity As System.Windows.Forms.Label
    Friend WithEvents Ms_Price As System.Windows.Forms.Label
    Friend WithEvents Ms_Date As System.Windows.Forms.Label
    Friend WithEvents Ms_btn_Delete As System.Windows.Forms.Button
    Friend WithEvents Ms_btn_Update As System.Windows.Forms.Button
    Friend WithEvents Ms_btn_Search As System.Windows.Forms.Button
    Friend WithEvents Ms_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents RadioUpdate As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Ms_Pname_txt As System.Windows.Forms.TextBox
    Friend WithEvents Ms_Barcode_txt As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Ms_Quantity_txt As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Ms_Price_txt As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PageTitleLabel As System.Windows.Forms.Label
End Class
