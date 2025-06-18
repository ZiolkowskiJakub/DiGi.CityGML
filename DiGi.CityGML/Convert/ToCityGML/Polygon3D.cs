using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Xml;

namespace DiGi.CityGML
{
    public static partial class Convert
    {
        public static Polygon3D ToCityGML_Polygon3D(XmlNode xmlNode, double tolerance = Core.Constans.Tolerance.Distance)
        {
            XmlNodeList xmlNodeList = xmlNode?.ChildNodes;
            if(xmlNodeList == null || xmlNodeList.Count == 0)
            {
                return null;
            }

            List<Point3D> point3Ds = null;

            if (xmlNodeList.Count == 1 && xmlNodeList[0].LocalName == Constans.XmlNode.Name.PosList)
            {
                point3Ds = ToCityGML_Point3Ds(xmlNodeList[0]);
            }
            else
            {
                point3Ds = new List<Point3D>(); 

                foreach (XmlNode xmlNode_Temp in xmlNodeList)
                {
                    if (xmlNode_Temp.LocalName != Constans.XmlNode.Name.Pos)
                    {
                        continue;
                    }

                    Point3D point3D = ToCityGML_Point3D(xmlNode_Temp);
                    if (point3D == null)
                    {
                        continue;
                    }

                    point3Ds.Add(point3D);
                }
            }

            if(point3Ds == null || point3Ds.Count < 3)
            {
                return null;
            }

            return Geometry.Spatial.Create.Polygon3D(point3Ds);
        }
    }
}
