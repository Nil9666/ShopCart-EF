using System.Threading.Tasks;
using Abp.Application.Services;
using ShopCart.Sessions.Dto;

namespace ShopCart.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
