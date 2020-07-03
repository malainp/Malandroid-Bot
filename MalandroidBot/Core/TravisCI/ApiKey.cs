using System;
using Newtonsoft.Json;

namespace MalandroidBot.Core.TravisCI
{
    public partial class ApiKey
    {
        [JsonProperty("secure")]
        public string Secure { get; set; }
    }
}
