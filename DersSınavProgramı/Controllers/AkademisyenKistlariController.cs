using Microsoft.AspNetCore.Mvc;

namespace DersSınavProgramı.Controllers
{
    public class AkademisyenKistlariController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
