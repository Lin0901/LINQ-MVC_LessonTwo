namespace LessonTwo.Models
{
    public class Actor
    {
        public int Id { get; set; }

        public static int IdCounter { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }  
        List<Movies> Movies { get; set; }

        public Actor(string name, DateTime birthday)
        {
            Id = IdCounter++;
            Name = name;
            Birthday = birthday;
        }
    }
}
