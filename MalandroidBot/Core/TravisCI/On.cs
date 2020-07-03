using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MalandroidBot.Core.TravisCI
{
    public partial class On
    {
        [JsonProperty("branch")]
        public List<string> Branch { get; set; }
    }
}
