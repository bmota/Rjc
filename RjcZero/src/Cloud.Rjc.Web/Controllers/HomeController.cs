using System.Web.Mvc;

namespace Cloud.Rjc.Web.Controllers
{
    public class HomeController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}