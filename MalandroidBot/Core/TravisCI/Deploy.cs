using System;
using Newtonsoft.Json;

namespace MalandroidBot.Core.TravisCI
{
    public partial class Deploy
    {
        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("strategy")]
        public string Strategy { get; set; }

        [JsonProperty("api_key")]
        public ApiKey ApiKey { get; set; }

        [JsonProperty("app")]
        public string App { get; set; }

        [JsonProperty("skip_cleanup")]
        public bool SkipCleanup { get; set; }

        [JsonProperty("on")]
        public On On { get; set; }
    }

}
