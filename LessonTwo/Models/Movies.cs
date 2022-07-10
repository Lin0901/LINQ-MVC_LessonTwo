namespace LessonTwo.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public static int MoviesIdCount { get; set; } = 0;
        public string Title { get; set; }
        public string Category { get; set; }
        public int Budget { get; set; }
        public DateTime Date { get; set; }
        public List<Actor> Actors { get; set; }

        public Movies(string title, string category, int budget, DateTime date)
        {
            Title = title;
            Category = category;
            Budget = budget;
            Date = date;
        }
    }

}
