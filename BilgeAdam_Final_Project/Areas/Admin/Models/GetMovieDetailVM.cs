namespace BilgeAdam_Final_Project.Areas.Admin.Models
{
    public class GetMovieDetailVM
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public List<string> Categories { get; set; }
        public int Year { get; set; }
        public string DirectorName { get; set; }
    }
}
