using DiGi.CityGML.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.CityGML.Classes
{
    public class Building : Core.Parameter.Classes.ParametrizedUniqueIdObject, ICityGMLParametrizedUniqueIdObject
    {
        [JsonIgnore]
        private Dictionary<string, ISurface> surfaces;

        [JsonInclude]
        private int roofTypeId;

        public Building(string uniqueId, int roofTypeId, IEnumerable<ISurface> surfaces)
            : base(uniqueId)
        {
            Surfaces = surfaces;
            roofTypeId = roofTypeId;
        }

        public Building(Building building)
            : base(building)
        {
            if(building != null)
            {
                Surfaces = building.surfaces?.Values;
                roofTypeId = building.roofTypeId;
            }
        }

        public Building(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonInclude, JsonPropertyName("Surfaces")]
        public IEnumerable<ISurface> Surfaces
        {
            get
            {
                return surfaces?.Values?.ToList();
            }

            private set
            {
                surfaces = null;

                if (value == null)
                {
                    return;
                }

                surfaces = new Dictionary<string, ISurface>();
                foreach (ISurface surface in value)
                {
                    ISurface surface_Temp = Core.Query.Clone(surface);
                    if (!string.IsNullOrEmpty(surface_Temp.UniqueId))
                    {
                        surfaces[surface_Temp.UniqueId] = surface_Temp;
                    }
                }
            }
        }

        [JsonIgnore]
        public int RoofTypeId
        {
            get
            {
                return roofTypeId;
            }
        }
    }
}
