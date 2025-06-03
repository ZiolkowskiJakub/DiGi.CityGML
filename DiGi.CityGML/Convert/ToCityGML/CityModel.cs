using DiGi.CityGML.Classes;
using System.Collections.Generic;
using System.Xml;

namespace DiGi.CityGML
{
    public static partial class Convert
    {
        public static CityModel ToCityGML_CityModel(XmlNode xmlNode)
        {
            if(xmlNode == null)
            {
                return null;
            }

            List<Building> buildings = null;

            XmlNodeList xmlNodeList = xmlNode.ChildNodes;
            if(xmlNodeList != null && xmlNodeList.Count != 0)
            {
                buildings = new List<Building>();

                foreach(XmlNode xmlNode_Temp in xmlNodeList)
                {
                    string name = xmlNode_Temp?.LocalName;

                    if (name == Constans.XmlNode.Name.CityObjectMember)
                    {
                        Building building = ToCityGML_Building(xmlNode_Temp);
                        if(building != null)
                        {
                            buildings.Add(building);
                        }
                    }
                }

            }

            CityModel result = new CityModel(buildings);

            return result;
        }
    }
}
