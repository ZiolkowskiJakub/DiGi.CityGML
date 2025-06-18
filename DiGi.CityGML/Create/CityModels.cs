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
        public static List<CityModel> CityModels(string path)
        {
            if(string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            string[] paths_Zip = null;

            List<CityModel> result = null;

            if (File.Exists(path))
            {
                if(Path.GetExtension(path) == ".zip")
                {
                    paths_Zip = new string[] { path };
                }
                else
                {
                    LOD? lOD = null;
                    int? year = null;

                    string yearString = Path.GetFileName(Path.GetDirectoryName(path));
                    if (!string.IsNullOrWhiteSpace(yearString) && int.TryParse(yearString.Trim(), out int year_Temp))
                    {
                        year = year_Temp;
                    }

                    string lODString = Path.GetFileName(Path.GetDirectoryName(Path.GetDirectoryName(path)));
                    if (!string.IsNullOrWhiteSpace(lODString) && Enum.TryParse(lODString, out LOD lOD_Temp))
                    {
                        lOD = lOD_Temp;
                    }

                    CityModel cityModel = CityModel(path, lOD, year);
                    if(cityModel != null)
                    {
                        result = new List<CityModel> { cityModel };
                    }

                    return result;
                }
            }
            else if(Directory.Exists(path))
            {
                paths_Zip = Directory.GetFiles(path, "*.zip");
            }

            if(paths_Zip == null || paths_Zip.Length == 0)
            {
                return null;
            }

            result = new List<CityModel>();
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

                using (ZipArchive zipArchive = ZipFile.OpenRead(path_Zip))
                {
                    foreach (ZipArchiveEntry zipArchiveEntry in zipArchive.Entries)
                    {
                        DeflateStream deflateStream = zipArchiveEntry.Open() as DeflateStream;
                        if (deflateStream == null)
                        {
                            continue;
                        }

                        CityModel cityModel = CityModel(zipArchiveEntry.Open(), lOD, year);
                        if(cityModel == null)
                        {
                            continue;
                        }

                        result.Add(cityModel);
                    }
                }
            }

            return result;
        }
    }
}
