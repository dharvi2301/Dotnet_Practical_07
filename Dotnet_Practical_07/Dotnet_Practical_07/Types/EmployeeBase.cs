using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Types
{
    public abstract class EmployeeBase
    {
        public string Name { get; set; }
        public abstract double GetSalary();
    }
}
