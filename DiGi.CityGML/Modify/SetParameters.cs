using DiGi.CityGML.Classes;
using DiGi.CityGML.Enums;
using System;
using System.Linq;
using System.Xml;

namespace DiGi.CityGML
{
    public static partial class Create
    {
        /// <summary>
        /// Sets the parameters of a building instance by parsing the provided XML node for attribute names and values that match known building parameters.
        /// </summary>
        /// <param name="building">The <see cref="Building"/> instance to be updated.</param>
        /// <param name="xmlNode">The <see cref="XmlNode"/> containing the parameter data to process.</param>
        /// <returns>True if at least one building parameter was successfully identified and set; otherwise, false.</returns>
        public static bool SetParameters(this Building? building, XmlNode? xmlNode)
        {
            if (building == null || xmlNode == null)
            {
                return false;
            }

            XmlNodeList xmlNodeList = xmlNode.ChildNodes;
            if (xmlNodeList == null || xmlNodeList.Count == 0)
            {
                return false;
            }

            bool result = false;
            foreach (XmlNode xmlNode_Temp in xmlNodeList)
            {
                if (xmlNode_Temp.LocalName == Constants.XmlNode.Name.StringAttribute)
                {
                    string? value = xmlNode_Temp.Attributes[Constants.XmlAttribute.Name.AttributeName]?.Value;
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        continue;
                    }

                    foreach (BuildingParameter buildingParameter in Enum.GetValues(typeof(BuildingParameter)))
                    {
                        if (value == buildingParameter.ToString())
                        {
                            XmlNode? xmlNode_Value = xmlNode_Temp.ChildNodes.Cast<XmlNode>().ToList()?.Find(x => x.LocalName == Constants.XmlNode.Name.Value);
                            if (xmlNode_Value != null)
                            {
                                building.SetValue(buildingParameter, xmlNode_Value.InnerText);
                                result = true;
                            }

                            break;
                        }
                    }
                }
            }

            return result;
        }
    }
}