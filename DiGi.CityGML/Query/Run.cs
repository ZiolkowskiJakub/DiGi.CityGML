using DiGi.CityGML.Classes;
using System;
using System.Threading.Tasks;

namespace DiGi.CityGML
{
    public static partial class Query
    {
        /// <summary>
        /// Synchronously walks the specified path or directory, parsing CityGML files and invoking the given <paramref name="action"/> for each <see cref="CityModel"/> found.
        /// </summary>
        /// <param name="pathOrDirectory">A path to a single CityGML file, a .zip archive, or a directory containing .zip archives. If the path is a single non-zip file, the directory structure is inspected to derive the <see cref="Enums.LOD"/> and year of the city model.</param>
        /// <param name="action">The <see cref="Action{T1, T2}"/> invoked for each city model with the source path and the parsed <see cref="CityModel"/>, which can be null.</param>
        /// <returns>True if the walk completed successfully; otherwise, false.</returns>
        public static bool Run(string? pathOrDirectory, Action<string, CityModel?>? action)
        {
            if (string.IsNullOrWhiteSpace(pathOrDirectory) || action is null)
            {
                return false;
            }

            return RunAsync(pathOrDirectory, (path, cityModel) =>
            {
                action.Invoke(path, cityModel);
                return Task.CompletedTask;
            }).GetAwaiter().GetResult();
        }
    }
}