namespace DiGi.CityGML.Interfaces
{
    /// <summary>
    /// Defines a contract for objects within the CityGML domain that are both serializable 
    /// and possess a unique identifier.
    /// </summary>
    public interface ICityGMLUniqueIdObject : ICityGMLSerializableObject, Core.Interfaces.IUniqueIdObject
    {
    }
}