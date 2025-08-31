<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class category
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(category))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_ClearCategory = New System.Windows.Forms.Button()
        Me.btn_AddCategory = New System.Windows.Forms.Button()
        Me.category_Dgv = New System.Windows.Forms.DataGridView()
        Me.btn_delcategory = New System.Windows.Forms.Button()
        Me.PageTitleLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.category_txtbox = New System.Windows.Forms.TextBox()
        CType(Me.category_Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(356, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Category Name"
        '
        'btn_ClearCategory
        '
        Me.btn_ClearCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btn_ClearCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ClearCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ClearCategory.ForeColor = System.Drawing.Color.White
        Me.btn_ClearCategory.Location = New System.Drawing.Point(495, 234)
        Me.btn_ClearCategory.Name = "btn_ClearCategory"
        Me.btn_ClearCategory.Size = New System.Drawing.Size(139, 46)
        Me.btn_ClearCategory.TabIndex = 2
        Me.btn_ClearCategory.Text = "Clear"
        Me.btn_ClearCategory.UseVisualStyleBackColor = False
        '
        'btn_AddCategory
        '
        Me.btn_AddCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btn_AddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddCategory.ForeColor = System.Drawing.Color.White
        Me.btn_AddCategory.Location = New System.Drawing.Point(317, 234)
        Me.btn_AddCategory.Name = "btn_AddCategory"
        Me.btn_AddCategory.Size = New System.Drawing.Size(139, 46)
        Me.btn_AddCategory.TabIndex = 3
        Me.btn_AddCategory.Text = "Add Category"
        Me.btn_AddCategory.UseVisualStyleBackColor = False
        '
        'category_Dgv
        '
        Me.category_Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.category_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.category_Dgv.Location = New System.Drawing.Point(291, 352)
        Me.category_Dgv.Name = "category_Dgv"
        Me.category_Dgv.Size = New System.Drawing.Size(572, 321)
        Me.category_Dgv.TabIndex = 4
        '
        'btn_delcategory
        '
        Me.btn_delcategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btn_delcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delcategory.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delcategory.ForeColor = System.Drawing.Color.White
        Me.btn_delcategory.Location = New System.Drawing.Point(677, 234)
        Me.btn_delcategory.Name = "btn_delcategory"
        Me.btn_delcategory.Size = New System.Drawing.Size(139, 46)
        Me.btn_delcategory.TabIndex = 5
        Me.btn_delcategory.Text = "Delete Category"
        Me.btn_delcategory.UseVisualStyleBackColor = False
        '
        'PageTitleLabel
        '
        Me.PageTitleLabel.AutoSize = True
        Me.PageTitleLabel.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageTitleLabel.Location = New System.Drawing.Point(447, 34)
        Me.PageTitleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PageTitleLabel.Name = "PageTitleLabel"
        Me.PageTitleLabel.Size = New System.Drawing.Size(218, 37)
        Me.PageTitleLabel.TabIndex = 6
        Me.PageTitleLabel.Text = "Add a Category"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(522, 173)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 3)
        Me.Panel1.TabIndex = 23
        '
        'category_txtbox
        '
        Me.category_txtbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.category_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.category_txtbox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category_txtbox.ForeColor = System.Drawing.Color.Black
        Me.category_txtbox.Location = New System.Drawing.Point(521, 156)
        Me.category_txtbox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.category_txtbox.Name = "category_txtbox"
        Me.category_txtbox.Size = New System.Drawing.Size(248, 22)
        Me.category_txtbox.TabIndex = 22
        '
        'category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(913, 487)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.category_txtbox)
        Me.Controls.Add(Me.PageTitleLabel)
        Me.Controls.Add(Me.btn_delcategory)
        Me.Controls.Add(Me.category_Dgv)
        Me.Controls.Add(Me.btn_AddCategory)
        Me.Controls.Add(Me.btn_ClearCategory)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add a Category"
        CType(Me.category_Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_ClearCategory As System.Windows.Forms.Button
    Friend WithEvents btn_AddCategory As System.Windows.Forms.Button
    Friend WithEvents category_Dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btn_delcategory As System.Windows.Forms.Button
    Friend WithEvents PageTitleLabel As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents category_txtbox As System.Windows.Forms.TextBox
End Class
