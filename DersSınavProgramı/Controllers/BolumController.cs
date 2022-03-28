using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DersSınavProgramı.Controllers
{
    public class BolumController : Controller
    {
        BolumManager bm = new BolumManager(new EFBolumRepository());
        public IActionResult Index()
        {
            var values = bm.GetBolumListWithFakulte();
            return View(values);
        }
        public IActionResult Edit(int id)
        {
            var values = bm.GetByIdD(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(Bolum bolum)
        {


            bm.TUpdate(bolum);
            return RedirectToAction("Index", "Bolum");


        }
        public IActionResult Delete(int id)
        {
            bm.TRemove(bm.GetByIdD(id));
            return RedirectToAction("Index", "Bolum");
        }
    }
}
