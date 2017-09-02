using System.Threading.Tasks;
using Cloud.Rjc.Sessions.Dto;

namespace Cloud.Rjc.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
