using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Assignment1.Entities
{
    public class Department : AuditedAggregateRoot<Guid>
    {
        public required string DepartmentName { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}
