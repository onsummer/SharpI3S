using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class DomainCodedValue
    {
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; internal set; }

        [JsonProperty("code", Required = Required.Always)]
        public double Code { get; internal set; }
    }
}