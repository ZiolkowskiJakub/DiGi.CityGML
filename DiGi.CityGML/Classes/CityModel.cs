using DiGi.CityGML.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.CityGML.Classes
{
    public class CityModel : Core.Parameter.Classes.ParametrizedUniqueIdObject, ICityGMLUniqueIdObject
    {
        [JsonIgnore]
        private Dictionary<string, Building>? buildings;

        public CityModel()
            : base()
        {
        }

        public CityModel(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public CityModel(CityModel? cityModel)
            : base(cityModel)
        {
            if (cityModel is not null)
            {
                Buildings = cityModel.Buildings;
            }
        }

        public CityModel(IEnumerable<Building>? buildings)
            : base()
        {
            if (buildings != null)
            {
                Buildings = buildings;
            }
        }

        [JsonInclude, JsonPropertyName("Buildings")]
        public IEnumerable<Building>? Buildings
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

                buildings = [];
                foreach (Building building in value)
                {
                    Building? building_Temp = Core.Query.Clone(building);
                    if (!string.IsNullOrEmpty(building_Temp?.UniqueId))
                    {
                        buildings[building_Temp!.UniqueId!] = building_Temp;
                    }
                }
            }
        }
    }
}