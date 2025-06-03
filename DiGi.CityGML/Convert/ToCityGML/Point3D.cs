using DiGi.Geometry.Spatial.Classes;
using System.Xml;

namespace DiGi.CityGML
{
    public static partial class Convert
    {
        public static Point3D ToCityGML_Point3D(XmlNode xmlNode)
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

            double[] values = new double[3];
            for(int i =0; i < strings.Length; i++)
            {
                if (!Core.Query.TryConvert(strings[i], out double value))
                {
                    value = double.NaN;
                }

                values[i] = value;
            }

            return new Point3D(values);
        }
    }
}
