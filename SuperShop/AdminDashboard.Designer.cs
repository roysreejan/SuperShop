
namespace SuperShop
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.purchasepricelabel = new System.Windows.Forms.Label();
            this.Priceadmin = new System.Windows.Forms.TextBox();
            this.AdminAddproductpanel = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Sellprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Istock = new System.Windows.Forms.TextBox();
            this.addedbuttoninventory = new System.Windows.Forms.Button();
            this.ProductCata = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.CustomerNameTextboxSales = new System.Windows.Forms.TextBox();
            this.admindashsearchicon = new System.Windows.Forms.Panel();
            this.csearch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.pnsearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.productid = new System.Windows.Forms.Label();
            this.pidSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_load = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.AdminAddproductpanel.SuspendLayout();
            this.admindashsearchicon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // purchasepricelabel
            // 
            this.purchasepricelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.purchasepricelabel.AutoSize = true;
            this.purchasepricelabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasepricelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.purchasepricelabel.Location = new System.Drawing.Point(14, 105);
            this.purchasepricelabel.Name = "purchasepricelabel";
            this.purchasepricelabel.Size = new System.Drawing.Size(85, 17);
            this.purchasepricelabel.TabIndex = 14;
            this.purchasepricelabel.Text = "BuyingPrice:";
            // 
            // Priceadmin
            // 
            this.Priceadmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Priceadmin.Location = new System.Drawing.Point(123, 104);
            this.Priceadmin.Name = "Priceadmin";
            this.Priceadmin.Size = new System.Drawing.Size(274, 20);
            this.Priceadmin.TabIndex = 13;
            // 
            // AdminAddproductpanel
            // 
            this.AdminAddproductpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminAddproductpanel.BackColor = System.Drawing.Color.Cyan;
            this.AdminAddproductpanel.Controls.Add(this.comboBox2);
            this.AdminAddproductpanel.Controls.Add(this.label4);
            this.AdminAddproductpanel.Controls.Add(this.Sellprice);
            this.AdminAddproductpanel.Controls.Add(this.label5);
            this.AdminAddproductpanel.Controls.Add(this.Istock);
            this.AdminAddproductpanel.Controls.Add(this.addedbuttoninventory);
            this.AdminAddproductpanel.Controls.Add(this.purchasepricelabel);
            this.AdminAddproductpanel.Controls.Add(this.Priceadmin);
            this.AdminAddproductpanel.Controls.Add(this.ProductCata);
            this.AdminAddproductpanel.Controls.Add(this.ProductName);
            this.AdminAddproductpanel.Controls.Add(this.CustomerNameTextboxSales);
            this.AdminAddproductpanel.Location = new System.Drawing.Point(224, 58);
            this.AdminAddproductpanel.Name = "AdminAddproductpanel";
            this.AdminAddproductpanel.Size = new System.Drawing.Size(643, 173);
            this.AdminAddproductpanel.TabIndex = 27;
            this.AdminAddproductpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminAddproductpanel_Paint);
            // 
            // comboBox2
            // 
            this.comboBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.comboBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "GROCERY",
            "FRUITS",
            "COSMETICS",
            "SPICIES",
            "DAIRY",
            "DRINKS",
            "TOILETRIES"});
            this.comboBox2.Location = new System.Drawing.Point(123, 50);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(274, 21);
            this.comboBox2.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(11, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Selling Price:";
            // 
            // Sellprice
            // 
            this.Sellprice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sellprice.Location = new System.Drawing.Point(123, 130);
            this.Sellprice.Name = "Sellprice";
            this.Sellprice.Size = new System.Drawing.Size(274, 20);
            this.Sellprice.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(14, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Initial Stock:";
            // 
            // Istock
            // 
            this.Istock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Istock.Location = new System.Drawing.Point(123, 78);
            this.Istock.Name = "Istock";
            this.Istock.Size = new System.Drawing.Size(274, 20);
            this.Istock.TabIndex = 19;
            this.Istock.TextChanged += new System.EventHandler(this.Istock_TextChanged);
            // 
            // addedbuttoninventory
            // 
            this.addedbuttoninventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addedbuttoninventory.BackColor = System.Drawing.Color.Aquamarine;
            this.addedbuttoninventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addedbuttoninventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addedbuttoninventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addedbuttoninventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addedbuttoninventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedbuttoninventory.ForeColor = System.Drawing.Color.Black;
            this.addedbuttoninventory.Location = new System.Drawing.Point(490, 49);
            this.addedbuttoninventory.Name = "addedbuttoninventory";
            this.addedbuttoninventory.Size = new System.Drawing.Size(130, 48);
            this.addedbuttoninventory.TabIndex = 17;
            this.addedbuttoninventory.Text = "Add Inventory";
            this.addedbuttoninventory.UseVisualStyleBackColor = false;
            this.addedbuttoninventory.Click += new System.EventHandler(this.addedbuttoninventory_Click);
            // 
            // ProductCata
            // 
            this.ProductCata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProductCata.AutoSize = true;
            this.ProductCata.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCata.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductCata.Location = new System.Drawing.Point(11, 52);
            this.ProductCata.Name = "ProductCata";
            this.ProductCata.Size = new System.Drawing.Size(67, 17);
            this.ProductCata.TabIndex = 4;
            this.ProductCata.Text = "Catagory:";
            // 
            // ProductName
            // 
            this.ProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProductName.AutoSize = true;
            this.ProductName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductName.Location = new System.Drawing.Point(11, 26);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(100, 17);
            this.ProductName.TabIndex = 2;
            this.ProductName.Text = "Product Name:";
            // 
            // CustomerNameTextboxSales
            // 
            this.CustomerNameTextboxSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomerNameTextboxSales.Location = new System.Drawing.Point(123, 24);
            this.CustomerNameTextboxSales.Name = "CustomerNameTextboxSales";
            this.CustomerNameTextboxSales.Size = new System.Drawing.Size(274, 20);
            this.CustomerNameTextboxSales.TabIndex = 0;
            this.CustomerNameTextboxSales.TextChanged += new System.EventHandler(this.CustomerNameTextboxSales_TextChanged);
            // 
            // admindashsearchicon
            // 
            this.admindashsearchicon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admindashsearchicon.BackColor = System.Drawing.Color.Cyan;
            this.admindashsearchicon.Controls.Add(this.csearch);
            this.admindashsearchicon.Controls.Add(this.label6);
            this.admindashsearchicon.Controls.Add(this.Update);
            this.admindashsearchicon.Controls.Add(this.pnsearch);
            this.admindashsearchicon.Controls.Add(this.label3);
            this.admindashsearchicon.Controls.Add(this.label2);
            this.admindashsearchicon.Controls.Add(this.btnSearch);
            this.admindashsearchicon.Controls.Add(this.productid);
            this.admindashsearchicon.Controls.Add(this.pidSearch);
            this.admindashsearchicon.Location = new System.Drawing.Point(224, 263);
            this.admindashsearchicon.Name = "admindashsearchicon";
            this.admindashsearchicon.Size = new System.Drawing.Size(643, 114);
            this.admindashsearchicon.TabIndex = 28;
            this.admindashsearchicon.Paint += new System.Windows.Forms.PaintEventHandler(this.admindashsearchicon_Paint);
            // 
            // csearch
            // 
            this.csearch.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.csearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.csearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.csearch.FormattingEnabled = true;
            this.csearch.Items.AddRange(new object[] {
            "GROCERY",
            "FRUITS",
            "COSMETICS",
            "SPICIES",
            "DAIRY",
            "DRINKS",
            "TOILETRIES"});
            this.csearch.Location = new System.Drawing.Point(123, 79);
            this.csearch.Name = "csearch";
            this.csearch.Size = new System.Drawing.Size(274, 21);
            this.csearch.TabIndex = 33;
            this.csearch.SelectedIndexChanged += new System.EventHandler(this.csearch_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Catagory:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Aquamarine;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(529, 65);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(79, 31);
            this.Update.TabIndex = 31;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // pnsearch
            // 
            this.pnsearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnsearch.Location = new System.Drawing.Point(123, 45);
            this.pnsearch.Name = "pnsearch";
            this.pnsearch.Size = new System.Drawing.Size(274, 20);
            this.pnsearch.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(14, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 27;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(529, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 31);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // productid
            // 
            this.productid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.productid.AutoSize = true;
            this.productid.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productid.Location = new System.Drawing.Point(14, 18);
            this.productid.Name = "productid";
            this.productid.Size = new System.Drawing.Size(73, 15);
            this.productid.TabIndex = 2;
            this.productid.Text = "Product Id:";
            // 
            // pidSearch
            // 
            this.pidSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pidSearch.Location = new System.Drawing.Point(123, 13);
            this.pidSearch.Name = "pidSearch";
            this.pidSearch.Size = new System.Drawing.Size(274, 20);
            this.pidSearch.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cyan;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(224, 411);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(570, 214);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(800, 493);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 30);
            this.btn_load.TabIndex = 30;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.BackColor = System.Drawing.Color.Aquamarine;
            this.logoutbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbutton.Location = new System.Drawing.Point(38, 591);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(125, 35);
            this.logoutbutton.TabIndex = 31;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = false;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // btnremove
            // 
            this.btnremove.AutoSize = true;
            this.btnremove.BackColor = System.Drawing.Color.Aquamarine;
            this.btnremove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(38, 88);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(143, 22);
            this.btnremove.TabIndex = 32;
            this.btnremove.Text = "Remove Product";
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logoutbutton);
            this.panel1.Controls.Add(this.btnremove);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 652);
            this.panel1.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Aquamarine;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(431, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 33);
            this.label7.TabIndex = 34;
            this.label7.Text = "Super Shop";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.BackgroundImage = global::SuperShop.Properties.Resources.reduced;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 646);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.admindashsearchicon);
            this.Controls.Add(this.AdminAddproductpanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.AdminAddproductpanel.ResumeLayout(false);
            this.AdminAddproductpanel.PerformLayout();
            this.admindashsearchicon.ResumeLayout(false);
            this.admindashsearchicon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label purchasepricelabel;
        private System.Windows.Forms.TextBox Priceadmin;
        private System.Windows.Forms.Panel AdminAddproductpanel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Sellprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Istock;
        private System.Windows.Forms.Button addedbuttoninventory;
        private System.Windows.Forms.Label ProductCata;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.TextBox CustomerNameTextboxSales;
        private System.Windows.Forms.Panel admindashsearchicon;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label productid;
        private System.Windows.Forms.TextBox pidSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox pnsearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox csearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Label btnremove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}