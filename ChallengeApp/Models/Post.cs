using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeApp.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }


        [ForeignKey("User")]
        public string? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }

        
        [ForeignKey("Challenge")]
        public int ChallengeId { get; set; }
        public Challenge Challenge { get; set; }

        List<Comment>? Comments { get; set; }
    }
}
