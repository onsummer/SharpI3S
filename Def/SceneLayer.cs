using Newtonsoft.Json;
using System.Collections.Generic;

namespace SharpI3S.Def
{
    public class SceneLayer
    {
        #region Properties

        [JsonProperty("id")]
        public int ID { get; internal set; }

        [JsonProperty("href")]
        public string Href { get; internal set; }

        [JsonProperty("layerType")]
        public string LayerType { get; internal set; }

        [JsonProperty("version")]
        public string Version { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("alias")]
        public string Alias { get; internal set; }

        [JsonProperty("description")]
        public string Description { get; internal set; }

        [JsonProperty("copyrightText")]
        public string CopyrightText { get; internal set; }

        /// <summary>
        /// 只能是 "View" "Query" "Edit"
        /// </summary>
        [JsonProperty("capabilities")]
        public List<string> Capabilities { get; internal set; }

        [JsonProperty("zFactor")]
        public double ZFactor { get; internal set; }

        [JsonProperty("disablePopup")]
        public bool DisablePopup { get; internal set; }

        [JsonProperty("spatialReference")]
        public SpatialReference SpatialReference { get; internal set; }

        [JsonProperty("heightModelInfo")]
        public HeightModelInfo HeightModelInfo { get; internal set; }

        [JsonProperty("serviceUpdateTimeStamp")]
        public ServiceUpdateTimeStamp ServiceUpdateTimeStamp { get; internal set; }

        [JsonProperty("cachedDrawingInfo")]
        public CachedDrawingInfo CachedDrawingInfo { get; internal set; }

        [JsonProperty("drawingInfo")]
        public DrawingInfo DrawingInfo { get; internal set; }

        [JsonProperty("elevationInfo")]
        public ElevationInfo ElevationInfo { get; internal set; }

        [JsonProperty("popupInfo")]
        public PopupInfo PopupInfo { get; internal set; }

        [JsonProperty("store")]
        public Store Store { get; internal set; }

        [JsonProperty("fields")]
        public List<Field> Fields { get; internal set; }

        [JsonProperty("attributeStorageInfos")]
        public List<AttributeStorageInfo> AttributeStorageInfos { get; internal set; }

        [JsonProperty("statisticsInfos")]
        public List<StatisticsInfo> StatisticsInfos { get; internal set; }

        [JsonProperty("nodePageDefinition")]
        public NodePageDefinition NodePageDefinition { get; internal set; }

        [JsonProperty("materialDefinitions")]
        public List<MaterialDefinition>  MaterialDefinitions { get; internal set; }

        [JsonProperty("textureSetDefinitions")]
        public List<TextureSetDefinition> TextureSetDefinitions { get; internal set; }

        [JsonProperty("geometryDefinitions")]
        public List<GeometryDefinition> GeometryDefinitions { get; internal set; }

        #endregion
    }
}
