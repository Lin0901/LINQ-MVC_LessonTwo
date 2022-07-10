using LessonTwo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LessonTwo.Controllers
{
    public class StudentController : Controller
    {
        List<Student> AllStudents = new List<Student>();

        public StudentController()
        {
            AllStudents = new List<Student>();
            AllStudents.Add(new Student(1, "Bill", 18));
            AllStudents.Add(new Student(2, "Tom", 19));
            AllStudents.Add(new Student(3, "John", 21));
            AllStudents.Add(new Student(4, "Lin", 23));

        }
        public IActionResult Index(int? id) // 这是总方法
        {
            if (id != null)
            {
                Student student = AllStudents.First(s => s.StudentID == id);
                return View("Details", student);
            }
            return View(); // 这是调用下列方法，在总方法的区域，显示出来
        }
        public IActionResult Details(int? id) // 这是一个子方法
        {

            return View();
        }
        public IActionResult AgeRange(int low, int high) // 最后需要给 low 和 high 赋值 .../student/agerange?low=18&high=30
        {
            List<Student> studentsInRange = AllStudents.Where(s => s.Age >= low && s.Age <= high).ToList<Student>();

            return View(studentsInRange);
        }

    }
}
