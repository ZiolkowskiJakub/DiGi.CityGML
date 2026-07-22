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
            : this(buildings, true)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CityModel"/> class with a specified collection of buildings, optionally adopting them instead of cloning them.
        /// <para>Internal because adopting is only safe for freshly built, unshared buildings - the parse path in <see cref="Convert"/>. Every public entry point clones.</para>
        /// </summary>
        /// <param name="buildings">The collection of buildings to associate with this city model.</param>
        /// <param name="clone">True to store defensive copies of <paramref name="buildings"/>; false to take ownership of the instances as given.</param>
        internal CityModel(IEnumerable<Building>? buildings, bool clone)
            : base()
        {
            if (buildings != null)
            {
                if (clone)
                {
                    Buildings = buildings;
                }
                else
                {
                    Adopt(buildings);
                }
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

        /// <summary>
        /// Stores the given buildings without cloning them, taking ownership of the instances as given.
        /// </summary>
        /// <param name="buildings">The buildings to adopt.</param>
        private void Adopt(IEnumerable<Building>? buildings)
        {
            this.buildings = null;

            if (buildings == null)
            {
                return;
            }

            this.buildings = [];
            foreach (Building building in buildings)
            {
                if (!string.IsNullOrEmpty(building?.UniqueId))
                {
                    this.buildings[building!.UniqueId!] = building;
                }
            }
        }
    }
}