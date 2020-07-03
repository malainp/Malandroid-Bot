using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MalandroidBot.Core.TravisCI
{
    public partial class TravisCiWebhook
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("config")]
        public TravisCiWebhookConfig Config { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("result")]
        public long Result { get; set; }

        [JsonProperty("status_message")]
        public string StatusMessage { get; set; }

        [JsonProperty("result_message")]
        public string ResultMessage { get; set; }

        [JsonProperty("started_at")]
        public DateTimeOffset StartedAt { get; set; }

        [JsonProperty("finished_at")]
        public DateTimeOffset FinishedAt { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("build_url")]
        public Uri BuildUrl { get; set; }

        [JsonProperty("commit_id")]
        public long CommitId { get; set; }

        [JsonProperty("commit")]
        public string Commit { get; set; }

        [JsonProperty("base_commit")]
        public object BaseCommit { get; set; }

        [JsonProperty("head_commit")]
        public object HeadCommit { get; set; }

        [JsonProperty("branch")]
        public string Branch { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("compare_url")]
        public Uri CompareUrl { get; set; }

        [JsonProperty("committed_at")]
        public DateTimeOffset CommittedAt { get; set; }

        [JsonProperty("author_name")]
        public string AuthorName { get; set; }

        [JsonProperty("author_email")]
        public string AuthorEmail { get; set; }

        [JsonProperty("committer_name")]
        public string CommitterName { get; set; }

        [JsonProperty("committer_email")]
        public string CommitterEmail { get; set; }

        [JsonProperty("pull_request")]
        public bool PullRequest { get; set; }

        [JsonProperty("pull_request_number")]
        public object PullRequestNumber { get; set; }

        [JsonProperty("pull_request_title")]
        public object PullRequestTitle { get; set; }

        [JsonProperty("tag")]
        public object Tag { get; set; }

        [JsonProperty("repository")]
        public Repository Repository { get; set; }

        [JsonProperty("matrix")]
        public List<Matrix> Matrix { get; set; }
    }
}
