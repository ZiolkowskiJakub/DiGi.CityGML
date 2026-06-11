using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.CityGML.Interfaces
{
    /// <summary>
    /// Defines the contract for a surface object within the CityGML model, 
    /// providing access to its unique identifier and associated 3D polygonal geometry.
    /// </summary>
    public interface ISurface : ICityGMLUniqueIdObject
    {
        /// <summary>
        /// Gets the 3D polygonal face geometry that defines the spatial extent of the surface.
        /// </summary>
        /// <value>The <see cref="IPolygonalFace3D"/> representing the surface geometry, or <c>null</c> if not defined.</value>
        IPolygonalFace3D? Geometry { get; }
    }
}