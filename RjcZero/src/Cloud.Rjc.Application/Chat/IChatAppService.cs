using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Cloud.Rjc.Chat.Dto;

namespace Cloud.Rjc.Chat
{
    public interface IChatAppService : IApplicationService
    {
        GetUserChatFriendsWithSettingsOutput GetUserChatFriendsWithSettings();

        Task<ListResultDto<ChatMessageDto>> GetUserChatMessages(GetUserChatMessagesInput input);

        Task MarkAllUnreadMessagesOfUserAsRead(MarkAllUnreadMessagesOfUserAsReadInput input);
    }
}
