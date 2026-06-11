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
        /// Calculates the point on the surfaces of the specified building that is closest to the provided 3D point.
        /// </summary>
        /// <param name="building">The building instance whose surfaces are analyzed to find the nearest point.</param>
        /// <param name="point3D">The reference 3D point used for the distance calculation.</param>
        /// <returns>The closest <see cref="Point3D"/> found across all surfaces of the building, or <c>null</c> if the building is null, the point is null, or no valid surfaces exist.</returns>
        public static Point3D? ClosestPoint(this Building? building, Point3D? point3D)
        {
            if (building == null || point3D == null)
            {
                return null;
            }

            IEnumerable<ISurface>? surfaces = building?.Surfaces;
            if (surfaces == null || surfaces.Count() == 0)
            {
                return null;
            }

            double distance = double.MaxValue;
            Point3D? result = null;
            foreach (ISurface surface in surfaces)
            {
                IPolygonalFace3D? polygonalFace3D = surface?.Geometry;
                if (polygonalFace3D == null)
                {
                    continue;
                }

                Point3D? point3D_Temp = polygonalFace3D.ClosestPoint(point3D);
                if (point3D_Temp == null)
                {
                    continue;
                }

                double distance_Temp = point3D_Temp.Distance(point3D);
                if (distance_Temp < distance)
                {
                    result = point3D_Temp;
                    distance = distance_Temp;
                }
            }

            return result;
        }
    }
}