using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCart.LoginUsr
{
    [Table("LoginUsr")]
    public class Login : FullAuditedEntity<Guid>, IPassivable, IMayHaveTenant
    {
        public virtual int? TenantId { get; set; }
        public virtual string LoginName { get; set; }
        public bool IsActive { get; set; }
    }
}
