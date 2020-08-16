using Newtonsoft.Json;

namespace SharpI3S.Def.NodePageDef
{
    public class Mesh
    {
        [JsonProperty("material")]
        public MeshMaterial Material { get; internal set; }

        [JsonProperty("geometry")]
        public MeshGeometry Geometry { get; internal set; }
        [JsonProperty("attribute")]
        public MeshAttribute Attribute { get; internal set; }
    }
}