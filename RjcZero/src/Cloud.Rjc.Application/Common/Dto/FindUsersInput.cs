using Cloud.Rjc.Dto;

namespace Cloud.Rjc.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}