using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Cloud.Rjc.Authorization.Users;

namespace Cloud.Rjc.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}