namespace EweForum.Models
{
    public class ViewTopicModel
    {
        public int Id { get; set; } 

        public bool IsActive { get; set; }

        public bool HasJoined { get; set; }

        public string CreatedOn { get; set; } = string.Empty;

        public string UpdatedOn { get; set; } = string.Empty;

        public string TopicName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public PaginationModel<PostViewModel> PaginationModel { get; set; } = null!;
    }
}
