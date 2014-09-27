using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Xml;


namespace vintustore
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
            SetDefaults();
            SetForm();

            txtIMEI.ForeColor = Color.Gray;
            txtIMEI.Text = "Nhap so IMEI gom 15 chu so vao";

        }

        //Set form
        public void SetForm()
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        //CHeck IMEI textbox is not NULL or empty
        public void checktextboxisNULL(TextBox txtcheck)
        {
            if (string.IsNullOrEmpty(txtcheck.Text))
            {
                MessageBox.Show("Xin Vao Long Nhap So IMEI can kiem tra !","Warning");
                SetDefaults();             
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

        //POST data to server
        public static string sendToServer(string Request) 
        { 
                HttpWebRequest request = (System.Net.HttpWebRequest)WebRequest.Create(Request); 
                //HttpWebRequest class is used to Make a request to a Uniform Resource Identifier (URI).  
            //    request.ContentType = "application/x-www-form-urlencoded";
                request.ContentType = "application/json";
               // Set the ContentType property of the WebRequest. 
                request.Method = "POST"; 
                byte[] byteArray = Encoding.UTF8.GetBytes(Request); 
               // Set the ContentLength property of the WebRequest. 
                request.ContentLength = byteArray.Length;  
               //Get the stream that holds request data by calling the GetRequestStream method. 
                Stream dataStream = request.GetRequestStream(); 
                // Write the data to the request stream. 
                dataStream.Write(byteArray, 0, byteArray.Length); 
                // Close the Stream object. 
                dataStream.Close(); 
                WebResponse response = request.GetResponse(); 
               // Get the stream containing content returned by the server.
                //Send the request to the server by calling GetResponse. 
                dataStream = response.GetResponseStream(); 
               // Open the stream using a StreamReader for easy access. 
                StreamReader reader = new StreamReader(dataStream); 
               // Read the content. 
                string Response = reader.ReadToEnd(); 
                //return the response 
                return Response; 
        }

        public void SetDefaults()
        {
            txtIMEI.Text = "";
            txtIMEI.Focus();
            pictureBoxLoading.Visible = true;
            
        }

        public bool CheckIMEIfromVintu(String result)
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

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnCheckVS_Click(sender, e);
            }
        }


        private void btnCheckVS_Click(object sender, EventArgs e)
        {
            
            if (CheckForInternetConnection() == true)
            {
               
                //Check IMEI is valid or not
                if (CheckIMEIValid(txtIMEI) == true)
                {
                    pictureBoxLoading.Visible = true;
                    //Get info from server   
                    string respond;
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.Proxy = new WebProxy("vintustore.netai.net");
                        respond = new WebClient().DownloadString("http://vintustore.netai.net/service.php?IMEI=" + txtIMEI.Text.ToString());
                    
                    }
                                              
                    if (CheckIMEIfromVintu(respond) == true)
                    {
                        string result = respond.Substring(respond.IndexOf("[") + 1, respond.IndexOf("]") - 1);

                        //Format the data
                        string s = result;
                        string[] values = s.Split(',');
                        string moreinfo = values[3].Trim(new Char[] { ' ', '"', '.' });

                        //Show the return data
                        pictureBoxLoading.Visible = false;
                        lblWelcome.Text = "Dien thoai nay mua o cua hang VintuStore" + "\n" +"\n" + "Ten dien thoai:" + values[0] + "\n" + "IMEI:" + values[1] + "\n" + "Gia khi mua:" + values[2] + "\n" + "Thong tin them:" + moreinfo;
                    }
                    else
                    {
                        pictureBoxLoading.Visible = false;
                        lblWelcome.Text = "\n" + "\n" + "\n" + "         May nay khong phai mua o VintuStore";                    
                    }
                                 

                }
                else
                {
                    MessageBox.Show("IMEI khong hop le, xin vui long kiem tra lai  !", "Warning");
                }
            }
            else
            {
                MessageBox.Show("Internet is DOWN. Xin vui long kiem tra lai duong truyen  !", "Warning");
                txtIMEI.Focus();
            }

        }

        private void btnCheckWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://selfsolve.apple.com/agreementWarrantyDynamic.do");
        }

        private void txtIMEI_Click(object sender, EventArgs e)
        {
            txtIMEI.ForeColor = Color.Black;
            txtIMEI.Text = "";
        }

       

        private void txtIMEI_Leave(object sender, EventArgs e)
        {
            txtIMEI.ForeColor = Color.Gray;
            txtIMEI.Text = "Nhap so IMEI gom 15 chu so vao";
        }

        public static void ThreadProc()
        {
            Application.Run(new Login());
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {           
            this.Close();         
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

    }
}
