using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace RjcErp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : RjcErpControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}