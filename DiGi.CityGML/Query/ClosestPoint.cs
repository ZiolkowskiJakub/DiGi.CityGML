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
        public static Point3D? ClosestPoint(this Building? building, Point3D? point3D, double tolerance = Core.Constans.Tolerance.Distance)
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