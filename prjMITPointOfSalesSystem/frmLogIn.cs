using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace prjMITPointOfSalesSystem
{
    public partial class frmLogIn : Form
    {  
                        Thread th;
                        DialogResult drAns;
                        SqlConnection con;
                        bool cnn;
                        String cnnStr = "", username = "", password = "";
                        public frmLogIn(bool status)
                        {
                            cnnStr = "Data Source=PC-LOK\\SQLEXPRESS;Initial Catalog=dbPOSSystem;Integrated Security=True";
                            if (status)
                            {
                                Thread t = new Thread(new ThreadStart(StartForm));
                                t.Start();
                                Thread.Sleep(5000);
                                InitializeComponent();
                                t.Abort();
                            }
                            else
                            {
                                InitializeComponent();
                            }
                        }
        //METHODS SECTION
        public void StartForm()
        {
            Application.Run(new frmSplashScreen());
        }
        private void frmLogIn_Load(object sender, EventArgs e)
        {
            cnn = connectDB();
        }
        public bool connectDB()
        {
            con = new SqlConnection(cnnStr);

            try
            {
                con.Open();
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }
        public void openFrmMDIParent()
        {
            Application.Run(new frmMDIParent(username));
        }// end for thread MDIParent

        //END OF METHODS SECTIONS

        //EVENTS SECTION

            //Login button
        private void picLogInBtn_Click(object sender, EventArgs e)
        {
            if ((txtUser.Text == ""))
            {
                drAns = MessageBox.Show("Please enter the username", "Log-In failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (drAns == DialogResult.OK)
                {
                    txtUser.Focus();
                }
            }//end of if txtUser
            else if (txtUser.Text != "")
            {

                String searchQuery = "SELECT username, password FROM tblUserAccounts WHERE username = '" + txtUser.Text + "'";
                SqlDataAdapter dtaAdapter = new SqlDataAdapter(searchQuery, cnnStr);
                DataTable dtSearch = new DataTable();
                dtaAdapter.Fill(dtSearch);
                if (dtSearch.Rows.Count > 0)
                {
                    username = dtSearch.Rows[0][0].ToString();
                    password = (dtSearch.Rows[0][1].ToString()).Trim();

                    if (txtPass.Text == password)
                    {
                        DialogResult drLoginConfirmed = new DialogResult();
                        drLoginConfirmed = MessageBox.Show("Log-In Successful", "Log-In Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (drLoginConfirmed == DialogResult.OK)
                        {
                            this.Close();
                            th = new Thread(openFrmMDIParent);
                            th.Start();

                        }//end of if drloginconfirmed
                    }//end of if txtPass
                    else if (txtPass.Text == "")
                    {
                        drAns = MessageBox.Show("Please Enter your password", "Log-In Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (drAns == DialogResult.OK)
                        {
                            txtPass.Focus();
                        }//end of if drAns
                    }
                    else
                    {
                        drAns = MessageBox.Show("Username and/or password incorrect", "Log-In Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (drAns == DialogResult.OK)
                        {
                            txtUser.Clear();
                            txtPass.Clear();
                            txtUser.Focus();
                        }//emd of if drAns
                    }//end of else
                }//end of if dtsearch.rows.count
                else
                {
                    drAns = MessageBox.Show("No user found.", "Log-In Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (drAns == DialogResult.OK)
                    {
                        txtUser.Clear();
                        txtPass.Clear();
                        txtUser.Focus();
                    }//end of if drAns
                }//end of else

            }
        }// end of piclogin button 

        //cancel Button
        private void picCancelBtn_Click(object sender, EventArgs e)
        {
            drAns = MessageBox.Show("Do you really want to close the system?", "Cancel Log-in", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drAns == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else if (drAns == DialogResult.No)
            {
                picLogInBtn.Focus();
            }

        }//end cancel button

        //To reveal password
        private void chkShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowHide.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
                chkShowHide.Text = "Hide Password";
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                chkShowHide.Text = "Show Password";
            }
        }//end chkshowhide

        //END OF EVENTS SECTION
    } // end of class
} //end of namespace
