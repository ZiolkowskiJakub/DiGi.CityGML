using DiGi.CityGML.Classes;
using DiGi.Core.Parameter.Classes;
using System.ComponentModel;

namespace DiGi.CityGML.Enums
{
    /// <summary>
    /// Parameters applicable to a Building.
    /// </summary>
    [AssociatedTypes(typeof(Building)), Description("Building Parameter")]
    public enum BuildingParameter
    {
        /// <summary>
        /// Identifier of the building.
        /// </summary>
        [ParameterProperties("846c62f0-91d2-45da-a823-1eea41a77b8a", "buildingId", "buildingId"), StringParameterValue()]
        buildingId,
        
        /// <summary>
        /// Naming space.
        /// </summary>
        [ParameterProperties("6e832039-334b-4fa8-855f-529b68cc2f42", "przestNazw", "przestNazw"), StringParameterValue()]
        przestNazw,

        /// <summary>
        /// Identifier of the version.
        /// </summary>
        [ParameterProperties("33fc38f8-afb4-4bd3-ae96-24bdda3facd7", "wersjaId", "wersjaId"), StringParameterValue()] 
        wersjaId,

        /// <summary>
        /// Source of the roof data.
        /// </summary>
        [ParameterProperties("903f2d7a-d5eb-48ee-a5e9-8cbaa5091ec0", "zrodloDach", "zrodloDach"), StringParameterValue()] 
        zrodloDach,

        /// <summary>
        /// Source act or document.
        /// </summary>
        [ParameterProperties("98dbf51e-4947-4cb2-a69a-30886239aa24", "aktZrodla", "aktZrodla"), StringParameterValue()] 
        aktZrodla,
    }
}