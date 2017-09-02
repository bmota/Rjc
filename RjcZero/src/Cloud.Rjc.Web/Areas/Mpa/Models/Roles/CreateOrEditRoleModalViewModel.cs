using Abp.AutoMapper;
using Cloud.Rjc.Authorization.Roles.Dto;
using Cloud.Rjc.Web.Areas.Mpa.Models.Common;

namespace Cloud.Rjc.Web.Areas.Mpa.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode
        {
            get { return Role.Id.HasValue; }
        }

        public CreateOrEditRoleModalViewModel(GetRoleForEditOutput output)
        {
            output.MapTo(this);
        }
    }
}