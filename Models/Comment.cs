using System;
namespace tamDevMvc.Models
{
	public class Comment
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string CommentContent { get; set; }

		public Comment()
		{
		}
	}
}

