using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;


namespace DersSınavProgramı.Controllers
{
    public class DersController : Controller
    {
        DersManager dm = new DersManager( new EFDersRepository());
        public IActionResult Index()
        {
            var values = dm.GetDersListWithAkademisyen();
            return View(values);
        }
        public IActionResult Edit(int id)
        {
            var values = dm.GetByIdD(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(Ders ders)
        {
            DersValidator dv = new DersValidator();
            ValidationResult  result = dv.Validate(ders);
            if (result.IsValid)
            {
                dm.TUpdate(ders);
                return RedirectToAction("Index", "Ders");

            }
            else
            {
               foreach (var d in result.Errors)
                {
                    ModelState.AddModelError(d.PropertyName, d.ErrorMessage);
                }
            }
          return View();
         
         
        }
        public IActionResult Delete(int id)
        {
            dm.TRemove(dm.GetByIdD(id));
            return RedirectToAction("Index", "Ders");
        }
        
    }
}
