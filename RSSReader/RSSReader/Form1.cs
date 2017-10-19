using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RSSReader
{


public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var UrlInput = RssUrl.Text;
            Console.ReadLine();
        }

    }
}
