using System.Collections.Generic;

namespace sabaycs321.Models;

public class Student
{
    public int Id { get; set; }

    public string FullName { get; set; } = "";

    public string Email { get; set; } = "";

    public string Course { get; set; } = "";

    public List<Activity> CreatedActivities { get; set; } = new();

    public List<ActivityParticipant> Participations { get; set; } = new();

    public List<Notification> Notifications { get; set; } = new();
}