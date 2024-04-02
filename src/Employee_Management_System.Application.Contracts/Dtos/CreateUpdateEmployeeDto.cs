using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Management_System.Dtos
{
    public class CreateUpdateEmployeeDto
    {
        public string Name { get; set; }
        public Guid DepartmentId { get; set; }
        public decimal Salary { get; set; }
    }
}
