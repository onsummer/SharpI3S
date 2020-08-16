using Newtonsoft.Json;
using System.Collections.Generic;

namespace SharpI3S.Def
{
    public class Domain
    {
        [JsonProperty("type", Required = Required.Always)]
        public string Type { get; internal set; }

        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; internal set; }

        [JsonProperty("description")]
        public string Description { get; internal set; }

        /// <summary>
        /// esriFieldTypeDate/esriFieldTypeSingle/esriFieldTypeDouble
        /// esriFieldTypeInteger/esriFieldTypeSmallInteger/esriFieldTypeString
        /// </summary>
        [JsonProperty("fieldType")]
        public string FieldType { get; internal set; }

        /// <summary>
        /// esriMPTDefaultValue/esriMPTSumValues/esriMPTAreaWeighted
        /// </summary>
        [JsonProperty("mergePolicy")]
        public string MergePolicy { get; internal set; }

        /// <summary>
        /// esriSPTGeometryRatio/esriSPTDuplicate/esriSPTDefaultValue
        /// </summary>
        [JsonProperty("splitPolicy")]
        public string SplitPolicy { get; internal set; }

        [JsonProperty("range")]
        public double[] Range { get; internal set; }

        [JsonProperty("codedValues")]
        public List<DomainCodedValue> CodedValues {get;}

    }
}