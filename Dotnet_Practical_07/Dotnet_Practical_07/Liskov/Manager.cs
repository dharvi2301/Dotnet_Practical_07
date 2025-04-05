using ConsoleApp1.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Liskov
{
    public class Manager : EmployeeBase
    {
        public override double GetSalary() => 70000;
    }

}
