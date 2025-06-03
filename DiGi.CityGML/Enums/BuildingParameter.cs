using DiGi.CityGML.Classes;
using DiGi.Core.Parameter.Classes;
using System.ComponentModel;

namespace DiGi.CityGML.Enums
{
    [AssociatedTypes(typeof(Building)), Description("Building Parameter")]
    public enum BuildingParameter
    {
        [ParameterProperties("846c62f0-91d2-45da-a823-1eea41a77b8a", "buildingId", "buildingId"), StringParameterValue()] buildingId,
        [ParameterProperties("6e832039-334b-4fa8-855f-529b68cc2f42", "przestNazw", "przestNazw"), StringParameterValue()] przestNazw,
        [ParameterProperties("33fc38f8-afb4-4bd3-ae96-24bdda3facd7", "wersjaId", "wersjaId"), StringParameterValue()] wersjaId,
        [ParameterProperties("903f2d7a-d5eb-48ee-a5e9-8cbaa5091ec0", "zrodloDach", "zrodloDach"), StringParameterValue()] zrodloDach,
        [ParameterProperties("98dbf51e-4947-4cb2-a69a-30886239aa24", "aktZrodla", "aktZrodla"), StringParameterValue()] aktZrodla,
    }
}
