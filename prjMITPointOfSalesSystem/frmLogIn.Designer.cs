namespace prjMITPointOfSalesSystem
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.picLoginLogo = new System.Windows.Forms.PictureBox();
            this.picUserIcon = new System.Windows.Forms.PictureBox();
            this.picPassIcon = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.picLogInBtn = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picCancelBtn = new System.Windows.Forms.PictureBox();
            this.chkShowHide = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogInBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancelBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // picLoginLogo
            // 
            this.picLoginLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLoginLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLoginLogo.Image")));
            this.picLoginLogo.Location = new System.Drawing.Point(129, 12);
            this.picLoginLogo.Name = "picLoginLogo";
            this.picLoginLogo.Size = new System.Drawing.Size(120, 120);
            this.picLoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoginLogo.TabIndex = 0;
            this.picLoginLogo.TabStop = false;
            // 
            // picUserIcon
            // 
            this.picUserIcon.BackColor = System.Drawing.Color.Transparent;
            this.picUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("picUserIcon.Image")));
            this.picUserIcon.Location = new System.Drawing.Point(54, 207);
            this.picUserIcon.Name = "picUserIcon";
            this.picUserIcon.Size = new System.Drawing.Size(30, 30);
            this.picUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserIcon.TabIndex = 1;
            this.picUserIcon.TabStop = false;
            // 
            // picPassIcon
            // 
            this.picPassIcon.BackColor = System.Drawing.Color.Transparent;
            this.picPassIcon.Image = ((System.Drawing.Image)(resources.GetObject("picPassIcon.Image")));
            this.picPassIcon.Location = new System.Drawing.Point(54, 271);
            this.picPassIcon.Name = "picPassIcon";
            this.picPassIcon.Size = new System.Drawing.Size(30, 30);
            this.picPassIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPassIcon.TabIndex = 2;
            this.picPassIcon.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Black;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(90, 207);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(241, 30);
            this.txtUser.TabIndex = 3;
            this.txtUser.Tag = "";
            this.txtUser.Text = "Username";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Black;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(90, 271);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(241, 30);
            this.txtPass.TabIndex = 4;
            this.txtPass.Text = "password";
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // picLogInBtn
            // 
            this.picLogInBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picLogInBtn.Image = ((System.Drawing.Image)(resources.GetObject("picLogInBtn.Image")));
            this.picLogInBtn.Location = new System.Drawing.Point(54, 340);
            this.picLogInBtn.Name = "picLogInBtn";
            this.picLogInBtn.Size = new System.Drawing.Size(120, 60);
            this.picLogInBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogInBtn.TabIndex = 5;
            this.picLogInBtn.TabStop = false;
            this.picLogInBtn.Click += new System.EventHandler(this.picLogInBtn_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Felix Titling", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(64, 147);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(251, 32);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "Account Login";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picCancelBtn
            // 
            this.picCancelBtn.Image = ((System.Drawing.Image)(resources.GetObject("picCancelBtn.Image")));
            this.picCancelBtn.Location = new System.Drawing.Point(211, 340);
            this.picCancelBtn.Name = "picCancelBtn";
            this.picCancelBtn.Size = new System.Drawing.Size(120, 60);
            this.picCancelBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCancelBtn.TabIndex = 7;
            this.picCancelBtn.TabStop = false;
            this.picCancelBtn.Click += new System.EventHandler(this.picCancelBtn_Click);
            // 
            // chkShowHide
            // 
            this.chkShowHide.AutoSize = true;
            this.chkShowHide.BackColor = System.Drawing.Color.Transparent;
            this.chkShowHide.ForeColor = System.Drawing.Color.Black;
            this.chkShowHide.Location = new System.Drawing.Point(90, 307);
            this.chkShowHide.Name = "chkShowHide";
            this.chkShowHide.Size = new System.Drawing.Size(102, 17);
            this.chkShowHide.TabIndex = 8;
            this.chkShowHide.Text = "Show Password";
            this.chkShowHide.UseVisualStyleBackColor = false;
            this.chkShowHide.CheckedChanged += new System.EventHandler(this.chkShowHide_CheckedChanged);
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 462);
            this.Controls.Add(this.chkShowHide);
            this.Controls.Add(this.picCancelBtn);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.picLogInBtn);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.picPassIcon);
            this.Controls.Add(this.picUserIcon);
            this.Controls.Add(this.picLoginLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLoginLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogInBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancelBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLoginLogo;
        private System.Windows.Forms.PictureBox picUserIcon;
        private System.Windows.Forms.PictureBox picPassIcon;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox picLogInBtn;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox picCancelBtn;
        private System.Windows.Forms.CheckBox chkShowHide;
    }
}