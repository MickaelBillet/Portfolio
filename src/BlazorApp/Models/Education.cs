namespace BlazorApp.Models
{
    public record Education : Item
    {
        public string title { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string years { get; set; } = string.Empty;
    }
}
