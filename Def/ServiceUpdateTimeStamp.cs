using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class ServiceUpdateTimeStamp
    {
        [JsonProperty("lastUpdate")]
        public double LateUpdate { get; internal set; }
    }
}