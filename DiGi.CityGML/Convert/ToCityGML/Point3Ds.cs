using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Xml;

namespace DiGi.CityGML
{
    public static partial class Convert
    {
        public static List<Point3D> ToCityGML_Point3Ds(XmlNode xmlNode)
        {
            string innerText = xmlNode?.InnerText;
            if(string.IsNullOrWhiteSpace(innerText))
            {
                return null;
            }

            string[] strings = innerText.Split(' ');
            if(strings == null || strings.Length == 0)
            {
                return null;
            }

            List<Point3D> result = new List<Point3D>();
            for(int i =0; i < strings.Length; i = i + 3)
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
