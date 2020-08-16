using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class GeometryColor
    {
        /// <summary>
        /// must be UInt8
        /// </summary>
        [JsonProperty("type", Required = Required.Always)]
        public string Type
        {
            get => "UInt8";
            internal set { }
        }

        [JsonProperty("component")]
        public int Component { get; internal set; }

        /// <summary>
        /// must be normalized
        /// </summary>
        [JsonProperty("encoding")]
        public string Encoding { get => "normalized"; internal set { } }

        /// <summary>
        /// must be per-vertex
        /// </summary>
        [JsonProperty("binding")]
        public string Binding { get => "per-vertex"; internal set { } }
    }
}