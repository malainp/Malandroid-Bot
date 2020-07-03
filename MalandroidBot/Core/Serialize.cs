using System;
using MalandroidBot.Core.GitComments;
using MalandroidBot.Core.TravisCI;
using Newtonsoft.Json;

namespace MalandroidBot.Core
{
    public static class Serialize
    {
        public static string ToJson(this GithubPullRequestReview self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this GithubPullRequestComment self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this TravisCiWebhook self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
