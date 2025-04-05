using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Workers
{
    public class TeamLead:IWork,IManage
    {
        /// <summary>
        /// Simulates team lead's work.
        /// </summary>
        public void Work() => Console.WriteLine("ISP>>>> Working in Team");
        /// <summary>
        /// Simulates team lead's management responsibilities.
        /// </summary>
        public void Manage() => Console.WriteLine("ISP>>>> Managing the task");
    }
}
