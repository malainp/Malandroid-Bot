using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MalandroidBot.Core.TravisCI
{
    public partial class TravisCiWebhookConfig
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("os")]
        public List<string> Os { get; set; }

        [JsonProperty("dist")]
        public string Dist { get; set; }

        [JsonProperty("sudo")]
        public bool Sudo { get; set; }

        [JsonProperty("python")]
        public List<string> Python { get; set; }

        [JsonProperty("branches")]
        public Branches Branches { get; set; }

        [JsonProperty("env")]
        public List<string> Env { get; set; }

        [JsonProperty("cache")]
        public Cache Cache { get; set; }

        [JsonProperty("deploy")]
        public List<Deploy> Deploy { get; set; }

        [JsonProperty("notifications")]
        public Notifications Notifications { get; set; }

        [JsonProperty("install")]
        public List<string> Install { get; set; }

        [JsonProperty("script")]
        public List<string> Script { get; set; }
    }
}
