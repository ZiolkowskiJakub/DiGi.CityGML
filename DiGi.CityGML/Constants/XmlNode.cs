namespace DiGi.CityGML.Constants
{
    /// <summary>
    /// Provides a centralized collection of constants used for XML node identification within CityGML processing.
    /// </summary>
    public static class XmlNode
    {
        /// <summary>
        /// Contains the string representations of XML element and attribute names defined in the CityGML schema.
        /// </summary>
        public static class Name
        {
            /// <summary>
            /// The XML node name for the root City Model element.
            /// </summary>
            public const string CityModel = "CityModel";

            /// <summary>
            /// The XML node name for a member of a city object collection.
            /// </summary>
            public const string CityObjectMember = "cityObjectMember";

            /// <summary>
            /// The XML node name for a Building object.
            /// </summary>
            public const string Building = "Building";

            /// <summary>
            /// The XML node name for a generic string attribute.
            /// </summary>
            public const string StringAttribute = "stringAttribute";

            /// <summary>
            /// The XML node name for the value of an attribute.
            /// </summary>
            public const string Value = "value";

            /// <summary>
            /// The XML node name for the roof type specification.
            /// </summary>
            public const string RoofType = "roofType";

            /// <summary>
            /// The XML node name indicating that a surface is bounded by specific geometry.
            /// </summary>
            public const string BoundedBy = "boundedBy";

            /// <summary>
            /// The XML node name for a ground surface.
            /// </summary>
            public const string GroundSurface = "GroundSurface";

            /// <summary>
            /// The XML node name for a wall surface.
            /// </summary>
            public const string WallSurface = "WallSurface";

            /// <summary>
            /// The XML node name for a roof surface.
            /// </summary>
            public const string RoofSurface = "RoofSurface";

            /// <summary>
            /// The XML node name for a linear ring geometry.
            /// </summary>
            public const string LinearRing = "LinearRing";

            /// <summary>
            /// The XML node name for a polygon geometry.
            /// </summary>
            public const string Polygon = "Polygon";

            /// <summary>
            /// The XML node name for a single position coordinate.
            /// </summary>
            public const string Pos = "pos";

            /// <summary>
            /// The XML node name for the exterior boundary of a polygon.
            /// </summary>
            public const string Exterior = "exterior";

            /// <summary>
            /// The XML node name for the interior boundaries (holes) of a polygon.
            /// </summary>
            public const string Interior = "interior";

            /// <summary>
            /// The XML node name for Level of Detail 1 (LOD1) solid representation.
            /// </summary>
            public const string LOD1Solid = "lod1Solid";

            /// <summary>
            /// The XML node name for a list of position coordinates.
            /// </summary>
            public const string PosList = "posList";
        }
    }
}