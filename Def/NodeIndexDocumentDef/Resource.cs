using Newtonsoft.Json;
using System.Collections.Generic;

namespace SharpI3S.Def.NodeIndexDocumentDef
{
    public class Resource
    {
        [JsonProperty("href", Required = Required.Always)]
        public string Href { get; internal set; }

        [JsonProperty("layerContent")]
        public List<string> LayerContent { get; internal set; }

        [JsonProperty("featureRange")]
        public int[] FeatureRange { get; internal set; }

        [JsonProperty("multiTextureBundle")]
        public string MultiTextureBundle { get; internal set; }

        [JsonProperty("vertexElements")]
        public int[] VertexElements { get; internal set; }

        [JsonProperty("faceElements")]
        public int[] FaceElements { get; internal set; }
    }
}