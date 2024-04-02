using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Employee_Management_System
{
    public class Employee : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        [ForeignKey(nameof(Department))]
        public Guid DepartmentId { get; set; }
        public virtual Department? Department { get; set; }

        public int Salary { get; set; }
    }
}
