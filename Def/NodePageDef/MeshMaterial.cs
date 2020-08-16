using Newtonsoft.Json;

namespace SharpI3S.Def.NodePageDef
{
    public class MeshMaterial
    {
        [JsonProperty("definition",Required = Required.Always)]
        public int Definition { get; internal set; }

        [JsonProperty("resource")]
        public int Resource { get; internal set; }

        [JsonProperty("texelCountHint")]
        public int TexelCountHint { get; internal set; }
    }
}