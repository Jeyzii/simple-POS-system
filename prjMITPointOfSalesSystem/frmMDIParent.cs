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
    public partial class frmMDIParent : Form
    {
        public frmMDIParent(String username)
        {
            InitializeComponent();
            mnuUsername.Text = username.Trim();
        }
        DialogResult drCancelMDI = new DialogResult();
       
        private void mnuUserAccounts_Click(object sender, EventArgs e)
        {
            frmUserAccounts frmUserAccts = new frmUserAccounts();
            frmUserAccts.MdiParent = this;
            frmUserAccts.Show();
        }

        private void mnuLogOut_Click(object sender, EventArgs e)
        {
            drCancelMDI = MessageBox.Show("Do you really want to close the system?", "Cancel Log-in", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drCancelMDI == DialogResult.Yes)
            {
                this.Close();
                Thread tLogin = new Thread(OpenLogIn);
                tLogin.Start();
            }
            
        }
        public void OpenLogIn()
        {
            Application.Run(new frmLogIn(false));
        }

        private void mnuPOST_Click(object sender, EventArgs e)
        {
            MessageBox.Show("POS Terminal still has problem.", "Under Maintenance");
            frmPointOfSalesTerminal frmPOST = new frmPointOfSalesTerminal(mnuUsername.Text);
            frmPOST.MdiParent = this;
            frmPOST.Show();
        }
    }
}