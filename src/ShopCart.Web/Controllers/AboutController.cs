using System.Web.Mvc;

namespace ShopCart.Web.Controllers
{
    public class AboutController : ShopCartControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}