using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ShopCart.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ShopCartControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}