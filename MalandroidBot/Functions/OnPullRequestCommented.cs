using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using MalandroidBot.Core.GitComments;
using SlackBotMessages;
using SlackBotMessages.Models;
using MalandroidBot.Core;

namespace MalandroidBot.Functions
{
    public class OnPullRequestCommented
    {
        [FunctionName("OnPullRequestCommented")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            GithubPullRequestComment? data;
            try
            {
                data = JsonConvert.DeserializeObject<GithubPullRequestComment>(requestBody);
            }
            catch (Exception)
            {
                return new BadRequestObjectResult("Strike!");
            }
            SendMessage(data);
            return new OkObjectResult("OK");
        }

        public static void SendMessage(GithubPullRequestComment comment)
        {
            var webhookUrl = Consts.SLACK_HOOK_URL;
            var client = new SbmClient(webhookUrl);

            var message = new Message($"<!here> <{comment.Comment.User.HtmlUrl}|{comment.Comment.User.Login}> commented on <{comment.PullRequest.HtmlUrl}|{comment.PullRequest.Title}>");

            message.AddAttachment(new Attachment()
                .SetPretext($">{comment.Comment.Body}\n\n```{comment.Comment.DiffHunk}```")
                .SetFooter(comment.Comment.Path, comment.Comment.User.AvatarUrl.ToString(), comment.Comment.CreatedAt.UtcDateTime)
            );
            

            client.Send(message);
        }
    }
}
