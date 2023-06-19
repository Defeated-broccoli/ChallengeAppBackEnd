using ChallengeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeApp.Interfaces
{
    public interface ICommentRepository
    {
        Task<Comment> GetCommentById(int id);
        Task<List<Comment>> GetAllComments();
        Task<List<Comment>> GetAllCommentsByAppUser(AppUser appUser);
        Task<List<Comment>> GetAllCommentsByPost(Post post);
        bool Save();
        bool Update(Comment comment);
        bool Delete(Comment comment);
        bool Add(Comment comment);
    }
}
