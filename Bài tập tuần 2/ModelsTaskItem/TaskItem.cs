using Bài_tập_tuần_2.Models;
using System.ComponentModel.DataAnnotations;

namespace Bài_tập_tuần_2.ModelsTaskItem
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime DueDate { get; set; }

        // Foreign Key
        public int UserId { get; set; }
        public User? User { get; set; }

    }
}
