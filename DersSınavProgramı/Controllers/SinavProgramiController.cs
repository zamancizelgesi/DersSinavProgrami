using Microsoft.AspNetCore.Mvc;

namespace DersSınavProgramı.Controllers
{
    public class SinavProgramiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
