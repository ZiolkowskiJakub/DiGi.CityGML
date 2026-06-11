using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Xml;

namespace DiGi.CityGML
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts an XML node representing a CityGML polygon into a <see cref="Polygon3D"/> object.
        /// </summary>
        /// <param name="xmlNode">The XML node containing the polygon data, which may consist of a position list or individual position elements.</param>
        /// <returns>A <see cref="Polygon3D"/> instance if the conversion is successful and at least three points are defined; otherwise, <c>null</c>.</returns>
        public static Polygon3D? ToCityGML_Polygon3D(XmlNode? xmlNode)
        {
            XmlNodeList? xmlNodeList = xmlNode?.ChildNodes;
            if (xmlNodeList == null || xmlNodeList.Count == 0)
            {
                return null;
            }

            List<Point3D>? point3Ds;
            if (xmlNodeList.Count == 1 && xmlNodeList[0].LocalName == Constants.XmlNode.Name.PosList)
            {
                point3Ds = ToCityGML_Point3Ds(xmlNodeList[0]);
            }
            else
            {
                point3Ds = [];

                foreach (XmlNode xmlNode_Temp in xmlNodeList)
                {
                    if (xmlNode_Temp.LocalName != Constants.XmlNode.Name.Pos)
                    {
                        continue;
                    }

                    Point3D? point3D = ToCityGML_Point3D(xmlNode_Temp);
                    if (point3D == null)
                    {
                        continue;
                    }

                    point3Ds.Add(point3D);
                }
            }

            if (point3Ds == null || point3Ds.Count < 3)
            {
                return null;
            }

            return Geometry.Spatial.Create.Polygon3D(point3Ds);
        }
    }
}