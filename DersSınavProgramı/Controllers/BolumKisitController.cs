using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DersSınavProgramı.Controllers
{
    public class BolumKisitController : Controller
    {
        BolumKisitManager bkm = new BolumKisitManager(new EFBolumKisitRepository());
        public IActionResult Index()
        {
            var value = bkm.GetBolumKisitListWithSablonZaman();
            return View(value);
        }

  
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(BolumKisit bolumKisit)
        {
            bkm.TAdd(bolumKisit);
            return RedirectToAction("Index", "Bolum");
        }

    }
}
