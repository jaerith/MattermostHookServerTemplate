namespace MattermostHookServerTemplate.Models
{
    public class MattermostAttachment
    {
        public MattermostAttachment()
        {
            fallback = color = "";
            pretext  = text  = "";

            author_name = author_icon = author_link = "";

            title = title_link = "";

            fields = null;

            image_url = "";
        }

        public string fallback { get; set; }

        public string color { get; set; }

        public string pretext { get; set; }

        public string text { get; set; }

        public string author_name { get; set; }

        public string author_icon { get; set; }

        public string author_link { get; set; }

        public string title { get; set; }

        public string title_link { get; set; }

        public MattermostField[] fields { get; set; }

        public string image_url { get; set; }
    }
}