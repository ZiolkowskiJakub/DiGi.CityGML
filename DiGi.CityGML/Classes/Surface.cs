using DiGi.CityGML.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.CityGML.Classes
{
    /// <summary>
    /// Represents an abstract base class for a surface in the CityGML model, providing unique identification and geometric representation.
    /// </summary>
    public abstract class Surface : Core.Classes.UniqueIdObject, ISurface
    {
        [JsonInclude, JsonPropertyName("Geometry")]
        private readonly IPolygonalFace3D? geometry;

        /// <summary>
        /// Initializes a new instance of the <see cref="Surface"/> class with a specified unique identifier and geometry.
        /// </summary>
        /// <param name="uniqueId">The unique identifier for the surface.</param>
        /// <param name="geometry">The polygonal face representing the 3D geometry of the surface.</param>
        public Surface(string? uniqueId, IPolygonalFace3D? geometry)
            : base(uniqueId)
        {
            this.geometry = Core.Query.Clone(geometry);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Surface"/> class using data from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the surface properties.</param>
        public Surface(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Surface"/> class by cloning an existing surface instance.
        /// </summary>
        /// <param name="surface">The source surface object to clone.</param>
        public Surface(Surface? surface)
            : base(surface)
        {
            if (surface != null)
            {
                geometry = Core.Query.Clone(surface.geometry);
            }
        }

        /// <summary>
        /// Gets the 3D polygonal face geometry associated with this surface.
        /// </summary>
        /// <value>A clone of the underlying <see cref="IPolygonalFace3D"/> geometry, or null if not defined.</value>
        [JsonIgnore]
        public IPolygonalFace3D? Geometry
        {
            get
            {
                return Core.Query.Clone(geometry);
            }
        }
    }
}