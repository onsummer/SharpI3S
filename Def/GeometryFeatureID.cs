using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class GeometryFeatureID
    {
        /// <summary>
        /// must be UInt16/UInt32/UInt64
        /// </summary>
        [JsonProperty("type", Required = Required.Always)]
        public string Type { get; internal set; }

        /// <summary>
        /// must be 1
        /// </summary>
        [JsonProperty("component", Required = Required.Always)]
        public int Component { get => 1; internal set { } }

        /// <summary>
        /// must be none
        /// </summary>
        [JsonProperty("encoding")]
        public string Encoding { get => "none"; internal set { } }

        [JsonProperty("binding")]
        public string Binding { get; internal set; }
    }
}