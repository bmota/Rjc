using Abp.Notifications;
using Cloud.Rjc.Dto;

namespace Cloud.Rjc.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}