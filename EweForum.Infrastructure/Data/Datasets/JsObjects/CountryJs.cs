using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Infrastructure.Data.Datasets.JsObjects
{
    public class CountryJs
    {
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;


        [JsonProperty("code")]
        public string Code{ get; set; } = string.Empty;

    }
}
