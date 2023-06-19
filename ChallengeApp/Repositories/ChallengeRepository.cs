using ChallengeApp.Data;
using ChallengeApp.Interfaces;
using ChallengeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeApp.Repositories
{
	public class ChallengeRepository : IChallengeRepository
	{
		private readonly ApplicationDbContext _context;

		public ChallengeRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
		}
        public bool Add(Challenge challenge)
		{
            _context.Challenges.Add(challenge);
			return Save();
		}

		public bool Delete(Challenge challenge)
		{
            _context.Challenges.Remove(challenge);
			return Save();
		}

		public async Task<List<Challenge>> GetAllChallenges()
		{
			return await _context.Challenges.ToListAsync();
		}

        public async Task<Challenge> GetChallengeById(int id)
		{
			return await _context.Challenges.FirstOrDefaultAsync(c => c.Id == id);
		}

		public bool Save()
		{
			return _context.SaveChanges() > 0 ? true : false;
		}

		public bool Update(Challenge challenge)
		{
            _context.Challenges.Update(challenge);
			return Save();
		}
	}
}
