using System.Xml;

namespace DiGi.CityGML
{
    public static partial class Query
    {
        /// <summary>
        /// Extracts the unique identifier from the attributes of the specified XML node.
        /// </summary>
        /// <param name="xmlNode">The XML node to search for the unique ID attribute.</param>
        /// <returns>The value of the unique ID attribute if it exists; otherwise, <see langword="null"/>.</returns>
        public static string? UniqueId(this XmlNode? xmlNode)
        {
            if (xmlNode == null || xmlNode.Attributes == null || xmlNode.Attributes.Count == 0)
            {
                return null;
            }

            foreach (XmlAttribute xmlAttribute in xmlNode.Attributes)
            {
                if (xmlAttribute?.LocalName == Constants.XmlAttribute.Name.Id)
                {
                    return xmlAttribute.InnerText;
                }
            }

            return null;
        }
    }
}