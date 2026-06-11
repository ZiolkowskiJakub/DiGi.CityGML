using DiGi.CityGML.Classes;
using System;

namespace DiGi.CityGML
{
    public static partial class Query
    {
        /// <summary>
        /// Extracts and cleans the reference identifier from a building's unique ID, 
        /// removing specific prefixes such as "ID-" if present.
        /// </summary>
        /// <param name="building">The <see cref="Building"/> instance to extract the reference from.</param>
        /// <returns>A trimmed string containing the processed reference identifier, or null if the building or its unique ID is null.</returns>
        public static string? Reference(this Building? building)
        {
            string? result = building?.UniqueId?.Trim();
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

            return result;
        }
    }
}