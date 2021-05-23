using ES.Services.Interface;
using System.Web.Mvc;

namespace ES.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _service;

        public HomeController(IProductService service)
        {
            _service = service;
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}