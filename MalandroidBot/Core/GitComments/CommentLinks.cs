using System;
using Newtonsoft.Json;

namespace MalandroidBot.Core.GitComments
{
    public partial class CommentLinks
    {
        [JsonProperty("self")]
        public Html Self { get; set; }

        [JsonProperty("html")]
        public Html Html { get; set; }

        [JsonProperty("pull_request")]
        public Html PullRequest { get; set; }
    }
}
