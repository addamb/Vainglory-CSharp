using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vainglory_CSharp.Model.Status
{
    public class Status
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public StatusAttributes Attributes { get; set; }
    }
}
