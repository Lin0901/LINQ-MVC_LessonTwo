using LessonTwo.Models;
using Microsoft.AspNetCore.Mvc;

namespace LessonTwo.Controllers
{
    public class ActorController : Controller
    {
        List<Actor> ActorList;
        public ActorController()
        {
            ActorList = new List<Actor>();
            ActorList.Add(new Actor("Bob", new DateTime(2000,09,01)));
            ActorList.Add(new Actor("John", new DateTime(1998,05,01)));
            ActorList.Add(new Actor("Ann", new DateTime(2002,03,01)));
            ActorList.Add(new Actor("Lisa", new DateTime(1999,07,01)));
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
