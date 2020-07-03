using System;
using Newtonsoft.Json;

namespace MalandroidBot.Core.TravisCI
{
    public partial class Repository
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner_name")]
        public string OwnerName { get; set; }

        [JsonProperty("url")]
        public object Url { get; set; }
    }
}
