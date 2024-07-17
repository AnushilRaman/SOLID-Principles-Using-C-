// See https://aka.ms/new-console-template for more information
using OpenClosedDemo;
using OpenClosedDemo.Client;

Employee employeePerm = new PermanentEmployee(1,"Permanent");
Employee employeeTemp = new TemporaryEmployee(2,"Temporary");

Console.WriteLine(string.Format("Empolyee {0} Bonus {1}", 
    employeePerm.ToString(), employeePerm.CalculateBonus(100000).ToString()));

Console.WriteLine(string.Format("Empolyee {0} Bonus {1}", 
    employeeTemp.ToString(), employeeTemp.CalculateBonus(150000).ToString()));

Console.ReadLine();


