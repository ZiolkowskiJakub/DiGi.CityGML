using DiGi.CityGML.Classes;
using DiGi.CityGML.Interfaces;
using System.Collections.Generic;
using System.Xml;

namespace DiGi.CityGML
{
    public static partial class Convert
    {
        public static Building ToCityGML_Building(XmlNode xmlNode)
        {
            if(xmlNode == null)
            {
                return null;
            }

            XmlNodeList xmlNodeList = xmlNode.ChildNodes;
            if (xmlNodeList == null || xmlNodeList.Count == 0)
            {
                return null;
            }

            if (xmlNode.LocalName != Constans.XmlNode.Name.Building)
            {
                foreach(XmlNode xmlNode_Temp in xmlNodeList)
                {
                    if(xmlNode_Temp.LocalName == Constans.XmlNode.Name.Building)
                    {
                        return ToCityGML_Building(xmlNode_Temp);
                    }
                }

                return null;
            }

            string uniqueId = xmlNode.UniqueId();

            List<ISurface> surfaces = null;            
            int roofTypeId = -1;

            foreach (XmlNode xmlNode_Temp in xmlNodeList)
            {
                if (xmlNode_Temp.LocalName == Constans.XmlNode.Name.RoofType)
                {
                    if(int.TryParse(xmlNode_Temp.InnerText, out int roofTypeId_Temp))
                    {
                        roofTypeId = roofTypeId_Temp;
                    }
                }
                else if (xmlNode_Temp.LocalName == Constans.XmlNode.Name.BoundedBy)
                {
                    XmlNodeList xmlNodeList_Surface = xmlNode_Temp.ChildNodes;
                    if(xmlNodeList_Surface == null || xmlNodeList_Surface.Count == 0)
                    {
                        continue;
                    }

                    foreach(XmlNode xmlNode_Surface in xmlNodeList_Surface)
                    {
                        ISurface surface = ToCityGML_Surface(xmlNode_Surface);
                        if (surface == null)
                        {
                            continue;
                        }

                        if(surfaces == null)
                        {
                            surfaces = new List<ISurface>();
                        }

                        surfaces.Add(surface);
                    }
                }
            }

            if(surfaces == null || surfaces.Count == 0)
            {
                foreach (XmlNode xmlNode_Temp in xmlNodeList)
                {
                    if (xmlNode_Temp.LocalName == Constans.XmlNode.Name.LOD1Solid)
                    {
                        XmlNodeList xmlNodeList_Solid = xmlNode_Temp.ChildNodes;
                        if (xmlNodeList_Solid == null || xmlNodeList_Solid.Count == 0)
                        {
                            break;
                        }

                        foreach(XmlNode xmlNode_Solid in xmlNodeList_Solid)
                        {
                            XmlNodeList xmlNodeList_Exterior = xmlNode_Solid.ChildNodes;
                            if (xmlNodeList_Exterior == null || xmlNodeList_Exterior.Count == 0)
                            {
                                continue;
                            }

                            foreach(XmlNode xmlNode_Exterior in xmlNodeList_Exterior)
                            {
                                XmlNodeList xmlNodeList_CompositeSurface = xmlNode_Exterior.ChildNodes;
                                if (xmlNodeList_CompositeSurface == null || xmlNodeList_CompositeSurface.Count == 0)
                                {
                                    continue;
                                }

                                foreach (XmlNode xmlNode_CompositeSurface in xmlNodeList_CompositeSurface)
                                {
                                    XmlNodeList xmlNodeList_SurfaceMember = xmlNode_CompositeSurface.ChildNodes;
                                    if (xmlNodeList_SurfaceMember == null || xmlNodeList_SurfaceMember.Count == 0)
                                    {
                                        continue;
                                    }

                                    foreach(XmlNode xmlNode_SurfaceMember in xmlNodeList_SurfaceMember)
                                    {
                                        ISurface surface = ToCityGML_Surface(xmlNode_SurfaceMember);
                                        if (surface == null)
                                        {
                                            continue;
                                        }

                                        if (surfaces == null)
                                        {
                                            surfaces = new List<ISurface>();
                                        }

                                        surfaces.Add(surface);
                                    }
                                }
                            }
                        }


                        break;
                    }
                }
            }

            Building result = new Building(uniqueId, roofTypeId, surfaces);
            result.SetParameters(xmlNode);

            return result;
        }
    }
}
