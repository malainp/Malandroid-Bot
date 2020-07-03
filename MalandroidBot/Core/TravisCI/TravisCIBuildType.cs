using System;
namespace MalandroidBot.Core.TravisCI
{
    public class TravisCIBuildType
    {
        public const string CRON = "cron";
        public const string PULL_REQUEST = "pull_request";
        public const string PUSH = "push";
        public const string API = "api";
    }
}
