using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

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


        public bool CheckUserName(String result)
        {
            if (result == "null\t")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
      
        private void btn_signin_Click(object sender, EventArgs e)
        {
            string returnedusername;
            using (WebClient webClient = new WebClient())
            {
                webClient.Proxy = new WebProxy("vintustore.netai.net");
                returnedusername = new WebClient().DownloadString("http://vintustore.netai.net/getuser.php?user=" + tbx_username.Text+"&password=" +tbx_password.Text );                
            }

            if (CheckUserName(returnedusername) == true)
            {              
                MessageBox.Show("Xin chao ! "+ tbx_username.Text + " : Dang nhap thanh cong","Welcome");
                OpenNewForm();
            }                                
            else
            {
                MessageBox.Show("Thu lai ! Dang nhap khong thanh cong");
                tbx_username.Focus();
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 checkIMEI = new Form1();
            checkIMEI.Show();
        }



    }
}
