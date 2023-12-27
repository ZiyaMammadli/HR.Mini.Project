using System;
using HR.Business.Interfaces;
using HR.Business.Utilities.Exceptions;
using HR.Core.Entities;
using HR.DataAccess.Contexts;

namespace HR.Business.Services;

public class EmployeeService : IEmployeeService
{
    private IDepartmentService departmentService { get; }
    public EmployeeService()
    {
        departmentService = new DepartmentService();
    }
    public void ChangeDepartment(int? departID, int? employeeId)
    {
        if (employeeId is null) throw new ArgumentNullException();
        Employee? Dbemploye = HRDbContext.dbEmployees.Find(c => c.Id == employeeId);
        if (Dbemploye is null) throw new NotFoundException($"{employeeId} is not found");
        if (departID is null) throw new ArgumentNullException();
        Department? dbdepartment = HRDbContext.dbDepartments.Find(b => b.Id == departID);
        if (dbdepartment is null) throw new NotFoundException($"{departID} is not found");
        foreach (var department in HRDbContext.dbDepartments)
        {
            if (Dbemploye.DepartmentId == department.Id)
            {
                department.CurrentEmployee--;
            }
        }
        Dbemploye.DepartmentId = dbdepartment.Id;
        dbdepartment.CurrentEmployee++;
        departmentService.ShowDepartmentDetails(departID);
    }

    public void Create(string? name, string? surname, int? salary)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentNullException();
        if (salary is null) throw new ArgumentNullException();
        Employee employe = new Employee(name, surname, salary);
        HRDbContext.dbEmployees.Add(employe);
        employe.IsActivate = true;
    }

    public void Deactive(int? id)
    {
        throw new NotImplementedException();
    }

    public void DecreaseEmployeeSalary(int? employeeId, int? decreaseSalary)
    {
        throw new NotImplementedException();
    }

    public void ShowAll()
    {
        throw new NotImplementedException();
    }

    public void İncreaseEmployeeSalary(int? employeeId, int? increaseSalary)
    {
        throw new NotImplementedException();
    }
}

