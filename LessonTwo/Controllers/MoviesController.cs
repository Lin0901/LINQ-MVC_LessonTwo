using LessonTwo.Models;
using Microsoft.AspNetCore.Mvc;

namespace LessonTwo.Controllers
{
    public class MoviesController : Controller
    {
        List<Movies> AllMovies { get; set; }

        public MoviesController()
        {
            AllMovies = new List<Movies>();
            AllMovies.Add(new Movies("夏洛特烦恼", "喜剧片", 2000, new DateTime(2010,09,01)));
            AllMovies.Add(new Movies("西虹市首富", "喜剧片", 3000, new DateTime(2012,09,01)));
            AllMovies.Add(new Movies("钢铁侠", "科幻片", 8000, new DateTime(2005,09,01)));
            AllMovies.Add(new Movies("甲方乙方", "剧情片", 600, new DateTime(1999,09,01)));
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "All Movies";
            ViewData["numOfMovies"] = AllMovies.Count;

            return View(AllMovies);
        }

        public IActionResult Category(string type)
        {
            List<Movies> ShowCategory = AllMovies.Where(m => m.Category.Contains(type)).ToList();
            ViewData["Title"] = "The Type of Movies";
            ViewData["numOfMovies"] = ShowCategory.Count;
            return View("Index", ShowCategory);
        }
        public IActionResult InBudgetRange(int low, int high)
        {
            List<Movies> ShowMovies = AllMovies.Where(m => m.Budget <= high && m.Budget >= low).ToList();
            ViewData["Title"] = "In Budget Range";
            ViewData["numOfMovies"] = ShowMovies.Count;
            return View("Index", ShowMovies);
        }
        public IActionResult InRangeYear(int high, int low)
        {
            List<Movies> ShowMovies = AllMovies.Where(m => m.Date.Year <= high && m.Date.Year >= low).ToList();
            ViewData["Title"] = "In Range of Year";
            ViewData["numOfMovies"] = ShowMovies.Count;
            return View("Index", ShowMovies);
        }
        public IActionResult AvrageFilmCost()
        {
           // int total = GetTotalCost();
           return View();
        }
    }
}
