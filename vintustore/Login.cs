using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vintustore
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            SetForm();
        }

        //Set form
        public void SetForm()
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {

            if (tbx_username.Text == "tung_vintustore" && tbx_password.Text == "tung88")
            {              
                MessageBox.Show(tbx_username.Text + ":Thanh cong");
                OpenNewForm();
            }
            else if (tbx_username.Text == "vinh_vintustore" && tbx_password.Text == "vinh88")
            {

                MessageBox.Show(tbx_username.Text + ":Thanh cong");
                OpenNewForm();
            }
            else if (tbx_username.Text == "danh_vintustore" && tbx_password.Text == "danh88")
            {
                MessageBox.Show(tbx_username.Text + ":Thanh cong");
                OpenNewForm();
            }
            else if (tbx_username.Text == "tin_vintustore" && tbx_password.Text == "tin88")
            {
                MessageBox.Show(tbx_username.Text + ":Thanh cong");
                OpenNewForm();
            }           
            else
            {
                MessageBox.Show("Dang nhap khong thanh cong");
            }
        }
       

        public void OpenNewForm()
        {
            this.Hide();
            string sellerlogin = tbx_username.Text;
            Adminpage admin = new Adminpage();
            admin.PassSeller(sellerlogin);
            admin.Show();
          
        }

       
       

        private void tbx_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_signin_Click(sender, e);
            }
        }



    }
}
