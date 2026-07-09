#### [DiGi\.CityGML](DiGi.CityGML.Overview.md 'DiGi\.CityGML\.Overview')

## DiGi\.CityGML\.Constants Namespace
### Classes

<a name='DiGi.CityGML.Constants.XmlAttribute'></a>

## XmlAttribute Class

Provides a centralized collection of constant strings used as XML attribute names within the CityGML context\.

```csharp
public static class XmlAttribute
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → XmlAttribute

<a name='DiGi.CityGML.Constants.XmlAttribute.Name'></a>

## XmlAttribute\.Name Class

Contains specific XML attribute name constants\.

```csharp
public static class XmlAttribute.Name
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Name
### Fields

<a name='DiGi.CityGML.Constants.XmlAttribute.Name.AttributeName'></a>

## XmlAttribute\.Name\.AttributeName Field

The constant value for the "name" XML attribute\.

```csharp
public const string AttributeName = "name";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.CityGML.Constants.XmlAttribute.Name.Id'></a>

## XmlAttribute\.Name\.Id Field

The constant value for the "id" XML attribute\.

```csharp
public const string Id = "id";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.CityGML.Constants.XmlNode'></a>

## XmlNode Class

Provides a centralized collection of constants used for XML node identification within CityGML processing\.

```csharp
public static class XmlNode
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → XmlNode

<a name='DiGi.CityGML.Constants.XmlNode.Name'></a>

## XmlNode\.Name Class

Contains the string representations of XML element and attribute names defined in the CityGML schema\.

```csharp
public static class XmlNode.Name
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Name
### Fields

<a name='DiGi.CityGML.Constants.XmlNode.Name.BoundedBy'></a>

## XmlNode\.Name\.BoundedBy Field

The XML node name indicating that a surface is bounded by specific geometry\.

```csharp
public const string BoundedBy = "boundedBy";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.CityGML.Constants.XmlNode.Name.Building'></a>

## XmlNode\.Name\.Building Field

The XML node name for a Building object\.

```csharp
public const string Building = "Building";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.CityGML.Constants.XmlNode.Name.CityModel'></a>

## XmlNode\.Name\.CityModel Field

The XML node name for the root City Model element\.

```csharp
public const string CityModel = "CityModel";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.CityGML.Constants.XmlNode.Name.CityObjectMember'></a>

## XmlNode\.Name\.CityObjectMember Field

The XML node name for a member of a city object collection\.

```csharp
public const string CityObjectMember = "cityObjectMember";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.CityGML.Constants.XmlNode.Name.Exterior'></a>

## XmlNode\.Name\.Exterior Field

The XML node name for the exterior boundary of a polygon\.

```csharp
public const string Exterior = "exterior";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.CityGML.Constants.XmlNode.Name.GroundSurface'></a>

## XmlNode\.Name\.GroundSurface Field

The XML node name for a ground surface\.

```csharp
public const string GroundSurface = "GroundSurface";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.CityGML.Constants.XmlNode.Name.Interior'></a>

## XmlNode\.Name\.Interior Field

The XML node name for the interior boundaries \(holes\) of a polygon\.

```csharp
public const string Interior = "interior";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.CityGML.Constants.XmlNode.Name.LinearRing'></a>

## XmlNode\.Name\.LinearRing Field

The XML node name for a linear ring geometry\.

```csharp
public const string LinearRing = "LinearRing";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.CityGML.Constants.XmlNode.Name.LOD1Solid'></a>

## XmlNode\.Name\.LOD1Solid Field

The XML node name for Level of Detail 1 \(LOD1\) solid representation\.

```csharp
public const string LOD1Solid = "lod1Solid";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.CityGML.Constants.XmlNode.Name.Polygon'></a>

## XmlNode\.Name\.Polygon Field

The XML node name for a polygon geometry\.

```csharp
public const string Polygon = "Polygon";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.CityGML.Constants.XmlNode.Name.Pos'></a>

## XmlNode\.Name\.Pos Field

The XML node name for a single position coordinate\.

```csharp
public const string Pos = "pos";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.CityGML.Constants.XmlNode.Name.PosList'></a>

## XmlNode\.Name\.PosList Field

The XML node name for a list of position coordinates\.

```csharp
public const string PosList = "posList";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.CityGML.Constants.XmlNode.Name.RoofSurface'></a>

## XmlNode\.Name\.RoofSurface Field

The XML node name for a roof surface\.

```csharp
public const string RoofSurface = "RoofSurface";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.CityGML.Constants.XmlNode.Name.RoofType'></a>

## XmlNode\.Name\.RoofType Field

The XML node name for the roof type specification\.

```csharp
public const string RoofType = "roofType";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.CityGML.Constants.XmlNode.Name.StringAttribute'></a>

## XmlNode\.Name\.StringAttribute Field

The XML node name for a generic string attribute\.

```csharp
public const string StringAttribute = "stringAttribute";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.CityGML.Constants.XmlNode.Name.Value'></a>

## XmlNode\.Name\.Value Field

The XML node name for the value of an attribute\.

```csharp
public const string Value = "value";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.CityGML.Constants.XmlNode.Name.WallSurface'></a>

## XmlNode\.Name\.WallSurface Field

The XML node name for a wall surface\.

```csharp
public const string WallSurface = "WallSurface";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')