using Abp.Web.Mvc.Views;

namespace RjcErp.Web.Views
{
    public abstract class RjcErpWebViewPageBase : RjcErpWebViewPageBase<dynamic>
    {

    }

    public abstract class RjcErpWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected RjcErpWebViewPageBase()
        {
            LocalizationSourceName = RjcErpConsts.LocalizationSourceName;
        }
    }
}