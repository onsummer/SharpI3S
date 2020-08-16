using Newtonsoft.Json;
using System.Collections.Generic;

namespace SharpI3S.Def
{
    public class DefaultGeometrySchema
    {
        [JsonProperty("geometryType")]
        public string GeometryType { get; internal set; }

        [JsonProperty("topology", Required = Required.Always)]
        public string Topology { get; internal set; }

        [JsonProperty("ordering", Required = Required.Always)]
        public List<string> Ordering { get; internal set; }

        [JsonProperty("featureAttributeOrder", Required = Required.Always)]
        public List<string> FeatureAttributeOrder { get; internal set; }

        [JsonProperty("vertexAttribute", Required = Required.Always)]
        public VertexAttribute VertexAttribute { get; internal set; }

        [JsonProperty("faces")]
        public VertexAttribute Faces { get; internal set; }

        [JsonProperty("featureAttributes", Required = Required.Always)]
        public FeatureAttribute FeatureAttributes { get; internal set; }

        [JsonProperty("header", Required = Required.Always)]
        public List<HeaderAttribute> Header { get; internal set; }
    }
}