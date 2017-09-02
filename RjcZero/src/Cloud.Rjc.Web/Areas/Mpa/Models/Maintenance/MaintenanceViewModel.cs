using System.Collections.Generic;
using Cloud.Rjc.Caching.Dto;

namespace Cloud.Rjc.Web.Areas.Mpa.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}