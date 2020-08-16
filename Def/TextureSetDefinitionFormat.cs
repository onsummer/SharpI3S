using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class TextureSetDefinitionFormat
    {
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; internal set; }

        /// <summary>
        /// jpg/png/dds/ktx-etc2
        /// </summary>
        [JsonProperty("format", Required = Required.Always)]
        public string Format { get; internal set; }
    }
}