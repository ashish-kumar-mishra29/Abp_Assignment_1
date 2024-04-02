using Employee_Management_System.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Employee_Management_System.Interfaces
{
    public interface IEmployeeService : ICrudAppService
        <
        EmployeeDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateEmployeeDto
        >
    {
    }
}
