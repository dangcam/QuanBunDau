using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace QuanBunDauTienHai
{
    class ReadConfig
    {
        XmlDocument xml;
        public void Read()
        {
            xml = new XmlDocument();
            xml.Load("config.xml");
            AppConfig.SerVer = xml.SelectSingleNode("config/server").InnerText.ToString();
            AppConfig.DataBase = xml.SelectSingleNode("config/batabase").InnerText.ToString();
            AppConfig.Path = xml.SelectSingleNode("config/path").InnerText.ToString();
        }
    }
}
