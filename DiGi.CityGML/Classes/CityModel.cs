using DiGi.CityGML.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.CityGML.Classes
{
    /// <summary>
    /// Represents a city model that contains a collection of buildings and implements unique identification for CityGML objects.
    /// </summary>
    public class CityModel : Core.Parameter.Classes.ParametrizedUniqueIdObject, ICityGMLUniqueIdObject
    {
        [JsonIgnore]
        private Dictionary<string, Building>? buildings;

        /// <summary>
        /// Initializes a new instance of the <see cref="CityModel"/> class.
        /// </summary>
        public CityModel()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CityModel"/> class using a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the city model.</param>
        public CityModel(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CityModel"/> class by copying an existing city model.
        /// </summary>
        /// <param name="cityModel">The source city model to copy from.</param>
        public CityModel(CityModel? cityModel)
            : base(cityModel)
        {
            if (cityModel is not null)
            {
                Buildings = cityModel.Buildings;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CityModel"/> class with a specified collection of buildings.
        /// </summary>
        /// <param name="buildings">The collection of buildings to associate with this city model.</param>
        public CityModel(IEnumerable<Building>? buildings)
            : base()
        {
            if (buildings != null)
            {
                Buildings = buildings;
            }
        }

        /// <summary>
        /// Gets or sets the collection of buildings contained within the city model.
        /// </summary>
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