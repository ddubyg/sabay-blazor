using System;
using System.Collections.Generic;
using System.Linq;

namespace sabaycs321.Services
{
    public class ActivityItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Category { get; set; } = "";
        public string Location { get; set; } = "";
        public string Date { get; set; } = "";
        public string Time { get; set; } = "";
        public int Needed { get; set; }
        public List<string> Participants { get; set; } = new();
        public string Description { get; set; } = "";
        public string Creator { get; set; } = "";
    }

    public static class ActivityStore
    {
        public static List<ActivityItem> Activities { get; } = new()
        {
            new ActivityItem
            {
                Id = 1,
                Title = "Study Session",
                Category = "Studying",
                Location = "CIT-U Library",
                Date = "October 5, 2026",
                Time = "2:00 PM",
                Needed = 4,
                Participants = new List<string> { "Alex", "Mark" },
                Description = "Let's review together for our upcoming exams.",
                Creator = "Alex"
            },
            new ActivityItem
            {
                Id = 2,
                Title = "Tennis Session",
                Category = "Sports",
                Location = "CIT-U Tennis Court",
                Date = "October 6, 2026",
                Time = "4:00 PM",
                Needed = 4,
                Participants = new List<string> { "Ryan" },
                Description = "Looking for people to play casual tennis.",
                Creator = "Ryan"
            },
            new ActivityItem
            {
                Id = 3,
                Title = "Lunch at IT Park",
                Category = "Food",
                Location = "IT Park",
                Date = "October 7, 2026",
                Time = "12:00 PM",
                Needed = 5,
                Participants = new List<string> { "Jamie", "Chris", "Sam" },
                Description = "Looking for people to grab lunch together.",
                Creator = "Jamie"
            },
            new ActivityItem
            {
                Id = 4,
                Title = "Gaming Night",
                Category = "Gaming",
                Location = "Online",
                Date = "October 8, 2026",
                Time = "8:00 PM",
                Needed = 5,
                Participants = new List<string> { "Kyle" },
                Description = "Looking for teammates for a gaming session.",
                Creator = "Kyle"
            }
        };

        public static int NextId =>
            Activities.Count == 0 ? 1 : Activities.Max(x => x.Id) + 1;

        public static ActivityItem? GetActivity(int id)
        {
            return Activities.FirstOrDefault(x => x.Id == id);
        }

        public static bool JoinActivity(int id, string user)
        {
            var activity = GetActivity(id);

            if (activity == null)
                return false;

            if (activity.Participants.Contains(user))
                return false;

            if (activity.Participants.Count >= activity.Needed)
                return false;

            activity.Participants.Add(user);
            return true;
        }

        public static void AddActivity(ActivityItem activity)
        {
            activity.Id = NextId;
            Activities.Add(activity);
        }
    }
}