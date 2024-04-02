using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Employee_Management_System
{
    public class Department : AuditedAggregateRoot<Guid>
    {
        public string DepartmentName { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
