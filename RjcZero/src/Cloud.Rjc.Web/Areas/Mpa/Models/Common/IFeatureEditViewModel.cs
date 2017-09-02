using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Cloud.Rjc.Editions.Dto;

namespace Cloud.Rjc.Web.Areas.Mpa.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}