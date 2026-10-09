using System;

namespace sabaycs321.Models;

public class Notification
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public string Title { get; set; } = "";

    public string Content { get; set; } = "";

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public bool IsRead { get; set; }

    public Student? Student { get; set; }
}