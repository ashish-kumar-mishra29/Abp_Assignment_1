using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace Employee_Management_System.Interfaces
{
    public interface IHrService : IApplicationService , IScopedDependency
    {
    }
}
