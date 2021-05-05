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
    public partial class RemoveProduct : Form
    {
        public RemoveProduct()
        {
            InitializeComponent();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }
        private void btnrmv_Click(object sender, EventArgs e)
        {
            int Product_Id;
            string ErrMsg = null;
            if (int.TryParse(pidtxt.Text, out Product_Id))
            {
                //ErrMsg += "\nValid Input";
            }
            else
            {
                ErrMsg += "Add Product Id!!!";
            }
            if (ErrMsg == null)
            {
                var conn = Database.ConnectDB();
                conn.Open();
                string query = string.Format("delete from Product where Product_Id ={0}", pidtxt.Text);
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

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void RemoveProduct_Load(object sender, EventArgs e)
        {
            var product = GetAllProduct();
            dataGridView1.DataSource = product;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard Admin = new AdminDashboard();
            Admin.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
