using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class VertexAttribute
    {
        [JsonProperty("position", Required = Required.Always)]
        public GeometryAttribute Position { get; internal set; }

        [JsonProperty("normal", Required = Required.Always)]
        public GeometryAttribute Normal { get; internal set; }

        [JsonProperty("uv0", Required = Required.Always)]
        public GeometryAttribute UV0 { get; internal set; }

        [JsonProperty("color", Required = Required.Always)]
        public GeometryAttribute Color { get; internal set; }

        [JsonProperty("region")]
        public GeometryAttribute Region { get; internal set; }
    }
}