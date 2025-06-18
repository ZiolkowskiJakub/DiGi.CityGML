using DiGi.CityGML.Classes;
using DiGi.CityGML.Enums;
using System.IO;
using System.Xml;

namespace DiGi.CityGML
{
    public static partial class Create
    {
        public static CityModel CityModel(Stream stream, LOD? lOD = null, int? year = null)
        {
            if(stream == null)
            {
                return null;
            }

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(stream);

            return CityModel(xmlDocument, lOD, year);
        }

        public static CityModel CityModel(XmlDocument xmlDocument, LOD? lOD = null, int? year = null)
        {
            if(xmlDocument == null)
            {
                return null;
            }

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

                if (name == Constans.XmlNode.Name.CityModel)
                {
                    result = Convert.ToCityGML_CityModel(xmlNodeList[i]);
                    if (result != null)
                    {
                        break;
                    }
                }
            }

            if (result != null)
            {
                Core.Parameter.Classes.SetValueSettings setValueSettings = new Core.Parameter.Classes.SetValueSettings(true, false);

                if (lOD != null && lOD.HasValue)
                {
                    result.SetValue(CityModelParameter.LOD, lOD, setValueSettings);
                }

                if (year != null && year.HasValue)
                {
                    result.SetValue(CityModelParameter.Year, year, setValueSettings);
                }
            }

            return result;
        }

        public static CityModel CityModel(string path, LOD? lOD = null, int? year = null)
        {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
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

            return CityModel(xmlDocument, lOD, year);
        }
    }
}
