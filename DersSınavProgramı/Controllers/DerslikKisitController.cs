using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DersSınavProgramı.Controllers
{
    public class DerslikKisitController : Controller
    {
        DerslikKisitManager dkm = new DerslikKisitManager(new EFDerslikKisitRepository());
        public IActionResult Index()
        {
            var value = dkm.GetListAll();
            return View(value);
        }
    }
}
