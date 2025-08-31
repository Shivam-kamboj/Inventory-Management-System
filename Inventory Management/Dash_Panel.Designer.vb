<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dash_Panel
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StockAlert_GrpBox = New System.Windows.Forms.GroupBox()
        Me.Alert_Label = New System.Windows.Forms.Label()
        Me.RecentTraction_GrpBox = New System.Windows.Forms.GroupBox()
        Me.RecentInventory = New System.Windows.Forms.DataGridView()
        Me.TotalProducts_Grpbox = New System.Windows.Forms.GroupBox()
        Me.TotalProducts_Label = New System.Windows.Forms.Label()
        Me.TotalProduct_Label = New System.Windows.Forms.Label()
        Me.Blink = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.StockAlert_GrpBox.SuspendLayout()
        Me.RecentTraction_GrpBox.SuspendLayout()
        CType(Me.RecentInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TotalProducts_Grpbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel1.Controls.Add(Me.StockAlert_GrpBox)
        Me.Panel1.Controls.Add(Me.RecentTraction_GrpBox)
        Me.Panel1.Controls.Add(Me.TotalProducts_Grpbox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(913, 487)
        Me.Panel1.TabIndex = 0
        '
        'StockAlert_GrpBox
        '
        Me.StockAlert_GrpBox.Controls.Add(Me.Alert_Label)
        Me.StockAlert_GrpBox.Location = New System.Drawing.Point(438, 132)
        Me.StockAlert_GrpBox.Name = "StockAlert_GrpBox"
        Me.StockAlert_GrpBox.Size = New System.Drawing.Size(380, 155)
        Me.StockAlert_GrpBox.TabIndex = 9
        Me.StockAlert_GrpBox.TabStop = False
        Me.StockAlert_GrpBox.Text = "Stock Alert"
        '
        'Alert_Label
        '
        Me.Alert_Label.AutoSize = True
        Me.Alert_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alert_Label.Location = New System.Drawing.Point(61, 31)
        Me.Alert_Label.Name = "Alert_Label"
        Me.Alert_Label.Size = New System.Drawing.Size(43, 19)
        Me.Alert_Label.TabIndex = 2
        Me.Alert_Label.Text = "Alert"
        '
        'RecentTraction_GrpBox
        '
        Me.RecentTraction_GrpBox.Controls.Add(Me.RecentInventory)
        Me.RecentTraction_GrpBox.Location = New System.Drawing.Point(167, 336)
        Me.RecentTraction_GrpBox.Margin = New System.Windows.Forms.Padding(2)
        Me.RecentTraction_GrpBox.Name = "RecentTraction_GrpBox"
        Me.RecentTraction_GrpBox.Padding = New System.Windows.Forms.Padding(2)
        Me.RecentTraction_GrpBox.Size = New System.Drawing.Size(586, 246)
        Me.RecentTraction_GrpBox.TabIndex = 10
        Me.RecentTraction_GrpBox.TabStop = False
        Me.RecentTraction_GrpBox.Text = "Recent Transaction"
        '
        'RecentInventory
        '
        Me.RecentInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RecentInventory.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RecentInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecentInventory.Location = New System.Drawing.Point(0, 19)
        Me.RecentInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.RecentInventory.Name = "RecentInventory"
        Me.RecentInventory.ReadOnly = True
        Me.RecentInventory.RowTemplate.Height = 28
        Me.RecentInventory.Size = New System.Drawing.Size(584, 227)
        Me.RecentInventory.TabIndex = 0
        '
        'TotalProducts_Grpbox
        '
        Me.TotalProducts_Grpbox.Controls.Add(Me.TotalProducts_Label)
        Me.TotalProducts_Grpbox.Controls.Add(Me.TotalProduct_Label)
        Me.TotalProducts_Grpbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalProducts_Grpbox.Location = New System.Drawing.Point(40, 123)
        Me.TotalProducts_Grpbox.Name = "TotalProducts_Grpbox"
        Me.TotalProducts_Grpbox.Size = New System.Drawing.Size(365, 164)
        Me.TotalProducts_Grpbox.TabIndex = 8
        Me.TotalProducts_Grpbox.TabStop = False
        Me.TotalProducts_Grpbox.Text = "Total Units"
        '
        'TotalProducts_Label
        '
        Me.TotalProducts_Label.AutoSize = True
        Me.TotalProducts_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalProducts_Label.Location = New System.Drawing.Point(41, 31)
        Me.TotalProducts_Label.Name = "TotalProducts_Label"
        Me.TotalProducts_Label.Size = New System.Drawing.Size(64, 17)
        Me.TotalProducts_Label.TabIndex = 2
        Me.TotalProducts_Label.Text = "Products"
        '
        'TotalProduct_Label
        '
        Me.TotalProduct_Label.AutoSize = True
        Me.TotalProduct_Label.Location = New System.Drawing.Point(289, 34)
        Me.TotalProduct_Label.Name = "TotalProduct_Label"
        Me.TotalProduct_Label.Size = New System.Drawing.Size(51, 17)
        Me.TotalProduct_Label.TabIndex = 3
        Me.TotalProduct_Label.Text = "Label1"
        '
        'Blink
        '
        Me.Blink.Enabled = True
        Me.Blink.Interval = 500
        '
        'Dash_Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(913, 487)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Dash_Panel"
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.StockAlert_GrpBox.ResumeLayout(False)
        Me.StockAlert_GrpBox.PerformLayout()
        Me.RecentTraction_GrpBox.ResumeLayout(False)
        CType(Me.RecentInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TotalProducts_Grpbox.ResumeLayout(False)
        Me.TotalProducts_Grpbox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents StockAlert_GrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents Alert_Label As System.Windows.Forms.Label
    Friend WithEvents RecentTraction_GrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents RecentInventory As System.Windows.Forms.DataGridView
    Friend WithEvents TotalProducts_Grpbox As System.Windows.Forms.GroupBox
    Friend WithEvents TotalProducts_Label As System.Windows.Forms.Label
    Friend WithEvents TotalProduct_Label As System.Windows.Forms.Label
    Friend WithEvents Blink As System.Windows.Forms.Timer
End Class
