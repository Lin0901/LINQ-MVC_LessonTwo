namespace LessonTwo.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public Student(int id, string name, int age)
        {
            StudentID = id;
            StudentName = name;
            Age = age;
        }

        
    }
}
