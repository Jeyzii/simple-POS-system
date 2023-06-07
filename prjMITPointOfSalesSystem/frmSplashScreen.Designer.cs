namespace prjMITPointOfSalesSystem
{
    partial class frmSplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.picCompanyLogo = new System.Windows.Forms.PictureBox();
            this.tmrSplashScreen = new System.Windows.Forms.Timer(this.components);
            this.lblSystemName = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.pnlProgressBarBorder = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlProgressBarFill = new System.Windows.Forms.Panel();
            this.lblSystemDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).BeginInit();
            this.pnlProgressBarBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCompanyLogo
            // 
            this.picCompanyLogo.BackColor = System.Drawing.Color.Transparent;
            this.picCompanyLogo.Image = ((System.Drawing.Image)(resources.GetObject("picCompanyLogo.Image")));
            this.picCompanyLogo.Location = new System.Drawing.Point(167, 31);
            this.picCompanyLogo.Name = "picCompanyLogo";
            this.picCompanyLogo.Size = new System.Drawing.Size(320, 270);
            this.picCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompanyLogo.TabIndex = 0;
            this.picCompanyLogo.TabStop = false;
            this.picCompanyLogo.UseWaitCursor = true;
            // 
            // tmrSplashScreen
            // 
            this.tmrSplashScreen.Enabled = true;
            this.tmrSplashScreen.Interval = 1;
            this.tmrSplashScreen.Tick += new System.EventHandler(this.tmrSplashScreen_Tick);
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.BackColor = System.Drawing.Color.Transparent;
            this.lblSystemName.Font = new System.Drawing.Font("Felix Titling", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.ForeColor = System.Drawing.Color.Black;
            this.lblSystemName.Location = new System.Drawing.Point(85, 329);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(481, 94);
            this.lblSystemName.TabIndex = 5;
            this.lblSystemName.Text = "Computerize \r\nPoint Of Sales System";
            this.lblSystemName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSystemName.UseWaitCursor = true;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.Font = new System.Drawing.Font("Freestyle Script", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.Black;
            this.lblCompanyName.Location = new System.Drawing.Point(201, 286);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(255, 47);
            this.lblCompanyName.TabIndex = 4;
            this.lblCompanyName.Text = "Make.It.Rain. Jewels";
            this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCompanyName.UseWaitCursor = true;
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.BackColor = System.Drawing.Color.Black;
            this.pnlSeparator.Location = new System.Drawing.Point(153, 280);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(347, 3);
            this.pnlSeparator.TabIndex = 6;
            this.pnlSeparator.UseWaitCursor = true;
            // 
            // pnlProgressBarBorder
            // 
            this.pnlProgressBarBorder.BackColor = System.Drawing.Color.White;
            this.pnlProgressBarBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlProgressBarBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProgressBarBorder.Controls.Add(this.pnlProgressBarFill);
            this.pnlProgressBarBorder.Location = new System.Drawing.Point(180, 428);
            this.pnlProgressBarBorder.Name = "pnlProgressBarBorder";
            this.pnlProgressBarBorder.Size = new System.Drawing.Size(290, 27);
            this.pnlProgressBarBorder.TabIndex = 7;
            this.pnlProgressBarBorder.UseWaitCursor = true;
            // 
            // pnlProgressBarFill
            // 
            this.pnlProgressBarFill.BackColor = System.Drawing.Color.Black;
            this.pnlProgressBarFill.Location = new System.Drawing.Point(3, 3);
            this.pnlProgressBarFill.Name = "pnlProgressBarFill";
            this.pnlProgressBarFill.Size = new System.Drawing.Size(1, 18);
            this.pnlProgressBarFill.TabIndex = 5;
            this.pnlProgressBarFill.UseWaitCursor = true;
            // 
            // lblSystemDetails
            // 
            this.lblSystemDetails.AutoSize = true;
            this.lblSystemDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblSystemDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemDetails.ForeColor = System.Drawing.Color.Black;
            this.lblSystemDetails.Location = new System.Drawing.Point(420, 487);
            this.lblSystemDetails.Name = "lblSystemDetails";
            this.lblSystemDetails.Size = new System.Drawing.Size(222, 12);
            this.lblSystemDetails.TabIndex = 8;
            this.lblSystemDetails.Text = "Version 1.0; LOKprograms, Inc.; Copyright Year 2020";
            this.lblSystemDetails.UseWaitCursor = true;
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.lblSystemDetails);
            this.Controls.Add(this.pnlProgressBarBorder);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblSystemName);
            this.Controls.Add(this.picCompanyLogo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).EndInit();
            this.pnlProgressBarBorder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCompanyLogo;
        private System.Windows.Forms.Timer tmrSplashScreen;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.FlowLayoutPanel pnlProgressBarBorder;
        private System.Windows.Forms.Panel pnlProgressBarFill;
        private System.Windows.Forms.Label lblSystemDetails;
    }
}

