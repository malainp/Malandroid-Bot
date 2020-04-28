using System;
using Newtonsoft.Json;

namespace MalandroidBot.Core.GitComments
{
    public partial class Comment
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("pull_request_review_id")]
        public long PullRequestReviewId { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("diff_hunk")]
        public string DiffHunk { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("original_position")]
        public long OriginalPosition { get; set; }

        [JsonProperty("commit_id")]
        public string CommitId { get; set; }

        [JsonProperty("original_commit_id")]
        public string OriginalCommitId { get; set; }

        [JsonProperty("user")]
        public Sender User { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("pull_request_url")]
        public Uri PullRequestUrl { get; set; }

        [JsonProperty("author_association")]
        public string AuthorAssociation { get; set; }

        [JsonProperty("_links")]
        public CommentLinks Links { get; set; }

        [JsonProperty("start_line")]
        public object StartLine { get; set; }

        [JsonProperty("original_start_line")]
        public object OriginalStartLine { get; set; }

        [JsonProperty("start_side")]
        public object StartSide { get; set; }

        [JsonProperty("line")]
        public long Line { get; set; }

        [JsonProperty("original_line")]
        public long OriginalLine { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }

        [JsonProperty("in_reply_to_id")]
        public long InReplyToId { get; set; }
    }
}
