using Bài_tập_tuần_2.Models;

namespace Bài_tập_tuần_2.TaskReposioty
{
    public interface ITasksRepository
    {
        Task<IEnumerable<TaskItem>> GetAllAsync();
        Task<TaskItem?> GetByIdAsync(int id);
        Task AddAsync(TaskItem task);
        Task UpdateAsync(TaskItem task);
        Task DeleteAsync(int id);
    }
}
