using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCart.States.Dto
{
    public class StateDto : EntityDto<Guid>
    {
        public int? TenantId { get; set; }
        public string StateName { get; set; }
        public bool IsActive { get; set; }
    }
}
