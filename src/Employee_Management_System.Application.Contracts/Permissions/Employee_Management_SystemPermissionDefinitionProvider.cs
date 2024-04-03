using Employee_Management_System.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Employee_Management_System.Permissions;

public class Employee_Management_SystemPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Employee_Management_SystemPermissions.GroupName, L("Permission:Employee_Management_System"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Employee_Management_SystemPermissions.MyPermission1, L("Permission:MyPermission1"));
        /*var booksPermission = myGroup.AddPermission(Employee_Management_SystemPermissions.Employees.Default, L("Permission:Books"));
        booksPermission.AddChild(Employee_Management_SystemPermissions.Employees.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(Employee_Management_SystemPermissions.Employees.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(Employee_Management_SystemPermissions.Employees.Delete, L("Permission:Books.Delete"));
        var employee = context.AddGroup("Employee");
        var hr = employee.AddPermission("HR", L("Permission:HR"));
        var admin = employee.AddPermission("ADMIN", L("Permission:ADMIN"));*/
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Employee_Management_SystemResource>(name);
    }
}
