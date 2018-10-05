using Newtonsoft.Json;
using System;

namespace Vainglory_CSharp.Model.Status
{
    public class StatusAttributes
    {
        [JsonProperty("releasedAt")]
        public DateTimeOffset ReleasedAt { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}