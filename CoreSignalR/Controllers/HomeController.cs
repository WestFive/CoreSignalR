using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
namespace CoreSignalRR.Controllers
{
    public class HomeController : Controller
    {
        [EnableCors("AllowAll")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            //ViewData["Message"] = "Your application description page.";

            return View();
        }


        [EnableCors("AllowAll")]
        public IActionResult Contact()
        {
            //ViewData["Message"] = "Your contact page.";

            return View();
        }

        [EnableCors("AllowAll")]
        public IActionResult Queue()
        {
            return View();
        }

        [EnableCors("AllowAll")]
        public IActionResult Error()
        {
            return View();
        }



    }
}
