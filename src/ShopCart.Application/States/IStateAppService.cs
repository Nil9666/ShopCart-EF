using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ShopCart.States.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCart.States
{
    public interface IStateAppService : IAsyncCrudAppService<StateDto, Guid, PagedResultRequestDto, CreateOrEditStateDto, StateDto>
    {
        Task<List<StateDto>> GetAll();
    }
}
