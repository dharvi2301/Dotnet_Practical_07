using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    public class SalaryCalculator
    {
        /// <summary>
        /// Calculates the salary of the given employee.
        /// </summary>
        public double CalculateSalary(Employee employee)
        {
            return employee.Salary;
        }
    }
}
