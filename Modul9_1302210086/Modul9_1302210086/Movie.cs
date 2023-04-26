namespace Modul9_1302210086
{
    public class Movie
    {
        public string title { get; set; }
        public string Director { get; set; }
        public List<string> Stars { get; set; }
        public string Description { get; set; }
        public Movie(string title, string director, List<string> Stars, string Description)
        {
            this.title = title;
            this.Director = director;
            this.Stars = new List<string>();
            this.Description = Description;

        }
    }
}
