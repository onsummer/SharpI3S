using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class GeometryFaceRange
    {
        /// <summary>
        /// must be UInt32
        /// </summary>
        [JsonProperty("type", Required = Required.Always)]
        public string Type
        {
            get => "UInt32";
            internal set { }
        }

        [JsonProperty("component", Required = Required.Always)]
        public int Component { get; internal set; }

        /// <summary>
        /// must be none
        /// </summary>
        [JsonProperty("encoding")]
        public string Encoding { get => "none"; internal set { } }

        /// <summary>
        /// must be per-feature
        /// </summary>
        [JsonProperty("binding")]
        public string Binding { get => "per-feature"; internal set { } }
    }
}