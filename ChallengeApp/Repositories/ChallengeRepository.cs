using ChallengeApp.Data;
using ChallengeApp.Interfaces;
using ChallengeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeApp.Repositories
{
	public class ChallengeRepository : IChallengeRepository
	{
		private readonly ApplicationDbContext _dbContext;

		public ChallengeRepository(ApplicationDbContext dbContext)
        {
			_dbContext = dbContext;
		}
        public bool Add(Challenge challenge)
		{
			_dbContext.Challenges.Add(challenge);
			return Save();
		}

		public bool Delete(Challenge challenge)
		{
			_dbContext.Challenges.Remove(challenge);
			return Save();
		}

		public async Task<List<Challenge>> GetAllChallenges()
		{
			return await _dbContext.Challenges.ToListAsync();
		}

        public Task<List<Challenge>> GetAllChallengesByAppUser(AppUser appUser)
        {
            throw new NotImplementedException();
        }

        public async Task<Challenge> GetChallengeById(int id)
		{
			return await _dbContext.Challenges.FirstOrDefaultAsync(c => c.Id == id);
		}

		public bool Save()
		{
			return _dbContext.SaveChanges() > 0;
		}

		public bool Update(Challenge challenge)
		{
			_dbContext.Challenges.Update(challenge);
			return Save();
		}
	}
}
