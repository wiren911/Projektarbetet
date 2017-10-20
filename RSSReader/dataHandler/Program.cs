using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace DataHandler
{
    class Program
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public void Save (string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(Program));
                XML.Serialize(stream, this);
            }
        }

        public void btnGetXML_Click(object sender, EventArgs e)
        {
            //var urlInput = txtURL.Text;
            var xmlRSS = "";
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xmlRSS = client.DownloadString("http://bellobard.libsyn.com/rss.xml");
            }
            var dom = new System.Xml.XmlDocument();
            dom.LoadXml(xmlRSS);

            foreach (System.Xml.XmlNode item in dom.DocumentElement.SelectNodes("channel/item"))
            {
                var title = item.SelectSingleNode("title");
                
            }
            
        }
        
        static void Main(string[] args)
        {
           
        }
    }
}
