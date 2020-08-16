using Newtonsoft.Json;
using System.Collections.Generic;

namespace SharpI3S.Def
{
    public class AttributeStorageInfo
    {
        [JsonProperty("key", Required = Required.Always)]
        public string Key { get; internal set; }

        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; internal set; }

        [JsonProperty("header", Required = Required.Always)]
        public List<HeaderValue> Header { get; internal set; }

        /// <summary>
        /// attributeByteCounts/attributeValues/ObjectIds
        /// </summary>
        [JsonProperty("ordering")]
        public List<string> Ordering { get; internal set; }

        [JsonProperty("attributeValues")]
        public Value AttributeValues { get; internal set; }

        [JsonProperty("objectIds")]
        public Value ObjectIds { get; internal set; }
        
        [JsonProperty("attributeByteCounts")]
        public Value AttributeByteCounts { get; internal set; }
    }
}