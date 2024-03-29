﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;

namespace ChallengeApp.Models
{
	public class AppUser : IdentityUser
	{
		public string? Name { get; set; }
		public string? Description { get; set; }
		public string? Image { get; set; }
		public List<Post> Posts { get; set; }
		public List<Comment> Comments { get; set; }
	}

}
