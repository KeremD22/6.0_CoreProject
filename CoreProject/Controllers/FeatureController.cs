using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class FeatureController : Controller
    {

        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Öne Çıkan Güncelleme";
            ViewBag.v2 = "Öne Çıkan";
            ViewBag.v3 = "Öne Çıkan Güncelleme";
            var values = featureManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            ViewBag.v1 = "Öne Çıkan Güncelleme";
            ViewBag.v2 = "Öne Çıkan";
            ViewBag.v3 = "Öne Çıkan Güncelleme";
            featureManager.TUpdate(feature);
            return RedirectToAction("Index", "Default");
        }
    }
}
