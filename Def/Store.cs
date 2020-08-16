using Newtonsoft.Json;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace SharpI3S.Def
{
    public class Store
    {
        [JsonProperty("id")]
        public string ID { get; internal set; }

        [JsonProperty("profile", Required = Required.Always)]
        public string Profile { get; internal set; }

        [JsonProperty("resourcePattern")]
        public List<string> ResourcePattern { get; internal set; }

        [JsonProperty("rootNode")]
        public string RootNode { get; internal set; }

        [JsonProperty("version", Required = Required.Always)]
        public string Version { get; internal set; }

        [JsonProperty("extent")]
        public double[] Extent { get; internal set; }

        [JsonProperty("indexCRS")]
        public string IndexCRS { get; internal set; }

        [JsonProperty("vertexCRS")]
        public string VertexCRS { get; internal set; }

        [JsonProperty("normalReferenceFrame")]
        public string NormalReferenceFrame { get; internal set; }

        [JsonProperty("nidEncoding")]
        public string NidEncoding { get; internal set; }

        [JsonProperty("featureEncoding")]
        public string FeatureEncoding { get; internal set; }

        [JsonProperty("geometryEncoding")]
        public string GeometryEncoding { get; internal set; }

        [JsonProperty("attributeEncoding")]
        public string AttributeEncoding { get; internal set; }

        [JsonProperty("textureEncoding")]
        public List<string> TextureEncoding { get; internal set; }

        [JsonProperty("lodModel")]
        public string LodModel { get; internal set; }

        [JsonProperty("indexingScheme")]
        public string IndexingScheme { get; internal set; }

        [JsonProperty("defaultGeometrySchema")]
        public DefaultGeometrySchema DefaultGeometrySchema { get; internal set; }

        [JsonProperty("defaultTextureDefinition")]
        public Texture DefaultTextureDefinition { get; internal set; }

        [JsonProperty("defaultMaterialDefinition")]
        public KeyValuePair<string, MaterialDefinitionInfo>  DefaultMaterialDefinition { get; internal set; }
    }
}