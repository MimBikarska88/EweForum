using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Infrastructure.Data.Datasets.JsObjects
{
    public class UserJoinTopicJs
    {
        [JsonProperty("userId")]
        public string ForumUserId { get; set; } = string.Empty;

        [JsonProperty("topicsIds")]
        public List<int> TopicsIds = new List<int>();
    }
}
