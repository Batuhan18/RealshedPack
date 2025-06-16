using Microsoft.AspNetCore.Mvc;

namespace RealshedPack.Controllers
{
    public class Default : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}