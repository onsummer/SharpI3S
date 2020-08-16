using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class TextureSetDefinition
    {
        [JsonProperty("formats", Required = Required.Always)]
        public TextureSetDefinitionFormat Formats { get; internal set; }

        [JsonProperty("atlas")]
        public bool Altas { get; internal set; }
    }
}