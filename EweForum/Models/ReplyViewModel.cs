namespace EweForum.Models
{
	public class ReplyViewModel
	{
		public int Id { get; set; }

		public string Content { get; set; } = string.Empty;

		public int PostId { get; set; }

		public string UserId { get; set; } = string.Empty;

		public string Username { get; set; } = string.Empty;

		public string CreatedOn { get; set; } = string.Empty;

		public int Depth { get; set; }	 
	}
}
