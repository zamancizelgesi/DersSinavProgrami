using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DersSınavProgramı.Controllers
{
    public class DerslikController : Controller
    {
        DerslikManager dm = new DerslikManager( new EFDerslikRepository());

        public IActionResult Index()
        {
            var values = dm.GetList();
            return View(values);
        }
        public IActionResult Edit(int id)
        {
            var values = dm.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit( Derslik derslik)
        {
            dm.DerslikUpdate(derslik);
            return RedirectToAction("Index","Derslik");
        }
        public IActionResult Delete(int id)
        {
            dm.DerslikRemove(dm.GetById(id));
            return RedirectToAction("Index", "Derslik");
        }
    }
}
