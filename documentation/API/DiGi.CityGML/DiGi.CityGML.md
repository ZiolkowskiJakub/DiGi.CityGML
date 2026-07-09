#### [DiGi\.CityGML](DiGi.CityGML.Overview.md 'DiGi\.CityGML\.Overview')

## DiGi\.CityGML Namespace
### Classes

<a name='DiGi.CityGML.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.CityGML.Convert.ToCityGML_Building(System.Xml.XmlNode)'></a>

## Convert\.ToCityGML\_Building\(XmlNode\) Method

Converts an XML node to a CityGML Building object\.

```csharp
public static DiGi.CityGML.Classes.Building? ToCityGML_Building(System.Xml.XmlNode? xmlNode);
```
#### Parameters

<a name='DiGi.CityGML.Convert.ToCityGML_Building(System.Xml.XmlNode).xmlNode'></a>

`xmlNode` [System\.Xml\.XmlNode](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmlnode 'System\.Xml\.XmlNode')

The XML node containing the building data\.

#### Returns
[Building](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Building 'DiGi\.CityGML\.Classes\.Building')  
A [Building](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Building 'DiGi\.CityGML\.Classes\.Building') instance if the conversion is successful; otherwise, null\.

<a name='DiGi.CityGML.Convert.ToCityGML_CityModel(System.Xml.XmlNode)'></a>

## Convert\.ToCityGML\_CityModel\(XmlNode\) Method

Converts an XML node into a [CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel') instance\.

```csharp
public static DiGi.CityGML.Classes.CityModel? ToCityGML_CityModel(System.Xml.XmlNode? xmlNode);
```
#### Parameters

<a name='DiGi.CityGML.Convert.ToCityGML_CityModel(System.Xml.XmlNode).xmlNode'></a>

`xmlNode` [System\.Xml\.XmlNode](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmlnode 'System\.Xml\.XmlNode')

The XML node to be converted\.

#### Returns
[CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel')  
A [CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel') object if the conversion is successful; otherwise, null\.

<a name='DiGi.CityGML.Convert.ToCityGML_Point3D(System.Xml.XmlNode)'></a>

## Convert\.ToCityGML\_Point3D\(XmlNode\) Method

Converts an XML node containing coordinate strings into a [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') object\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? ToCityGML_Point3D(System.Xml.XmlNode xmlNode);
```
#### Parameters

<a name='DiGi.CityGML.Convert.ToCityGML_Point3D(System.Xml.XmlNode).xmlNode'></a>

`xmlNode` [System\.Xml\.XmlNode](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmlnode 'System\.Xml\.XmlNode')

The XML node to be parsed for 3D point coordinates\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') instance if the parsing is successful; otherwise, `null`\.

<a name='DiGi.CityGML.Convert.ToCityGML_Point3Ds(System.Xml.XmlNode)'></a>

## Convert\.ToCityGML\_Point3Ds\(XmlNode\) Method

Converts an XML node containing a space\-separated string of coordinates into a list of [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') objects\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Point3D>? ToCityGML_Point3Ds(System.Xml.XmlNode? xmlNode);
```
#### Parameters

<a name='DiGi.CityGML.Convert.ToCityGML_Point3Ds(System.Xml.XmlNode).xmlNode'></a>

`xmlNode` [System\.Xml\.XmlNode](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmlnode 'System\.Xml\.XmlNode')

The XML node to be parsed for coordinate data\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') instances if the input is valid and contains coordinates; otherwise, `null`\.

<a name='DiGi.CityGML.Convert.ToCityGML_Polygon3D(System.Xml.XmlNode)'></a>

## Convert\.ToCityGML\_Polygon3D\(XmlNode\) Method

Converts an XML node representing a CityGML polygon into a [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') object\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polygon3D? ToCityGML_Polygon3D(System.Xml.XmlNode? xmlNode);
```
#### Parameters

<a name='DiGi.CityGML.Convert.ToCityGML_Polygon3D(System.Xml.XmlNode).xmlNode'></a>

`xmlNode` [System\.Xml\.XmlNode](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmlnode 'System\.Xml\.XmlNode')

The XML node containing the polygon data, which may consist of a position list or individual position elements\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') instance if the conversion is successful and at least three points are defined; otherwise, `null`\.

<a name='DiGi.CityGML.Convert.ToCityGML_PolygonalFace3D(System.Xml.XmlNode,double)'></a>

## Convert\.ToCityGML\_PolygonalFace3D\(XmlNode, double\) Method

Converts an XML node representing a CityGML polygonal face into an [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') instance\.

```csharp
public static DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D? ToCityGML_PolygonalFace3D(System.Xml.XmlNode? xmlNode, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.CityGML.Convert.ToCityGML_PolygonalFace3D(System.Xml.XmlNode,double).xmlNode'></a>

`xmlNode` [System\.Xml\.XmlNode](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmlnode 'System\.Xml\.XmlNode')

The XML node to be converted\.

<a name='DiGi.CityGML.Convert.ToCityGML_PolygonalFace3D(System.Xml.XmlNode,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for geometric processing\. Defaults to [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')  
An [DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D') object if the conversion is successful; otherwise, `null`\.

<a name='DiGi.CityGML.Convert.ToCityGML_Surface(System.Xml.XmlNode)'></a>

## Convert\.ToCityGML\_Surface\(XmlNode\) Method

Converts an XML node to a CityGML surface implementation based on the node's local name and content\.

```csharp
public static DiGi.CityGML.Interfaces.ISurface? ToCityGML_Surface(System.Xml.XmlNode? xmlNode);
```
#### Parameters

<a name='DiGi.CityGML.Convert.ToCityGML_Surface(System.Xml.XmlNode).xmlNode'></a>

`xmlNode` [System\.Xml\.XmlNode](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmlnode 'System\.Xml\.XmlNode')

The XML node to be converted into a surface\.

#### Returns
[ISurface](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ISurface 'DiGi\.CityGML\.Interfaces\.ISurface')  
An instance of [ISurface](DiGi.CityGML.Interfaces.md#DiGi.CityGML.Interfaces.ISurface 'DiGi\.CityGML\.Interfaces\.ISurface') \(such as RoofSurface, WallSurface, or GroundSurface\) if the conversion is successful; otherwise, `null`\.

<a name='DiGi.CityGML.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.CityGML.Create.CityModel(string,System.Nullable_DiGi.CityGML.Enums.LOD_,System.Nullable_int_)'></a>

## Create\.CityModel\(string, Nullable\<LOD\>, Nullable\<int\>\) Method

Creates a [CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel') instance from the specified file path\.

```csharp
public static DiGi.CityGML.Classes.CityModel? CityModel(string? path, System.Nullable<DiGi.CityGML.Enums.LOD> lOD=null, System.Nullable<int> year=null);
```
#### Parameters

<a name='DiGi.CityGML.Create.CityModel(string,System.Nullable_DiGi.CityGML.Enums.LOD_,System.Nullable_int_).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The full path to the CityGML file\.

<a name='DiGi.CityGML.Create.CityModel(string,System.Nullable_DiGi.CityGML.Enums.LOD_,System.Nullable_int_).lOD'></a>

`lOD` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[LOD](DiGi.CityGML.Enums.md#DiGi.CityGML.Enums.LOD 'DiGi\.CityGML\.Enums\.LOD')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

Optional level of detail to assign to the city model\.

<a name='DiGi.CityGML.Create.CityModel(string,System.Nullable_DiGi.CityGML.Enums.LOD_,System.Nullable_int_).year'></a>

`year` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

Optional year to assign to the city model\.

#### Returns
[CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel')  
A [CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel') instance if successful; otherwise, null\.

<a name='DiGi.CityGML.Create.CityModel(System.IO.Stream,System.Nullable_DiGi.CityGML.Enums.LOD_,System.Nullable_int_)'></a>

## Create\.CityModel\(Stream, Nullable\<LOD\>, Nullable\<int\>\) Method

Creates a [CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel') instance from the provided stream\.

```csharp
public static DiGi.CityGML.Classes.CityModel? CityModel(System.IO.Stream? stream, System.Nullable<DiGi.CityGML.Enums.LOD> lOD=null, System.Nullable<int> year=null);
```
#### Parameters

<a name='DiGi.CityGML.Create.CityModel(System.IO.Stream,System.Nullable_DiGi.CityGML.Enums.LOD_,System.Nullable_int_).stream'></a>

`stream` [System\.IO\.Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream 'System\.IO\.Stream')

The input stream containing the CityGML data\.

<a name='DiGi.CityGML.Create.CityModel(System.IO.Stream,System.Nullable_DiGi.CityGML.Enums.LOD_,System.Nullable_int_).lOD'></a>

`lOD` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[LOD](DiGi.CityGML.Enums.md#DiGi.CityGML.Enums.LOD 'DiGi\.CityGML\.Enums\.LOD')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

Optional level of detail to assign to the city model\.

<a name='DiGi.CityGML.Create.CityModel(System.IO.Stream,System.Nullable_DiGi.CityGML.Enums.LOD_,System.Nullable_int_).year'></a>

`year` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

Optional year to assign to the city model\.

#### Returns
[CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel')  
A [CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel') instance if successful; otherwise, null\.

<a name='DiGi.CityGML.Create.CityModel(System.Xml.XmlDocument,System.Nullable_DiGi.CityGML.Enums.LOD_,System.Nullable_int_)'></a>

## Create\.CityModel\(XmlDocument, Nullable\<LOD\>, Nullable\<int\>\) Method

Creates a [CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel') instance from the provided XML document\.

```csharp
public static DiGi.CityGML.Classes.CityModel? CityModel(System.Xml.XmlDocument? xmlDocument, System.Nullable<DiGi.CityGML.Enums.LOD> lOD=null, System.Nullable<int> year=null);
```
#### Parameters

<a name='DiGi.CityGML.Create.CityModel(System.Xml.XmlDocument,System.Nullable_DiGi.CityGML.Enums.LOD_,System.Nullable_int_).xmlDocument'></a>

`xmlDocument` [System\.Xml\.XmlDocument](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmldocument 'System\.Xml\.XmlDocument')

The [System\.Xml\.XmlDocument](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmldocument 'System\.Xml\.XmlDocument') containing the CityGML data\.

<a name='DiGi.CityGML.Create.CityModel(System.Xml.XmlDocument,System.Nullable_DiGi.CityGML.Enums.LOD_,System.Nullable_int_).lOD'></a>

`lOD` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[LOD](DiGi.CityGML.Enums.md#DiGi.CityGML.Enums.LOD 'DiGi\.CityGML\.Enums\.LOD')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

Optional level of detail to assign to the city model\.

<a name='DiGi.CityGML.Create.CityModel(System.Xml.XmlDocument,System.Nullable_DiGi.CityGML.Enums.LOD_,System.Nullable_int_).year'></a>

`year` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

Optional year to assign to the city model\.

#### Returns
[CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel')  
A [CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel') instance if successful; otherwise, null\.

<a name='DiGi.CityGML.Create.CityModels(string)'></a>

## Create\.CityModels\(string\) Method

Creates a list of CityModel objects from a specified file path or directory\. 
It supports individual files, ZIP archives, and directories containing ZIP archives, 
attempting to infer the Level of Detail \(LOD\) and year from the folder hierarchy\.

```csharp
public static System.Collections.Generic.List<DiGi.CityGML.Classes.CityModel>? CityModels(string? path);
```
#### Parameters

<a name='DiGi.CityGML.Create.CityModels(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The system path to the file or directory to process\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [CityModel](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.CityModel 'DiGi\.CityGML\.Classes\.CityModel') objects if successful; otherwise, null\.

<a name='DiGi.CityGML.Create.SetParameters(thisDiGi.CityGML.Classes.Building,System.Xml.XmlNode)'></a>

## Create\.SetParameters\(this Building, XmlNode\) Method

Sets the parameters of a building instance by parsing the provided XML node for attribute names and values that match known building parameters\.

```csharp
public static bool SetParameters(this DiGi.CityGML.Classes.Building? building, System.Xml.XmlNode? xmlNode);
```
#### Parameters

<a name='DiGi.CityGML.Create.SetParameters(thisDiGi.CityGML.Classes.Building,System.Xml.XmlNode).building'></a>

`building` [Building](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Building 'DiGi\.CityGML\.Classes\.Building')

The [Building](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Building 'DiGi\.CityGML\.Classes\.Building') instance to be updated\.

<a name='DiGi.CityGML.Create.SetParameters(thisDiGi.CityGML.Classes.Building,System.Xml.XmlNode).xmlNode'></a>

`xmlNode` [System\.Xml\.XmlNode](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmlnode 'System\.Xml\.XmlNode')

The [System\.Xml\.XmlNode](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmlnode 'System\.Xml\.XmlNode') containing the parameter data to process\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if at least one building parameter was successfully identified and set; otherwise, false\.

<a name='DiGi.CityGML.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.CityGML.Query.BoundingBox(thisDiGi.CityGML.Classes.Building)'></a>

## Query\.BoundingBox\(this Building\) Method

Calculates the 3D bounding box for the specified building by aggregating the bounding boxes of its constituent surfaces\.

```csharp
public static DiGi.Geometry.Spatial.Classes.BoundingBox3D? BoundingBox(this DiGi.CityGML.Classes.Building? building);
```
#### Parameters

<a name='DiGi.CityGML.Query.BoundingBox(thisDiGi.CityGML.Classes.Building).building'></a>

`building` [Building](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Building 'DiGi\.CityGML\.Classes\.Building')

The building instance from which to calculate the spatial extent\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') representing the total volume encompassing all surfaces, or `null` if the building is null or contains no valid geometry\.

<a name='DiGi.CityGML.Query.ClosestPoint(thisDiGi.CityGML.Classes.Building,DiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Query\.ClosestPoint\(this Building, Point3D\) Method

Calculates the point on the surfaces of the specified building that is closest to the provided 3D point\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? ClosestPoint(this DiGi.CityGML.Classes.Building? building, DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.CityGML.Query.ClosestPoint(thisDiGi.CityGML.Classes.Building,DiGi.Geometry.Spatial.Classes.Point3D).building'></a>

`building` [Building](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Building 'DiGi\.CityGML\.Classes\.Building')

The building instance whose surfaces are analyzed to find the nearest point\.

<a name='DiGi.CityGML.Query.ClosestPoint(thisDiGi.CityGML.Classes.Building,DiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The reference 3D point used for the distance calculation\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The closest [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') found across all surfaces of the building, or `null` if the building is null, the point is null, or no valid surfaces exist\.

<a name='DiGi.CityGML.Query.Polyhedron(thisDiGi.CityGML.Classes.Building)'></a>

## Query\.Polyhedron\(this Building\) Method

Extracts the polyhedron geometry from a building by collecting its polygonal surface faces\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polyhedron? Polyhedron(this DiGi.CityGML.Classes.Building? building);
```
#### Parameters

<a name='DiGi.CityGML.Query.Polyhedron(thisDiGi.CityGML.Classes.Building).building'></a>

`building` [Building](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Building 'DiGi\.CityGML\.Classes\.Building')

The building instance from which to extract the polyhedron\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')  
A [Polyhedron\(this Building\)](DiGi.CityGML.md#DiGi.CityGML.Query.Polyhedron(thisDiGi.CityGML.Classes.Building) 'DiGi\.CityGML\.Query\.Polyhedron\(this DiGi\.CityGML\.Classes\.Building\)') representing the 3D volume of the building, or `null` if no valid surfaces are found\.

<a name='DiGi.CityGML.Query.Reference(thisDiGi.CityGML.Classes.Building)'></a>

## Query\.Reference\(this Building\) Method

Extracts and cleans the reference identifier from a building's unique ID, 
removing specific prefixes such as "ID\-" if present\.

```csharp
public static string? Reference(this DiGi.CityGML.Classes.Building? building);
```
#### Parameters

<a name='DiGi.CityGML.Query.Reference(thisDiGi.CityGML.Classes.Building).building'></a>

`building` [Building](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Building 'DiGi\.CityGML\.Classes\.Building')

The [Building](DiGi.CityGML.Classes.md#DiGi.CityGML.Classes.Building 'DiGi\.CityGML\.Classes\.Building') instance to extract the reference from\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A trimmed string containing the processed reference identifier, or null if the building or its unique ID is null\.

<a name='DiGi.CityGML.Query.UniqueId(thisSystem.Xml.XmlNode)'></a>

## Query\.UniqueId\(this XmlNode\) Method

Extracts the unique identifier from the attributes of the specified XML node\.

```csharp
public static string? UniqueId(this System.Xml.XmlNode? xmlNode);
```
#### Parameters

<a name='DiGi.CityGML.Query.UniqueId(thisSystem.Xml.XmlNode).xmlNode'></a>

`xmlNode` [System\.Xml\.XmlNode](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmlnode 'System\.Xml\.XmlNode')

The XML node to search for the unique ID attribute\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The value of the unique ID attribute if it exists; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.