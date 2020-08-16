using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class HeaderAttribute
    {
        [JsonProperty("property", Required = Required.Always)]
        public string Property { get; internal set; }
        
        /// <summary>
        /// UInt8/UInt16/UInt32/UInt64/Int16/Int32/Int64/Float32/Float64
        /// </summary>
        [JsonProperty("type", Required = Required.Always)]
        public string Type { get; internal set; }
    }
}