﻿using System;
using Newtonsoft.Json;

namespace MalandroidBot.Core.GitComments
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
        public string MergeCommitSha { get; set; }

        [JsonProperty("assignee")]
        public object Assignee { get; set; }

        [JsonProperty("assignees")]
        public object[] Assignees { get; set; }

        [JsonProperty("requested_reviewers")]
        public Sender[] RequestedReviewers { get; set; }

        [JsonProperty("requested_teams")]
        public object[] RequestedTeams { get; set; }

        [JsonProperty("labels")]
        public object[] Labels { get; set; }

        [JsonProperty("milestone")]
        public object Milestone { get; set; }

        [JsonProperty("draft")]
        public bool Draft { get; set; }

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
        public PullRequestLinks Links { get; set; }

        [JsonProperty("author_association")]
        public string AuthorAssociation { get; set; }
    }
}
