using System;
namespace MalandroidBot.Core
{
    public class PullRequestAction
    {
        public const string Assigned = "assigned";
        public const string Unassigned = "unassigned";
        public const string ReviewRequested = "review_requested";
        public const string ReviewRequestRemoved = "review_request_removed";
        public const string Labeled = "labeled";
        public const string Unlabeled = "unlabeled";
        public const string Opened = "opened";
        public const string Edited = "edited";
        public const string Closed = "closed";
        public const string ReadyForReview = "ready_for_review";
        public const string Locked = "locked";
        public const string Unlocked = "unlocked";
        public const string Reopened = "reopened";
    }
}
