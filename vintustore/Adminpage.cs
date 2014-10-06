using System;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Reflection;


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
            tbx_Specs.Text = "Tinh trang may:";
            tbx_Specs1.Text = "Bao hanh den:";
            ShowThePasswordArea(false);
            lbl_quantity.Visible = false;
            linklbl_checkupdate.Visible = false;
        }

        internal void PassSeller(string sellername, string email)
        {
            lbl_welcome.Text = "Chao mung: " + sellername;
            tbx_Seller.Text = sellername;
            lbl_username.Text = "Chu TK: " + sellername;
            lbl_email.Text = "Email TK: " + email.Replace("]", "");
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

        public void SetReadOnlyTextbox(bool value)
        {
            tbx_IMEI.ReadOnly = value;
            tbx_Name.ReadOnly = value;
            tbx_Price.ReadOnly = value;
            tbx_Specs.ReadOnly = value;
            tbx_Specs1.ReadOnly = value;
        }

        public void ResetTextbox()
        {
            tbx_IMEI.Text = "";
            tbx_IMEI.Focus();
            tbx_Name.Text = "";
            tbx_Price.Text = "";
            tbx_Specs.Text = "Tinh trang may:";
            tbx_Specs1.Text = "Bao hanh den:";
            tbx_PurID.Text = purchaseprefix + RandomString(5);
        }

        public void ShowThePasswordArea(bool value)
        {
            lbl_newpass.Visible = value;
            tbx_newpass.Visible = value;
            tbx_newpass.Text = "";
            btn_cancel.Visible = value;
            lbl_confirmpass.Visible = value;
            tbx_confirmnewpass.Visible = value;
            tbx_confirmnewpass.Text = "";
            btn_OK.Visible = value;

        }

        public void Writetofile()
        {
            // Compose a string that consists of three lines.
            string desktoppath = Environment.GetFolderPath(
                         System.Environment.SpecialFolder.DesktopDirectory);

            DateTime dateTime = DateTime.UtcNow.Date;
            dateTime.ToString("yyyy");


            string pathtowrite = desktoppath + "\\" + dateTime.ToString("yyyy");

            string lines = "Hoa don ban may VINTUSTORE" + "\r\n" +
                            "=============================" + "\r\n" +
                            "Ngay: " + tbx_Date.Text + "\r\n" +
                            "So hoa don:" + tbx_PurID.Text + "\r\n" +
                            "IMEI: " + tbx_IMEI.Text + "\r\n" +
                            "Ten may:" + tbx_Name.Text + "\r\n" +
                            "Gia ban:" + tbx_Price.Text + "\r\n" +
                            "Mieu ta:" + tbx_Specs.Text + "\\" + tbx_Specs1.Text + "\r\n" +
                            "Nguoi ban:" + tbx_Seller.Text + "\r\n" +
                            "\r\n" +
                            "=============================";

            // Write the string to a file.



            System.IO.Directory.CreateDirectory(pathtowrite);
            FileStream invoice = new FileStream(pathtowrite + "\\hoadon-" + tbx_PurID.Text + ".txt", FileMode.CreateNew);
            byte[] byteData = null;
            byteData = Encoding.ASCII.GetBytes(lines);
            invoice.Write(byteData, 0, byteData.Length);

            invoice.Flush();




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
                            SetReadOnlyTextbox(true);
                            string adddevice;
                            string addpurchase;
                            using (WebClient webClient = new WebClient())
                            {
                                webClient.Proxy = new WebProxy("vintustore.netai.net");
                                adddevice = new WebClient().DownloadString("http://vintustore.netai.net/addnewdevice.php?name=" + tbx_Name.Text + "&imei=" + tbx_IMEI.Text + "&price=" + tbx_Price.Text + "&specs=" + tbx_Specs.Text + "," + tbx_Specs1.Text);
                                addpurchase = new WebClient().DownloadString("http://vintustore.netai.net/addnewpurchasing.php?purid=" + tbx_PurID.Text + "&imei=" + tbx_IMEI.Text + "&purdate=" + tbx_Date.Text + "&adminid=" + tbx_Seller.Text);
                            }
                            if (adddevice != null && addpurchase != null)
                            {
                                if (adddevice.Contains("device") == true && addpurchase == "purchase\t")
                                {
                                    //  ptb_loading.Visible = false;
                                    SetReadOnlyTextbox(false);
                                    MessageBox.Show("Da nhap thanh cong. Hoa don da duoc luu tren Desktop", "Info");
                                    Writetofile();
                                    ResetTextbox();

                                    //  this.Hide();


                                    //  Form1 checkIMEI = new Form1();
                                    //  checkIMEI.Show();
                                }
                                else
                                {

                                    MessageBox.Show("Xin thu lai. Giao dich khong thanh cong", "Info");

                                }
                            }
                            else
                            {
                                MessageBox.Show("Xin thu lai! Co loi xay ra!", "Info");
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

        private void linklbl_changepassword_Click(object sender, EventArgs e)
        {
            ShowThePasswordArea(true);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ShowThePasswordArea(false);
        }


        public bool CheckMatch(TextBox tb1, TextBox tb2)
        {
            if (tb1.Text == tb2.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckValidPassword(TextBox tb1)
        {
            Regex regex = new Regex("^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}$");
            if (regex.IsMatch(tb1.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void btn_OK_Click(object sender, EventArgs e)
        {
            if (CheckValidPassword(tbx_newpass) == true)
            {
                if (CheckMatch(tbx_newpass, tbx_confirmnewpass) == true)
                {
                    if (CheckForInternetConnection() == true)
                    {
                        string changed;

                        using (WebClient webClient = new WebClient())
                        {
                            webClient.Proxy = new WebProxy("vintustore.netai.net");
                            changed = new WebClient().DownloadString("http://vintustore.netai.net/changepassword.php?us=" + tbx_Seller.Text + "&pw=" + tbx_newpass.Text);
                        }
                        if (changed == "success\t")
                        {
                            MessageBox.Show("Doi mau khau thanh cong. Xin vui long dang nhap lai", "Info");
                            this.Hide();

                            Login loginpage = new Login();
                            loginpage.Show();
                        }
                        else
                        {
                            MessageBox.Show("Xin thu lai! Co loi xay ra!", "Info");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Internet is DOWN. Xin vui long kiem tra lai duong truyen  !", "Warning");
                    }
                }
                else
                {
                    MessageBox.Show("Xac nhan mat khau khong trung voi mat khau moi", "Info");
                    tbx_confirmnewpass.Focus();
                }
            }
            else
            {
                MessageBox.Show("Xin nhap mat khau moi." + "\n" + "Mat khau phai:" + "\n" + "-Bat dau bang chu" + "\n" + "-Lon hon hoac bang 8 ky tu", "Info");
            }
        }

        //Check update
        public void checkcurrentversion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fileVersionInfo.ProductVersion;
            lbl_currentversion.Text = "Ban dang dung phien ban: " + version;
        }


        private void linklbl_quantity_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CheckForInternetConnection() == true)
            {
                string countdevices;

                using (WebClient webClient = new WebClient())
                {
                    webClient.Proxy = new WebProxy("vintustore.netai.net");
                    countdevices = new WebClient().DownloadString("http://vintustore.netai.net/count.php?user=" + tbx_Seller.Text);
                }
                if (countdevices != null)
                {
                    lbl_quantity.Visible = true;
                    lbl_quantity.Text = countdevices.Trim(new char[] { '[', ']', '"', '\t' }) + " may";
                }
                else
                {
                    MessageBox.Show("Xin thu lai! Co loi xay ra!", "Info");
                }

            }
            else
            {
                MessageBox.Show("Internet is DOWN. Xin vui long kiem tra lai duong truyen  !", "Warning");
            }
        }

        private void tbc_Invoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkcurrentversion();
        }

        private void linklbl_checkupdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //  AutoUpdater.Start("http://vintustore.netai.net/update/Appcast.xml");
        }


    }
}
