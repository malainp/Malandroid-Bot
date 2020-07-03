using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MalandroidBot.Core.TravisCI
{
    public partial class Cache
    {
        [JsonProperty("pip")]
        public bool Pip { get; set; }

        [JsonProperty("directories")]
        public List<string> Directories { get; set; }
    }
}
