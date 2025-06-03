using DiGi.CityGML.Classes;
using System.IO;
using System.Xml;

namespace DiGi.CityGML
{
    public static partial class Create
    {
        public static CityModel CityModel(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path))
            {
                return null;
            }

            string text = File.ReadAllText(path);
            if (string.IsNullOrWhiteSpace(text))
            {
                return null;
            }

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(text);

            XmlNodeList xmlNodeList = xmlDocument.ChildNodes;
            if (xmlNodeList == null || xmlNodeList.Count == 0)
            {
                return null;
            }


            CityModel result = null;
            for (int i = 0; i < xmlNodeList.Count; i++)
            {
                string name = xmlNodeList[i]?.LocalName;

                if (string.IsNullOrWhiteSpace(name))
                {
                    continue;
                }

                if(name == Constans.XmlNode.Name.CityModel)
                {
                    result = Convert.ToCityGML_CityModel(xmlNodeList[i]);
                    if(result != null)
                    {
                        break;
                    }
                }
            }

            return result;
        }
    }
}
