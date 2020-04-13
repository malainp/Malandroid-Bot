using System;
using Newtonsoft.Json;

namespace MalandroidBot.Core
{
    public class AdafruitData
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
