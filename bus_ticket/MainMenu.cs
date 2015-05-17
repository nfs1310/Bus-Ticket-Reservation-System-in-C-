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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void registeruser_Click(object sender, EventArgs e)
        {
            SignIn login = new SignIn();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Guest_btn_Click_1(object sender, EventArgs e)
        {
            GuestMenu gm = new GuestMenu();
            gm.Show();
            this.Hide();
        }

        private void Admin_btn_Click(object sender, EventArgs e)
        {
            SignInAdmin login_admin = new SignInAdmin();
            login_admin.Show();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
