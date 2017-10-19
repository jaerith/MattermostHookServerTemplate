using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MattermostHookServerTemplate.Models
{
    public class MattermostReturnPayload
    {
        public MattermostReturnPayload()
        {
            response_type = "in_channel";
            text          = "";
            username      = "robot";
            icon_url      = "https://www.mattermost.org/wp-content/uploads/2016/04/icon.png";
            attachments   = null;
        }

        public string response_type { get; set; }

        public string text { get; set; }

        public string username { get; set; }

        public string icon_url { get; set; }

        public MattermostAttachment[] attachments { get; set; }
    }
}