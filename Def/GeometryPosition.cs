using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class GeometryPosition
    {
        /// <summary>
        /// must be Float32
        /// </summary>
        [JsonProperty("type", Required = Required.Always)]
        public string Type 
        {
            get => "Float32";
            internal set { }
        }

        /// <summary>
        /// must be 3
        /// </summary>
        [JsonProperty("component")]
        public int Component { get => 3; internal set { } }

        /// <summary>
        /// must be none
        /// </summary>
        [JsonProperty("encoding")]
        public string Encoding { get => "none"; internal set { } }

        /// <summary>
        /// must be per-vertex
        /// </summary>
        [JsonProperty("binding")]
        public string Binding { get => "per-vertex"; internal set { } }
    }
}