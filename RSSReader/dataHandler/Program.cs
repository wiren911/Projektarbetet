using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace DataHandler
{
    public class Program
    {
       

        //public void GetRssFeed()
        static void Main(string[] args)
        {
            
                var xml = "";
                using (var client = new System.Net.WebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    xml = client.DownloadString("http://bellobard.libsyn.com/rss");
                }
                var dom = new System.Xml.XmlDocument();
                dom.LoadXml(xml);

                foreach(System.Xml.XmlNode item in dom.DocumentElement.SelectNodes("channel/item"))
                {
                    var title = item.SelectSingleNode("title");
                    
                    Console.WriteLine(title.InnerText);
                }
            Console.ReadKey();
        }  
    }
  

}
