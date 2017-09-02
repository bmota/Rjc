using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Cloud.Rjc.Web.Controllers;

namespace Cloud.Rjc.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class WelcomeController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}