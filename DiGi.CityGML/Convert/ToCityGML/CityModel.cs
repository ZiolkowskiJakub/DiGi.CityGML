using DiGi.CityGML.Classes;
using System.Collections.Generic;
using System.Xml;

namespace DiGi.CityGML
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts an XML node into a <see cref="CityModel"/> instance.
        /// </summary>
        /// <param name="xmlNode">The XML node to be converted.</param>
        /// <returns>A <see cref="CityModel"/> object if the conversion is successful; otherwise, null.</returns>
        public static CityModel? ToCityGML_CityModel(XmlNode? xmlNode)
        {
            if (xmlNode == null)
            {
                return null;
            }

            List<Building>? buildings = null;

            XmlNodeList xmlNodeList = xmlNode.ChildNodes;
            if (xmlNodeList != null && xmlNodeList.Count != 0)
            {
                buildings = [];

                foreach (XmlNode xmlNode_Temp in xmlNodeList)
                {
                    string? name = xmlNode_Temp?.LocalName;

                    if (name == Constants.XmlNode.Name.CityObjectMember)
                    {
                        Building? building = ToCityGML_Building(xmlNode_Temp);
                        if (building != null)
                        {
                            buildings.Add(building);
                        }
                    }
                }
            }

            // The buildings were just built by ToCityGML_Building and are referenced by nothing else, so
            // the city model adopts them rather than deep-copying every surface geometry a third time.
            CityModel result = new(buildings, false);

            return result;
        }
    }
}