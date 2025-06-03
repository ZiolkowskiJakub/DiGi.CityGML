using DiGi.CityGML.Classes;
using DiGi.CityGML.Enums;
using System;
using System.Linq;
using System.Xml;

namespace DiGi.CityGML
{
    public static partial class Create
    {
        public static bool SetParameters(this Building building, XmlNode xmlNode)
        {
            if(building == null || xmlNode == null)
            {
                return false;
            }

            XmlNodeList xmlNodeList = xmlNode.ChildNodes;
            if(xmlNodeList == null || xmlNodeList.Count == 0)
            {
                return false;
            }

            bool result = false;
            foreach(XmlNode xmlNode_Temp in xmlNodeList)
            {
                if(xmlNode_Temp.LocalName == Constans.XmlNode.Name.StringAttribute)
                {
                    string value = xmlNode_Temp.Attributes[Constans.XmlAttribute.Name.AttributeName]?.Value;
                    if(string.IsNullOrWhiteSpace(value))
                    {
                        continue;
                    }

                    foreach(BuildingParameter buildingParameter in Enum.GetValues(typeof(BuildingParameter)))
                    {
                        if(value == buildingParameter.ToString())
                        {
                            XmlNode xmlNode_Value = xmlNode_Temp.ChildNodes.Cast<XmlNode>().ToList()?.Find(x => x.LocalName == Constans.XmlNode.Name.Value);
                            if(xmlNode_Value != null)
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
