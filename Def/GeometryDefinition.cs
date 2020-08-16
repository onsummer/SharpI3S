using Newtonsoft.Json;
using System.Collections.Generic;

namespace SharpI3S.Def
{
    public class GeometryDefinition
    {
        /// <summary>
        /// only triangle
        /// </summary>
        [JsonProperty("topology")]
        public string Topology { get; internal set; }

        /// <summary>
        /// 长度只能是1或2，1只有未压缩的，2代表多了一个draco的数据
        /// </summary>
        [JsonProperty("geometryBuffers", Required = Required.Always)]
        public List<GeometryBuffer> GeometryBuffers { get; internal set; }
    }
}