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
    public partial class UserBooking : Form
    {
        string username;
        public UserBooking(string user)
        {
            InitializeComponent();
            bookdateTimePicker.Value = DateTime.Now;
            username = user;
            id_txt.Text = getUserId();
        }

        string getUserId()
        {
            GetConnectionString gtc = new GetConnectionString();
            string connectString = gtc.getString();
            SqlConnection con = new SqlConnection(connectString);

            string query = "SELECT UserId FROM [UserInfo] WHERE Username = '" + username + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            cmd.ExecuteNonQuery();
            string userId = cmd.ExecuteScalar().ToString();
            con.Close();

            return userId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {

        }

        private void Browse_btn_Click(object sender, EventArgs e)
        {
            SeatSelection ss = new SeatSelection();
            ss.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            frm_combo.Items.Clear();
            to_combo.Items.Clear();

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
                frm_combo.Items.Add(sdr_frm["LocationFrom"]);
            }

            string query_to = "SELECT DISTINCT LocationTo FROM [FairList] ORDER BY LocationTo";
            SqlCommand cmd_to = new SqlCommand(query_to, con);
            cmd_to.CommandType = CommandType.Text;

            con.Close();

            con.Open();
            SqlDataReader sdr_to = cmd_to.ExecuteReader();

            while (sdr_to.Read())
            {
                to_combo.Items.Add(sdr_to["LocationTo"]);
            }
            con.Close();
        }

        static int counttbl = getCount();

        static int getCount()
        {
            GetConnectionString gtc = new GetConnectionString();
            string connectString = gtc.getString();
            SqlConnection con = new SqlConnection(connectString);

            string query = "SELECT count(*) FROM [BookTicket]";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            cmd.ExecuteNonQuery();
            Int32 count = (Int32)cmd.ExecuteScalar();
            con.Close();

            return count;
        }

        string seatNum;
        public string getSeat(string number)
        {
            seatNum = number;
            return seatNum;
        }

        private void confirm_btn_Click_1(object sender, EventArgs e)
        {
            string bookingId = "B_" + counttbl++;
            string userId = getUserId();
            string from = frm_combo.Text;
            string to = to_combo.Text;

            string inputDate = bookdateTimePicker.Value.ToShortDateString();
            //string inputTime = bookdateTimePicker.Value.ToShortTimeString();
            //MessageBox.Show("USER:  " + getUserId() + "\nDATE SELECTED:  " + inputDate + "\nTime :  " + inputTime + "\nFROM:  " + from + "\nTO:  " + to + "\nSEAT:  ");

            GetConnectionString gtc = new GetConnectionString();
            string connectString = gtc.getString();
            SqlConnection con = new SqlConnection(connectString);

            string query = "INSERT INTO [BookTicket] VALUES ('" + bookingId + "','" + userId + "','" + from + "','" + to + "','" + inputDate + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Ticket booked successfully...!!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bookdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
        }

        private void UserBooking_Load(object sender, EventArgs e)
        {

        }

        private void UserBooking_Load_1(object sender, EventArgs e)
        {

        }

        private void UserBooking_Load_2(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
