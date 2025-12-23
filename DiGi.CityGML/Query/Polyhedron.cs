using DiGi.CityGML.Classes;
using DiGi.CityGML.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.CityGML
{
    public static partial class Query
    {
        public static Polyhedron? Polyhedron(this Building? building)
        {
            IEnumerable<ISurface>? surfaces = building?.Surfaces;
            if (surfaces == null || surfaces.Count() == 0)
            {
                return null;
            }

            List<IPolygonalFace3D> polygonalFace3Ds = [];
            foreach (ISurface surface in surfaces)
            {
                IPolygonalFace3D? polygonalFace3D = surface?.Geometry;
                if (polygonalFace3D == null)
                {
                    continue;
                }

                polygonalFace3Ds.Add(polygonalFace3D);
            }

            return Geometry.Spatial.Create.Polyhedron(polygonalFace3Ds);
        }
    }
}
