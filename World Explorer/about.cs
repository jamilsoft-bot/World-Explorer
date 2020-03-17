using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace World_Explorer
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

      
        private void about_Load(object sender, EventArgs e)
        {
            

        }

        jwe nmain = new jwe();
        private void button3_Click(object sender, EventArgs e)
        {
            WebBrowser web = nmain.tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                nmain.Show();
                web.Navigate("https://paystack.com/pay/jamilsoft");

                web.ProgressChanged += web_ProgressChanged;


            }
            
            nmain.webBrowser.Navigate("https://paystack.com/pay/jamilsoft");
            nmain.webBrowser.ProgressChanged += webBrowser_ProgressChanged;
            this.Hide();
        }

        void web_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                nmain.progressBar1.Increment(Convert.ToInt32(e.CurrentProgress));
                nmain.progressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
            }
            catch
            {

            }
        }

        void webBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                nmain.progressBar1.Increment(Convert.ToInt32(e.CurrentProgress));
                nmain.progressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nmain.webBrowser.Navigate("https://sourceforge.net/u/myakububauchi/profile");
            nmain.webBrowser.ProgressChanged += webBrowser_ProgressChanged;
            nmain.Show();
            this.Hide();
        }

        private void tabCurtesy_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebBrowser web = nmain.tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                nmain.Show();
                web.Navigate("https://paystack.com/pay/jamilsoft");

                web.ProgressChanged += web_ProgressChanged;


            }

            nmain.webBrowser.Navigate("https://paystack.com/pay/jamilsoft");
            nmain.webBrowser.ProgressChanged += webBrowser_ProgressChanged;
            this.Hide();
        }
    }
}
