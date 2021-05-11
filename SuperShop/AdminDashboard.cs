using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace SuperShop
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            var product = GetAllProduct();
            dataGridView1.DataSource = product;
        }

        private void CustomerNameTextboxSales_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminAddproductpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            var product = GetAllProduct();
            dataGridView1.DataSource = product;
        }
        List<Product> GetAllProduct()
        {
            var conn = Database.ConnectDB();
            List<Product> product = new List<Product>();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = "Select * from Product";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Product p = new Product();
                    p.Product_Id = reader.GetInt32(reader.GetOrdinal("Product_Id"));
                    p.Product_Name = reader.GetString(reader.GetOrdinal("Product_Name"));
                    p.Catagory = reader.GetString(reader.GetOrdinal("Catagory"));
                    p.Initial_Stock = reader.GetInt32(reader.GetOrdinal("Initial_Stock"));
                    p.Buying_Price = reader.GetInt32(reader.GetOrdinal("Buying_Price"));
                    p.Selling_Price = reader.GetInt32(reader.GetOrdinal("Selling_Price"));
                    product.Add(p);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return product;
        }

        private void addedbuttoninventory_Click(object sender, EventArgs e)
        {
            string product_name = CustomerNameTextboxSales.Text;
            string catagory = comboBox2.Text;
            int initial_stock;
            int buying_price;
            int selling_price;
            string ErrMsg = null;

            if (CustomerNameTextboxSales.Text.Equals(""))
            {
                ErrMsg += "Add Product Name!!!";
            }
            else
            {
                product_name = CustomerNameTextboxSales.Text;
            }
            if (comboBox2.Text.Equals(""))
            {
                ErrMsg += "\nAdd Catagory!!!";
            }
            else
            {
                catagory = comboBox2.Text;
            }
            
            if (int.TryParse(Istock.Text, out initial_stock))
            {
                //ErrMsg += "Valid Input";
            }
            else
            {
                ErrMsg += "\nAdd Initial Stock!!!";
            }
    
            if (int.TryParse(Priceadmin.Text, out buying_price))
            {
                //ErrMsg += "\nValid Input";
            }
            else
            {
                ErrMsg += "\nAdd Buying Price!!!";
            }
          
            if (int.TryParse(Sellprice.Text, out selling_price))
            {
                //ErrMsg += "\nValid Input";
            }
            else
            {
                ErrMsg += "\nAdd Selling Price!!!";
            }

            if (ErrMsg == null)
            {
                var conn = Database.ConnectDB();
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                string query = string.Format("insert into Product values ('{0}','{1}','{2}','{3}','{4}')", product_name, catagory, initial_stock, buying_price, selling_price);
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int r = cmd.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("Product Inserted");
                    }
                    else
                    {
                        MessageBox.Show("Insert Failed!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                var product = GetAllProduct();
                dataGridView1.DataSource = product;
            }
            else
            {
                MessageBox.Show(ErrMsg);
            }          

        }

        private void Istock_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conn = Database.ConnectDB();
            conn.Open();
            int Product_Id;
            string ErrMsg = null;
            if (int.TryParse(pidSearch.Text, out Product_Id))
            {
                //ErrMsg += "Valid Input";
            }
            else
            {
                ErrMsg += "\nAdd Product Id!!!";
            }
            if (ErrMsg == null)
            {
                string query = "select * from Product where Product_ID = " + Product_Id;
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                Product p = new Product();
                while (reader.Read())
                {
                    p.Product_Id = reader.GetInt32(reader.GetOrdinal("Product_Id"));
                    p.Product_Name = reader.GetString(reader.GetOrdinal("Product_Name"));
                    p.Catagory = reader.GetString(reader.GetOrdinal("Catagory"));

                }
                conn.Close();
                pnsearch.Text = p.Product_Name;
                csearch.Text = p.Catagory;
            }
            else
            {
                MessageBox.Show(ErrMsg);
            }

        }

        private void admindashsearchicon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            int Product_Id;
            string Product_Name = pnsearch.Text.Trim();
            string Catagory = csearch.Text.Trim();
            string ErrMsg = null;
            if (int.TryParse(pidSearch.Text, out Product_Id))
            {
                //ErrMsg += "\nValid Input";
            }
            else
            {
                ErrMsg += "Add Product Id!!!";
            }
            if (pnsearch.Text.Equals(""))
            {
                ErrMsg += "\nAdd Product Name!!!";
            }
            else
            {
                Product_Name = pnsearch.Text;
            }
            if (csearch.Text.Equals(""))
            {
                ErrMsg += "\nAdd Catagory!!!";
            }
            else
            {
                Catagory = csearch.Text;
            }
            if (ErrMsg == null)
            {
                var conn = Database.ConnectDB();
                conn.Open();
                string query = string.Format("update Product set Product_Name='{0}',Catagory='{1}' where Product_ID={2}", Product_Name, Catagory, Product_Id);
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                var product = GetAllProduct();
                dataGridView1.DataSource = product;
            }
            else
            {
                MessageBox.Show(ErrMsg);
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            RemoveProduct rmv = new RemoveProduct();
            rmv.Show();
            this.Hide();
        }

        private void csearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
