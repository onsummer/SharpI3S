using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class Field
    {
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; internal set; }

        /// <summary>
        /// esriFieldTypeDate/esriFieldTypeSingle/esriFieldTypeDouble/esriFieldTypeGUID
        /// esriFieldTypeGlobalID/esriFieldTypeInteger/esriFieldTypeOID/esriFieldTypeSmallInteger
        /// esriFieldTypeString
        /// </summary>
        [JsonProperty("type", Required = Required.Always)]
        public string Type { get; internal set; }

        [JsonProperty("alias")]
        public string Alias { get; internal set; }

        [JsonProperty("domain")]
        public Domain Domain { get; internal set; }
    }
}