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
            : base(uniqueId, geometry)
        {
        }
    }
}