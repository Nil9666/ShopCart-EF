using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCart.Trackings
{
    [Table("Trackings")]
    public class Tracking : FullAuditedEntity<Guid>, IPassivable, IMayHaveTenant
    {
        public virtual int? TenantId { get; set; }
        public virtual string TrackingName { get; set; }
        public bool IsActive { get; set; }
    }
}
