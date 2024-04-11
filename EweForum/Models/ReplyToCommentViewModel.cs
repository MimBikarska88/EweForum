namespace EweForum.Models
{
    public class ReplyToCommentViewModel
    {
        public int PostId { get; set; }

        public string Content { get; set; } = string.Empty;

        public int ParentId { get; set; }

        public int Depth { get; set; }

    }
}
