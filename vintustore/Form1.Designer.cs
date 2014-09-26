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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_IMEICheck
            // 
            this.lbl_IMEICheck.AutoSize = true;
            this.lbl_IMEICheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IMEICheck.Location = new System.Drawing.Point(14, 29);
            this.lbl_IMEICheck.Name = "lbl_IMEICheck";
            this.lbl_IMEICheck.Size = new System.Drawing.Size(252, 25);
            this.lbl_IMEICheck.TabIndex = 0;
            this.lbl_IMEICheck.Text = "Nhap so IMEI de kiem tra";
            // 
            // txtIMEI
            // 
            this.txtIMEI.Location = new System.Drawing.Point(19, 79);
            this.txtIMEI.MaxLength = 15;
            this.txtIMEI.Name = "txtIMEI";
            this.txtIMEI.Size = new System.Drawing.Size(246, 21);
            this.txtIMEI.TabIndex = 1;
            // 
            // btnCheckVS
            // 
            this.btnCheckVS.Location = new System.Drawing.Point(19, 126);
            this.btnCheckVS.Name = "btnCheckVS";
            this.btnCheckVS.Size = new System.Drawing.Size(246, 54);
            this.btnCheckVS.TabIndex = 2;
            this.btnCheckVS.Text = "Kiem tra IMEI voi VintuStore";
            this.btnCheckVS.UseVisualStyleBackColor = true;
            this.btnCheckVS.Click += new System.EventHandler(this.btnCheckVS_Click);
            // 
            // btnCheckWeb
            // 
            this.btnCheckWeb.Location = new System.Drawing.Point(19, 187);
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
            this.lblWelcome.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Red;
            this.lblWelcome.Location = new System.Drawing.Point(277, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(571, 70);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Chao mung den voi VintuStore\r\nNoi ban se tim thay nhung dieu tuyet voi nhat";
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Image = global::vintustore.Properties.Resources.loading;
            this.pictureBoxLoading.InitialImage = global::vintustore.Properties.Resources.ajax_loader;
            this.pictureBoxLoading.Location = new System.Drawing.Point(498, 138);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(121, 105);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoading.TabIndex = 5;
            this.pictureBoxLoading.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 279);
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
            this.Text = "Check IMEI - VintuStore";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
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
    }
}

