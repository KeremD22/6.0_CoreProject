using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CoreProject.ViewComponents.Contact
{
    public class SendMessage:ViewComponent
    {
        MessageManager _messageManager = new MessageManager(new EfMessageDal());
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
 
    }
}
