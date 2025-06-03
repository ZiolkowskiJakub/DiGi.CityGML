using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.CityGML.Classes
{
    public class GroundSurface : Surface
    {
        public GroundSurface(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public GroundSurface(GroundSurface groundSurface)
            : base(groundSurface)
        {

        }

        public GroundSurface(string uniqueId, IPolygonalFace3D geometry)
            : base(uniqueId, geometry)
        {

        }
    }
}
