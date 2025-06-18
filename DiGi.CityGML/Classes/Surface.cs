using DiGi.CityGML.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.CityGML.Classes
{
    public abstract class Surface : Core.Classes.UniqueIdObject, ISurface
    {
        [JsonInclude, JsonPropertyName("Geometry")]
        private IPolygonalFace3D geometry;

        public Surface(string uniqueId, IPolygonalFace3D geometry)
            : base(uniqueId)
        {
            this.geometry = Core.Query.Clone(geometry);
        }

        public Surface(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Surface(Surface surface)
            : base(surface)
        {
            if(surface != null)
            {
                geometry = Core.Query.Clone(surface.geometry);
            }
        }

        [JsonIgnore]
        public IPolygonalFace3D Geometry
        {
            get
            {
                return Core.Query.Clone(geometry);
            }
        }
    }
}
