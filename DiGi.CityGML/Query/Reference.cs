using DiGi.CityGML.Classes;
using DiGi.CityGML.Enums;
using System;

namespace DiGi.CityGML
{
    public static partial class Query
    {
        /// <summary>
        /// Extracts and cleans the reference identifier from buildingId or building's unique ID, 
        /// removing specific prefixes such as "ID-" if present.
        /// </summary>
        /// <param name="building">The <see cref="Building"/> instance to extract the reference from.</param>
        /// <returns>A trimmed string containing buildingId or the processed reference identifier, or null if the building or its unique ID is null.</returns>
        public static string? Reference(this Building? building)
        {
            string? result = building?.GetValue<string>(BuildingParameter.buildingId);
            if(string.IsNullOrWhiteSpace(result))
            {
                result = building?.UniqueId?.Trim();
                if (result == null)
                {
                    return result;
                }

                if (result.StartsWith("ID-"))
                {
                    string[] values = result.Split('-');
                    if (values.Length > 2)
                    {
                        result = string.Join("-", new ArraySegment<string>(values, 2, values.Length - 2));
                    }
                }
            }

            return result;
        }
    }
}