using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ShopCart.MultiTenancy.Dto;

namespace ShopCart.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
