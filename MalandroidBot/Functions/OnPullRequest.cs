using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using MalandroidBot.Core;
using Refit;
using SlackBotMessages;
using SlackBotMessages.Models;

namespace MalandroidBot.Functions
{
    public static class OnPullRequest
    {
        [FunctionName("OnPullRequest")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            GithubPullRequestReview? data;
            try
            {
                data = JsonConvert.DeserializeObject<GithubPullRequestReview>(requestBody);
            }
            catch (Exception)
            {
                return new BadRequestObjectResult("Strike!");
            }

            var adafruitResponse = await SendAdafruitData(data.Action);

            if (data.Action == PullRequestAction.Opened
                || data.Action == PullRequestAction.Reopened
                || data.Action == PullRequestAction.Edited
                || data.Action == PullRequestAction.Closed)
                SendMessage(data);
            return new OkObjectResult(adafruitResponse);
        }

        static async Task<string> SendAdafruitData(string action)
        {
            var api = RestService.For<AdafruitService>(Consts.ADAFRUIT_HOOK_URL);
            var adaValue = new AdafruitData();
            switch (action)
            {
                case PullRequestAction.Closed:
                    adaValue.Value = 0;
                    break;

                default:
                    adaValue.Value = 100;
                    break;
            }

            return await api.SendHook(adaValue);
        }

        public static void SendMessage(GithubPullRequestReview pr)
        {
            var WebHookUrl = Consts.SLACK_HOOK_URL;
            var client = new SbmClient(WebHookUrl);
            var message = new Message($"<!here> {pr.Sender.Login} {pr.Action} a Pull request on {pr.Repository.Name}");
            string color;
            switch (pr.Action)
            {
                case PullRequestAction.Closed:
                    color = Consts.CLOSED_COLOR;
                    break;
                case PullRequestAction.Edited:
                    color = Consts.EDITED_COLOR;
                    break;
                default:
                    color = Consts.OPENED_COLOR;
                    break;
            }

            message.AddAttachment(new Attachment()

                .AddField("Pull request info", $"<{pr.PullRequest.HtmlUrl}|{pr.PullRequest.Title} (#{pr.Number})>")
                .AddField("Description", pr.PullRequest.Body)
                .AddField("Commits", pr.PullRequest.Commits.ToString(), true)
                .AddField("Changed files", pr.PullRequest.ChangedFiles.ToString(), true)
                .AddField("User", $"<{pr.Sender.HtmlUrl.ToString()}|{pr.Sender.Login}>", true)
                .SetThumbUrl(pr.PullRequest.User.AvatarUrl.ToString())
                .SetColor(color)
            );

            client.Send(message);
        }


    }
}
