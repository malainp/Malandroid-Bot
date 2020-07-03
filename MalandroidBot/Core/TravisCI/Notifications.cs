using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MalandroidBot.Core.TravisCI
{
    public partial class Notifications
    {
        [JsonProperty("slack")]
        public List<Slack> Slack { get; set; }

        [JsonProperty("webhooks")]
        public List<Webhook> Webhooks { get; set; }
    }
}
