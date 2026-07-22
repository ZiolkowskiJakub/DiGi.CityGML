using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.CityGML.Classes
{
    /// <summary>
    /// Represents a ground surface in the CityGML model, typically used to define the terrain or floor surfaces.
    /// </summary>
    public class GroundSurface : Surface
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroundSurface"/> class using a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data to initialize the ground surface.</param>
        public GroundSurface(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundSurface"/> class by copying an existing <see cref="GroundSurface"/> instance.
        /// </summary>
        /// <param name="groundSurface">The ground surface instance to copy from.</param>
        public GroundSurface(GroundSurface? groundSurface)
            : base(groundSurface)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundSurface"/> class with a specified unique identifier and geometry.
        /// </summary>
        /// <param name="uniqueId">The unique identifier for the ground surface.</param>
        /// <param name="geometry">The 3D polygonal face geometry associated with the ground surface.</param>
        public GroundSurface(string? uniqueId, IPolygonalFace3D? geometry)
            : base(uniqueId, geometry, true)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundSurface"/> class with a specified unique identifier and geometry, optionally adopting the geometry instead of cloning it.
        /// <para>Internal because adopting is only safe for freshly built, unshared geometry - the parse path in <see cref="Convert"/>. Every public entry point clones.</para>
        /// </summary>
        /// <param name="uniqueId">The unique identifier for the ground surface.</param>
        /// <param name="geometry">The 3D polygonal face geometry associated with the ground surface.</param>
        /// <param name="clone">True to store a defensive copy of <paramref name="geometry"/>; false to take ownership of the instance as given.</param>
        internal GroundSurface(string? uniqueId, IPolygonalFace3D? geometry, bool clone)
            : base(uniqueId, geometry, clone)
        {
        }
    }
}