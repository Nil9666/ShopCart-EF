using Abp.Application.Services.Dto;
using Abp.Web.Mvc.Authorization;
using ShopCart.Authorization;
using ShopCart.Roles;
using ShopCart.States;
using ShopCart.Web.Models.Roles;
using ShopCart.Web.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ShopCart.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_State)]
    public class StateController : Controller
    {
        private readonly IRoleAppService _roleAppService;
        private readonly IStateAppService _stateAppService;

        public StateController(IRoleAppService roleAppService, IStateAppService stateAppService)
        {
            _roleAppService = roleAppService;
            _stateAppService = stateAppService;
        }
        // GET: State
        public async Task<ActionResult> Index()
        {
            var state = await _stateAppService.GetAll();
            //var roles = (await _roleAppService.GetAllAsync(new PagedAndSortedResultRequestDto())).Items;
            //var permissions = (await _roleAppService.GetAllPermissions()).Items;
            //var model = new RoleListViewModel
            //{
            //    Roles = roles,
            //    Permissions = permissions
            //};
            var model = new StatesViewDto()
            {
                States = state
            };
            return View(model);
        }
    }
}