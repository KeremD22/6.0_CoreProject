using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {
        ServiceManager _serviceManager = new ServiceManager(new EfServiceDal());
        public IViewComponentResult Invoke()
        {
            var values = _serviceManager.TGetList();
            return View(values);
        }
    }
}
