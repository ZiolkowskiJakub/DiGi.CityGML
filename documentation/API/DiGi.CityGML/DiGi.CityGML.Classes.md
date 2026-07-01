#### [DiGi\.CityGML](index.md 'index')

## DiGi\.CityGML\.Classes Namespace
### Classes

<a name='DiGi.CityGML.Classes.Building'></a>

## Building Class

Represents a building entity within the CityGML model, providing properties for roof type and associated surfaces\.

```csharp
public class Building : DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject, DiGi.CityGML.Interfaces.ICityGMLParametrizedUniqueIdObject, DiGi.CityGML.Interfaces.ICityGMLUniqueIdObject, DiGi.CityGML.Interfaces.ICityGMLSerializableObject, DiGi.CityGML.Interfaces.ICityGMLObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueIdObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Parameter.Interfaces.IParametrizedUniqueIdObject, DiGi.Core.Parameter.Interfaces.IParametrizedUniqueObject, DiGi.Core.Parameter.Interfaces.IParametrizedObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedUniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizeduniqueidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedUniqueIdObject') → Building

Implements [ICityGMLParametrizedUniqueIdObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLParametrizedUniqueIdObject 'DiGi\.CityGML\.Interfaces\.ICityGMLParametrizedUniqueIdObject'), [ICityGMLUniqueIdObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLUniqueIdObject 'DiGi\.CityGML\.Interfaces\.ICityGMLUniqueIdObject'), [ICityGMLSerializableObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLSerializableObject 'DiGi\.CityGML\.Interfaces\.ICityGMLSerializableObject'), [ICityGMLObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLObject 'DiGi\.CityGML\.Interfaces\.ICityGMLObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueidobject 'DiGi\.Core\.Interfaces\.IUniqueIdObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Parameter\.Interfaces\.IParametrizedUniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparametrizeduniqueidobject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedUniqueIdObject'), [DiGi\.Core\.Parameter\.Interfaces\.IParametrizedUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparametrizeduniqueobject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedUniqueObject'), [DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.interfaces.iparametrizedobject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject')
### Constructors

<a name='DiGi.CityGML.Classes.Building.Building(DiGi.CityGML.Classes.Building)'></a>

## Building\(Building\) Constructor

Initializes a new instance of the [Building](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Building 'DiGi\.CityGML\.Classes\.Building') class by copying an existing building instance\.

```csharp
public Building(DiGi.CityGML.Classes.Building? building);
```
#### Parameters

<a name='DiGi.CityGML.Classes.Building.Building(DiGi.CityGML.Classes.Building).building'></a>

`building` [Building](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Building 'DiGi\.CityGML\.Classes\.Building')

The source building object to copy from\.

<a name='DiGi.CityGML.Classes.Building.Building(string,int,System.Collections.Generic.IEnumerable_DiGi.CityGML.Interfaces.ISurface_)'></a>

## Building\(string, int, IEnumerable\<ISurface\>\) Constructor

Initializes a new instance of the [Building](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Building 'DiGi\.CityGML\.Classes\.Building') class with specified unique identifier, roof type ID, and surfaces\.

```csharp
public Building(string? uniqueId, int roofTypeId, System.Collections.Generic.IEnumerable<DiGi.CityGML.Interfaces.ISurface>? surfaces);
```
#### Parameters

<a name='DiGi.CityGML.Classes.Building.Building(string,int,System.Collections.Generic.IEnumerable_DiGi.CityGML.Interfaces.ISurface_).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the building\.

<a name='DiGi.CityGML.Classes.Building.Building(string,int,System.Collections.Generic.IEnumerable_DiGi.CityGML.Interfaces.ISurface_).roofTypeId'></a>

`roofTypeId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The identifier representing the type of the roof\.

<a name='DiGi.CityGML.Classes.Building.Building(string,int,System.Collections.Generic.IEnumerable_DiGi.CityGML.Interfaces.ISurface_).surfaces'></a>

`surfaces` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ISurface](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ISurface 'DiGi\.CityGML\.Interfaces\.ISurface')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of surfaces associated with the building\.

<a name='DiGi.CityGML.Classes.Building.Building(System.Text.Json.Nodes.JsonObject)'></a>

## Building\(JsonObject\) Constructor

Initializes a new instance of the [Building](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Building 'DiGi\.CityGML\.Classes\.Building') class from a JSON object\.

```csharp
public Building(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.CityGML.Classes.Building.Building(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the building data\.
### Properties

<a name='DiGi.CityGML.Classes.Building.RoofTypeId'></a>

## Building\.RoofTypeId Property

Gets the identifier for the type of roof associated with this building\.

```csharp
public int RoofTypeId { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.CityGML.Classes.Building.Surfaces'></a>

## Building\.Surfaces Property

Gets or sets the collection of surfaces that constitute the building's geometry\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.CityGML.Interfaces.ISurface>? Surfaces { get; private set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ISurface](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ISurface 'DiGi\.CityGML\.Interfaces\.ISurface')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.CityGML.Classes.CityModel'></a>

## CityModel Class

Represents a city model that contains a collection of buildings and implements unique identification for CityGML objects\.

```csharp
public class CityModel : DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject, DiGi.CityGML.Interfaces.ICityGMLUniqueIdObject, DiGi.CityGML.Interfaces.ICityGMLSerializableObject, DiGi.CityGML.Interfaces.ICityGMLObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueIdObject, DiGi.Core.Interfaces.IUniqueObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizedobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject') → [DiGi\.Core\.Parameter\.Classes\.ParametrizedUniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.parameter.classes.parametrizeduniqueidobject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedUniqueIdObject') → CityModel

Implements [ICityGMLUniqueIdObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLUniqueIdObject 'DiGi\.CityGML\.Interfaces\.ICityGMLUniqueIdObject'), [ICityGMLSerializableObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLSerializableObject 'DiGi\.CityGML\.Interfaces\.ICityGMLSerializableObject'), [ICityGMLObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLObject 'DiGi\.CityGML\.Interfaces\.ICityGMLObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueidobject 'DiGi\.Core\.Interfaces\.IUniqueIdObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Constructors

<a name='DiGi.CityGML.Classes.CityModel.CityModel()'></a>

## CityModel\(\) Constructor

Initializes a new instance of the [CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel') class\.

```csharp
public CityModel();
```

<a name='DiGi.CityGML.Classes.CityModel.CityModel(DiGi.CityGML.Classes.CityModel)'></a>

## CityModel\(CityModel\) Constructor

Initializes a new instance of the [CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel') class by copying an existing city model\.

```csharp
public CityModel(DiGi.CityGML.Classes.CityModel? cityModel);
```
#### Parameters

<a name='DiGi.CityGML.Classes.CityModel.CityModel(DiGi.CityGML.Classes.CityModel).cityModel'></a>

`cityModel` [CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel')

The source city model to copy from\.

<a name='DiGi.CityGML.Classes.CityModel.CityModel(System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_)'></a>

## CityModel\(IEnumerable\<Building\>\) Constructor

Initializes a new instance of the [CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel') class with a specified collection of buildings\.

```csharp
public CityModel(System.Collections.Generic.IEnumerable<DiGi.CityGML.Classes.Building>? buildings);
```
#### Parameters

<a name='DiGi.CityGML.Classes.CityModel.CityModel(System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_).buildings'></a>

`buildings` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Building](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Building 'DiGi\.CityGML\.Classes\.Building')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of buildings to associate with this city model\.

<a name='DiGi.CityGML.Classes.CityModel.CityModel(System.Text.Json.Nodes.JsonObject)'></a>

## CityModel\(JsonObject\) Constructor

Initializes a new instance of the [CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel') class using a JSON object\.

```csharp
public CityModel(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.CityGML.Classes.CityModel.CityModel(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the city model\.
### Properties

<a name='DiGi.CityGML.Classes.CityModel.Buildings'></a>

## CityModel\.Buildings Property

Gets or sets the collection of buildings contained within the city model\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.CityGML.Classes.Building>? Buildings { get; private set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Building](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Building 'DiGi\.CityGML\.Classes\.Building')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.CityGML.Classes.GroundSurface'></a>

## GroundSurface Class

Represents a ground surface in the CityGML model, typically used to define the terrain or floor surfaces\.

```csharp
public class GroundSurface : DiGi.CityGML.Classes.Surface
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.UniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueidobject 'DiGi\.Core\.Classes\.UniqueIdObject') → [Surface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Surface 'DiGi\.CityGML\.Classes\.Surface') → GroundSurface
### Constructors

<a name='DiGi.CityGML.Classes.GroundSurface.GroundSurface(DiGi.CityGML.Classes.GroundSurface)'></a>

## GroundSurface\(GroundSurface\) Constructor

Initializes a new instance of the [GroundSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.GroundSurface 'DiGi\.CityGML\.Classes\.GroundSurface') class by copying an existing [GroundSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.GroundSurface 'DiGi\.CityGML\.Classes\.GroundSurface') instance\.

```csharp
public GroundSurface(DiGi.CityGML.Classes.GroundSurface? groundSurface);
```
#### Parameters

<a name='DiGi.CityGML.Classes.GroundSurface.GroundSurface(DiGi.CityGML.Classes.GroundSurface).groundSurface'></a>

`groundSurface` [GroundSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.GroundSurface 'DiGi\.CityGML\.Classes\.GroundSurface')

The ground surface instance to copy from\.

<a name='DiGi.CityGML.Classes.GroundSurface.GroundSurface(string,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D)'></a>

## GroundSurface\(string, IPolygonalFace3D\) Constructor

Initializes a new instance of the [GroundSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.GroundSurface 'DiGi\.CityGML\.Classes\.GroundSurface') class with a specified unique identifier and geometry\.

```csharp
public GroundSurface(string? uniqueId, DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? geometry);
```
#### Parameters

<a name='DiGi.CityGML.Classes.GroundSurface.GroundSurface(string,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the ground surface\.

<a name='DiGi.CityGML.Classes.GroundSurface.GroundSurface(string,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D).geometry'></a>

`geometry` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The 3D polygonal face geometry associated with the ground surface\.

<a name='DiGi.CityGML.Classes.GroundSurface.GroundSurface(System.Text.Json.Nodes.JsonObject)'></a>

## GroundSurface\(JsonObject\) Constructor

Initializes a new instance of the [GroundSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.GroundSurface 'DiGi\.CityGML\.Classes\.GroundSurface') class using a JSON object\.

```csharp
public GroundSurface(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.CityGML.Classes.GroundSurface.GroundSurface(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to initialize the ground surface\.

<a name='DiGi.CityGML.Classes.RoofSurface'></a>

## RoofSurface Class

Represents a roof surface within the CityGML model, inheriting from the base [Surface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Surface 'DiGi\.CityGML\.Classes\.Surface') class\.

```csharp
public class RoofSurface : DiGi.CityGML.Classes.Surface
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.UniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueidobject 'DiGi\.Core\.Classes\.UniqueIdObject') → [Surface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Surface 'DiGi\.CityGML\.Classes\.Surface') → RoofSurface
### Constructors

<a name='DiGi.CityGML.Classes.RoofSurface.RoofSurface(DiGi.CityGML.Classes.RoofSurface)'></a>

## RoofSurface\(RoofSurface\) Constructor

Initializes a new instance of the [RoofSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.RoofSurface 'DiGi\.CityGML\.Classes\.RoofSurface') class by copying an existing [RoofSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.RoofSurface 'DiGi\.CityGML\.Classes\.RoofSurface') instance\.

```csharp
public RoofSurface(DiGi.CityGML.Classes.RoofSurface? roofSurface);
```
#### Parameters

<a name='DiGi.CityGML.Classes.RoofSurface.RoofSurface(DiGi.CityGML.Classes.RoofSurface).roofSurface'></a>

`roofSurface` [RoofSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.RoofSurface 'DiGi\.CityGML\.Classes\.RoofSurface')

The source [RoofSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.RoofSurface 'DiGi\.CityGML\.Classes\.RoofSurface') object to copy from\.

<a name='DiGi.CityGML.Classes.RoofSurface.RoofSurface(string,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D)'></a>

## RoofSurface\(string, IPolygonalFace3D\) Constructor

Initializes a new instance of the [RoofSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.RoofSurface 'DiGi\.CityGML\.Classes\.RoofSurface') class with a specified unique identifier and geometry\.

```csharp
public RoofSurface(string? uniqueId, DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? geometry);
```
#### Parameters

<a name='DiGi.CityGML.Classes.RoofSurface.RoofSurface(string,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the roof surface\.

<a name='DiGi.CityGML.Classes.RoofSurface.RoofSurface(string,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D).geometry'></a>

`geometry` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The 3D polygonal face geometry associated with the roof surface\.

<a name='DiGi.CityGML.Classes.RoofSurface.RoofSurface(System.Text.Json.Nodes.JsonObject)'></a>

## RoofSurface\(JsonObject\) Constructor

Initializes a new instance of the [RoofSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.RoofSurface 'DiGi\.CityGML\.Classes\.RoofSurface') class using the provided JSON object\.

```csharp
public RoofSurface(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.CityGML.Classes.RoofSurface.RoofSurface(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to initialize the roof surface\.

<a name='DiGi.CityGML.Classes.Surface'></a>

## Surface Class

Represents an abstract base class for a surface in the CityGML model, providing unique identification and geometric representation\.

```csharp
public abstract class Surface : DiGi.Core.Classes.UniqueIdObject, DiGi.CityGML.Interfaces.ISurface, DiGi.CityGML.Interfaces.ICityGMLUniqueIdObject, DiGi.CityGML.Interfaces.ICityGMLSerializableObject, DiGi.CityGML.Interfaces.ICityGMLObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueIdObject, DiGi.Core.Interfaces.IUniqueObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.UniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueidobject 'DiGi\.Core\.Classes\.UniqueIdObject') → Surface

Derived  
↳ [GroundSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.GroundSurface 'DiGi\.CityGML\.Classes\.GroundSurface')  
↳ [RoofSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.RoofSurface 'DiGi\.CityGML\.Classes\.RoofSurface')  
↳ [UndefinedSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.UndefinedSurface 'DiGi\.CityGML\.Classes\.UndefinedSurface')  
↳ [WallSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.WallSurface 'DiGi\.CityGML\.Classes\.WallSurface')

Implements [ISurface](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ISurface 'DiGi\.CityGML\.Interfaces\.ISurface'), [ICityGMLUniqueIdObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLUniqueIdObject 'DiGi\.CityGML\.Interfaces\.ICityGMLUniqueIdObject'), [ICityGMLSerializableObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLSerializableObject 'DiGi\.CityGML\.Interfaces\.ICityGMLSerializableObject'), [ICityGMLObject](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ICityGMLObject 'DiGi\.CityGML\.Interfaces\.ICityGMLObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IUniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueidobject 'DiGi\.Core\.Interfaces\.IUniqueIdObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Constructors

<a name='DiGi.CityGML.Classes.Surface.Surface(DiGi.CityGML.Classes.Surface)'></a>

## Surface\(Surface\) Constructor

Initializes a new instance of the [Surface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Surface 'DiGi\.CityGML\.Classes\.Surface') class by cloning an existing surface instance\.

```csharp
public Surface(DiGi.CityGML.Classes.Surface? surface);
```
#### Parameters

<a name='DiGi.CityGML.Classes.Surface.Surface(DiGi.CityGML.Classes.Surface).surface'></a>

`surface` [Surface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Surface 'DiGi\.CityGML\.Classes\.Surface')

The source surface object to clone\.

<a name='DiGi.CityGML.Classes.Surface.Surface(string,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D)'></a>

## Surface\(string, IPolygonalFace3D\) Constructor

Initializes a new instance of the [Surface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Surface 'DiGi\.CityGML\.Classes\.Surface') class with a specified unique identifier and geometry\.

```csharp
public Surface(string? uniqueId, DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? geometry);
```
#### Parameters

<a name='DiGi.CityGML.Classes.Surface.Surface(string,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the surface\.

<a name='DiGi.CityGML.Classes.Surface.Surface(string,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D).geometry'></a>

`geometry` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The polygonal face representing the 3D geometry of the surface\.

<a name='DiGi.CityGML.Classes.Surface.Surface(System.Text.Json.Nodes.JsonObject)'></a>

## Surface\(JsonObject\) Constructor

Initializes a new instance of the [Surface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Surface 'DiGi\.CityGML\.Classes\.Surface') class using data from a JSON object\.

```csharp
public Surface(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.CityGML.Classes.Surface.Surface(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the surface properties\.
### Properties

<a name='DiGi.CityGML.Classes.Surface.Geometry'></a>

## Surface\.Geometry Property

Gets the 3D polygonal face geometry associated with this surface\.

```csharp
public DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? Geometry { get; }
```

Implements [Geometry](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ISurface.Geometry 'DiGi\.CityGML\.Interfaces\.ISurface\.Geometry')

#### Property Value
[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')  
A clone of the underlying [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') geometry, or null if not defined\.

<a name='DiGi.CityGML.Classes.UndefinedSurface'></a>

## UndefinedSurface Class

Represents a surface in the CityGML model where the specific type of surface is not defined\.

```csharp
public class UndefinedSurface : DiGi.CityGML.Classes.Surface
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.UniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueidobject 'DiGi\.Core\.Classes\.UniqueIdObject') → [Surface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Surface 'DiGi\.CityGML\.Classes\.Surface') → UndefinedSurface
### Constructors

<a name='DiGi.CityGML.Classes.UndefinedSurface.UndefinedSurface(DiGi.CityGML.Classes.UndefinedSurface)'></a>

## UndefinedSurface\(UndefinedSurface\) Constructor

Initializes a new instance of the [UndefinedSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.UndefinedSurface 'DiGi\.CityGML\.Classes\.UndefinedSurface') class by copying another instance\.

```csharp
public UndefinedSurface(DiGi.CityGML.Classes.UndefinedSurface? undefinedSurface);
```
#### Parameters

<a name='DiGi.CityGML.Classes.UndefinedSurface.UndefinedSurface(DiGi.CityGML.Classes.UndefinedSurface).undefinedSurface'></a>

`undefinedSurface` [UndefinedSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.UndefinedSurface 'DiGi\.CityGML\.Classes\.UndefinedSurface')

The source [UndefinedSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.UndefinedSurface 'DiGi\.CityGML\.Classes\.UndefinedSurface') instance to copy from\.

<a name='DiGi.CityGML.Classes.UndefinedSurface.UndefinedSurface(string,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D)'></a>

## UndefinedSurface\(string, IPolygonalFace3D\) Constructor

Initializes a new instance of the [UndefinedSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.UndefinedSurface 'DiGi\.CityGML\.Classes\.UndefinedSurface') class with a unique identifier and geometry\.

```csharp
public UndefinedSurface(string? uniqueId, DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? geometry);
```
#### Parameters

<a name='DiGi.CityGML.Classes.UndefinedSurface.UndefinedSurface(string,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the surface\.

<a name='DiGi.CityGML.Classes.UndefinedSurface.UndefinedSurface(string,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D).geometry'></a>

`geometry` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The polygonal face 3D geometry associated with the surface\.

<a name='DiGi.CityGML.Classes.UndefinedSurface.UndefinedSurface(System.Text.Json.Nodes.JsonObject)'></a>

## UndefinedSurface\(JsonObject\) Constructor

Initializes a new instance of the [UndefinedSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.UndefinedSurface 'DiGi\.CityGML\.Classes\.UndefinedSurface') class using a JSON object\.

```csharp
public UndefinedSurface(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.CityGML.Classes.UndefinedSurface.UndefinedSurface(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the surface data\.

<a name='DiGi.CityGML.Classes.WallSurface'></a>

## WallSurface Class

Represents a wall surface within the CityGML model, inheriting from the base [Surface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Surface 'DiGi\.CityGML\.Classes\.Surface') class\.

```csharp
public class WallSurface : DiGi.CityGML.Classes.Surface
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.UniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueidobject 'DiGi\.Core\.Classes\.UniqueIdObject') → [Surface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Surface 'DiGi\.CityGML\.Classes\.Surface') → WallSurface
### Constructors

<a name='DiGi.CityGML.Classes.WallSurface.WallSurface(DiGi.CityGML.Classes.WallSurface)'></a>

## WallSurface\(WallSurface\) Constructor

Initializes a new instance of the [WallSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.WallSurface 'DiGi\.CityGML\.Classes\.WallSurface') class by copying an existing [WallSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.WallSurface 'DiGi\.CityGML\.Classes\.WallSurface') instance\.

```csharp
public WallSurface(DiGi.CityGML.Classes.WallSurface? wallSurface);
```
#### Parameters

<a name='DiGi.CityGML.Classes.WallSurface.WallSurface(DiGi.CityGML.Classes.WallSurface).wallSurface'></a>

`wallSurface` [WallSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.WallSurface 'DiGi\.CityGML\.Classes\.WallSurface')

The source wall surface instance to copy from\.

<a name='DiGi.CityGML.Classes.WallSurface.WallSurface(string,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D)'></a>

## WallSurface\(string, IPolygonalFace3D\) Constructor

Initializes a new instance of the [WallSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.WallSurface 'DiGi\.CityGML\.Classes\.WallSurface') class with a specified unique identifier and geometry\.

```csharp
public WallSurface(string? uniqueId, DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? geometry);
```
#### Parameters

<a name='DiGi.CityGML.Classes.WallSurface.WallSurface(string,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the wall surface\.

<a name='DiGi.CityGML.Classes.WallSurface.WallSurface(string,DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D).geometry'></a>

`geometry` [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')

The polygonal 3D face representing the geometry of the wall surface\.

<a name='DiGi.CityGML.Classes.WallSurface.WallSurface(System.Text.Json.Nodes.JsonObject)'></a>

## WallSurface\(JsonObject\) Constructor

Initializes a new instance of the [WallSurface](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.WallSurface 'DiGi\.CityGML\.Classes\.WallSurface') class using the provided JSON object\.

```csharp
public WallSurface(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.CityGML.Classes.WallSurface.WallSurface(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the wall surface data\.