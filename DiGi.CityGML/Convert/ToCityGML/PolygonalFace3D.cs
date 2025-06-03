using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Xml;

namespace DiGi.CityGML
{
    public static partial class Convert
    {
        public static IPolygonalFace3D ToCityGML_PolygonalFace3D(XmlNode xmlNode, double tolerance = Core.Constans.Tolerance.Distance)
        {
            XmlNodeList xmlNodeList = xmlNode?.ChildNodes;
            if (xmlNodeList == null || xmlNodeList.Count == 0)
            {
                return null;
            }

            IPolygonalFace3D result = null;

            if (xmlNode.LocalName != Constans.XmlNode.Name.Polygon)
            {
                foreach(XmlNode xmlNode_Temp in xmlNodeList)
                {
                    result = ToCityGML_PolygonalFace3D(xmlNode_Temp, tolerance);
                    if(result != null)
                    {
                        return result;
                    }
                }

                return null;
            }

            IPolygonal3D externalEdge3D = null;
            List<IPolygonal3D> internalEdge3Ds = null;

            foreach (XmlNode xmlNode_Temp in xmlNodeList)
            {
                if(xmlNode_Temp.LocalName == Constans.XmlNode.Name.Exterior)
                {
                    XmlNodeList xmlNodeList_LinearRing = xmlNode_Temp?.ChildNodes;
                    foreach(XmlNode xmlNode_LinearRing in xmlNodeList_LinearRing)
                    {
                        if(xmlNode_LinearRing.LocalName == Constans.XmlNode.Name.LinearRing)
                        {
                            IPolygonal3D externalEdge_Temp = ToCityGML_Polygon3D(xmlNode_LinearRing, tolerance);
                            if(externalEdge_Temp != null)
                            {
                                externalEdge3D = externalEdge_Temp;
                            }
                        }
                    }
                }
                else if(xmlNode_Temp.LocalName == Constans.XmlNode.Name.Interior)
                {
                    internalEdge3Ds = new List<IPolygonal3D>();

                    XmlNodeList xmlNodeList_LinearRing = xmlNode_Temp?.ChildNodes;
                    foreach (XmlNode xmlNode_LinearRing in xmlNodeList_LinearRing)
                    {
                        if (xmlNode_LinearRing.LocalName == Constans.XmlNode.Name.LinearRing)
                        {
                            IPolygonal3D internalEdge_Temp = ToCityGML_Polygon3D(xmlNode_LinearRing, tolerance);
                            if (internalEdge_Temp != null)
                            {
                                internalEdge3Ds.Add(internalEdge_Temp);
                            }
                        }
                    }
                }
            }

            if(externalEdge3D == null)
            {
                return null;
            }

            return Geometry.Spatial.Create.PolygonalFace3D(externalEdge3D, internalEdge3Ds, tolerance);
        }
    }
}
