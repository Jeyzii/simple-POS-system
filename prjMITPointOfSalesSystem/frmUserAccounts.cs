using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient; //to use SQL classes

namespace prjMITPointOfSalesSystem
{
    public partial class frmUserAccounts : Form
    {
        String cnnStr; //var for connection string
        SqlConnection con; // Sqlconnection obj
        public frmUserAccounts()
        {
            InitializeComponent();
            cnnStr = "Data Source=PC-LOK\\SQLEXPRESS;Initial Catalog=dbPOSSystem;Integrated Security=True";//connection string
        }

        bool cnn; //boolean for connection

        private void frmUserAccounts_Load(object sender, EventArgs e)
        {
            cnn = connectDB();//bool variable stores status of database connection

            txtSearch.Focus();//to focus in txtsearch
            txtSearch.Select();//to highlight text in txtsearch

            if (cnn)//test if there is connection
            {
                string query = "SELECT userID, userType, username, firstname, lastname FROM tblUserAccounts";
                SqlDataAdapter dtaAdapter = new SqlDataAdapter(query, cnnStr);
                DataSet ds = new DataSet();
                dtaAdapter.Fill(ds, "tblUsers");
                dgvUserAccounts.DataSource = ds;
                dgvUserAccounts.DataMember = "tblUsers";
            }
            else//if there is no connection
            {
                MessageBox.Show("Database was not connected.");//notifies user
            }
        }

        //METHODS SECTION

        public bool connectDB()//used to establish database connection
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

        private bool saveRecord()
        {
            try
            {
                String insertRecQuery = "INSERT INTO tblUserAccounts VALUES ('" + txtUserID.Text + "', '" + cboUserType.Text
                                        + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtFirstname.Text
                                        + "','" + txtLastname.Text + "', '" + cboPosition.Text + "','" + txtEmail.Text + "')";

                SqlDataAdapter dtaAdapter = new SqlDataAdapter(insertRecQuery, cnnStr);
                DataTable dtInsert = new DataTable();
                dtaAdapter.Fill(dtInsert);

                String viewInsertRecQuery = "SELECT userID, userType, username, firstname,lastname FROM tblUserAccounts";
                dtaAdapter = new SqlDataAdapter(viewInsertRecQuery, cnnStr);
                DataTable dtViewInsert = new DataTable();
                dtaAdapter.Fill(dtViewInsert);
                dgvUserAccounts.DataSource = dtViewInsert;
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }

        private String assignNewUserID()
        {
            String getUserIDQuery = "SELECT userID FROM tblUserAccounts ORDER BY userID DESC";

            SqlDataAdapter dtaDAdapter = new SqlDataAdapter(getUserIDQuery, cnnStr);
            DataTable dtGetUserID = new DataTable();
            dtaDAdapter.Fill(dtGetUserID);
            int newUserID;
            String newUserID4D = "";

            if (dtGetUserID.Rows.Count > 0)
            {
                newUserID = Convert.ToInt32(dtGetUserID.Rows[0][0].ToString());
                newUserID += 1;
                newUserID4D = newUserID.ToString("D4");
            }
            return newUserID4D;
        }

        private void enableControls()
        {
            txtUserID.Enabled = false;
            cboUserType.Focus();
            cboUserType.Enabled = true;
            txtUsername.Enabled = true;
            txtPassword.Enabled = false;
            txtFirstname.Enabled = true;
            txtLastname.Enabled = true;
            cboPosition.Enabled = true;
            txtEmail.Enabled = true;
        }

        private void makeValueControlEmpty()
        {
            txtUserID.Clear();
            cboUserType.SelectedIndex = -1;
            cboUserType.Text = "";
            txtUsername.Clear();
            txtPassword.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            cboPosition.SelectedIndex = -1;
            cboPosition.Text = "";
            txtEmail.Clear();
        }

        //TO GENERATE RANDOM PASSWORD METHODS SECTION

        public string passGenerator()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(randomString(4, true));
            builder.Append(randomNumber(1000, 9999));
            builder.Append(randomString(2, false));
            return builder.ToString();
        }

        public string randomString(int size, bool lowercase)
        {
            StringBuilder builder = new StringBuilder();

            Random random = new Random();
            char ch;

            for (int i = 0; i < size; i++)
            {
                Double temp = random.NextDouble();
                //TextBox1.Text = temp.ToString();
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * temp + 65)));
                builder.Append(ch);
            }

            if (lowercase)
            {
                return builder.ToString().ToLower();
            }
            return builder.ToString();
        }

        public int randomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        //END OF GENERATING RANDOM PASSWORD METHODS SECTION

        private void makeDefaultControls()
        {
            txtSearch.Focus();
            txtSearch.Text = "[SearchText]";
            txtSearch.Select();
            txtUserID.Enabled = false;
            cboUserType.Enabled = false;
            cboUserType.DropDownStyle = ComboBoxStyle.DropDown;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            txtFirstname.Enabled = false;
            txtLastname.Enabled = false;
            cboPosition.Enabled = false;
            cboPosition.DropDownStyle = ComboBoxStyle.DropDown;
            txtEmail.Enabled = false;

            btnAdd.Text = "Add";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;

            String searchQuery = "SELECT userID,userType,username,firstname,lastname FROM tblUserAccounts ";
            SqlDataAdapter dtaAdapter = new SqlDataAdapter(searchQuery, cnnStr);
            DataTable dtaSearch = new DataTable();
            dtaAdapter.Fill(dtaSearch);
            dgvUserAccounts.DataSource = dtaSearch;
        }

        private bool saveUpdateRecord()
        {
            try
            {
                String updateRecQuery = "UPDATE tblUserAccounts SET userID = '" + txtUserID.Text + "', userType = '" + cboUserType.Text + "', username = '" + txtUsername.Text
                                                                                + "', firstname = '" + txtFirstname.Text + "', lastname = '" + txtLastname.Text
                                                                                + "', position = '" + cboPosition.Text + "', email = '" + txtEmail.Text
                                                                                + "' WHERE userID = '" + txtUserID.Text + "'";
                SqlDataAdapter dtaAdapter = new SqlDataAdapter(updateRecQuery, cnnStr);
                DataTable dtUpdate = new DataTable();
                dtaAdapter.Fill(dtUpdate);

                String viewUpdateRecQuery = "SELECT userID, userType, username, firstname, lastname FROM tblUserAccounts";
                dtaAdapter = new SqlDataAdapter(viewUpdateRecQuery, cnnStr);
                DataTable dtViewUpdated = new DataTable();
                dtaAdapter.Fill(dtViewUpdated);
                dgvUserAccounts.DataSource = dtViewUpdated;
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }

        private bool deleteRecord()
        {
            try
            {
                String deleteRecQuery = "DELETE FROM tblUserAccounts WHERE userID = '" + txtUserID.Text + "'";
                SqlDataAdapter dtaAdapter = new SqlDataAdapter(deleteRecQuery, cnnStr);
                DataTable dtDelete = new DataTable();
                dtaAdapter.Fill(dtDelete);

                String viewUpdateRecQuery = "SELECT userID,userType, username, firstname, lastname FROM tblUserAccounts";
                dtaAdapter = new SqlDataAdapter(viewUpdateRecQuery, cnnStr);
                DataTable dtViewUpdated = new DataTable();
                dtaAdapter.Fill(dtViewUpdated);
                dgvUserAccounts.DataSource = dtViewUpdated;

            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }
        // END OF METHODS SECTION


        //EVENTS SECTION
        private void dgvUserAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string userID;//use to store current userID in dgvUserAccounts

            if (dgvUserAccounts.SelectedRows.Count > 0)
            {
                userID = dgvUserAccounts.SelectedRows[0].Cells[0].Value + string.Empty; // stores userID displayed in dgvUserAccounts

                String clickQuery = "SELECT * FROM tblUserAccounts WHERE userID LIKE '" + userID + "%'";
                SqlDataAdapter dtaAdapter = new SqlDataAdapter(clickQuery, cnnStr);
                DataTable dtClick = new DataTable();
                dtaAdapter.Fill(dtClick);

                txtUserID.Text = dtClick.Rows[0][0].ToString();
                cboUserType.DropDownStyle = ComboBoxStyle.DropDown;
                cboUserType.Text = dtClick.Rows[0][1].ToString();
                txtUsername.Text = dtClick.Rows[0][2].ToString();
                txtPassword.Text = dtClick.Rows[0][3].ToString();
                txtFirstname.Text = dtClick.Rows[0][4].ToString();
                txtLastname.Text = dtClick.Rows[0][5].ToString();
                cboPosition.DropDownStyle = ComboBoxStyle.DropDown;
                cboPosition.Text = dtClick.Rows[0][6].ToString();
                txtEmail.Text = dtClick.Rows[0][7].ToString();

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

            }
        }

        private void frmUserAccounts_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cnn)//if has a connection
            {
                con.Close();//end connection
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String searchQuery = "SELECT userID, userType, username, firstname, lastname FROM tblUserAccounts WHERE username LIKE'" + txtSearch.Text + "%'";
            SqlDataAdapter dtaAdapter = new SqlDataAdapter(searchQuery, cnnStr);
            DataTable dtSearch = new DataTable();
            dtaAdapter.Fill(dtSearch);
            dgvUserAccounts.DataSource = dtSearch;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                String searchQuery = "SELECT userID, userType, username, firstname, lastname FROM tblUserAccounts WHERE username LIKE '" + txtSearch.Text + "%'";
                SqlDataAdapter dtaAdapter = new SqlDataAdapter(searchQuery, cnnStr);
                DataTable dtSearch = new DataTable();
                dtaAdapter.Fill(dtSearch);
                dgvUserAccounts.DataSource = dtSearch;

                String displaySQuery = "SELECT * FROM tblUserAccounts WHERE username LIKE'" + txtSearch.Text + "%'";
                SqlDataAdapter dtaDAdapter = new SqlDataAdapter(displaySQuery, cnnStr);
                DataTable dtDSearch = new DataTable();
                dtaDAdapter.Fill(dtDSearch);

                if (dgvUserAccounts.SelectedRows.Count > 0)
                {
                    txtUserID.Text = dtDSearch.Rows[0][0].ToString();

                    cboUserType.DropDownStyle = ComboBoxStyle.DropDown;
                    cboUserType.Text = dtDSearch.Rows[0][1].ToString();
                    txtUsername.Text = dtDSearch.Rows[0][2].ToString();
                    txtPassword.Text = dtDSearch.Rows[0][3].ToString();
                    txtFirstname.Text = dtDSearch.Rows[0][4].ToString();
                    txtLastname.Text = dtDSearch.Rows[0][5].ToString();
                    cboPosition.DropDownStyle = ComboBoxStyle.DropDown;
                    cboPosition.Text = dtDSearch.Rows[0][6].ToString();
                    txtEmail.Text = dtDSearch.Rows[0][7].ToString();
                }
            }
        }

        private void picSearch_Click(object sender, EventArgs e)
        {

            String searchQuery = "SELECT userID, userType, username, firstname, lastname FROM tblUserAccounts WHERE username LIKE '" + txtSearch.Text + "%'";
            SqlDataAdapter dtaAdapter = new SqlDataAdapter(searchQuery, cnnStr);
            DataTable dtSearch = new DataTable();
            dtaAdapter.Fill(dtSearch);
            dgvUserAccounts.DataSource = dtSearch;

            String displaySQuery = "SELECT * FROM tblUserAccounts WHERE username LIKE'" + txtSearch.Text + "%'";
            SqlDataAdapter dtaDAdapter = new SqlDataAdapter(displaySQuery, cnnStr);
            DataTable dtDSearch = new DataTable();
            dtaDAdapter.Fill(dtDSearch);

            if (dgvUserAccounts.SelectedRows.Count > 0)
            {
                txtUserID.Text = dtDSearch.Rows[0][0].ToString();
                cboUserType.DropDownStyle = ComboBoxStyle.DropDown;
                cboUserType.Text = dtDSearch.Rows[0][1].ToString();
                txtUsername.Text = dtDSearch.Rows[0][2].ToString();
                txtPassword.Text = dtDSearch.Rows[0][3].ToString();
                txtFirstname.Text = dtDSearch.Rows[0][4].ToString();
                txtLastname.Text = dtDSearch.Rows[0][5].ToString();
                cboPosition.DropDownStyle = ComboBoxStyle.DropDown;
                cboPosition.Text = dtDSearch.Rows[0][6].ToString();
                txtEmail.Text = dtDSearch.Rows[0][7].ToString();
            }


            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            bool saveStatus;
            if (btnAdd.Text == "Add")
            {
                btnAdd.Text = "Save";
                btnCancel.Enabled = true;
                makeValueControlEmpty();
                enableControls();
                txtUserID.Text = assignNewUserID();
            }
            else if (btnAdd.Text == "Save")
            {
                btnAdd.Text = "Add";
                DialogResult confirmSaveDR = new DialogResult();
                confirmSaveDR = MessageBox.Show("Are all data correct and complete?", "Adding user account record."
                                                                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmSaveDR == DialogResult.Yes)
                {
                    saveStatus = saveRecord();
                    DialogResult saveStatusDR = new DialogResult();

                    if (saveStatus)
                    {
                        saveStatusDR = MessageBox.Show("New user account saved!", "Adding user account record"
                                                                , MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (saveStatusDR == DialogResult.OK)
                        {
                            makeDefaultControls();
                            makeValueControlEmpty();
                        }
                    }
                    else
                    {
                        saveStatusDR = MessageBox.Show("New user account was not saved?", "Adding user account record"
                                                                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        if (saveStatusDR == DialogResult.OK)
                        {
                            cboPosition.Focus();
                        }
                    }
                }
                else if (confirmSaveDR == DialogResult.No)
                {
                    cboUserType.Focus();
                }
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtPassword.Text = passGenerator();
        }
       

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                chkShow.Text = "Hide";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                chkShow.Text = "Show";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult cancelDialogResult = new DialogResult();
            if (btnAdd.Text == "Save")
            {
                cancelDialogResult = MessageBox.Show("Are you sure you want to cancel updating this record? All data entered in the form will be deleted.",
                                            "Cancel Operation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (cancelDialogResult == DialogResult.OK)
                {
                    makeDefaultControls();
                    makeDefaultControls();
                }
                else if (cancelDialogResult == DialogResult.Cancel)
                {
                    cboUserType.Focus();
                }
            }

            else if (btnUpdate.Text == "Save")
            {
                cancelDialogResult = MessageBox.Show("Are you sure you want to cancel updating this record? All data entered in the form will be deleted.",
                                           "Cancel Operation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (cancelDialogResult == DialogResult.OK)
                {
                    btnUpdate.Text = "Update";
                    makeDefaultControls();
                    makeValueControlEmpty();
                }
                else if (cancelDialogResult == DialogResult.Cancel)
                {
                    cboUserType.Focus();
                }
            }
            else if (delCancel)
            {
                makeValueControlEmpty();
                makeDefaultControls();
            }
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            bool updateStatus;
            if (btnUpdate.Text == "Update")
            {
                btnUpdate.Text = "Save";
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnCancel.Enabled = true;
                enableControls();
            }
            else if (btnUpdate.Text == "Save")
            {
                DialogResult confirmUpdateDR = new DialogResult();
                confirmUpdateDR = MessageBox.Show("Do you want the changes to be saved?", "Updating User account record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmUpdateDR == DialogResult.Yes)
                {
                    updateStatus = saveUpdateRecord();

                    DialogResult updateStatusDR = new DialogResult();
                    if (updateStatus)
                    {
                        updateStatusDR = MessageBox.Show("Update Successful", "Updating user accounts record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (updateStatusDR == DialogResult.OK)
                        {
                            btnUpdate.Text = "Update";
                            makeDefaultControls();
                            makeValueControlEmpty();
                        }
                    }
                    else
                    {
                        updateStatusDR = MessageBox.Show("Update unsuccessful", "updating user accounts record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (updateStatusDR == DialogResult.OK)
                        {
                            cboUserType.Focus();
                        }
                    }
                }
                else if (confirmUpdateDR == DialogResult.No)
                {
                    cboUserType.Focus();
                }
            }
        }

        private void cboUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboUserType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cboPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPosition.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        bool delCancel; //contains value of true when no button is clicked for cancelling of deletion 

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult confirmDeletDR = MessageBox.Show("Do you really want to delete this record? Records that are deleted can;t be retrieved anymore.",
                "Deleting user account record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmDeletDR == DialogResult.Yes)
            {
                bool deleteRecStatus = deleteRecord();

                DialogResult deleteResponce = MessageBox.Show("1 user account record was deleted.", "Deleting user account record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (deleteResponce == DialogResult.OK)
                {
                    String viewUpdateRecQuery = "SELECT userID, userType, username, firstname, lastname FROM tblUserAccounts";
                    SqlDataAdapter dtaAdapter = new SqlDataAdapter(viewUpdateRecQuery, cnnStr);
                    DataTable dtViewUpdated = new DataTable();
                    dtaAdapter.Fill(dtViewUpdated);
                    dgvUserAccounts.DataSource = dtViewUpdated;

                    makeDefaultControls();
                    makeValueControlEmpty();
                }
            }
            else if (confirmDeletDR == DialogResult.No)
            {
                txtSearch.Focus();
                txtSearch.Select();
                makeDefaultControls();
                btnCancel.Enabled = true;
                delCancel = true;
            }
        }
        //END OF EVENTS SECTIONS
       
    }
}