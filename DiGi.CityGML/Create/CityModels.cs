using DiGi.CityGML.Classes;
using System.Collections.Generic;

namespace DiGi.CityGML
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a list of CityModel objects from a specified file path or directory. 
        /// It supports individual files, ZIP archives, and directories containing ZIP archives, 
        /// attempting to infer the Level of Detail (LOD) and year from the folder hierarchy.
        /// </summary>
        /// <param name="pathOrDirectory">The system path to the file or directory to process. Directory with subfolders [LOD]\[YEAR]\*.zip containing ZIP archives.</param>
        /// <returns>A list of <see cref="Classes.CityModel"/> objects if successful; otherwise, null.</returns>
        public static List<CityModel>? CityModels(string? pathOrDirectory)
        {
            if (string.IsNullOrWhiteSpace(pathOrDirectory))
            {
                return null;
            }

            List<CityModel>? result = [];

            bool succeded = Query.Run(pathOrDirectory, (path, cityModel) =>
            {
                if(cityModel is not null)
                {
                    result.Add(cityModel);
                }
            });

            if (!succeded)
            {
                return null;
            }

            return result;
        }
    }
}