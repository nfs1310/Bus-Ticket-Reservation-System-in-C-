﻿using System;
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
    public partial class UserSchedule : Form
    {
        string user;
        public UserSchedule( string userName)
        {
            InitializeComponent();
            user = userName;
            load_table();
        }

        string getUserId()
        {
            GetConnectionString gtc = new GetConnectionString();
            string connectString = gtc.getString();
            SqlConnection con = new SqlConnection(connectString);

            string query = "SELECT UserId FROM [UserInfo] WHERE Username = '" + user + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            cmd.ExecuteNonQuery();
            string userIdNo = cmd.ExecuteScalar().ToString();
            con.Close();

            return userIdNo;
        }

        void load_table()
        {
            string usersId = getUserId();
            GetConnectionString connect = new GetConnectionString();
            string connectString = connect.getString();

            SqlConnection con = new SqlConnection(connectString);

            string query = "SELECT * FROM [BookTicket] WHERE UserId = '" + usersId + "'";
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
            userScheduleGrid.DataSource = bsrc;
            sda.Update(dbdataset);

            con.Close();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
