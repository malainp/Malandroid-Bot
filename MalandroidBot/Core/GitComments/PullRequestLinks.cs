using System;
using Newtonsoft.Json;

namespace MalandroidBot.Core.GitComments
{
    public partial class PullRequestLinks
    {
        [JsonProperty("self")]
        public Html Self { get; set; }

        [JsonProperty("html")]
        public Html Html { get; set; }

        [JsonProperty("issue")]
        public Html Issue { get; set; }

        [JsonProperty("comments")]
        public Html Comments { get; set; }

        [JsonProperty("review_comments")]
        public Html ReviewComments { get; set; }

        [JsonProperty("review_comment")]
        public Html ReviewComment { get; set; }

        [JsonProperty("commits")]
        public Html Commits { get; set; }

        [JsonProperty("statuses")]
        public Html Statuses { get; set; }
    }
}
