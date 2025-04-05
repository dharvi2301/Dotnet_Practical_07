using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Types
{
    public class ContractEmployee:EmployeeBase
    {
        public override double GetSalary() => 30000;
    }
}
