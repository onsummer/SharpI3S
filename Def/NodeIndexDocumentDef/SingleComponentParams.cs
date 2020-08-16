using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpI3S.Def.NodeIndexDocumentDef
{
    public class SingleComponentParams : GeometryParams
    {
        [JsonProperty("id", Required = Required.Always)]
        public int ID { get; internal set; }

        [JsonProperty("materialID", Required = Required.Always)]
        public int MaterialID { get; internal set; }

        [JsonProperty("material")]
        public string Material { get; internal set; }

        [JsonProperty("texture")]
        public string Texture { get; internal set; }

        [JsonProperty("textureID")]
        public int[] TextureID { get; internal set; }

        [JsonProperty("regionID")]
        public int[] RegionID { get; internal set; }
    }
}
