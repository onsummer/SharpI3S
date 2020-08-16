using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class PbrMetallicRoughness
    {
        /// <summary>
        /// 1,1,1,1
        /// </summary>
        [JsonProperty("baseColorFactor")]
        public double[] BaseColorFactor { get; internal set; }

        [JsonProperty("baseColorTexture")]
        public MaterialTexture BaseColorTexture { get; internal set; }

        [JsonProperty("metallicFactor")]
        public double MetallicFactor { get; internal set; }

        [JsonProperty("roughnessFactor")]
        public double RoughnessFactor { get; internal set; }

        [JsonProperty("metallicRoughnessTexture")]
        public MaterialTexture MetallicRoughnessTexture { get; internal set; }
    }
}