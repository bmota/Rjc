using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace Cloud.Rjc.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
