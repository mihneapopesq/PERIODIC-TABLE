using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabelPeriodic2
{
    public partial class Form2 : Form
    {
        string adresa = "https://ro.wikipedia.org/wiki/";

        public Form2()
        {
            InitializeComponent();

        }

        public Form2(string txt)
        {
            adresa += txt;


            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(adresa);

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }
    }
}
