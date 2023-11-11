using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class SkillController : Controller
    {
        SkillManager _skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            var values = _skillManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.v1 = "Yetenek Listesi";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Listesi";
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill p)
        {
            ViewBag.v1 = "Yetenek Listesi";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Listesi";
            _skillManager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            ViewBag.v1 = "Yetenek Silme";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Silme";
            var values= _skillManager.TGetByID(id);
            _skillManager.TDelete(values);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            ViewBag.v1 = "Yetenek Güncelleme";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Güncelleme";
            var values=_skillManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill p)
        {
            ViewBag.v1 = "Yetenek Güncelleme";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Güncelleme";
            _skillManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
