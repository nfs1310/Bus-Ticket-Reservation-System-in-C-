using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus_ticket
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            password_txt.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        string login_username, login_pass;
        private void login_btn_Click(object sender, EventArgs e)
        {
            login_username = username_txt.Text;
            login_pass = password_txt.Text;

            GetConnectionString connect = new GetConnectionString();
            string connectString = connect.getString();

            SqlConnection con = new SqlConnection(connectString);

            string query = "SELECT Username, Password FROM [UserInfo] WHERE Username = '" + login_username + "' AND Password = '" + login_pass + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            cmd.ExecuteNonQuery();
            
            string db_user = string.Empty;
            db_user = (string)cmd.ExecuteScalar();
            con.Close();

            if (string.IsNullOrEmpty(db_user))
            {
                MessageBox.Show("Wrong Username or Password...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username_txt.Text = "";
                password_txt.Text = "";
            }
            else
            {
                this.Hide();
                UserHome uh = new UserHome(login_username);
                uh.Show();
                this.Hide();
            }
            
        }

        private void cncl_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
