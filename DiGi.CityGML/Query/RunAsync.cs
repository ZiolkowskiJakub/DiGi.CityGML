using DiGi.CityGML.Classes;
using DiGi.CityGML.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

namespace DiGi.CityGML
{
    public static partial class Query
    {
        /// <summary>
        /// Asynchronously walks the specified path or directory, parsing CityGML files and invoking the given <paramref name="action"/> for each <see cref="CityModel"/> found.
        /// <para>If the path points to a single non-zip file, the <see cref="Enums.LOD"/> and year are derived from its parent directory structure and a single <see cref="CityModel"/> is created. If the path is a .zip file or a directory, all .zip archives are enumerated recursively; each <see cref="DeflateStream"/> entry within an archive is parsed individually.</para>
        /// </summary>
        /// <param name="pathOrDirectory">A path to a single CityGML file, a .zip archive, or a directory containing .zip archives. This value can be null.</param>
        /// <param name="action">The asynchronous <see cref="Func{T1, T2, TResult}"/> invoked for each city model with the source path and the parsed <see cref="CityModel"/>, which can be null. This value can be null.</param>
        /// <returns>A task that represents the asynchronous operation. The task result is true if the walk completed successfully; otherwise, false.</returns>
        public static async Task<bool> RunAsync(string? pathOrDirectory, Func<string, CityModel?, Task>? action)
        {
            if (string.IsNullOrWhiteSpace(pathOrDirectory) || action is null)
            {
                return false;
            }

            string[]? paths_Zip = null;

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
                    if (!string.IsNullOrWhiteSpace(lODString) && Enum.TryParse(lODString, true, out LOD lOD_Temp))
                    {
                        lOD = lOD_Temp;
                    }

                    CityModel? cityModel = Create.CityModel(pathOrDirectory, lOD, year);

                    await action.Invoke(pathOrDirectory!, cityModel);
                }
            }
            else if (Directory.Exists(pathOrDirectory))
            {
                paths_Zip = Directory.GetFiles(pathOrDirectory, "*.zip", SearchOption.AllDirectories);
            }

            if (paths_Zip == null || paths_Zip.Length == 0)
            {
                return false;
            }

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
                if (!string.IsNullOrWhiteSpace(lODString) && Enum.TryParse(lODString, true, out LOD lOD_Temp))
                {
                    lOD = lOD_Temp;
                }

                if (lOD is null && year is null)
                {
                    lODString = Path.GetFileName(Path.GetDirectoryName(path_Zip));
                    if (!string.IsNullOrWhiteSpace(lODString) && Enum.TryParse(lODString, true, out lOD_Temp))
                    {
                        lOD = lOD_Temp;
                    }
                }

                using ZipArchive zipArchive = ZipFile.OpenRead(path_Zip);

                foreach (ZipArchiveEntry zipArchiveEntry in zipArchive.Entries)
                {
                    if (zipArchiveEntry.Open() is not DeflateStream)
                    {
                        continue;
                    }

                    CityModel? cityModel = Create.CityModel(zipArchiveEntry.Open(), lOD, year);

                    string path = Path.Combine(path_Zip, zipArchiveEntry.FullName.Replace('/', Path.DirectorySeparatorChar));

                    await action.Invoke(path, cityModel);
                }
            }

            return true;
        }
    }
}
