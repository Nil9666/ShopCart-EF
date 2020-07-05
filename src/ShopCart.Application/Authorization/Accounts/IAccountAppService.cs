using System.Threading.Tasks;
using Abp.Application.Services;
using ShopCart.Authorization.Accounts.Dto;

namespace ShopCart.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
