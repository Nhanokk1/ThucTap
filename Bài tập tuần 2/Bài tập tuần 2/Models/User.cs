namespace Bài_tập_tuần_2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;

        public List<TaskItem> Tasks { get; set; } = new();
    }
}
