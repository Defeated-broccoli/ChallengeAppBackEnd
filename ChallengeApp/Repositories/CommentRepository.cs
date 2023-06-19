using ChallengeApp.Data;
using ChallengeApp.Interfaces;
using ChallengeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeApp.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDbContext _context;

        public CommentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Comment comment)
        {
            _context.Comments.Add(comment);
            return Save();
        }

        public bool Delete(Comment comment)
        {
            _context.Comments.Remove(comment);
            return Save();
        }

        public async Task<List<Comment>> GetAllComments()
        {
            return await _context.Comments.ToListAsync();
        }

        public async Task<List<Comment>> GetAllCommentsByAppUser(AppUser appUser)
        {
            return await _context.Comments.Where(c => c.AppUser == appUser).ToListAsync();
        }

        public async Task<List<Comment>> GetAllCommentsByPost(Post post)
        {
            return await _context.Comments.Where(c => c.Post == post).ToListAsync();
        }

        public async Task<Comment> GetCommentById(int id)
        {
            return await _context.Comments.FirstOrDefaultAsync(c => c.Id == id);
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0 ? true : false;
        }

        public bool Update(Comment comment)
        {
            _context.Comments.Update(comment);
            return Save();
        }
    }
}
