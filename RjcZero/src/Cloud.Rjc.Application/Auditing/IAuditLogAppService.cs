using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Cloud.Rjc.Auditing.Dto;
using Cloud.Rjc.Dto;

namespace Cloud.Rjc.Auditing
{
    public interface IAuditLogAppService : IApplicationService
    {
        Task<PagedResultDto<AuditLogListDto>> GetAuditLogs(GetAuditLogsInput input);

        Task<FileDto> GetAuditLogsToExcel(GetAuditLogsInput input);
    }
}