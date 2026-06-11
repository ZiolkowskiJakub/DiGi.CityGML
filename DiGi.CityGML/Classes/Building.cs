using DiGi.CityGML.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.CityGML.Classes
{
    /// <summary>
    /// Represents a building entity within the CityGML model, providing properties for roof type and associated surfaces.
    /// </summary>
    public class Building : Core.Parameter.Classes.ParametrizedUniqueIdObject, ICityGMLParametrizedUniqueIdObject
    {
        [JsonInclude]
        private readonly int roofTypeId = -1;

        [JsonIgnore]
        private Dictionary<string, ISurface>? surfaces;

        /// <summary>
        /// Initializes a new instance of the <see cref="Building"/> class with specified unique identifier, roof type ID, and surfaces.
        /// </summary>
        /// <param name="uniqueId">The unique identifier for the building.</param>
        /// <param name="roofTypeId">The identifier representing the type of the roof.</param>
        /// <param name="surfaces">A collection of surfaces associated with the building.</param>
        public Building(string? uniqueId, int roofTypeId, IEnumerable<ISurface>? surfaces)
            : base(uniqueId)
        {
            Surfaces = surfaces;
            this.roofTypeId = roofTypeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Building"/> class by copying an existing building instance.
        /// </summary>
        /// <param name="building">The source building object to copy from.</param>
        public Building(Building? building)
            : base(building)
        {
            if (building != null)
            {
                Surfaces = building.surfaces?.Values;
                roofTypeId = building.roofTypeId;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Building"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the building data.</param>
        public Building(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the identifier for the type of roof associated with this building.
        /// </summary>
        [JsonIgnore]
        public int RoofTypeId
        {
            get
            {
                return roofTypeId;
            }
        }

        /// <summary>
        /// Gets or sets the collection of surfaces that constitute the building's geometry.
        /// </summary>
        [JsonInclude, JsonPropertyName("Surfaces")]
        public IEnumerable<ISurface>? Surfaces
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

                surfaces = [];
                foreach (ISurface surface in value)
                {
                    ISurface? surface_Temp = Core.Query.Clone(surface);
                    if (!string.IsNullOrEmpty(surface_Temp?.UniqueId))
                    {
                        surfaces[surface_Temp!.UniqueId!] = surface_Temp;
                    }
                }
            }
        }
    }
}