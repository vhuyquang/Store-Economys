using ES.Core.Model;
using ES.Core.ShareModel;
using ES.Services.Interface;
using System.Web.Mvc;

namespace ES.Web.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index()
        {
            SearchWithPaging param = new SearchWithPaging();
            param.PageNo = 0;
            param.PageSize = 20;
            param.SearchTerm = null;
            PagedResult<ProductModel> Product = _productService.GetAll(param);
            return View();
        }
    }
}