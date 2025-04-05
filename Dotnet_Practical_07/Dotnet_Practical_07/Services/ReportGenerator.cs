using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    public class ReportGenerator
    {
        public string GenerateReport(Employee employee)
        {
            return $"SRP Example>>>> Name:{employee.Name} ,Position:{employee.Position}, Salary:{employee.Salary}";
        }
    }
}
