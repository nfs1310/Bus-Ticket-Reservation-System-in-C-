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
    public partial class RouteDetail : Form
    {
        public RouteDetail()
        {
            InitializeComponent();
            populate_list();
        }

        void populate_list() 
        {
            from_cbox.Items.Clear();
            to_cbox.Items.Clear();

            GetConnectionString connect = new GetConnectionString();
            string connectString = connect.getString();

            SqlConnection con = new SqlConnection(connectString);
            con.Open();

            string query_frm = "SELECT DISTINCT LocationFrom FROM [FairList] ORDER BY LocationFrom ASC";
            SqlCommand cmd_frm = new SqlCommand(query_frm, con);
            cmd_frm.CommandType = CommandType.Text;

            SqlDataReader sdr_frm = cmd_frm.ExecuteReader();

            while (sdr_frm.Read())
            {
                from_cbox.Items.Add(sdr_frm["LocationFrom"]);
            }

            string query_to = "SELECT DISTINCT LocationTo FROM [FairList] ORDER BY LocationTo";
            SqlCommand cmd_to = new SqlCommand(query_to, con);
            cmd_to.CommandType = CommandType.Text;

            con.Close();

            con.Open();
            SqlDataReader sdr_to = cmd_to.ExecuteReader();

            while (sdr_to.Read())
            {
                to_cbox.Items.Add(sdr_to["LocationTo"]);
            }
            con.Close();
        }

        string fromPlace, toPlace;
        private void go_btn_Click(object sender, EventArgs e)
        {
            if (fromPlace == toPlace)
            {
                MessageBox.Show("Current location and your Destination cannot be same...!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show("The path is valid. Check the FAIR LIST for more information.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            toPlace = to_cbox.Text;
        }

        private void from_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fromPlace = from_cbox.Text;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
