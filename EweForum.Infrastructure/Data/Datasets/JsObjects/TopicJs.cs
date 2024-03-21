using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Infrastructure.Data.Datasets.JsObjects
{
    public class TopicJs
    {
        [JsonProperty("title")]
        public string Title { get; set; } = string.Empty;

        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

    }
}
