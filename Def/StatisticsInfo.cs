using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class StatisticsInfo
    {
        [JsonProperty("key", Required = Required.Always)]
        public string Key { get; internal set; }

        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; internal set; }

        [JsonProperty("href", Required = Required.Always)]
        public string Href { get; internal set; }
    }
}