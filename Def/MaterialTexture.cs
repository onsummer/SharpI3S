using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class MaterialTexture
    {
        [JsonProperty("textureSetDefinitionId", Required = Required.Always)]
        public int TextureSetDefinitionID { get; internal set; }

        /// <summary>
        /// default 0
        /// </summary>
        [JsonProperty("texCoord")]
        public int TexCoord { get; internal set; }

        /// <summary>
        /// default 1
        /// </summary>
        [JsonProperty("factor")]
        public int Factor { get; internal set; }
    }
}