using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class HeightModelInfo
    {
        [JsonProperty("heightModel")]
        public string HeightModel { get; internal set; }

        [JsonProperty("vertCRS")]
        public string VertCRS { get; internal set; }

        /// <summary>
        /// 允许值：meter/us-foot/foot/clarke-foot/clarke-yard/clarke-link
        /// sears-yard/sears-foot/sears-chain/benoit-1895-b-chain
        /// indian-1937-yard/gold-coast-foot/sears-1922-truncated-chain/
        /// us-inch/us-yard/millimeter/decimeter/centimeter/kilometer
        /// </summary>
        [JsonProperty("heightUnit")]
        public string HeightUnit { get; internal set; }
    }
}