using Newtonsoft.Json;

namespace SharpI3S.Def.NodeIndexDocumentDef
{
    public class LodSelection
    {
        /// <summary>
        /// maxScreenThreshold/maxScreenThresholdSQ/screenSpaceRelative
        /// distanceRangeFromDefaultCamera/effectiveDensity
        /// </summary>
        [JsonProperty("metricType", Required = Required.Always)]
        public string MetricType { get; internal set; }

        [JsonProperty("maxError", Required = Required.Always)]
        public double MaxError { get; internal set; }
    }
}