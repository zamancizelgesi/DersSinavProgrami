using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DersSınavProgramı.Controllers
{
    public class AkademisyenController : Controller
    {
        AkademisyenManager aMa = new AkademisyenManager(new EFAkademisyenRepository());
        public IActionResult Index()
        {
            var values = aMa.GetListAll();
            return View(values);
        }
        public IActionResult Edit(int id)
        {
            var values = aMa.GetByIdD(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(Akademisyen akademisyen)
        {
              
           
                aMa.TUpdate(akademisyen);
                return RedirectToAction("Index", "Akademisyen");


        }
        public IActionResult Delete(int id)
        {
            aMa.TRemove(aMa.GetByIdD(id));
            return RedirectToAction("Index", "Akademisyen");
        }

    }
}
