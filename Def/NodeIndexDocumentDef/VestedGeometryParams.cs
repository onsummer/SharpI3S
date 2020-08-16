using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpI3S.Def.NodeIndexDocumentDef
{
    public class VestedGeometryParams : GeometryParams
    {
        [JsonProperty("type")]
        public string Type { get; internal set; }

        /// <summary>
        /// PerAttributeArray/InterleavedArray/Indexed
        /// </summary>
        [JsonProperty("topology")]
        public string Topology { get; internal set; }

        [JsonProperty("vertexAttributes")]
        public VertexAttribute VertexAttributes { get; internal set; }

        [JsonProperty("faces")]
        public GeometryAttribute Faces { get; internal set; }
    }
}
