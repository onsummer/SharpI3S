using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class MaterialDefinition
    {
        [JsonProperty("pbrMetallicRoughness")]
        public PbrMetallicRoughness PbrMetallicRoughness { get; internal set; }

        [JsonProperty("normalTexture")]
        public MaterialTexture NormalTexture { get; internal set; }

        [JsonProperty("occlusionTexture")]
        public MaterialTexture OcclusionTexture { get; internal set; }

        [JsonProperty("emissiveTexture")]
        public MaterialTexture EmissiveTexture { get; internal set; }

        [JsonProperty("emissiveFactor")]
        public double[] EmissiveFactor { get; internal set; }
        
        /// <summary>
        /// opaque/mask/blend
        /// </summary>
        [JsonProperty("alphaMode")]
        public string AlphaMode { get; internal set; }

        /// <summary>
        /// 0.25
        /// </summary>
        [JsonProperty("alphaCutOff")]
        public double AlphaCutOff { get; internal set; }

        /// <summary>
        /// false
        /// </summary>
        [JsonProperty("doubleSided")]
        public bool DoubleSided { get; internal set; }


        /// <summary>
        /// none/front/back
        /// </summary>
        [JsonProperty("cullFace")]
        public string CullFace { get; internal set; }

    }
}