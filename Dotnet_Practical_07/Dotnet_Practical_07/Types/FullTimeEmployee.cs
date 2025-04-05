using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Types
{
    public class FullTimeEmployee:EmployeeBase
    {
        /// <summary>
        /// Returns fixed salary for a full-time employee.
        /// </summary>
        public override double GetSalary() => 50000;
       
    }
}
