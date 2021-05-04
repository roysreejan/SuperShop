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

namespace SuperShop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if(e.CloseReason!=CloseReason.WindowsShutDown)
            Application.Exit();
        }
        private void RoleSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string user_id = UserID_textBox.Text;
            string password = passwrodbox.Text;
            string role = RoleSelect.Text;
            string ErrMsg = null;
            if (RoleSelect.Text.Equals(""))
            {
                ErrMsg += "Invalid Role";
            }
            else
            {
                user_id = RoleSelect.Text;
            }
            if (UserID_textBox.Text.Equals(""))
            {
                ErrMsg += "\nUserName Required";
            }
            else
            {
                user_id = UserID_textBox.Text;
            }

            if (passwrodbox.Text.Equals(""))
            {
                ErrMsg += "\nPassword Required";
            }
            else
            {
                password = passwrodbox.Text;
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
                string query = string.Format("SELECT * FROM LOGIN WHERE USER_ID= '{0}'and ROLE='{1}'and PASSWORD='{2}'", user_id, role, password);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                {

                    if (reader.Read())
                    {
                        this.Hide();
                        MessageBox.Show("Login Successful");
                        new AdminDashboard().Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                    conn.Close();

                }
            }
            else
            {
                MessageBox.Show(ErrMsg);
            }

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
