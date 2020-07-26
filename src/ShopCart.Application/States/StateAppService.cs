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

        public async Task<StateDto> CreateAsync(CreateOrEditStateDto input)
        {
            try
            {
                if (input.Id != null && input.Id != Guid.Empty)
                {
                    return ObjectMapper.Map<StateDto>(await _stateRepository.FirstOrDefaultAsync(input.Id));
                }
                else
                {
                    var State = ObjectMapper.Map<State>(input);

                    if (AbpSession.TenantId != null)
                    {
                        State.TenantId = (int?)AbpSession.TenantId;
                    }

                    await _stateRepository.InsertAndGetIdAsync(State);
                    return ObjectMapper.Map<StateDto>(State);
                }
                
            }
            catch (Exception ex)
            {
                return new StateDto();
            }            
        }

        public async Task<List<StateDto>> GetAll()
        {
            var States =await _stateRepository.GetAllListAsync(e=>e.TenantId == AbpSession.TenantId);

            try
            {
                var StatesList = ObjectMapper.Map<List<StateDto>>(States.OrderByDescending(e=>e.CreationTime).ToList());

                return StatesList;
            }
            catch (Exception ex)
            {
                return new List<StateDto>();
            }
        }
    }
}
