using System;
using Newtonsoft.Json;

namespace MalandroidBot.Core.GitComments
{
    public partial class Html
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}
