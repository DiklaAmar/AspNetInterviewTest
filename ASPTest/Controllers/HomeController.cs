using System.Web.Mvc;

namespace ASPTest.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            HttpContext.Cache.Remove("Items");
            HttpContext.Cache.Remove("NextPositionItemsList");

            return View();
        }
    }
}