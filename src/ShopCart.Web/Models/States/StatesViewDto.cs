using Abp.Application.Services.Dto;
using ShopCart.States.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopCart.Web.Models.States
{
    public class StatesViewDto
    {
        public List<StateDto> States { get; set; }
    }
}