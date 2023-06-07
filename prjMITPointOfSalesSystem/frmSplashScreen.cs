using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace prjMITPointOfSalesSystem
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }
        private void tmrSplashScreen_Tick(object sender, EventArgs e) // timer method
        {
            try
            {
                pnlProgressBarFill.Width += 1; //progress bar fill speed
                if (pnlProgressBarFill.Width >= 283)
                {
                    tmrSplashScreen.Stop(); // stop timer
                    this.Close(); // close splashscreen
                    Thread t = new Thread(startLogIn);
                    t.Start();
                }
            }
            catch (Exception)
            {
                return;
            }
           }//end of timer method
        public void startLogIn() // method for next login form
        {
            Application.Run(new frmLogIn(false)); // run login form
        }
    }//end of class
}//end of namespace
