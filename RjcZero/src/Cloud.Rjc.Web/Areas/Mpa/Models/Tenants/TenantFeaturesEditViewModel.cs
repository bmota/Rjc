using Abp.AutoMapper;
using Cloud.Rjc.MultiTenancy;
using Cloud.Rjc.MultiTenancy.Dto;
using Cloud.Rjc.Web.Areas.Mpa.Models.Common;

namespace Cloud.Rjc.Web.Areas.Mpa.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesForEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesForEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }

        public TenantFeaturesEditViewModel(Tenant tenant, GetTenantFeaturesForEditOutput output)
        {
            Tenant = tenant;
            output.MapTo(this);
        }
    }
}