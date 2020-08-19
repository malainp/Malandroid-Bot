using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using MalandroidBot.Core.TravisCI;
using MalandroidBot.Core;
using SlackBotMessages;
using SlackBotMessages.Models;
using System.Net;

namespace MalandroidBot.Functions
{
    public class OnTravisCIBuildFinished
    {
        [FunctionName("OnTravisCIBuildFinished")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            requestBody = WebUtility.UrlDecode(requestBody.Replace("payload=", ""));
            TravisCiWebhook? data;
            try
            {
                data = JsonConvert.DeserializeObject<TravisCiWebhook>(requestBody);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult("Strike!");
            }

            SendMessage(data);

            return new OkObjectResult(data);
        }
        public static void SendMessage(TravisCiWebhook build)
        {
            var buildStatus = "👷🏼‍♂️🛠" + (build.Status == TravisCIBuildStatus.SUCCESS ? "✅" : "❌");
            string color = build.Status == TravisCIBuildStatus.SUCCESS ? Consts.GREEN : Consts.RED;
            string buildType = "";
            string prnumber = "";
            switch (build.Type)
            {
                case TravisCIBuildType.API:
                    buildType = "api";
                    break;
                case TravisCIBuildType.CRON:
                    buildType = "cron";
                    break;
                case TravisCIBuildType.PULL_REQUEST:
                    buildType = "pull request";
                    prnumber = $" (#{build.PullRequestNumber})";
                    break;
                case TravisCIBuildType.PUSH:
                    buildType = "push";
                    break;
            }

            var WebHookUrl = Consts.SLACK_HOOK_URL;
            var client = new SbmClient(WebHookUrl);
            var message = new Message($"<!here> {buildStatus}  {build.AuthorName}'s <{build.BuildUrl}|{buildType}{prnumber}> {build.ResultMessage.ToLower()} ");

            message.AddAttachment(new Attachment()
                .SetColor(color)
                .AddField("Started at", build.StartedAt.UtcDateTime.ToString(), true)
                .AddField("Total build time", $"{build.Duration} seconds", true)
                .AddField("Build number", build.Number, true)
                .AddField("Compare", $"<{build.CompareUrl}|{build.Commit.Substring(0, 7)}>", true)
                );

            client.Send(message);
        }
    }
}
