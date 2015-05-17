using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus_ticket
{
    public partial class UserHome : Form
    {
        string logged_user;
        public UserHome( string username)
        {
            InitializeComponent();
            logged_user = username;
            logger_lbl.Text = "Hello " + username;
        }

        private void Profile_Btn_Click(object sender, EventArgs e)
        {
            UserProfile up = new UserProfile( logged_user);
            up.Show();
        }

        private void Booking_Btn_Click(object sender, EventArgs e)
        {
            UserBooking ub = new UserBooking(logged_user);
            ub.Show();

        }

        private void Schedule_Btn_Click(object sender, EventArgs e)
        {
            UserSchedule us = new UserSchedule(logged_user);
            us.Show();


        }

        private void LogOut_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }

        private void UserHome_Load(object sender, EventArgs e)
        {

        }


        private void logger_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Btn_EnabledChanged(object sender, EventArgs e)
        {
        }

        private void logger_lbl_MouseHover(object sender, EventArgs e)
        {
        }
    }
}
