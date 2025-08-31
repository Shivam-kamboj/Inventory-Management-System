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
        Me.Ms_Quantity_txt = New System.Windows.Forms.TextBox()
        Me.Ms_Pname_txt = New System.Windows.Forms.TextBox()
        Me.Ms_Barcode_txt = New System.Windows.Forms.TextBox()
        Me.Ms_Price_txt = New System.Windows.Forms.TextBox()
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
        CType(Me.Ms_Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ms_GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ms_Quantity_txt
        '
        Me.Ms_Quantity_txt.Location = New System.Drawing.Point(154, 183)
        Me.Ms_Quantity_txt.Name = "Ms_Quantity_txt"
        Me.Ms_Quantity_txt.Size = New System.Drawing.Size(205, 20)
        Me.Ms_Quantity_txt.TabIndex = 5
        '
        'Ms_Pname_txt
        '
        Me.Ms_Pname_txt.Location = New System.Drawing.Point(154, 73)
        Me.Ms_Pname_txt.Name = "Ms_Pname_txt"
        Me.Ms_Pname_txt.Size = New System.Drawing.Size(205, 20)
        Me.Ms_Pname_txt.TabIndex = 5
        '
        'Ms_Barcode_txt
        '
        Me.Ms_Barcode_txt.Location = New System.Drawing.Point(154, 128)
        Me.Ms_Barcode_txt.Name = "Ms_Barcode_txt"
        Me.Ms_Barcode_txt.Size = New System.Drawing.Size(205, 20)
        Me.Ms_Barcode_txt.TabIndex = 5
        '
        'Ms_Price_txt
        '
        Me.Ms_Price_txt.Location = New System.Drawing.Point(154, 238)
        Me.Ms_Price_txt.Name = "Ms_Price_txt"
        Me.Ms_Price_txt.Size = New System.Drawing.Size(205, 20)
        Me.Ms_Price_txt.TabIndex = 5
        '
        'Ms_Dgv
        '
        Me.Ms_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Ms_Dgv.Location = New System.Drawing.Point(386, 73)
        Me.Ms_Dgv.Name = "Ms_Dgv"
        Me.Ms_Dgv.Size = New System.Drawing.Size(490, 240)
        Me.Ms_Dgv.TabIndex = 6
        '
        'RadioSearch
        '
        Me.RadioSearch.AutoSize = True
        Me.RadioSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioSearch.Location = New System.Drawing.Point(15, 19)
        Me.RadioSearch.Name = "RadioSearch"
        Me.RadioSearch.Size = New System.Drawing.Size(65, 17)
        Me.RadioSearch.TabIndex = 7
        Me.RadioSearch.TabStop = True
        Me.RadioSearch.Text = "Search"
        Me.RadioSearch.UseVisualStyleBackColor = True
        '
        'RadioDelete
        '
        Me.RadioDelete.AutoSize = True
        Me.RadioDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioDelete.Location = New System.Drawing.Point(522, 19)
        Me.RadioDelete.Name = "RadioDelete"
        Me.RadioDelete.Size = New System.Drawing.Size(62, 17)
        Me.RadioDelete.TabIndex = 7
        Me.RadioDelete.TabStop = True
        Me.RadioDelete.Text = "Delete"
        Me.RadioDelete.UseVisualStyleBackColor = True
        '
        'Ms_Date_dtp
        '
        Me.Ms_Date_dtp.Location = New System.Drawing.Point(154, 292)
        Me.Ms_Date_dtp.Name = "Ms_Date_dtp"
        Me.Ms_Date_dtp.Size = New System.Drawing.Size(200, 20)
        Me.Ms_Date_dtp.TabIndex = 8
        '
        'Ms_ProductName
        '
        Me.Ms_ProductName.AutoSize = True
        Me.Ms_ProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ms_ProductName.Location = New System.Drawing.Point(28, 79)
        Me.Ms_ProductName.Name = "Ms_ProductName"
        Me.Ms_ProductName.Size = New System.Drawing.Size(87, 13)
        Me.Ms_ProductName.TabIndex = 9
        Me.Ms_ProductName.Text = "Product Name"
        '
        'Ms_Barcode
        '
        Me.Ms_Barcode.AutoSize = True
        Me.Ms_Barcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ms_Barcode.Location = New System.Drawing.Point(28, 135)
        Me.Ms_Barcode.Name = "Ms_Barcode"
        Me.Ms_Barcode.Size = New System.Drawing.Size(60, 15)
        Me.Ms_Barcode.TabIndex = 9
        Me.Ms_Barcode.Text = "Barcode"
        '
        'Ms_Quantity
        '
        Me.Ms_Quantity.AutoSize = True
        Me.Ms_Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ms_Quantity.Location = New System.Drawing.Point(28, 190)
        Me.Ms_Quantity.Name = "Ms_Quantity"
        Me.Ms_Quantity.Size = New System.Drawing.Size(59, 15)
        Me.Ms_Quantity.TabIndex = 9
        Me.Ms_Quantity.Text = "Quantity"
        '
        'Ms_Price
        '
        Me.Ms_Price.AutoSize = True
        Me.Ms_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ms_Price.Location = New System.Drawing.Point(33, 243)
        Me.Ms_Price.Name = "Ms_Price"
        Me.Ms_Price.Size = New System.Drawing.Size(40, 15)
        Me.Ms_Price.TabIndex = 9
        Me.Ms_Price.Text = "Price"
        '
        'Ms_Date
        '
        Me.Ms_Date.AutoSize = True
        Me.Ms_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ms_Date.Location = New System.Drawing.Point(36, 298)
        Me.Ms_Date.Name = "Ms_Date"
        Me.Ms_Date.Size = New System.Drawing.Size(37, 15)
        Me.Ms_Date.TabIndex = 9
        Me.Ms_Date.Text = "Date"
        '
        'Ms_btn_Delete
        '
        Me.Ms_btn_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ms_btn_Delete.Location = New System.Drawing.Point(624, 378)
        Me.Ms_btn_Delete.Name = "Ms_btn_Delete"
        Me.Ms_btn_Delete.Size = New System.Drawing.Size(106, 33)
        Me.Ms_btn_Delete.TabIndex = 10
        Me.Ms_btn_Delete.Text = "Delete"
        Me.Ms_btn_Delete.UseVisualStyleBackColor = True
        '
        'Ms_btn_Update
        '
        Me.Ms_btn_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ms_btn_Update.Location = New System.Drawing.Point(376, 378)
        Me.Ms_btn_Update.Name = "Ms_btn_Update"
        Me.Ms_btn_Update.Size = New System.Drawing.Size(106, 33)
        Me.Ms_btn_Update.TabIndex = 11
        Me.Ms_btn_Update.Text = "Update"
        Me.Ms_btn_Update.UseVisualStyleBackColor = True
        '
        'Ms_btn_Search
        '
        Me.Ms_btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ms_btn_Search.Location = New System.Drawing.Point(128, 378)
        Me.Ms_btn_Search.Name = "Ms_btn_Search"
        Me.Ms_btn_Search.Size = New System.Drawing.Size(106, 33)
        Me.Ms_btn_Search.TabIndex = 12
        Me.Ms_btn_Search.Text = "Search"
        Me.Ms_btn_Search.UseVisualStyleBackColor = True
        '
        'Ms_GroupBox
        '
        Me.Ms_GroupBox.Controls.Add(Me.RadioSearch)
        Me.Ms_GroupBox.Controls.Add(Me.RadioUpdate)
        Me.Ms_GroupBox.Controls.Add(Me.RadioDelete)
        Me.Ms_GroupBox.Location = New System.Drawing.Point(163, 7)
        Me.Ms_GroupBox.Name = "Ms_GroupBox"
        Me.Ms_GroupBox.Size = New System.Drawing.Size(606, 60)
        Me.Ms_GroupBox.TabIndex = 13
        Me.Ms_GroupBox.TabStop = False
        '
        'RadioUpdate
        '
        Me.RadioUpdate.AutoSize = True
        Me.RadioUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioUpdate.Location = New System.Drawing.Point(257, 19)
        Me.RadioUpdate.Name = "RadioUpdate"
        Me.RadioUpdate.Size = New System.Drawing.Size(66, 17)
        Me.RadioUpdate.TabIndex = 7
        Me.RadioUpdate.TabStop = True
        Me.RadioUpdate.Text = "Update"
        Me.RadioUpdate.UseVisualStyleBackColor = True
        '
        'ManageStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 490)
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
        Me.Controls.Add(Me.Ms_Pname_txt)
        Me.Controls.Add(Me.Ms_Price_txt)
        Me.Controls.Add(Me.Ms_Barcode_txt)
        Me.Controls.Add(Me.Ms_Quantity_txt)
        Me.Name = "ManageStock"
        Me.Text = "Manage Stock"
        CType(Me.Ms_Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ms_GroupBox.ResumeLayout(False)
        Me.Ms_GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ms_Quantity_txt As System.Windows.Forms.TextBox
    Friend WithEvents Ms_Pname_txt As System.Windows.Forms.TextBox
    Friend WithEvents Ms_Barcode_txt As System.Windows.Forms.TextBox
    Friend WithEvents Ms_Price_txt As System.Windows.Forms.TextBox
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
End Class
