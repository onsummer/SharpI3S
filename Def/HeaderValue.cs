using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class HeaderValue
    {
        /// <summary>
        /// Int8~16~32/UInt8~16~32/Float32~64/String
        /// </summary>
        [JsonProperty("valueType", Required = Required.Always)]
        public string ValueType { get; internal set; }

        /// <summary>
        /// count/attributeValuesByteCount
        /// </summary>
        [JsonProperty("property", Required = Required.Always)]
        public string Property { get; internal set; }
    }
}