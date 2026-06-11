using DiGi.CityGML.Classes;
using DiGi.CityGML.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.CityGML
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the 3D bounding box for the specified building by aggregating the bounding boxes of its constituent surfaces.
        /// </summary>
        /// <param name="building">The building instance from which to calculate the spatial extent.</param>
        /// <returns>A <see cref="BoundingBox3D"/> representing the total volume encompassing all surfaces, or <c>null</c> if the building is null or contains no valid geometry.</returns>
        public static BoundingBox3D? BoundingBox(this Building? building)
        {
            IEnumerable<ISurface>? surfaces = building?.Surfaces;
            if (surfaces == null || surfaces.Count() == 0)
            {
                return null;
            }

            List<BoundingBox3D> boundingBox3Ds = [];
            foreach (ISurface surface in surfaces)
            {
                BoundingBox3D? boundingBox3D = surface?.Geometry?.GetBoundingBox();
                if (boundingBox3D == null)
                {
                    continue;
                }

                boundingBox3Ds.Add(boundingBox3D);
            }

            return Geometry.Spatial.Create.BoundingBox3D(boundingBox3Ds);
        }
    }
}