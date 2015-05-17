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
    public partial class AdminPanel : Form
    {
        public AdminPanel( string admin)
        {
            InitializeComponent();
            admin_lbl.Text = "Hello " + admin;
        }

        private void adnewfair_btn_Click(object sender, EventArgs e)
        {
            NewFair nf = new NewFair();
            nf.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void admin_lbl_Click(object sender, EventArgs e)
        {

        }

        private void adminlist_btn_Click(object sender, EventArgs e)
        {
            AllAdminList aal = new AllAdminList();
            aal.Show();
        }

        private void userlist_btn_Click(object sender, EventArgs e)
        {
            AllUserList aul = new AllUserList();
            aul.Show();
        }
    }
}
