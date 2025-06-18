using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.CityGML.Interfaces
{
    public interface ISurface : ICityGMLUniqueIdObject
    {
        IPolygonalFace3D Geometry { get; }
    }
}
