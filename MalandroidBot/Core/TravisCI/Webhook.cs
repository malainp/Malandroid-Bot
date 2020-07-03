using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MalandroidBot.Core.TravisCI
{
    public partial class Webhook
    {
        [JsonProperty("urls")]
        public List<Uri> Urls { get; set; }
    }
}
