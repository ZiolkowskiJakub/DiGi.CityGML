using DiGi.CityGML.Classes;
using DiGi.CityGML.Enums;
using System.IO;
using System.Xml;

namespace DiGi.CityGML
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="Classes.CityModel"/> instance from the provided stream.
        /// </summary>
        /// <param name="stream">The input stream containing the CityGML data.</param>
        /// <param name="lOD">Optional level of detail to assign to the city model.</param>
        /// <param name="year">Optional year to assign to the city model.</param>
        /// <returns>A <see cref="Classes.CityModel"/> instance if successful; otherwise, null.</returns>
        public static CityModel? CityModel(Stream? stream, LOD? lOD = null, int? year = null)
        {
            if (stream == null)
            {
                return null;
            }

            XmlDocument xmlDocument = new();
            xmlDocument.Load(stream);

            return CityModel(xmlDocument, lOD, year);
        }

        /// <summary>
        /// Creates a <see cref="Classes.CityModel"/> instance from the provided XML document.
        /// </summary>
        /// <param name="xmlDocument">The <see cref="XmlDocument"/> containing the CityGML data.</param>
        /// <param name="lOD">Optional level of detail to assign to the city model.</param>
        /// <param name="year">Optional year to assign to the city model.</param>
        /// <returns>A <see cref="Classes.CityModel"/> instance if successful; otherwise, null.</returns>
        public static CityModel? CityModel(XmlDocument? xmlDocument, LOD? lOD = null, int? year = null)
        {
            if (xmlDocument == null)
            {
                return null;
            }

            XmlNodeList xmlNodeList = xmlDocument.ChildNodes;
            if (xmlNodeList == null || xmlNodeList.Count == 0)
            {
                return null;
            }

            CityModel? result = null;
            for (int i = 0; i < xmlNodeList.Count; i++)
            {
                string? name = xmlNodeList[i]?.LocalName;

                if (string.IsNullOrWhiteSpace(name))
                {
                    continue;
                }

                if (name == Constants.XmlNode.Name.CityModel)
                {
                    result = Convert.ToCityGML_CityModel(xmlNodeList[i]);
                    if (result != null)
                    {
                        break;
                    }
                }
            }

            if (result != null)
            {
                Core.Parameter.Classes.SetValueSettings setValueSettings = new(true, false);

                if (lOD != null && lOD.HasValue)
                {
                    result.SetValue(CityModelParameter.LOD, lOD, setValueSettings);
                }

                if (year != null && year.HasValue)
                {
                    result.SetValue(CityModelParameter.Year, year, setValueSettings);
                }
            }

            return result;
        }

        /// <summary>
        /// Creates a <see cref="Classes.CityModel"/> instance from the specified file path.
        /// </summary>
        /// <param name="path">The full path to the CityGML file.</param>
        /// <param name="lOD">Optional level of detail to assign to the city model.</param>
        /// <param name="year">Optional year to assign to the city model.</param>
        /// <returns>A <see cref="Classes.CityModel"/> instance if successful; otherwise, null.</returns>
        public static CityModel? CityModel(string? path, LOD? lOD = null, int? year = null)
        {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                return null;
            }

            // Load from the stream rather than File.ReadAllText + LoadXml: the latter materializes the
            // whole file as a UTF-16 string before the parser sees a single byte.
            using FileStream fileStream = File.OpenRead(path);

            if (fileStream.Length == 0)
            {
                return null;
            }

            XmlDocument xmlDocument = new();
            xmlDocument.Load(fileStream);

            return CityModel(xmlDocument, lOD, year);
        }
    }
}