using System.Threading.Tasks;
using Abp.Application.Services;
using ShopCart.Configuration.Dto;

namespace ShopCart.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}