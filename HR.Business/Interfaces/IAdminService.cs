using System;
namespace HR.Business.Interfaces;

public interface IAdminService
{
    public void ShowAllDeactivateCompany();
    public void ShowAllDeactivateDepartment();
    public void ShowAllDeactivateEmployee();
    public void ActivateCompany(string? name);
    public void ActivateDepartment(int? departID);
    public void ActivateEmployee(int? EmployeeID);
}

