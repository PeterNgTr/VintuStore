using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace vintustore
{
    public partial class Adminpage : Form
    {
        static string purchaseprefix = "vintu";
        
        private readonly Random _rng = new Random();
       
        private const string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

        private string RandomString(int size)
        {
            char[] buffer = new char[size];

            for (int i = 0; i < size; i++)
            {
                buffer[i] = _chars[_rng.Next(_chars.Length)];
            }
            return new string(buffer);
        }
            
        public Adminpage()
        {
            InitializeComponent();
            SetForm();

            tbx_PurID.Text = purchaseprefix + RandomString(5);
            tbx_Date.Text = getCurrentDate();
          
        }

        internal void PassSeller(string sellername)
        {
            lbl_welcome.Text = "Chao mung: " + sellername;
            tbx_Seller.Text = sellername;
        }

        public string getCurrentDate()
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            return dateTime.ToString("dd/MM/yyyy");
        }

        //Set form
        public void SetForm()
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
           // ptb_loading.Visible = false;
        }

        public static void ThreadProc()
        {
            Application.Run(new Form1());
        }        

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
        }

        //CHeck textbox is not NULL or empty
        public bool checktextboxisNULL(TextBox txtcheck)
        {
            if (string.IsNullOrEmpty(txtcheck.Text))
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        //Check Internet Connection
        public static bool CheckForInternetConnection()
        {
            try
            {
                System.Net.IPHostEntry i = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Check IMEI valid
        private bool CheckIMEIValid(TextBox txtcheck)
        {
            Regex regex = new Regex("^[0-9]{15}(,[0-9]{15})*$");
            if (regex.IsMatch(txtcheck.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void Adminpage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
      
        private void btn_Purchase_Click(object sender, EventArgs e)
        {

            if (checktextboxisNULL(tbx_Name) == false)
            {
                if (checktextboxisNULL(tbx_Specs) == false)
                {
                    if (CheckIMEIValid(tbx_IMEI) == true)
                    {
                        if (CheckForInternetConnection() == true)
                        {
                           // ptb_loading.Visible = true;
                            string adddevice;
                            string addpurchase;
                            using (WebClient webClient = new WebClient())
                            {
                                webClient.Proxy = new WebProxy("vintustore.netai.net");
                                adddevice = new WebClient().DownloadString("http://vintustore.netai.net/addnewdevice.php?name=" + tbx_Name.Text + "&imei=" + tbx_IMEI.Text + "&price=" + tbx_Price.Text + "&specs=" + tbx_Specs.Text + " " + tbx_Seller.Text + " " + tbx_Date.Text + " " + tbx_PurID.Text);
                                addpurchase = new WebClient().DownloadString("http://vintustore.netai.net/addnewpurchasing.php?purid=" + tbx_PurID.Text + "&imei=" + tbx_IMEI.Text + "&purdate=" + tbx_Date.Text + "&adminid=" + tbx_Seller.Text);
                            }


                            if (adddevice == "device\t" && addpurchase == "purchase\t")
                            {
                              //  ptb_loading.Visible = false;
                                MessageBox.Show("Da nhap thanh cong", "Info");
                                this.Hide();
                                

                                Form1 checkIMEI = new Form1();
                                checkIMEI.Show();
                            }
                            else
                            {

                                MessageBox.Show("Xin thu lai. Giao dich khong thanh cong", "Info");
                                tbx_PurID.Text = purchaseprefix + RandomString(5);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Internet is DOWN. Xin vui long kiem tra lai duong truyen  !", "Warning");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xin nhap IMEI hop le", "Warning");
                    }

                }
                else
                {
                    MessageBox.Show("Xin vui long nhap Mieu ta", "Info");
                }
            }
            else
            {
                MessageBox.Show("Xin vui long nhap Ten dien thoai", "Info");
            }
           
        }
       
    }
}
