using ES.Services.Interface;
using System.Web.Mvc;

namespace ES.Web.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
    }
}