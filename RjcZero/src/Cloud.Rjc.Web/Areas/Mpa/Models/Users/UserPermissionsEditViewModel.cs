using Abp.AutoMapper;
using Cloud.Rjc.Authorization.Users;
using Cloud.Rjc.Authorization.Users.Dto;
using Cloud.Rjc.Web.Areas.Mpa.Models.Common;

namespace Cloud.Rjc.Web.Areas.Mpa.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; private set; }

        public UserPermissionsEditViewModel(GetUserPermissionsForEditOutput output, User user)
        {
            User = user;
            output.MapTo(this);
        }
    }
}