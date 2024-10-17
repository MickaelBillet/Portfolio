namespace BlazorApp.Models
{
    public class Job
    {
        public string title { get; set; } = string.Empty;
        public string years { get; set; } = string.Empty;
        public List<Mission> missions { get; set; } = new ();
    }
}
