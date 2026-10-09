using System;

namespace sabaycs321.Models;

public class Message
{
    public int Id { get; set; }

    public int SenderId { get; set; }

    public int ReceiverId { get; set; }

    public string Content { get; set; } = "";

    public DateTime SentAt { get; set; } = DateTime.UtcNow;

    public Student? Sender { get; set; }

    public Student? Receiver { get; set; }
}