using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Newtonsoft.Json;

namespace MattermostHookServerTemplate.Models
{

    public class MattermostField
    {
        public MattermostField()
        {
            this.isShort = false;
            this.title = "";
            this.value = "";
        }

        [JsonProperty(PropertyName = "short")]
        public bool isShort { get; set; }

        public string title { get; set; }

        public string value { get; set; }
    }
}