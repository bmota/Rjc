using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Cloud.Rjc.Editions.Dto;

namespace Cloud.Rjc.MultiTenancy.Dto
{
    public class GetTenantFeaturesForEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}