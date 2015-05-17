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
    public partial class SignInAdmin : Form
    {
        public SignInAdmin()
        {
            InitializeComponent();
            password_txt.PasswordChar = '*';
        }

        string login_username, login_pass;
        private void login_btn_Click(object sender, EventArgs e)
        {
            login_username = username_txt.Text;
            login_pass = password_txt.Text;

            GetConnectionString connect = new GetConnectionString();
            string connectString = connect.getString();

            SqlConnection con = new SqlConnection(connectString);

            string query = "SELECT Username, Password FROM [AdminInfo] WHERE Username = '" + login_username + "' AND Password = '" + login_pass + "'";
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
                MessageBox.Show("Success...!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminPanel admin = new AdminPanel(login_username);
                admin.Show();
            }

            this.Hide();
        }

        private void cncl_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
