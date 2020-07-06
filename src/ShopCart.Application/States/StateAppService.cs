using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using ShopCart.Authorization;
using ShopCart.States.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCart.States
{
    [AbpAuthorize(PermissionNames.Pages_State)]
    public class StateAppService : AsyncCrudAppService<State, StateDto, Guid, PagedResultRequestDto>, IStateAppService
    {
        private readonly IRepository<State, Guid> _stateRepository;

        public StateAppService(IRepository<State, Guid> repository,
            IRepository<State, Guid> stateRepository) : base(repository)
        {
            _stateRepository = stateRepository;
        }

        public Task<StateDto> CreateAsync(CreateOrEditStateDto input)
        {
            throw new NotImplementedException();
        }

        public async Task<List<StateDto>> GetAll()
        {
            var States =await _stateRepository.GetAllListAsync(e=>e.TenantId == AbpSession.TenantId);
            
            var StatesList = new List<StateDto>();
            foreach (var item in States)
            {
                var objState = new StateDto()
                {
                    Id = item.Id,
                    TenantId = item.TenantId,
                    IsActive = item.IsActive,
                    StateName = item.StateName
                };
                StatesList.Add(objState);
            }

            return StatesList;
        }
    }
}
