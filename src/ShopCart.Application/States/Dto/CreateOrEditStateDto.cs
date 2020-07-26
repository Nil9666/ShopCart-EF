﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCart.States.Dto
{
    public class CreateOrEditStateDto : EntityDto<Guid>
    {
        public int? TenantId { get; set; }
        public string StateName { get; set; }
        public bool IsActive { get; set; }
        //public StateDto State { get; set; }
    }
}
