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
    public partial class frmPointOfSalesTerminal : Form
    {
        String cnnStr; //var for connection string
        SqlConnection con; // Sqlconnection obj
        bool cnn;
        //class variables
        String itemID, itemName, itemPrice;
        double subTotal, total, taxValue, netValue, amountGiven, change = 0;

        
        public frmPointOfSalesTerminal(String username)
        {
            InitializeComponent();
            txtCashier.Text = username;
            dgvTransactions.Rows.Clear();
            cnnStr = "Data Source=PC-LOK\\SQLEXPRESS;Initial Catalog=dbPOSSystem;Integrated Security=True";
            defaultValues();
        }

        
        private void frmPointOfSalesTerminal_Load(object sender, EventArgs e)
        {
            cnn = connectDB();
            txtCustomerID.Focus();

            
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

        private void defaultValues()// use to set all controls to deafult state
        {
            DateTime dtmTransactDate = new DateTime();
            dtmTransactDate = DateTime.Today;

            //formats value of date and time and display on txtTransactiondate
            txtTransactionDate.Text = dtmTransactDate.ToString("MMMM dd, yyyy (dddd) ");
            btnPayout.Enabled = false;
            btnCancel.Enabled = false;
            makeNewTransactionID();

            String getUserIDQuery = "SELECT userID FROM tblUserAccounts WHERE username = '" + txtCashier.Text + "'";

            SqlDataAdapter dtaDAdapter = new SqlDataAdapter(getUserIDQuery, cnnStr);
            DataTable dtGetUserID = new DataTable();
            dtaDAdapter.Fill(dtGetUserID);

            if (dtGetUserID.Rows.Count > 0)
            {
                String userID = dtGetUserID.Rows[0][0].ToString();
                txtCashierID.Text = userID;     
            }

        }// end of defaultValues method

        private void makeNewTransactionID()
        {
            String getTransactionRecQuery = "SELECT transactionID FROM tblTransactions ORDER BY transactionID DESC";

            SqlDataAdapter dtaDAdapter = new SqlDataAdapter(getTransactionRecQuery, cnnStr);
            DataTable dtGetTransactionRec = new DataTable();
            dtaDAdapter.Fill(dtGetTransactionRec);

            int noOfTransactioRec = dtGetTransactionRec.Rows.Count; // gets number of records

            if(noOfTransactioRec == 0)//if no record
            {
                String newTransactionID = "0000000000";
                txtTransactionID.Text = newTransactionID;
            }
            else if (noOfTransactioRec > 0)// if has record
            {
                int newTransactionIDNum = Convert.ToInt32(dtGetTransactionRec.Rows[0][0].ToString());
                newTransactionIDNum = +1;//increase userID by 1
                String newTransactionID = newTransactionIDNum.ToString("D10");//set new Transaction ID as 10 digit id
                txtTransactionID.Text = newTransactionID;
            }
        }// END OF MAKE NEW TRANSACTIONID METHOD

        private void setSelectedItems()// to assign item details
        {
            txtItemID.Text = itemID;
            txtItemName.Text = itemName;
            txtItemPrice.Text = itemPrice;
            txtQuantity.ReadOnly = false;
            txtQuantity.Focus();
            txtQuantity.Select();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            //commputation of subtotal?
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                //display textbox value in datagridview
                dgvTransactions.Rows.Add(txtItemID.Text, txtItemName.Text, txtItemPrice.Text, txtQuantity.Text, txtSubTotal.Text);

                txtQuantity.ReadOnly = true;
                btnClear.Focus();
                btnEnter.Enabled = true;
                btnClear.Enabled = true;
                clearTextBoxes();
            }
        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
            int itemPurchaseCount;
            total = 0;
            itemPurchaseCount = dgvTransactions.RowCount;

            if(itemPurchaseCount > 0)
            {
                int ctr1 = 0;

                while (ctr1 < (itemPurchaseCount - 1))
                {
                    String test = dgvTransactions.Rows[ctr1].Cells[4].Value.ToString();// USE TO GET SUBTOTAL VALUES
                    total += Double.Parse(test, System.Globalization.NumberStyles.Currency);//REMOVE THE CURRENCY FORMATTING OF SUBTOTAL THEN ADD TO TOTAL 

                    ctr1++;
                }
                txtTotal.Text = total.ToString("C");

                taxValue = total * 0.12;
                txtTax.Text = taxValue.ToString("C");
                netValue = total - taxValue;
                txtNetTotal.Text = netValue.ToString("C");

                btnPayout.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        //ITEMS SECTION
        private void picHighPriestess_Click(object sender, EventArgs e)
        {
            itemID = "item0002PLR";
            itemPrice = "45,800.00";
            itemName = lblHighPriested.Text;
            setSelectedItems();
        }

        private void picEsmeralda_Click(object sender, EventArgs e)
        {
            itemID = "item0005YGR";
            itemPrice = "55,000.00";
            itemName = lblEsmeralda.Text;
            setSelectedItems();
        }

        private void picBlueBlooded_Click(object sender, EventArgs e)
        {
            itemID = "item0003RGR";
            itemPrice = "23,130.00";
            itemName = lblBlueBlooded.Text;
            setSelectedItems();
        }

        private void picSweetheart_Click(object sender, EventArgs e)
        {
            itemID = "item0003SLR";
            itemPrice = "10,440.00";
            itemName = lblSweetheart.Text;
            setSelectedItems();
        }

        private void picQueen_Click(object sender, EventArgs e)
        {
            itemID = "item0009TIT";
            itemPrice = "10,800.00";
            itemName = lblQueen.Text;
            setSelectedItems();
        }

        private void picRoyale_Click(object sender, EventArgs e)
        {
            itemID = "item0008RYL";
            itemPrice = "69,193.00";
            itemName = lblRoyale.Text;
            setSelectedItems();
        }

        private void picElena_Click(object sender, EventArgs e)
        {
            itemID = "item0009ELE";
            itemPrice = "12,800.00";
            itemName = lblElena.Text;
            setSelectedItems();
        }

        private void picGilsten_Click(object sender, EventArgs e)
        {
            itemID = "item00016YGE";
            itemPrice = "25,000.00";
            itemName = lblGilsten.Text;
            setSelectedItems();
        }

        private void picOriental_Click(object sender, EventArgs e)
        {
            itemID = "item0001ORL";
            itemPrice = "15,900.00";
            itemName = lblOriental.Text;
            setSelectedItems();
        }

        private void picPearlescent_Click(object sender, EventArgs e)
        {
            itemID = "item00013PLE";
            itemPrice = "80,000.00";
            itemName = lblPearlescent.Text;
            setSelectedItems();
        }

        private void picPristine_Click(object sender, EventArgs e)
        {
            itemID = "item0007PRI";
            itemPrice = "50,800.00";
            itemName = lblPristine.Text;
            setSelectedItems();
        }

        private void picStarlight_Click(object sender, EventArgs e)
        {
            itemID = "item0003STR";
            itemPrice = "20,999.00";
            itemName = lblStarlight.Text;
            setSelectedItems();
        }

        private void picBohemian_Click(object sender, EventArgs e)
        {
            itemID = "item00069BHM";
            itemPrice = "15,900.00";
            itemName = lblBohemian.Text;
            setSelectedItems();
        }

        private void picEstome_Click(object sender, EventArgs e)
        {
            itemID = "item0006EST";
            itemPrice = "69,000.00";
            itemName = lblEstome.Text;
            setSelectedItems();
        }

        private void picSpringNails_Click(object sender, EventArgs e)
        {
            itemID = "item0008SPR";
            itemPrice = "45,000.00";
            itemName = lblSpringNails.Text;
            setSelectedItems();
        }

        private void picTreeOfLife_Click(object sender, EventArgs e)
        {
            itemID = "item0002TOL";
            itemPrice = "25,900.00";
            itemName = lblTreeOfLife.Text;
            setSelectedItems();
        }

        private void picTrio_Click(object sender, EventArgs e)
        {
            itemID = "item0003TRI";
            itemPrice = "33,300.00";
            itemName = lblTrio.Text;
            setSelectedItems();
        }

        private void picTwistedRope_Click(object sender, EventArgs e)
        {
            itemID = "item00048YGB";
            itemPrice = "25,000.00";
            itemName = lblTwistedRope.Text;
            setSelectedItems();
        }
        //END OF ITEMMS SECTION
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }

        private void clearTextBoxes()
        {
            txtItemID.Clear();
            txtItemName.Clear();
            txtItemPrice.Clear();
            txtQuantity.Text = "0";
            txtSubTotal.Text = "0.00";
        }

        private void txtAmuontGiven_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                txtAmuontGiven.Text = (Convert.ToDouble(txtAmuontGiven.Text)).ToString("C");
                amountGiven = Convert.ToDouble(Double.Parse(txtAmuontGiven.Text, System.Globalization.NumberStyles.Currency));
                if (amountGiven >= total)
                {
                    change = total = amountGiven;
                    txtChange.Text = change.ToString("C");
                    btnPayout.Enabled = true;
                    btnCancel.Enabled = true;
                }
                else
                {
                    DialogResult drAmountGivenWarning = new DialogResult();
                    drAmountGivenWarning = MessageBox.Show("The amount given was insufficient.", "Payment Status", 
                                                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (drAmountGivenWarning == DialogResult.OK)
                    {
                        txtAmuontGiven.Clear();
                        txtAmuontGiven.Focus();
                    }
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult drConfirmCancel = new DialogResult();
            drConfirmCancel = MessageBox.Show("Transaction will be canceled. All detailss will be removed", "Cancel Transaction", 
                                                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(drConfirmCancel == DialogResult.OK)
            {
                clearTextBoxes();
                txtNetTotal.Clear();
                txtTax.Clear();
                txtTotal.Clear();
                txtAmuontGiven.Clear();
                txtChange.Clear();
                dgvTransactions.Rows.Clear();
                btnPayout.Enabled = false;
                btnCancel.Enabled = false;
            }
            else
            {
                tabRings.Focus();
            }
        }
        private void btnPayout_Click(object sender, EventArgs e)
        {
            if(txtChange.Text != "")
            {
                bool saveTransactionStatus = saveTransactionRecord();

                if (saveTransactionStatus)
                {
                    DialogResult drPayoutConfirmed = new DialogResult();
                    drPayoutConfirmed = MessageBox.Show("Payement confirmed processed.", "Payment confirmation", 
                                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(drPayoutConfirmed == DialogResult.OK)
                    {
                        DialogResult drPrinting = new DialogResult();
                        //simulate printing using messagebox
                        drPrinting = MessageBox.Show("The official receipt was printed. Transaction was completed.", "Transaction Complete", 
                                                                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(drPrinting == DialogResult.OK)
                        {//make POS Terminal default state
                            clearTextBoxes();
                            txtNetTotal.Clear();
                            txtTax.Clear();
                            txtTotal.Clear();
                            txtAmuontGiven.Clear();
                            txtChange.Clear();
                            dgvTransactions.Rows.Clear();
                            defaultValues();
                        }
                    }
                }
                else
                {
                    DialogResult drPayoutNotConfirmed = new DialogResult();
                    drPayoutNotConfirmed = MessageBox.Show("Payment not confirmed nor processed.","Payment confirmation",
                                                                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if(drPayoutNotConfirmed == DialogResult.OK)
                    {
                        txtItemID.Focus();
                    }
                }
            }
            else
            {
                DialogResult drEnterAmnt = new DialogResult();
                drEnterAmnt = MessageBox.Show("Please enter payment amount first.", "Payment confirmation", 
                                                                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if(drEnterAmnt == DialogResult.OK)
                {
                    txtAmuontGiven.Focus();
                }
            }
        }

        private bool saveTransactionRecord()
        {
            try
            {
                String cashierName = txtCashier.Text;
                String saveTransactionRecQuery = "INSERT INTO tblTransactions VALUES( '"+ txtTransactionID.Text+"','"+txtTransactionDate.Text + 
                                                                                        "','"+txtCustomerID.Text + "','" + lblCustomerName.Text + 
                                                                                        "','" + txtTax.Text + "','" + txtNetTotal.Text + 
                                                                                        "','" + txtTotal.Text + "','" + txtCashier.Text + "')";
                SqlDataAdapter dtaAdapter = new SqlDataAdapter(saveTransactionRecQuery, cnnStr);
                DataTable dtTransactionRec = new DataTable();
                dtaAdapter.Fill(dtTransactionRec);

                int itemOrderRowCtr = (dgvTransactions.Rows.Count) - 1;

                String getOrderIDQuery = "SELECT itemOrderID FROM tblItemPurchases_new ORDER BY itemOrderID DESC";
                SqlDataAdapter dtaDAdapter = new SqlDataAdapter(getOrderIDQuery, cnnStr);
                DataTable dtGetOrderIDQuery = new DataTable();
                dtaDAdapter.Fill(dtGetOrderIDQuery);
                int itemOrderID;

                if (dtGetOrderIDQuery.Rows.Count < 1)
                {
                    itemOrderID = 0;
                }
                else
                {
                    itemOrderID = Convert.ToInt32(dtGetOrderIDQuery.Rows[0][0].ToString());
                }
                if (itemOrderRowCtr > 0)
                {
                    for (int ctr = 0; ctr < itemOrderRowCtr; ctr++)
                    {
                        itemOrderID++;
                
                        String saveItemOrdersQuery = "INSERT INTO tblItemPurchases_new VALUES('"+itemOrderID.ToString("DS")+
                                                                                                "','"+ txtTransactionID.Text+
                                                                              "','"+dgvTransactions.Rows[ctr].Cells[0].Value.ToString() + 
                                                                              "','" + dgvTransactions.Rows[ctr].Cells[1].Value.ToString() + 
                                                                              "','" +dgvTransactions.Rows[ctr].Cells[2].Value.ToString() + 
                                                                              "','" + dgvTransactions.Rows[ctr].Cells[3].Value.ToString() + 
                                                                              "','" +dgvTransactions.Rows[ctr].Cells[4].Value.ToString() + "')";

                        dtaAdapter = new SqlDataAdapter(saveItemOrdersQuery,cnnStr);
                        DataTable dtItemOrdersRec = new DataTable();
                        dtaAdapter.Fill(dtItemOrdersRec);
                    }
                }
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }

        private void frmPointOfSalesTerminal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cnn)
            {
                con.Close();
            }
        }

    }
}
