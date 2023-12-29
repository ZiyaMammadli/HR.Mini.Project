using System;
namespace HR.Business.Utilities.Helper
{
    public enum Menu
    {
        Create_company = 1,                 //Company
        Deactive_Company,
        Get_all_department_inCompany,
        Show_all_company,
        Find_company_with_id,//_________________________
        Create_department,             //Department
        Deactive_department,
        Add_employee_to_department,
        Update_department,
        Get_employees_inDepartment,
        Show_department_details,
        Show_all_departments,//_________________________
        Create_employee,               //Employee
        Deactive_employee,
        Show_all_employees,
        Change_department,
        Update_Employee_Salary,//____________________________
        Open_Admin_panel,                //Admin
        Quit                             //Quit
    }                          
}
public enum SalaryMenu
{
    increase = 1,
    decrease
}
public enum AdminMenu
{
    Show_all_deactivate_company=1,
    Activate_company,
    Show_all_deactivate_department,
    Activate_department,
    Show_all_deaactivate_employee,
    Activate_employee,
    Exit_and_go_menu,
    Quit_project
}