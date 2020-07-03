using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MalandroidBot.Core.TravisCI
{
    public partial class MatrixConfig
    {
        [JsonProperty("os")]
        public string Os { get; set; }

        [JsonProperty("python")]
        public string Python { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("dist")]
        public string Dist { get; set; }

        [JsonProperty("sudo")]
        public bool Sudo { get; set; }

        [JsonProperty("branches")]
        public Branches Branches { get; set; }

        [JsonProperty("cache")]
        public Cache Cache { get; set; }

        [JsonProperty("install")]
        public List<string> Install { get; set; }

        [JsonProperty("script")]
        public List<string> Script { get; set; }

        [JsonProperty("env")]
        public List<string> Env { get; set; }

        [JsonProperty("addons")]
        public Addons Addons { get; set; }
    }
}
