using System;
using Newtonsoft.Json;

namespace MalandroidBot.Core.GitComments
{
    public partial class GithubPullRequestComment
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("comment")]
        public Comment Comment { get; set; }

        [JsonProperty("pull_request")]
        public PullRequest PullRequest { get; set; }

        [JsonProperty("repository")]
        public Repo Repository { get; set; }

        [JsonProperty("organization")]
        public Organization Organization { get; set; }

        [JsonProperty("sender")]
        public Sender Sender { get; set; }
    }

    public partial class GithubPullRequestComment
    {
        public static GithubPullRequestComment FromJson(string json) => JsonConvert.DeserializeObject<GithubPullRequestComment>(json, Converter.Settings);
    }
}
