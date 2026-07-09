#### [DiGi\.CityGML](DiGi.CityGML.Overview.md 'DiGi\.CityGML\.Overview')

## DiGi\.CityGML\.Interfaces Namespace
### Interfaces

<a name='DiGi.CityGML.Interfaces.ICityGMLObject'></a>

## ICityGMLObject Interface

Defines the base contract for all objects that are part of the CityGML representation\.

```csharp
public interface ICityGMLObject : DiGi.Core.Interfaces.IObject
```

Derived  
↳ [Building](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Building 'DiGi\.CityGML\.Classes\.Building')  
↳ [CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel')  
↳ [Surface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Surface 'DiGi\.CityGML\.Classes\.Surface')  
↳ [ICityGMLParametrizedObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLParametrizedObject 'DiGi\.CityGML\.Interfaces\.ICityGMLParametrizedObject')  
↳ [ICityGMLParametrizedUniqueIdObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLParametrizedUniqueIdObject 'DiGi\.CityGML\.Interfaces\.ICityGMLParametrizedUniqueIdObject')  
↳ [ICityGMLSerializableObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLSerializableObject 'DiGi\.CityGML\.Interfaces\.ICityGMLSerializableObject')  
↳ [ICityGMLUniqueIdObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLUniqueIdObject 'DiGi\.CityGML\.Interfaces\.ICityGMLUniqueIdObject')  
↳ [ISurface](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ISurface 'DiGi\.CityGML\.Interfaces\.ISurface')

Implements [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.CityGML.Interfaces.ICityGMLParametrizedObject'></a>

## ICityGMLParametrizedObject Interface

Defines an interface for objects within the CityGML context that are both serializable 
according to CityGML standards and defined by parameters\.

```csharp
public interface ICityGMLParametrizedObject : DiGi.CityGML.Interfaces.ICityGMLSerializableObject, DiGi.CityGML.Interfaces.ICityGMLObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Parameter.Interfaces.IParametrizedObject
```

Implements [ICityGMLSerializableObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLSerializableObject 'DiGi\.CityGML\.Interfaces\.ICityGMLSerializableObject'), [ICityGMLObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLObject 'DiGi\.CityGML\.Interfaces\.ICityGMLObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparametrizedobject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject')

<a name='DiGi.CityGML.Interfaces.ICityGMLParametrizedUniqueIdObject'></a>

## ICityGMLParametrizedUniqueIdObject Interface

Defines an interface for a CityGML object that combines the properties of a unique identification object 
and a parametrized unique identification object\.

```csharp
public interface ICityGMLParametrizedUniqueIdObject : DiGi.CityGML.Interfaces.ICityGMLUniqueIdObject, DiGi.CityGML.Interfaces.ICityGMLSerializableObject, DiGi.CityGML.Interfaces.ICityGMLObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueIdObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Parameter.Interfaces.IParametrizedUniqueIdObject, DiGi.Core.Parameter.Interfaces.IParametrizedUniqueObject, DiGi.Core.Parameter.Interfaces.IParametrizedObject
```

Derived  
↳ [Building](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Building 'DiGi\.CityGML\.Classes\.Building')

Implements [ICityGMLUniqueIdObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLUniqueIdObject 'DiGi\.CityGML\.Interfaces\.ICityGMLUniqueIdObject'), [ICityGMLSerializableObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLSerializableObject 'DiGi\.CityGML\.Interfaces\.ICityGMLSerializableObject'), [ICityGMLObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLObject 'DiGi\.CityGML\.Interfaces\.ICityGMLObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueidobject 'DiGi\.Core\.Interfaces\.IUniqueIdObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Parameter\.Interfaces\.IParametrizedUniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparametrizeduniqueidobject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedUniqueIdObject'), [DiGi\.Core\.Parameter\.Interfaces\.IParametrizedUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparametrizeduniqueobject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedUniqueObject'), [DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparametrizedobject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject')

<a name='DiGi.CityGML.Interfaces.ICityGMLSerializableObject'></a>

## ICityGMLSerializableObject Interface

Defines a contract for objects that are both CityGML objects and capable of being serialized\.

```csharp
public interface ICityGMLSerializableObject : DiGi.CityGML.Interfaces.ICityGMLObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [Building](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Building 'DiGi\.CityGML\.Classes\.Building')  
↳ [CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel')  
↳ [Surface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Surface 'DiGi\.CityGML\.Classes\.Surface')  
↳ [ICityGMLParametrizedObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLParametrizedObject 'DiGi\.CityGML\.Interfaces\.ICityGMLParametrizedObject')  
↳ [ICityGMLParametrizedUniqueIdObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLParametrizedUniqueIdObject 'DiGi\.CityGML\.Interfaces\.ICityGMLParametrizedUniqueIdObject')  
↳ [ICityGMLUniqueIdObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLUniqueIdObject 'DiGi\.CityGML\.Interfaces\.ICityGMLUniqueIdObject')  
↳ [ISurface](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ISurface 'DiGi\.CityGML\.Interfaces\.ISurface')

Implements [ICityGMLObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLObject 'DiGi\.CityGML\.Interfaces\.ICityGMLObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')

<a name='DiGi.CityGML.Interfaces.ICityGMLUniqueIdObject'></a>

## ICityGMLUniqueIdObject Interface

Defines a contract for objects within the CityGML domain that are both serializable 
and possess a unique identifier\.

```csharp
public interface ICityGMLUniqueIdObject : DiGi.CityGML.Interfaces.ICityGMLSerializableObject, DiGi.CityGML.Interfaces.ICityGMLObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueIdObject, DiGi.Core.Interfaces.IUniqueObject
```

Derived  
↳ [Building](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Building 'DiGi\.CityGML\.Classes\.Building')  
↳ [CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel')  
↳ [Surface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Surface 'DiGi\.CityGML\.Classes\.Surface')  
↳ [ICityGMLParametrizedUniqueIdObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLParametrizedUniqueIdObject 'DiGi\.CityGML\.Interfaces\.ICityGMLParametrizedUniqueIdObject')  
↳ [ISurface](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ISurface 'DiGi\.CityGML\.Interfaces\.ISurface')

Implements [ICityGMLSerializableObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLSerializableObject 'DiGi\.CityGML\.Interfaces\.ICityGMLSerializableObject'), [ICityGMLObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLObject 'DiGi\.CityGML\.Interfaces\.ICityGMLObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueidobject 'DiGi\.Core\.Interfaces\.IUniqueIdObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')

<a name='DiGi.CityGML.Interfaces.ISurface'></a>

## ISurface Interface

Defines the contract for a surface object within the CityGML model, 
providing access to its unique identifier and associated 3D polygonal geometry\.

```csharp
public interface ISurface : DiGi.CityGML.Interfaces.ICityGMLUniqueIdObject, DiGi.CityGML.Interfaces.ICityGMLSerializableObject, DiGi.CityGML.Interfaces.ICityGMLObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueIdObject, DiGi.Core.Interfaces.IUniqueObject
```

Derived  
↳ [Surface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Surface 'DiGi\.CityGML\.Classes\.Surface')

Implements [ICityGMLUniqueIdObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLUniqueIdObject 'DiGi\.CityGML\.Interfaces\.ICityGMLUniqueIdObject'), [ICityGMLSerializableObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLSerializableObject 'DiGi\.CityGML\.Interfaces\.ICityGMLSerializableObject'), [ICityGMLObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLObject 'DiGi\.CityGML\.Interfaces\.ICityGMLObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueidobject 'DiGi\.Core\.Interfaces\.IUniqueIdObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Properties

<a name='DiGi.CityGML.Interfaces.ISurface.Geometry'></a>

## ISurface\.Geometry Property

Gets the 3D polygonal face geometry that defines the spatial extent of the surface\.

```csharp
DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? Geometry { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')  
The [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') representing the surface geometry, or `null` if not defined\.