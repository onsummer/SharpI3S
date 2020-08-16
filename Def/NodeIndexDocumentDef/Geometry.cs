using Newtonsoft.Json;

namespace SharpI3S.Def.NodeIndexDocumentDef
{
    public class Geometry
    {
        [JsonProperty("id", Required = Required.Always)]
        public int ID { get; internal set; }

        [JsonProperty("type")]
        public string Type { get; internal set; }

        [JsonProperty("transformation")]
        public double[] Transformation { get; internal set; }
        
        [JsonProperty("params")]
        public GeometryParams Params { get; internal set; }
    }
}