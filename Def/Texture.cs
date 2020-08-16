using Newtonsoft.Json;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace SharpI3S.Def
{
    public class Texture
    {
        [JsonProperty("encoding")]
        public List<string> Encoding { get; internal set; }

        /// <summary>
        /// none/repeat/mirror
        /// </summary>
        [JsonProperty("wrap")]
        public List<string> Wrap { get; internal set; }

        [JsonProperty("altas")]
        public bool Atlas { get; internal set; }

        [JsonProperty("uvSet")]
        public string UVSet { get; internal set; }

        [JsonProperty("channels")]
        public List<string> Channels { get; internal set; }
    }
}