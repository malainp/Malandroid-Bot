using System;
using Newtonsoft.Json;

namespace MalandroidBot.Core
{
    public partial class Comments
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}
