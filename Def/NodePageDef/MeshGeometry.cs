using Newtonsoft.Json;

namespace SharpI3S.Def.NodePageDef
{
    public class MeshGeometry
    {
        [JsonProperty("definition", Required = Required.Always)]
        public int Definition { get; internal set; }

        [JsonProperty("resource", Required = Required.Always)]
        public int Resource { get; internal set; }

        [JsonProperty("vertexCount")]
        public int VertexCount { get; internal set; }

        [JsonProperty("featureCount")]
        public int FeatureCount { get; internal set; }
    }
}