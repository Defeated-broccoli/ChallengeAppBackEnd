using ChallengeApp.Models;

namespace ChallengeApp.Interfaces
{
	public interface IChallengeRepository
	{
		Task<Challenge> GetChallengeById(int id);
		Task<List<Challenge>> GetAllChallenges();
		Task<List<Challenge>> GetAllChallengesByAppUser(AppUser appUser);
		bool Add(Challenge challenge);
		bool Update(Challenge challenge);
		bool Delete(Challenge challenge);
		bool Save();
	}
}
