using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class MaterialDefinitionInfo
    {
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; internal set; }
        
        [JsonProperty("type")]
        public string Type { get; internal set; }

        [JsonProperty("params")]
        public MaterialParams Params { get; internal set; }
    }
}