using System.Collections.Generic;
using Cloud.Rjc.Auditing.Dto;
using Cloud.Rjc.Dto;

namespace Cloud.Rjc.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
