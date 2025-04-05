using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Notifications
{
    public interface IEmailNotifier
    {
        void Notify(string message);
    }
}
