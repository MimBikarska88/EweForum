namespace EweForum.Models
{
    public class TopicViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; } 

        public bool IsActive { get; set; }

        public int UserCount { get; set; }

        public bool IsCurrentUserJoined { get; set; }
    }
}
