using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntitiyFramework;

using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class DefaultController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            var values = serviceManager.GetListAll();
            return View(values);
        }
    }
}
