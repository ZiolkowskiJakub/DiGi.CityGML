using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.CityGML.Classes
{
    public class UndefinedSurface : Surface
    {
        public UndefinedSurface(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public UndefinedSurface(UndefinedSurface undefinedSurface)
            : base(undefinedSurface)
        {

        }

        public UndefinedSurface(string uniqueId, IPolygonalFace3D geometry)
            : base(uniqueId, geometry)
        {

        }
    }
}
