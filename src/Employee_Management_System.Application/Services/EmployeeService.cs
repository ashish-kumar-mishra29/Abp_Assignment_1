using Employee_Management_System.Dtos;
using Employee_Management_System.Interfaces;
using Employee_Management_System.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Linq;

namespace Employee_Management_System.Services
{
    public class EmployeeService : CrudAppService<Employee, EmployeeDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEmployeeDto>, IEmployeeService
    {
        private readonly IRepository<Employee, Guid> _repository;
        private readonly IAsyncQueryableExecuter _asyncExecuter;

        public EmployeeService(IRepository<Employee, Guid> repository, IAsyncQueryableExecuter asyncExecuter) : base(repository)
        {
            _repository = repository;
            _asyncExecuter = asyncExecuter;
            /*GetPolicyName = Employee_Management_SystemPermissions.Employees.Default;
            GetListPolicyName = Employee_Management_SystemPermissions.Employees.Default;
            CreatePolicyName = Employee_Management_SystemPermissions.Employees.Create;
            UpdatePolicyName = Employee_Management_SystemPermissions.Employees.Edit;
            DeletePolicyName = Employee_Management_SystemPermissions.Employees.Delete;*/
        }
        public async Task<List<Employee>> GetEmployeesAsync(string name)
        {
            var details = await _repository.GetQueryableAsync();
            var query = details
               .Where(e => e.Name.Contains(name));
            List<Employee> employeeName = await _asyncExecuter.ToListAsync(query);

            return (employeeName);
        }

    }

}
