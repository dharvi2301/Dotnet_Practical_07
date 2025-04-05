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
        /// <summary>
        /// Abstract method to get salary. Must be implemented by derived classes.
        /// </summary>
        public abstract double GetSalary();
    }
}
