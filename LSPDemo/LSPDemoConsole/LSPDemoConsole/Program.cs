// See https://aka.ms/new-console-template for more information

using LSPDemoConsole.Abstract;
using LSPDemoConsole.Implementation;
using LSPDemoConsole.Interface;

List<Employee> employees = new List<Employee>();
employees.Add(new PermanentEmployee(1, "John"));
employees.Add(new TemporaryEmployee(2, "Jason"));
//Un Comment to see the error
//employees.Add(new ContractEmployee(3, "Mike"));
foreach (var employee in employees)
{
    Console.WriteLine(string.Format("Employee {0} Bonus: {1} MinSalary: {2}",
    employee.ToString(),
    employee.CalculateBonus(100000).ToString(),
    employee.GetMinimumSalary().ToString()));
}

Console.WriteLine();

List<IEmployee> employeesOnly = new List<IEmployee>();

employeesOnly.Add(new PermanentEmployee(1, "John"));
employeesOnly.Add(new TemporaryEmployee(2, "Jason"));
employeesOnly.Add(new ContractEmployee(3, "Mike"));

foreach (var employee in employeesOnly)
{
    Console.WriteLine(string.Format("Employee {0}  MinSalary: {1}",
    employee.ToString(),
    employee.GetMinimumSalary().ToString()));
}

Console.WriteLine();

IEmployee employee1 = new ContractEmployee(4, "Anuj");
Console.WriteLine(string.Format("Employee {0}  MinSalary: {1}",
    employee1.ToString(), employee1.GetMinimumSalary().ToString()));

Console.ReadLine();