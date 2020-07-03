using System;
using Newtonsoft.Json;

namespace MalandroidBot.Core.TravisCI
{
    public partial class Matrix
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("repository_id")]
        public long RepositoryId { get; set; }

        [JsonProperty("parent_id")]
        public long ParentId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("config")]
        public MatrixConfig Config { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("result")]
        public long Result { get; set; }

        [JsonProperty("commit")]
        public string Commit { get; set; }

        [JsonProperty("branch")]
        public string Branch { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("compare_url")]
        public Uri CompareUrl { get; set; }

        [JsonProperty("started_at")]
        public DateTimeOffset StartedAt { get; set; }

        [JsonProperty("finished_at")]
        public DateTimeOffset FinishedAt { get; set; }

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

        [JsonProperty("allow_failure")]
        public object AllowFailure { get; set; }
    }
}
