using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Employee_Management_System.Dtos
{
    public class DepartmentDto : EntityDto<Guid>
    {
        public Guid Id { get; set; }
        public string DepartmentName { get; set; }
    }
}
