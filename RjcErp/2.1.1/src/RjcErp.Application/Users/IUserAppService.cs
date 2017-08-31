using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RjcErp.Roles.Dto;
using RjcErp.Users.Dto;

namespace RjcErp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}