using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpI3S.Def.NodePageDef
{
    public class NodePage
    {
        [JsonProperty("nodes")]
        public List<Node> Nodes { get; internal set; }
    }
}
