<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditStoreDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddDiscountCouponsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer_DateTime = New System.Windows.Forms.Timer(Me.components)
        Me.TotalProducts_Label = New System.Windows.Forms.Label()
        Me.Alert_Label = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.AddCategoryBtn = New System.Windows.Forms.Button()
        Me.SalesBtn = New System.Windows.Forms.Button()
        Me.ShowStockBtn = New System.Windows.Forms.Button()
        Me.ManageCustomerBtn = New System.Windows.Forms.Button()
        Me.DashboardBtn = New System.Windows.Forms.Button()
        Me.Stockbtn = New System.Windows.Forms.Button()
        Me.TotalProducts_Grpbox = New System.Windows.Forms.GroupBox()
        Me.TotalProduct_Label = New System.Windows.Forms.Label()
        Me.StockAlert_GrpBox = New System.Windows.Forms.GroupBox()
        Me.RecentTraction_GrpBox = New System.Windows.Forms.GroupBox()
        Me.RecentInventory = New System.Windows.Forms.DataGridView()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Blink = New System.Windows.Forms.Timer(Me.components)
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.buttoncloser_timer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SidePanel.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TotalProducts_Grpbox.SuspendLayout()
        Me.StockAlert_GrpBox.SuspendLayout()
        Me.RecentTraction_GrpBox.SuspendLayout()
        CType(Me.RecentInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ProductToolStripMenuItem, Me.StockToolStripMenuItem, Me.SalesToolStripMenuItem, Me.Settings})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1257, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.ProductToolStripMenuItem.Text = "Add a Category"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'Settings
        '
        Me.Settings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FeedbackToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.Settings.ForeColor = System.Drawing.Color.White
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(57, 20)
        Me.Settings.Text = "Setings"
        '
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditStoreDetailsToolStripMenuItem, Me.AddDiscountCouponsToolStripMenuItem})
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.FeedbackToolStripMenuItem.Text = "Store Details"
        '
        'EditStoreDetailsToolStripMenuItem
        '
        Me.EditStoreDetailsToolStripMenuItem.Name = "EditStoreDetailsToolStripMenuItem"
        Me.EditStoreDetailsToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.EditStoreDetailsToolStripMenuItem.Text = "Edit Store Details"
        '
        'AddDiscountCouponsToolStripMenuItem
        '
        Me.AddDiscountCouponsToolStripMenuItem.Name = "AddDiscountCouponsToolStripMenuItem"
        Me.AddDiscountCouponsToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AddDiscountCouponsToolStripMenuItem.Text = "Add Discount Coupons"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Timer_DateTime
        '
        Me.Timer_DateTime.Interval = 1000
        '
        'TotalProducts_Label
        '
        Me.TotalProducts_Label.AutoSize = True
        Me.TotalProducts_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalProducts_Label.Location = New System.Drawing.Point(84, 97)
        Me.TotalProducts_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalProducts_Label.Name = "TotalProducts_Label"
        Me.TotalProducts_Label.Size = New System.Drawing.Size(64, 17)
        Me.TotalProducts_Label.TabIndex = 2
        Me.TotalProducts_Label.Text = "Products"
        '
        'Alert_Label
        '
        Me.Alert_Label.AutoSize = True
        Me.Alert_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alert_Label.Location = New System.Drawing.Point(91, 47)
        Me.Alert_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Alert_Label.Name = "Alert_Label"
        Me.Alert_Label.Size = New System.Drawing.Size(43, 19)
        Me.Alert_Label.TabIndex = 2
        Me.Alert_Label.Text = "Alert"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1206, 959)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Label1"
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.SidePanel.Controls.Add(Me.PictureBox9)
        Me.SidePanel.Controls.Add(Me.PictureBox8)
        Me.SidePanel.Controls.Add(Me.PictureBox7)
        Me.SidePanel.Controls.Add(Me.PictureBox5)
        Me.SidePanel.Controls.Add(Me.PictureBox2)
        Me.SidePanel.Controls.Add(Me.PictureBox3)
        Me.SidePanel.Controls.Add(Me.PictureBox1)
        Me.SidePanel.Controls.Add(Me.Panel3)
        Me.SidePanel.Controls.Add(Me.Panel2)
        Me.SidePanel.Controls.Add(Me.LogoutBtn)
        Me.SidePanel.Controls.Add(Me.AddCategoryBtn)
        Me.SidePanel.Controls.Add(Me.SalesBtn)
        Me.SidePanel.Controls.Add(Me.ShowStockBtn)
        Me.SidePanel.Controls.Add(Me.ManageCustomerBtn)
        Me.SidePanel.Controls.Add(Me.DashboardBtn)
        Me.SidePanel.Controls.Add(Me.Stockbtn)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SidePanel.Location = New System.Drawing.Point(0, 24)
        Me.SidePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(375, 952)
        Me.SidePanel.TabIndex = 4
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(42, 499)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(46, 40)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 6
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(43, 597)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(46, 40)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 5
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(50, 389)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(46, 40)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 4
        Me.PictureBox7.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(50, 183)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 36)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(45, 716)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(47, 281)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(46, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(48, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(46, 327)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(71, 94)
        Me.Panel3.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Controls.Add(Me.UpdateBtn)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.AddBtn)
        Me.Panel2.Location = New System.Drawing.Point(46, 327)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(324, 94)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(75, 51)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(40, 36)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 2
        Me.PictureBox6.TabStop = False
        '
        'UpdateBtn
        '
        Me.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.UpdateBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.UpdateBtn.Location = New System.Drawing.Point(69, 45)
        Me.UpdateBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(255, 49)
        Me.UpdateBtn.TabIndex = 1
        Me.UpdateBtn.Text = "Update Stock"
        Me.UpdateBtn.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(75, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 36)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.AddBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.AddBtn.Location = New System.Drawing.Point(69, 0)
        Me.AddBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(255, 49)
        Me.AddBtn.TabIndex = 0
        Me.AddBtn.Text = "Add Stock"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'LogoutBtn
        '
        Me.LogoutBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.LogoutBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.LogoutBtn.Location = New System.Drawing.Point(39, 709)
        Me.LogoutBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(253, 49)
        Me.LogoutBtn.TabIndex = 0
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.UseVisualStyleBackColor = False
        '
        'AddCategoryBtn
        '
        Me.AddCategoryBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.AddCategoryBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.AddCategoryBtn.Location = New System.Drawing.Point(39, 495)
        Me.AddCategoryBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.AddCategoryBtn.Name = "AddCategoryBtn"
        Me.AddCategoryBtn.Size = New System.Drawing.Size(253, 49)
        Me.AddCategoryBtn.TabIndex = 0
        Me.AddCategoryBtn.Text = "Add a Category"
        Me.AddCategoryBtn.UseVisualStyleBackColor = False
        '
        'SalesBtn
        '
        Me.SalesBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.SalesBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.SalesBtn.Location = New System.Drawing.Point(39, 593)
        Me.SalesBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SalesBtn.Name = "SalesBtn"
        Me.SalesBtn.Size = New System.Drawing.Size(253, 49)
        Me.SalesBtn.TabIndex = 0
        Me.SalesBtn.Text = "Checkout"
        Me.SalesBtn.UseVisualStyleBackColor = False
        '
        'ShowStockBtn
        '
        Me.ShowStockBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ShowStockBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.ShowStockBtn.Location = New System.Drawing.Point(46, 385)
        Me.ShowStockBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ShowStockBtn.Name = "ShowStockBtn"
        Me.ShowStockBtn.Size = New System.Drawing.Size(253, 49)
        Me.ShowStockBtn.TabIndex = 0
        Me.ShowStockBtn.Text = "Show Stock"
        Me.ShowStockBtn.UseVisualStyleBackColor = False
        '
        'ManageCustomerBtn
        '
        Me.ManageCustomerBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ManageCustomerBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.ManageCustomerBtn.Location = New System.Drawing.Point(43, 176)
        Me.ManageCustomerBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ManageCustomerBtn.Name = "ManageCustomerBtn"
        Me.ManageCustomerBtn.Size = New System.Drawing.Size(253, 49)
        Me.ManageCustomerBtn.TabIndex = 0
        Me.ManageCustomerBtn.Text = "Transactions"
        Me.ManageCustomerBtn.UseVisualStyleBackColor = False
        '
        'DashboardBtn
        '
        Me.DashboardBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DashboardBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.DashboardBtn.Location = New System.Drawing.Point(43, 76)
        Me.DashboardBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.DashboardBtn.Name = "DashboardBtn"
        Me.DashboardBtn.Size = New System.Drawing.Size(253, 49)
        Me.DashboardBtn.TabIndex = 0
        Me.DashboardBtn.Text = "Dashboard"
        Me.DashboardBtn.UseVisualStyleBackColor = False
        '
        'Stockbtn
        '
        Me.Stockbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Stockbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Stockbtn.Location = New System.Drawing.Point(43, 277)
        Me.Stockbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.Stockbtn.Name = "Stockbtn"
        Me.Stockbtn.Size = New System.Drawing.Size(253, 49)
        Me.Stockbtn.TabIndex = 0
        Me.Stockbtn.Text = "Manage Stock"
        Me.Stockbtn.UseVisualStyleBackColor = False
        '
        'TotalProducts_Grpbox
        '
        Me.TotalProducts_Grpbox.Controls.Add(Me.TotalProducts_Label)
        Me.TotalProducts_Grpbox.Controls.Add(Me.TotalProduct_Label)
        Me.TotalProducts_Grpbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalProducts_Grpbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.TotalProducts_Grpbox.Location = New System.Drawing.Point(47, 180)
        Me.TotalProducts_Grpbox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalProducts_Grpbox.Name = "TotalProducts_Grpbox"
        Me.TotalProducts_Grpbox.Padding = New System.Windows.Forms.Padding(4)
        Me.TotalProducts_Grpbox.Size = New System.Drawing.Size(367, 219)
        Me.TotalProducts_Grpbox.TabIndex = 5
        Me.TotalProducts_Grpbox.TabStop = False
        Me.TotalProducts_Grpbox.Text = "Total Products"
        '
        'TotalProduct_Label
        '
        Me.TotalProduct_Label.AutoSize = True
        Me.TotalProduct_Label.Location = New System.Drawing.Point(273, 97)
        Me.TotalProduct_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalProduct_Label.Name = "TotalProduct_Label"
        Me.TotalProduct_Label.Size = New System.Drawing.Size(51, 17)
        Me.TotalProduct_Label.TabIndex = 3
        Me.TotalProduct_Label.Text = "Label1"
        '
        'StockAlert_GrpBox
        '
        Me.StockAlert_GrpBox.Controls.Add(Me.Alert_Label)
        Me.StockAlert_GrpBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.StockAlert_GrpBox.Location = New System.Drawing.Point(452, 183)
        Me.StockAlert_GrpBox.Margin = New System.Windows.Forms.Padding(4)
        Me.StockAlert_GrpBox.Name = "StockAlert_GrpBox"
        Me.StockAlert_GrpBox.Padding = New System.Windows.Forms.Padding(4)
        Me.StockAlert_GrpBox.Size = New System.Drawing.Size(389, 216)
        Me.StockAlert_GrpBox.TabIndex = 6
        Me.StockAlert_GrpBox.TabStop = False
        Me.StockAlert_GrpBox.Text = "Stock Alert"
        '
        'RecentTraction_GrpBox
        '
        Me.RecentTraction_GrpBox.Controls.Add(Me.RecentInventory)
        Me.RecentTraction_GrpBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.RecentTraction_GrpBox.Location = New System.Drawing.Point(432, 448)
        Me.RecentTraction_GrpBox.Name = "RecentTraction_GrpBox"
        Me.RecentTraction_GrpBox.Size = New System.Drawing.Size(747, 276)
        Me.RecentTraction_GrpBox.TabIndex = 7
        Me.RecentTraction_GrpBox.TabStop = False
        Me.RecentTraction_GrpBox.Text = "Recent Transaction"
        '
        'RecentInventory
        '
        Me.RecentInventory.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RecentInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecentInventory.Location = New System.Drawing.Point(0, 29)
        Me.RecentInventory.Name = "RecentInventory"
        Me.RecentInventory.ReadOnly = True
        Me.RecentInventory.RowTemplate.Height = 28
        Me.RecentInventory.Size = New System.Drawing.Size(745, 247)
        Me.RecentInventory.TabIndex = 0
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'DateTime
        '
        Me.DateTime.Name = "DateTime"
        Me.DateTime.Size = New System.Drawing.Size(119, 17)
        Me.DateTime.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.DateTime, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 976)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1257, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Blink
        '
        Me.Blink.Enabled = True
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.MainPanel.Controls.Add(Me.StockAlert_GrpBox)
        Me.MainPanel.Controls.Add(Me.RecentTraction_GrpBox)
        Me.MainPanel.Controls.Add(Me.TotalProducts_Grpbox)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.ForeColor = System.Drawing.Color.Black
        Me.MainPanel.Location = New System.Drawing.Point(375, 24)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(882, 952)
        Me.MainPanel.TabIndex = 8
        '
        'buttoncloser_timer
        '
        Me.buttoncloser_timer.Interval = 1000
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Dashboard"
        Me.Text = "My Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SidePanel.ResumeLayout(False)
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TotalProducts_Grpbox.ResumeLayout(False)
        Me.TotalProducts_Grpbox.PerformLayout()
        Me.StockAlert_GrpBox.ResumeLayout(False)
        Me.StockAlert_GrpBox.PerformLayout()
        Me.RecentTraction_GrpBox.ResumeLayout(False)
        CType(Me.RecentInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MainPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Settings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer_DateTime As System.Windows.Forms.Timer
    Friend WithEvents TotalProducts_Label As System.Windows.Forms.Label
    Friend WithEvents Alert_Label As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DashboardBtn As System.Windows.Forms.Button
    Friend WithEvents LogoutBtn As System.Windows.Forms.Button
    Friend WithEvents SalesBtn As System.Windows.Forms.Button
    Friend WithEvents ShowStockBtn As System.Windows.Forms.Button
    Friend WithEvents Stockbtn As System.Windows.Forms.Button
    Friend WithEvents UpdateBtn As System.Windows.Forms.Button
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents TotalProducts_Grpbox As System.Windows.Forms.GroupBox
    Friend WithEvents StockAlert_GrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents RecentTraction_GrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DateTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents RecentInventory As System.Windows.Forms.DataGridView
    Friend WithEvents Blink As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ManageCustomerBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SidePanel As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents buttoncloser_timer As System.Windows.Forms.Timer
    Friend WithEvents AddCategoryBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents EditStoreDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddDiscountCouponsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalProduct_Label As System.Windows.Forms.Label
End Class
