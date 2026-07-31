using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Xml;

namespace DiGi.CityGML
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts an XML node containing a space-separated string of coordinates into a list of <see cref="Point3D"/> objects.
        /// </summary>
        /// <param name="xmlNode">The XML node to be parsed for coordinate data.</param>
        /// <returns>A list of <see cref="Point3D"/> instances if the input is valid and contains coordinates; otherwise, <c>null</c>.</returns>
        public static List<Point3D>? ToCityGML_Point3Ds(XmlNode? xmlNode)
        {
            string? innerText = xmlNode?.InnerText;
            if (string.IsNullOrWhiteSpace(innerText))
            {
                return null;
            }

            // The specification allows any whitespace between the coordinates of a position list, so the
            // separators are left to the framework rather than assuming a single space. Splitting on a
            // single space turns every other separator into empty entries, which shifts the triples out
            // of step and reads past the end of the array.
            string[]? strings = innerText!.Split((char[]?)null, System.StringSplitOptions.RemoveEmptyEntries);
            if (strings == null || strings.Length < 3)
            {
                return null;
            }

            List<Point3D> result = [];

            // A trailing coordinate that does not complete a triple is not a position and is left out.
            for (int i = 0; i + 2 < strings.Length; i += 3)
            {
                if (!Core.Query.TryConvert(strings[i], out double x))
                {
                    continue;
                }

                if (!Core.Query.TryConvert(strings[i + 1], out double y))
                {
                    continue;
                }

                if (!Core.Query.TryConvert(strings[i + 2], out double z))
                {
                    continue;
                }

                result.Add(new Point3D(x, y, z));
            }

            return result;
        }
    }
}