using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Assignment1.Entities
{
    public class roles : AuditedAggregateRoot<Guid>
    {
        public string role_name { get; set; }
    }
}
