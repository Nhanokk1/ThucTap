using Bài_tập_tuần_2.Models;

namespace Bài_tập_tuần_2.Repository
{
    public interface IUserReposiory
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User?> GetByIdAsync(int id);
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(int id);
    }
}
