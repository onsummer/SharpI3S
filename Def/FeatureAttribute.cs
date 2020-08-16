using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SharpI3S.Def
{
    public class FeatureAttribute
    {
        [JsonProperty("id")]
        public Value ID { get; internal set; }

        [JsonProperty("faceRange")]
        public Value FaceRange { get; internal set; }
    }
}