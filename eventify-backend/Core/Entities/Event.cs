using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Event
{
    [Key] public Guid Id { get; set; }
    public string Name { get; set; }
    public string ShortDescription { get; set; }
    public string LongDescription { get; set; }
    public string Place { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public string Image { get; set; }
    public int UserId { get; set; }
}