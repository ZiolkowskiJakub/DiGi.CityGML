using DiGi.CityGML.Classes;
using DiGi.Core.Parameter.Classes;
using System.ComponentModel;

namespace DiGi.CityGML.Enums
{
    [AssociatedTypes(typeof(CityModel)), Description("CityModel Parameter")]
    public enum CityModelParameter
    {
        [ParameterProperties("79ab4292-94c1-4d39-b33b-9d80cf7df631", "LOD", "Level Of Detail", Core.Parameter.Enums.AccessType.Read), StringParameterValue()] LOD,
        [ParameterProperties("fc073811-4f72-4d2b-8fdf-552282425ed6", "Year", "Year", Core.Parameter.Enums.AccessType.Read), IntegerParameterValue()] Year,
    }
}
