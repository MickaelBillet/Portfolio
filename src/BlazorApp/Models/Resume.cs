namespace BlazorApp.Models
{
    public record Resume
    {
        public string name { get; set; } = string.Empty;
        public string address { get; set; } = string.Empty;
        public string phone { get; set; } = string.Empty;
        public string mail { get; set; } = string.Empty;
        public List<Education>? education { get; set; } = new List<Education>();
        public List<ExperienceType1> experiencetype1 { get; set; } = new List<ExperienceType1>();
        public List<ExperienceType2> experiencetype2 { get; set; } = new List<ExperienceType2>();
    }
}
