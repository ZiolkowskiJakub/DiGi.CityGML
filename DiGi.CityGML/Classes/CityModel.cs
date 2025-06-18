using DiGi.CityGML.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace DiGi.CityGML.Classes
{
    public class CityModel : Core.Parameter.Classes.ParametrizedUniqueIdObject, ICityGMLUniqueIdObject
    {
        [JsonIgnore]
        Dictionary<string, Building> buildings;

        public CityModel(IEnumerable<Building> buildings)
            :base()
        {
            if(buildings != null)
            {
                this.buildings = new Dictionary<string, Building>();
                foreach(Building building in buildings)
                {
                    if(string.IsNullOrEmpty(building.UniqueId))
                    {
                        continue;
                    }

                    this.buildings[building.UniqueId] = building;
                }

            }
        }

        [JsonInclude, JsonPropertyName("Buildings")]
        public IEnumerable<Building> Buildings
        {
            get
            {
                return buildings?.Values?.ToList();
            }

            private set
            {
                buildings = null;

                if (value == null)
                {
                    return;
                }

                buildings = new Dictionary<string, Building>();
                foreach (Building building in value)
                {
                    Building building_Temp = Core.Query.Clone(building);
                    if (!string.IsNullOrEmpty(building_Temp.UniqueId))
                    {
                        buildings[building_Temp.UniqueId] = building_Temp;
                    }
                }
            }
        }
    }
}
