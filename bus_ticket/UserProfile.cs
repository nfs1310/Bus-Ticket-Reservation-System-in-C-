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
    public partial class UserProfile : Form
    {
        string logger_profile;
        public UserProfile(string user)
        {
            InitializeComponent();
            logger_profile = user;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cncl_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            GetConnectionString connect = new GetConnectionString();
            string connectString = connect.getString();

            SqlConnection con = new SqlConnection(connectString);

            string query = "SELECT * FROM [UserInfo] WHERE Username = '" + logger_profile + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            //cmd.CommandType = CommandType.Text;

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            // cmd.ExecuteNonQuery();

            if (sdr.Read())
            {

                //MessageBox.Show("name: " + sdr["Name"].ToString() + "\nemail: " + sdr["E-mail"] + "\nusername: " + sdr["Username"] + "\npassword:  " + sdr["password"]);
                name_txt.Text = sdr["Name"].ToString();
                email_txt.Text = sdr["E-mail"].ToString();
                username_txt.Text = sdr["Username"].ToString();
                pass_txt.Text = sdr["password"].ToString();
            }
            else
            {
                MessageBox.Show("Error Encounteres..!!!");
            }

           // string db_user = string.Empty;
            //db_user = (string)cmd.ExecuteScalar();
            con.Close();

        }
    }
}
