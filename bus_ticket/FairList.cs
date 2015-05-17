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
    public partial class FairList_user : Form
    {
        public FairList_user()
        {
            InitializeComponent();
            load_table();
        }


        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void load_table()
        {
            GetConnectionString connect = new GetConnectionString();
            string connectString = connect.getString();

            SqlConnection con = new SqlConnection(connectString);

            string query = "SELECT ListId, LocationFrom, LocationTo, Price FROM [FairList]";
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

        private void UserdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
