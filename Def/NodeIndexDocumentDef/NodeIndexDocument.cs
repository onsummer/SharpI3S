using Newtonsoft.Json;
using SharpI3S.Def.NodePageDef;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpI3S.Def.NodeIndexDocumentDef
{
    public class NodeIndexDocument
    {
        [JsonProperty("id", Required = Required.Always)]
        public string ID { get; internal set; }

        [JsonProperty("level")]
        public int Level { get; internal set; }

        [JsonProperty("version")]
        public string Version { get; internal set; }

        [JsonProperty("mbs")]
        public double[] MBS { get; internal set; }

        [JsonProperty("obb")]
        public Obb Obb { get; internal set; }

        [JsonProperty("created")]
        public string Created { get; internal set; }

        [JsonProperty("expires")]
        public string Expires { get; internal set; }

        [JsonProperty("transform")]
        public double[] Transform { get; internal set; }

        [JsonProperty("parentNode")]
        public NodeReference ParentNode { get; internal set; }

        [JsonProperty("children")]
        public List<NodeReference> Children { get; internal set; }

        [JsonProperty("neighbors")]
        public List<NodeReference> Neighbors { get; internal set; }

        [JsonProperty("sharedResource")]
        public Resource SharedResource { get; internal set; }

        [JsonProperty("featureData")]
        public List<Resource> FeatureData { get; internal set; }

        [JsonProperty("geometryData")]
        public List<Resource> GeometryData { get; internal set; }

        [JsonProperty("textureData")]
        public List<Resource> TextureData { get; internal set; }

        [JsonProperty("attributeData")]
        public List<Resource> AttributeData { get; internal set; }

        [JsonProperty("lodSelection")]
        public List<LodSelection> LodSelection { get; internal set; }

        [JsonProperty("features")]
        public List<Features> Features { get; internal set; }
    }
}
