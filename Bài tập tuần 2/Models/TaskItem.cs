﻿namespace Bài_tập_tuần_2.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool IsCompleted { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
