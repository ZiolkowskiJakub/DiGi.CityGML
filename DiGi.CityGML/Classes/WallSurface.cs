using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.CityGML.Classes
{
    public class WallSurface : Surface
    {
        public WallSurface(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public WallSurface(WallSurface wallSurface)
            : base(wallSurface)
        {

        }

        public WallSurface(string uniqueId, IPolygonalFace3D geometry)
            : base(uniqueId, geometry)
        {

        }
    }
}
