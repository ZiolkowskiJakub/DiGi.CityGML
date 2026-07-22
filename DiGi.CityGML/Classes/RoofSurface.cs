using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.CityGML.Classes
{
    /// <summary>
    /// Represents a roof surface within the CityGML model, inheriting from the base <see cref="Surface"/> class.
    /// </summary>
    public class RoofSurface : Surface
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoofSurface"/> class using the provided JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data to initialize the roof surface.</param>
        public RoofSurface(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoofSurface"/> class by copying an existing <see cref="RoofSurface"/> instance.
        /// </summary>
        /// <param name="roofSurface">The source <see cref="RoofSurface"/> object to copy from.</param>
        public RoofSurface(RoofSurface? roofSurface)
            : base(roofSurface)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoofSurface"/> class with a specified unique identifier and geometry.
        /// </summary>
        /// <param name="uniqueId">The unique identifier for the roof surface.</param>
        /// <param name="geometry">The 3D polygonal face geometry associated with the roof surface.</param>
        public RoofSurface(string? uniqueId, IPolygonalFace3D? geometry)
            : base(uniqueId, geometry, true)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoofSurface"/> class with a specified unique identifier and geometry, optionally adopting the geometry instead of cloning it.
        /// <para>Internal because adopting is only safe for freshly built, unshared geometry - the parse path in <see cref="Convert"/>. Every public entry point clones.</para>
        /// </summary>
        /// <param name="uniqueId">The unique identifier for the roof surface.</param>
        /// <param name="geometry">The 3D polygonal face geometry associated with the roof surface.</param>
        /// <param name="clone">True to store a defensive copy of <paramref name="geometry"/>; false to take ownership of the instance as given.</param>
        internal RoofSurface(string? uniqueId, IPolygonalFace3D? geometry, bool clone)
            : base(uniqueId, geometry, clone)
        {
        }
    }
}