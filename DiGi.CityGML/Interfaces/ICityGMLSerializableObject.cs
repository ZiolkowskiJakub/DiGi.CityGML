namespace DiGi.CityGML.Interfaces
{
    /// <summary>
    /// Defines a contract for objects that are both CityGML objects and capable of being serialized.
    /// </summary>
    public interface ICityGMLSerializableObject : ICityGMLObject, Core.Interfaces.ISerializableObject
    {
    }
}