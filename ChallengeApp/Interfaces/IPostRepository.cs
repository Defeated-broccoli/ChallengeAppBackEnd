using ChallengeApp.Models;

namespace ChallengeApp.Interfaces
{
    public interface IPostRepository
    {
        Task<Post> GetPostById(int id);
        Task<List<Post>> GetAllPosts();
        Task<List<Post>> GetAllPostsByAppUser(AppUser appUser);
        Task<List<Post>> GetAllPostsByChallenge (Challenge challenge);
        bool Save();
        bool Update(Post post);
        bool Delete(Post post);
        bool Add(Post post);
    }
}
