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
    public partial class GuestMenu : Form
    {
        public GuestMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkfairlist_Click(object sender, EventArgs e)
        {
            FairList_user flu = new FairList_user();
            flu.Show();
        }

        private void routedetail_btn_Click(object sender, EventArgs e)
        {
            RouteDetail rd = new RouteDetail();
            rd.Show();
        }

        private void register_Click(object sender, EventArgs e)
        {
            RegisterMenu rgm = new RegisterMenu();
            rgm.Show();
        }

        private void mainmenu_btn_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }
    }
}
