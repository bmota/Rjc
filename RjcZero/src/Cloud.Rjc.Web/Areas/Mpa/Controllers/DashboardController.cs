using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Cloud.Rjc.Authorization;
using Cloud.Rjc.Web.Controllers;

namespace Cloud.Rjc.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class DashboardController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}