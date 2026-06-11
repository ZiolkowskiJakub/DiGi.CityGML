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
        /// <summary>
        /// Extracts the polyhedron geometry from a building by collecting its polygonal surface faces.
        /// </summary>
        /// <param name="building">The building instance from which to extract the polyhedron.</param>
        /// <returns>A <see cref="Polyhedron"/> representing the 3D volume of the building, or <c>null</c> if no valid surfaces are found.</returns>
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