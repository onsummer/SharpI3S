using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class GeometryBuffer
    {
        /// <summary>
        /// default 0
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; internal set; }

        [JsonProperty("position")]
        public GeometryPosition Position { get; internal set; } 

        [JsonProperty("normal")]
        public GeometryNormal Normal { get; internal set; }

        [JsonProperty("uv0")]
        public GeometryUV UV0 { get; internal set; }

        [JsonProperty("color")]
        public GeometryColor Color { get; internal set; }

        [JsonProperty("uvRegion")]
        public GeometryUVRegion UVRegion { get; internal set; }

        [JsonProperty("featureId")]
        public GeometryFeatureID FeatureID { get; internal set; }

        [JsonProperty("faceRange")]
        public GeometryFaceRange FaceRange { get; internal set; }

        [JsonProperty("compressedAttributes")]
        public CompressedAttributes CompressedAttributes { get; internal set; }
    }
}