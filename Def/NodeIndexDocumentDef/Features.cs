using Newtonsoft.Json;
using System.Collections.Generic;

namespace SharpI3S.Def.NodeIndexDocumentDef
{
    public class Features
    {
        [JsonProperty("featureData")]
        public List<FeatureData> FeatureData { get; internal set; }

        [JsonProperty("geometryData")]
        public List<Geometry> GeometryData { get; internal set; }
    }
}