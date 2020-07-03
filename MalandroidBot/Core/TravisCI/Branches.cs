using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MalandroidBot.Core.TravisCI
{
    public partial class Branches
    {
        [JsonProperty("only")]
        public List<string> Only { get; set; }
    }
}
