using DiGi.Geometry.Spatial.Classes;
using System.Xml;

namespace DiGi.CityGML
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts an XML node containing coordinate strings into a <see cref="Point3D"/> object.
        /// </summary>
        /// <param name="xmlNode">The XML node to be parsed for 3D point coordinates.</param>
        /// <returns>A <see cref="Point3D"/> instance if the parsing is successful; otherwise, <c>null</c>.</returns>
        public static Point3D? ToCityGML_Point3D(XmlNode xmlNode)
        {
            string? innerText = xmlNode?.InnerText;
            if (string.IsNullOrWhiteSpace(innerText))
            {
                return null;
            }

            // The specification allows any whitespace between the coordinates of a position, so the
            // separators are left to the framework rather than assuming a single space.
            string[]? strings = innerText!.Split((char[]?)null, System.StringSplitOptions.RemoveEmptyEntries);
            if (strings == null || strings.Length < 3)
            {
                return null;
            }

            double[] values = new double[3];
            for (int i = 0; i < 3; i++)
            {
                // A coordinate that cannot be read leaves the position undefined. Reporting that is the
                // only safe answer - a not-a-number coordinate placed here travels all the way into the
                // stored geometry, where it is no longer traceable to the file it came from.
                if (!Core.Query.TryConvert(strings[i], out double value))
                {
                    return null;
                }

                values[i] = value;
            }

            return new Point3D(values);
        }
    }
}