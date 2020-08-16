using Newtonsoft.Json;
using System.Collections.Generic;

namespace SharpI3S.Def
{
    public class CompressedAttributes
    {
        /// <summary>
        /// must be draco
        /// </summary>
        [JsonProperty("encoding", Required = Required.Always)]
        public string Encoding { get => "draco"; internal set { } }

        /// <summary>
        /// position/normal/uv0/color/uv-region/feature-index
        /// </summary>
        [JsonProperty("attributes", Required = Required.Always)]
        public List<string> Attributes { get; internal set; }
    }
}