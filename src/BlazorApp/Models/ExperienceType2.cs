namespace BlazorApp.Models
{
    public record ExperienceType2 : ExperienceType
    {
        public string company { get; set; } = string.Empty;
        public string years { get; set; } = string.Empty ;
        public string location { get; set; } = string.Empty;
        public List<Job> jobs { get; set; } = new();
    }
}
