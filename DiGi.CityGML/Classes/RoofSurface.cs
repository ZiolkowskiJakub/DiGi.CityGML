using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.CityGML.Classes
{
    public class RoofSurface : Surface
    {
        public RoofSurface(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public RoofSurface(RoofSurface roofSurface)
            : base(roofSurface)
        {

        }

        public RoofSurface(string uniqueId, IPolygonalFace3D geometry)
            : base(uniqueId, geometry)
        {

        }
    }
}
