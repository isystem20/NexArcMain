using System.Threading.Tasks;
using Abp.Application.Services;
using NEXARC.Sessions.Dto;

namespace NEXARC.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
