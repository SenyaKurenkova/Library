using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        //
        //GET /HomeContoller/
        public string Index()
        {
            return "This is my default action...";
        }

        //
        //GET /HomeContoller/Welcome/
        public string Welcome(string name, int id = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {id}");
        }
    }
}
