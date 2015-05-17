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
    public partial class NewFair : Form
    {
        public NewFair()
        {
            InitializeComponent();
            load_table();
        }

        void load_table()
        {
            GetConnectionString connect = new GetConnectionString();
            string connectString = connect.getString();

            SqlConnection con = new SqlConnection(connectString);

            string query = "SELECT * FROM [FairList]";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;

            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);

            BindingSource bsrc = new BindingSource();
            bsrc.DataSource = dbdataset;
            UserdataGridView.DataSource = bsrc;
            sda.Update(dbdataset);

            con.Close();
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

        private void addnew_btn_Click(object sender, EventArgs e)
        {
            if ((from_txt.Text == "") && (to_txt.Text == "") && (price_txt.Text == ""))
            {
                MessageBox.Show("Enter Values to DELETE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string l_id = "F_" + count++;
                DateTime dt = DateTime.Now;

                GetConnectionString connect = new GetConnectionString();
                string connectString = connect.getString();

                SqlConnection con = new SqlConnection(connectString);

                string query = "INSERT INTO [FairList] VALUES ('" + l_id + "','" + from_txt.Text.ToUpper() + "','" + to_txt.Text.ToUpper() + "'," + price_txt.Text + ",'" + dt + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                load_table();
            }
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
