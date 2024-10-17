namespace BlazorApp.Models
{
    public class ExperienceType1 : ExperienceType
    {
        public string title { get; set; } = string.Empty;
        public string company { get; set; } = string.Empty;
        public string years { get; set; } = string.Empty;
        public string location { get; set; } = string.Empty;
        public List<Mission> missions { get; set; } = new List<Mission>();
    }
}
