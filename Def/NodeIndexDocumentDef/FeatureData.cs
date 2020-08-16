using Newtonsoft.Json;

namespace SharpI3S.Def.NodeIndexDocumentDef
{
    public class FeatureData
    {
        [JsonProperty("id", Required = Required.Always)]
        public int ID { get; internal set; }

        /// <summary>
        /// 2~3个
        /// </summary>
        [JsonProperty("position")]
        public double[] Position { get; internal set; }

        /// <summary>
        /// 3个
        /// </summary>
        [JsonProperty("pivotOffset")]
        public double[] PivotOffset { get; internal set; }

        /// <summary>
        /// 6个
        /// </summary>
        [JsonProperty("mbb")]
        public double[] Mbb { get; internal set; }

        [JsonProperty("layer")]
        public string Layer { get; internal set; }

        [JsonProperty("attributes")]
        public FeatureAttribute Attributes { get; internal set; }

        [JsonProperty("geometries")]
        public Geometry Geometries { get; internal set; }
    }
}