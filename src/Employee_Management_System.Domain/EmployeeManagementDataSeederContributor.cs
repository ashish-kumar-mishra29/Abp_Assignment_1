using System;
using System.Threading.Tasks;

using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;

namespace Employee_Management_System;

public class EmployeeDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Employee, Guid> _employeeRepository;
    private readonly IdentityRoleManager _identyRoleManager;
    private readonly IdentityUserManager _identityUserManager;

    public EmployeeDataSeederContributor(IRepository<Employee, Guid> employeeRepository, IdentityRoleManager identyRoleManager, IdentityUserManager identityUserManager)
    {
        _employeeRepository = employeeRepository;
        _identyRoleManager = identyRoleManager;
        _identityUserManager = identityUserManager;

    }

    public async Task SeedAsync(DataSeedContext context)
    {
        var role = await _identyRoleManager.FindByNameAsync("HR");

        if(role == null)
        {
            await _identyRoleManager.CreateAsync(new IdentityRole(Guid.NewGuid(), "HR"));
        }
        IdentityUser user = new IdentityUser(Guid.NewGuid(), "HR", "hr@gmail.com");
        await _identityUserManager.CreateAsync(user, "Test123*");
        await _identityUserManager.AddToRoleAsync(user, "HR");
    }
}

