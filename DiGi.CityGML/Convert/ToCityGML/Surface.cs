using DiGi.CityGML.Classes;
using DiGi.CityGML.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Xml;

namespace DiGi.CityGML
{
    public static partial class Convert
    {
        public static ISurface ToCityGML_Surface(XmlNode xmlNode)
        {
            if (xmlNode == null)
            {
                return null;
            }

            IPolygonalFace3D polygonalFace3D = ToCityGML_PolygonalFace3D(xmlNode);
            if(polygonalFace3D == null)
            {
                return null;
            }

            string uniqueId = Query.UniqueId(xmlNode);
            if(string.IsNullOrWhiteSpace(uniqueId) && xmlNode.ChildNodes != null && xmlNode.ChildNodes.Count != 0)
            {
                uniqueId = Query.UniqueId(xmlNode.ChildNodes[0]);
            }

            switch(xmlNode.LocalName)
            {
                case Constans.XmlNode.Name.RoofSurface:
                    return new RoofSurface(uniqueId, polygonalFace3D);

                case Constans.XmlNode.Name.WallSurface:
                    return new WallSurface(uniqueId, polygonalFace3D);

                case Constans.XmlNode.Name.GroundSurface:
                    return new GroundSurface(uniqueId, polygonalFace3D);

                default:
                    return new UndefinedSurface(uniqueId, polygonalFace3D);
            }
        }
    }
}
