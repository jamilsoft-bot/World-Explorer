using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace World_Explorer
{
    public partial class jwe : Form
    {
        public jwe()
        {
            InitializeComponent();
        }



        
        private void Form1_Load(object sender, EventArgs e)
        {

            urlText.Text = "http://";
            searchtext.Text = "Search Google";


            webBrowser.Navigate("https://google.com");
            webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
        }

        void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            tabControl.SelectedTab.Text = webBrowser.DocumentTitle;
            urlText.Text = webBrowser.Url.ToString(); 
        }

        void history()
        {
            
        }

        public void RemoveTab()
        {
            if (tabControl.TabPages.Count - 1 > 0)
            {
                tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
                tabControl.SelectTab(tabControl.TabPages.Count - 1);
            }
        }

        WebBrowser NewTab = null;
        public void CreateTab()
        {
            TabPage tab = new TabPage();
            tab.Text = "Blank Tab";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            NewTab = new WebBrowser() { ScriptErrorsSuppressed = true };
            NewTab.Parent = tab;
            NewTab.Dock = DockStyle.Fill;
            NewTab.Navigate("https://google.com");
            NewTab.DocumentCompleted += NewTab_DocumentCompleted;
            NewTab.ProgressChanged += NewTab_ProgressChanged;


        }

        void NewTab_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                progressBar1.Increment(Convert.ToInt32(e.CurrentProgress));
                progressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
            }
            catch
            {

            }
        }

        void NewTab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = NewTab.DocumentTitle;

            urlText.Text = NewTab.Url.ToString();
        }


        public void Fwd()
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;

            if (web != null)
            {
                if (web.CanGoForward)
                {
                    web.GoForward();
                    web.ProgressChanged +=web_ProgressChanged;
                }
            }
        }

        public void Bwd()
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;

            if (web != null)
            {
                if (web.CanGoBack)
                {
                    web.GoBack();
                    web.ProgressChanged +=web_ProgressChanged;
                }
            }
        }


        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTab();        


        }

        void webtab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            RemoveTab();
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
        }

        private void goToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {

                web.Refresh();
                web.ProgressChanged +=web_ProgressChanged;
                

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fwd();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {

                web.Navigate(urlText.Text);

                web.ProgressChanged += web_ProgressChanged;


            }
        }

        void web_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                progressBar1.Increment(Convert.ToInt32(e.CurrentProgress));
                progressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
            }
            catch
            {

            }   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {

                web.Navigate("http://google.com/search?q=" + searchtext.Text);

                web.ProgressChanged +=web_ProgressChanged;


            }
        }

        private void urlText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;


                web.Navigate(urlText.Text);
                web.DocumentCompleted += web_DocumentCompleted;

                urlText.Text = web.Url.ToString();
                

                
            }
        }

        void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void searchtext_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void searchtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;


                web.Navigate("http://google.com/search?q=" + searchtext.Text);
                



            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
                WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;

                if (web != null)
                {
                    web.ShowPrintDialog();
                }
                



            
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;

            if (web != null)
            {
                web.ShowPrintPreviewDialog();
            }
        }

       
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;

            if (web != null)
            {
                
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void jwe_Click(object sender, EventArgs e)
        {
            
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jwe njwe = new jwe();
            njwe.Show();
        }

        private void newTabToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CreateTab();
        }

        private void printToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            webBrowser.ShowPrintDialog();
        }

        private void printPreviewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            webBrowser.ShowPrintPreviewDialog();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            webBrowser.ShowPageSetupDialog();
            
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {

                web.Navigate("https://sourceforge.net/projects/jamilsoft-world-explorer/files/");

                web.ProgressChanged += web_ProgressChanged;


            }
        
        }

        private void whatsNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About an = new About();
            an.Show();
            an.tabContribute.Show();
            
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About an = new About();
            an.Show();
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTab();

        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveTab();
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {

                web.Navigate("http://google.com");


            }
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {

                web.ShowSaveAsDialog();


            }
        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;

            if (web != null)
            {


                web.Stop();

            }
        }

        private void urlText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
