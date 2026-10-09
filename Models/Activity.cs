using System;
using System.Collections.Generic;

namespace sabaycs321.Models;

public class Activity
{
    public int Id { get; set; }

    public string Title { get; set; } = "";

    public string Description { get; set; } = "";

    public string Location { get; set; } = "";

    public DateTime DateTime { get; set; }

    public int MaxParticipants { get; set; }

    public ActivityCategory Category { get; set; }

    public int CreatorId { get; set; }

    public Student? Creator { get; set; }

    public List<ActivityParticipant> Participants { get; set; } = new();
}