using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Experience
{
    public class ExperienceList:ViewComponent
    {
        ExperienceManager _experinceManager = new ExperienceManager(new EfExperienceDal());
        public IViewComponentResult Invoke()
        {
            var values = _experinceManager.TGetList();
            return View(values);
        }
    }
}
