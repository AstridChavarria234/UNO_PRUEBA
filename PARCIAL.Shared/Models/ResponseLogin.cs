using Newtonsoft.Json;
using PARCIAL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PARCIAL.Models
{
    public class ResponseLogin
    {

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("expiration")]
        public DateTimeOffset Expiration { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }
}
