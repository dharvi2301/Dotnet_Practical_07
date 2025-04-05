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
        public void Work() => Console.WriteLine("ISP>>>> Working in Team");
        public void Manage() => Console.WriteLine("ISP>>>> Managing the task");
    }
}
