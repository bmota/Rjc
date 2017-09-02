using Abp.WebApi.Controllers;

namespace Cloud.Rjc.WebApi
{
    public abstract class AbpZeroTemplateApiControllerBase : AbpApiController
    {
        protected AbpZeroTemplateApiControllerBase()
        {
            LocalizationSourceName = AbpZeroTemplateConsts.LocalizationSourceName;
        }
    }
}