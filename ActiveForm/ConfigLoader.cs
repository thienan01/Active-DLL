using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ActiveForm
{
    public class ConfigLoader
    {
        public Dictionary<string, string> ReadConfigFile(string fileName)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            XmlDocument docXML = new XmlDocument();
            docXML.Load(fileName);
            XmlNodeList lsNode;
            lsNode = docXML.GetElementsByTagName("setting");
            foreach (XmlNode node in lsNode)
            {
                string outterXML = node.OuterXml;
                string[] lsName = outterXML.Split('"');
                string name = lsName[1];
                string value = node.InnerText;
                dic.Add(name, value);
            }
            return dic;
        }

        public  string WriteConfigFile(Dictionary<string, string> dic, string fileName,out bool result)
        {
            result = false;
            try
            {
                XmlDocument docXML = new XmlDocument();
                docXML.Load(fileName);
                XmlNodeList lsNode;
                lsNode = docXML.GetElementsByTagName("setting");
                foreach (XmlNode node in lsNode)
                {
                    string outterXML = node.OuterXml;
                    string[] lsName = outterXML.Split('"');
                    string name = lsName[1];
                    node.InnerXml = "<value>" + dic[name] + "</value>";
                }
                docXML.Save(fileName);
                result =  true;
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
