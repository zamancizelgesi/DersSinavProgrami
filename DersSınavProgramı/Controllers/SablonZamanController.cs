using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DersSınavProgramı.Controllers
{
    public class SablonZamanController : Controller
    {
        SablonZamanManager szm = new SablonZamanManager(new EFSablonZamanRepository());
        public IActionResult Index()
        {
            var value = szm.GetListAll();
            return View(value);
        }
    }
}
