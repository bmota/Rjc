using Abp.Application.Services;
using Cloud.Rjc.Dto;
using Cloud.Rjc.Logging.Dto;

namespace Cloud.Rjc.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
