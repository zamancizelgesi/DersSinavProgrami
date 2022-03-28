using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DersSınavProgramı.Controllers
{
    public class FakulteController : Controller
    {
        FakulteManager fm = new FakulteManager(new EFFakulteRepository());
        public IActionResult Index()
        {
            var value = fm.GetListAll();
            return View(value);
        }
        public IActionResult Delete(int id)
        {
            fm.TRemove(fm.GetByIdD(id));
            return RedirectToAction("Index", "Fakulte");
        }
    }
}
