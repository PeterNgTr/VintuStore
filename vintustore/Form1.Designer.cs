namespace vintustore
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_IMEICheck = new System.Windows.Forms.Label();
            this.txtIMEI = new System.Windows.Forms.TextBox();
            this.btnCheckVS = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_LoadAppleCheckIMEI = new System.Windows.Forms.Button();
            this.webBrowser_apple = new System.Windows.Forms.WebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbl_About = new System.Windows.Forms.Label();
            this.btn_iCloudCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_IMEICheck
            // 
            this.lbl_IMEICheck.AutoSize = true;
            this.lbl_IMEICheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IMEICheck.ForeColor = System.Drawing.Color.Blue;
            this.lbl_IMEICheck.Location = new System.Drawing.Point(275, 16);
            this.lbl_IMEICheck.Name = "lbl_IMEICheck";
            this.lbl_IMEICheck.Size = new System.Drawing.Size(343, 33);
            this.lbl_IMEICheck.TabIndex = 0;
            this.lbl_IMEICheck.Text = "Nhap so IMEI de kiem tra";
            // 
            // txtIMEI
            // 
            this.txtIMEI.Location = new System.Drawing.Point(323, 63);
            this.txtIMEI.MaxLength = 15;
            this.txtIMEI.Name = "txtIMEI";
            this.txtIMEI.Size = new System.Drawing.Size(247, 21);
            this.txtIMEI.TabIndex = 1;
            this.txtIMEI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIMEI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            this.txtIMEI.MouseHover += new System.EventHandler(this.txtIMEI_MouseHover);
            // 
            // btnCheckVS
            // 
            this.btnCheckVS.Location = new System.Drawing.Point(323, 101);
            this.btnCheckVS.Name = "btnCheckVS";
            this.btnCheckVS.Size = new System.Drawing.Size(247, 48);
            this.btnCheckVS.TabIndex = 2;
            this.btnCheckVS.Text = "Kiem tra IMEI voi VintuStore";
            this.btnCheckVS.UseVisualStyleBackColor = true;
            this.btnCheckVS.Click += new System.EventHandler(this.btnCheckVS_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Red;
            this.lblWelcome.Location = new System.Drawing.Point(203, 332);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(477, 44);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome to VintuStore\r\nNoi ban se tim thay nhung dieu tuyet voi nhat";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Image = global::vintustore.Properties.Resources.iphone_models;
            this.pictureBoxLoading.InitialImage = global::vintustore.Properties.Resources.ajax_loader;
            this.pictureBoxLoading.Location = new System.Drawing.Point(14, 438);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(898, 140);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoading.TabIndex = 5;
            this.pictureBoxLoading.TabStop = false;
            // 
            // btn_Admin
            // 
            this.btn_Admin.Location = new System.Drawing.Point(323, 209);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(247, 48);
            this.btn_Admin.TabIndex = 6;
            this.btn_Admin.Text = "Khu Vuc Admin";
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 75);
            this.label1.TabIndex = 7;
            this.label1.Text = "VintuStore\r\n194 Vinh Hoi Quan 4, HCM\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(605, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 87);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hotline:\r\n0903013404 (Mr.TÙNG)  \r\n0909696440(Mr.VINH)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::vintustore.Properties.Resources.iphone_5s_6_grass;
            this.pictureBox1.InitialImage = global::vintustore.Properties.Resources.ajax_loader;
            this.pictureBox1.Location = new System.Drawing.Point(13, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::vintustore.Properties.Resources.size;
            this.pictureBox2.InitialImage = global::vintustore.Properties.Resources.ajax_loader;
            this.pictureBox2.Location = new System.Drawing.Point(605, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(301, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(948, 623);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_iCloudCheck);
            this.tabPage2.Controls.Add(this.lbl_IMEICheck);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.txtIMEI);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.btnCheckVS);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lblWelcome);
            this.tabPage2.Controls.Add(this.btn_Admin);
            this.tabPage2.Controls.Add(this.pictureBoxLoading);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(940, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kiem Tra IMEI - VINTUSTORE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_LoadAppleCheckIMEI);
            this.tabPage1.Controls.Add(this.webBrowser_apple);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(940, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kiem tra IMEI - Apple";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_LoadAppleCheckIMEI
            // 
            this.btn_LoadAppleCheckIMEI.Location = new System.Drawing.Point(6, 7);
            this.btn_LoadAppleCheckIMEI.Name = "btn_LoadAppleCheckIMEI";
            this.btn_LoadAppleCheckIMEI.Size = new System.Drawing.Size(251, 32);
            this.btn_LoadAppleCheckIMEI.TabIndex = 1;
            this.btn_LoadAppleCheckIMEI.Text = "Tai trang Kiem Tra IMEI - Apple";
            this.btn_LoadAppleCheckIMEI.UseVisualStyleBackColor = true;
            this.btn_LoadAppleCheckIMEI.Click += new System.EventHandler(this.btn_LoadAppleCheckIMEI_Click);
            // 
            // webBrowser_apple
            // 
            this.webBrowser_apple.Location = new System.Drawing.Point(6, 44);
            this.webBrowser_apple.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_apple.Name = "webBrowser_apple";
            this.webBrowser_apple.Size = new System.Drawing.Size(916, 544);
            this.webBrowser_apple.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbl_About);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(940, 594);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thong tin them";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbl_About
            // 
            this.lbl_About.AutoSize = true;
            this.lbl_About.Location = new System.Drawing.Point(39, 55);
            this.lbl_About.Name = "lbl_About";
            this.lbl_About.Size = new System.Drawing.Size(410, 160);
            this.lbl_About.TabIndex = 0;
            this.lbl_About.Text = resources.GetString("lbl_About.Text");
            // 
            // btn_iCloudCheck
            // 
            this.btn_iCloudCheck.Location = new System.Drawing.Point(323, 155);
            this.btn_iCloudCheck.Name = "btn_iCloudCheck";
            this.btn_iCloudCheck.Size = new System.Drawing.Size(247, 48);
            this.btn_iCloudCheck.TabIndex = 11;
            this.btn_iCloudCheck.Text = "Kiem tra tinh trang iCloud";
            this.btn_iCloudCheck.UseVisualStyleBackColor = true;
            this.btn_iCloudCheck.Click += new System.EventHandler(this.btn_iCloudCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(950, 647);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check IMEI - VintuStore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_IMEICheck;
        private System.Windows.Forms.TextBox txtIMEI;
        private System.Windows.Forms.Button btnCheckVS;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_LoadAppleCheckIMEI;
        private System.Windows.Forms.WebBrowser webBrowser_apple;
        private System.Windows.Forms.Label lbl_About;
        private System.Windows.Forms.Button btn_iCloudCheck;
    }
}

