﻿using System;
using System.Xml.Linq;
using HR.Business.Interfaces;
using HR.Business.Utilities.Exceptions;
using HR.Core.Entities;
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

    public void ActivateCompany(string name)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentNullException();
        Company? dbcompany=HRDbContext.dbCompanies.Find(c => c.Name.ToLower() == name.ToLower());
        if (dbcompany is null) throw new NotFoundException($"{name} is not found");
        dbcompany.IsActivate = true;
    }

    public void ActivateDepartment(int? departID)
    {
        if (departID is null) throw new ArgumentNullException();
        Department? dbdepartment = HRDbContext.dbDepartments.Find(c => c.Id == departID);
        if (dbdepartment is null) throw new NotFoundException($"{departID} is not found");
        dbdepartment.IsActivated = true;
    }

    public void ActivateEmployee(int? EmployeeID)
    {
        if (EmployeeID is null) throw new ArgumentNullException();
        Employee? dbemployee = HRDbContext.dbEmployees.Find(c => c.Id == EmployeeID);
        if (dbemployee is null) throw new NotFoundException($"{EmployeeID} is not found");
        dbemployee.IsActivate = true;
    }
}
