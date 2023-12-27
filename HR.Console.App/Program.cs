using HR.Business.Services;

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













}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Incorrect Passsword or Username\n" +
                      "");
    Console.ResetColor();
    goto Start;
}