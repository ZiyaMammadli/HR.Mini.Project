using System;
using HR.Business.Interfaces;
using HR.Business.Utilities.Exceptions;
using HR.Core.Entities;
using HR.DataAccess.Contexts;

namespace HR.Business.Services;

public class DepartmentService : IDepartmentService
{
    private ICompanyService companyservice { get; }
    public DepartmentService()
    {
        companyservice = new CompanyService();
    }
    public void AddEmployee(int? employeeId, int? departId)
    {
        if (employeeId is null) throw new ArgumentNullException();
        Employee? dbEmploye = HRDbContext.dbEmployees.Find(c => c.Id == employeeId);
        if (dbEmploye is null) throw new NotFoundException($"{employeeId} is not found");
        if (departId is null) throw new ArgumentNullException();
        Department? dbdepartment = HRDbContext.dbDepartments.Find(b => b.Id == departId);
        if (dbdepartment is null) throw new NotFoundException($"{departId} is not found");
        if (dbdepartment.CurrentEmployee < dbdepartment.EmployeeLimit)
        {
            if (dbEmploye.DepartmentId == null)
            {
                dbEmploye.DepartmentId = dbdepartment.Id;
                dbdepartment.CurrentEmployee++;
            }
            else
            {
                throw new AlreadyWorkOtherDepartment("This Employee already works in another Department");
            }
        }
        else
        {
            throw new MaxCapacityAxceeded("Maximum Employee capacity exceeded");
        }
    }

    public void Create(string? name, int? employeelimit, int companyid)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentNullException();
        Department? dbdepartment = HRDbContext.dbDepartments.Find(c => c.Name.ToLower() == name.ToLower());
        if (dbdepartment?.CompanyId == companyid) throw new AlreadyExistException($"{name} already is exist");
        if (employeelimit is null) throw new ArgumentNullException();
        if (employeelimit > 6) throw new MaxCapacityAxceeded("Maximum capacity can be 6 employees");
        companyservice.FindCompanyWithId(companyid);
        Department department = new Department(name, companyid, employeelimit);
        HRDbContext.dbDepartments.Add(department);
        department.IsActivated = true;
    }

    public void Deactive(int? id)
    {
        throw new NotImplementedException();
    }

    public void GetDepartmentEmployees(int? id)
    {
        throw new NotImplementedException();
    }

    public void ShowAll()
    {
        throw new NotImplementedException();
    }

    public void ShowDepartmentDetails(int? id)
    {
        throw new NotImplementedException();
    }

    public void UpdateDepartment(int? departId, string? newName, int employeeLimit)
    {
        throw new NotImplementedException();
    }
}

