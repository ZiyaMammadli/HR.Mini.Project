﻿using HR.Business.Services;

CompanyService companyService = new();
DepartmentService departmentService = new();
EmployeeService employeservice = new();
string Username = "ziya";
string Password = "zm040";
bool control = true;
Start:
Console.WriteLine("Enter username:");
string? username = Convert.ToString(Console.ReadLine());
Console.WriteLine("Enter password");
string? password = Convert.ToString(Console.ReadLine());
if (username == Username && password == Password)
{
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Welcome to HR project\n" +
                     "");
    Console.ResetColor();
    while (control == true)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("<<< COMPANY >>>\n" +
                      "1.Create new Company\n" +
                      "2.Deactivate Company\n" +
                      "3.Show all the departments of the your selected Company\n" +
                      "4.Show all Companies\n" +
                      "5.Find Company with own ID\n" +
                      "\n" +
                      "\n" +
                      "<<< Department >>>\n" +
                      "6.Create new Department\n" +
                      "7.Deactivate Department\n" +
                      "8.Add new Employees to your selected Department\n" +
                      "9.Update your selected Department\n" +
                      "10.Show Employees in your selected Department\n" +
                      "11.Show Department details\n" +
                      "12.Show all Departments\n" +
                      "\n" +
                      "\n" +
                      "<<< Employee >>>\n" +
                      "13.Create new Employee\n" +
                      "14.Deactivate Employee\n" +
                      "15.Show all Employees\n" +
                      "16.Change the Employee's Department\n" +
                      "17.Update Employee salary\n" +
                      "18.Quit\n");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Please enter the serial number of your chosen process:");
        Console.ResetColor();
        string? optionn = Console.ReadLine();
        bool checkParse = int.TryParse(optionn, out int option);
        Console.ForegroundColor = ConsoleColor.Red;
        if (checkParse == false) Console.WriteLine("\n" +
                                                   "<<<< Only number should be entered. >>>>\n" +
                                                   ""); ;
        Console.ResetColor();
        if (option <= 18 && option > 0)
        {




        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Numbers from 0 to 18 (18 inclusive) must be entered.\n");
            Console.ResetColor();
        }
    }
}       
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Incorrect Passsword or Username\n" +
                      "");
    Console.ResetColor();
    goto Start;
}