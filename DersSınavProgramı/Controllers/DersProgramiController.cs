using Microsoft.AspNetCore.Mvc;

namespace DersSınavProgramı.Controllers
{
    public class DersProgramiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
