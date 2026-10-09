using System;

namespace sabaycs321.Models;

public class ActivityParticipant
{
    public int Id { get; set; }

    public int ActivityId { get; set; }

    public int StudentId { get; set; }

    public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

    public Activity? Activity { get; set; }

    public Student? Student { get; set; }
}