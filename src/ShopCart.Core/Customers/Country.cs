using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCart.Customers
{
    [Table("Customers")]
    public class Customer : FullAuditedEntity<Guid>, IPassivable, IMayHaveTenant
    {
        public virtual int? TenantId { get; set; }
        public virtual string CustomerName { get; set; }
        public bool IsActive { get; set; }
    }
}
