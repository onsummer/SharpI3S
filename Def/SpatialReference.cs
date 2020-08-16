using Newtonsoft.Json;

namespace SharpI3S.Def
{
    public class SpatialReference
    {
        [JsonProperty("wkt")]
        public string WKT { get; internal set; }

        [JsonProperty("wkid")]
        public int WKID { get; internal set; }

        [JsonProperty("vcsWkid")]
        public int VcsWKID { get; internal set; }

        [JsonProperty("latestWkid")]
        public int LatestWKID { get; internal set; }

        [JsonProperty("latestVcsWkid")]
        public int LatestVcsWKID { get; internal set; }
    }
}