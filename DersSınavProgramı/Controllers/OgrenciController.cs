using Microsoft.AspNetCore.Mvc;

namespace DersSınavProgramı.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
