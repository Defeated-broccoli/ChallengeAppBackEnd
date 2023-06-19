using ChallengeApp.Data;
using ChallengeApp.Interfaces;
using ChallengeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeApp.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly ApplicationDbContext _context;

        public PostRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Post post)
        {
            _context.Posts.Add(post);
            return Save();
        }

        public bool Delete(Post post)
        {
            _context.Posts.Remove(post);
            return Save();
        }

        public async Task<List<Post>> GetAllPosts()
        {
            return await _context.Posts.ToListAsync();
        }

        public async Task<List<Post>> GetAllPostsByAppUser(AppUser appUser)
        {
            return await _context.Posts.Where(p => p.AppUser == appUser).ToListAsync();
        }

        public async Task<List<Post>> GetAllPostsByChallenge(Challenge challenge)
        {
            return await _context.Posts.Where(p => p.Challenge == challenge).ToListAsync();
        }

        public async Task<Post> GetPostById(int id)
        {
            return await _context.Posts.FirstOrDefaultAsync(p => p.Id == id);
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0 ? true : false;   
        }

        public bool Update(Post post)
        {
            _context.Posts.Update(post);
            return Save();
        }
    }
}
