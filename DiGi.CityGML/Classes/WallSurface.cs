using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.CityGML.Classes
{
    /// <summary>
    /// Represents a wall surface within the CityGML model, inheriting from the base <see cref="Surface"/> class.
    /// </summary>
    public class WallSurface : Surface
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WallSurface"/> class using the provided JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the wall surface data.</param>
        public WallSurface(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WallSurface"/> class by copying an existing <see cref="WallSurface"/> instance.
        /// </summary>
        /// <param name="wallSurface">The source wall surface instance to copy from.</param>
        public WallSurface(WallSurface? wallSurface)
            : base(wallSurface)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WallSurface"/> class with a specified unique identifier and geometry.
        /// </summary>
        /// <param name="uniqueId">The unique identifier for the wall surface.</param>
        /// <param name="geometry">The polygonal 3D face representing the geometry of the wall surface.</param>
        public WallSurface(string? uniqueId, IPolygonalFace3D? geometry)
            : base(uniqueId, geometry)
        {
        }
    }
}