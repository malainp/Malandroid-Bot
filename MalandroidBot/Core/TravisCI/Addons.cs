using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MalandroidBot.Core.TravisCI
{
    public partial class Addons
    {
        [JsonProperty("deploy")]
        public List<Deploy> Deploy { get; set; }
    }
}
