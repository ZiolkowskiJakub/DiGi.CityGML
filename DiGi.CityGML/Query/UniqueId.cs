using System.Xml;

namespace DiGi.CityGML
{
    public static partial class Query
    {
        public static string UniqueId(this XmlNode xmlNode)
        {
            if(xmlNode == null || xmlNode.Attributes == null || xmlNode.Attributes.Count == 0)
            {
                return null;
            }

            foreach(XmlAttribute xmlAttribute in xmlNode.Attributes)
            {
                if(xmlAttribute?.LocalName == Constans.XmlAttribute.Name.Id)
                {
                    return xmlAttribute.InnerText;
                }
            }

            return null;
        }
    }
}
