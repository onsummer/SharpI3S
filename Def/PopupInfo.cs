using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SharpI3S.Def
{
    public class PopupInfo
    {
        [JsonProperty("title")]
        public string Title { get; internal set; }

        [JsonProperty("description")]
        public string Description { get; internal set; }

        [JsonProperty("expressionInfos")]
        public JArray ExpressionInfos { get; internal set; }

        [JsonProperty("fieldInfos")]
        public JArray FieldInfos { get; internal set; }

        [JsonProperty("mediaInfos")]
        public JArray MediaInfos { get; internal set; }

        [JsonProperty("popupElements")]
        public JArray PopupElements { get; internal set; }
    }
}