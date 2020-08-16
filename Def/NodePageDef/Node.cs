using Newtonsoft.Json;

namespace SharpI3S.Def.NodePageDef
{
    public class Node
    {
        [JsonProperty("index", Required = Required.Always)]
        public int Index { get; internal set; }

        [JsonProperty("lodThreshold")]
        public double LodThreshold { get; internal set; }

        [JsonProperty("obb", Required = Required.Always)]
        public Obb Obb { get; internal set; }

        [JsonProperty("children")]
        public int[] Children { get; internal set; }

        [JsonProperty("mesh")]
        public Mesh Mesh { get; internal set; }
    }
}