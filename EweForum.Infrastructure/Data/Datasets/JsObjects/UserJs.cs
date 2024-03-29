using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Infrastructure.Data.Datasets.JsObjects
{
    public class UserJs
    {
        [JsonProperty("username")]
        public string Username { get; set; } = string.Empty;
        [JsonProperty("password")]
        public string Password { get; set; } = string.Empty;

        [JsonProperty("email")]
        public string Email { get; set; } = string.Empty;

        [JsonProperty("personalInfo")] 
        public string PersonalInfo { get;set; } = string.Empty;

        [JsonProperty("countryId")]
        public string CountryId { get; set; } = string.Empty;

        [JsonProperty("joinedTopics")]
        public int[] JoinedTopics { get; set;} = new int[0];
       

    }
}
