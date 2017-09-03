﻿using Abp.AutoMapper;
using System.Linq;
using MyCompanyName.AbpZeroTemplate.Authorization.Users.Dto;

namespace MyCompanyName.AbpZeroTemplate.Web.Areas.Mpa.Models.Users
{
    [AutoMapFrom(typeof (GetUserForEditOutput))]
    public class CreateOrEditUserModalViewModel : GetUserForEditOutput
    {
        public bool CanChangeUserName
        {
            get { return User.UserName != Authorization.Users.User.AdminUserName; }
        }

        public int AssignedRoleCount
        {
            get { return Roles.Count(r => r.IsAssigned); }
        }

        public bool IsEditMode
        {
            get { return User.Id.HasValue; }
        }

        public CreateOrEditUserModalViewModel(GetUserForEditOutput output)
        {
            output.MapTo(this);
        }
    }
}