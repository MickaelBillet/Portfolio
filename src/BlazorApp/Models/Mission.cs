namespace BlazorApp.Models
{
    public class Mission
    {
        public string description { get; set; } = string.Empty;
        public List<string> tasks { get; set; } = new List<string>();
    }
}
