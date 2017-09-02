using System.Threading.Tasks;
using Abp;
using Abp.Notifications;
using Cloud.Rjc.Authorization.Users;
using Cloud.Rjc.MultiTenancy;

namespace Cloud.Rjc.Notifications
{
    public interface IAppNotifier
    {
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        Task NewTenantRegisteredAsync(Tenant tenant);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);
    }
}
