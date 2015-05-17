using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus_ticket
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new GuestMenu());
            //Application.Run(new RegisterMenu());
            //Application.Run(new SignIn());
            //Application.Run(new MainMenu());
            Application.Run(new TestLogin());
            //Application.Run(new Purchase());
            //Application.Run(new RouteDetail());
            //Application.Run(new FairList_user());
            //Application.Run(new NewFair());
           // Application.Run(new UserHome("afra.arpa"));
            //Application.Run(new UserBooking("arpa014"));
           // Application.Run(new AdminPanel("nfs1310"));

        }
    }
}
