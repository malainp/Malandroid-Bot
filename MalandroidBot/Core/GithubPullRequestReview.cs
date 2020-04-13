using System;
using Newtonsoft.Json;

namespace MalandroidBot.Core
{
    public partial class GithubPullRequestReview
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("pull_request")]
        public PullRequest PullRequest { get; set; }

        [JsonProperty("repository")]
        public Repo Repository { get; set; }

        [JsonProperty("sender")]
        public Sender Sender { get; set; }
    }

    public partial class GithubPullRequestReview
    {
        public static GithubPullRequestReview FromJson(string json) => JsonConvert.DeserializeObject<GithubPullRequestReview>(json, Converter.Settings);
    }
}
