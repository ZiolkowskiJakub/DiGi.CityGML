namespace DiGi.CityGML.Interfaces
{
    /// <summary>
    /// Defines an interface for objects within the CityGML context that are both serializable 
    /// according to CityGML standards and defined by parameters.
    /// </summary>
    public interface ICityGMLParametrizedObject : ICityGMLSerializableObject, Core.Parameter.Interfaces.IParametrizedObject
    {
    }
}