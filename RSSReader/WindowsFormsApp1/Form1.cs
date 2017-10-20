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

        string[,] rssData = null;

        private String[,] getRssData(String channel)
        {
            System.Net.WebRequest myRequest = System.Net.WebRequest.Create(channel);
            System.Net.WebResponse myResponse = myRequest.GetResponse();

            System.IO.Stream rssStream = myResponse.GetResponseStream();
            System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();

            System.Xml.XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");

            //Här skapas en Array av detta kontent: titlar,descriptions,länkar. 
            String[,] tempRssData = new string[100, 3];
            for (int i = 0; i < rssItems.Count; i++)
            {
                System.Xml.XmlNode rssNode;


                rssNode = rssItems.Item(i).SelectSingleNode("title");
                if (rssNode != null)
                {
                    tempRssData[i, 0] = rssNode.InnerText;
                }
                else
                {
                    tempRssData[i, 0] = "";
                }
                rssNode = rssItems.Item(i).SelectSingleNode("describtion");
                if (rssNode != null)
                {
                    tempRssData[i, 1] = rssNode.InnerText;
                }
                else
                {
                    tempRssData[i, 1] = "";
                }

                rssNode = rssItems.Item(i).SelectSingleNode("Link");
                if (rssNode != null)
                {
                    tempRssData[i, 2] = rssNode.InnerText;
                }
                else
                {
                    tempRssData[i, 2] = "";
                }
            }

            return tempRssData;

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

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homebutton_Click(object sender, EventArgs e)
        {

        }

        private void CombTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rssData[combtitle.SelectedIndex, 1] != null)
            {
                dtextfild.Text = rssData[combtitle.SelectedIndex, 1];
            }
            if (rssData[combtitle.SelectedIndex, 2] != null)
            {
                linkLabel1.Text = "Gå till:" + rssData[combtitle.SelectedIndex, 0];
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (rssData[combtitle.SelectedIndex, 2] != null)
            {
                System.Diagnostics.Process.Start(rssData[combtitle.SelectedIndex, 2]);
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            combtitle.Items.Clear();
            rssData = getRssData(textBox2.Text);
            for (int i = 0; i < rssData.GetLength(0); i++)
            {
                if (rssData[i, 0] != null)
                {
                    combtitle.Items.Add(rssData[i, 0]);
                }
                combtitle.SelectedIndex = 0;
            }
        }
    }
}
