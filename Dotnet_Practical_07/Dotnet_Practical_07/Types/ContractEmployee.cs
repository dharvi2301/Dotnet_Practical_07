using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Types
{
    public class ContractEmployee:EmployeeBase
    {
        /// <summary>
        /// Returns fixed salary for a contract employee.
        /// </summary>
        public override double GetSalary() => 30000;
    }
}
