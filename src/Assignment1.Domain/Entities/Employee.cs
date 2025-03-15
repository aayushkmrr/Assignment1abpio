using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Assignment1.Entities
{
    public class Employee : AuditedAggregateRoot<Guid>
    {
        public required string EmployeeName { get; set; }

        public required Guid DepartmentId { get; set; }

        public virtual Department Department { get; set; }


    }
}
