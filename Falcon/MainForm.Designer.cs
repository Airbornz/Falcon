namespace Falcon
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnCCleaner = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnStrip = new System.Windows.Forms.Button();
            this.btnWifi = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnAutoRestore = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnWindows = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(12, 143);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(130, 45);
            this.btnInstall.TabIndex = 1;
            this.btnInstall.Text = "Install Software";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnCCleaner
            // 
            this.btnCCleaner.Location = new System.Drawing.Point(148, 143);
            this.btnCCleaner.Name = "btnCCleaner";
            this.btnCCleaner.Size = new System.Drawing.Size(130, 45);
            this.btnCCleaner.TabIndex = 2;
            this.btnCCleaner.Text = "Launch CCleaner";
            this.btnCCleaner.UseVisualStyleBackColor = true;
            this.btnCCleaner.Click += new System.EventHandler(this.btnCCleaner_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(12, 194);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(130, 45);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "User Mover";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnStrip
            // 
            this.btnStrip.Location = new System.Drawing.Point(148, 194);
            this.btnStrip.Name = "btnStrip";
            this.btnStrip.Size = new System.Drawing.Size(130, 45);
            this.btnStrip.TabIndex = 4;
            this.btnStrip.Text = "Strip Ownership";
            this.btnStrip.UseVisualStyleBackColor = true;
            this.btnStrip.Click += new System.EventHandler(this.btnStrip_Click);
            // 
            // btnWifi
            // 
            this.btnWifi.Location = new System.Drawing.Point(12, 245);
            this.btnWifi.Name = "btnWifi";
            this.btnWifi.Size = new System.Drawing.Size(130, 45);
            this.btnWifi.TabIndex = 5;
            this.btnWifi.Text = "Wifi Resolver";
            this.btnWifi.UseVisualStyleBackColor = true;
            this.btnWifi.Click += new System.EventHandler(this.btnWifi_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(148, 245);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(130, 45);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Text = "Create Restore Point";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnAutoRestore
            // 
            this.btnAutoRestore.Location = new System.Drawing.Point(12, 296);
            this.btnAutoRestore.Name = "btnAutoRestore";
            this.btnAutoRestore.Size = new System.Drawing.Size(130, 45);
            this.btnAutoRestore.TabIndex = 7;
            this.btnAutoRestore.Text = "Auto Restore Points";
            this.btnAutoRestore.UseVisualStyleBackColor = true;
            this.btnAutoRestore.Click += new System.EventHandler(this.btnAutoRestore_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(148, 347);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(130, 45);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVersion.Location = new System.Drawing.Point(12, 400);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(266, 23);
            this.lblVersion.TabIndex = 9;
            this.lblVersion.Text = "Version: ";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Falcon.Properties.Resources.falcon;
            this.pictureBox1.Location = new System.Drawing.Point(90, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(148, 296);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(130, 45);
            this.btnPassword.TabIndex = 10;
            this.btnPassword.Text = "Remove Password";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnWindows
            // 
            this.btnWindows.Location = new System.Drawing.Point(12, 347);
            this.btnWindows.Name = "btnWindows";
            this.btnWindows.Size = new System.Drawing.Size(130, 45);
            this.btnWindows.TabIndex = 11;
            this.btnWindows.Text = "Windows 11 Upgrade";
            this.btnWindows.UseVisualStyleBackColor = true;
            this.btnWindows.Click += new System.EventHandler(this.btnWindows_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 432);
            this.Controls.Add(this.btnWindows);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnAutoRestore);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnWifi);
            this.Controls.Add(this.btnStrip);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnCCleaner);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Falcon - Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnCCleaner;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnStrip;
        private System.Windows.Forms.Button btnWifi;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnAutoRestore;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Button btnWindows;
    }
}

