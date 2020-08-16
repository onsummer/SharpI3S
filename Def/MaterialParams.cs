using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class MaterialParams
    {
        [JsonProperty("transparency")]
        public double Transparency { get; internal set; }

        [JsonProperty("reflectivity")]
        public double Reflectivity { get; internal set; }

        [JsonProperty("shininess")]
        public double Shininess { get; internal set; }

        [JsonProperty("ambient")]
        public double[] Ambient { get; internal set; }

        [JsonProperty("diffuse")]
        public double[] Diffuse { get; internal set; }

        [JsonProperty("specular")]
        public double[] Specular { get; internal set; }

        /// <summary>
        /// textured/solid/untextured/wireframe
        /// </summary>
        [JsonProperty("renderMode", Required = Required.Always)]
        public string RenderMode { get; internal set; }

        [JsonProperty("castShadows")]
        public bool CastShadows { get; internal set; }

        [JsonProperty("receiveShadows")]
        public bool ReceiveShadows { get; internal set; }

        [JsonProperty("cullFace")]
        public string CullFace { get; internal set; }

        [JsonProperty("vertexColors")]
        public bool VertexColors { get; internal set; }

        [JsonProperty("vertexRegions")]
        public bool VertexRegions { get; internal set; }

        [JsonProperty("useVertexColorAlpha")]
        public bool UseVertexColorAlpha { get; internal set; }
    }
}  