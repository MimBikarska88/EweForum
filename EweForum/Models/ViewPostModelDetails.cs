namespace EweForum.Models
{
	public class ViewPostModelDetails
	{
		public string Title { get; set; } = string.Empty;
		public int PostType { get; set; }

		public int Id { get; set; }

		public string EventDescription { get; set; } = string.Empty;

		public bool IsNew { get; set; }

		public string CreatedOn { get; set; } = string.Empty;

		public string Content { get; set; } = string.Empty;
		public string Start { get; set; } = string.Empty;

		public string End { get; set; } = string.Empty;

		public string VideoUrl { get; set; } = string.Empty;
		public string VideoDescription { get; set; } = string.Empty;

		public string EventTitle { get; set; } = string.Empty;

		public string VideoTitle { get; set; } = string.Empty;

		public int TopicId { get; set; }

		public string Username { get; set; } = string.Empty;

		public bool HasLiked { get; set; }

		public int LikesCount { get; set; }

		public List<ReplyViewModel> Replies { get; set; } = new List<ReplyViewModel> ();

		public bool ShowDetailsButton { get; set; } = true;
	}
}
