using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class AboutController : Controller
    {

        AboutManager aboutManager = new AboutManager(new EfAboutDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Öne Çıkan Güncelleme";
            ViewBag.v2 = "Öne Çıkan";
            ViewBag.v3 = "Öne Çıkan Güncelleme";
            var values = aboutManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            ViewBag.v1 = "Öne Çıkan Güncelleme";
            ViewBag.v2 = "Öne Çıkan";
            ViewBag.v3 = "Öne Çıkan Güncelleme";
            aboutManager.TUpdate(about);
            return RedirectToAction("Index","Default");
        }
    }
}
