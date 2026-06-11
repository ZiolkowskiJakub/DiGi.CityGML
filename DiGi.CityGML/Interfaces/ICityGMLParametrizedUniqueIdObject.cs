namespace DiGi.CityGML.Interfaces
{
    /// <summary>
    /// Defines an interface for a CityGML object that combines the properties of a unique identification object 
    /// and a parametrized unique identification object.
    /// </summary>
    public interface ICityGMLParametrizedUniqueIdObject : ICityGMLUniqueIdObject, Core.Parameter.Interfaces.IParametrizedUniqueIdObject
    {
    }
}