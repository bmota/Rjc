using System.Collections.Generic;
using Cloud.Rjc.Authorization.Users.Dto;
using Cloud.Rjc.Dto;

namespace Cloud.Rjc.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}