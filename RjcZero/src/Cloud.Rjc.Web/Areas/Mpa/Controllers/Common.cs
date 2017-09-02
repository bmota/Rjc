using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Cloud.Rjc.Web.Areas.Mpa.Models.Common.Modals;
using Cloud.Rjc.Web.Controllers;

namespace Cloud.Rjc.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class CommonController : AbpZeroTemplateControllerBase
    {
        public PartialViewResult LookupModal(LookupModalViewModel model)
        {
            return PartialView("Modals/_LookupModal", model);
        }
    }
}