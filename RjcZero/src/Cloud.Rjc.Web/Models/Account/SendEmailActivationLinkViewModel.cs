using System.ComponentModel.DataAnnotations;

namespace Cloud.Rjc.Web.Models.Account
{
    public class SendEmailActivationLinkViewModel
    {
        public string TenancyName { get; set; }

        [Required]
        public string EmailAddress { get; set; }
    }
}