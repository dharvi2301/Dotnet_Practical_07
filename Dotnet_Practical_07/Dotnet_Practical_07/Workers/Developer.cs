using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Workers
{
    public class Developer:IWork
    {
        /// <summary>
        /// Simulates developer's work.
        /// </summary>
        public void Work() => Console.WriteLine("ISP>>>> This is Developer Work.");
    }
}
