
namespace SuperShop
{
    partial class RemoveProduct
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
            this.btnremove = new System.Windows.Forms.Label();
            this.admindashsearchicon = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnrmv = new System.Windows.Forms.Button();
            this.productid = new System.Windows.Forms.Label();
            this.pidtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_load = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.admindashsearchicon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnremove
            // 
            this.btnremove.AutoSize = true;
            this.btnremove.BackColor = System.Drawing.Color.LawnGreen;
            this.btnremove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(79, 32);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(143, 22);
            this.btnremove.TabIndex = 33;
            this.btnremove.Text = "Remove Product";
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // admindashsearchicon
            // 
            this.admindashsearchicon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admindashsearchicon.BackColor = System.Drawing.Color.Cyan;
            this.admindashsearchicon.Controls.Add(this.label2);
            this.admindashsearchicon.Controls.Add(this.btnrmv);
            this.admindashsearchicon.Controls.Add(this.productid);
            this.admindashsearchicon.Controls.Add(this.pidtxt);
            this.admindashsearchicon.Location = new System.Drawing.Point(79, 87);
            this.admindashsearchicon.Name = "admindashsearchicon";
            this.admindashsearchicon.Size = new System.Drawing.Size(643, 65);
            this.admindashsearchicon.TabIndex = 34;
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
            // btnrmv
            // 
            this.btnrmv.BackColor = System.Drawing.Color.Aquamarine;
            this.btnrmv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrmv.Location = new System.Drawing.Point(507, 18);
            this.btnrmv.Name = "btnrmv";
            this.btnrmv.Size = new System.Drawing.Size(96, 31);
            this.btnrmv.TabIndex = 26;
            this.btnrmv.Text = "Remove";
            this.btnrmv.UseVisualStyleBackColor = false;
            this.btnrmv.Click += new System.EventHandler(this.btnrmv_Click);
            // 
            // productid
            // 
            this.productid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.productid.AutoSize = true;
            this.productid.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productid.Location = new System.Drawing.Point(14, 20);
            this.productid.Name = "productid";
            this.productid.Size = new System.Drawing.Size(73, 15);
            this.productid.TabIndex = 2;
            this.productid.Text = "Product Id:";
            // 
            // pidtxt
            // 
            this.pidtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pidtxt.Location = new System.Drawing.Point(122, 18);
            this.pidtxt.Name = "pidtxt";
            this.pidtxt.Size = new System.Drawing.Size(274, 20);
            this.pidtxt.TabIndex = 0;
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
            this.dataGridView1.Location = new System.Drawing.Point(79, 186);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(542, 167);
            this.dataGridView1.TabIndex = 35;
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(647, 257);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 30);
            this.btn_load.TabIndex = 36;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.BackColor = System.Drawing.Color.Aquamarine;
            this.logoutbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbutton.Location = new System.Drawing.Point(308, 386);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(125, 35);
            this.logoutbutton.TabIndex = 37;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = false;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LawnGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(612, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "Add Product";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RemoveProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuperShop.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.admindashsearchicon);
            this.Controls.Add(this.btnremove);
            this.Name = "RemoveProduct";
            this.Text = "RemoveProduct";
            this.Load += new System.EventHandler(this.RemoveProduct_Load);
            this.admindashsearchicon.ResumeLayout(false);
            this.admindashsearchicon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnremove;
        private System.Windows.Forms.Panel admindashsearchicon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnrmv;
        private System.Windows.Forms.Label productid;
        private System.Windows.Forms.TextBox pidtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Label label1;
    }
}