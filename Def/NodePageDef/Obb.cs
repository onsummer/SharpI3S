using Newtonsoft.Json;

namespace SharpI3S.Def.NodePageDef
{
    public class Obb
    {
        [JsonProperty("center", Required = Required.Always)]
        public double[] Center { get; internal set; }
        [JsonProperty("halfSize", Required = Required.Always)]
        public double[] HalfSize { get; internal set; }
        [JsonProperty("quaternion", Required = Required.Always)]
        public double[] Quaternion { get; internal set; }
    }
}