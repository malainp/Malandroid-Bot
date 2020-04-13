using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MalandroidBot.Core
{
    public partial class PullRequest
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("diff_url")]
        public Uri DiffUrl { get; set; }

        [JsonProperty("patch_url")]
        public Uri PatchUrl { get; set; }

        [JsonProperty("issue_url")]
        public Uri IssueUrl { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("user")]
        public Sender User { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("closed_at")]
        public object ClosedAt { get; set; }

        [JsonProperty("merged_at")]
        public object MergedAt { get; set; }

        [JsonProperty("merge_commit_sha")]
        public object MergeCommitSha { get; set; }

        [JsonProperty("assignee")]
        public object Assignee { get; set; }

        [JsonProperty("assignees")]
        public List<object> Assignees { get; set; }

        [JsonProperty("requested_reviewers")]
        public List<object> RequestedReviewers { get; set; }

        [JsonProperty("requested_teams")]
        public List<object> RequestedTeams { get; set; }

        [JsonProperty("labels")]
        public List<object> Labels { get; set; }

        [JsonProperty("milestone")]
        public object Milestone { get; set; }

        [JsonProperty("commits_url")]
        public Uri CommitsUrl { get; set; }

        [JsonProperty("review_comments_url")]
        public Uri ReviewCommentsUrl { get; set; }

        [JsonProperty("review_comment_url")]
        public string ReviewCommentUrl { get; set; }

        [JsonProperty("comments_url")]
        public Uri CommentsUrl { get; set; }

        [JsonProperty("statuses_url")]
        public Uri StatusesUrl { get; set; }

        [JsonProperty("head")]
        public Base Head { get; set; }

        [JsonProperty("base")]
        public Base Base { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("author_association")]
        public string AuthorAssociation { get; set; }

        [JsonProperty("draft")]
        public bool Draft { get; set; }

        [JsonProperty("merged")]
        public bool Merged { get; set; }

        [JsonProperty("mergeable")]
        public object Mergeable { get; set; }

        [JsonProperty("rebaseable")]
        public object Rebaseable { get; set; }

        [JsonProperty("mergeable_state")]
        public string MergeableState { get; set; }

        [JsonProperty("merged_by")]
        public object MergedBy { get; set; }

        [JsonProperty("comments")]
        public long Comments { get; set; }

        [JsonProperty("review_comments")]
        public long ReviewComments { get; set; }

        [JsonProperty("maintainer_can_modify")]
        public bool MaintainerCanModify { get; set; }

        [JsonProperty("commits")]
        public long Commits { get; set; }

        [JsonProperty("additions")]
        public long Additions { get; set; }

        [JsonProperty("deletions")]
        public long Deletions { get; set; }

        [JsonProperty("changed_files")]
        public long ChangedFiles { get; set; }
    }
}
