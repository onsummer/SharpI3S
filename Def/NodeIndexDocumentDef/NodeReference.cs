using Newtonsoft.Json;
using SharpI3S.Def.NodePageDef;

namespace SharpI3S.Def.NodeIndexDocumentDef
{
    public class NodeReference
    {
        [JsonProperty("id", Required = Required.Always)]
        public string ID { get; internal set; }

        [JsonProperty("mbs")]
        public double[] MBS { get; internal set; }

        [JsonProperty("href")]
        public string Href { get; internal set; }

        [JsonProperty("version")]
        public string Version { get; internal set; }

        [JsonProperty("featureCount")]
        public int FeatureCount { get; internal set; }

        [JsonProperty("obb")]
        public Obb Obb { get; internal set; }
    }
}