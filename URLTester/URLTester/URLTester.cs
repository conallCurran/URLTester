using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace URLTester
{
    public partial class URLTester1 : Form
    {

        private static StreamWriter SW;
        private static HttpWebResponse response;
       


        public URLTester1()
        {
            InitializeComponent();
        }


        //Web Page Active?

        private void button1_Click(object sender, EventArgs e)
        {
            Uri fileURI = new Uri(URLbox1.Text);

            //tests http response 
            WebRequest request = WebRequest.Create(fileURI);
            HttpWebResponse response = null;

            request.Method = "HEAD";


            bool exists = false;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
                exists = response.StatusCode == HttpStatusCode.OK;

            }
            catch
            {
                exists = false;
            }
            finally
            {
                // close your response.
                if (response != null)

                    response.Close();
            }

            if (exists)
            {
                label1.Text = "Active";
                label1.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label1.Text = "Inactive";
                label1.ForeColor = System.Drawing.Color.Red;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            BrokenLinks.Text = String.Empty;
            cbl_items.Items.Clear();
            label2.Text = "";



            Uri fileURI = new Uri(URLbox2.Text);

            WebRequest request = WebRequest.Create(fileURI);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();

            SW = File.CreateText("C:\\Users\\Conal_Curran\\OneDrive\\C#\\MyProjects\\Web Crawler\\URLTester\\response1.htm");
            SW.WriteLine(responseFromServer);
            SW.Close();

            BrokenLinks.Text = String.Empty;

            HtmlWeb hw = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc = hw.Load("C:\\Users\\Conal_Curran\\OneDrive\\C#\\MyProjects\\Web Crawler\\URLTester\\response1.htm");
            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty);
                Console.WriteLine(hrefValue);
                cbl_items.Items.Add(hrefValue);
            
        }
            
    }
        
        

        private void button3_Click(object sender, EventArgs e)
        {
            Uri URI = new Uri(cbl_items.Text);

            //tests http response 
            WebRequest request = WebRequest.Create(URI);
            HttpWebResponse response = null;

            request.Method = "HEAD";


            bool exists = false;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
                exists = response.StatusCode == HttpStatusCode.OK;

            }
            catch
            {
                exists = false;
            }
            finally
            {
                // close your response.
                if (response != null)
                    response.Close();
            }

            if (exists)
            {
                label2.Text = "None";
                label2.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                label2.Text = "Some";
                label2.ForeColor = System.Drawing.Color.Red;
                Console.WriteLine(cbl_items.Text);
                BrokenLinks.Text = cbl_items.Text;

            }

        }

    

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BrokenLinks_TextChanged(object sender, EventArgs e)
        {

        }

        private void BrokenLinks_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void URLTester1_Load(object sender, EventArgs e)
        {

        }
    }
}








