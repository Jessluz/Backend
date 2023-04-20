using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    public class TypesFood : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
