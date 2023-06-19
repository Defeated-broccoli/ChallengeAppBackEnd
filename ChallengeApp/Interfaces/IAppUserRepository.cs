using ChallengeApp.Models;

namespace ChallengeApp.Interfaces
{
    public interface IAppUserRepository
    {
        Task<AppUser> GetAppUserById(string id);
        Task<List<AppUser>> GetAllAppUsers();
        Task<List<Comment>> GetAllCommentsByAppUser(AppUser appUser);
        Task<List<Post>> GetAllPostsByAppUser(AppUser appUser);
        bool Add(AppUser appUser);
        bool Update(AppUser appUser);
        bool Delete(AppUser appUser);
        bool Save();
    }
}
