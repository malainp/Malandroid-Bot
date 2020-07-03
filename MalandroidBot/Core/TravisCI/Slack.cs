using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MalandroidBot.Core.TravisCI
{
    public partial class Slack
    {
        [JsonProperty("rooms")]
        public List<ApiKey> Rooms { get; set; }

        [JsonProperty("on_success")]
        public string OnSuccess { get; set; }
    }
}
