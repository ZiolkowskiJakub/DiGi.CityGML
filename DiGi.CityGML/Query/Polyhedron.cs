using DiGi.CityGML.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using DiGi.CityGML.Interfaces;
using System.Linq;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.CityGML
{
    public static partial class Query
    {
        public static Polyhedron Polyhedron(this Building building)
        {
            IEnumerable<ISurface> surfaces = building?.Surfaces;
            if(surfaces == null || surfaces.Count() == 0)
            {
                return null;
            }

            List<IPolygonalFace3D> polygonalFace3Ds = new List<IPolygonalFace3D>();
            foreach(ISurface surface in surfaces)
            {
                IPolygonalFace3D polygonalFace3D = surface?.Geometry;
                if(polygonalFace3D == null)
                {
                    continue;
                }

                polygonalFace3Ds.Add(polygonalFace3D);
            }

            return Geometry.Spatial.Create.Polyhedron(polygonalFace3Ds);
        }
    }
}
