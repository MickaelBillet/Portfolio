namespace BlazorApp.Models;

public record AboutMe
{
    public string Description { get; set; } = string.Empty;
    public List<string> Skills { get; set; } = new();
    public string DetailOrQuote { get; set; } = string.Empty;
}