using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Contact
{
    public class ContactList:ViewComponent
    {
        ContactManager _contactManager = new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var values = _contactManager.TGetList();
            return View(values);
        }
    }
}
