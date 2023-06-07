namespace prjMITPointOfSalesSystem
{
    partial class frmMDIParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDIParent));
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuPOST = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsername = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPurchasing = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSystemConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUserAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.userTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSalesTax = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDiscountPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.mnuStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mnuStrip.BackgroundImage")));
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPOST,
            this.mnuCustomer,
            this.mnuLogOut,
            this.mnuUsername,
            this.mnuInventory,
            this.mnuPurchasing,
            this.mnuReports,
            this.mnuSystemConfig,
            this.mnuHelp});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(1370, 24);
            this.mnuStrip.TabIndex = 2;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // mnuPOST
            // 
            this.mnuPOST.Image = ((System.Drawing.Image)(resources.GetObject("mnuPOST.Image")));
            this.mnuPOST.Name = "mnuPOST";
            this.mnuPOST.Size = new System.Drawing.Size(102, 20);
            this.mnuPOST.Text = "PointOfSales";
            this.mnuPOST.Click += new System.EventHandler(this.mnuPOST_Click);
            // 
            // mnuCustomer
            // 
            this.mnuCustomer.Image = ((System.Drawing.Image)(resources.GetObject("mnuCustomer.Image")));
            this.mnuCustomer.Name = "mnuCustomer";
            this.mnuCustomer.Size = new System.Drawing.Size(87, 20);
            this.mnuCustomer.Text = "Customer";
            // 
            // mnuLogOut
            // 
            this.mnuLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuLogOut.Image = ((System.Drawing.Image)(resources.GetObject("mnuLogOut.Image")));
            this.mnuLogOut.Name = "mnuLogOut";
            this.mnuLogOut.Size = new System.Drawing.Size(78, 20);
            this.mnuLogOut.Text = "Log Out";
            this.mnuLogOut.Click += new System.EventHandler(this.mnuLogOut_Click);
            // 
            // mnuUsername
            // 
            this.mnuUsername.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuUsername.Image = ((System.Drawing.Image)(resources.GetObject("mnuUsername.Image")));
            this.mnuUsername.Name = "mnuUsername";
            this.mnuUsername.Size = new System.Drawing.Size(88, 20);
            this.mnuUsername.Text = "Username";
            // 
            // mnuInventory
            // 
            this.mnuInventory.Image = ((System.Drawing.Image)(resources.GetObject("mnuInventory.Image")));
            this.mnuInventory.Name = "mnuInventory";
            this.mnuInventory.Size = new System.Drawing.Size(85, 20);
            this.mnuInventory.Text = "Inventory";
            // 
            // mnuPurchasing
            // 
            this.mnuPurchasing.Image = ((System.Drawing.Image)(resources.GetObject("mnuPurchasing.Image")));
            this.mnuPurchasing.Name = "mnuPurchasing";
            this.mnuPurchasing.Size = new System.Drawing.Size(94, 20);
            this.mnuPurchasing.Text = "Purchasing";
            // 
            // mnuReports
            // 
            this.mnuReports.Image = ((System.Drawing.Image)(resources.GetObject("mnuReports.Image")));
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(75, 20);
            this.mnuReports.Text = "Reports";
            // 
            // mnuSystemConfig
            // 
            this.mnuSystemConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUserAccounts,
            this.tsSalesTax,
            this.tsDiscountPrice});
            this.mnuSystemConfig.Image = ((System.Drawing.Image)(resources.GetObject("mnuSystemConfig.Image")));
            this.mnuSystemConfig.Name = "mnuSystemConfig";
            this.mnuSystemConfig.Size = new System.Drawing.Size(150, 20);
            this.mnuSystemConfig.Text = "System Configuration";
            // 
            // mnuUserAccounts
            // 
            this.mnuUserAccounts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userTypeToolStripMenuItem});
            this.mnuUserAccounts.Image = ((System.Drawing.Image)(resources.GetObject("mnuUserAccounts.Image")));
            this.mnuUserAccounts.Name = "mnuUserAccounts";
            this.mnuUserAccounts.Size = new System.Drawing.Size(180, 22);
            this.mnuUserAccounts.Text = "User Accounts";
            this.mnuUserAccounts.Click += new System.EventHandler(this.mnuUserAccounts_Click);
            // 
            // userTypeToolStripMenuItem
            // 
            this.userTypeToolStripMenuItem.Name = "userTypeToolStripMenuItem";
            this.userTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userTypeToolStripMenuItem.Text = "User Type";
            // 
            // tsSalesTax
            // 
            this.tsSalesTax.Image = ((System.Drawing.Image)(resources.GetObject("tsSalesTax.Image")));
            this.tsSalesTax.Name = "tsSalesTax";
            this.tsSalesTax.Size = new System.Drawing.Size(180, 22);
            this.tsSalesTax.Text = "Sales Tax";
            // 
            // tsDiscountPrice
            // 
            this.tsDiscountPrice.Image = ((System.Drawing.Image)(resources.GetObject("tsDiscountPrice.Image")));
            this.tsDiscountPrice.Name = "tsDiscountPrice";
            this.tsDiscountPrice.Size = new System.Drawing.Size(180, 22);
            this.tsDiscountPrice.Text = "Discount Rate";
            // 
            // mnuHelp
            // 
            this.mnuHelp.Image = ((System.Drawing.Image)(resources.GetObject("mnuHelp.Image")));
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(60, 20);
            this.mnuHelp.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip1.BackgroundImage")));
            this.statusStrip1.Location = new System.Drawing.Point(0, 592);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1370, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmMDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1370, 614);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "frmMDIParent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuSystemConfig;
        private System.Windows.Forms.ToolStripMenuItem mnuUserAccounts;
        private System.Windows.Forms.ToolStripMenuItem mnuLogOut;
        private System.Windows.Forms.ToolStripMenuItem tsSalesTax;
        private System.Windows.Forms.ToolStripMenuItem tsDiscountPrice;
        private System.Windows.Forms.ToolStripMenuItem mnuUsername;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuPOST;
        private System.Windows.Forms.ToolStripMenuItem mnuInventory;
        private System.Windows.Forms.ToolStripMenuItem mnuPurchasing;
        private System.Windows.Forms.ToolStripMenuItem mnuReports;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem userTypeToolStripMenuItem;
    }
}