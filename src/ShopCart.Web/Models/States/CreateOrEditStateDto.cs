using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopCart.Web.Models.States
{
    public class CreateOrEditStateDto : EntityDto<Guid>
    {
        public string StateName { get; set; }
    }
}