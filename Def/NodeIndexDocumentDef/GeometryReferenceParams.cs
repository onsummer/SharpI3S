using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpI3S.Def.NodeIndexDocumentDef
{
    public class GeometryReferenceParams : GeometryParams
    {
        [JsonProperty("href", Required = Required.Always)]
        public string Href { get; internal set; }

        [JsonProperty("type")]
        public string Type { get; internal set; }

        [JsonProperty("faceRange")]
        public int[] FaceRange { get; internal set; }

        [JsonProperty("lodGeometry")]
        public bool LodGeometry { get; internal set; }
    }
}
