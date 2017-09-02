using System.Web.Mvc;
using Abp.Auditing;
using Abp.Web.Mvc.Authorization;
using Cloud.Rjc.Authorization;
using Cloud.Rjc.Web.Controllers;

namespace Cloud.Rjc.Web.Areas.Mpa.Controllers
{
    [DisableAuditing]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_AuditLogs)]
    public class AuditLogsController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}