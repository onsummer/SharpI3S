using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SharpI3S.Def
{
    public class DrawingInfo
    {
        [JsonProperty("renderer", Required = Required.Always)]
        public JObject Renderer { get; internal set; }

        [JsonProperty("scaleSymbols")]
        public bool ScaleSymbols { get; internal set; }
    }
}