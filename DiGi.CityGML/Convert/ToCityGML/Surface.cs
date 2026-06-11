using DiGi.CityGML.Classes;
using DiGi.CityGML.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Xml;

namespace DiGi.CityGML
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts an XML node to a CityGML surface implementation based on the node's local name and content.
        /// </summary>
        /// <param name="xmlNode">The XML node to be converted into a surface.</param>
        /// <returns>An instance of <see cref="ISurface"/> (such as RoofSurface, WallSurface, or GroundSurface) if the conversion is successful; otherwise, <c>null</c>.</returns>
        public static ISurface? ToCityGML_Surface(XmlNode? xmlNode)
        {
            if (xmlNode == null)
            {
                return null;
            }

            IPolygonalFace3D? polygonalFace3D = ToCityGML_PolygonalFace3D(xmlNode);
            if (polygonalFace3D == null)
            {
                return null;
            }

            string? uniqueId = Query.UniqueId(xmlNode);
            if (string.IsNullOrWhiteSpace(uniqueId) && xmlNode.ChildNodes != null && xmlNode.ChildNodes.Count != 0)
            {
                uniqueId = Query.UniqueId(xmlNode.ChildNodes[0]);
            }

            return xmlNode.LocalName switch
            {
                Constants.XmlNode.Name.RoofSurface => new RoofSurface(uniqueId, polygonalFace3D),
                Constants.XmlNode.Name.WallSurface => new WallSurface(uniqueId, polygonalFace3D),
                Constants.XmlNode.Name.GroundSurface => new GroundSurface(uniqueId, polygonalFace3D),
                _ => new UndefinedSurface(uniqueId, polygonalFace3D),
            };
        }
    }
}