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
            this.btnCheckWeb = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_IMEICheck
            // 
            this.lbl_IMEICheck.AutoSize = true;
            this.lbl_IMEICheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IMEICheck.ForeColor = System.Drawing.Color.Blue;
            this.lbl_IMEICheck.Location = new System.Drawing.Point(273, 18);
            this.lbl_IMEICheck.Name = "lbl_IMEICheck";
            this.lbl_IMEICheck.Size = new System.Drawing.Size(343, 33);
            this.lbl_IMEICheck.TabIndex = 0;
            this.lbl_IMEICheck.Text = "Nhap so IMEI de kiem tra";
            // 
            // txtIMEI
            // 
            this.txtIMEI.Location = new System.Drawing.Point(321, 67);
            this.txtIMEI.MaxLength = 15;
            this.txtIMEI.Name = "txtIMEI";
            this.txtIMEI.Size = new System.Drawing.Size(247, 21);
            this.txtIMEI.TabIndex = 1;
            this.txtIMEI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIMEI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // btnCheckVS
            // 
            this.btnCheckVS.Location = new System.Drawing.Point(321, 114);
            this.btnCheckVS.Name = "btnCheckVS";
            this.btnCheckVS.Size = new System.Drawing.Size(247, 54);
            this.btnCheckVS.TabIndex = 2;
            this.btnCheckVS.Text = "Kiem tra IMEI voi VintuStore";
            this.btnCheckVS.UseVisualStyleBackColor = true;
            this.btnCheckVS.Click += new System.EventHandler(this.btnCheckVS_Click);
            // 
            // btnCheckWeb
            // 
            this.btnCheckWeb.Location = new System.Drawing.Point(321, 181);
            this.btnCheckWeb.Name = "btnCheckWeb";
            this.btnCheckWeb.Size = new System.Drawing.Size(247, 56);
            this.btnCheckWeb.TabIndex = 3;
            this.btnCheckWeb.Text = "Kiem tra IMEI thong qua Apple";
            this.btnCheckWeb.UseVisualStyleBackColor = true;
            this.btnCheckWeb.Click += new System.EventHandler(this.btnCheckWeb_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Red;
            this.lblWelcome.Location = new System.Drawing.Point(206, 343);
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
            this.pictureBoxLoading.Location = new System.Drawing.Point(17, 449);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(898, 140);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoading.TabIndex = 5;
            this.pictureBoxLoading.TabStop = false;
            // 
            // btn_Admin
            // 
            this.btn_Admin.Location = new System.Drawing.Point(321, 251);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(247, 51);
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
            this.label1.Location = new System.Drawing.Point(12, 57);
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
            this.label2.Location = new System.Drawing.Point(588, 67);
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
            this.pictureBox1.Location = new System.Drawing.Point(16, 135);
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
            this.pictureBox2.Location = new System.Drawing.Point(614, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(301, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(950, 601);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.pictureBoxLoading);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnCheckWeb);
            this.Controls.Add(this.btnCheckVS);
            this.Controls.Add(this.txtIMEI);
            this.Controls.Add(this.lbl_IMEICheck);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_IMEICheck;
        private System.Windows.Forms.TextBox txtIMEI;
        private System.Windows.Forms.Button btnCheckVS;
        private System.Windows.Forms.Button btnCheckWeb;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

