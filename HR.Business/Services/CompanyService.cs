using System;
using HR.Business.Interfaces;
using HR.Business.Utilities.Exceptions;
using HR.Core.Entities;
using HR.DataAccess.Contexts;

namespace HR.Business.Services;

public class CompanyService : ICompanyService
{
    public void Create(string name)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentNullException();
        Company? dbcompany = HRDbContext.dbCompanies.Find(b => b.Name.ToLower() == name.ToLower());
        if (dbcompany is not null) throw new AlreadyExistException($"{dbcompany} already is exist");
        Company company = new Company(name);
        HRDbContext.dbCompanies.Add(company);
        company.IsActivate = true;
    }

    public void Deactive(string? name)
    {
        throw new NotImplementedException();
    }

    public void FindCompanyWithId(int? id)
    {
        throw new NotImplementedException();
    }

    public void GetAllDepartment(string? name)
    {
        throw new NotImplementedException();
    }

    public void ShowAll()
    {
        throw new NotImplementedException();
    }

    public void ShowAllCompanyId()
    {
        throw new NotImplementedException();
    }
}

