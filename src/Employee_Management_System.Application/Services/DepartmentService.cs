using Employee_Management_System.Dtos;
using Employee_Management_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Employee_Management_System.Services
{
    public class DepartmentService : CrudAppService<Department, DepartmentDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateDepartmentDto>, IDepartmentService
    {
        public DepartmentService(IRepository<Department, Guid> repository) : base(repository)
        {
        }
    }
}
