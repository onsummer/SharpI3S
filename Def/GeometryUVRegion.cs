using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class GeometryUVRegion
    {
        /// <summary>
        /// must be UInt16
        /// </summary>
        [JsonProperty("type", Required = Required.Always)]
        public string Type
        {
            get => "UInt16";
            internal set { }
        }

        /// <summary>
        /// must be 4
        /// </summary>
        [JsonProperty("component")]
        public int Component { get => 4; internal set { } }

        /// <summary>
        /// must be normalized
        /// </summary>
        [JsonProperty("encoding")]
        public string Encoding { get => "normalized"; internal set { } }

        /// <summary>
        /// must be per-vertex/per-uvregion
        /// </summary>
        [JsonProperty("binding")]
        public string Binding { get; internal set; }
    }
}