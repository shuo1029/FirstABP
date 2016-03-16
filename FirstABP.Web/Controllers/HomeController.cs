using System.Web.Mvc;

namespace FirstABP.Web.Controllers
{
    public class HomeController : FirstABPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}