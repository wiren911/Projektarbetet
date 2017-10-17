using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetXML_Click(object sender, EventArgs e)
        {
            //var urlInput = txtURL.Text;
            var listRSS = lstRSS;
            var xmlRSS = "";
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xmlRSS = client.DownloadString("http://bellobard.libsyn.com/rss");
            }
            
        }
    }
}
