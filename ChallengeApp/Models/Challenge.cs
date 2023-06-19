using System.ComponentModel.DataAnnotations;

namespace ChallengeApp.Models
{
	public class Challenge
	{
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
