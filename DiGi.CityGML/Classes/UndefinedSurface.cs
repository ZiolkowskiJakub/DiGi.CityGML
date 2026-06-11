using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.CityGML.Classes
{
    /// <summary>
    /// Represents a surface in the CityGML model where the specific type of surface is not defined.
    /// </summary>
    public class UndefinedSurface : Surface
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UndefinedSurface"/> class using a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the surface data.</param>
        public UndefinedSurface(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UndefinedSurface"/> class by copying another instance.
        /// </summary>
        /// <param name="undefinedSurface">The source <see cref="UndefinedSurface"/> instance to copy from.</param>
        public UndefinedSurface(UndefinedSurface? undefinedSurface)
            : base(undefinedSurface)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UndefinedSurface"/> class with a unique identifier and geometry.
        /// </summary>
        /// <param name="uniqueId">The unique identifier for the surface.</param>
        /// <param name="geometry">The polygonal face 3D geometry associated with the surface.</param>
        public UndefinedSurface(string? uniqueId, IPolygonalFace3D? geometry)
            : base(uniqueId, geometry)
        {
        }
    }
}