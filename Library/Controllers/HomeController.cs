using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        //
        //GET /HomeContoller/
        public IActionResult Index()
        {
            return View();
        }

        //
        //GET /HomeContoller/Welcome/
        public IActionResult Welcome(string name, int id = 1)
        {
            ViewData["id"] = id;
            ViewData["Message"] = "Hello "+name;
            return View();
        }
    }
}
