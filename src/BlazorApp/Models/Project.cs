namespace BlazorApp.Models;

public record Project
{
    public string title { get; set; } = string.Empty;
    public List<string> descriptions { get; set; } = new List<string>();
    public string Url { get; set; } = string.Empty;
}