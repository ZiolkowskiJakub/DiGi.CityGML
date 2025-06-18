using DiGi.CityGML.Classes;
using System;

namespace DiGi.CityGML
{
    public static partial class Query
    {
        public static string Reference(this Building building)
        {
            string result = building?.UniqueId?.Trim();
            if(result == null)
            {
                return result;
            }

            if (result.StartsWith("ID-"))
            {
                string[] values = result.Split('-');
                if(values.Length > 2)
                {
                    result = string.Join("-", new ArraySegment<string>(values, 2, values.Length - 2));
                }
            }

            return result;
        }
    }
}
