using ConsoleApp1.Interfaces;
using ConsoleApp1.Liskov;
using ConsoleApp1.Models;
using ConsoleApp1.Notifications;
using ConsoleApp1.Services;
using ConsoleApp1.Types;
using ConsoleApp1.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // SRP Example
            Employee emp = new Employee { Name = "John", Position = "Developer", Salary = 60000 };
            SalaryCalculator salaryCalculator = new SalaryCalculator();
            ReportGenerator reportGenerator = new ReportGenerator();
            Console.WriteLine("SRP Example>>>> Calculate Salary " + salaryCalculator.CalculateSalary(emp));
            Console.WriteLine(reportGenerator.GenerateReport(emp));

            // OCP Example
            EmployeeBase fullTime = new FullTimeEmployee { Name = "Alice" };
            Console.WriteLine("OCP Example>>>> " + fullTime.Name + " Salary: " + fullTime.GetSalary());
            EmployeeBase contractBase = new ContractEmployee { Name = "Bob" };
            Console.WriteLine("OCP Example>>>> " + contractBase.Name + " Salary: " + contractBase.GetSalary());

            // LSP Example
            EmployeeBase manager = new Manager { Name = "Ruskin" };
            Console.WriteLine("LSP Example>>>> " + manager.Name + " Salary: " + manager.GetSalary());
            EmployeeBase intern = new Intern { Name = "Vandna" };
            Console.WriteLine("LSP Example>>>> " + intern.Name + " Salary: " + intern.GetSalary());

            // ISP Example
            IWork dev = new Developer();
            dev.Work();
            IManage teamLead = new TeamLead();
            teamLead.Manage();

            //DIP Example
            IEmailNotifier notifier = new EmailNotifier();
            HRService hrService = new HRService(notifier);
            hrService.NotifyEmployee("Welcome to the company!");

            Console.ReadLine();
        }
    }
}
