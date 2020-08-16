using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class Value
    {
        [JsonProperty("valueType", Required = Required.Always)]
        public string ValueType { get; internal set; }

        [JsonProperty("encoding")]
        public string Encoding { get; internal set; }

        [JsonProperty("valuesPerElement")]
        public double ValuesPerElement { get; internal set; }
    }
}