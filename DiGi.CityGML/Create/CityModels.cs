using DiGi.CityGML.Classes;
using DiGi.CityGML.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

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

            string[]? paths_Zip = null;

            List<CityModel>? result = null;

            if (File.Exists(pathOrDirectory))
            {
                if (Path.GetExtension(pathOrDirectory) == ".zip")
                {
                    paths_Zip = [pathOrDirectory!];
                }
                else
                {
                    LOD? lOD = null;
                    int? year = null;

                    string yearString = Path.GetFileName(Path.GetDirectoryName(pathOrDirectory));
                    if (!string.IsNullOrWhiteSpace(yearString) && int.TryParse(yearString.Trim(), out int year_Temp))
                    {
                        year = year_Temp;
                    }

                    string lODString = Path.GetFileName(Path.GetDirectoryName(Path.GetDirectoryName(pathOrDirectory)));
                    if (!string.IsNullOrWhiteSpace(lODString) && Enum.TryParse(lODString, out LOD lOD_Temp))
                    {
                        lOD = lOD_Temp;
                    }

                    CityModel? cityModel = CityModel(pathOrDirectory, lOD, year);
                    if (cityModel != null)
                    {
                        result = [cityModel];
                    }

                    return result;
                }
            }
            else if (Directory.Exists(pathOrDirectory))
            {
                paths_Zip = Directory.GetFiles(pathOrDirectory, "*.zip");
            }

            if (paths_Zip == null || paths_Zip.Length == 0)
            {
                return null;
            }

            result = [];
            foreach (string path_Zip in paths_Zip)
            {
                LOD? lOD = null;
                int? year = null;

                string yearString = Path.GetFileName(Path.GetDirectoryName(path_Zip));
                if (!string.IsNullOrWhiteSpace(yearString) && int.TryParse(yearString.Trim(), out int year_Temp))
                {
                    year = year_Temp;
                }

                string lODString = Path.GetFileName(Path.GetDirectoryName(Path.GetDirectoryName(path_Zip)));
                if (!string.IsNullOrWhiteSpace(lODString) && Enum.TryParse(lODString, out LOD lOD_Temp))
                {
                    lOD = lOD_Temp;
                }

                using ZipArchive zipArchive = ZipFile.OpenRead(path_Zip);

                foreach (ZipArchiveEntry zipArchiveEntry in zipArchive.Entries)
                {
                    if (zipArchiveEntry.Open() is not DeflateStream)
                    {
                        continue;
                    }

                    CityModel? cityModel = CityModel(zipArchiveEntry.Open(), lOD, year);
                    if (cityModel == null)
                    {
                        continue;
                    }

                    result.Add(cityModel);
                }
            }

            return result;
        }
    }
}