using System;
namespace tamDevMvc.Models
{
	public class BlogPost
	{
		public string Title { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }

		public BlogPost()
		{
		}
	}
}

