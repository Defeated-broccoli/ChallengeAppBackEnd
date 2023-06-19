using ChallengeApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace ChallengeApp.Data
{

	public class ApplicationDbContext : IdentityDbContext<AppUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<Challenge> Challenges { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Post> Posts { get; set; }
	}
}

