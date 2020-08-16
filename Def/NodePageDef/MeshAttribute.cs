using Newtonsoft.Json;

namespace SharpI3S.Def.NodePageDef
{
    public class MeshAttribute
    {
        [JsonProperty("resource", Required = Required.Always)]
        public int Resource { get; internal set; }
    }
}