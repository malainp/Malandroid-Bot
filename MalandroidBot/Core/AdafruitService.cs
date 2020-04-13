using System;
using System.Threading.Tasks;
using Refit;

namespace MalandroidBot.Core
{
    public interface AdafruitService
    {
        [Post("/feed/FEED_ID")]
        Task<String> SendHook([Body] AdafruitData value);
    }
}
