using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class NodePageDefinition
    {

        [JsonProperty("nodesPerPage", Required = Required.Always)]
        public int NodesPerPage { get; internal set; }

        [JsonProperty("rootIndex", Required = Required.Always)]
        public int RootIndex { get; internal set; }

        [JsonProperty("lodSelectionMetricType", Required = Required.Always)]
        public string LodSelectionMetricType { get; internal set; }
    }
}