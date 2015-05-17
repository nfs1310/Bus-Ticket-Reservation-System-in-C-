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
    public partial class RegisterMenu : Form
    {
        public RegisterMenu()
        {
            InitializeComponent();
            pass_txt.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static int count = getCount();

        static int getCount()
        {
            GetConnectionString gtc = new GetConnectionString();
            string connectString = gtc.getString();
            SqlConnection con = new SqlConnection(connectString);

            string query = "SELECT count(*) FROM [UserInfo]";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            cmd.ExecuteNonQuery();
            Int32 count = (Int32)cmd.ExecuteScalar();
            con.Close();

            return count;
        }

        string name, email, username, password = null;
        private void Save_Click(object sender, EventArgs e)
        {
            int id = count + 1;
            string user_id = "U_" + id.ToString(); 
            name = name_txt.Text.ToUpper();
            email = email_txt.Text.ToUpper();
            username = username_txt.Text;
            password = pass_txt.Text;

            //Guid user_id = Guid.NewGuid();
            
            GetConnectionString connect = new GetConnectionString();
            string connectString = connect.getString();

            SqlConnection con = new SqlConnection(connectString);

            string query = "INSERT INTO [UserInfo] VALUES ('" + user_id + "','" + name + "','" + email + "','" + username + "','" + password + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Registration Successfull...!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            name_txt.Text = "";
            email_txt.Text = "";
            username_txt.Text = "";
            pass_txt.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RegisterMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
