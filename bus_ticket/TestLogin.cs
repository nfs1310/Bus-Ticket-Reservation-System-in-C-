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
    public partial class TestLogin : Form
    {
        public TestLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        string login_username, login_pass;
        private void login_btn_Click(object sender, EventArgs e)
        {
            login_username = username_txt.Text;
            login_pass = pass_txt.Text;

            //string connectString = "Data Source=OMI\SQLEXPRESS;Initial Catalog=BusTicket;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

            SqlConnection con = new SqlConnection(@"Data Source=OMI\SQLEXPRESS;Initial Catalog=BusTicket;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

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
                pass_txt.Text = "";
            }
            else
            {
                MessageBox.Show("Success...!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //AdminPanel admin = new AdminPanel(login_username);
                //admin.Show();
                username_txt.Text = "";
                pass_txt.Text = "";
            }

            //this.Hide();
        }
    }
}
