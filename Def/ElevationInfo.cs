using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class ElevationInfo
    {
        /// <summary>
        /// relativeToGround/absoluteHeight/onTheGround/relativeToScene
        /// </summary>
        [JsonProperty("mode")]
        public string Mode { get; internal set; }

        [JsonProperty("offset")]
        public double Offset { get; internal set; }
        
        [JsonProperty("unit")]
        public string Unit { get; internal set; }
    }
}