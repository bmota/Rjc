using System.Collections.Generic;
using Cloud.Rjc.Authorization.Users.Dto;

namespace Cloud.Rjc.Web.Areas.Mpa.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}