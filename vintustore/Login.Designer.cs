namespace vintustore
{
    partial class Login
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
            this.lbl_admin_welcome = new System.Windows.Forms.Label();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_signin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_admin_welcome
            // 
            this.lbl_admin_welcome.AutoSize = true;
            this.lbl_admin_welcome.Location = new System.Drawing.Point(60, 41);
            this.lbl_admin_welcome.Name = "lbl_admin_welcome";
            this.lbl_admin_welcome.Size = new System.Drawing.Size(169, 13);
            this.lbl_admin_welcome.TabIndex = 0;
            this.lbl_admin_welcome.Text = "Xin vui long dang nhap de tiep tuc";
            // 
            // tbx_username
            // 
            this.tbx_username.Location = new System.Drawing.Point(83, 77);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(146, 20);
            this.tbx_username.TabIndex = 1;
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(83, 103);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(146, 20);
            this.tbx_password.TabIndex = 2;
            this.tbx_password.UseSystemPasswordChar = true;
            this.tbx_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_password_KeyDown);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(18, 80);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(46, 13);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "Ten TK:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(18, 106);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Mat Khau:";
            // 
            // btn_signin
            // 
            this.btn_signin.Location = new System.Drawing.Point(23, 148);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(205, 56);
            this.btn_signin.TabIndex = 5;
            this.btn_signin.Text = "Dang Nhap";
            this.btn_signin.UseVisualStyleBackColor = true;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 220);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.lbl_admin_welcome);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_admin_welcome;
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_signin;
    }
}