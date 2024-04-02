using AutoMapper;
using Employee_Management_System.Dtos;

namespace Employee_Management_System;

public class Employee_Management_SystemApplicationAutoMapperProfile : Profile
{
    public Employee_Management_SystemApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Employee, EmployeeDto>();
        CreateMap<CreateUpdateEmployeeDto, Employee>();

        CreateMap<Department, DepartmentDto>();
        CreateMap<CreateUpdateDepartmentDto, Department>();


    }
}
