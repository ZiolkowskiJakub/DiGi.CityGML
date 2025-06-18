using DiGi.CityGML.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using DiGi.CityGML.Interfaces;
using System.Linq;

namespace DiGi.CityGML
{
    public static partial class Query
    {
        public static BoundingBox3D BoundingBox(this Building building)
        {
            IEnumerable<ISurface> surfaces = building?.Surfaces;
            if(surfaces == null || surfaces.Count() == 0)
            {
                return null;
            }

            List<BoundingBox3D> boundingBox3Ds = new List<BoundingBox3D>();
            foreach(ISurface surface in surfaces)
            {
                BoundingBox3D boundingBox3D = surface?.Geometry?.GetBoundingBox();
                if(boundingBox3D == null)
                {
                    continue;
                }

                boundingBox3Ds.Add(boundingBox3D);
            }

            return Geometry.Spatial.Create.BoundingBox3D(boundingBox3Ds);
        }
    }
}
