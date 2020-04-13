using System;
using Newtonsoft.Json;

namespace MalandroidBot.Core
{
    public static class Serialize
    {
        public static string ToJson(this GithubPullRequestReview self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
