using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flock.Models
{
    public class ResponseModel
    {
        [JsonProperty("type")]
        public String Type { get; set; }
        [JsonProperty("data")]
        public object Data { get; set; }

        [JsonProperty("message")]
        public String Message { get; set; }
    }
}