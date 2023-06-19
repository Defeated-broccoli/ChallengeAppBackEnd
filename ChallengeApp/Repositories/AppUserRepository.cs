using ChallengeApp.Data;
using ChallengeApp.Interfaces;
using ChallengeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeApp.Repositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly ApplicationDbContext _context;

        public AppUserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(AppUser appUser)
        {
            _context.Users.Add(appUser);
            return Save();
        }

        public bool Delete(AppUser appUser)
        {
            _context.Users.Remove(appUser);
            return Save();
        }

        public async Task<List<AppUser>> GetAllAppUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<List<Comment>> GetAllCommentsByAppUser(AppUser appUser)
        {
            return await _context.Comments.Where(c => c.AppUserId == appUser.Id).ToListAsync();
        }

        public async Task<List<Post>> GetAllPostsByAppUser(AppUser appUser)
        {
            return await _context.Posts.Where(p => p.AppUserId == appUser.Id).ToListAsync();
        }

        public async Task<AppUser> GetAppUserById(string id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0 ? true : false;
        }

        public bool Update(AppUser appUser)
        {
            _context.Users.Update(appUser);
            return Save();
        }
    }
}
