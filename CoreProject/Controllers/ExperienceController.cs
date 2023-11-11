using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Deneyim Listesi";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Listesi";
            var values = experienceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Deneyim Ekleme";
            ViewBag.v2 = "Deneyim";
            ViewBag.v3 = "Deneyim Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            ViewBag.v1 = "Deneyim Ekleme";
            ViewBag.v2 = "Deneyim";
            ViewBag.v3 = "Deneyim Ekleme";
            experienceManager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            ViewBag.v1 = "Deneyim Silme";
            ViewBag.v2 = "Deneyim";
            ViewBag.v3 = "Deneyim Silme";
            var values = experienceManager.TGetByID(id);
            experienceManager.TDelete(values);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            ViewBag.v1 = "Deneyim Güncelleme";
            ViewBag.v2 = "Deneyim";
            ViewBag.v3 = "Deneyim Güncelleme";
            var values = experienceManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSkill(Experience p)
        {
            ViewBag.v1 = "Deneyim Güncelleme";
            ViewBag.v2 = "Deneyim";
            ViewBag.v3 = "Deneyim Güncelleme";
            experienceManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
