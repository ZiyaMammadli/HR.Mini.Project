using System;
using HR.Business.Interfaces;
using HR.DataAccess.Contexts;

namespace HR.Business.Services;

public class AdminService : IAdminService
{
    public void ShowAllDeactivateCompany()
    {
        foreach (var company in HRDbContext.dbCompanies)
        {
            if (company.IsActivate == false)
            {
                Console.WriteLine($"Company | ID :{company.Id} | Name :{company.Name} |");
            }
        }
    }

    public void ShowAllDeactivateDepartment()
    {
        foreach (var department in HRDbContext.dbDepartments)
        {
            if (department.IsActivated == false)
            {
                Console.WriteLine(department);
            }
        }
    }

    public void ShowAllDeactivateEmployee()
    {
        foreach (var employee in HRDbContext.dbEmployees)
        {
            if (employee.IsActivate == false)
            {
                Console.WriteLine(employee);
            }
        }
    }
}

