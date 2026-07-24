namespace EventEaseApp.Models;

public class EventModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime Date { get; set; } = DateTime.Now;
    public string Description { get; set; } = string.Empty;
    public int Capacity { get; set; } = 50;
}