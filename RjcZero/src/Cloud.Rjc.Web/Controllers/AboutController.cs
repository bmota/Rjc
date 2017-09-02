using System.Web.Mvc;

namespace Cloud.Rjc.Web.Controllers
{
    public class AboutController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}