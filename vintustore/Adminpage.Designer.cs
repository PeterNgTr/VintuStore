namespace vintustore
{
    partial class Adminpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminpage));
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_IMEI = new System.Windows.Forms.Label();
            this.tbx_IMEI = new System.Windows.Forms.TextBox();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tbx_Specs = new System.Windows.Forms.TextBox();
            this.lbl_Specs = new System.Windows.Forms.Label();
            this.tbx_Date = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tbx_Seller = new System.Windows.Forms.TextBox();
            this.lbl_Seller = new System.Windows.Forms.Label();
            this.tbx_PurID = new System.Windows.Forms.TextBox();
            this.lbl_PurID = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_Purchase = new System.Windows.Forms.Button();
            this.tbx_Price = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.tbx_Specs1 = new System.Windows.Forms.TextBox();
            this.tbc_Invoice = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.linklbl_changepassword = new System.Windows.Forms.LinkLabel();
            this.lbl_newpass = new System.Windows.Forms.Label();
            this.lbl_confirmpass = new System.Windows.Forms.Label();
            this.tbx_newpass = new System.Windows.Forms.TextBox();
            this.tbx_confirmnewpass = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.tbc_Invoice.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_welcome.Location = new System.Drawing.Point(22, 24);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(104, 21);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Chao mung:";
            // 
            // lbl_IMEI
            // 
            this.lbl_IMEI.AutoSize = true;
            this.lbl_IMEI.Location = new System.Drawing.Point(21, 96);
            this.lbl_IMEI.Name = "lbl_IMEI";
            this.lbl_IMEI.Size = new System.Drawing.Size(32, 13);
            this.lbl_IMEI.TabIndex = 1;
            this.lbl_IMEI.Text = "IMEI:";
            // 
            // tbx_IMEI
            // 
            this.tbx_IMEI.Location = new System.Drawing.Point(95, 94);
            this.tbx_IMEI.MaxLength = 15;
            this.tbx_IMEI.Name = "tbx_IMEI";
            this.tbx_IMEI.Size = new System.Drawing.Size(214, 20);
            this.tbx_IMEI.TabIndex = 2;
            // 
            // tbx_Name
            // 
            this.tbx_Name.Location = new System.Drawing.Point(95, 120);
            this.tbx_Name.MaxLength = 128;
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(214, 20);
            this.tbx_Name.TabIndex = 4;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(21, 122);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(51, 13);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Ten may:";
            // 
            // tbx_Specs
            // 
            this.tbx_Specs.Location = new System.Drawing.Point(95, 172);
            this.tbx_Specs.MaxLength = 1024;
            this.tbx_Specs.Name = "tbx_Specs";
            this.tbx_Specs.Size = new System.Drawing.Size(214, 20);
            this.tbx_Specs.TabIndex = 6;
            // 
            // lbl_Specs
            // 
            this.lbl_Specs.AutoSize = true;
            this.lbl_Specs.Location = new System.Drawing.Point(22, 179);
            this.lbl_Specs.Name = "lbl_Specs";
            this.lbl_Specs.Size = new System.Drawing.Size(45, 13);
            this.lbl_Specs.TabIndex = 5;
            this.lbl_Specs.Text = "Mieu ta:";
            // 
            // tbx_Date
            // 
            this.tbx_Date.Location = new System.Drawing.Point(95, 227);
            this.tbx_Date.Name = "tbx_Date";
            this.tbx_Date.ReadOnly = true;
            this.tbx_Date.Size = new System.Drawing.Size(214, 20);
            this.tbx_Date.TabIndex = 8;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(21, 229);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(58, 13);
            this.lbl_Date.TabIndex = 7;
            this.lbl_Date.Text = "Ngay mua:";
            // 
            // tbx_Seller
            // 
            this.tbx_Seller.Location = new System.Drawing.Point(95, 253);
            this.tbx_Seller.Name = "tbx_Seller";
            this.tbx_Seller.ReadOnly = true;
            this.tbx_Seller.Size = new System.Drawing.Size(214, 20);
            this.tbx_Seller.TabIndex = 10;
            // 
            // lbl_Seller
            // 
            this.lbl_Seller.AutoSize = true;
            this.lbl_Seller.Location = new System.Drawing.Point(21, 255);
            this.lbl_Seller.Name = "lbl_Seller";
            this.lbl_Seller.Size = new System.Drawing.Size(59, 13);
            this.lbl_Seller.TabIndex = 9;
            this.lbl_Seller.Text = "Nguoi ban:";
            // 
            // tbx_PurID
            // 
            this.tbx_PurID.Location = new System.Drawing.Point(95, 68);
            this.tbx_PurID.Name = "tbx_PurID";
            this.tbx_PurID.ReadOnly = true;
            this.tbx_PurID.Size = new System.Drawing.Size(214, 20);
            this.tbx_PurID.TabIndex = 12;
            // 
            // lbl_PurID
            // 
            this.lbl_PurID.AutoSize = true;
            this.lbl_PurID.Location = new System.Drawing.Point(21, 70);
            this.lbl_PurID.Name = "lbl_PurID";
            this.lbl_PurID.Size = new System.Drawing.Size(69, 13);
            this.lbl_PurID.TabIndex = 11;
            this.lbl_PurID.Text = "So Hoa Don:";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(28, 292);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(123, 38);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Thoat";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_Purchase
            // 
            this.btn_Purchase.Location = new System.Drawing.Point(186, 292);
            this.btn_Purchase.Name = "btn_Purchase";
            this.btn_Purchase.Size = new System.Drawing.Size(123, 38);
            this.btn_Purchase.TabIndex = 14;
            this.btn_Purchase.Text = "Ban";
            this.btn_Purchase.UseVisualStyleBackColor = true;
            this.btn_Purchase.Click += new System.EventHandler(this.btn_Purchase_Click);
            // 
            // tbx_Price
            // 
            this.tbx_Price.Location = new System.Drawing.Point(95, 146);
            this.tbx_Price.MaxLength = 128;
            this.tbx_Price.Name = "tbx_Price";
            this.tbx_Price.Size = new System.Drawing.Size(214, 20);
            this.tbx_Price.TabIndex = 16;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(21, 148);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(47, 13);
            this.lbl_Price.TabIndex = 15;
            this.lbl_Price.Text = "Gia ban:";
            // 
            // tbx_Specs1
            // 
            this.tbx_Specs1.Location = new System.Drawing.Point(95, 198);
            this.tbx_Specs1.MaxLength = 1024;
            this.tbx_Specs1.Name = "tbx_Specs1";
            this.tbx_Specs1.Size = new System.Drawing.Size(214, 20);
            this.tbx_Specs1.TabIndex = 17;
            // 
            // tbc_Invoice
            // 
            this.tbc_Invoice.Controls.Add(this.tabPage1);
            this.tbc_Invoice.Controls.Add(this.tabPage2);
            this.tbc_Invoice.Location = new System.Drawing.Point(12, 12);
            this.tbc_Invoice.Name = "tbc_Invoice";
            this.tbc_Invoice.SelectedIndex = 0;
            this.tbc_Invoice.Size = new System.Drawing.Size(341, 386);
            this.tbc_Invoice.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_welcome);
            this.tabPage1.Controls.Add(this.tbx_Specs1);
            this.tabPage1.Controls.Add(this.lbl_IMEI);
            this.tabPage1.Controls.Add(this.tbx_Price);
            this.tabPage1.Controls.Add(this.tbx_IMEI);
            this.tabPage1.Controls.Add(this.lbl_Price);
            this.tabPage1.Controls.Add(this.lbl_Name);
            this.tabPage1.Controls.Add(this.btn_Purchase);
            this.tabPage1.Controls.Add(this.tbx_Name);
            this.tabPage1.Controls.Add(this.btn_exit);
            this.tabPage1.Controls.Add(this.lbl_Specs);
            this.tabPage1.Controls.Add(this.tbx_PurID);
            this.tabPage1.Controls.Add(this.tbx_Specs);
            this.tabPage1.Controls.Add(this.lbl_PurID);
            this.tabPage1.Controls.Add(this.lbl_Date);
            this.tabPage1.Controls.Add(this.tbx_Seller);
            this.tabPage1.Controls.Add(this.tbx_Date);
            this.tabPage1.Controls.Add(this.lbl_Seller);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(333, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tao Hoa Don";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_OK);
            this.tabPage2.Controls.Add(this.btn_cancel);
            this.tabPage2.Controls.Add(this.tbx_confirmnewpass);
            this.tabPage2.Controls.Add(this.tbx_newpass);
            this.tabPage2.Controls.Add(this.lbl_confirmpass);
            this.tabPage2.Controls.Add(this.lbl_newpass);
            this.tabPage2.Controls.Add(this.linklbl_changepassword);
            this.tabPage2.Controls.Add(this.lbl_email);
            this.tabPage2.Controls.Add(this.lbl_username);
            this.tabPage2.Controls.Add(this.lbl_quantity);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(333, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thong tin TK";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(23, 57);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(23, 25);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(46, 13);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Ten TK:";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(23, 89);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(108, 13);
            this.lbl_quantity.TabIndex = 0;
            this.lbl_quantity.Text = "So may da ban duoc:";
            // 
            // linklbl_changepassword
            // 
            this.linklbl_changepassword.AutoSize = true;
            this.linklbl_changepassword.Location = new System.Drawing.Point(23, 119);
            this.linklbl_changepassword.Name = "linklbl_changepassword";
            this.linklbl_changepassword.Size = new System.Drawing.Size(70, 13);
            this.linklbl_changepassword.TabIndex = 3;
            this.linklbl_changepassword.TabStop = true;
            this.linklbl_changepassword.Text = "Doi mat khau";
            this.linklbl_changepassword.Click += new System.EventHandler(this.linklbl_changepassword_Click);
            // 
            // lbl_newpass
            // 
            this.lbl_newpass.AutoSize = true;
            this.lbl_newpass.Location = new System.Drawing.Point(23, 159);
            this.lbl_newpass.Name = "lbl_newpass";
            this.lbl_newpass.Size = new System.Drawing.Size(74, 13);
            this.lbl_newpass.TabIndex = 4;
            this.lbl_newpass.Text = "Mat khau moi:";
            // 
            // lbl_confirmpass
            // 
            this.lbl_confirmpass.AutoSize = true;
            this.lbl_confirmpass.Location = new System.Drawing.Point(23, 214);
            this.lbl_confirmpass.Name = "lbl_confirmpass";
            this.lbl_confirmpass.Size = new System.Drawing.Size(122, 13);
            this.lbl_confirmpass.TabIndex = 5;
            this.lbl_confirmpass.Text = "Xac nhan mat khau moi:";
            // 
            // tbx_newpass
            // 
            this.tbx_newpass.Location = new System.Drawing.Point(23, 178);
            this.tbx_newpass.MaxLength = 128;
            this.tbx_newpass.Name = "tbx_newpass";
            this.tbx_newpass.PasswordChar = '*';
            this.tbx_newpass.Size = new System.Drawing.Size(189, 20);
            this.tbx_newpass.TabIndex = 6;
            // 
            // tbx_confirmnewpass
            // 
            this.tbx_confirmnewpass.Location = new System.Drawing.Point(23, 230);
            this.tbx_confirmnewpass.MaxLength = 128;
            this.tbx_confirmnewpass.Name = "tbx_confirmnewpass";
            this.tbx_confirmnewpass.PasswordChar = '*';
            this.tbx_confirmnewpass.Size = new System.Drawing.Size(189, 20);
            this.tbx_confirmnewpass.TabIndex = 7;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(23, 288);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 26);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Huy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(129, 288);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(100, 26);
            this.btn_OK.TabIndex = 9;
            this.btn_OK.Text = "Dong y";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // Adminpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 410);
            this.Controls.Add(this.tbc_Invoice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Adminpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adminpage";
            this.TransparencyKey = System.Drawing.Color.Tomato;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Adminpage_FormClosing);
            this.tbc_Invoice.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_IMEI;
        private System.Windows.Forms.TextBox tbx_IMEI;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tbx_Specs;
        private System.Windows.Forms.Label lbl_Specs;
        private System.Windows.Forms.TextBox tbx_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tbx_Seller;
        private System.Windows.Forms.Label lbl_Seller;
        private System.Windows.Forms.TextBox tbx_PurID;
        private System.Windows.Forms.Label lbl_PurID;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_Purchase;
        private System.Windows.Forms.TextBox tbx_Price;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox tbx_Specs1;
        private System.Windows.Forms.TabControl tbc_Invoice;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.TextBox tbx_confirmnewpass;
        private System.Windows.Forms.TextBox tbx_newpass;
        private System.Windows.Forms.Label lbl_confirmpass;
        private System.Windows.Forms.Label lbl_newpass;
        private System.Windows.Forms.LinkLabel linklbl_changepassword;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_cancel;
    }
}