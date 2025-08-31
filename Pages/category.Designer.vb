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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.category_txtbox = New System.Windows.Forms.TextBox()
        Me.btn_ClearCategory = New System.Windows.Forms.Button()
        Me.btn_AddCategory = New System.Windows.Forms.Button()
        Me.category_Dgv = New System.Windows.Forms.DataGridView()
        Me.btn_delcategory = New System.Windows.Forms.Button()
        CType(Me.category_Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Category Name"
        '
        'category_txtbox
        '
        Me.category_txtbox.Location = New System.Drawing.Point(269, 79)
        Me.category_txtbox.Name = "category_txtbox"
        Me.category_txtbox.Size = New System.Drawing.Size(205, 20)
        Me.category_txtbox.TabIndex = 1
        '
        'btn_ClearCategory
        '
        Me.btn_ClearCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ClearCategory.Location = New System.Drawing.Point(326, 149)
        Me.btn_ClearCategory.Name = "btn_ClearCategory"
        Me.btn_ClearCategory.Size = New System.Drawing.Size(106, 33)
        Me.btn_ClearCategory.TabIndex = 2
        Me.btn_ClearCategory.Text = "Clear"
        Me.btn_ClearCategory.UseVisualStyleBackColor = True
        '
        'btn_AddCategory
        '
        Me.btn_AddCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddCategory.Location = New System.Drawing.Point(167, 149)
        Me.btn_AddCategory.Name = "btn_AddCategory"
        Me.btn_AddCategory.Size = New System.Drawing.Size(106, 33)
        Me.btn_AddCategory.TabIndex = 3
        Me.btn_AddCategory.Text = "Add Category"
        Me.btn_AddCategory.UseVisualStyleBackColor = True
        '
        'category_Dgv
        '
        Me.category_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.category_Dgv.Location = New System.Drawing.Point(65, 223)
        Me.category_Dgv.Name = "category_Dgv"
        Me.category_Dgv.Size = New System.Drawing.Size(572, 198)
        Me.category_Dgv.TabIndex = 4
        '
        'btn_delcategory
        '
        Me.btn_delcategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delcategory.Location = New System.Drawing.Point(471, 149)
        Me.btn_delcategory.Name = "btn_delcategory"
        Me.btn_delcategory.Size = New System.Drawing.Size(106, 33)
        Me.btn_delcategory.TabIndex = 5
        Me.btn_delcategory.Text = "Delete Category"
        Me.btn_delcategory.UseVisualStyleBackColor = True
        '
        'category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 434)
        Me.Controls.Add(Me.btn_delcategory)
        Me.Controls.Add(Me.category_Dgv)
        Me.Controls.Add(Me.btn_AddCategory)
        Me.Controls.Add(Me.btn_ClearCategory)
        Me.Controls.Add(Me.category_txtbox)
        Me.Controls.Add(Me.Label1)
        Me.MinimizeBox = False
        Me.Name = "category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Category"
        CType(Me.category_Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents category_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents btn_ClearCategory As System.Windows.Forms.Button
    Friend WithEvents btn_AddCategory As System.Windows.Forms.Button
    Friend WithEvents category_Dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btn_delcategory As System.Windows.Forms.Button
End Class
