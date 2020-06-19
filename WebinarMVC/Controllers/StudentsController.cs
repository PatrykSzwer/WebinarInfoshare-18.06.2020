using Microsoft.AspNetCore.Mvc;

namespace WebinarMVC.Controllers
{
    public class StudentsController : Controller
    {
        // Metoda zwracająca widok tworzący studenta.
        public IActionResult Index()
        {
            return View();
        }
    }
}
